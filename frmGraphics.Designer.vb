<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraphics
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGraphics))
        Me.bpPap = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.bpPap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bpPap
        '
        Me.bpPap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bpPap.Image = CType(resources.GetObject("bpPap.Image"), System.Drawing.Image)
        Me.bpPap.Location = New System.Drawing.Point(-120, -136)
        Me.bpPap.Name = "bpPap"
        Me.bpPap.Size = New System.Drawing.Size(208, 170)
        Me.bpPap.TabIndex = 0
        Me.bpPap.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'frmGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(926, 540)
        Me.Controls.Add(Me.bpPap)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmGraphics"
        Me.Text = "Graphics"
        CType(Me.bpPap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bpPap As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
