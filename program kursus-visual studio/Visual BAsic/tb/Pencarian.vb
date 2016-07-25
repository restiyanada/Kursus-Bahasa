Imports System.Data.OleDb
Public Class Pencarian
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
    End Sub
    Private Sub TextBox1_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()

            CMD = New OleDbCommand("Select * from registrasi where nama='" & TextBox1.Text & "'", Con)
            rd = CMD.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox2.Focus()
            Else
                TextBox2.Text = rd.Item("ID_pendaftaran")
                TextBox3.Text = rd.Item("no_telp")
                TextBox4.Text = rd.Item("E_mail")
                TextBox5.Text = rd.Item("usia")
                TextBox6.Text = rd.Item("cabang")
                TextBox7.Text = rd.Item("hari")
                TextBox8.Text = rd.Item("jadwal_kursus")
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class