<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSum
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(55, 141)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(170, 20)
        Me.txtOutput.TabIndex = 3
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(55, 36)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(170, 48)
        Me.btnSum.TabIndex = 2
        Me.btnSum.Text = "Find sum of 1 through 100"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'frmSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 207)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnSum)
        Me.Name = "frmSum"
        Me.Text = "Sum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnSum As System.Windows.Forms.Button

End Class
