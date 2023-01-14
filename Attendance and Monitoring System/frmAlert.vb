Public Class frmAlert
    Enum AlertTypeEnum
        Info
        Success
        Failed
        Warning
    End Enum
    Enum ActionEnum
        Start
        Wait
        Close
    End Enum
    Dim x, y As Integer
    Public Sub SetAlert(msg As String, type As AlertTypeEnum)
        Me.Opacity = 0
        Me.StartPosition = FormStartPosition.Manual
        Dim FName As String
        For i As Integer = 1 To 10
            FName = "alert" & i.ToString
            Dim F As frmAlert = Application.OpenForms.Item(FName)
            If F Is Nothing Then
                Me.Name = FName
                x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                Me.Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5
        Select Case type
            Case AlertTypeEnum.Info
                Me.PictureBox1.Image = My.Resources.Info_28px
                Me.BackColor = Color.FromArgb(71, 169, 248)
                Me.Panel1.BackColor = Color.FromArgb(50, 0, 0, 0)
                Me.Label1.ForeColor = Color.White
            Case AlertTypeEnum.Success
                Me.PictureBox1.Image = My.Resources.Checkmark_28px
                Me.BackColor = Color.FromArgb(42, 171, 160)
                Me.Panel1.BackColor = Color.FromArgb(50, 0, 0, 0)
                Me.Label1.ForeColor = Color.White
            Case AlertTypeEnum.Failed
                Me.PictureBox1.Image = My.Resources.Error_28px
                Me.BackColor = Color.FromArgb(255, 121, 70)
                Me.Panel1.BackColor = Color.FromArgb(50, 0, 0, 0)
                Me.Label1.ForeColor = Color.White
            Case AlertTypeEnum.Warning
                Me.PictureBox1.Image = My.Resources.Warning_28px
                Me.BackColor = Color.FromArgb(255, 179, 2)
                Me.Panel1.BackColor = Color.FromArgb(50, 0, 0, 0)
                Me.Label1.ForeColor = Color.White
        End Select
        Me.Label1.Text = msg
        Me.Show()
        Me.Timer1.Interval = 1
        Me.Timer1.Start()
    End Sub
    Private Action As ActionEnum = ActionEnum.Start
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case Action
            Case ActionEnum.Start
                Me.Timer1.Interval = 1
                Me.Opacity += 0.1
                If x < Me.Location.X Then
                    Me.Left -= 1
                Else
                    If Me.Opacity = 1 Then
                        Action = ActionEnum.Wait
                    End If
                End If
            Case ActionEnum.Wait
                Timer1.Interval = 5000
                Action = ActionEnum.Close
            Case ActionEnum.Close
                Timer1.Interval = 1
                Me.Opacity -= 0.1
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Close()
                End If
        End Select
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Timer1.Interval = 1
        Action = ActionEnum.Close
    End Sub
End Class