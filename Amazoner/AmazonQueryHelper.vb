Imports Amazoner.Amazon.WebServices.ECommerce
Imports System.ComponentModel

Public Class AmazonQueryHelper
    Public Function RunQuery(ByVal titleSearchText As String, _
                            ByVal worker As BackgroundWorker, _
                            ByVal associateID As String, _
                            ByVal AWSAccessKey As String) _
                                                        As List(Of ItemResult)
        mAssociateID = associateID
        mAWS_AccessKeyID = AWSAccessKey
        mTitleSearchText = titleSearchText

        Dim service As New AWSECommerceService()
        Dim searchData As ItemSearch = CreateSearchQuery()

        worker.ReportProgress(10, "Querying service...")
        Dim response As ItemSearchResponse = Nothing

        Try
            response = service.ItemSearch(searchData)

            If Not response.OperationRequest.Errors Is Nothing Then
                HadError = True
                LastError = getAllErrors(response)
                worker.ReportProgress(50, "Error!")
                Return New List(Of ItemResult)
            End If

            worker.ReportProgress(20, "Loading results...")

            If response.Items Is Nothing Then
                worker.ReportProgress(100, "No items found.")
                Return New List(Of ItemResult)
            End If
        Catch ex As Exception
            worker.ReportProgress(100, "Error!" & vbNewLine & ex.ToString())
            Return New List(Of ItemResult)
        End Try

        Dim results As List(Of ItemResult) = GetResultsFromResponse(response, worker)
        Return results
    End Function


    Private Function getAllErrors(ByVal response As ItemSearchResponse) As String

        Dim result As New System.Text.StringBuilder
        For i As Integer = 0 To response.OperationRequest.Errors.Length - 1
            result.Append(response.OperationRequest.Errors(i).Message)
            result.Append(vbNewLine)
            result.Append("---------------")
            result.Append(vbNewLine)
        Next
        Return result.ToString
    End Function
    Private mAWS_AccessKeyID As String
    Private mTitleSearchText As String
    Private mAssociateID As String

    Private Function CreateSearchQuery() As ItemSearch
        Dim searchData As New ItemSearch()
        searchData.AWSAccessKeyId = mAWS_AccessKeyID
        searchData.Request = New ItemSearchRequest() {New ItemSearchRequest()}

        With searchData.Request(0)
            .Title = mTitleSearchText
            .SearchIndex = "Books"
            .ResponseGroup = New String() {ImageSize, "Images", "ItemAttributes"}
        End With
        Return searchData
    End Function

    Private mImageSize As String = "Small"
    Public Property ImageSize() As String
        Get
            Return mImageSize
        End Get
        Set(ByVal value As String)
            mImageSize = value
        End Set
    End Property


    Private Function GetResultsFromResponse(ByVal response As ItemSearchResponse, ByVal worker As BackgroundWorker) As List(Of ItemResult)
        Dim results As New List(Of ItemResult)
        Dim iter As IEnumerator = response.Items.GetEnumerator()
        Dim progress As Integer = 0
        While (iter.MoveNext)
            Dim items As Items = CType(iter.Current, Items)
            If items.TotalResults = 0 Then
                Continue While
            End If
            For itemIndex As Integer = 0 To items.Item.Length - 1
                progress += 10
                If progress >= 100 Then progress = 99
                worker.ReportProgress(progress, "Loading item " & itemIndex + 1 & "..")
                Dim it As Item = items.Item(itemIndex)
                Dim result As ItemResult = CreateResultFromItem(it)
                results.Add(result)
            Next
        End While
        Return results
    End Function

    Private Function CreateResultFromItem(ByVal it As Item) As ItemResult
        Dim result As New ItemResult
        result.Title = it.ItemAttributes.Title
        result.ASIN = it.ASIN
        result.Author = getAuthors(it)
        result.AssociateLink = (makeLink(it))
        result.ISBN = it.ItemAttributes.ISBN
        setImageData(it, result)
        Return result
    End Function

    Private Function getNoResultsItem() As ItemResult
        Dim it As New ItemResult
        it.Title = "No results!"
        Return it
    End Function
    Private Function setImageData(ByVal it As Item, ByVal result As ItemResult) As System.Drawing.Image
        Dim webClient1 As New Net.WebClient
        Try
            'find out which image to download
            Dim img As Image = Nothing
            'If Not it.LargeImage Is Nothing Then img = it.LargeImage
            If img Is Nothing Then
                If Not it.MediumImage Is Nothing Then img = it.MediumImage
                If img Is Nothing Then
                    If Not it.SmallImage Is Nothing Then img = it.SmallImage
                End If
            End If
            ' Download the Data into a Byte().

            If img Is Nothing Then Return Nothing
            Dim data() As Byte = webClient1.DownloadData(img.URL)
            Dim st As New System.IO.MemoryStream(data)
            Dim imgData As System.Drawing.Image = System.Drawing.Image.FromStream(st)
            result.Image = imgData
            result.ImageUrl = img.URL
            Return imgData
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Private Function makeLink(ByVal it As Item) As String
        'example: http://www.amazon.com/exec/obidos/ASIN/0131177052/iserializable-20
        Const templateURL As String = "http://www.amazon.com/exec/obidos/ASIN/$ASIN$/$ID$-20"
        Dim url As String = templateURL.Replace("$ASIN$", it.ASIN)
        url = url.Replace("$ID$", mAssociateID)
        Return url
    End Function
    Private Function getAuthors(ByVal it As Item) As String
        Dim authors As String = ""
        If it.ItemAttributes.Author Is Nothing Then Return String.Empty

        For Each author As String In it.ItemAttributes.Author
            authors &= author & ", "
        Next
        authors = authors.TrimEnd(" ")
        authors = authors.TrimEnd(",")
        Return authors
    End Function

    Public Sub New()

    End Sub

    Public Property HadError() As Boolean
        Get
            Return mHadError
        End Get
        Set(ByVal value As Boolean)
            mHadError = value
        End Set
    End Property

    Public Property LastError() As String
        Get
            Return mLastError
        End Get
        Set(ByVal value As String)
            mLastError = value
        End Set
    End Property
    Private mHadError As Boolean
    Private mLastError As String
End Class
