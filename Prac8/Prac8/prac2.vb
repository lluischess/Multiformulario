Public Class prac2


    Private Sub BtnOrd_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button1.Click
        Dim taula(7) As Integer
        Dim index As Integer
        Dim index2 As Integer
        Dim Aux As Integer

        Try
            taula(0) = TextBox1.Text

        Catch
            TextBox1.Focus() 'revisem que estigi correcta
            MsgBox("Hi Ha un error a la caixa 1")
            Exit Sub
        End Try
        Try
            taula(1) = TextBox2.Text

        Catch
            TextBox2.Focus() 'revisem que estigi correcta
            MsgBox("Hi Ha un error a la caixa 2")
            Exit Sub
        End Try
        Try
            taula(2) = TextBox3.Text

        Catch
            TextBox3.Focus() 'revisem que estigi correcta
            MsgBox("Hi Ha un error a la caixa 3")
            Exit Sub
        End Try
        Try
            taula(3) = TextBox4.Text

        Catch
            TextBox4.Focus() 'revisem que estigi correcta
            MsgBox("Hi Ha un error a la caixa 4")
            Exit Sub
        End Try
        Try
            taula(4) = TextBox5.Text

        Catch
            TextBox5.Focus() 'revisem que estigi correcta
            MsgBox("Hi Ha un error a la caixa 5")
            Exit Sub
        End Try
        Try
            taula(5) = TextBox6.Text

        Catch
            TextBox6.Focus() 'revisem que estigi correcta
            MsgBox("Hi Ha un error a la caixa 6")
            Exit Sub
        End Try
        Try
            taula(6) = TextBox7.Text

        Catch
            TextBox7.Focus() 'revisem que estigi correcta
            MsgBox("Hi Ha un error a la caixa 7")
            Exit Sub
        End Try
        Try
            taula(7) = TextBox8.Text

        Catch
            TextBox8.Focus() 'revisem que estigi correcta
            MsgBox("Hi Ha un error a la caixa 8")
            Exit Sub
        End Try
        '---------------------------------------------------------------------------------
        'Controlem que es pugi ordenar 
        'Ascendent
        If (RadioButton1.Checked = True) Then
            For index = 0 To 7
                For index2 = 0 To 7
                    If taula(index) < taula(index2) Then
                        Aux = taula(index2)
                        taula(index2) = taula(index)
                        taula(index) = Aux
                    End If
                Next index2
            Next index


            'Descendent
        ElseIf (RadioButton2.Checked = True) Then
            For index = 0 To 7
                For index2 = 0 To 7
                    If taula(index) > taula(index2) Then
                        Aux = taula(index2)
                        taula(index2) = taula(index)
                        taula(index) = Aux
                    End If
                Next index2
            Next index


        End If

        TextBox1.Text = taula(0)
        TextBox2.Text = taula(1)
        TextBox3.Text = taula(2)
        TextBox4.Text = taula(3)
        TextBox5.Text = taula(4)
        TextBox6.Text = taula(5)
        TextBox7.Text = taula(6)
        TextBox8.Text = taula(7)
    End Sub
    Private Sub Divisor(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Resultat As Double
        Dim Index As Double
        Dim taula(7) As Integer
        Dim contador As Integer = 0
        taula(0) = TextBox1.Text
        taula(1) = TextBox2.Text
        taula(2) = TextBox3.Text
        taula(3) = TextBox4.Text
        taula(4) = TextBox5.Text
        taula(5) = TextBox6.Text
        taula(6) = TextBox7.Text
        taula(7) = TextBox8.Text

        If (TextBox9.Text <> "0") Then
            For Index = 0 To 7
                Resultat = taula(Index) / TextBox9.Text
                If taula(Index) Mod TextBox9.Text = 0 Then
                    contador = contador + 1 'sumem els numeros que seran divisors del numero afeigit
                End If
            Next Index
        End If
        MsgBox(contador)

    End Sub
End Class
