<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LibraryDataSet2 = New fedpoffa_digital_library.libraryDataSet2()
        Me.LibraryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryTableAdapter = New fedpoffa_digital_library.libraryDataSet2TableAdapters.libraryTableAdapter()
        Me.AppliedScienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnvironmentalStudiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommunicationAndInformationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolOfEngeneeringDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolOfManagementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppliedScienceDataGridViewTextBoxColumn, Me.EnvironmentalStudiesDataGridViewTextBoxColumn, Me.CommunicationAndInformationDataGridViewTextBoxColumn, Me.SchoolOfEngeneeringDataGridViewTextBoxColumn, Me.SchoolOfManagementDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LibraryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(604, 245)
        Me.DataGridView1.TabIndex = 0
        '
        'LibraryDataSet2
        '
        Me.LibraryDataSet2.DataSetName = "libraryDataSet2"
        Me.LibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryBindingSource
        '
        Me.LibraryBindingSource.DataMember = "library"
        Me.LibraryBindingSource.DataSource = Me.LibraryDataSet2
        '
        'LibraryTableAdapter
        '
        Me.LibraryTableAdapter.ClearBeforeFill = True
        '
        'AppliedScienceDataGridViewTextBoxColumn
        '
        Me.AppliedScienceDataGridViewTextBoxColumn.DataPropertyName = "Applied Science"
        Me.AppliedScienceDataGridViewTextBoxColumn.HeaderText = "Applied Science"
        Me.AppliedScienceDataGridViewTextBoxColumn.Name = "AppliedScienceDataGridViewTextBoxColumn"
        '
        'EnvironmentalStudiesDataGridViewTextBoxColumn
        '
        Me.EnvironmentalStudiesDataGridViewTextBoxColumn.DataPropertyName = "Environmental Studies"
        Me.EnvironmentalStudiesDataGridViewTextBoxColumn.HeaderText = "Environmental Studies"
        Me.EnvironmentalStudiesDataGridViewTextBoxColumn.Name = "EnvironmentalStudiesDataGridViewTextBoxColumn"
        '
        'CommunicationAndInformationDataGridViewTextBoxColumn
        '
        Me.CommunicationAndInformationDataGridViewTextBoxColumn.DataPropertyName = "Communication and Information"
        Me.CommunicationAndInformationDataGridViewTextBoxColumn.HeaderText = "Communication and Information"
        Me.CommunicationAndInformationDataGridViewTextBoxColumn.Name = "CommunicationAndInformationDataGridViewTextBoxColumn"
        '
        'SchoolOfEngeneeringDataGridViewTextBoxColumn
        '
        Me.SchoolOfEngeneeringDataGridViewTextBoxColumn.DataPropertyName = "School of Engeneering"
        Me.SchoolOfEngeneeringDataGridViewTextBoxColumn.HeaderText = "School of Engeneering"
        Me.SchoolOfEngeneeringDataGridViewTextBoxColumn.Name = "SchoolOfEngeneeringDataGridViewTextBoxColumn"
        '
        'SchoolOfManagementDataGridViewTextBoxColumn
        '
        Me.SchoolOfManagementDataGridViewTextBoxColumn.DataPropertyName = "School of Management"
        Me.SchoolOfManagementDataGridViewTextBoxColumn.HeaderText = "School of Management"
        Me.SchoolOfManagementDataGridViewTextBoxColumn.Name = "SchoolOfManagementDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(177, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "AVAILABLE BOOKS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(620, 334)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "available books"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LibraryDataSet2 As fedpoffa_digital_library.libraryDataSet2
    Friend WithEvents LibraryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryTableAdapter As fedpoffa_digital_library.libraryDataSet2TableAdapters.libraryTableAdapter
    Friend WithEvents AppliedScienceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnvironmentalStudiesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommunicationAndInformationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolOfEngeneeringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolOfManagementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
