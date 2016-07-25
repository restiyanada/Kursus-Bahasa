Imports System.Data.OleDb
Public Class Pendaftaran
    Dim Con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim CMD As OleDbCommand
    Dim Lokasidb As String
    Dim rd As OleDbDataReader
    Sub Koneksi()
        Lokasidb = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Login.accdb"
        Con = New OleDbConnection(Lokasidb)
    End Sub
    Private Sub Pendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Tambah As String = "Insert Into Registrasi(Nama, No_Telp, E_mail, Usia, Cabang, Jadwal_Kursus) Values('" & TextBoxNama.Text & "','" & TextBoxTelepon.Text & "','" & TextBoxEmail.Text & "','" & ComboBoxUsia.Text & "','" & ComboBoxCabang.Text & "','00-00-0000')"
        Try
            Call Koneksi()
            Using cmd As New OleDbCommand(Tambah, Con)
                Con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Terima Kasih Sudah Mendaftar", MsgBoxStyle.Information, "Perhatian")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Jadwal.TextBox6.Text = TextBoxNama.Text
        Jadwal.TextBox2.Text = TextBoxTelepon.Text
        Jadwal.TextBox3.Text = TextBoxEmail.Text
        Jadwal.TextBox4.Text = ComboBoxUsia.Text
        Jadwal.TextBox5.Text = ComboBoxCabang.Text
        Jadwal.Show()
        Me.Close()
    End Sub
End Class