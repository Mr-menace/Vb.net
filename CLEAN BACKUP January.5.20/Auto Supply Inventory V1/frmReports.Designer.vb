<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.TbProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProductsTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbProductsTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        Me.TbProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TbProductsDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbPOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbPOSTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbPOSTableAdapter()
        Me.TbPOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProductsDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AutosupplyDataSet
        '
        Me.AutosupplyDataSet.DataSetName = "autosupplyDataSet"
        Me.AutosupplyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbProductsBindingSource
        '
        Me.TbProductsBindingSource.DataMember = "tbProducts"
        Me.TbProductsBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'TbProductsTableAdapter
        '
        Me.TbProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tbBrandTableAdapter = Nothing
        Me.TableAdapterManager.tbNameTableAdapter = Nothing
        Me.TableAdapterManager.tbPOSTableAdapter = Nothing
        Me.TableAdapterManager.tbProductsTableAdapter = Me.TbProductsTableAdapter
        Me.TableAdapterManager.tbQualityTableAdapter = Nothing
        Me.TableAdapterManager.tbReturnedTableAdapter = Nothing
        Me.TableAdapterManager.tbSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbtimeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbProductsDataGridView
        '
        Me.TbProductsDataGridView.AllowUserToAddRows = False
        Me.TbProductsDataGridView.AutoGenerateColumns = False
        Me.TbProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12})
        Me.TbProductsDataGridView.DataSource = Me.TbProductsBindingSource
        Me.TbProductsDataGridView.Location = New System.Drawing.Point(3, 35)
        Me.TbProductsDataGridView.Name = "TbProductsDataGridView"
        Me.TbProductsDataGridView.ReadOnly = True
        Me.TbProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TbProductsDataGridView.Size = New System.Drawing.Size(414, 162)
        Me.TbProductsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Brand"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PartNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PartNo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Quality"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quality"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Supplier"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "BarcodeEncode"
        Me.DataGridViewTextBoxColumn9.HeaderText = "BarcodeEncode"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "OrigPrice"
        Me.DataGridViewTextBoxColumn12.HeaderText = "OrigPrice"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(451, 35)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(350, 162)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'TbProductsDataGridView1
        '
        Me.TbProductsDataGridView1.AllowUserToAddRows = False
        Me.TbProductsDataGridView1.AutoGenerateColumns = False
        Me.TbProductsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbProductsDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17})
        Me.TbProductsDataGridView1.DataSource = Me.TbProductsBindingSource
        Me.TbProductsDataGridView1.Location = New System.Drawing.Point(3, 254)
        Me.TbProductsDataGridView1.Name = "TbProductsDataGridView1"
        Me.TbProductsDataGridView1.Size = New System.Drawing.Size(414, 220)
        Me.TbProductsDataGridView1.TabIndex = 2
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Supplier"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "BarcodeEncode"
        Me.DataGridViewTextBoxColumn17.HeaderText = "BarcodeEncode"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Daily Stocks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Daily inventory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(578, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "View Developer Mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(448, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Daily Purchase"
        '
        'TbPOSBindingSource
        '
        Me.TbPOSBindingSource.DataMember = "tbPOS"
        Me.TbPOSBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'TbPOSTableAdapter
        '
        Me.TbPOSTableAdapter.ClearBeforeFill = True
        '
        'TbPOSDataGridView
        '
        Me.TbPOSDataGridView.AllowUserToAddRows = False
        Me.TbPOSDataGridView.AutoGenerateColumns = False
        Me.TbPOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbPOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn16})
        Me.TbPOSDataGridView.DataSource = Me.TbPOSBindingSource
        Me.TbPOSDataGridView.Location = New System.Drawing.Point(451, 254)
        Me.TbPOSDataGridView.Name = "TbPOSDataGridView"
        Me.TbPOSDataGridView.Size = New System.Drawing.Size(363, 220)
        Me.TbPOSDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TransactionDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "TransactionDate"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TransactionTime"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TransactionTime"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Breakdowns"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Breakdowns"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Signed"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Signed"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 571)
        Me.Controls.Add(Me.TbPOSDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbProductsDataGridView1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TbProductsDataGridView)
        Me.Name = "frmReports"
        Me.Text = "Report Builder"
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProductsDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbProductsBindingSource As BindingSource
    Friend WithEvents TbProductsTableAdapter As autosupplyDataSetTableAdapters.tbProductsTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbProductsDataGridView As DataGridView
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents TbProductsDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbPOSBindingSource As BindingSource
    Friend WithEvents TbPOSTableAdapter As autosupplyDataSetTableAdapters.tbPOSTableAdapter
    Friend WithEvents TbPOSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
End Class
