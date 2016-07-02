Public Class frmdangnhap

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtuser.Text = Nothing And txtpass.Text = Nothing Then
            MsgBox("Hãy nhập user và password", MsgBoxStyle.Critical)

            Exit Sub
        End If
        If txtuser.Text = "admin" And txtpass.Text = "12345" Then
            MsgBox("Đăng nhập thành công........!!!!", MsgBoxStyle.Information)
            frmchinh.ShowDialog()

            Me.Hide()



        Else
            MsgBox("Xin vui lòng thử lại", MsgBoxStyle.Critical)
        End If
    End Sub
End Class