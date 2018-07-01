Public Class FormInicial
    Dim contprac1 As Integer = 0
    Dim contprac2 As Integer = 0
    Dim contprac3 As Integer = 0
    Dim contprac4 As Integer = 0
    Dim contprac5 As Integer = 0

    Dim Tiempomedio1 As TimeSpan
    Dim Tiempomedio2 As TimeSpan
    Dim Tiempomedio3 As TimeSpan
    Dim Tiempomedio4 As TimeSpan
    Dim Tiempomedio5 As TimeSpan

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick



        Dim FechaI1 As Date
        Dim FechaI2 As Date
        Dim FechaI3 As Date
        Dim FechaI4 As Date
        Dim FechaI5 As Date

        Dim FechaF1 As Date
        Dim FechaF2 As Date
        Dim FechaF3 As Date
        Dim FechaF4 As Date
        Dim FechaF5 As Date



        Dim segundos1 As Integer
        Dim segundos2 As Integer
        Dim segundos3 As Integer
        Dim segundos4 As Integer
        Dim segundos5 As Integer

        Dim minutos1 As Integer
        Dim minutos2 As Integer
        Dim minutos3 As Integer
        Dim minutos4 As Integer
        Dim minutos5 As Integer



        Select Case e.Node.Tag
            Case 1
                Try

                    FechaI1 = TimeOfDay
                    op1.Text = FechaI1

                    pr1.ShowDialog()
                    contprac1 = contprac1 + 1
                    rep1.Text = contprac1

                    FechaF1 = TimeOfDay
                    T1.Text = FechaF1

                    Tiempomedio1 = Tiempomedio1 + (FechaI1 - FechaF1)
                    segundos1 = Tiempomedio1.Seconds
                    minutos1 = Tiempomedio1.Minutes

                    te1.Text = minutos1
                    s1.Text = segundos1

                Catch ex As Exception
                    MsgBox("Error")
                End Try


            Case 2
                Try
                    FechaI2 = TimeOfDay
                    op2.Text = FechaI2

                    prac2.ShowDialog()
                    contprac2 = contprac2 + 1
                    rep2.Text = contprac2

                    FechaF2 = TimeOfDay
                    T2.Text = FechaF2

                    Tiempomedio2 = Tiempomedio2 + (FechaI2 - FechaF2)
                    segundos2 = Tiempomedio2.Seconds
                    minutos2 = Tiempomedio2.Minutes

                    te2.Text = minutos2
                    s2.Text = segundos2
                Catch ex As Exception

                    MsgBox("Error")
                End Try


            Case 3
                Try
                    FechaI3 = TimeOfDay
                    op3.Text = FechaI3

                    prac3.ShowDialog()
                    contprac3 = contprac3 + 1
                    rep3.Text = contprac3

                    FechaF3 = TimeOfDay
                    T3.Text = FechaF3

                    Tiempomedio3 = Tiempomedio3 + (FechaI3 - FechaF3)
                    segundos3 = Tiempomedio3.Seconds
                    minutos3 = Tiempomedio3.Minutes

                    te3.Text = minutos3
                    s3.Text = segundos3
                Catch ex As Exception
                    MsgBox("Error")
                End Try

            Case 4

                Try
                    FechaI4 = TimeOfDay
                    op4.Text = FechaI4

                    prac4.ShowDialog()
                    contprac4 = contprac4 + 1
                    rep4.Text = contprac4

                    FechaF4 = TimeOfDay
                    T4.Text = FechaF4

                    Tiempomedio4 = Tiempomedio4 + (FechaI4 - FechaF4)
                    segundos4 = Tiempomedio4.Seconds
                    minutos4 = Tiempomedio4.Minutes

                    te4.Text = minutos4
                    s4.Text = segundos4
                Catch ex As Exception
                    MsgBox("Error")
                End Try

            Case 5

                Try
                    FechaI5 = TimeOfDay
                    op5.Text = FechaI5

                    prac5.ShowDialog()
                    contprac5 = contprac5 + 1
                    rep5.Text = contprac5

                    FechaF5 = TimeOfDay
                    T5.Text = FechaF5

                    Tiempomedio5 = Tiempomedio5 + (FechaI5 - FechaF5)
                    segundos5 = Tiempomedio5.Seconds
                    minutos5 = Tiempomedio5.Minutes

                    te5.Text = minutos5
                    s5.Text = segundos5
                Catch ex As Exception
                    MsgBox("Error")
                End Try

        End Select
    End Sub


End Class
