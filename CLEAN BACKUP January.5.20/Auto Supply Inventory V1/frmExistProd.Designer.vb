<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExistProd
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
        Me.components = New System.ComponentModel.Container()
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim DeliveryDateLabel As System.Windows.Forms.Label
        Dim BarcodeEncodeLabel As System.Windows.Forms.Label
        Dim DeliveryTimeLabel As System.Windows.Forms.Label
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.TbProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProductsTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbProductsTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.BarcodeEncodeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DeliveryDateLabel2 = New System.Windows.Forms.Label()
        Me.DeliveryTimeLabel2 = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        DeliveryDateLabel = New System.Windows.Forms.Label()
        BarcodeEncodeLabel = New System.Windows.Forms.Label()
        DeliveryTimeLabel = New System.Windows.Forms.Label()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.TableAdapterManager.tbProductsTableAdapter = Me.TbProductsTableAdapter
        Me.TableAdapterManager.tbQualityTableAdapter = Nothing
        Me.TableAdapterManager.tbReturnedTableAdapter = Nothing
        Me.TableAdapterManager.tbSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbtimeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.ForeColor = System.Drawing.Color.Crimson
        QuantityLabel.Location = New System.Drawing.Point(33, 119)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(66, 18)
        QuantityLabel.TabIndex = 11
        QuantityLabel.Text = "Quantity:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(105, 112)
        Me.QuantityTextBox.MaxLength = 5
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.ReadOnly = True
        Me.QuantityTextBox.Size = New System.Drawing.Size(80, 29)
        Me.QuantityTextBox.TabIndex = 12
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(105, 82)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.ReadOnly = True
        Me.ProductNameTextBox.Size = New System.Drawing.Size(202, 24)
        Me.ProductNameTextBox.TabIndex = 4
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductNameLabel.ForeColor = System.Drawing.Color.Crimson
        ProductNameLabel.Location = New System.Drawing.Point(52, 88)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(52, 18)
        ProductNameLabel.TabIndex = 3
        ProductNameLabel.Text = "Name:"
        '
        'DeliveryDateLabel
        '
        DeliveryDateLabel.AutoSize = True
        DeliveryDateLabel.BackColor = System.Drawing.Color.Transparent
        DeliveryDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DeliveryDateLabel.ForeColor = System.Drawing.Color.Crimson
        DeliveryDateLabel.Location = New System.Drawing.Point(327, 33)
        DeliveryDateLabel.Name = "DeliveryDateLabel"
        DeliveryDateLabel.Size = New System.Drawing.Size(99, 18)
        DeliveryDateLabel.TabIndex = 15
        DeliveryDateLabel.Text = "Delivery Date:"
        '
        'BarcodeEncodeLabel
        '
        BarcodeEncodeLabel.AutoSize = True
        BarcodeEncodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarcodeEncodeLabel.ForeColor = System.Drawing.Color.Crimson
        BarcodeEncodeLabel.Location = New System.Drawing.Point(6, 36)
        BarcodeEncodeLabel.Name = "BarcodeEncodeLabel"
        BarcodeEncodeLabel.Size = New System.Drawing.Size(96, 18)
        BarcodeEncodeLabel.TabIndex = 17
        BarcodeEncodeLabel.Text = "Barcode Info:"
        '
        'BarcodeEncodeTextBox
        '
        Me.BarcodeEncodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "BarcodeEncode", True))
        Me.BarcodeEncodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeEncodeTextBox.Location = New System.Drawing.Point(105, 32)
        Me.BarcodeEncodeTextBox.MaxLength = 12
        Me.BarcodeEncodeTextBox.Name = "BarcodeEncodeTextBox"
        Me.BarcodeEncodeTextBox.ReadOnly = True
        Me.BarcodeEncodeTextBox.Size = New System.Drawing.Size(202, 24)
        Me.BarcodeEncodeTextBox.TabIndex = 18
        '
        'DeliveryTimeLabel
        '
        DeliveryTimeLabel.AutoSize = True
        DeliveryTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DeliveryTimeLabel.ForeColor = System.Drawing.Color.Crimson
        DeliveryTimeLabel.Location = New System.Drawing.Point(327, 82)
        DeliveryTimeLabel.Name = "DeliveryTimeLabel"
        DeliveryTimeLabel.Size = New System.Drawing.Size(101, 18)
        DeliveryTimeLabel.TabIndex = 20
        DeliveryTimeLabel.Text = "Delivery Time:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DeliveryTimeLabel2)
        Me.GroupBox1.Controls.Add(Me.DeliveryDateLabel2)
        Me.GroupBox1.Controls.Add(DeliveryTimeLabel)
        Me.GroupBox1.Controls.Add(Me.BarcodeEncodeTextBox)
        Me.GroupBox1.Controls.Add(BarcodeEncodeLabel)
        Me.GroupBox1.Controls.Add(DeliveryDateLabel)
        Me.GroupBox1.Controls.Add(ProductNameLabel)
        Me.GroupBox1.Controls.Add(Me.ProductNameTextBox)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(QuantityLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 194)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'DeliveryDateLabel2
        '
        Me.DeliveryDateLabel2.BackColor = System.Drawing.Color.LightGray
        Me.DeliveryDateLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "DeliveryDate", True))
        Me.DeliveryDateLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryDateLabel2.Location = New System.Drawing.Point(432, 36)
        Me.DeliveryDateLabel2.Name = "DeliveryDateLabel2"
        Me.DeliveryDateLabel2.Size = New System.Drawing.Size(237, 23)
        Me.DeliveryDateLabel2.TabIndex = 21
        '
        'DeliveryTimeLabel2
        '
        Me.DeliveryTimeLabel2.BackColor = System.Drawing.Color.LightGray
        Me.DeliveryTimeLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "DeliveryTime", True))
        Me.DeliveryTimeLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryTimeLabel2.Location = New System.Drawing.Point(432, 79)
        Me.DeliveryTimeLabel2.Name = "DeliveryTimeLabel2"
        Me.DeliveryTimeLabel2.Size = New System.Drawing.Size(152, 23)
        Me.DeliveryTimeLabel2.TabIndex = 22
        '
        'frmExistProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(693, 217)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmExistProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExistProd"
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbProductsBindingSource As BindingSource
    Friend WithEvents TbProductsTableAdapter As autosupplyDataSetTableAdapters.tbProductsTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents BarcodeEncodeTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DeliveryTimeLabel2 As Label
    Friend WithEvents DeliveryDateLabel2 As Label
End Class
