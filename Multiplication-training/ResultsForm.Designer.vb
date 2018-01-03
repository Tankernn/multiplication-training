<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultsForm
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
        Me.lblPoäng = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.pbAndelrätt = New System.Windows.Forms.ProgressBar()
        Me.lblAndel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPoäng
        '
        Me.lblPoäng.BackColor = System.Drawing.Color.White
        Me.lblPoäng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoäng.Location = New System.Drawing.Point(12, 9)
        Me.lblPoäng.Name = "lblPoäng"
        Me.lblPoäng.Size = New System.Drawing.Size(260, 172)
        Me.lblPoäng.TabIndex = 0
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(13, 235)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(259, 23)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'pbAndelrätt
        '
        Me.pbAndelrätt.Location = New System.Drawing.Point(13, 206)
        Me.pbAndelrätt.Name = "pbAndelrätt"
        Me.pbAndelrätt.Size = New System.Drawing.Size(259, 23)
        Me.pbAndelrätt.TabIndex = 2
        '
        'lblAndel
        '
        Me.lblAndel.AutoSize = True
        Me.lblAndel.Location = New System.Drawing.Point(16, 185)
        Me.lblAndel.Name = "lblAndel"
        Me.lblAndel.Size = New System.Drawing.Size(101, 13)
        Me.lblAndel.TabIndex = 3
        Me.lblAndel.Text = "Percentage correct:"
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblAndel)
        Me.Controls.Add(Me.pbAndelrätt)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblPoäng)
        Me.Name = "Results"
        Me.Text = "Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPoäng As System.Windows.Forms.Label
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents pbAndelrätt As System.Windows.Forms.ProgressBar
    Friend WithEvents lblAndel As System.Windows.Forms.Label
End Class
