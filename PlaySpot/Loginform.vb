Imports System.Data.SqlClient


Public Class Loginform


    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        If Email.Text.Length <= 0 Then
            MessageBox.Show("Please enter your email id")
        ElseIf Password.Text.Length <= 0 Then
            MessageBox.Show("Please enter your password")
        End If

        con1.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\just4\Desktop\project\Database2.mdf;Integrated Security=True"
        con1.Open()

        cmd1.Connection = con1
        cmd1.CommandText = "select EmailID,Password from logins"
        Dim dr1 As SqlDataReader
        dr1 = cmd1.ExecuteReader

        Dim flag As Boolean
        Do While dr1.Read
            If (dr1("EmailID") = Email.Text) And (dr1("Password") = Password.Text) Then
                flag = True
                Me.Hide()
                SportsCategory.Show()
                Exit Do
            Else
                Continue Do

            End If
        Loop
        If flag = False Then
            MessageBox.Show("Enter correct credentials")
            Email.Text = ""
            Password.Text = ""

        End If
        dr1.Close()

    End Sub

    Private Sub Email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Email.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            Dim allowednos As String = "1234567890"
            Dim allowedsymbols As String = "@."
            If Not allowednos.Contains(e.KeyChar.ToString) And Not allowedchars.Contains(e.KeyChar.ToString.ToLower) And Not allowedsymbols.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please Enter a Valid Email ID !")
                e.KeyChar = ChrW(0)
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub Email_TextChanged(sender As Object, e As EventArgs) Handles Email.TextChanged

    End Sub
End Class