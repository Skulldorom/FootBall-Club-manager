Public Class AddMember
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql, sql1 As String
    Dim a, max As Integer
    Dim RoleString, PositionString, GenderString, Fullname, Injurystring As String
    Private Sub AddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Position.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub coach_CheckedChanged(sender As Object, e As EventArgs) Handles coach.CheckedChanged
        If coach.Checked Then
            Position.Enabled = False
            s1.Checked = False
            m1.Checked = False
            d1.Checked = False
            g1.Checked = False
            RoleString = "Coach"
            PositionString = "NA"
        End If
    End Sub

    Private Sub Player_CheckedChanged(sender As Object, e As EventArgs) Handles Player.CheckedChanged
        If Player.Checked Then
            Position.Enabled = True
            s1.Checked = True
            RoleString = "Player"
        End If
    End Sub

    Private Sub EmailGen_Click(sender As Object, e As EventArgs) Handles EmailGen.Click
        Dim firstletter As Char
        firstletter = FnameTXT.Text.Substring(0, 1)
        etxt.Text = firstletter + LNametxt.Text + "@usiu.ac.ke"
    End Sub

    Private Sub s1_CheckedChanged(sender As Object, e As EventArgs) Handles s1.CheckedChanged
        PositionString = "Striker"
    End Sub

    Private Sub m1_CheckedChanged(sender As Object, e As EventArgs) Handles m1.CheckedChanged
        PositionString = "MidFeilder"
    End Sub

    Private Sub d1_CheckedChanged(sender As Object, e As EventArgs) Handles d1.CheckedChanged
        PositionString = "Defender"
    End Sub

    Private Sub g1_CheckedChanged(sender As Object, e As EventArgs) Handles g1.CheckedChanged
        PositionString = "Goal Keeper"
    End Sub

    Private Sub IDtxt_TextChanged(sender As Object, e As EventArgs) Handles IDtxt.TextChanged

    End Sub

    Private Sub gendertxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gendertxt.SelectedIndexChanged
        If gendertxt.Text = "Male" Then
            GenderString = "Male"
        ElseIf gendertxt.Text = "Female" Then
            GenderString = "Female"
        Else
            GenderString = "Other"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IDtxt.BackColor = Color.White
        FnameTXT.BackColor = Color.White
        LNametxt.BackColor = Color.White
        agetxt.BackColor = Color.White
        etxt.BackColor = Color.White
        BTtxt.BackColor = Color.White

        Dim x As Integer = 0
        If IDtxt.Text = "" Then
            IDtxt.BackColor = Color.OrangeRed
            x = 1
        End If
        If FnameTXT.Text = "" Then
            FnameTXT.BackColor = Color.OrangeRed
            x = 1
        End If
        If LNametxt.Text = "" Then

            LNametxt.BackColor = Color.OrangeRed
            x = 1
        End If
        If agetxt.Text = "0" Then

            agetxt.BackColor = Color.OrangeRed
            x = 1
        End If
        If etxt.Text = "" Then

            etxt.BackColor = Color.OrangeRed
            x = 1
        End If
        If BTtxt.Text = "" Then
            BTtxt.BackColor = Color.OrangeRed
            x = 1
        End If
        If EDtxt.Text = "" Then
            EDtxt.Text = "NA"
        End If
        If x <> 0 Then

            MessageBox.Show("Error:" & vbCrLf & "Missing Information")
            Exit Sub
        End If
        ' output
        'Dim disp As String
        'disp = IDtxt.Text
        'disp += FnameTXT.Text
        'disp += LNametxt.Text
        'disp += GenderString
        'disp += agetxt.Value.ToString
        'disp += datetxt.Value
        'disp += RoleString
        'disp += PositionString
        'disp += etxt.Text
        'disp += BTtxt.Text
        'disp += EDtxt.Text
        'MessageBox.Show(disp)
        Fullname = FnameTXT.Text & " " & LNametxt.Text
        Injurystring = "No"
        sendMembers()
    End Sub

    Sub sendMembers()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "INSERT INTO Members Values (?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDb.OleDbParameter("ID", CType(IDtxt.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("First Name", CType(FnameTXT.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Last Name", CType(LNametxt.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Gender", CType(GenderString, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Age", CType(agetxt.Value.ToString, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Join Date", CType(datetxt.Value.ToShortDateString, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Role", CType(RoleString, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Position", CType(PositionString, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Email", CType(etxt.Text, String)))

        sql1 = "INSERT INTO MedicalDetails Values (?,?,?,?,?,?,?)"
        Dim cmd1 As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql1, con)
        cmd1.Parameters.Add(New OleDb.OleDbParameter("ID", CType(IDtxt.Text, String)))
        cmd1.Parameters.Add(New OleDb.OleDbParameter("Full Name", CType(Fullname, String)))
        cmd1.Parameters.Add(New OleDb.OleDbParameter("Blood Type", CType(BTtxt.Text, String)))
        cmd1.Parameters.Add(New OleDb.OleDbParameter("Age", CType(agetxt.Value.ToString, String)))
        cmd1.Parameters.Add(New OleDb.OleDbParameter("Sex", CType(GenderString, String)))
        cmd1.Parameters.Add(New OleDb.OleDbParameter("Injured", CType(Injurystring, String)))
        cmd1.Parameters.Add(New OleDb.OleDbParameter("Extra Details", CType(EDtxt.Text, String)))


        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cmd1.ExecuteNonQuery()
            cmd1.Dispose()
            con.Close()
            MessageBox.Show("Record Added")
            Me.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try


    End Sub

End Class