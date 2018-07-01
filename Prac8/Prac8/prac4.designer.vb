<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prac4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Iniciar = New System.Windows.Forms.Button()
        Me.Resultat = New System.Windows.Forms.Button()
        Me.Convertir = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B0 = New System.Windows.Forms.Button()
        Me.B9 = New System.Windows.Forms.Button()
        Me.B8 = New System.Windows.Forms.Button()
        Me.B7 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Iniciar)
        Me.GroupBox1.Controls.Add(Me.Resultat)
        Me.GroupBox1.Controls.Add(Me.Convertir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.B0)
        Me.GroupBox1.Controls.Add(Me.B9)
        Me.GroupBox1.Controls.Add(Me.B8)
        Me.GroupBox1.Controls.Add(Me.B7)
        Me.GroupBox1.Controls.Add(Me.B6)
        Me.GroupBox1.Controls.Add(Me.B5)
        Me.GroupBox1.Controls.Add(Me.B4)
        Me.GroupBox1.Controls.Add(Me.B3)
        Me.GroupBox1.Controls.Add(Me.B2)
        Me.GroupBox1.Controls.Add(Me.B1)
        Me.GroupBox1.Controls.Add(Me.Borrar)
        Me.GroupBox1.Controls.Add(Me.TextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 343)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comversor"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(112, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 47)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = ","
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Iniciar
        '
        Me.Iniciar.Location = New System.Drawing.Point(221, 63)
        Me.Iniciar.Name = "Iniciar"
        Me.Iniciar.Size = New System.Drawing.Size(98, 63)
        Me.Iniciar.TabIndex = 16
        Me.Iniciar.Text = "Inicializar"
        Me.Iniciar.UseVisualStyleBackColor = True
        '
        'Resultat
        '
        Me.Resultat.Location = New System.Drawing.Point(220, 290)
        Me.Resultat.Name = "Resultat"
        Me.Resultat.Size = New System.Drawing.Size(99, 47)
        Me.Resultat.TabIndex = 15
        Me.Resultat.Text = "="
        Me.Resultat.UseVisualStyleBackColor = True
        '
        'Convertir
        '
        Me.Convertir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Convertir.FormattingEnabled = True
        Me.Convertir.Items.AddRange(New Object() {"Dollars", "Yens", "Lliures Esterlines", "Dragmes"})
        Me.Convertir.Location = New System.Drawing.Point(7, 76)
        Me.Convertir.Name = "Convertir"
        Me.Convertir.Size = New System.Drawing.Size(100, 21)
        Me.Convertir.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Escoger Moneda"
        '
        'B0
        '
        Me.B0.Location = New System.Drawing.Point(6, 290)
        Me.B0.Name = "B0"
        Me.B0.Size = New System.Drawing.Size(101, 47)
        Me.B0.TabIndex = 11
        Me.B0.Text = "0"
        Me.B0.UseVisualStyleBackColor = True
        '
        'B9
        '
        Me.B9.Location = New System.Drawing.Point(220, 240)
        Me.B9.Name = "B9"
        Me.B9.Size = New System.Drawing.Size(99, 44)
        Me.B9.TabIndex = 10
        Me.B9.Text = "9"
        Me.B9.UseVisualStyleBackColor = True
        '
        'B8
        '
        Me.B8.Location = New System.Drawing.Point(113, 240)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(100, 44)
        Me.B8.TabIndex = 9
        Me.B8.Text = "8"
        Me.B8.UseVisualStyleBackColor = True
        '
        'B7
        '
        Me.B7.Location = New System.Drawing.Point(7, 240)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(100, 44)
        Me.B7.TabIndex = 8
        Me.B7.Text = "7"
        Me.B7.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.Location = New System.Drawing.Point(220, 190)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(99, 44)
        Me.B6.TabIndex = 7
        Me.B6.Text = "6"
        Me.B6.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Location = New System.Drawing.Point(112, 190)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(100, 44)
        Me.B5.TabIndex = 6
        Me.B5.Text = "5"
        Me.B5.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Location = New System.Drawing.Point(6, 190)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(100, 44)
        Me.B4.TabIndex = 5
        Me.B4.Text = "4"
        Me.B4.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(219, 132)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(100, 48)
        Me.B3.TabIndex = 4
        Me.B3.Text = "3"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(113, 132)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(100, 48)
        Me.B2.TabIndex = 3
        Me.B2.Text = "2"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(6, 132)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(100, 48)
        Me.B1.TabIndex = 2
        Me.B1.Text = "1"
        Me.B1.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Location = New System.Drawing.Point(113, 63)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(100, 63)
        Me.Borrar.TabIndex = 1
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'TextBox
        '
        Me.TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox.Location = New System.Drawing.Point(9, 19)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ReadOnly = True
        Me.TextBox.Size = New System.Drawing.Size(310, 34)
        Me.TextBox.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Convertir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 367)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox As TextBox
    Friend WithEvents B0 As Button
    Friend WithEvents B9 As Button
    Friend WithEvents B8 As Button
    Friend WithEvents B7 As Button
    Friend WithEvents B6 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B1 As Button
    Friend WithEvents Borrar As Button
    Friend WithEvents Convertir As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Resultat As Button
    Friend WithEvents Iniciar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
