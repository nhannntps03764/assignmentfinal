Public Class frmtrinhduyet
    Private MyCollection As New Collection
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.WebBrowser1.GoBack()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.WebBrowser1.GoForward()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.WebBrowser1.Navigate(txttiemkiem.Text)
        MyCollection.Add(txttiemkiem.Text)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim url As String = ""
        For i As Integer = 1 To MyCollection.Count
            url += MyCollection.Item(i) + vbCrLf
        Next
        MessageBox.Show(url, "Lịch sử", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class