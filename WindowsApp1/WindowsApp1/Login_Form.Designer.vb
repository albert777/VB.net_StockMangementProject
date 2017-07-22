<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_Username = New System.Windows.Forms.TextBox()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.Bt_Login = New System.Windows.Forms.Button()
        Me.Bt_Reset = New System.Windows.Forms.Button()
        Me.Bt_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(167, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Tb_Username
        '
        Me.Tb_Username.Location = New System.Drawing.Point(264, 126)
        Me.Tb_Username.Name = "Tb_Username"
        Me.Tb_Username.Size = New System.Drawing.Size(215, 20)
        Me.Tb_Username.TabIndex = 3
        '
        'Tb_Password
        '
        Me.Tb_Password.Location = New System.Drawing.Point(264, 171)
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tb_Password.Size = New System.Drawing.Size(215, 20)
        Me.Tb_Password.TabIndex = 4
        '
        'Bt_Login
        '
        Me.Bt_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Login.Location = New System.Drawing.Point(133, 223)
        Me.Bt_Login.Name = "Bt_Login"
        Me.Bt_Login.Size = New System.Drawing.Size(112, 37)
        Me.Bt_Login.TabIndex = 5
        Me.Bt_Login.Text = "Login"
        Me.Bt_Login.UseVisualStyleBackColor = True
        '
        'Bt_Reset
        '
        Me.Bt_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Reset.Location = New System.Drawing.Point(280, 223)
        Me.Bt_Reset.Name = "Bt_Reset"
        Me.Bt_Reset.Size = New System.Drawing.Size(112, 37)
        Me.Bt_Reset.TabIndex = 6
        Me.Bt_Reset.Text = "Reset"
        Me.Bt_Reset.UseVisualStyleBackColor = True
        '
        'Bt_Exit
        '
        Me.Bt_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Exit.Location = New System.Drawing.Point(421, 223)
        Me.Bt_Exit.Name = "Bt_Exit"
        Me.Bt_Exit.Size = New System.Drawing.Size(112, 37)
        Me.Bt_Exit.TabIndex = 7
        Me.Bt_Exit.Text = "Exit"
        Me.Bt_Exit.UseVisualStyleBackColor = True
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 368)
        Me.Controls.Add(Me.Bt_Exit)
        Me.Controls.Add(Me.Bt_Reset)
        Me.Controls.Add(Me.Bt_Login)
        Me.Controls.Add(Me.Tb_Password)
        Me.Controls.Add(Me.Tb_Username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(665, 407)
        Me.Name = "Login_Form"
        Me.Text = "Mobile Stock Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb_Username As TextBox
    Friend WithEvents Tb_Password As TextBox
    Friend WithEvents Bt_Login As Button
    Friend WithEvents Bt_Reset As Button
    Friend WithEvents Bt_Exit As Button
End Class
