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
        Me.txt_nascimento = New System.Windows.Forms.TextBox()
        Me.txt_hoje = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdcalcular = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_nascimento
        '
        Me.txt_nascimento.Location = New System.Drawing.Point(6, 100)
        Me.txt_nascimento.Name = "txt_nascimento"
        Me.txt_nascimento.Size = New System.Drawing.Size(211, 20)
        Me.txt_nascimento.TabIndex = 0
        '
        'txt_hoje
        '
        Me.txt_hoje.Location = New System.Drawing.Point(367, 100)
        Me.txt_hoje.Name = "txt_hoje"
        Me.txt_hoje.Size = New System.Drawing.Size(211, 20)
        Me.txt_hoje.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdcalcular)
        Me.GroupBox1.Controls.Add(Me.txt_nascimento)
        Me.GroupBox1.Controls.Add(Me.txt_hoje)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 556)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Idade"
        '
        'cmdcalcular
        '
        Me.cmdcalcular.Location = New System.Drawing.Point(204, 230)
        Me.cmdcalcular.Name = "cmdcalcular"
        Me.cmdcalcular.Size = New System.Drawing.Size(158, 38)
        Me.cmdcalcular.TabIndex = 2
        Me.cmdcalcular.Text = "calcular"
        Me.cmdcalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 580)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_nascimento As TextBox
    Friend WithEvents txt_hoje As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdcalcular As Button
End Class
