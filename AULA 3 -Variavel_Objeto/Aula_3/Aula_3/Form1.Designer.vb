<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdola = New System.Windows.Forms.Button()
        Me.cmdlimpar = New System.Windows.Forms.Button()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdola
        '
        Me.cmdola.Location = New System.Drawing.Point(62, 169)
        Me.cmdola.Name = "cmdola"
        Me.cmdola.Size = New System.Drawing.Size(123, 39)
        Me.cmdola.TabIndex = 0
        Me.cmdola.Text = "&Olá"
        Me.cmdola.UseVisualStyleBackColor = True
        '
        'cmdlimpar
        '
        Me.cmdlimpar.Location = New System.Drawing.Point(361, 169)
        Me.cmdlimpar.Name = "cmdlimpar"
        Me.cmdlimpar.Size = New System.Drawing.Size(123, 39)
        Me.cmdlimpar.TabIndex = 1
        Me.cmdlimpar.Text = "Limpar"
        Me.cmdlimpar.UseVisualStyleBackColor = True
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(62, 80)
        Me.txtnome.Multiline = True
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(422, 29)
        Me.txtnome.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Digite seu nome:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 315)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.cmdlimpar)
        Me.Controls.Add(Me.cmdola)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdola As Button
    Friend WithEvents cmdlimpar As Button
    Friend WithEvents txtnome As TextBox
    Friend WithEvents Label1 As Label
End Class
