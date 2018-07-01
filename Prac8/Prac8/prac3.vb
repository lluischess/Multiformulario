Public Class prac3


    Private Sub Button_Añadir(sender As Object, e As EventArgs) Handles Añadir.Click
        Dim Seleccio As Integer
        Dim Añadir As Boolean
        Dim cont As Integer
        Dim array(0 To ListBox1.Items.Count()) As Double
        Seleccio = ComboEscojer.SelectedIndex
        Select Case Seleccio
            Case 0
                'insertamos el numero al principio
                ListBox1.Items.Insert(0, CDbl(EscribirT.Text))
            Case 1
                'insertaremos el numero al final
                ListBox1.Items.Add(CDbl(EscribirT.Text))
            Case 2
                'insertaremos el numero comparandolo con el mas grande o igual al de la lista.
                Dim valor As Double
                valor = 0
                cont = 0
                Añadir = False
                Dim Contar As Integer
                Contar = ListBox1.Items.Count
                For cont = 0 To Contar - 1
                    array(cont) = ListBox1.Items.Item(cont)
                Next
                Dim pF As Integer = -1
                cont = 0
                valor = EscribirT.Text
                For cont = 0 To Contar - 1
                    If valor >= array(cont) Then

                        If pF = -1 Then
                            pF = cont
                            Añadir = True
                        End If
                    End If
                Next
                If pF = -1 Then
                    ListBox1.Items.Insert(cont, CDbl(valor))
                Else
                    ListBox1.Items.Insert(pF, CDbl(valor))
                End If

        End Select


    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub EscribirT_TextChanged(sender As Object, e As EventArgs) Handles EscribirT.TextChanged

    End Sub

    Private Sub AñadirP_Click(sender As Object, e As EventArgs) Handles AñadirP.Click
        Dim valor As Double
        valor = InputBox("Introduce valor para añadirlo a la listbox:", "Imprimir")

        If (ComboEscojer.SelectedIndex = 0) Then
            ListBox1.Items.Insert(0, valor)

        ElseIf (ComboEscojer.SelectedIndex = 2) Then
            ListBox1.Items.Add(valor)
        Else
            Dim cont As Integer
            Dim agregar As Boolean
            cont = 0
            agregar = False
            While cont < ListBox1.Items.Count And agregar = False
                If CDbl(ListBox1.Items.Item(cont)) >= CDbl(valor) Then
                    ListBox1.Items.Insert(cont, valor)

                    agregar = True
                End If
                cont = cont + 1
            End While
            If agregar = False Then
                ListBox1.Items.Add(valor)


            End If
        End If

    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim cont2 As Integer
        Dim sum As Double = 0
        Dim min As Double
        Dim max As Double
        Dim avg As Double
        Dim contar2 As Integer
        Dim array2(0 To ListBox1.Items.Count()) As Double
        contar2 = ListBox1.Items.Count
        cont2 = 0

        For cont2 = 0 To contar2 - 1
            array2(cont2) = ListBox1.Items.Item(cont2)
        Next
        min = array2(0)
        max = array2(0)
        avg = 0
        For cont2 = 0 To contar2 - 1
            If min > array2(cont2) Then
                min = array2(cont2)
            End If
            If max < array2(cont2) Then
                max = array2(cont2)
            End If
            sum = sum + array2(cont2)
        Next
        avg = sum / cont2

        MsgBox("PEQUEÑO: " & min & " GRANDE: " & max & " PROMEDIO:" & avg)
    End Sub

    Private Sub Orden_Click(sender As Object, e As EventArgs) Handles Orden.Click
        Dim array3(0 To ListBox1.Items.Count() - 1) As Double
        Dim valor As Double
        Dim cont3 As Double
        Dim cont4 As Double
        Dim aux As Double
        valor = 0
        cont3 = 0
        Dim Contar As Integer
        Contar = ListBox1.Items.Count
        For cont = 0 To Contar - 1
            array3(cont) = ListBox1.Items.Item(cont)
        Next
        'ordenacion
        For cont4 = 1 To array3.Length - 1
            For cont3 = 0 To array3.Length - cont4 - 1
                If array3(cont3) > array3(cont3 + 1) Then
                    aux = array3(cont3 + 1)
                    array3(cont3 + 1) = array3(cont3)
                    array3(cont3) = aux
                End If
            Next
        Next
        ListBox1.Items.Clear()
        cont3 = 0
        If Onumeros.Checked = True Then
            If CheckBox1.Checked = True Then
                For cont3 = 0 To array3.Length - 1
                    ListBox1.Items.Add(array3(cont3))
                Next
            Else
                For cont3 = array3.Length - 1 To 0 Step -1
                    ListBox1.Items.Add(array3(cont3))
                Next

            End If
        Else
        End If
        If Ascii.Checked = True Then
            If CheckBox1.Checked = True Then
                ListBox1.Sorted = True
                ListBox1.Sorted = False
                For cont3 = 0 To array3.Length - 1
                    ListBox1.Items.Add(array3(cont3))
                Next
            Else
                ListBox1.Sorted = True
                ListBox1.Sorted = False
                For cont3 = array3.Length - 1 To 0 Step -1
                    ListBox1.Items.Add(array3(cont3))
                Next

            End If
        Else
        End If

    End Sub
End Class
