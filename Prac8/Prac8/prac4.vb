Public Class prac4
    Private Norepetirvalor As Boolean = False
    Private Norepetirvalor1 As Boolean = False
    Private Norepetirvalor2 As Boolean = False
    Private Norepetirvalor3 As Boolean = False

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Iniciar.Click
        TextBox.Text = 0
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click

        If TextBox.Text = 0 Then
            TextBox.Text = ""

        End If
        TextBox.Text = TextBox.Text + "1"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox.Text = 0


    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If TextBox.Text = 0 Then
            TextBox.Text = ""

        End If
        TextBox.Text = TextBox.Text + "2"
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If TextBox.Text = 0 Then
            TextBox.Text = ""

        End If
        TextBox.Text = TextBox.Text + "3"
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        If TextBox.Text = 0 Then
            TextBox.Text = ""

        End If
        TextBox.Text = TextBox.Text + "4"
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        If TextBox.Text = 0 Then
            TextBox.Text = ""

        End If
        TextBox.Text = TextBox.Text + "5"
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        If TextBox.Text = 0 Then
            TextBox.Text = ""

        End If
        TextBox.Text = TextBox.Text + "6"
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        If TextBox.Text = 0 Then
            TextBox.Text = ""

        End If
        TextBox.Text = TextBox.Text + "7"
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        If TextBox.Text = 0 Then
            TextBox.Text = ""

        End If
        TextBox.Text = TextBox.Text + "8"
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        If TextBox.Text = 0 Then
            TextBox.Text = ""

        End If
        TextBox.Text = TextBox.Text + "9"
    End Sub

    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click

        TextBox.Text = TextBox.Text + "0"
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click

        If TextBox.Text.Length > 0 Then

            TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1)

        End If
        If TextBox.Text.Length = 0 Then
            TextBox.Text = 0
        End If
    End Sub

    Private Sub Comvertir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Convertir.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cont2 As Integer = 0
        Dim cont3 As Integer = 0
        Dim contcomas As Integer = 0
        Dim comaB As Boolean = False

        For cont2 = 0 To TextBox.Text.Length - 1
            If TextBox.Text(cont2) = "," Then
                contcomas = cont2
                comaB = True
            End If
        Next

        If comaB = False Then
            TextBox.Text = TextBox.Text + ","
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Calc As Double
        Dim Calc1 As Double
        Dim Calc2 As Double
        Dim Calc3 As Double
        Dim Dollars As Double
        Dim Yens As Double
        Dim Lliures As Double
        Dim Dragmes As Double

        Dim valor As Double


        If (Convertir.SelectedIndex = 0) Then

            If Norepetirvalor = False Then
                valor = InputBox("Introduce valor del cambio: ", "Imprimir")
                Norepetirvalor = True
            End If
            Calc = TextBox.Text
            Dollars = Calc * valor
            TextBox.Text = Dollars
        End If

        If (Convertir.SelectedIndex = 1) Then

            If Norepetirvalor = False Then
                valor = InputBox("Introduce valor del cambio: ", "Imprimir")
                Norepetirvalor1 = True
            End If
            Calc1 = TextBox.Text
            Yens = Calc1 * valor
            TextBox.Text = Yens
        End If

        If (Convertir.SelectedIndex = 2) Then

            If Norepetirvalor = False Then
                valor = InputBox("Introduce valor del cambio: ", "Imprimir")
                Norepetirvalor2 = True
            End If
            Calc2 = TextBox.Text
            Lliures = Calc2 * valor
            TextBox.Text = Lliures
        End If

        If (Convertir.SelectedIndex = 3) Then

            If Norepetirvalor = False Then
                valor = InputBox("Introduce valor del cambio: ", "Imprimir")
                Norepetirvalor3 = True
            End If
            Calc3 = TextBox.Text
            Dragmes = Calc3 * valor
            TextBox.Text = Dragmes
        End If


    End Sub
End Class
