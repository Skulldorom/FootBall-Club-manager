Imports System.IO
Public Class Match
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql, Statustxt As String
    Dim a, max As Integer
    Sub Match_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disabled while working
        'AddBTn.Enabled = False
        'DeleteBtn.Enabled = False

        RowDIsp.Text = a
        RecDown.Enabled = False
        '
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM Matchs"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "Matchs")
        con.Close()
        '
        max = ds.Tables("Matchs").Rows.Count
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
        sql = "SELECT * FROM Matchs"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "Matchs")
        con.Close()

        TextBox1.Text = ds.Tables("Matchs").Rows(a).Item(0)
        TextBox2.Text = ds.Tables("Matchs").Rows(a).Item(1)
        DateTimePicker1.Text = ds.Tables("Matchs").Rows(a).Item(2)
        Statustxt = ds.Tables("Matchs").Rows(a).Item(3)
        ComboBox1.Text = Statustxt

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Win" Then
            Statustxt = "Win"
        ElseIf ComboBox1.Text = "Loss" Then
            Statustxt = "Loss"
        ElseIf ComboBox1.Text = "Draw" Then
            Statustxt = "Draw"
        ElseIf ComboBox1.Text = "Upcoming" Then
            Statustxt = "Upcoming"

        End If
    End Sub
    Private Sub DIsp_Click(sender As Object, e As EventArgs) Handles DIsp.Click
        MatchCalender.Show()
    End Sub

    Private Sub AddBTn_Click(sender As Object, e As EventArgs) Handles AddBTn.Click
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "INSERT INTO Matchs Values (?,?,?,?)"
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDb.OleDbParameter("ID", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Home Ground", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Date", CType(DateTimePicker1.Value.ToShortDateString, String)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("Status", CType(Statustxt, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MessageBox.Show("Record Added")
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "Delete from [Matchs] where [Match ID] = " & TextBox1.Text & ""
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MessageBox.Show("Record Deleted")
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RecUP_Click(sender As Object, e As EventArgs) Handles RecUP.Click
        a += 1
        RowDIsp.Text = a
        If a = max Then
            RecUP.Enabled = False
        Else
            RecDown.Enabled = True
            RecUP.Enabled = True
        End If
        GetData()
    End Sub

    Private Sub RecDown_Click(sender As Object, e As EventArgs) Handles RecDown.Click
        a -= 1
        RowDIsp.Text = a
        If a = 0 Then
            RecDown.Enabled = False
            RecUP.Enabled = True
        ElseIf a <> max Then
            RecUP.Enabled = True
        End If
        GetData()
    End Sub



    Private Sub CLoseBtn_Click(sender As Object, e As EventArgs) Handles CLoseBtn.Click
        Me.Close()
    End Sub
End Class