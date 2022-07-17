Imports System.Data.SqlClient

Public Class Register
    Private Sub Reg_cancel_Click(sender As Object, e As EventArgs) Handles Reg_cancel.Click
        Me.Hide()
        Welcome.Show()
    End Sub


    Private Sub Existing_User_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Existing_User.Click
        Loginform.Show()

    End Sub
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Txtname.Leave, Txtname.Enter
        Me.Hide()
        Welcome.Show()


    End Sub

    Private Sub TxtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmail.KeyPress
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

    Private Sub Txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("Please Enter a Character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress

        Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please Enter a Valid Phone Number !")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

    End Sub





    Private Sub Register_Now_Click(sender As Object, e As EventArgs) Handles Register_Now.Click
        If TxtEmail.Text.Contains("@") And TxtEmail.Text.Contains(".") Then

            Dim con As New SqlConnection
                Dim cmd As New SqlCommand
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\just4\Desktop\project\Database2.mdf;Integrated Security=True"
            con.Open()
            If (Txtname.Text = "" Or TxtPhone.Text = "" Or CmbGender.Text = "" Or TxtPass.Text = "") Then
                MessageBox.Show("Please Enter the Details")
            Else
                cmd.Connection = con


                cmd.CommandText = "INSERT INTO logins(Name,Phone,EmailID,Password,Gender) VALUES(@Name,@Phone,@EmailID,@Password,@Gender)"
                    Dim ParamName As New SqlParameter("@Name", SqlDbType.VarChar, 50)
                    ParamName.Value = Txtname.Text
                Dim ParamPhone As New SqlParameter("@Phone", SqlDbType.VarChar, 50)
                ParamPhone.Value = TxtPhone.Text
                    Dim ParamEmailID As New SqlParameter("@EmailID", SqlDbType.VarChar, 50)
                    ParamEmailID.Value = TxtEmail.Text
                Dim ParamPassword As New SqlParameter("@Password", SqlDbType.VarChar, 50)
                ParamPassword.Value = TxtPass.Text

                Dim ParamGender As New SqlParameter("@Gender", SqlDbType.VarChar, 50)
                    ParamGender.Value = CmbGender.SelectedItem.ToString
                    cmd.Parameters.Add(ParamName)
                    cmd.Parameters.Add(ParamPhone)
                    cmd.Parameters.Add(ParamEmailID)
                    cmd.Parameters.Add(ParamPassword)
                    cmd.Parameters.Add(ParamGender)
                Dim d As New SqlDataAdapter
                d.InsertCommand = cmd


                d.InsertCommand.ExecuteNonQuery()


                MsgBox("User Registered Successfully .", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    Loginform.Show()
                    Txtname.Clear()
                    TxtPhone.Clear()
                    TxtEmail.Clear()
                    TxtPass.Clear()
                    Txtconfirmpass.Clear()

                End If
                con.Close()

                Else
            MsgBox("Please Enter valid Email ID !")

        End If
    End Sub

    Private Sub Showpass1_Click(sender As Object, e As EventArgs) Handles Showpass1.Click
        If TxtPass.UseSystemPasswordChar = True Then
            TxtPass.UseSystemPasswordChar = False
        Else
            TxtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Showpass2_Click(sender As Object, e As EventArgs) Handles Showpass2.Click
        If Txtconfirmpass.UseSystemPasswordChar = True Then
            Txtconfirmpass.UseSystemPasswordChar = False
        Else
            Txtconfirmpass.UseSystemPasswordChar = True
        End If
    End Sub
End Class