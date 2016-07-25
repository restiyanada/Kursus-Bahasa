Imports System.Data.OleDb
Public Class Jadwal
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
    Private Sub Jadwal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Kode admin 6 Digit dan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim edit As String = "update registrasi set hari='" & ComboBox1.Text & "',jadwal_kursus='" & ComboBox2.Text & "' where nama='" & TextBox6.Text & "'"
            CMD = New OleDbCommand(edit, Con)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Edit", MsgBoxStyle.Information, "Information")
        End If
    End Sub
    Private Sub TextBox6_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
       
            CMD = New OleDbCommand("Select * from registrasi where nama='" & TextBox6.Text & "'", Con)
            rd = CMD.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                TextBox1.Text = ""
                TextBox1.Focus()
            Else
                TextBox1.Text = rd.Item("ID_pendaftaran")
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class