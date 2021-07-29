<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formlogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Buttonlogin = New System.Windows.Forms.Button()
        Me.Buttoncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Admin "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(187, 54)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(161, 20)
        Me.txtUser.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(187, 93)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.txtPassword.Size = New System.Drawing.Size(161, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Buttonlogin
        '
        Me.Buttonlogin.Location = New System.Drawing.Point(77, 150)
        Me.Buttonlogin.Name = "Buttonlogin"
        Me.Buttonlogin.Size = New System.Drawing.Size(89, 46)
        Me.Buttonlogin.TabIndex = 4
        Me.Buttonlogin.Text = "Login"
        Me.Buttonlogin.UseVisualStyleBackColor = True
        '
        'Buttoncancel
        '
        Me.Buttoncancel.Location = New System.Drawing.Point(203, 150)
        Me.Buttoncancel.Name = "Buttoncancel"
        Me.Buttoncancel.Size = New System.Drawing.Size(88, 45)
        Me.Buttoncancel.TabIndex = 5
        Me.Buttoncancel.Text = "Cancel"
        Me.Buttoncancel.UseVisualStyleBackColor = True
        '
        'Formlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 233)
        Me.Controls.Add(Me.Buttoncancel)
        Me.Controls.Add(Me.Buttonlogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Buttonlogin As System.Windows.Forms.Button
    Friend WithEvents Buttoncancel As System.Windows.Forms.Button
End Class
