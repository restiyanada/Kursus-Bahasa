Imports System.Data.OleDb
Public Class Data_Member
    Dim Con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim CMD As OleDbCommand
    Dim Lokasidb As String
    Dim rd As OleDbDataReader
    Sub Koneksi()
        Lokasidb = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Login.accdb"
        Con = New OleDbConnection(Lokasidb)
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
    End Sub
    Sub dbtutup()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub
    Sub bersih()
        Koneksi()
        da = New OleDbDataAdapter("Select * from registrasi", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "regis")
        DataGridView1.DataSource = (ds.Tables("regis"))
    End Sub
    Private Sub TextBox5_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()

            CMD = New OleDbCommand("Select * from registrasi where nama='" & TextBox5.Text & "'", Con)
            rd = CMD.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                TextBoxNama.Text = ""
                TextBoxEmail.Text = ""
                TextBoxTelepon.Text = ""
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBoxNama.Focus()
            Else
                TextBoxNama.Text = rd.Item("ID_pendaftaran")
                TextBoxTelepon.Text = rd.Item("no_telp")
                TextBoxEmail.Text = rd.Item("E_mail")
                TextBox1.Text = rd.Item("usia")
                TextBox2.Text = rd.Item("cabang")
                TextBox3.Text = rd.Item("hari")
                TextBox4.Text = rd.Item("jadwal_kursus")
                TextBoxNama.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBoxEmail.Text = "" Or TextBoxNama.Text = "" Or TextBoxTelepon.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim edit As String = "update registrasi set no_telp='" & TextBoxTelepon.Text & "',E_mail='" & TextBoxEmail.Text & "',usia='" & TextBox1.Text & "',cabang='" & TextBox2.Text & "',hari='" & TextBox3.Text & "',jadwal_kursus='" & TextBox4.Text & "' where nama='" & TextBox5.Text & "'"
            CMD = New OleDbCommand(edit, Con)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Ubah", MsgBoxStyle.Information, "Information")
            Call bersih()
        End If
    End Sub

    Private Sub Data_Member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersih()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Kode admin 6 Digit dan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "DELETE FROM registrasi WHERE registrasi.E_mail = '" & TextBoxEmail.Text & "'"
                CMD = New OleDbCommand(hapus, Con)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil di Hapus", MsgBoxStyle.Information, "Information")
                Call bersih()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class