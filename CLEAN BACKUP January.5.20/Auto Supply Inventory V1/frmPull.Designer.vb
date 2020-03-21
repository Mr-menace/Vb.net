<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPull
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
        Dim BarcodeEncodeLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.QuantityLabel1 = New System.Windows.Forms.Label()
        Me.TbProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.BarcodeEncodeTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameLabel2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtCashier = New System.Windows.Forms.TextBox()
        Me.DeliveryTimeLabel2 = New System.Windows.Forms.Label()
        Me.DeliveryDateLabel2 = New System.Windows.Forms.Label()
        Me.lbltips = New System.Windows.Forms.Label()
        Me.lblnoFound = New System.Windows.Forms.Label()
        Me.rtbStat = New System.Windows.Forms.RichTextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TbProductsTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbProductsTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        ProductNameLabel = New System.Windows.Forms.Label()
        BarcodeEncodeLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductNameLabel.Location = New System.Drawing.Point(711, 37)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(113, 21)
        ProductNameLabel.TabIndex = 3
        ProductNameLabel.Text = "Product Name:"
        '
        'BarcodeEncodeLabel
        '
        BarcodeEncodeLabel.AutoSize = True
        BarcodeEncodeLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarcodeEncodeLabel.Location = New System.Drawing.Point(339, 217)
        BarcodeEncodeLabel.Name = "BarcodeEncodeLabel"
        BarcodeEncodeLabel.Size = New System.Drawing.Size(132, 23)
        BarcodeEncodeLabel.TabIndex = 4
        BarcodeEncodeLabel.Text = "Barcode Input:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(706, 109)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(88, 21)
        QuantityLabel.TabIndex = 6
        QuantityLabel.Text = "Remaining:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(332, 72)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(136, 23)
        Label2.TabIndex = 6
        Label2.Text = "Choose Action:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(391, 29)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(77, 23)
        Label3.TabIndex = 6
        Label3.Text = "Cashier:"
        '
        'QuantityLabel1
        '
        Me.QuantityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "Quantity", True))
        Me.QuantityLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityLabel1.Location = New System.Drawing.Point(711, 142)
        Me.QuantityLabel1.Name = "QuantityLabel1"
        Me.QuantityLabel1.Size = New System.Drawing.Size(100, 23)
        Me.QuantityLabel1.TabIndex = 7
        Me.QuantityLabel1.Text = "Label1"
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
        'BarcodeEncodeTextBox
        '
        Me.BarcodeEncodeTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeEncodeTextBox.Location = New System.Drawing.Point(470, 210)
        Me.BarcodeEncodeTextBox.MaxLength = 50
        Me.BarcodeEncodeTextBox.Name = "BarcodeEncodeTextBox"
        Me.BarcodeEncodeTextBox.ReadOnly = True
        Me.BarcodeEncodeTextBox.Size = New System.Drawing.Size(219, 32)
        Me.BarcodeEncodeTextBox.TabIndex = 2
        '
        'ProductNameLabel2
        '
        Me.ProductNameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "ProductName", True))
        Me.ProductNameLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameLabel2.Location = New System.Drawing.Point(711, 70)
        Me.ProductNameLabel2.Name = "ProductNameLabel2"
        Me.ProductNameLabel2.Size = New System.Drawing.Size(100, 23)
        Me.ProductNameLabel2.TabIndex = 8
        Me.ProductNameLabel2.Text = "Label1"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Green
        Me.RadioButton1.Location = New System.Drawing.Point(470, 70)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 25)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Re-Stock"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Red
        Me.RadioButton2.Location = New System.Drawing.Point(575, 68)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(77, 25)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Deduct"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Controls.Add(Me.txtCashier)
        Me.Panel1.Controls.Add(Me.DeliveryTimeLabel2)
        Me.Panel1.Controls.Add(Me.DeliveryDateLabel2)
        Me.Panel1.Controls.Add(Me.lbltips)
        Me.Panel1.Controls.Add(Me.lblnoFound)
        Me.Panel1.Controls.Add(Me.rtbStat)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.ProductNameLabel2)
        Me.Panel1.Controls.Add(ProductNameLabel)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(QuantityLabel)
        Me.Panel1.Controls.Add(Me.BarcodeEncodeTextBox)
        Me.Panel1.Controls.Add(Me.QuantityLabel1)
        Me.Panel1.Controls.Add(BarcodeEncodeLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 402)
        Me.Panel1.TabIndex = 10
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "OrigPrice", True))
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(468, 169)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(20, 23)
        Me.lblPrice.TabIndex = 26
        Me.lblPrice.Text = "0"
        '
        'txtCashier
        '
        Me.txtCashier.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashier.Location = New System.Drawing.Point(470, 26)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Size = New System.Drawing.Size(219, 32)
        Me.txtCashier.TabIndex = 25
        '
        'DeliveryTimeLabel2
        '
        Me.DeliveryTimeLabel2.BackColor = System.Drawing.Color.LightGray
        Me.DeliveryTimeLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "DeliveryTime", True))
        Me.DeliveryTimeLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryTimeLabel2.Location = New System.Drawing.Point(706, 269)
        Me.DeliveryTimeLabel2.Name = "DeliveryTimeLabel2"
        Me.DeliveryTimeLabel2.Size = New System.Drawing.Size(105, 62)
        Me.DeliveryTimeLabel2.TabIndex = 24
        '
        'DeliveryDateLabel2
        '
        Me.DeliveryDateLabel2.BackColor = System.Drawing.Color.LightGray
        Me.DeliveryDateLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProductsBindingSource, "DeliveryDate", True))
        Me.DeliveryDateLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryDateLabel2.Location = New System.Drawing.Point(706, 204)
        Me.DeliveryDateLabel2.Name = "DeliveryDateLabel2"
        Me.DeliveryDateLabel2.Size = New System.Drawing.Size(145, 53)
        Me.DeliveryDateLabel2.TabIndex = 23
        '
        'lbltips
        '
        Me.lbltips.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltips.Location = New System.Drawing.Point(336, 290)
        Me.lbltips.Name = "lbltips"
        Me.lbltips.Size = New System.Drawing.Size(356, 108)
        Me.lbltips.TabIndex = 14
        '
        'lblnoFound
        '
        Me.lblnoFound.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnoFound.ForeColor = System.Drawing.Color.Red
        Me.lblnoFound.Location = New System.Drawing.Point(466, 245)
        Me.lblnoFound.Name = "lblnoFound"
        Me.lblnoFound.Size = New System.Drawing.Size(194, 63)
        Me.lblnoFound.TabIndex = 13
        Me.lblnoFound.Text = "*Product Not Found*"
        Me.lblnoFound.Visible = False
        '
        'rtbStat
        '
        Me.rtbStat.BackColor = System.Drawing.SystemColors.Desktop
        Me.rtbStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbStat.Dock = System.Windows.Forms.DockStyle.Left
        Me.rtbStat.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbStat.ForeColor = System.Drawing.Color.White
        Me.rtbStat.Location = New System.Drawing.Point(0, 0)
        Me.rtbStat.Name = "rtbStat"
        Me.rtbStat.ReadOnly = True
        Me.rtbStat.Size = New System.Drawing.Size(326, 398)
        Me.rtbStat.TabIndex = 5
        Me.rtbStat.Text = ""
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(470, 112)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 32)
        Me.NumericUpDown1.TabIndex = 11
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Orig. Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(382, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Quantity:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
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
        'frmPull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 402)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmPull"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Production"
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbProductsBindingSource As BindingSource
    Friend WithEvents TbProductsTableAdapter As autosupplyDataSetTableAdapters.tbProductsTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents QuantityLabel1 As Label
    Friend WithEvents BarcodeEncodeTextBox As TextBox
    Friend WithEvents ProductNameLabel2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Timer1 As Timer
    Friend WithEvents rtbStat As RichTextBox
    Friend WithEvents lblnoFound As Label
    Friend WithEvents lbltips As Label
    Friend WithEvents DeliveryTimeLabel2 As Label
    Friend WithEvents DeliveryDateLabel2 As Label
    Friend WithEvents txtCashier As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPrice As Label
End Class
