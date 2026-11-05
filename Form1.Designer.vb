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
    Me.btnVerifica = New System.Windows.Forms.Button()
    Me.txtNome = New System.Windows.Forms.TextBox()
    Me.txtValor = New System.Windows.Forms.TextBox()
    Me.btnVerificaNumero = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'btnVerifica
    '
    Me.btnVerifica.Location = New System.Drawing.Point(12, 53)
    Me.btnVerifica.Name = "btnVerifica"
    Me.btnVerifica.Size = New System.Drawing.Size(181, 29)
    Me.btnVerifica.TabIndex = 0
    Me.btnVerifica.Text = "Verifica"
    Me.btnVerifica.UseVisualStyleBackColor = True
    '
    'txtNome
    '
    Me.txtNome.Location = New System.Drawing.Point(12, 25)
    Me.txtNome.Name = "txtNome"
    Me.txtNome.Size = New System.Drawing.Size(181, 22)
    Me.txtNome.TabIndex = 1
    Me.txtNome.Text = "Gabriel"
    '
    'txtValor
    '
    Me.txtValor.Location = New System.Drawing.Point(12, 107)
    Me.txtValor.Name = "txtValor"
    Me.txtValor.Size = New System.Drawing.Size(181, 22)
    Me.txtValor.TabIndex = 2
    '
    'btnVerificaNumero
    '
    Me.btnVerificaNumero.Location = New System.Drawing.Point(13, 136)
    Me.btnVerificaNumero.Name = "btnVerificaNumero"
    Me.btnVerificaNumero.Size = New System.Drawing.Size(180, 32)
    Me.btnVerificaNumero.TabIndex = 3
    Me.btnVerificaNumero.Text = "Verifica Número"
    Me.btnVerificaNumero.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(207, 180)
    Me.Controls.Add(Me.btnVerificaNumero)
    Me.Controls.Add(Me.txtValor)
    Me.Controls.Add(Me.txtNome)
    Me.Controls.Add(Me.btnVerifica)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents btnVerifica As Button
  Friend WithEvents txtNome As TextBox
  Friend WithEvents txtValor As TextBox
  Friend WithEvents btnVerificaNumero As Button
End Class
