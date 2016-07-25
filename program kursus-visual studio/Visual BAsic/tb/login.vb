Imports System.Data.OleDb
Public Class login
    Dim con As OleDbConnection
    Dim com As OleDbCommand
    Dim read As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim lokasidb As String
    Sub Koneksi()
        lokasidb = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Login.accdb"
        con = New OleDbConnection(lokasidb)
        If con.State = ConnectionState.Closed Then con.Open()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pendaftaran.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("data login tidak lengkap")
            Exit Sub
        Else
            Call Koneksi()
            com = New OleDbCommand("select * from login where ID_Login='" & TextBox1.Text & "' and Pass_Login='" & TextBox2.Text & "'", con)
            read = com.ExecuteReader
            read.Read()
            If read.HasRows Then
                Me.Close()
                index.Show()
                index.DaftarToolStripMenuItem.Visible = False
                index.LoginToolStripMenuItem.Visible = False
                index.LogoutToolStripMenuItem.Visible = True
                index.PencarianJadwalToolStripMenuItem.Visible = True
                index.BookingToolStripMenuItem.Visible = True
            Else
                MsgBox("Username atau Password salah")
            End If
        End If
    End Sub
End Class