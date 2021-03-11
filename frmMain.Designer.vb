<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnAutoScaleNone = New System.Windows.Forms.Button()
        Me.btnAutoScaleFont = New System.Windows.Forms.Button()
        Me.btnAutoScaleDpi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAutoScaleNone
        '
        Me.btnAutoScaleNone.Location = New System.Drawing.Point(12, 12)
        Me.btnAutoScaleNone.Name = "btnAutoScaleNone"
        Me.btnAutoScaleNone.Size = New System.Drawing.Size(184, 77)
        Me.btnAutoScaleNone.TabIndex = 0
        Me.btnAutoScaleNone.Text = "AutoScale None"
        Me.btnAutoScaleNone.UseVisualStyleBackColor = True
        '
        'btnAutoScaleFont
        '
        Me.btnAutoScaleFont.Location = New System.Drawing.Point(12, 104)
        Me.btnAutoScaleFont.Name = "btnAutoScaleFont"
        Me.btnAutoScaleFont.Size = New System.Drawing.Size(184, 77)
        Me.btnAutoScaleFont.TabIndex = 1
        Me.btnAutoScaleFont.Text = "AutoScale Font"
        Me.btnAutoScaleFont.UseVisualStyleBackColor = True
        '
        'btnAutoScaleDpi
        '
        Me.btnAutoScaleDpi.Location = New System.Drawing.Point(12, 199)
        Me.btnAutoScaleDpi.Name = "btnAutoScaleDpi"
        Me.btnAutoScaleDpi.Size = New System.Drawing.Size(184, 77)
        Me.btnAutoScaleDpi.TabIndex = 2
        Me.btnAutoScaleDpi.Text = "AutoScale DPI"
        Me.btnAutoScaleDpi.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 290)
        Me.Controls.Add(Me.btnAutoScaleDpi)
        Me.Controls.Add(Me.btnAutoScaleFont)
        Me.Controls.Add(Me.btnAutoScaleNone)
        Me.Name = "frmMain"
        Me.Text = "AutoScale Test App"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAutoScaleNone As Button
    Friend WithEvents btnAutoScaleFont As Button
    Friend WithEvents btnAutoScaleDpi As Button
End Class
