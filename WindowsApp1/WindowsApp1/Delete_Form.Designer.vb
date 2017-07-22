<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Delete_Form
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
        Me.Tb_Delete = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Bt_Main = New System.Windows.Forms.Button()
        Me.Bt_DeleteN = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a Product ID to be deleted"
        '
        'Tb_Delete
        '
        Me.Tb_Delete.Location = New System.Drawing.Point(70, 128)
        Me.Tb_Delete.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Delete.Name = "Tb_Delete"
        Me.Tb_Delete.Size = New System.Drawing.Size(132, 23)
        Me.Tb_Delete.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(369, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(638, 339)
        Me.DataGridView1.TabIndex = 4
        '
        'Bt_Main
        '
        Me.Bt_Main.Location = New System.Drawing.Point(139, 342)
        Me.Bt_Main.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_Main.Name = "Bt_Main"
        Me.Bt_Main.Size = New System.Drawing.Size(109, 34)
        Me.Bt_Main.TabIndex = 5
        Me.Bt_Main.Text = "Main Menu"
        Me.Bt_Main.UseVisualStyleBackColor = True
        '
        'Bt_DeleteN
        '
        Me.Bt_DeleteN.Location = New System.Drawing.Point(220, 125)
        Me.Bt_DeleteN.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_DeleteN.Name = "Bt_DeleteN"
        Me.Bt_DeleteN.Size = New System.Drawing.Size(100, 28)
        Me.Bt_DeleteN.TabIndex = 6
        Me.Bt_DeleteN.Text = "Delete"
        Me.Bt_DeleteN.UseVisualStyleBackColor = True
        '
        'Delete_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 449)
        Me.Controls.Add(Me.Bt_DeleteN)
        Me.Controls.Add(Me.Bt_Main)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Tb_Delete)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1048, 488)
        Me.Name = "Delete_Form"
        Me.Text = "Detele_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_Delete As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Bt_Main As Button
    Friend WithEvents Bt_DeleteN As Button
End Class
