<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Admin = New System.Windows.Forms.RichTextBox()
        Me.Password = New System.Windows.Forms.RichTextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.CrossBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Management System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'Admin
        '
        Me.Admin.BackColor = System.Drawing.Color.Orange
        Me.Admin.Location = New System.Drawing.Point(112, 193)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(230, 28)
        Me.Admin.TabIndex = 4
        Me.Admin.Text = ""
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.Orange
        Me.Password.Location = New System.Drawing.Point(112, 241)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(230, 28)
        Me.Password.TabIndex = 5
        Me.Password.Text = ""
        '
        'LoginBtn
        '
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LoginBtn.Location = New System.Drawing.Point(123, 289)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(204, 23)
        Me.LoginBtn.TabIndex = 6
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearBtn.Location = New System.Drawing.Point(123, 338)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(204, 23)
        Me.ClearBtn.TabIndex = 7
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'CrossBtn
        '
        Me.CrossBtn.BackColor = System.Drawing.Color.White
        Me.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CrossBtn.ForeColor = System.Drawing.Color.Red
        Me.CrossBtn.Location = New System.Drawing.Point(400, 0)
        Me.CrossBtn.Name = "CrossBtn"
        Me.CrossBtn.Size = New System.Drawing.Size(28, 23)
        Me.CrossBtn.TabIndex = 8
        Me.CrossBtn.Text = "X"
        Me.CrossBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Employee_MS_Project.My.Resources.Resources.e66784a8bb6c58cde81d1d16f4e60fba1
        Me.PictureBox1.Location = New System.Drawing.Point(157, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(428, 410)
        Me.Controls.Add(Me.CrossBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Admin As RichTextBox
    Friend WithEvents Password As RichTextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents CrossBtn As Button
End Class
