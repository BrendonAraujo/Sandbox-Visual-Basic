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
    Me.btnLoopWhile = New System.Windows.Forms.Button()
    Me.lstDados = New System.Windows.Forms.ListBox()
    Me.SuspendLayout()
    '
    'btnLoopWhile
    '
    Me.btnLoopWhile.Location = New System.Drawing.Point(368, 12)
    Me.btnLoopWhile.Name = "btnLoopWhile"
    Me.btnLoopWhile.Size = New System.Drawing.Size(145, 41)
    Me.btnLoopWhile.TabIndex = 0
    Me.btnLoopWhile.Text = "Loop While"
    Me.btnLoopWhile.UseVisualStyleBackColor = True
    '
    'lstDados
    '
    Me.lstDados.FormattingEnabled = True
    Me.lstDados.ItemHeight = 16
    Me.lstDados.Location = New System.Drawing.Point(0, 0)
    Me.lstDados.Name = "lstDados"
    Me.lstDados.Size = New System.Drawing.Size(362, 260)
    Me.lstDados.TabIndex = 1
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(525, 261)
    Me.Controls.Add(Me.lstDados)
    Me.Controls.Add(Me.btnLoopWhile)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents btnLoopWhile As Button
  Friend WithEvents lstDados As ListBox
End Class
