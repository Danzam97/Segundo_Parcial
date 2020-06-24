<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmTareas
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
        Me.btnBolsaSolidaria = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBolsaSolidaria
        '
        Me.btnBolsaSolidaria.Location = New System.Drawing.Point(229, 126)
        Me.btnBolsaSolidaria.Name = "btnBolsaSolidaria"
        Me.btnBolsaSolidaria.Size = New System.Drawing.Size(186, 227)
        Me.btnBolsaSolidaria.TabIndex = 0
        Me.btnBolsaSolidaria.Text = "Bolsa solidaria"
        Me.btnBolsaSolidaria.UseVisualStyleBackColor = True
        '
        'fmTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBolsaSolidaria)
        Me.Name = "fmTareas"
        Me.Text = "Tareas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBolsaSolidaria As Button
End Class
