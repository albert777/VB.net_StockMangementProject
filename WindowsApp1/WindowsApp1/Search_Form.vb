Imports System.Data.SqlClient
Public Class Search_Form

    Dim connection As New SqlConnection("Server = DESKTOP-BGM0H05\SQLEXPRESS; Database = Mobile_DB; Integrated Security = true")

    Private Sub Bt_Backward_Click(sender As Object, e As EventArgs) Handles Bt_Backward.Click

        Main_Form.Show()
        Me.Close()


    End Sub

    Public Sub FilterData(valueToSearch As String)

        Dim searchQuery As String = "SELECT * From Stock_List WHERE CONCAT(id, name, company) like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub Search_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FilterData("")

    End Sub

    Private Sub Bt_Search_Click(sender As Object, e As EventArgs) Handles Bt_Search.Click
        FilterData(Tb_SearchBar.Text)
    End Sub
End Class