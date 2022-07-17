
Public Class Welcome

    Private Sub Button1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles Customerbtn.Click
        Me.Hide()

        Register.Show()

    End Sub
    Private Sub Button2_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles Adminbtn.Click
        Me.Hide()

        adminlogin.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
End Class
