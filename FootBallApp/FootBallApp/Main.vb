Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MemBTn_Click(sender As Object, e As EventArgs) Handles MemBTn.Click
        Member.MdiParent = Me
        AddMember.MdiParent = Me
        Member.Show()
    End Sub

    Private Sub TBtn_Click(sender As Object, e As EventArgs) Handles TBtn.Click
        Team.MdiParent = Me
        Team.Show()
    End Sub

    Private Sub MBtn_Click(sender As Object, e As EventArgs) Handles MBtn.Click
        Match.MdiParent = Me
        MatchCalender.MdiParent = Me
        Match.Show()
    End Sub

    Private Sub AboBtn_Click(sender As Object, e As EventArgs) Handles AboBtn.Click
        MessageBox.Show("About Us:" & vbCrLf & "This is a sports club within United States International University." & vbCrLf & "For any Issues/Technical Support Contact us: adesa@usiu.ac.ke")
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = TimeOfDay
        DateLBl.Text = DateString
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Login.MdiParent = Me
        Login.Show()
        Medical.MdiParent = Me
        Admin.MdiParent = Me
        AccountHandler.MdiParent = Me
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        AccountHandler.Close()
        AddMember.Close()
        Admin.Close()
        Login.Close()
        Match.Close()
        MatchCalender.Close()
        Medical.Close()
        Member.Close()
        Team.Close()
    End Sub
End Class
