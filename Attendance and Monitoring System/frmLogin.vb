Imports System.IO
Imports System.IO.File

Public Class frmLogin
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\attendance.accdb")

    Private sqlQuery As New ExecQueryFunctions

    Public Sub AddLog(ByVal text As String)
        Dim filename As String = Application.StartupPath & "\test.log"
        Dim sw As StreamWriter = AppendText(filename)

        sw.WriteLine(Now() & " " & text)
        sw.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim alert As frmAlert = New frmAlert
        If txtUsername.Text = Nothing Then
            frmAlert.SetAlert("Please input your username", frmAlert.AlertTypeEnum.Failed)
        ElseIf txtPassword.Text = Nothing Then
            frmAlert.SetAlert("Please input your password", frmAlert.AlertTypeEnum.Failed)
        Else


            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM TableUsers WHERE Username = '" & txtUsername.Text & "' AND [Password] = '" & txtPassword.Text & "' ", con)

            Dim user As String = ""
            Dim pass As String = ""

            Try
                con.Open()

                Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader()

                If (sdr.Read() = True) Then

                    user = sdr("Username")
                    pass = sdr("Password")
                    alert.SetAlert("Welcome " & sqlQuery.GetName(txtUsername.Text), frmAlert.AlertTypeEnum.Success)

                    If sqlQuery.CheckIfAdmin(txtUsername.Text) Then
                        AddLog("An admin has logged in")
                        frmMain.Show()
                        Me.Close()
                    Else
                        AddLog("Student named " & sqlQuery.GetName(txtUsername.Text) & " has logged in")
                        Dim obj As New frmStudent
                        obj.StringPass = txtUsername.Text
                        obj.Show()
                        Me.Close()
                    End If
                Else
                    alert.SetAlert("No existing user named " & txtUsername.Text & " is found", frmAlert.AlertTypeEnum.Failed)
                End If
            Catch ex As Exception
                alert.SetAlert(ex.Message, frmAlert.AlertTypeEnum.Info)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        frmRegister.Show()
        Me.Close()
    End Sub
End Class
