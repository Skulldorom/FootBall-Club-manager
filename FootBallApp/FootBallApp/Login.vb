Public Class Login
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql, UsernameString, PasswordString As String
    Dim a, max As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For a = 0 To max
            UsernameString = ds.Tables("CoachLogin").Rows(a).Item(0)
            PasswordString = ds.Tables("CoachLogin").Rows(a).Item(1)
            If UserName.Text = UsernameString Then

                If Password.Text = PasswordString Then
                    Admin.Show()
                    Me.Close()
                    Exit Sub

                End If
            End If
        Next
        MessageBox.Show("Wrong User Name or Password")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Sub GetData()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM CoachLogin"
        da = New OleDb.OleDbDataAdapter(Sql, con)

        da.Fill(ds, "CoachLogin")
        con.Close()
        max = ds.Tables("CoachLogin").Rows.Count
        max -= 1
    End Sub
End Class