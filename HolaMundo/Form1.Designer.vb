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
        Me.cboMun = New System.Windows.Forms.ComboBox()
        Me.cboDepto = New System.Windows.Forms.ComboBox()
        Me.lblmun = New System.Windows.Forms.Label()
        Me.lbldepto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboMun
        '
        Me.cboMun.FormattingEnabled = True
        Me.cboMun.Location = New System.Drawing.Point(391, 55)
        Me.cboMun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboMun.Name = "cboMun"
        Me.cboMun.Size = New System.Drawing.Size(180, 28)
        Me.cboMun.TabIndex = 13
        '
        'cboDepto
        '
        Me.cboDepto.FormattingEnabled = True
        Me.cboDepto.Location = New System.Drawing.Point(104, 55)
        Me.cboDepto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.Size = New System.Drawing.Size(180, 28)
        Me.cboDepto.TabIndex = 12
        '
        'lblmun
        '
        Me.lblmun.AutoSize = True
        Me.lblmun.Location = New System.Drawing.Point(339, 58)
        Me.lblmun.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmun.Name = "lblmun"
        Me.lblmun.Size = New System.Drawing.Size(44, 20)
        Me.lblmun.TabIndex = 11
        Me.lblmun.Text = "Mun:"
        '
        'lbldepto
        '
        Me.lbldepto.AutoSize = True
        Me.lbldepto.Location = New System.Drawing.Point(13, 58)
        Me.lbldepto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldepto.Name = "lbldepto"
        Me.lbldepto.Size = New System.Drawing.Size(57, 20)
        Me.lbldepto.TabIndex = 10
        Me.lbldepto.Text = "Depto:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 146)
        Me.Controls.Add(Me.cboMun)
        Me.Controls.Add(Me.cboDepto)
        Me.Controls.Add(Me.lblmun)
        Me.Controls.Add(Me.lbldepto)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Combos Dinamicos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboMun As ComboBox
    Friend WithEvents cboDepto As ComboBox
    Friend WithEvents lblmun As Label
    Friend WithEvents lbldepto As Label
End Class
