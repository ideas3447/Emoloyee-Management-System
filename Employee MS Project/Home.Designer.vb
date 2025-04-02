<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.CrossBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeBtn = New System.Windows.Forms.Button()
        Me.SalaryBtn = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HOME"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(260, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "View Emloyee Information"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LogoutBtn
        '
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogoutBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.Location = New System.Drawing.Point(260, 343)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(188, 23)
        Me.LogoutBtn.TabIndex = 9
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'CrossBtn
        '
        Me.CrossBtn.BackColor = System.Drawing.Color.White
        Me.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CrossBtn.ForeColor = System.Drawing.Color.Red
        Me.CrossBtn.Location = New System.Drawing.Point(663, 0)
        Me.CrossBtn.Name = "CrossBtn"
        Me.CrossBtn.Size = New System.Drawing.Size(28, 23)
        Me.CrossBtn.TabIndex = 14
        Me.CrossBtn.Text = "X"
        Me.CrossBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 26)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Employee Management System"
        '
        'EmployeeBtn
        '
        Me.EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EmployeeBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeBtn.Location = New System.Drawing.Point(12, 222)
        Me.EmployeeBtn.Name = "EmployeeBtn"
        Me.EmployeeBtn.Size = New System.Drawing.Size(188, 23)
        Me.EmployeeBtn.TabIndex = 16
        Me.EmployeeBtn.Text = "Employee"
        Me.EmployeeBtn.UseVisualStyleBackColor = True
        '
        'SalaryBtn
        '
        Me.SalaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SalaryBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaryBtn.Location = New System.Drawing.Point(491, 222)
        Me.SalaryBtn.Name = "SalaryBtn"
        Me.SalaryBtn.Size = New System.Drawing.Size(188, 23)
        Me.SalaryBtn.TabIndex = 18
        Me.SalaryBtn.Text = "Salary"
        Me.SalaryBtn.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Employee_MS_Project.My.Resources.Resources.payroll_salary_icon
        Me.PictureBox5.Location = New System.Drawing.Point(552, 151)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(82, 56)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Employee_MS_Project.My.Resources.Resources.pngwing_com
        Me.PictureBox4.Location = New System.Drawing.Point(316, 271)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(84, 56)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Employee_MS_Project.My.Resources.Resources.search_user_icon
        Me.PictureBox3.Location = New System.Drawing.Point(320, 151)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(80, 56)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Employee_MS_Project.My.Resources.Resources.Team_Transparent_Background
        Me.PictureBox2.Location = New System.Drawing.Point(57, 151)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Employee_MS_Project.My.Resources.Resources._588a6758d06f6719692a2d22
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(691, 402)
        Me.Controls.Add(Me.SalaryBtn)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.EmployeeBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CrossBtn)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LogoutBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CrossBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents EmployeeBtn As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents SalaryBtn As Button
End Class
