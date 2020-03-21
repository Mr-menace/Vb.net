<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOScall
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
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim BarcodeEncodeLabel As System.Windows.Forms.Label
        Dim OrigPriceLabel As System.Windows.Forms.Label
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.TbProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProductsTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbProductsTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        Me.ProductNameLabel1 = New System.Windows.Forms.Label()
        Me.QuantityLabel1 = New System.Windows.Forms.Label()
        Me.BarcodeEncodeLabel1 = New System.Windows.Forms.Label()
        Me.OrigPriceTextBox = New System.Windows.Forms.TextBox()
        Me.TbPOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbPOSTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbPOSTableAdapter()
        ProductNameLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        BarcodeEncodeLabel = New System.Windows.Forms.Label()
        OrigPriceLabel = New System.Windows.Forms.Label()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(50, 59)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(78, 13)
        ProductNameLabel.TabIndex = 3
        ProductNameLabel.Text = "Product Name:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(50, 82)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 11
        QuantityLabel.Text = "Quantity:"
        '
        'BarcodeEncodeLabel
        '
        BarcodeEncodeLabel.AutoSize = True
        BarcodeEncodeLabel.Location = New System.Drawing.Point(50, 115)
        BarcodeEncodeLabel.Name = "BarcodeEncodeLabel"
        BarcodeEncodeLabel.Size = New System.Drawing.Size(90, 13)
        BarcodeEncodeLabel.TabIndex = 19
        BarcodeEncodeLabel.Text = "Barcode Encode:"
        '
        'OrigPriceLabel
        '
        OrigPriceLabel.AutoSize = True
        OrigPriceLabel.Location = New System.Drawing.Point(53, 144)
        OrigPriceLabel.Name = "OrigPriceLabel"
        OrigPriceLabel.Size = New System.Drawing.Size(56, 13)
        OrigPriceLabel.TabIndex = 25
        OrigPriceLabel.Text = "Orig Price:"
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
        'ProductNameLabel1
        '
        Me.ProductNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "ProductName", True))
        Me.ProductNameLabel1.Location = New System.Drawing.Point(146, 59)
        Me.ProductNameLabel1.Name = "ProductNameLabel1"
        Me.ProductNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ProductNameLabel1.TabIndex = 4
        Me.ProductNameLabel1.Text = "Label1"
        '
        'QuantityLabel1
        '
        Me.QuantityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "Quantity", True))
        Me.QuantityLabel1.Location = New System.Drawing.Point(146, 82)
        Me.QuantityLabel1.Name = "QuantityLabel1"
        Me.QuantityLabel1.Size = New System.Drawing.Size(100, 23)
        Me.QuantityLabel1.TabIndex = 12
        Me.QuantityLabel1.Text = "Label1"
        '
        'BarcodeEncodeLabel1
        '
        Me.BarcodeEncodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "BarcodeEncode", True))
        Me.BarcodeEncodeLabel1.Location = New System.Drawing.Point(146, 115)
        Me.BarcodeEncodeLabel1.Name = "BarcodeEncodeLabel1"
        Me.BarcodeEncodeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BarcodeEncodeLabel1.TabIndex = 20
        Me.BarcodeEncodeLabel1.Text = "Label1"
        '
        'OrigPriceTextBox
        '
        Me.OrigPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "OrigPrice", True))
        Me.OrigPriceTextBox.Location = New System.Drawing.Point(149, 141)
        Me.OrigPriceTextBox.Name = "OrigPriceTextBox"
        Me.OrigPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OrigPriceTextBox.TabIndex = 26
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
        'frmPOScall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 197)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameLabel1)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityLabel1)
        Me.Controls.Add(BarcodeEncodeLabel)
        Me.Controls.Add(Me.BarcodeEncodeLabel1)
        Me.Controls.Add(OrigPriceLabel)
        Me.Controls.Add(Me.OrigPriceTextBox)
        Me.Name = "frmPOScall"
        Me.Text = "POS CALL"
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbProductsBindingSource As BindingSource
    Friend WithEvents TbProductsTableAdapter As autosupplyDataSetTableAdapters.tbProductsTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductNameLabel1 As Label
    Friend WithEvents QuantityLabel1 As Label
    Friend WithEvents BarcodeEncodeLabel1 As Label
    Friend WithEvents OrigPriceTextBox As TextBox
    Friend WithEvents TbPOSBindingSource As BindingSource
    Friend WithEvents TbPOSTableAdapter As autosupplyDataSetTableAdapters.tbPOSTableAdapter
End Class
