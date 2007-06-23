Imports Amazoner.Amazon.WebServices.ECommerce
Imports System.Net
Public Class MainForm
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Load, MyBase.Load, MyBase.Load, MyBase.Load



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DoSearch()
    End Sub

    Private Sub DoSearch()

        If Not My.Computer.Network.IsAvailable Then
            MsgBox("You are not connected to the internet. Please connect and try again.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "No Internet Connection")
            Return
        End If

        Button1.Enabled = False
        pbQuery.Value = 0
        pbQuery.Visible = True
        lblStatus.Visible = True
        lblStatus.Text = "Querying.."
        mQUeryResults = New List(Of ItemResult)
        ItemResultBindingSource.DataSource = mQUeryResults
        QueryWorker.RunWorkerAsync()


    End Sub




    Private Sub ItemResultDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemResultDataGridView.CellDoubleClick
    End Sub

    Private Sub BrowseToCurrentItem()
        Dim it As ItemResult = getCurrenItmResultData()
        Process.Start(it.AssociateLink)
    End Sub

    Private Function dataExists() As Boolean
        Return Not ItemResultBindingSource.Current Is Nothing
    End Function
    Private Function getCurrenItmResultData() As ItemResult
        If ItemResultBindingSource.Count = 0 Then Return Nothing

        Return CType(ItemResultBindingSource.Current, ItemResult)
    End Function

    Private Sub CopyTitleaslinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyTitleaslinkToolStripMenuItem.Click
        CopyTitleAsLink()
    End Sub

    Private Sub CopybothtitleandimageaslinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopybothtitleandimageaslinkToolStripMenuItem.Click
        CopyTitleAndImageAsLink()

    End Sub

    Private Sub CopyimageaslinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyimageaslinkToolStripMenuItem.Click
        CopyImageAsLink()
    End Sub

    Private Sub copy(ByVal html As String)
        Dim dao As New DataObject(html)

        dao.SetData(DataFormats.Html, html)
        dao.SetData(DataFormats.Text, html)
        dao.SetData(DataFormats.UnicodeText, html)

        Clipboard.SetDataObject(dao)
    End Sub
    Private Sub CopyImageAsLink()
        Dim it As ItemResult = getCurrenItmResultData()
        If it Is Nothing Then Return
        copy(it.MakeImageLink())
    End Sub

    Private Sub CopyTitleAsLink()
        Dim it As ItemResult = getCurrenItmResultData()
        If it Is Nothing Then Return
        copy(it.MakeTitleLink())
    End Sub

    Private Sub CopyTitleAndImageAsLink()
        Dim it As ItemResult = getCurrenItmResultData()
        If it Is Nothing Then Return
        copy(it.MakeTitleAndImageLink())
    End Sub

    Private Sub ItemResultDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemResultDataGridView.CellContentClick

    End Sub

    Private Sub QueryWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles QueryWorker.DoWork
        startQueryWork()
    End Sub


    Private Sub startQueryWork()
        Dim helper As New AmazonQueryHelper
        Dim results As List(Of ItemResult) = helper.RunQuery(TextBox1.Text, QueryWorker, txtAssociateID.Text, My.Settings.AWS_AccessKeyID)
        If helper.HadError Then
            QueryWorker.ReportProgress(99, "Error:" & helper.LastError)
            Return
        End If
        mQUeryResults = results
        QueryWorker.ReportProgress(100, "done")
    End Sub

    Private Sub QueryWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles QueryWorker.ProgressChanged
        pbQuery.Value = e.ProgressPercentage
        lblStatus.Text = e.UserState.ToString()

        If e.UserState.ToString().ToLower().StartsWith("error") Then
            MsgBox(e.UserState.ToString(), MsgBoxStyle.Exclamation, "Error querying service")
        End If

    End Sub

    Private mQUeryResults As List(Of ItemResult)
    Private Sub QueryWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles QueryWorker.RunWorkerCompleted
        ItemResultBindingSource.DataSource = mQUeryResults
        pbQuery.Value = 0
        pbQuery.Visible = False
        lblStatus.Visible = False
        Button1.Enabled = True

    End Sub

    Private Sub CopybooktitleaslinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopybooktitleaslinkToolStripMenuItem.Click
        CopyTitleAsLink()
    End Sub

    Private Sub CopybookimageaslinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopybookimageaslinkToolStripMenuItem.Click
        CopyImageAsLink()
    End Sub

    Private Sub CopybothaslinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopybothaslinkToolStripMenuItem.Click
        CopyTitleAndImageAsLink()
    End Sub

    Private Sub BrowsetoitemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowsetoitemToolStripMenuItem.Click
        BrowseToCurrentItem()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutAmazonerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutAmazonerToolStripMenuItem.Click
        ShowAbout()
    End Sub


    Private Sub ShowAbout()
        Dim box As New AboutBox()
        box.ShowDialog(Me)
    End Sub

    Private Sub ChangeAmazoneWSCredientialsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeAmazoneWSCredientialsToolStripMenuItem.Click
        ChangeAmazonCredentials()
    End Sub


    Private Sub ChangeAmazonCredentials()
        Dim newCredentials As String = InputBox("Please enter your Amazon WS Access Key (Not your secret key!)", "Web Service Credentials", Settings.Default.AWS_AccessKeyID)
        If newCredentials <> String.Empty And _
            newCredentials <> My.Settings.AWS_AccessKeyID _
            Then

            My.Settings.AWS_AccessKeyID = newCredentials
            My.Settings.Save()

        End If
    End Sub

    Private Sub RoysBlogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoysBlogToolStripMenuItem.Click
        BrowseTo("http://www.ISerializable.com")
    End Sub


    Private Sub BrowseTo(ByVal url As String)
        Process.Start(url)
    End Sub

    Private Sub TeamAgileshomepageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeamAgileshomepageToolStripMenuItem.Click
        BrowseTo("http://www.TeamAgile.com")
    End Sub
End Class
