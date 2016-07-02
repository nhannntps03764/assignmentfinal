Imports System.IO
Public Class frmgiaitriflash

    Private Sub btnnhac_Click(sender As Object, e As EventArgs) Handles btnnhac.Click
        AxShockwaveFlash1.Movie = "https://www.youtube.com/v/9t9IhVM_zEg"
    End Sub

    Private Sub btntimhinh_Click(sender As Object, e As EventArgs) Handles btntimhinh.Click
        If Not Directory.Exists("C:\Users\" & Environment.UserName & "\Documents\jyrka98") Then
            Directory.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\jyrka98")
        End If
        Try
            IO.File.WriteAllBytes("C:\Users\" & Environment.UserName & "\Documents\jyrka98\flash.swf", My.Resources.flash)
            AxShockwaveFlash1.Movie = "C:\Users\" & Environment.UserName & "\Documents\jyrka98\flash.swf"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btngame_Click(sender As Object, e As EventArgs) Handles btngame.Click
        If Not Directory.Exists("C:\Users\" & Environment.UserName & "\Documents\jyrka98") Then
            Directory.CreateDirectory("C:\Users\" & Environment.UserName & "\Documents\jyrka98")
        End If
        Try
            IO.File.WriteAllBytes("C:\Users\" & Environment.UserName & "\Documents\jyrka98\flash.swf", My.Resources.flappy_bird_mouse)
            AxShockwaveFlash1.Movie = "C:\Users\" & Environment.UserName & "\Documents\jyrka98\flash.swf"
        Catch ex As Exception
        End Try
    End Sub
End Class