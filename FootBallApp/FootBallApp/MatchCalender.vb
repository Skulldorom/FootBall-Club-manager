Public Class MatchCalender
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles CloseBTn.Click
        Me.Close()
    End Sub

    Private Sub MatchCalender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sql = "SELECT * FROM Matchs"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        Dim DBDT As New DataTable
        da.Fill(DBDT)
        con.Close()
        DataGridView1.DataSource = DBDT

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filltable()
    End Sub
End Class