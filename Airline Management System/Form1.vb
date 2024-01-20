Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        Label3.Text = ProgressBar1.Value & "%"

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()

        End If

        If ProgressBar1.Value = 15 Then
            Label1.Text = "Please wait while we setup database..."
        End If

        If ProgressBar1.Value = 35 Then
            Label1.Text = "Be patient..."
        End If

        If ProgressBar1.Value = 52 Then
            Label1.Text = "Halfway there..."
        End If

        If ProgressBar1.Value = 75 Then
            Label1.Text = "Almost there..."
            Label2.Text = "Finishing..."
        End If

        If ProgressBar1.Value = 95 Then
            Label1.Text = "Launching database..."
        End If

        If ProgressBar1.Value = 100 Then
            Login.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Start()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
