﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvTIMKIEM = New System.Windows.Forms.DataGridView()
        Me.txtTIMKIEM = New System.Windows.Forms.TextBox()
        Me.cmbTRACUU = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvTIMKIEM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTIMKIEM
        '
        Me.dgvTIMKIEM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTIMKIEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTIMKIEM.Location = New System.Drawing.Point(40, 74)
        Me.dgvTIMKIEM.Name = "dgvTIMKIEM"
        Me.dgvTIMKIEM.Size = New System.Drawing.Size(607, 272)
        Me.dgvTIMKIEM.TabIndex = 7
        '
        'txtTIMKIEM
        '
        Me.txtTIMKIEM.Location = New System.Drawing.Point(272, 47)
        Me.txtTIMKIEM.Name = "txtTIMKIEM"
        Me.txtTIMKIEM.Size = New System.Drawing.Size(379, 20)
        Me.txtTIMKIEM.TabIndex = 6
        '
        'cmbTRACUU
        '
        Me.cmbTRACUU.FormattingEnabled = True
        Me.cmbTRACUU.Items.AddRange(New Object() {"Mã Khách Hàng", "Tên Khách Hàng", "Sdt", "Địa Chỉ"})
        Me.cmbTRACUU.Location = New System.Drawing.Point(145, 47)
        Me.cmbTRACUU.Name = "cmbTRACUU"
        Me.cmbTRACUU.Size = New System.Drawing.Size(121, 21)
        Me.cmbTRACUU.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(37, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tìm Kiếm Thông Tin"
        '
        'frmTimKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ps03764_final.My.Resources.Resources.Untitled_11
        Me.ClientSize = New System.Drawing.Size(730, 431)
        Me.Controls.Add(Me.dgvTIMKIEM)
        Me.Controls.Add(Me.txtTIMKIEM)
        Me.Controls.Add(Me.cmbTRACUU)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTimKiem"
        Me.Text = "frmtimkiem"
        CType(Me.dgvTIMKIEM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTIMKIEM As System.Windows.Forms.DataGridView
    Friend WithEvents txtTIMKIEM As System.Windows.Forms.TextBox
    Friend WithEvents cmbTRACUU As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
