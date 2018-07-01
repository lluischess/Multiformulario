<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class prac3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Añadir = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.AñadirP = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.EscribirT = New System.Windows.Forms.TextBox()
        Me.ComboEscojer = New System.Windows.Forms.ComboBox()
        Me.Orden = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Ascii = New System.Windows.Forms.RadioButton()
        Me.Onumeros = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(32, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(182, 292)
        Me.ListBox1.TabIndex = 0
        '
        'Añadir
        '
        Me.Añadir.Location = New System.Drawing.Point(4, 84)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(92, 45)
        Me.Añadir.TabIndex = 1
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(102, 85)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(92, 43)
        Me.Eliminar.TabIndex = 2
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'AñadirP
        '
        Me.AñadirP.Location = New System.Drawing.Point(224, 155)
        Me.AñadirP.Name = "AñadirP"
        Me.AñadirP.Size = New System.Drawing.Size(92, 71)
        Me.AñadirP.TabIndex = 3
        Me.AñadirP.Text = "¿Quieres añadir de otra manera?"
        Me.AñadirP.UseVisualStyleBackColor = True
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(322, 155)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(92, 71)
        Me.Calcular.TabIndex = 4
        Me.Calcular.Text = "Calcular(max,min,avg)"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'EscribirT
        '
        Me.EscribirT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EscribirT.Location = New System.Drawing.Point(4, 19)
        Me.EscribirT.Multiline = True
        Me.EscribirT.Name = "EscribirT"
        Me.EscribirT.Size = New System.Drawing.Size(190, 33)
        Me.EscribirT.TabIndex = 5
        '
        'ComboEscojer
        '
        Me.ComboEscojer.FormattingEnabled = True
        Me.ComboEscojer.Items.AddRange(New Object() {"Al principio de la lista", "Al final de la lista", "Ordenado por lista"})
        Me.ComboEscojer.Location = New System.Drawing.Point(5, 58)
        Me.ComboEscojer.Name = "ComboEscojer"
        Me.ComboEscojer.Size = New System.Drawing.Size(189, 21)
        Me.ComboEscojer.TabIndex = 6
        Me.ComboEscojer.Text = "Posicion(Añadir)"
        '
        'Orden
        '
        Me.Orden.Location = New System.Drawing.Point(4, 19)
        Me.Orden.Name = "Orden"
        Me.Orden.Size = New System.Drawing.Size(190, 29)
        Me.Orden.TabIndex = 7
        Me.Orden.Text = "Configurar el Orden por:"
        Me.Orden.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EscribirT)
        Me.GroupBox1.Controls.Add(Me.ComboEscojer)
        Me.GroupBox1.Controls.Add(Me.Añadir)
        Me.GroupBox1.Controls.Add(Me.Eliminar)
        Me.GroupBox1.Location = New System.Drawing.Point(220, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 137)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Añadir Valores a la lista:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Ascii)
        Me.GroupBox2.Controls.Add(Me.Onumeros)
        Me.GroupBox2.Controls.Add(Me.Orden)
        Me.GroupBox2.Location = New System.Drawing.Point(225, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 88)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Orden"
        '
        'Ascii
        '
        Me.Ascii.AutoSize = True
        Me.Ascii.Location = New System.Drawing.Point(83, 54)
        Me.Ascii.Name = "Ascii"
        Me.Ascii.Size = New System.Drawing.Size(52, 17)
        Me.Ascii.TabIndex = 9
        Me.Ascii.TabStop = True
        Me.Ascii.Text = "ASCII"
        Me.Ascii.UseVisualStyleBackColor = True
        '
        'Onumeros
        '
        Me.Onumeros.AutoSize = True
        Me.Onumeros.Location = New System.Drawing.Point(7, 55)
        Me.Onumeros.Name = "Onumeros"
        Me.Onumeros.Size = New System.Drawing.Size(70, 17)
        Me.Onumeros.TabIndex = 8
        Me.Onumeros.TabStop = True
        Me.Onumeros.Text = "Numerica"
        Me.Onumeros.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(156, 55)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(44, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Asc"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 363)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.AñadirP)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Añadir As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents AñadirP As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents EscribirT As TextBox
    Friend WithEvents ComboEscojer As ComboBox
    Friend WithEvents Orden As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Ascii As RadioButton
    Friend WithEvents Onumeros As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
End Class
