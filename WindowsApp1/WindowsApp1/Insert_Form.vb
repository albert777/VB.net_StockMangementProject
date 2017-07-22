Imports System.Data.SqlClient

Public Class Insert_Form

    Dim connection As New SqlConnection("Server = DESKTOP-BGM0H05\SQLEXPRESS; Database = Mobile_DB; Integrated Security = true")

    Private Sub Bt_Backward_Click(sender As Object, e As EventArgs) Handles Bt_Backward.Click

        Main_Form.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim command As New SqlCommand("insert into Stock_List(id, name, company, stock, price, market_price) values('" & Tb_Phone_Id.Text & "','" & Tb_Phone_Name.Text & "','" & Tb_Phone_Company.Text & "','" & Tb_Phone_Stock.Text & "','" & Tb_Price.Text & "'," & Tb_Marrket_Price.Text & ") ", connection)
        Dim table As New DataTable

        connection.Open()

        If ((Tb_Phone_Id.Text = "") Or (Tb_Phone_Name.Text = "") Or (Tb_Phone_Company.Text = "") Or (Tb_Phone_Stock.Text = "") Or (Tb_Price.Text = "") Or (Tb_Marrket_Price.Text = "")) Then
            MessageBox.Show("Data cannot be empty")
        ElseIf command.ExecuteNonQuery() = 1 Then
            Tb_Phone_Id.Text = ""
            Tb_Phone_Name.Text = ""
            Tb_Phone_Company.Text = ""
            Tb_Phone_Stock.Text = ""
            Tb_Price.Text = ""
            Tb_Marrket_Price.Text = ""
            MessageBox.Show("New Data Added")
        Else
            MessageBox.Show("Data cannot be added")
        End If

        Dim adapter As New SqlDataAdapter("Select * from Stock_List ", connection)
        adapter.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()

    End Sub

    Private Sub Insert_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adapter As New SqlDataAdapter("Select * from Stock_List ", connection)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub
End Class