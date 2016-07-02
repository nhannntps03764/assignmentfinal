Imports System.Data.SqlClient
Public Class Class1
    Public Function Loadkhachang() As DataSet
        'Dim chuoiketnoi As String = "workstation id=nhannntps03764.mssql.somee.com;packet size=4096;user id=danhthien260280;pwd=01663409420;data source=nhannntps03764.mssql.somee.com;persist security info=False;initial catalog=nhannntps03764"
        Dim chuoiketnoi As String = "Data Source=DESKTOP-704RL6O;Initial Catalog=Final_ps03764;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', EMAIL as 'Email', DIACHI from KHACHHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
