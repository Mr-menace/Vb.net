<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOS
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
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnDiscount = New System.Windows.Forms.Button()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkReScan = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOrigPrice = New System.Windows.Forms.Label()
        Me.lblAmt = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NumQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.TbPOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbPOSTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbPOSTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblToken = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(131, 425)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(291, 44)
        Me.txtCash.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtCash, "Cash Input Box")
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(492, 67)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(397, 659)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        Me.ToolTip1.SetToolTip(Me.RichTextBox1, "Breakdowns")
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckout.FlatAppearance.BorderSize = 0
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(27, 587)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(149, 53)
        Me.btnCheckout.TabIndex = 6
        Me.btnCheckout.Text = "Check Out"
        Me.ToolTip1.SetToolTip(Me.btnCheckout, "End Transaction Restart a new one and save")
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnDiscount
        '
        Me.btnDiscount.BackColor = System.Drawing.Color.Transparent
        Me.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiscount.FlatAppearance.BorderSize = 0
        Me.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscount.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscount.Location = New System.Drawing.Point(198, 587)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(126, 53)
        Me.btnDiscount.TabIndex = 7
        Me.btnDiscount.Text = "Discount"
        Me.ToolTip1.SetToolTip(Me.btnDiscount, "Discount ")
        Me.btnDiscount.UseVisualStyleBackColor = False
        Me.btnDiscount.Visible = False
        '
        'btnScan
        '
        Me.btnScan.BackColor = System.Drawing.Color.Transparent
        Me.btnScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScan.FlatAppearance.BorderSize = 0
        Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.Location = New System.Drawing.Point(346, 587)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(99, 53)
        Me.btnScan.TabIndex = 8
        Me.btnScan.Text = "Reload"
        Me.btnScan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myriad Hebrew", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(7, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myriad Hebrew", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(43, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cash:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Myriad Hebrew", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(12, 492)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Change:"
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(131, 270)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(291, 44)
        Me.txtBarcode.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtBarcode, "Product Barcode.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Myriad Hebrew", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(6, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Barcode:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.chkReScan)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.NumQuantity)
        Me.Panel1.Controls.Add(Me.btnScan)
        Me.Panel1.Controls.Add(Me.txtBarcode)
        Me.Panel1.Controls.Add(Me.btnDiscount)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lblChange)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnCheckout)
        Me.Panel1.Controls.Add(Me.txtCash)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(3, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 659)
        Me.Panel1.TabIndex = 4
        '
        'chkReScan
        '
        Me.chkReScan.AutoSize = True
        Me.chkReScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkReScan.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReScan.ForeColor = System.Drawing.Color.Black
        Me.chkReScan.Location = New System.Drawing.Point(131, 320)
        Me.chkReScan.Name = "chkReScan"
        Me.chkReScan.Size = New System.Drawing.Size(90, 25)
        Me.chkReScan.TabIndex = 4
        Me.chkReScan.Text = "Re-Scan"
        Me.ToolTip1.SetToolTip(Me.chkReScan, "Check if you want to re-scan a product if someone change their mind on purchasing" &
        " it")
        Me.chkReScan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.lblItem)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblOrigPrice)
        Me.GroupBox1.Controls.Add(Me.lblAmt)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(3, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 189)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Scanned"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblItem.Location = New System.Drawing.Point(126, 26)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(0, 31)
        Me.lblItem.TabIndex = 3
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Myriad Hebrew", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Location = New System.Drawing.Point(47, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 33)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Myriad Hebrew", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(51, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 33)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Item:"
        '
        'lblOrigPrice
        '
        Me.lblOrigPrice.AutoSize = True
        Me.lblOrigPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigPrice.Location = New System.Drawing.Point(126, 77)
        Me.lblOrigPrice.Name = "lblOrigPrice"
        Me.lblOrigPrice.Size = New System.Drawing.Size(0, 31)
        Me.lblOrigPrice.TabIndex = 3
        Me.lblOrigPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAmt
        '
        Me.lblAmt.AutoSize = True
        Me.lblAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmt.Location = New System.Drawing.Point(126, 132)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(0, 31)
        Me.lblAmt.TabIndex = 3
        Me.lblAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(312, 205)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(164, 48)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Remember Qty"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Do not Delete Quantity Inputted")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NumQuantity
        '
        Me.NumQuantity.Font = New System.Drawing.Font("Microsoft Tai Le", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumQuantity.Location = New System.Drawing.Point(131, 205)
        Me.NumQuantity.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NumQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumQuantity.Name = "NumQuantity"
        Me.NumQuantity.Size = New System.Drawing.Size(175, 48)
        Me.NumQuantity.TabIndex = 1
        Me.NumQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.NumQuantity, "Amount to Purchase")
        Me.NumQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(125, 357)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(276, 31)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblTotal, "Total to Pay")
        '
        'lblChange
        '
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.Black
        Me.lblChange.Location = New System.Drawing.Point(125, 474)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(276, 71)
        Me.lblChange.TabIndex = 3
        Me.lblChange.Text = "0.00"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblChange, "Your Change")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Myriad Hebrew", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(5, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 33)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Myriad Hebrew", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(44, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 33)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(3, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 27)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(0, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 27)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Time:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(63, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(27, 27)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "D"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(62, 38)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(24, 27)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "T"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(487, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 27)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Public Token:"
        Me.ToolTip1.SetToolTip(Me.Label11, "You can use this to identify a transaction history or generate a report about it." &
        "")
        '
        'AutosupplyDataSet
        '
        Me.AutosupplyDataSet.DataSetName = "autosupplyDataSet"
        Me.AutosupplyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tbBrandTableAdapter = Nothing
        Me.TableAdapterManager.tbNameTableAdapter = Nothing
        Me.TableAdapterManager.tbPOSTableAdapter = Me.TbPOSTableAdapter
        Me.TableAdapterManager.tbProductsTableAdapter = Nothing
        Me.TableAdapterManager.tbQualityTableAdapter = Nothing
        Me.TableAdapterManager.tbReturnedTableAdapter = Nothing
        Me.TableAdapterManager.tbSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbtimeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtToken
        '
        Me.txtToken.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtToken.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToken.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtToken.Location = New System.Drawing.Point(492, 33)
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(397, 32)
        Me.txtToken.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtToken, "You can use this to identify a transaction history or generate a report about it." &
        "")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 40
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Point of Sale"
        '
        'lblToken
        '
        Me.lblToken.AutoSize = True
        Me.lblToken.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToken.Location = New System.Drawing.Point(636, 5)
        Me.lblToken.Name = "lblToken"
        Me.lblToken.Size = New System.Drawing.Size(37, 21)
        Me.lblToken.TabIndex = 11
        Me.lblToken.Text = "000"
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(896, 730)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblToken)
        Me.Controls.Add(Me.txtToken)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point of Sale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCash As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnDiscount As Button
    Friend WithEvents btnScan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblItem As Label
    Friend WithEvents lblAmt As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Public WithEvents NumQuantity As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblOrigPrice As Label
    Friend WithEvents chkReScan As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbPOSBindingSource As BindingSource
    Friend WithEvents TbPOSTableAdapter As autosupplyDataSetTableAdapters.tbPOSTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtToken As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblToken As Label
End Class
