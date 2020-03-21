<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim PartNoLabel As System.Windows.Forms.Label
        Dim QualityLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim SupplierLabel As System.Windows.Forms.Label
        Dim DeliveryDateLabel As System.Windows.Forms.Label
        Dim BarcodeEncodeLabel As System.Windows.Forms.Label
        Dim DeliveryTimeLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdd))
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.TbProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbProductsTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbProductsTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.PartNoTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.BarcodeEncodeTextBox = New System.Windows.Forms.TextBox()
        Me.BarcodeimgPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumOrigPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblExist = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboQuality = New System.Windows.Forms.ComboBox()
        Me.TbQualityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboBrand = New System.Windows.Forms.ComboBox()
        Me.TbBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.TbSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TbBrandTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbBrandTableAdapter()
        Me.TbSupplierTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbSupplierTableAdapter()
        Me.TbQualityTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbQualityTableAdapter()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        ProductIDLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        PartNoLabel = New System.Windows.Forms.Label()
        QualityLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        SupplierLabel = New System.Windows.Forms.Label()
        DeliveryDateLabel = New System.Windows.Forms.Label()
        BarcodeEncodeLabel = New System.Windows.Forms.Label()
        DeliveryTimeLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarcodeimgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumOrigPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TbQualityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.BackColor = System.Drawing.Color.Transparent
        ProductIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductIDLabel.ForeColor = System.Drawing.Color.Crimson
        ProductIDLabel.Location = New System.Drawing.Point(6, 36)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(89, 20)
        ProductIDLabel.TabIndex = 1
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductNameLabel.ForeColor = System.Drawing.Color.Crimson
        ProductNameLabel.Location = New System.Drawing.Point(6, 81)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(55, 20)
        ProductNameLabel.TabIndex = 3
        ProductNameLabel.Text = "Name:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BrandLabel.ForeColor = System.Drawing.Color.Crimson
        BrandLabel.Location = New System.Drawing.Point(6, 126)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(85, 20)
        BrandLabel.TabIndex = 5
        BrandLabel.Text = "Car Brand:"
        '
        'PartNoLabel
        '
        PartNoLabel.AutoSize = True
        PartNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PartNoLabel.ForeColor = System.Drawing.Color.Crimson
        PartNoLabel.Location = New System.Drawing.Point(6, 169)
        PartNoLabel.Name = "PartNoLabel"
        PartNoLabel.Size = New System.Drawing.Size(66, 20)
        PartNoLabel.TabIndex = 7
        PartNoLabel.Text = "Part No:"
        '
        'QualityLabel
        '
        QualityLabel.AutoSize = True
        QualityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QualityLabel.ForeColor = System.Drawing.Color.Crimson
        QualityLabel.Location = New System.Drawing.Point(6, 216)
        QualityLabel.Name = "QualityLabel"
        QualityLabel.Size = New System.Drawing.Size(61, 20)
        QualityLabel.TabIndex = 9
        QualityLabel.Text = "Quality:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.ForeColor = System.Drawing.Color.Crimson
        QuantityLabel.Location = New System.Drawing.Point(6, 266)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(72, 20)
        QuantityLabel.TabIndex = 11
        QuantityLabel.Text = "Quantity:"
        '
        'SupplierLabel
        '
        SupplierLabel.AutoSize = True
        SupplierLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupplierLabel.ForeColor = System.Drawing.Color.Crimson
        SupplierLabel.Location = New System.Drawing.Point(6, 310)
        SupplierLabel.Name = "SupplierLabel"
        SupplierLabel.Size = New System.Drawing.Size(71, 20)
        SupplierLabel.TabIndex = 13
        SupplierLabel.Text = "Supplier:"
        '
        'DeliveryDateLabel
        '
        DeliveryDateLabel.AutoSize = True
        DeliveryDateLabel.BackColor = System.Drawing.Color.Transparent
        DeliveryDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DeliveryDateLabel.ForeColor = System.Drawing.Color.Crimson
        DeliveryDateLabel.Location = New System.Drawing.Point(318, 36)
        DeliveryDateLabel.Name = "DeliveryDateLabel"
        DeliveryDateLabel.Size = New System.Drawing.Size(107, 20)
        DeliveryDateLabel.TabIndex = 15
        DeliveryDateLabel.Text = "Delivery Date:"
        '
        'BarcodeEncodeLabel
        '
        BarcodeEncodeLabel.AutoSize = True
        BarcodeEncodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarcodeEncodeLabel.ForeColor = System.Drawing.Color.Crimson
        BarcodeEncodeLabel.Location = New System.Drawing.Point(318, 146)
        BarcodeEncodeLabel.Name = "BarcodeEncodeLabel"
        BarcodeEncodeLabel.Size = New System.Drawing.Size(105, 20)
        BarcodeEncodeLabel.TabIndex = 17
        BarcodeEncodeLabel.Text = "Barcode Info:"
        '
        'DeliveryTimeLabel
        '
        DeliveryTimeLabel.AutoSize = True
        DeliveryTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DeliveryTimeLabel.ForeColor = System.Drawing.Color.Crimson
        DeliveryTimeLabel.Location = New System.Drawing.Point(318, 85)
        DeliveryTimeLabel.Name = "DeliveryTimeLabel"
        DeliveryTimeLabel.Size = New System.Drawing.Size(106, 20)
        DeliveryTimeLabel.TabIndex = 20
        DeliveryTimeLabel.Text = "Delivery Time:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Crimson
        Label2.Location = New System.Drawing.Point(6, 360)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(85, 20)
        Label2.TabIndex = 13
        Label2.Text = "Orig. Price:"
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
        Me.TableAdapterManager.tbProductsTableAdapter = Me.TbProductsTableAdapter
        Me.TableAdapterManager.tbQualityTableAdapter = Nothing
        Me.TableAdapterManager.tbReturnedTableAdapter = Nothing
        Me.TableAdapterManager.tbSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbtimeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(94, 32)
        Me.ProductIDTextBox.MaxLength = 10
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(202, 29)
        Me.ProductIDTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ProductIDTextBox, "Product ID Choose Numeric Only, Click Auto Generate for auto fill ID's (Recommend" &
        "ed)")
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(94, 79)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(202, 29)
        Me.ProductNameTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.ProductNameTextBox, "Your Product Name")
        '
        'PartNoTextBox
        '
        Me.PartNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartNoTextBox.Location = New System.Drawing.Point(94, 166)
        Me.PartNoTextBox.Name = "PartNoTextBox"
        Me.PartNoTextBox.Size = New System.Drawing.Size(202, 29)
        Me.PartNoTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.PartNoTextBox, "Part Number")
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(94, 255)
        Me.QuantityTextBox.MaxLength = 5
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(157, 29)
        Me.QuantityTextBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.QuantityTextBox, "Quantity you're going to stock")
        '
        'BarcodeEncodeTextBox
        '
        Me.BarcodeEncodeTextBox.Enabled = False
        Me.BarcodeEncodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeEncodeTextBox.Location = New System.Drawing.Point(425, 140)
        Me.BarcodeEncodeTextBox.MaxLength = 30
        Me.BarcodeEncodeTextBox.Name = "BarcodeEncodeTextBox"
        Me.BarcodeEncodeTextBox.Size = New System.Drawing.Size(202, 29)
        Me.BarcodeEncodeTextBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.BarcodeEncodeTextBox, "Click here after filling all the fields and scan a Barcode")
        '
        'BarcodeimgPictureBox
        '
        Me.BarcodeimgPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.BarcodeimgPictureBox.Location = New System.Drawing.Point(16, 19)
        Me.BarcodeimgPictureBox.Name = "BarcodeimgPictureBox"
        Me.BarcodeimgPictureBox.Size = New System.Drawing.Size(242, 129)
        Me.BarcodeimgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BarcodeimgPictureBox.TabIndex = 19
        Me.BarcodeimgPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BarcodeimgPictureBox, "Barcode ")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumOrigPrice)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblExist)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboQuality)
        Me.GroupBox1.Controls.Add(Me.cboBrand)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.dtpTime)
        Me.GroupBox1.Controls.Add(DeliveryTimeLabel)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.ProductIDTextBox)
        Me.GroupBox1.Controls.Add(Me.BarcodeEncodeTextBox)
        Me.GroupBox1.Controls.Add(BarcodeEncodeLabel)
        Me.GroupBox1.Controls.Add(ProductIDLabel)
        Me.GroupBox1.Controls.Add(DeliveryDateLabel)
        Me.GroupBox1.Controls.Add(ProductNameLabel)
        Me.GroupBox1.Controls.Add(Me.ProductNameTextBox)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(SupplierLabel)
        Me.GroupBox1.Controls.Add(BrandLabel)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(QuantityLabel)
        Me.GroupBox1.Controls.Add(PartNoLabel)
        Me.GroupBox1.Controls.Add(Me.PartNoTextBox)
        Me.GroupBox1.Controls.Add(QualityLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 514)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'NumOrigPrice
        '
        Me.NumOrigPrice.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumOrigPrice.Location = New System.Drawing.Point(94, 346)
        Me.NumOrigPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NumOrigPrice.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumOrigPrice.Name = "NumOrigPrice"
        Me.NumOrigPrice.Size = New System.Drawing.Size(157, 32)
        Me.NumOrigPrice.TabIndex = 34
        Me.NumOrigPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumOrigPrice.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.NumOrigPrice, "Original Price")
        Me.NumOrigPrice.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(6, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 71)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Note: Make sure to fill all the details above if you are adding a new PRODUCT."
        '
        'lblExist
        '
        Me.lblExist.AutoSize = True
        Me.lblExist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExist.ForeColor = System.Drawing.Color.Red
        Me.lblExist.Location = New System.Drawing.Point(449, 123)
        Me.lblExist.Name = "lblExist"
        Me.lblExist.Size = New System.Drawing.Size(151, 16)
        Me.lblExist.TabIndex = 32
        Me.lblExist.Text = "*Barcode Already Exist*"
        Me.lblExist.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BarcodeimgPictureBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(369, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 168)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Barcode"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(322, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 71)
        Me.Button2.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.Button2, "Save Data (Manual)")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 40)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "*Please Focus your mouse to the barcode Textbox (Above) everytime scanning a barc" &
    "ode"
        '
        'cboQuality
        '
        Me.cboQuality.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboQuality.DataSource = Me.TbQualityBindingSource
        Me.cboQuality.DisplayMember = "ProductQuality"
        Me.cboQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuality.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuality.FormattingEnabled = True
        Me.cboQuality.Location = New System.Drawing.Point(94, 210)
        Me.cboQuality.Name = "cboQuality"
        Me.cboQuality.Size = New System.Drawing.Size(157, 26)
        Me.cboQuality.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cboQuality, "Quality Assured")
        '
        'TbQualityBindingSource
        '
        Me.TbQualityBindingSource.DataMember = "tbQuality"
        Me.TbQualityBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'cboBrand
        '
        Me.cboBrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboBrand.DataSource = Me.TbBrandBindingSource
        Me.cboBrand.DisplayMember = "BrandName"
        Me.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.Location = New System.Drawing.Point(94, 123)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.Size = New System.Drawing.Size(157, 26)
        Me.cboBrand.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cboBrand, "Choose What Brand It is.")
        '
        'TbBrandBindingSource
        '
        Me.TbBrandBindingSource.DataMember = "tbBrand"
        Me.TbBrandBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'cboSupplier
        '
        Me.cboSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSupplier.DataSource = Me.TbSupplierBindingSource
        Me.cboSupplier.DisplayMember = "Suppliers"
        Me.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(94, 302)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(157, 26)
        Me.cboSupplier.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.cboSupplier, "Choose Product Supplier")
        '
        'TbSupplierBindingSource
        '
        Me.TbSupplierBindingSource.DataMember = "tbSupplier"
        Me.TbSupplierBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'dtpTime
        '
        Me.dtpTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(425, 81)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(193, 29)
        Me.dtpTime.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.dtpTime, "Delivery Time of the product.")
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(425, 36)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(193, 29)
        Me.dtpDate.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.dtpDate, "Delivery Date of the product")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.LightBlue
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(12, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(129, 20)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Auto Generate ID"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Auto Generate Makes Product ID Field Filled Automatically with Valid ID's")
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(750, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TbBrandTableAdapter
        '
        Me.TbBrandTableAdapter.ClearBeforeFill = True
        '
        'TbSupplierTableAdapter
        '
        Me.TbSupplierTableAdapter.ClearBeforeFill = True
        '
        'TbQualityTableAdapter
        '
        Me.TbQualityTableAdapter.ClearBeforeFill = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.LightBlue
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(159, 12)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(184, 20)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "Remember Product Name"
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "Product Name will not be deleted every transaction if checked.")
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.LightBlue
        Me.CheckBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(365, 12)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(146, 20)
        Me.CheckBox3.TabIndex = 13
        Me.CheckBox3.Text = "Remember Quantity"
        Me.ToolTip1.SetToolTip(Me.CheckBox3, "Product Quantity will not be deleted every transaction if checked")
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.Color.LightBlue
        Me.CheckBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(527, 13)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(145, 20)
        Me.CheckBox4.TabIndex = 14
        Me.CheckBox4.Text = "For Existing Product"
        Me.ToolTip1.SetToolTip(Me.CheckBox4, "Click this if you want to add stocks for existing product")
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 7000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 20
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Product Adding"
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(687, 565)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Products"
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarcodeimgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumOrigPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TbQualityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbProductsBindingSource As BindingSource
    Friend WithEvents TbProductsTableAdapter As autosupplyDataSetTableAdapters.tbProductsTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents PartNoTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents BarcodeEncodeTextBox As TextBox
    Friend WithEvents BarcodeimgPictureBox As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents cboBrand As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cboQuality As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TbBrandBindingSource As BindingSource
    Friend WithEvents TbBrandTableAdapter As autosupplyDataSetTableAdapters.tbBrandTableAdapter
    Friend WithEvents TbSupplierBindingSource As BindingSource
    Friend WithEvents TbSupplierTableAdapter As autosupplyDataSetTableAdapters.tbSupplierTableAdapter
    Friend WithEvents TbQualityBindingSource As BindingSource
    Friend WithEvents TbQualityTableAdapter As autosupplyDataSetTableAdapters.tbQualityTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents lblExist As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumOrigPrice As NumericUpDown
    Friend WithEvents ToolTip1 As ToolTip
End Class
