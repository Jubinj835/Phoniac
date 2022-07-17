<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.CmbGender = New System.Windows.Forms.ComboBox()
        Me.Register_Now = New System.Windows.Forms.Button()
        Me.Existing_User = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Showpass1 = New System.Windows.Forms.Button()
        Me.Showpass2 = New System.Windows.Forms.Button()
        Me.Reg_cancel = New System.Windows.Forms.Button()
        Me.Txtconfirmpass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(136, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(136, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Password"
        '
        'Txtname
        '
        Me.Txtname.ForeColor = System.Drawing.Color.Black
        Me.Txtname.Location = New System.Drawing.Point(279, 77)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(121, 20)
        Me.Txtname.TabIndex = 6
        '
        'TxtPhone
        '
        Me.TxtPhone.ForeColor = System.Drawing.Color.Black
        Me.TxtPhone.Location = New System.Drawing.Point(279, 112)
        Me.TxtPhone.MaxLength = 10
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(121, 20)
        Me.TxtPhone.TabIndex = 7
        '
        'TxtEmail
        '
        Me.TxtEmail.ForeColor = System.Drawing.Color.Black
        Me.TxtEmail.Location = New System.Drawing.Point(279, 193)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(121, 20)
        Me.TxtEmail.TabIndex = 8
        '
        'TxtPass
        '
        Me.TxtPass.ForeColor = System.Drawing.Color.Black
        Me.TxtPass.Location = New System.Drawing.Point(279, 227)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(121, 20)
        Me.TxtPass.TabIndex = 9
        Me.TxtPass.UseSystemPasswordChar = True
        '
        'CmbGender
        '
        Me.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGender.FormattingEnabled = True
        Me.CmbGender.Items.AddRange(New Object() {"MALE", "FEMALE", "OTHERS"})
        Me.CmbGender.Location = New System.Drawing.Point(279, 152)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.Size = New System.Drawing.Size(121, 21)
        Me.CmbGender.TabIndex = 10
        '
        'Register_Now
        '
        Me.Register_Now.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Now.Location = New System.Drawing.Point(113, 315)
        Me.Register_Now.Name = "Register_Now"
        Me.Register_Now.Size = New System.Drawing.Size(139, 23)
        Me.Register_Now.TabIndex = 11
        Me.Register_Now.Text = "REGISTER NOW"
        Me.Register_Now.UseVisualStyleBackColor = True
        '
        'Existing_User
        '
        Me.Existing_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Existing_User.Location = New System.Drawing.Point(13, 13)
        Me.Existing_User.Name = "Existing_User"
        Me.Existing_User.Size = New System.Drawing.Size(120, 23)
        Me.Existing_User.TabIndex = 12
        Me.Existing_User.Text = "Already a User"
        Me.Existing_User.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(110, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Confirm Password"
        '
        'Showpass1
        '
        Me.Showpass1.BackColor = System.Drawing.Color.White
        Me.Showpass1.Image = Global.project.My.Resources.Resources.eye_icon1
        Me.Showpass1.Location = New System.Drawing.Point(428, 224)
        Me.Showpass1.Name = "Showpass1"
        Me.Showpass1.Size = New System.Drawing.Size(35, 20)
        Me.Showpass1.TabIndex = 15
        Me.Showpass1.UseVisualStyleBackColor = False
        '
        'Showpass2
        '
        Me.Showpass2.BackColor = System.Drawing.Color.White
        Me.Showpass2.Image = Global.project.My.Resources.Resources.eye_icon1
        Me.Showpass2.Location = New System.Drawing.Point(428, 265)
        Me.Showpass2.Name = "Showpass2"
        Me.Showpass2.Size = New System.Drawing.Size(35, 20)
        Me.Showpass2.TabIndex = 16
        Me.Showpass2.UseVisualStyleBackColor = False
        '
        'Reg_cancel
        '
        Me.Reg_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reg_cancel.Location = New System.Drawing.Point(292, 315)
        Me.Reg_cancel.Name = "Reg_cancel"
        Me.Reg_cancel.Size = New System.Drawing.Size(94, 23)
        Me.Reg_cancel.TabIndex = 17
        Me.Reg_cancel.Text = "CANCEL"
        Me.Reg_cancel.UseVisualStyleBackColor = True
        '
        'Txtconfirmpass
        '
        Me.Txtconfirmpass.ForeColor = System.Drawing.Color.Black
        Me.Txtconfirmpass.Location = New System.Drawing.Point(279, 265)
        Me.Txtconfirmpass.Name = "Txtconfirmpass"
        Me.Txtconfirmpass.Size = New System.Drawing.Size(121, 20)
        Me.Txtconfirmpass.TabIndex = 14
        Me.Txtconfirmpass.UseSystemPasswordChar = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project.My.Resources.Resources.Admin_workspace_image1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 350)
        Me.Controls.Add(Me.Reg_cancel)
        Me.Controls.Add(Me.Showpass2)
        Me.Controls.Add(Me.Showpass1)
        Me.Controls.Add(Me.Txtconfirmpass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Existing_User)
        Me.Controls.Add(Me.Register_Now)
        Me.Controls.Add(Me.CmbGender)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Register"
        Me.Text = "register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtname As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents CmbGender As ComboBox
    Friend WithEvents Register_Now As Button
    Friend WithEvents Existing_User As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Showpass1 As Button
    Friend WithEvents Showpass2 As Button
    Friend WithEvents Reg_cancel As Button
    Friend WithEvents Txtconfirmpass As TextBox
End Class
