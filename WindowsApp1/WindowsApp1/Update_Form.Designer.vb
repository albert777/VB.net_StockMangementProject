<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Form
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Tb_Market_Price = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tb_Price = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tb_Phone_Stock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Bt_Update = New System.Windows.Forms.Button()
        Me.Tb_Phone_Company = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb_Phone_Name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_Phone_Id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bt_Backward = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(339, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(638, 260)
        Me.DataGridView1.TabIndex = 35
        '
        'Tb_Market_Price
        '
        Me.Tb_Market_Price.Location = New System.Drawing.Point(159, 330)
        Me.Tb_Market_Price.Name = "Tb_Market_Price"
        Me.Tb_Market_Price.Size = New System.Drawing.Size(133, 20)
        Me.Tb_Market_Price.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Market Price"
        '
        'Tb_Price
        '
        Me.Tb_Price.Location = New System.Drawing.Point(159, 280)
        Me.Tb_Price.Name = "Tb_Price"
        Me.Tb_Price.Size = New System.Drawing.Size(133, 20)
        Me.Tb_Price.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Price"
        '
        'Tb_Phone_Stock
        '
        Me.Tb_Phone_Stock.Location = New System.Drawing.Point(159, 232)
        Me.Tb_Phone_Stock.Name = "Tb_Phone_Stock"
        Me.Tb_Phone_Stock.Size = New System.Drawing.Size(133, 20)
        Me.Tb_Phone_Stock.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(99, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = " Stock"
        '
        'Bt_Update
        '
        Me.Bt_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Update.Location = New System.Drawing.Point(578, 359)
        Me.Bt_Update.Name = "Bt_Update"
        Me.Bt_Update.Size = New System.Drawing.Size(151, 70)
        Me.Bt_Update.TabIndex = 28
        Me.Bt_Update.Text = "Update"
        Me.Bt_Update.UseVisualStyleBackColor = True
        '
        'Tb_Phone_Company
        '
        Me.Tb_Phone_Company.Location = New System.Drawing.Point(159, 188)
        Me.Tb_Phone_Company.Name = "Tb_Phone_Company"
        Me.Tb_Phone_Company.Size = New System.Drawing.Size(133, 20)
        Me.Tb_Phone_Company.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Phone's Company"
        '
        'Tb_Phone_Name
        '
        Me.Tb_Phone_Name.Location = New System.Drawing.Point(159, 138)
        Me.Tb_Phone_Name.Name = "Tb_Phone_Name"
        Me.Tb_Phone_Name.Size = New System.Drawing.Size(133, 20)
        Me.Tb_Phone_Name.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Phone Name"
        '
        'Tb_Phone_Id
        '
        Me.Tb_Phone_Id.Location = New System.Drawing.Point(159, 90)
        Me.Tb_Phone_Id.Name = "Tb_Phone_Id"
        Me.Tb_Phone_Id.Size = New System.Drawing.Size(133, 20)
        Me.Tb_Phone_Id.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Phone ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(528, 31)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cell Phone Inventory Management System"
        '
        'Bt_Backward
        '
        Me.Bt_Backward.Location = New System.Drawing.Point(900, 385)
        Me.Bt_Backward.Name = "Bt_Backward"
        Me.Bt_Backward.Size = New System.Drawing.Size(121, 44)
        Me.Bt_Backward.TabIndex = 20
        Me.Bt_Backward.Text = "Main Page"
        Me.Bt_Backward.UseVisualStyleBackColor = True
        '
        'Update_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 449)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Tb_Market_Price)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tb_Price)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tb_Phone_Stock)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Bt_Update)
        Me.Controls.Add(Me.Tb_Phone_Company)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tb_Phone_Name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tb_Phone_Id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt_Backward)
        Me.MaximumSize = New System.Drawing.Size(1048, 488)
        Me.Name = "Update_Form"
        Me.Text = "Modify_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Tb_Market_Price As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Tb_Price As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Tb_Phone_Stock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Bt_Update As Button
    Friend WithEvents Tb_Phone_Company As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Tb_Phone_Name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb_Phone_Id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Bt_Backward As Button
End Class
