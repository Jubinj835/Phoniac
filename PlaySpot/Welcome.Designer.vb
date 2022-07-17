<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Customerbtn = New System.Windows.Forms.Button()
        Me.Adminbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Customerbtn
        '
        Me.Customerbtn.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Customerbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Customerbtn.FlatAppearance.BorderSize = 0
        Me.Customerbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Customerbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Customerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Customerbtn.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customerbtn.ForeColor = System.Drawing.Color.White
        Me.Customerbtn.Location = New System.Drawing.Point(496, 208)
        Me.Customerbtn.Name = "Customerbtn"
        Me.Customerbtn.Size = New System.Drawing.Size(95, 41)
        Me.Customerbtn.TabIndex = 0
        Me.Customerbtn.Text = "Customer"
        Me.Customerbtn.UseVisualStyleBackColor = False
        '
        'Adminbtn
        '
        Me.Adminbtn.BackColor = System.Drawing.Color.Orange
        Me.Adminbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Adminbtn.FlatAppearance.BorderSize = 0
        Me.Adminbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Adminbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Adminbtn.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adminbtn.ForeColor = System.Drawing.Color.White
        Me.Adminbtn.Image = Global.project.My.Resources.Resources.Admin_icon
        Me.Adminbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Adminbtn.Location = New System.Drawing.Point(496, 37)
        Me.Adminbtn.Name = "Adminbtn"
        Me.Adminbtn.Size = New System.Drawing.Size(95, 41)
        Me.Adminbtn.TabIndex = 1
        Me.Adminbtn.Text = "Admin"
        Me.Adminbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Adminbtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(186, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 59)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PLAYSPOT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PLAY BOLD . PLAY HARD"
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project.My.Resources.Resources.Welcome_image
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(607, 358)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Adminbtn)
        Me.Controls.Add(Me.Customerbtn)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Welcome"
        Me.Text = "PlaySpot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Customerbtn As Button
    Friend WithEvents Adminbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
