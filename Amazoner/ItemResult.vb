Public Class ItemResult
  


    Private mTitle As String
    Private mAuthor As String
    Private mASIN As String
    Private mAssociateLink As String
    Private mImage As Image
    Private mImageUrl As String
    Private mISBN As String

    Public Function MakeImageLink() As String
        Const template As String = " <A href=""$URL$""><IMG src=$SRC$ border=0\></A>"
        Dim html As String = template.Replace("$SRC$", ImageUrl)
        html = html.Replace("$URL$", AssociateLink)
        Return html
    End Function

    Public Function MakeTitleLink() As String
        Const template As String = " <A href=""$URL$"">$Title$</A>"
        Dim html As String = template.Replace("$Title$", Title)
        html = html.Replace("$URL$", AssociateLink)
        Return html
    End Function

    Public Function MakeTitleAndImageLink()
        Const template As String = " <P align=center><A href=""$URL$""><IMG src=$SRC$ border=0\><br>$Title$</A></P>"
        Dim html As String = template.Replace("$SRC$", ImageUrl)
        html = html.Replace("$Title$", Title)
        html = html.Replace("$URL$", AssociateLink)
        Return html
    End Function



    Property ISBN()
        Get
            Return mISBN
        End Get
        Set(ByVal value)
            mISBN = value
        End Set
    End Property
    Public Property Author() As String
        Get
            Return mAuthor
        End Get
        Set(ByVal value As String)
            mAuthor = value
        End Set
    End Property
    Public Property ImageUrl() As String
        Get
            Return mImageUrl
        End Get
        Set(ByVal value As String)
            mImageUrl = value
        End Set
    End Property

    Public Property ASIN() As String
        Get
            Return mASIN
        End Get
        Set(ByVal value As String)
            mASIN = value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return mTitle
        End Get
        Set(ByVal value As String)
            mTitle = value
        End Set
    End Property

    Public Property Image() As Image
        Get
            Return mImage
        End Get
        Set(ByVal value As Image)
            mImage = value
        End Set
    End Property



    Public Property AssociateLink() As String
        Get
            Return mAssociateLink
        End Get
        Set(ByVal value As String)
            mAssociateLink = value
        End Set
    End Property
End Class
