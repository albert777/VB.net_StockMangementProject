Imports System.Data.DataTable

Public Class Insert_Form2

    Dim table As New DataTable("Table")

    Dim index As Integer

    Private Sub Insert_Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        table.Columns.Add("ID", Type.GetType("System.Int32"))
        table.Columns.Add("Product Name", Type.GetType("System.String"))
        table.Columns.Add("Product's Company Name", Type.GetType("System.String"))
        table.Columns.Add("Stock", Type.GetType("System.Int32"))

        DataGridView1.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        table.Rows.Add(Tb_Phone_Id.Text, Tb_Phone_Name.Text, Tb_Phone_Company.Text, Tb_Phone_Stock.Text)

        DataGridView1.DataSource = table

    End Sub
End Class