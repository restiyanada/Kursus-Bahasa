Public Class index
    Sub Terkunci()
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        PencarianJadwalToolStripMenuItem.Visible = True
        BookingToolStripMenuItem.Visible = False
        DaftarToolStripMenuItem.Visible = True
    End Sub
    Private Sub TahunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallToolStripMenuItem.Click
        SmallStars.MdiParent = Me
        SmallStars.Show()
        highflyer.Close()
        trailblazers.Close()
        frontrunner.Close()
        Pendaftaran.Close()
    End Sub

    Private Sub HighToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighToolStripMenuItem2.Click
        highflyer.MdiParent = Me
        highflyer.Show()
        SmallStars.Close()
        trailblazers.Close()
        frontrunner.Close()
        Pendaftaran.Close()
    End Sub

    Private Sub TrailToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrailToolStripMenuItem3.Click
        trailblazers.MdiParent = Me
        trailblazers.Show()
        SmallStars.Close()
        highflyer.Close()
        frontrunner.Close()
        Pendaftaran.Close()
    End Sub

    Private Sub FrontToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrontToolStripMenuItem1.Click
        frontrunner.MdiParent = Me
        frontrunner.Show()
        SmallStars.Close()
        highflyer.Close()
        trailblazers.Close()
        Pendaftaran.Close()
    End Sub

    Private Sub SmartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DaftarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarToolStripMenuItem.Click
        Pendaftaran.MdiParent = Me
        Pendaftaran.Show()
    End Sub

    Private Sub BandungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Terkunci()

        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        PencarianJadwalToolStripMenuItem.Visible = True
        BookingToolStripMenuItem.Visible = False
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub LoginToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        login.MdiParent = Me
        login.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub DataMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataMemberToolStripMenuItem.Click
        Data_Member.MdiParent = Me
        Data_Member.Show()
    End Sub

    Private Sub PencarianJadwalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PencarianJadwalToolStripMenuItem.Click
        Pencarian.MdiParent = Me
        Pencarian.Show()
    End Sub
End Class
