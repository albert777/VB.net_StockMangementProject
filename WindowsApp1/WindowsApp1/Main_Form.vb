Imports System.Data.SqlClient
Public Class Main_Form

    Dim connection As New SqlConnection("Server = DESKTOP-BGM0H05\SQLEXPRESS; Database = Mobile_DB; Integrated Security = true")

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bt_Delete.Click

        Delete_Form.Show()
        Me.Close()

    End Sub

    Private Sub Bt_Show_All_Click(sender As Object, e As EventArgs) Handles Bt_Show_All.Click

        Show_Table_Form.Show()
        Me.Close()

    End Sub

    Private Sub Bt_Logout_Click(sender As Object, e As EventArgs) Handles Bt_Logout.Click

        Login_Form.Show()
        Me.Close()
        MessageBox.Show("Sucessful Logout")

    End Sub

    Private Sub Bt_Insert_Click(sender As Object, e As EventArgs) Handles Bt_Insert.Click

        Insert_Form.Show()
        Me.Close()

    End Sub

    Private Sub Bt_Search_Click(sender As Object, e As EventArgs) Handles Bt_Search.Click

        Search_Form.Show()
        Me.Close()


    End Sub

    Private Sub Bt_Modify_Click(sender As Object, e As EventArgs) Handles Bt_Modify.Click

        Update_Form.Show()
        Me.Close()

    End Sub
End Class