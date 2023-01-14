Public Class frmRegister
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\attendance.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand

    Dim isAdmin As String = ""

    Private sqlQuery As New ExecQueryFunctions

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim alert As frmAlert = New frmAlert

        If txtUsername.Text = Nothing Then
            alert.SetAlert("Please input your username", frmAlert.AlertTypeEnum.Failed)
        ElseIf txtPassword.Text = Nothing Then
            alert.SetAlert("Please input your password", frmAlert.AlertTypeEnum.Failed)
        Else
            isAdmin = "0"
            RegisterUser()
        End If

    End Sub

    Private Sub RegisterUser()
        Dim alert As frmAlert = New frmAlert
        Dim i As Integer

        If sqlQuery.CheckUserInClassList(txtUsername.Text) = True Then
            If sqlQuery.CheckUserRegistered(txtUsername.Text) = True Then
                alert.SetAlert("Student is already registered", frmAlert.AlertTypeEnum.Failed)
            Else
                Try
                    con.Open()
                    sql = "INSERT INTO TableUsers ( [Username], [Password], [isAdmin] ) VALUES ('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & isAdmin & "');"

                    cmd.Connection = con
                    cmd.CommandText = sql

                    i = cmd.ExecuteNonQuery

                    If i > 0 Then
                        alert.SetAlert("Successfully registered a new user!", frmAlert.AlertTypeEnum.Success)
                    Else
                        alert.SetAlert("Failed to add new user", frmAlert.AlertTypeEnum.Success)
                    End If
                Catch ex As Exception
                    alert.SetAlert(ex.Message, frmAlert.AlertTypeEnum.Info)
                Finally
                    con.Close()
                End Try
            End If
        Else
            alert.SetAlert("Student Number not found on Student Records
Ask your proffesor to add you in class list", frmAlert.AlertTypeEnum.Failed)
        End If

    End Sub
    Private Sub btnBacktoLogin_Click(sender As Object, e As EventArgs) Handles btnBacktoLogin.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class