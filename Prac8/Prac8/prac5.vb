Public Class prac5


    Private array As ArrayList
    Private Sub timerRellotge_Tick(sender As Object, e As EventArgs) Handles timerRellotge.Tick
        Reloj.Text = TimeOfDay

        Dim mes As String
        Dim any As Integer
        Dim day As Integer
        day = DateAndTime.Day(Now)
        mes = Month(Now)
        any = Year(Now)
        Select Case mes

            Case 1
                mes = "Gener"
            Case 2
                mes = "Febrer"
            Case 3
                mes = "Març"
            Case 4
                mes = "Abril"
            Case 5
                mes = "Maig"

            Case 6
                mes = "Juny"
            Case 7
                mes = "Juliol"
            Case 8
                mes = "Agost"
            Case 9
                mes = "Septembre"
            Case 10
                mes = "Octubre"
            Case 11
                mes = "Novembre"
            Case 12
                mes = "Desembre"


        End Select
        Data.Text = day & " " & "de" & " " & mes & " " & "del " & any

        Select Case ComboBox1.Text

            Case "Ningún"
                Reloj2.Hide()

            Case "United Kingdom"
                Reloj2.Text = TimeOfDay.AddHours(-1)
            Case "China"
                Reloj2.Text = TimeOfDay.AddHours(+7)
            Case "Alaska"
                Reloj2.Text = TimeOfDay.AddHours(-10)
        End Select



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Alarma.Text = Reloj.Text Then
            Label7.Text = Alarma.Text
        End If
        If Label7.Text = Alarma.Text And Missat.Checked = True Then
            Timer1.Stop()
            MessageBox.Show("Alarma")
        ElseIf Label7.Text = Alarma.Text And bAlarm.Checked = True Then
            Console.Beep()
        End If
    End Sub

    Private Sub btnAlarmaOff_Click(sender As Object, e As EventArgs) Handles AlarmaOff.Click
        Timer1.Stop()
    End Sub

    Private Sub btnAlarmaOn_Click(sender As Object, e As EventArgs) Handles AlarmaOn.Click
        Timer1.Start()
        Alarma.Text = txt.Text
    End Sub

    Private Sub btnmessageAlarm_CheckedChanged(sender As Object, e As EventArgs) Handles Missat.CheckedChanged

    End Sub


End Class
