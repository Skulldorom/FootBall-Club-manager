Public Class Medical
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim a, max As Integer


    Private Sub Medical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecDown.Enabled = False
        filltable()

        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM MedicalDetails"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "MedicalDetails")
        con.Close()
        '
        max = ds.Tables("MedicalDetails").Rows.Count
        max -= 1
        GetData()
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
        sql = "SELECT * FROM MedicalDetails"
        da = New OleDb.OleDbDataAdapter(sql, con)
        Dim DBDT As New DataTable
        da.Fill(DBDT)
        con.Close()
        DataGridView1.DataSource = DBDT

    End Sub

    Sub GetData()
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        sql = "SELECT * FROM MedicalDetails"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "MedicalDetails")
        con.Close()

        IDTxt.Text = ds.Tables("MedicalDetails").Rows(a).Item(0)
        BTtxt.Text = ds.Tables("MedicalDetails").Rows(a).Item(2)
        Injured.Text = ds.Tables("MedicalDetails").Rows(a).Item(5)
        Extradettxt.Text = ds.Tables("MedicalDetails").Rows(a).Item(6)


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub RecUP_Click(sender As Object, e As EventArgs) Handles RecUP.Click
        a += 1

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

        If a = 0 Then
            RecDown.Enabled = False
            RecUP.Enabled = True
        End If
        GetData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fileName As String = My.Application.Info.DirectoryPath()
        Dim Filenameremove As String = "\bin\Debug"
        fileName = fileName.Replace(Filenameremove, "").Trim()
        fileName += "\FootballlClub.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Persist Security Info=False;"

        con.Open()
        Dim str As String
        Dim IDno As Integer = IDTxt.Text
        str = "Update [MedicalDetails] set [Blood Type] = '" & BTtxt.Text & "',[Injured] = '" & Injured.Text & "',[Extra Details] = '" & Extradettxt.Text & "' Where [ID] = " & IDno
        Dim cmd = New OleDb.OleDbCommand(str, con)

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
End Class