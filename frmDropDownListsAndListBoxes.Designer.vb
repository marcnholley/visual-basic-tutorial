<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDropDownListsAndListBoxes
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
        Me.cbNumber = New System.Windows.Forms.ComboBox()
        Me.lbConcepts = New System.Windows.Forms.ListBox()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbNumber
        '
        Me.cbNumber.FormattingEnabled = True
        Me.cbNumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cbNumber.Location = New System.Drawing.Point(8, 41)
        Me.cbNumber.Name = "cbNumber"
        Me.cbNumber.Size = New System.Drawing.Size(34, 21)
        Me.cbNumber.TabIndex = 0
        '
        'lbConcepts
        '
        Me.lbConcepts.FormattingEnabled = True
        Me.lbConcepts.Location = New System.Drawing.Point(48, 41)
        Me.lbConcepts.Name = "lbConcepts"
        Me.lbConcepts.Size = New System.Drawing.Size(254, 95)
        Me.lbConcepts.TabIndex = 1
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(8, 12)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(69, 23)
        Me.btnInstructions.TabIndex = 3
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(83, 12)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(69, 23)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(158, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(233, 12)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(69, 23)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmDropDownListsAndListBoxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 146)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.lbConcepts)
        Me.Controls.Add(Me.cbNumber)
        Me.Name = "frmDropDownListsAndListBoxes"
        Me.Text = "Drop Down Lists And List Boxes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbNumber As System.Windows.Forms.ComboBox
    Friend WithEvents lbConcepts As System.Windows.Forms.ListBox
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnQuit As Button
End Class
