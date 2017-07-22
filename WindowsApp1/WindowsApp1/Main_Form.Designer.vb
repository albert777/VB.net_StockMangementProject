<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bt_Insert = New System.Windows.Forms.Button()
        Me.Bt_Delete = New System.Windows.Forms.Button()
        Me.Bt_Modify = New System.Windows.Forms.Button()
        Me.Bt_Show_All = New System.Windows.Forms.Button()
        Me.Bt_Logout = New System.Windows.Forms.Button()
        Me.Bt_Search = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mobile Inventory Management System"
        '
        'Bt_Insert
        '
        Me.Bt_Insert.Location = New System.Drawing.Point(112, 131)
        Me.Bt_Insert.Name = "Bt_Insert"
        Me.Bt_Insert.Size = New System.Drawing.Size(101, 31)
        Me.Bt_Insert.TabIndex = 1
        Me.Bt_Insert.Text = "Insert"
        Me.Bt_Insert.UseVisualStyleBackColor = True
        '
        'Bt_Delete
        '
        Me.Bt_Delete.Location = New System.Drawing.Point(112, 203)
        Me.Bt_Delete.Name = "Bt_Delete"
        Me.Bt_Delete.Size = New System.Drawing.Size(101, 31)
        Me.Bt_Delete.TabIndex = 2
        Me.Bt_Delete.Text = "Delete"
        Me.Bt_Delete.UseVisualStyleBackColor = True
        '
        'Bt_Modify
        '
        Me.Bt_Modify.Location = New System.Drawing.Point(265, 131)
        Me.Bt_Modify.Name = "Bt_Modify"
        Me.Bt_Modify.Size = New System.Drawing.Size(101, 31)
        Me.Bt_Modify.TabIndex = 2
        Me.Bt_Modify.Text = "Update"
        Me.Bt_Modify.UseVisualStyleBackColor = True
        '
        'Bt_Show_All
        '
        Me.Bt_Show_All.Location = New System.Drawing.Point(428, 131)
        Me.Bt_Show_All.Name = "Bt_Show_All"
        Me.Bt_Show_All.Size = New System.Drawing.Size(101, 31)
        Me.Bt_Show_All.TabIndex = 8
        Me.Bt_Show_All.Text = "Show All"
        Me.Bt_Show_All.UseVisualStyleBackColor = True
        '
        'Bt_Logout
        '
        Me.Bt_Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Logout.Location = New System.Drawing.Point(428, 203)
        Me.Bt_Logout.Name = "Bt_Logout"
        Me.Bt_Logout.Size = New System.Drawing.Size(101, 31)
        Me.Bt_Logout.TabIndex = 9
        Me.Bt_Logout.Text = "Log out"
        Me.Bt_Logout.UseVisualStyleBackColor = True
        '
        'Bt_Search
        '
        Me.Bt_Search.Location = New System.Drawing.Point(265, 203)
        Me.Bt_Search.Name = "Bt_Search"
        Me.Bt_Search.Size = New System.Drawing.Size(101, 31)
        Me.Bt_Search.TabIndex = 10
        Me.Bt_Search.Text = "Search"
        Me.Bt_Search.UseVisualStyleBackColor = True
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 368)
        Me.Controls.Add(Me.Bt_Search)
        Me.Controls.Add(Me.Bt_Logout)
        Me.Controls.Add(Me.Bt_Show_All)
        Me.Controls.Add(Me.Bt_Modify)
        Me.Controls.Add(Me.Bt_Delete)
        Me.Controls.Add(Me.Bt_Insert)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(665, 407)
        Me.Name = "Main_Form"
        Me.Text = "Main_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Bt_Insert As Button
    Friend WithEvents Bt_Delete As Button
    Friend WithEvents Bt_Modify As Button
    Friend WithEvents Bt_Show_All As Button
    Friend WithEvents Bt_Logout As Button
    Friend WithEvents Bt_Search As Button
End Class
