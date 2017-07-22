<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Form
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
        Me.Bt_Backward = New System.Windows.Forms.Button()
        Me.Bt_Search = New System.Windows.Forms.Button()
        Me.Tb_SearchBar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bt_Backward
        '
        Me.Bt_Backward.Location = New System.Drawing.Point(119, 346)
        Me.Bt_Backward.Name = "Bt_Backward"
        Me.Bt_Backward.Size = New System.Drawing.Size(121, 44)
        Me.Bt_Backward.TabIndex = 20
        Me.Bt_Backward.Text = "Main Page"
        Me.Bt_Backward.UseVisualStyleBackColor = True
        '
        'Bt_Search
        '
        Me.Bt_Search.Location = New System.Drawing.Point(226, 178)
        Me.Bt_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_Search.Name = "Bt_Search"
        Me.Bt_Search.Size = New System.Drawing.Size(100, 28)
        Me.Bt_Search.TabIndex = 25
        Me.Bt_Search.Text = "Search"
        Me.Bt_Search.UseVisualStyleBackColor = True
        '
        'Tb_SearchBar
        '
        Me.Tb_SearchBar.Location = New System.Drawing.Point(86, 183)
        Me.Tb_SearchBar.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_SearchBar.Name = "Tb_SearchBar"
        Me.Tb_SearchBar.Size = New System.Drawing.Size(132, 20)
        Me.Tb_SearchBar.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Enter Phone ID, Name or Company to be Searched"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(423, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(575, 339)
        Me.DataGridView1.TabIndex = 26
        '
        'Search_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 449)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Bt_Search)
        Me.Controls.Add(Me.Tb_SearchBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt_Backward)
        Me.Name = "Search_Form"
        Me.Text = "Search_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bt_Backward As Button
    Friend WithEvents Bt_Search As Button
    Friend WithEvents Tb_SearchBar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
