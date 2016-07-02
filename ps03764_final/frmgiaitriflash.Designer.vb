<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgiaitriflash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmgiaitriflash))
        Me.btngame = New System.Windows.Forms.Button()
        Me.btntimhinh = New System.Windows.Forms.Button()
        Me.btnnhac = New System.Windows.Forms.Button()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btngame
        '
        Me.btngame.Location = New System.Drawing.Point(575, 125)
        Me.btngame.Name = "btngame"
        Me.btngame.Size = New System.Drawing.Size(114, 23)
        Me.btngame.TabIndex = 3
        Me.btngame.Text = "Game"
        Me.btngame.UseVisualStyleBackColor = True
        '
        'btntimhinh
        '
        Me.btntimhinh.Location = New System.Drawing.Point(575, 80)
        Me.btntimhinh.Name = "btntimhinh"
        Me.btntimhinh.Size = New System.Drawing.Size(114, 23)
        Me.btntimhinh.TabIndex = 4
        Me.btntimhinh.Text = "Tìm hình"
        Me.btntimhinh.UseVisualStyleBackColor = True
        '
        'btnnhac
        '
        Me.btnnhac.Location = New System.Drawing.Point(575, 34)
        Me.btnnhac.Name = "btnnhac"
        Me.btnnhac.Size = New System.Drawing.Size(114, 23)
        Me.btnnhac.TabIndex = 5
        Me.btnnhac.Text = "Nhạc"
        Me.btnnhac.UseVisualStyleBackColor = True
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(8, 10)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(561, 515)
        Me.AxShockwaveFlash1.TabIndex = 6
        '
        'frmgiaitriflash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ps03764_final.My.Resources.Resources.Untitled_11
        Me.ClientSize = New System.Drawing.Size(777, 573)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.btngame)
        Me.Controls.Add(Me.btntimhinh)
        Me.Controls.Add(Me.btnnhac)
        Me.Name = "frmgiaitriflash"
        Me.Text = "frmgiaitriflash"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btngame As System.Windows.Forms.Button
    Friend WithEvents btntimhinh As System.Windows.Forms.Button
    Friend WithEvents btnnhac As System.Windows.Forms.Button
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
