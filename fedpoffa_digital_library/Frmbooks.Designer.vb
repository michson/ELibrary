<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmbooks
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmbooks))
        Me.AxFoxitCtl1 = New AxFOXITREADERLib.AxFoxitCtl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.BooksTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._MyDatabase_1DataSet = New fedpoffa_digital_library._MyDatabase_1DataSet()
        Me.Books_TBTableAdapter = New fedpoffa_digital_library._MyDatabase_1DataSetTableAdapters.Books_TBTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.AxFoxitCtl2 = New AxFOXITREADERLib.AxFoxitCtl()
        CType(Me.AxFoxitCtl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._MyDatabase_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxFoxitCtl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxFoxitCtl1
        '
        Me.AxFoxitCtl1.Enabled = True
        Me.AxFoxitCtl1.Location = New System.Drawing.Point(302, 12)
        Me.AxFoxitCtl1.Name = "AxFoxitCtl1"
        Me.AxFoxitCtl1.OcxState = CType(resources.GetObject("AxFoxitCtl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxFoxitCtl1.Size = New System.Drawing.Size(593, 684)
        Me.AxFoxitCtl1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SEARCH  "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lstBooks
        '
        Me.lstBooks.BackColor = System.Drawing.Color.AliceBlue
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.Items.AddRange(New Object() {"ANDROID", "FinalReport.pdf"})
        Me.lstBooks.Location = New System.Drawing.Point(12, 53)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(203, 264)
        Me.lstBooks.TabIndex = 3
        '
        'BooksTBBindingSource
        '
        Me.BooksTBBindingSource.DataMember = "Books_TB"
        Me.BooksTBBindingSource.DataSource = Me._MyDatabase_1DataSet
        '
        '_MyDatabase_1DataSet
        '
        Me._MyDatabase_1DataSet.DataSetName = "_MyDatabase_1DataSet"
        Me._MyDatabase_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Books_TBTableAdapter
        '
        Me.Books_TBTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(13, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Availlable Book To Read"
        '
        'btnPreview
        '
        Me.btnPreview.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnPreview.Location = New System.Drawing.Point(221, 53)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 5
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'AxFoxitCtl2
        '
        Me.AxFoxitCtl2.Enabled = True
        Me.AxFoxitCtl2.Location = New System.Drawing.Point(221, 143)
        Me.AxFoxitCtl2.Name = "AxFoxitCtl2"
        Me.AxFoxitCtl2.OcxState = CType(resources.GetObject("AxFoxitCtl2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxFoxitCtl2.Size = New System.Drawing.Size(75, 77)
        Me.AxFoxitCtl2.TabIndex = 6
        '
        'Frmbooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 745)
        Me.Controls.Add(Me.AxFoxitCtl2)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBooks)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AxFoxitCtl1)
        Me.Name = "Frmbooks"
        Me.Text = "Frmbooks"
        CType(Me.AxFoxitCtl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._MyDatabase_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxFoxitCtl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxFoxitCtl1 As AxFOXITREADERLib.AxFoxitCtl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lstBooks As System.Windows.Forms.ListBox
    Friend WithEvents _MyDatabase_1DataSet As fedpoffa_digital_library._MyDatabase_1DataSet
    Friend WithEvents BooksTBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Books_TBTableAdapter As fedpoffa_digital_library._MyDatabase_1DataSetTableAdapters.Books_TBTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents AxFoxitCtl2 As AxFOXITREADERLib.AxFoxitCtl
End Class
