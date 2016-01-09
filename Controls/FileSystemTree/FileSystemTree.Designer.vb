<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileSystemTree
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.tvSystem = New System.Windows.Forms.TreeView()
        Me.SuspendLayout
        '
        'tvSystem
        '
        Me.tvSystem.Location = New System.Drawing.Point(0, 0)
        Me.tvSystem.Name = "tvSystem"
        Me.tvSystem.Size = New System.Drawing.Size(280, 358)
        Me.tvSystem.TabIndex = 0
        '
        'FileSystemTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tvSystem)
        Me.Name = "FileSystemTree"
        Me.Size = New System.Drawing.Size(280, 358)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents tvSystem As System.Windows.Forms.TreeView

End Class
