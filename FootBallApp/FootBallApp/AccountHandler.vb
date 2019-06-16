Public Class AccountHandler
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql, UsernameString, Passwordstring As String
    Dim a, max, acno As Integer



    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        For a = 0 To max
            UsernameString = ds.Tables("CoachLogin").Rows(a).Item(0)

            If UsernameConfirmtxt.Text = UsernameString Then
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                acno = a

                Exit Sub
            End If
        Next
        MessageBox.Show("Incorrect Username")
    End Sub

    Private Sub AccountHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GetData()
        max = ds.Tables("CoachLogin").Rows.Count
        max -= 1
    End Sub

    Sub GetData()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM CoachLogin"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "CoachLogin")
        con.Close()

    End Sub

    Private Sub AddBTn_Click(sender As Object, e As EventArgs) Handles AddBTn.Click
        If P1txt.Text <> Cp1txt.Text Then
            P1txt.BackColor = Color.OrangeRed
            Cp1txt.BackColor = Color.OrangeRed
            MessageBox.Show("Error passwords don't match")
            Exit Sub
        End If
        senddata()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Passwordstring = ds.Tables("CoachLogin").Rows(acno).Item(1)
        If Optxt.Text <> Passwordstring Then
            Optxt.BackColor = Color.OrangeRed
            MessageBox.Show("Old Password incorrect")
            Exit Sub
        End If
        If Nptxt.Text <> CP2txt.Text Then
            Nptxt.BackColor = Color.OrangeRed
            CP2txt.BackColor = Color.OrangeRed
            MessageBox.Show("Error passwords don't match")
            Exit Sub
        End If
        updateinfo()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Sub senddata()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "INSERT INTO CoachLogin Values (?,?)"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)

        cmd.Parameters.Add(New OleDb.OleDbParameter("Username", CType(Utxt.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Password", CType(P1txt.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MessageBox.Show("Account Created")
            Me.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
        GetData()
    End Sub

    Sub updateinfo()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        Dim str As String
        str = "Update [CoachLogin] set [Password] = '" & Nptxt.Text & "' Where [Username] = '" & UsernameString & "'"
        Dim cmd = New OleDb.OleDbCommand(str, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MessageBox.Show("Password Updated")
            Me.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class