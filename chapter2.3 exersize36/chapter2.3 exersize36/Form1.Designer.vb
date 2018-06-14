<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm123
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
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.txtThree = New System.Windows.Forms.TextBox()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(28, 40)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(100, 20)
        Me.txtOne.TabIndex = 0
        Me.txtOne.Text = "One"
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(28, 112)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtTwo.TabIndex = 1
        Me.txtTwo.Text = "Two"
        '
        'txtThree
        '
        Me.txtThree.Location = New System.Drawing.Point(28, 196)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.Size = New System.Drawing.Size(100, 20)
        Me.txtThree.TabIndex = 2
        Me.txtThree.Text = "Three"
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(323, 40)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(163, 74)
        Me.btnLeft.TabIndex = 3
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(323, 139)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(163, 77)
        Me.btnRight.TabIndex = 4
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'frm123
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 261)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.txtThree)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtOne)
        Me.Name = "frm123"
        Me.Text = "One, Two, Three"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOne As System.Windows.Forms.TextBox
    Friend WithEvents txtTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtThree As System.Windows.Forms.TextBox
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button

End Class
