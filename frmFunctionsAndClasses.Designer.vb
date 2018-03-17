<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFunctionsAndClasses
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbOutput = New System.Windows.Forms.ListBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.cbNumber = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbOutput
        '
        Me.lbOutput.FormattingEnabled = True
        Me.lbOutput.Location = New System.Drawing.Point(12, 38)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(364, 95)
        Me.lbOutput.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(139, 12)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'cbNumber
        '
        Me.cbNumber.FormattingEnabled = True
        Me.cbNumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cbNumber.Location = New System.Drawing.Point(93, 14)
        Me.cbNumber.Name = "cbNumber"
        Me.cbNumber.Size = New System.Drawing.Size(40, 21)
        Me.cbNumber.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(220, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(12, 12)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(75, 23)
        Me.btnInstructions.TabIndex = 5
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(301, 12)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmFunctionsAndClasses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 146)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cbNumber)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lbOutput)
        Me.Name = "frmFunctionsAndClasses"
        Me.Text = "Functions And Classes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbOutput As ListBox
    Friend WithEvents btnShow As Button
    Friend WithEvents cbNumber As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnQuit As Button
End Class
