<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KursusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrailToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PencarianJadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KursusToolStripMenuItem, Me.DaftarToolStripMenuItem, Me.PencarianJadwalToolStripMenuItem, Me.BookingToolStripMenuItem, Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KursusToolStripMenuItem
        '
        Me.KursusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmallToolStripMenuItem, Me.HighToolStripMenuItem2, Me.TrailToolStripMenuItem3, Me.FrontToolStripMenuItem1})
        Me.KursusToolStripMenuItem.Name = "KursusToolStripMenuItem"
        Me.KursusToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.KursusToolStripMenuItem.Size = New System.Drawing.Size(54, 19)
        Me.KursusToolStripMenuItem.Text = "Kursus"
        '
        'SmallToolStripMenuItem
        '
        Me.SmallToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem"
        Me.SmallToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SmallToolStripMenuItem.Text = "&Small Stars 4-6"
        '
        'HighToolStripMenuItem2
        '
        Me.HighToolStripMenuItem2.Name = "HighToolStripMenuItem2"
        Me.HighToolStripMenuItem2.Size = New System.Drawing.Size(172, 22)
        Me.HighToolStripMenuItem2.Text = "&High Flyers 7-9 "
        '
        'TrailToolStripMenuItem3
        '
        Me.TrailToolStripMenuItem3.Name = "TrailToolStripMenuItem3"
        Me.TrailToolStripMenuItem3.Size = New System.Drawing.Size(172, 22)
        Me.TrailToolStripMenuItem3.Text = "&Trailblazers 10-13"
        '
        'FrontToolStripMenuItem1
        '
        Me.FrontToolStripMenuItem1.Name = "FrontToolStripMenuItem1"
        Me.FrontToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.FrontToolStripMenuItem1.Text = "&Frontrunner 14-17 "
        '
        'DaftarToolStripMenuItem
        '
        Me.DaftarToolStripMenuItem.Name = "DaftarToolStripMenuItem"
        Me.DaftarToolStripMenuItem.Size = New System.Drawing.Size(51, 19)
        Me.DaftarToolStripMenuItem.Text = "Daftar"
        '
        'PencarianJadwalToolStripMenuItem
        '
        Me.PencarianJadwalToolStripMenuItem.Name = "PencarianJadwalToolStripMenuItem"
        Me.PencarianJadwalToolStripMenuItem.Size = New System.Drawing.Size(109, 19)
        Me.PencarianJadwalToolStripMenuItem.Text = "Pencarian Jadwal"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMemberToolStripMenuItem})
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(63, 19)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'DataMemberToolStripMenuItem
        '
        Me.DataMemberToolStripMenuItem.Name = "DataMemberToolStripMenuItem"
        Me.DataMemberToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataMemberToolStripMenuItem.Text = "Data Member"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 19)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 19)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(771, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PUSAT BELAJAR BAHASA INGGRIS DI INDONESIA" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(610, 360)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "index"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KursusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrailToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrontToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PencarianJadwalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
