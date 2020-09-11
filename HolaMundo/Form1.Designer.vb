<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.cboa = New System.Windows.Forms.ComboBox()
        Me.cbode = New System.Windows.Forms.ComboBox()
        Me.lbla = New System.Windows.Forms.Label()
        Me.lblde = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(224, 211)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(231, 99)
        Me.btnConvertir.TabIndex = 25
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrespuesta.Location = New System.Drawing.Point(490, 249)
        Me.lblrespuesta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(162, 29)
        Me.lblrespuesta.TabIndex = 24
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(544, 125)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(77, 20)
        Me.lblcantidad.TabIndex = 23
        Me.lblcantidad.Text = "Cantidad:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(662, 119)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(148, 26)
        Me.txtcantidad.TabIndex = 22
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"Monedas", "Longitud", "Masa", "Almacenamiento", "Tiempo"})
        Me.cbotipo.Location = New System.Drawing.Point(262, 33)
        Me.cbotipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(180, 28)
        Me.cbotipo.TabIndex = 21
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(204, 41)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(43, 20)
        Me.lbltipo.TabIndex = 20
        Me.lbltipo.Text = "Tipo:"
        '
        'cboa
        '
        Me.cboa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboa.FormattingEnabled = True
        Me.cboa.Location = New System.Drawing.Point(292, 125)
        Me.cboa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboa.Name = "cboa"
        Me.cboa.Size = New System.Drawing.Size(180, 28)
        Me.cboa.TabIndex = 19
        '
        'cbode
        '
        Me.cbode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbode.FormattingEnabled = True
        Me.cbode.Location = New System.Drawing.Point(67, 125)
        Me.cbode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbode.Name = "cbode"
        Me.cbode.Size = New System.Drawing.Size(180, 28)
        Me.cbode.TabIndex = 18
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Location = New System.Drawing.Point(258, 130)
        Me.lbla.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(24, 20)
        Me.lbla.TabIndex = 17
        Me.lbla.Text = "A:"
        '
        'lblde
        '
        Me.lblde.AutoSize = True
        Me.lblde.Location = New System.Drawing.Point(20, 130)
        Me.lblde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblde.Name = "lblde"
        Me.lblde.Size = New System.Drawing.Size(36, 20)
        Me.lblde.TabIndex = 16
        Me.lblde.Text = "DE:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 337)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.cboa)
        Me.Controls.Add(Me.cbode)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.lblde)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Combos Dinamicos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents cbotipo As ComboBox
    Friend WithEvents lbltipo As Label
    Friend WithEvents cboa As ComboBox
    Friend WithEvents cbode As ComboBox
    Friend WithEvents lbla As Label
    Friend WithEvents lblde As Label
End Class
