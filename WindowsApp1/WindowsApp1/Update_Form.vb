Imports System.Data.SqlClient

Public Class Update_Form

    Dim connection As New SqlConnection("Server = DESKTOP-BGM0H05\SQLEXPRESS; Database = Mobile_DB; Integrated Security = true")

    Private Sub Modify_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adapter As New SqlDataAdapter("Select * from Stock_List ", connection)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub Bt_Update_Click(sender As Object, e As EventArgs) Handles Bt_Update.Click

        Dim command As New SqlCommand("update Stock_List set name = @name, company = @company, stock = @stock, price = @price, market_price = @markprice where id = @id", connection)

        If Tb_Phone_Id.Text = "" Then
            MessageBox.Show("Please Enter Phone ID")

        Else
            command.Parameters.Add("@id", SqlDbType.Int).Value = Tb_Phone_Id.Text.ToString
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = Tb_Phone_Name.Text.ToString
            command.Parameters.Add("@company", SqlDbType.VarChar).Value = Tb_Phone_Company.Text.ToString
            command.Parameters.Add("@stock", SqlDbType.Int).Value = Tb_Phone_Stock.Text.ToString
            command.Parameters.Add("@price", SqlDbType.Int).Value = Tb_Price.Text.ToString
            command.Parameters.Add("@markprice", SqlDbType.Int).Value = Tb_Market_Price.Text.ToString

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Updated")
            Else
                MessageBox.Show("Data cannot be updade")
            End If

            connection.Close()
        End If

        Dim adapter As New SqlDataAdapter("Select * from Stock_List ", connection)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()


    End Sub

    Private Sub Bt_Backward_Click(sender As Object, e As EventArgs) Handles Bt_Backward.Click

        Main_Form.Show()
        Me.Close()

    End Sub
End Class