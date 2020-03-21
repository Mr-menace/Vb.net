<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReturn
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
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim BarcodeEncodeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim BarcodeLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturn))
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.BarcodeEncodeTextBox = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.TbProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.rbtDamage = New System.Windows.Forms.RadioButton()
        Me.rbtGood = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtOrig = New System.Windows.Forms.TextBox()
        Me.dtpPurchased = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblReturnID = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbcReturn = New System.Windows.Forms.TabPage()
        Me.tbcList = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtfind = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TbReturnedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarcodeTextBox = New System.Windows.Forms.TextBox()
        Me.TbReturnedDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePurchased = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TbProductsTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbProductsTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        Me.TbReturnedTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbReturnedTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        ProductNameLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        BarcodeEncodeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        BarcodeLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbcReturn.SuspendLayout()
        Me.tbcList.SuspendLayout()
        CType(Me.TbReturnedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbReturnedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductNameLabel.Location = New System.Drawing.Point(28, 53)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(136, 24)
        ProductNameLabel.TabIndex = 1
        ProductNameLabel.Text = "Product Name:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BrandLabel.Location = New System.Drawing.Point(29, 99)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(135, 24)
        BrandLabel.TabIndex = 2
        BrandLabel.Text = "Product Brand:"
        '
        'BarcodeEncodeLabel
        '
        BarcodeEncodeLabel.AutoSize = True
        BarcodeEncodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarcodeEncodeLabel.Location = New System.Drawing.Point(8, 339)
        BarcodeEncodeLabel.Name = "BarcodeEncodeLabel"
        BarcodeEncodeLabel.Size = New System.Drawing.Size(158, 24)
        BarcodeEncodeLabel.TabIndex = 6
        BarcodeEncodeLabel.Text = "Barcode Encode:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(277, 225)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 24)
        Label1.TabIndex = 4
        Label1.Text = "Quantity:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(566, 222)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(76, 13)
        QuantityLabel.TabIndex = 10
        QuantityLabel.Text = "View for Devs:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(-1, 161)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(165, 24)
        Label2.TabIndex = 6
        Label2.Text = "Product Condition:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(442, 26)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(136, 24)
        Label3.TabIndex = 6
        Label3.Text = "Date Returned:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(442, 96)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(58, 24)
        Label4.TabIndex = 6
        Label4.Text = "Time:"
        '
        'BarcodeLabel
        '
        BarcodeLabel.AutoSize = True
        BarcodeLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarcodeLabel.Location = New System.Drawing.Point(413, 12)
        BarcodeLabel.Name = "BarcodeLabel"
        BarcodeLabel.Size = New System.Drawing.Size(83, 23)
        BarcodeLabel.TabIndex = 1
        BarcodeLabel.Text = "Barcode:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(431, 54)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(65, 23)
        Label5.TabIndex = 1
        Label5.Text = "Status:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(16, 288)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(149, 24)
        Label6.TabIndex = 6
        Label6.Text = "Date Purchased:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(36, 225)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(128, 24)
        Label7.TabIndex = 6
        Label7.Text = "Original Price:"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(170, 53)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(219, 29)
        Me.ProductNameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ProductNameTextBox, "Input Product Name")
        '
        'BrandTextBox
        '
        Me.BrandTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandTextBox.Location = New System.Drawing.Point(170, 97)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(219, 29)
        Me.BrandTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BrandTextBox, "Input Product Brand")
        '
        'BarcodeEncodeTextBox
        '
        Me.BarcodeEncodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeEncodeTextBox.Location = New System.Drawing.Point(170, 336)
        Me.BarcodeEncodeTextBox.MaxLength = 50
        Me.BarcodeEncodeTextBox.Name = "BarcodeEncodeTextBox"
        Me.BarcodeEncodeTextBox.Size = New System.Drawing.Size(219, 29)
        Me.BarcodeEncodeTextBox.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.BarcodeEncodeTextBox, "Input Barcode Data")
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(362, 222)
        Me.txtQuantity.MaxLength = 8
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(104, 29)
        Me.txtQuantity.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtQuantity, "Input Quantity")
        '
        'lblQuantity
        '
        Me.lblQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "Quantity", True))
        Me.lblQuantity.ForeColor = System.Drawing.Color.Red
        Me.lblQuantity.Location = New System.Drawing.Point(570, 278)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 23)
        Me.lblQuantity.TabIndex = 11
        Me.lblQuantity.Text = "Label2"
        '
        'TbProductsBindingSource
        '
        Me.TbProductsBindingSource.DataMember = "tbProducts"
        Me.TbProductsBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'AutosupplyDataSet
        '
        Me.AutosupplyDataSet.DataSetName = "autosupplyDataSet"
        Me.AutosupplyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnReturn
        '
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(246, 405)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(101, 50)
        Me.btnReturn.TabIndex = 11
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'rbtDamage
        '
        Me.rbtDamage.AutoSize = True
        Me.rbtDamage.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDamage.ForeColor = System.Drawing.Color.DarkRed
        Me.rbtDamage.Location = New System.Drawing.Point(170, 143)
        Me.rbtDamage.Name = "rbtDamage"
        Me.rbtDamage.Size = New System.Drawing.Size(149, 25)
        Me.rbtDamage.TabIndex = 4
        Me.rbtDamage.TabStop = True
        Me.rbtDamage.Text = "Item has Damage"
        Me.ToolTip1.SetToolTip(Me.rbtDamage, "Declare item as Damage to Reject it")
        Me.rbtDamage.UseVisualStyleBackColor = True
        '
        'rbtGood
        '
        Me.rbtGood.AutoSize = True
        Me.rbtGood.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtGood.ForeColor = System.Drawing.Color.DarkRed
        Me.rbtGood.Location = New System.Drawing.Point(170, 174)
        Me.rbtGood.Name = "rbtGood"
        Me.rbtGood.Size = New System.Drawing.Size(155, 25)
        Me.rbtGood.TabIndex = 5
        Me.rbtGood.TabStop = True
        Me.rbtGood.Text = "In Good Condition"
        Me.ToolTip1.SetToolTip(Me.rbtGood, "Declare item as in Good Condition to Add the quantity to the system")
        Me.rbtGood.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.txtOrig)
        Me.GroupBox1.Controls.Add(Me.dtpPurchased)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblData)
        Me.GroupBox1.Controls.Add(Me.dtpTime)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.ProductNameTextBox)
        Me.GroupBox1.Controls.Add(Me.rbtGood)
        Me.GroupBox1.Controls.Add(ProductNameLabel)
        Me.GroupBox1.Controls.Add(Me.rbtDamage)
        Me.GroupBox1.Controls.Add(Me.BrandTextBox)
        Me.GroupBox1.Controls.Add(Me.btnReturn)
        Me.GroupBox1.Controls.Add(BrandLabel)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.BarcodeEncodeTextBox)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(BarcodeEncodeLabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 472)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(503, 413)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "You Can Only Return a product if the barcode was registered on the system, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if f" &
        "ailed to acquired the product will not be processed nor accepted " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by the return" &
        " system feature.")
        '
        'txtOrig
        '
        Me.txtOrig.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrig.Location = New System.Drawing.Point(170, 222)
        Me.txtOrig.MaxLength = 8
        Me.txtOrig.Name = "txtOrig"
        Me.txtOrig.Size = New System.Drawing.Size(104, 29)
        Me.txtOrig.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtOrig, "Input Original Price")
        '
        'dtpPurchased
        '
        Me.dtpPurchased.CalendarFont = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurchased.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurchased.Location = New System.Drawing.Point(170, 280)
        Me.dtpPurchased.Name = "dtpPurchased"
        Me.dtpPurchased.Size = New System.Drawing.Size(296, 32)
        Me.dtpPurchased.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(503, 207)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.Red
        Me.lblData.Location = New System.Drawing.Point(223, 368)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(134, 21)
        Me.lblData.TabIndex = 33
        Me.lblData.Text = "*Data Not Found*"
        Me.lblData.Visible = False
        '
        'dtpTime
        '
        Me.dtpTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(446, 123)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(204, 29)
        Me.dtpTime.TabIndex = 10
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(446, 53)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(320, 29)
        Me.dtpDate.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblReturnID
        '
        Me.lblReturnID.ForeColor = System.Drawing.Color.Red
        Me.lblReturnID.Location = New System.Drawing.Point(570, 242)
        Me.lblReturnID.Name = "lblReturnID"
        Me.lblReturnID.Size = New System.Drawing.Size(100, 23)
        Me.lblReturnID.TabIndex = 11
        Me.lblReturnID.Text = "Return ID"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.tbcReturn)
        Me.TabControl1.Controls.Add(Me.tbcList)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(783, 510)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 15
        '
        'tbcReturn
        '
        Me.tbcReturn.Controls.Add(Me.GroupBox1)
        Me.tbcReturn.Location = New System.Drawing.Point(4, 28)
        Me.tbcReturn.Name = "tbcReturn"
        Me.tbcReturn.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcReturn.Size = New System.Drawing.Size(775, 478)
        Me.tbcReturn.TabIndex = 0
        Me.tbcReturn.Text = "Return Items Here"
        Me.tbcReturn.UseVisualStyleBackColor = True
        '
        'tbcList
        '
        Me.tbcList.AutoScroll = True
        Me.tbcList.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.tbcList.Controls.Add(Me.Button3)
        Me.tbcList.Controls.Add(Me.btnFind)
        Me.tbcList.Controls.Add(Label5)
        Me.tbcList.Controls.Add(BarcodeLabel)
        Me.tbcList.Controls.Add(Me.txtfind)
        Me.tbcList.Controls.Add(Me.TextBox1)
        Me.tbcList.Controls.Add(Me.BarcodeTextBox)
        Me.tbcList.Controls.Add(Me.TbReturnedDataGridView)
        Me.tbcList.Location = New System.Drawing.Point(4, 28)
        Me.tbcList.Name = "tbcList"
        Me.tbcList.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcList.Size = New System.Drawing.Size(775, 478)
        Me.tbcList.TabIndex = 1
        Me.tbcList.Text = "List of Returned Items"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(134, 45)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 43)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(223, 45)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(83, 43)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "Search"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtfind
        '
        Me.txtfind.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfind.Location = New System.Drawing.Point(3, 3)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(303, 32)
        Me.txtfind.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbReturnedBindingSource, "Status", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(502, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(265, 32)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbReturnedBindingSource
        '
        Me.TbReturnedBindingSource.DataMember = "tbReturned"
        Me.TbReturnedBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbReturnedBindingSource, "Barcode", True))
        Me.BarcodeTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(502, 6)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.ReadOnly = True
        Me.BarcodeTextBox.Size = New System.Drawing.Size(265, 32)
        Me.BarcodeTextBox.TabIndex = 4
        Me.BarcodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbReturnedDataGridView
        '
        Me.TbReturnedDataGridView.AllowUserToAddRows = False
        Me.TbReturnedDataGridView.AllowUserToDeleteRows = False
        Me.TbReturnedDataGridView.AutoGenerateColumns = False
        Me.TbReturnedDataGridView.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TbReturnedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbReturnedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DatePurchased, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.OrigPrice, Me.DataGridViewTextBoxColumn7, Me.Status})
        Me.TbReturnedDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TbReturnedDataGridView.DataSource = Me.TbReturnedBindingSource
        Me.TbReturnedDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TbReturnedDataGridView.Location = New System.Drawing.Point(3, 110)
        Me.TbReturnedDataGridView.Name = "TbReturnedDataGridView"
        Me.TbReturnedDataGridView.ReadOnly = True
        Me.TbReturnedDataGridView.Size = New System.Drawing.Size(769, 365)
        Me.TbReturnedDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Barcode"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DatePurchased
        '
        Me.DatePurchased.DataPropertyName = "DatePurchased"
        Me.DatePurchased.HeaderText = "Purchased"
        Me.DatePurchased.Name = "DatePurchased"
        Me.DatePurchased.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ReturnedDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Returned"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'OrigPrice
        '
        Me.OrigPrice.DataPropertyName = "OrigPrice"
        Me.OrigPrice.HeaderText = "Price"
        Me.OrigPrice.Name = "OrigPrice"
        Me.OrigPrice.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "EncodeBy"
        Me.DataGridViewTextBoxColumn7.HeaderText = "EncodeBy"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.EditToolStripMenuItem, Me.ToolStripSeparator1, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 66)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(131, 6)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(131, 6)
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
        'TbReturnedTableAdapter
        '
        Me.TbReturnedTableAdapter.ClearBeforeFill = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        Me.ToolTip1.AutoPopDelay = 6000
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 40
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Return Items Info"
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(783, 510)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.lblReturnID)
        Me.Controls.Add(Me.lblQuantity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Returns"
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbcReturn.ResumeLayout(False)
        Me.tbcList.ResumeLayout(False)
        Me.tbcList.PerformLayout()
        CType(Me.TbReturnedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbReturnedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbProductsBindingSource As BindingSource
    Friend WithEvents TbProductsTableAdapter As autosupplyDataSetTableAdapters.tbProductsTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents BrandTextBox As TextBox
    Friend WithEvents BarcodeEncodeTextBox As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents rbtDamage As RadioButton
    Friend WithEvents rbtGood As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblData As Label
    Friend WithEvents TbReturnedBindingSource As BindingSource
    Friend WithEvents TbReturnedTableAdapter As autosupplyDataSetTableAdapters.tbReturnedTableAdapter
    Friend WithEvents lblReturnID As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbcReturn As TabPage
    Friend WithEvents tbcList As TabPage
    Friend WithEvents TbReturnedDataGridView As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BarcodeTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents txtfind As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpPurchased As DateTimePicker
    Friend WithEvents txtOrig As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DatePurchased As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents OrigPrice As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
