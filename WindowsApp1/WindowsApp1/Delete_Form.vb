Imports System.Data.SqlClient
Public Class Delete_Form

    Dim connection As New SqlConnection("Server = DESKTOP-BGM0H05\SQLEXPRESS; Database = Mobile_DB; Integrated Security = true")

    Private Sub Bt_Main_Click(sender As Object, e As EventArgs) Handles Bt_Main.Click

        Main_Form.Show()
        Me.Close()

    End Sub

    Private Sub Detele_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adapter As New SqlDataAdapter("Select * from Stock_List ", connection)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.BeginExecuteNonQuery()
        connection.Close()

    End Sub

    Private Sub Bt_DeleteN_Click(sender As Object, e As EventArgs) Handles Bt_DeleteN.Click

        Dim command As New SqlCommand("delete from Stock_List where id = " & Tb_Delete.Text, connection)
        Dim table As New DataTable

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data has been Deleted")
        Else
            MessageBox.Show("Data cannot delete")
        End If

        Dim adapter As New SqlDataAdapter("Select * from Stock_List ", connection)
        adapter.Fill(table)

        DataGridView1.DataSource = table
        connection.Close()



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class