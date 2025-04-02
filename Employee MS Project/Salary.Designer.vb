<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.En = New System.Windows.Forms.TextBox()
        Me.Eid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ep = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Wd = New System.Windows.Forms.TextBox()
        Me.SS = New System.Windows.Forms.RichTextBox()
        Me.CrossBtn = New System.Windows.Forms.Button()
        Me.FetchdataBtn = New System.Windows.Forms.Button()
        Me.ViewBtn = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Salary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 22)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Employee ID"
        '
        'En
        '
        Me.En.BackColor = System.Drawing.Color.Orange
        Me.En.Location = New System.Drawing.Point(174, 179)
        Me.En.Name = "En"
        Me.En.Size = New System.Drawing.Size(174, 20)
        Me.En.TabIndex = 15
        '
        'Eid
        '
        Me.Eid.BackColor = System.Drawing.Color.Orange
        Me.Eid.Location = New System.Drawing.Point(174, 114)
        Me.Eid.Name = "Eid"
        Me.Eid.Size = New System.Drawing.Size(174, 20)
        Me.Eid.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-2, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Employee Position"
        '
        'Ep
        '
        Me.Ep.BackColor = System.Drawing.Color.Orange
        Me.Ep.Location = New System.Drawing.Point(174, 247)
        Me.Ep.Name = "Ep"
        Me.Ep.Size = New System.Drawing.Size(174, 20)
        Me.Ep.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Working Days"
        '
        'Wd
        '
        Me.Wd.BackColor = System.Drawing.Color.Orange
        Me.Wd.Location = New System.Drawing.Point(174, 306)
        Me.Wd.Name = "Wd"
        Me.Wd.Size = New System.Drawing.Size(174, 20)
        Me.Wd.TabIndex = 19
        '
        'SS
        '
        Me.SS.BackColor = System.Drawing.Color.Orange
        Me.SS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SS.Location = New System.Drawing.Point(381, 79)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(395, 336)
        Me.SS.TabIndex = 20
        Me.SS.Text = ""
        '
        'CrossBtn
        '
        Me.CrossBtn.BackColor = System.Drawing.Color.White
        Me.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CrossBtn.ForeColor = System.Drawing.Color.Red
        Me.CrossBtn.Location = New System.Drawing.Point(766, 0)
        Me.CrossBtn.Name = "CrossBtn"
        Me.CrossBtn.Size = New System.Drawing.Size(34, 28)
        Me.CrossBtn.TabIndex = 27
        Me.CrossBtn.Text = "X"
        Me.CrossBtn.UseVisualStyleBackColor = False
        '
        'FetchdataBtn
        '
        Me.FetchdataBtn.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.FetchdataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FetchdataBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FetchdataBtn.Location = New System.Drawing.Point(12, 383)
        Me.FetchdataBtn.Name = "FetchdataBtn"
        Me.FetchdataBtn.Size = New System.Drawing.Size(100, 23)
        Me.FetchdataBtn.TabIndex = 28
        Me.FetchdataBtn.Text = "Fetch Data"
        Me.FetchdataBtn.UseVisualStyleBackColor = True
        '
        'ViewBtn
        '
        Me.ViewBtn.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ViewBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBtn.Location = New System.Drawing.Point(134, 383)
        Me.ViewBtn.Name = "ViewBtn"
        Me.ViewBtn.Size = New System.Drawing.Size(80, 23)
        Me.ViewBtn.TabIndex = 29
        Me.ViewBtn.Text = "View"
        Me.ViewBtn.UseVisualStyleBackColor = True
        '
        'HomeBtn
        '
        Me.HomeBtn.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HomeBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.Location = New System.Drawing.Point(240, 383)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(80, 23)
        Me.HomeBtn.TabIndex = 30
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Employee_MS_Project.My.Resources.Resources.payroll_salary_icon
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Salary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.ViewBtn)
        Me.Controls.Add(Me.FetchdataBtn)
        Me.Controls.Add(Me.CrossBtn)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.Wd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Ep)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.En)
        Me.Controls.Add(Me.Eid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Salary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALARY"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents En As TextBox
    Friend WithEvents Eid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Ep As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Wd As TextBox
    Friend WithEvents SS As RichTextBox
    Friend WithEvents CrossBtn As Button
    Friend WithEvents FetchdataBtn As Button
    Friend WithEvents ViewBtn As Button
    Friend WithEvents HomeBtn As Button
End Class
