Imports System.Data.SqlClient
Public Class adminlogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        If TextBox1.Text.Length <= 0 Then
            MessageBox.Show("Please enter your email id")
        ElseIf TextBox2.Text.Length <= 0 Then
            MessageBox.Show("Please enter your password")
        End If

        con1.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\just4\Desktop\project\Database2.mdf;Integrated Security=True"
        con1.Open()

        cmd1.Connection = con1
        cmd1.CommandText = "select emailid,password from admin"
        Dim dr1 As SqlDataReader
        dr1 = cmd1.ExecuteReader

        Dim flag As Boolean
        Do While dr1.Read
            If (dr1("emailid") = TextBox1.Text) And (dr1("password") = TextBox2.Text) Then
                flag = True
                Me.Hide()
                Adminworkspace.Show()
                Exit Do
            Else
                Continue Do

            End If
        Loop
        If flag = False Then
            MessageBox.Show("Enter correct credentials")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If
        dr1.Close()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Welcome.Show()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
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
End Class