Imports System.Data.SqlClient

Public Class Show_Table_Form

    Dim connection As New SqlConnection("Server = DESKTOP-BGM0H05\SQLEXPRESS; Database = Mobile_DB; Integrated Security = true")

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Bt_Backward_Click(sender As Object, e As EventArgs) Handles Bt_Backward.Click

        Main_Form.Show()
        Me.Close()

    End Sub

    Private Sub Show_Table_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adapter As New SqlDataAdapter("Select * from Stock_List ", connection)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub
End Class