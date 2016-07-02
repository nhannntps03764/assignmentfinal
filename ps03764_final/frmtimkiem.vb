Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmTimKiem
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=DESKTOP-704RL6O;Initial Catalog=Final_ps03764;Integrated Security=True"
    ' Dim chuoiketnoi As String = "workstation id=nhannntps03764.mssql.somee.com;packet size=4096;user id=danhthien260280;pwd=01663409420;data source=nhannntps03764.mssql.somee.com;persist security info=False;initial catalog=nhannntps03764"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Databaseaccess As New DataBaseAccess
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', EMAIL as 'Email', DIACHI from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvTIMKIEM.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub Searchcustommer(value As String)
        'Dim sqlquery As String = String.Format("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', SDT as 'Sdt', DIACHI from KHACHHANG")
        '  If cmbTRACUU.SelectedIndex = 0 Then
        'sqlquery += String.Format("where MAKH like N'{0}%'", value)
        '  ElseIf cmbTRACUU.SelectedIndex = 1 Then
        '  sqlquery += String.Format("where TENKH LIKE N'{0}%'", value)
        '  End If
        '  Dim dtable As DataTable = Databaseaccess.GetDataTable(sqlquery)
        ' dgvTIMKIEM.DataSource = dtable
        ' With dgvTIMKIEM
        '.Columns(0).HeaderText = "Mã KH"
        ' .Columns(1).HeaderText = "Tên Khách Hàng"
        ' .Columns(2).HeaderText = "Sdt"
        ' .Columns(3).HeaderText = "DIA CHI"

        ' End With

        Dim sqlQuery As String = String.Format("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', EMAIL as 'Email', DIACHI from KHACHHANG")
        If cmbTRACUU.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MaKH like '{0}%'", value)
        ElseIf cmbTRACUU.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TENKH LIKE N'{0}%'", value)
        ElseIf cmbTRACUU.SelectedIndex = 2 Then
            sqlQuery += String.Format(" where DIACHI LIKE N'{0}%'", value)
        ElseIf cmbTRACUU.SelectedIndex = 3 Then
            sqlQuery += String.Format(" where EMAIL LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        dgvTIMKIEM.DataSource = data
        With dgvTIMKIEM
            .Columns(0).HeaderText = "Mã KH"
            .Columns(1).HeaderText = "Tên Khách Hàng"
            .Columns(2).HeaderText = "Địa Chỉ"
            .Columns(3).HeaderText = "Email"
        End With
    End Sub




    Private Sub txtTIMKIEM_TextChanged(sender As Object, e As EventArgs) Handles txtTIMKIEM.TextChanged
        Searchcustommer(txtTIMKIEM.Text)

    End Sub

    Private Sub frmTimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub dgvTIMKIEM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTIMKIEM.CellContentClick

    End Sub

    Private Sub cmbTRACUU_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTRACUU.SelectedIndexChanged

    End Sub
End Class