<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prac5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Reloj = New System.Windows.Forms.Label()
        Me.Data = New System.Windows.Forms.Label()
        Me.timerRellotge = New System.Windows.Forms.Timer(Me.components)
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Reloj2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Alarma = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AlarmaOn = New System.Windows.Forms.Button()
        Me.AlarmaOff = New System.Windows.Forms.Button()
        Me.Missat = New System.Windows.Forms.RadioButton()
        Me.bAlarm = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Reloj
        '
        Me.Reloj.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reloj.Location = New System.Drawing.Point(113, 32)
        Me.Reloj.Name = "Reloj"
        Me.Reloj.Size = New System.Drawing.Size(135, 23)
        Me.Reloj.TabIndex = 0
        Me.Reloj.Text = "00:00:00"
        '
        'Data
        '
        Me.Data.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data.Location = New System.Drawing.Point(480, 47)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(306, 42)
        Me.Data.TabIndex = 1
        Me.Data.Text = "Label2"
        '
        'timerRellotge
        '
        Me.timerRellotge.Enabled = True
        Me.timerRellotge.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hora actual"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Reloj2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Reloj)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 146)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Reloj2
        '
        Me.Reloj2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reloj2.Location = New System.Drawing.Point(113, 103)
        Me.Reloj2.Name = "Reloj2"
        Me.Reloj2.Size = New System.Drawing.Size(164, 30)
        Me.Reloj2.TabIndex = 0
        Me.Reloj2.Text = "00:00:00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Altre hora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(484, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"United Kingdom", "China", "Alaska"})
        Me.ComboBox1.Location = New System.Drawing.Point(14, 275)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 244)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Selecció pais"
        '
        'Timer1
        '
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Alarma)
        Me.GroupBox3.Location = New System.Drawing.Point(266, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 146)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Alarma"
        '
        'Alarma
        '
        Me.Alarma.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alarma.Location = New System.Drawing.Point(92, 32)
        Me.Alarma.Name = "Alarma"
        Me.Alarma.Size = New System.Drawing.Size(94, 34)
        Me.Alarma.TabIndex = 0
        Me.Alarma.Text = "00:00:00"
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(129, 276)
        Me.txt.Margin = New System.Windows.Forms.Padding(2)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(248, 20)
        Me.txt.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(126, 245)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Entra l'hora"
        '
        'AlarmaOn
        '
        Me.AlarmaOn.Location = New System.Drawing.Point(14, 323)
        Me.AlarmaOn.Margin = New System.Windows.Forms.Padding(2)
        Me.AlarmaOn.Name = "AlarmaOn"
        Me.AlarmaOn.Size = New System.Drawing.Size(92, 32)
        Me.AlarmaOn.TabIndex = 10
        Me.AlarmaOn.Text = "Alarma ON"
        Me.AlarmaOn.UseVisualStyleBackColor = True
        '
        'AlarmaOff
        '
        Me.AlarmaOff.Location = New System.Drawing.Point(110, 323)
        Me.AlarmaOff.Margin = New System.Windows.Forms.Padding(2)
        Me.AlarmaOff.Name = "AlarmaOff"
        Me.AlarmaOff.Size = New System.Drawing.Size(92, 32)
        Me.AlarmaOff.TabIndex = 11
        Me.AlarmaOff.Text = "Alarma Off"
        Me.AlarmaOff.UseVisualStyleBackColor = True
        '
        'Missat
        '
        Me.Missat.AutoSize = True
        Me.Missat.Location = New System.Drawing.Point(66, 178)
        Me.Missat.Margin = New System.Windows.Forms.Padding(2)
        Me.Missat.Name = "Missat"
        Me.Missat.Size = New System.Drawing.Size(67, 17)
        Me.Missat.TabIndex = 12
        Me.Missat.TabStop = True
        Me.Missat.Text = "Missatge"
        Me.Missat.UseVisualStyleBackColor = True
        '
        'bAlarm
        '
        Me.bAlarm.AutoSize = True
        Me.bAlarm.Checked = True
        Me.bAlarm.Location = New System.Drawing.Point(11, 178)
        Me.bAlarm.Margin = New System.Windows.Forms.Padding(2)
        Me.bAlarm.Name = "bAlarm"
        Me.bAlarm.Size = New System.Drawing.Size(51, 17)
        Me.bAlarm.TabIndex = 13
        Me.bAlarm.TabStop = True
        Me.bAlarm.Text = "Soroll"
        Me.bAlarm.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(338, 245)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Label"
        Me.Label7.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(261, 319)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 36)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Nou horari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'prac5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(871, 366)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bAlarm)
        Me.Controls.Add(Me.Missat)
        Me.Controls.Add(Me.AlarmaOff)
        Me.Controls.Add(Me.AlarmaOn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Data)
        Me.Name = "prac5"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Reloj As Label
    Friend WithEvents Data As Label
    Friend WithEvents timerRellotge As Timer
    Friend WithEvents timer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Reloj2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AlarmaOn As Button
    Friend WithEvents AlarmaOff As Button
    Friend WithEvents Missat As RadioButton
    Friend WithEvents bAlarm As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Alarma As Label
End Class
