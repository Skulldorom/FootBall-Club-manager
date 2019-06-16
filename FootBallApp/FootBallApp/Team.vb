Public Class Team
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim a, max As Integer

    Sub filltable()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"


        con.Open()
        sql = "SELECT * FROM LineUp"
        da = New OleDb.OleDbDataAdapter(sql, con)
        Dim DBDT As New DataTable
        da.Fill(DBDT)
        con.Close()
        LineUpDataGridView.DataSource = DBDT

    End Sub
    Private Sub Team_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        filltable()

        RecDown.Enabled = False
        '
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM Members"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "Members")
        con.Close()
        '
        max = ds.Tables("Members").Rows.Count
        max -= 1
        GetData()
    End Sub

    Sub GetData()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM Members"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "Members")
        con.Close()

        TextBox1.Text = ds.Tables("Members").Rows(a).Item(0)
        Dim FullNameString As String

        FullNameString = ds.Tables("Members").Rows(a).Item(1)
        FullNameString += " "
        FullNameString += ds.Tables("Members").Rows(a).Item(2)
        TextBox2.Text = FullNameString

        TextBox3.Text = ds.Tables("Members").Rows(a).Item(7)

    End Sub

    Sub senddata()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "INSERT INTO LineUp Values (?,?,?)"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDb.OleDbParameter("ID", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Full Name", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Position", CType(TextBox3.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            filltable()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub RecUP_Click(sender As Object, e As EventArgs) Handles RecUp.Click
        a += 1

        If a = max Then
            RecUp.Enabled = False
        Else
            RecDown.Enabled = True
            RecUp.Enabled = True
        End If
        GetData()
    End Sub

    Private Sub AddPlayer_Click(sender As Object, e As EventArgs) Handles AddPlayer.Click
        senddata()
    End Sub

    Private Sub RemovePlayer_Click(sender As Object, e As EventArgs) Handles RemovePlayer.Click
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "Delete from [LineUp] where [ID] = " & TextBox1.Text & ""
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            filltable()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub RecDown_Click(sender As Object, e As EventArgs) Handles RecDown.Click
        a -= 1

        If a = 0 Then
            RecDown.Enabled = False
            RecUp.Enabled = True
        ElseIf a <> max Then
            RecUP.Enabled = True
        End If
        GetData()
    End Sub
End Class