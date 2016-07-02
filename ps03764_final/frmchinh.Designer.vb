<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmchinh))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ThôngTinKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinKháchHàngToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrìnhDuyệtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiảiTríToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinKháchHàngToolStripMenuItem, Me.TrìnhDuyệtToolStripMenuItem, Me.GiảiTríToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(353, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ThôngTinKháchHàngToolStripMenuItem
        '
        Me.ThôngTinKháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinKháchHàngToolStripMenuItem1, Me.TìmKháchHàngToolStripMenuItem})
        Me.ThôngTinKháchHàngToolStripMenuItem.Image = Global.ps03764_final.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_2_Personal_information
        Me.ThôngTinKháchHàngToolStripMenuItem.Name = "ThôngTinKháchHàngToolStripMenuItem"
        Me.ThôngTinKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ThôngTinKháchHàngToolStripMenuItem.Text = "Khách Hàng"
        '
        'ThôngTinKháchHàngToolStripMenuItem1
        '
        Me.ThôngTinKháchHàngToolStripMenuItem1.Image = Global.ps03764_final.My.Resources.Resources.Dario_Arnaez_Genesis_3G_User_Files
        Me.ThôngTinKháchHàngToolStripMenuItem1.Name = "ThôngTinKháchHàngToolStripMenuItem1"
        Me.ThôngTinKháchHàngToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.ThôngTinKháchHàngToolStripMenuItem1.Text = "Thông tin khách hàng"
        '
        'TìmKháchHàngToolStripMenuItem
        '
        Me.TìmKháchHàngToolStripMenuItem.Image = Global.ps03764_final.My.Resources.Resources.Jommans_Mushroom_Search
        Me.TìmKháchHàngToolStripMenuItem.Name = "TìmKháchHàngToolStripMenuItem"
        Me.TìmKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.TìmKháchHàngToolStripMenuItem.Text = "Tìm khách hàng"
        '
        'TrìnhDuyệtToolStripMenuItem
        '
        Me.TrìnhDuyệtToolStripMenuItem.BackgroundImage = Global.ps03764_final.My.Resources.Resources.images
        Me.TrìnhDuyệtToolStripMenuItem.Image = Global.ps03764_final.My.Resources.Resources.images
        Me.TrìnhDuyệtToolStripMenuItem.Name = "TrìnhDuyệtToolStripMenuItem"
        Me.TrìnhDuyệtToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.TrìnhDuyệtToolStripMenuItem.Text = "Trình duyệt"
        '
        'GiảiTríToolStripMenuItem
        '
        Me.GiảiTríToolStripMenuItem.Image = CType(resources.GetObject("GiảiTríToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GiảiTríToolStripMenuItem.Name = "GiảiTríToolStripMenuItem"
        Me.GiảiTríToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.GiảiTríToolStripMenuItem.Text = "Giải trí"
        '
        'frmchinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ps03764_final.My.Resources.Resources.global_business_23_2147506554
        Me.ClientSize = New System.Drawing.Size(353, 376)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmchinh"
        Me.Text = "frmchinh"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ThôngTinKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinKháchHàngToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TìmKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrìnhDuyệtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GiảiTríToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
