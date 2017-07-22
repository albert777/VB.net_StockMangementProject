Imports System.Data.SqlClient
Public Class Login_Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Bt_Exit.Click
        End
    End Sub

    Private Sub Bt_Ok_Click(sender As Object, e As EventArgs) Handles Bt_Login.Click

        Dim connection As New SqlConnection("Server = DESKTOP-BGM0H05\SQLEXPRESS; Database = Mobile_DB; Integrated Security = true")
        Dim command As New SqlCommand("Select * from admin_login where Username = @username and Password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = Tb_Username.Text.ToString
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = Tb_Password.Text.ToString


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password are Invalid!")
        Else
            MessageBox.Show("Login Successful")
            Main_Form.Show()
            Close()
        End If

    End Sub

    Private Sub Bt_Reset_Click(sender As Object, e As EventArgs) Handles Bt_Reset.Click

        Tb_Username.Text = ""
        Tb_Password.Text = ""

    End Sub
End Class
