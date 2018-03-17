<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLINQAndTextFiles
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
        Me.btnConcepts = New System.Windows.Forms.Button()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConcepts
        '
        Me.btnConcepts.Location = New System.Drawing.Point(12, 12)
        Me.btnConcepts.Name = "btnConcepts"
        Me.btnConcepts.Size = New System.Drawing.Size(83, 22)
        Me.btnConcepts.TabIndex = 0
        Me.btnConcepts.Text = "Concepts"
        Me.btnConcepts.UseVisualStyleBackColor = True
        '
        'dgvOutput
        '
        Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(12, 40)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.Size = New System.Drawing.Size(374, 161)
        Me.dgvOutput.TabIndex = 1
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(156, 12)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(83, 23)
        Me.btnInstructions.TabIndex = 2
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(303, 11)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(83, 23)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmLINQAndTextFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 213)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.btnConcepts)
        Me.Name = "frmLINQAndTextFiles"
        Me.Text = "LINQ And Text Files"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConcepts As Button
    Friend WithEvents dgvOutput As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnQuit As Button
End Class
