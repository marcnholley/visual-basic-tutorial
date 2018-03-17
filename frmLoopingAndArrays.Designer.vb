<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoopingAndArrays
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
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.lbOutput = New System.Windows.Forms.ListBox()
        Me.btnConcepts = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(12, 12)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(70, 23)
        Me.btnInstructions.TabIndex = 0
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'lbOutput
        '
        Me.lbOutput.FormattingEnabled = True
        Me.lbOutput.Location = New System.Drawing.Point(12, 42)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(260, 95)
        Me.lbOutput.TabIndex = 1
        '
        'btnConcepts
        '
        Me.btnConcepts.Location = New System.Drawing.Point(105, 12)
        Me.btnConcepts.Name = "btnConcepts"
        Me.btnConcepts.Size = New System.Drawing.Size(70, 23)
        Me.btnConcepts.TabIndex = 2
        Me.btnConcepts.Text = "Concepts"
        Me.btnConcepts.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(202, 12)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(70, 23)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmLoopingAndArrays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 155)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnConcepts)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.btnInstructions)
        Me.Name = "frmLoopingAndArrays"
        Me.Text = "Looping And Arrays"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInstructions As Button
    Friend WithEvents lbOutput As ListBox
    Friend WithEvents btnConcepts As Button
    Friend WithEvents btnQuit As Button
End Class
