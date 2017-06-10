<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recarga
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
        Me.btEntrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btEntrar
        '
        Me.btEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEntrar.Location = New System.Drawing.Point(39, 21)
        Me.btEntrar.Name = "btEntrar"
        Me.btEntrar.Size = New System.Drawing.Size(111, 52)
        Me.btEntrar.TabIndex = 0
        Me.btEntrar.Text = "Entrar"
        Me.btEntrar.UseVisualStyleBackColor = True
        '
        'Recarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 96)
        Me.Controls.Add(Me.btEntrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Recarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recarga"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btEntrar As System.Windows.Forms.Button
End Class
