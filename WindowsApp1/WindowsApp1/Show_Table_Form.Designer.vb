<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_Table_Form
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
        Me.Bt_Backward = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(638, 339)
        Me.DataGridView1.TabIndex = 0
        '
        'Bt_Backward
        '
        Me.Bt_Backward.Location = New System.Drawing.Point(799, 214)
        Me.Bt_Backward.Name = "Bt_Backward"
        Me.Bt_Backward.Size = New System.Drawing.Size(121, 44)
        Me.Bt_Backward.TabIndex = 1
        Me.Bt_Backward.Text = "Main Page"
        Me.Bt_Backward.UseVisualStyleBackColor = True
        '
        'Show_Table_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 449)
        Me.Controls.Add(Me.Bt_Backward)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximumSize = New System.Drawing.Size(1048, 488)
        Me.Name = "Show_Table_Form"
        Me.Text = "Show_Table_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Bt_Backward As Button
End Class
