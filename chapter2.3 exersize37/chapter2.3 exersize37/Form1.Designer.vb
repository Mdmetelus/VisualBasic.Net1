<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuote
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
        Me.txtQuote = New System.Windows.Forms.TextBox()
        Me.txtLife = New System.Windows.Forms.TextBox()
        Me.txtTruth = New System.Windows.Forms.TextBox()
        Me.txtFuture = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtQuote
        '
        Me.txtQuote.Location = New System.Drawing.Point(12, 38)
        Me.txtQuote.Name = "txtQuote"
        Me.txtQuote.ReadOnly = True
        Me.txtQuote.Size = New System.Drawing.Size(332, 20)
        Me.txtQuote.TabIndex = 0
        '
        'txtLife
        '
        Me.txtLife.Location = New System.Drawing.Point(12, 119)
        Me.txtLife.Name = "txtLife"
        Me.txtLife.Size = New System.Drawing.Size(100, 20)
        Me.txtLife.TabIndex = 1
        Me.txtLife.Text = "Life"
        '
        'txtTruth
        '
        Me.txtTruth.Location = New System.Drawing.Point(244, 119)
        Me.txtTruth.Name = "txtTruth"
        Me.txtTruth.Size = New System.Drawing.Size(100, 20)
        Me.txtTruth.TabIndex = 2
        Me.txtTruth.Text = "Truth"
        '
        'txtFuture
        '
        Me.txtFuture.Location = New System.Drawing.Point(129, 119)
        Me.txtFuture.Name = "txtFuture"
        Me.txtFuture.Size = New System.Drawing.Size(100, 20)
        Me.txtFuture.TabIndex = 3
        Me.txtFuture.Text = "Future"
        '
        'frmQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 200)
        Me.Controls.Add(Me.txtFuture)
        Me.Controls.Add(Me.txtTruth)
        Me.Controls.Add(Me.txtLife)
        Me.Controls.Add(Me.txtQuote)
        Me.Name = "frmQuote"
        Me.Text = "Sayings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtQuote As System.Windows.Forms.TextBox
    Friend WithEvents txtLife As System.Windows.Forms.TextBox
    Friend WithEvents txtTruth As System.Windows.Forms.TextBox
    Friend WithEvents txtFuture As System.Windows.Forms.TextBox

End Class
