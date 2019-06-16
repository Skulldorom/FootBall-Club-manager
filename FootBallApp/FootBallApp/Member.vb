Public Class Member
    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filltable()
    End Sub
    Sub filltable()
        Dim con As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"


        con.Open()
        sql = "SELECT * FROM Members"
        da = New OleDb.OleDbDataAdapter(sql, con)
        Dim DBDT As New DataTable
        da.Fill(DBDT)
        con.Close()
        DataGridView1.DataSource = DBDT

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddMember.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        filltable()
    End Sub
End Class