<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pendaftaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pendaftaran))
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxTelepon = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.ComboBoxUsia = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCabang = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(59, 57)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxNama.TabIndex = 0
        Me.TextBoxNama.Text = "Nama"
        '
        'TextBoxTelepon
        '
        Me.TextBoxTelepon.Location = New System.Drawing.Point(59, 83)
        Me.TextBoxTelepon.Name = "TextBoxTelepon"
        Me.TextBoxTelepon.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxTelepon.TabIndex = 1
        Me.TextBoxTelepon.Text = "Telepon"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(59, 109)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxEmail.TabIndex = 2
        Me.TextBoxEmail.Text = "Email"
        '
        'ComboBoxUsia
        '
        Me.ComboBoxUsia.FormattingEnabled = True
        Me.ComboBoxUsia.Items.AddRange(New Object() {"4-6", "7-10", "11-13", "14-17", "18+"})
        Me.ComboBoxUsia.Location = New System.Drawing.Point(60, 135)
        Me.ComboBoxUsia.Name = "ComboBoxUsia"
        Me.ComboBoxUsia.Size = New System.Drawing.Size(153, 21)
        Me.ComboBoxUsia.TabIndex = 3
        Me.ComboBoxUsia.Text = "Usia"
        '
        'ComboBoxCabang
        '
        Me.ComboBoxCabang.FormattingEnabled = True
        Me.ComboBoxCabang.Items.AddRange(New Object() {"Banda Aceh - Jl. Angsa", "Banda Aceh - Jl. Dipenogoro", "Bandung - Jl. Antapani", "Bandung - Jl. BKR", "Bandung - Jl. Peta", "Bekasi - Jl. Kranji", "Bekasi - Jl. Pemuda", "Bekasi - Galaxy Mall", "Bogor - Jl. Raya Puncak", "Bogor - Jl. Ir.H.Juanda", "Cilacap - Jl. Sudirman", "Cilacap - Jl. Soekarno", "Cilegon - Jl. Krakatau", "Denpasar - Kuta", "Depok - Jl. Margonda", "Jakarta - Pondok Indah Mall", "Jakarta - Plaza Indonesia", "Jakarta - Kelapa Gading", "Jakarta - Jl. Cikini", "Jayapura - Jl. Soekarno", "Lampung - Jl. Apel", "Makassar - Jl. Matim", "Malang - Jl. Ngalam", "Medan - Jl. Kota", "Padang - Jl. Pop", "Palembang - Jl. Lambang", "Samarinda - Jl. Brokoli", "Surabaya - Jl. Mangga", "Tangerang - Jl. Sriwijaya", "Yogyakarta - Jl. Malioboro"})
        Me.ComboBoxCabang.Location = New System.Drawing.Point(60, 162)
        Me.ComboBoxCabang.Name = "ComboBoxCabang"
        Me.ComboBoxCabang.Size = New System.Drawing.Size(153, 21)
        Me.ComboBoxCabang.TabIndex = 4
        Me.ComboBoxCabang.Text = "Cabang"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(357, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(80, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DAFTAR SEKARANG"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(357, 306)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxCabang)
        Me.Controls.Add(Me.ComboBoxUsia)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxTelepon)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pendaftaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pendaftaran"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTelepon As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxUsia As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxCabang As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
