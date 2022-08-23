<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainPage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffUploadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllActivitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AVAILABLEBOOKSFORALLDEPTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffAttendanceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.BooksToolStripMenuItem, Me.StaffAttendanceToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(991, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffUploadToolStripMenuItem1, Me.AddUserToolStripMenuItem, Me.ViewAllActivitiesToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem1.Text = "Admin"
        '
        'StaffUploadToolStripMenuItem1
        '
        Me.StaffUploadToolStripMenuItem1.Name = "StaffUploadToolStripMenuItem1"
        Me.StaffUploadToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.StaffUploadToolStripMenuItem1.Text = "staff upload"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AddUserToolStripMenuItem.Text = "&Add User"
        '
        'ViewAllActivitiesToolStripMenuItem
        '
        Me.ViewAllActivitiesToolStripMenuItem.Name = "ViewAllActivitiesToolStripMenuItem"
        Me.ViewAllActivitiesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ViewAllActivitiesToolStripMenuItem.Text = "Usage report"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AVAILABLEBOOKSFORALLDEPTToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'AVAILABLEBOOKSFORALLDEPTToolStripMenuItem
        '
        Me.AVAILABLEBOOKSFORALLDEPTToolStripMenuItem.Name = "AVAILABLEBOOKSFORALLDEPTToolStripMenuItem"
        Me.AVAILABLEBOOKSFORALLDEPTToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.AVAILABLEBOOKSFORALLDEPTToolStripMenuItem.Text = "AVAILABLE BOOKS FOR ALL DEPT"
        '
        'StaffAttendanceToolStripMenuItem
        '
        Me.StaffAttendanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffAttendanceToolStripMenuItem1, Me.UsersAttendanceToolStripMenuItem})
        Me.StaffAttendanceToolStripMenuItem.Name = "StaffAttendanceToolStripMenuItem"
        Me.StaffAttendanceToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.StaffAttendanceToolStripMenuItem.Text = "Attendance"
        '
        'StaffAttendanceToolStripMenuItem1
        '
        Me.StaffAttendanceToolStripMenuItem1.Name = "StaffAttendanceToolStripMenuItem1"
        Me.StaffAttendanceToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.StaffAttendanceToolStripMenuItem1.Text = "Staff Attendance"
        '
        'UsersAttendanceToolStripMenuItem
        '
        Me.UsersAttendanceToolStripMenuItem.Name = "UsersAttendanceToolStripMenuItem"
        Me.UsersAttendanceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UsersAttendanceToolStripMenuItem.Text = "Users Attendance"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.fedpoffa_digital_library.My.Resources.Resources.Slide1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1006, 718)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FrmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(991, 685)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMainPage"
        Me.Text = "FrmMainPage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StaffUploadToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AVAILABLEBOOKSFORALLDEPTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllActivitiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffAttendanceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
