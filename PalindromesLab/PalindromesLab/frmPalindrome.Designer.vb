<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPalindrome
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
        Me.lblPalindrome = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtPalindrome = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPalindrome
        '
        Me.lblPalindrome.AutoSize = True
        Me.lblPalindrome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPalindrome.ForeColor = System.Drawing.Color.White
        Me.lblPalindrome.Location = New System.Drawing.Point(12, 42)
        Me.lblPalindrome.Name = "lblPalindrome"
        Me.lblPalindrome.Size = New System.Drawing.Size(133, 20)
        Me.lblPalindrome.TabIndex = 0
        Me.lblPalindrome.Text = "Input Palindrome:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(300, 243)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(101, 72)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(183, 255)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 60)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtPalindrome
        '
        Me.txtPalindrome.Location = New System.Drawing.Point(163, 44)
        Me.txtPalindrome.Name = "txtPalindrome"
        Me.txtPalindrome.Size = New System.Drawing.Size(163, 20)
        Me.txtPalindrome.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblOutput.Location = New System.Drawing.Point(54, 126)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(315, 69)
        Me.lblOutput.TabIndex = 4
        '
        'frmPalindrome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(413, 327)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtPalindrome)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblPalindrome)
        Me.Name = "frmPalindrome"
        Me.Text = "Palindromes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPalindrome As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtPalindrome As TextBox
    Friend WithEvents lblOutput As Label
End Class
