<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsuppEtc
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
        Dim ContactLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbcSuppliers = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstSuppliers = New System.Windows.Forms.ListBox()
        Me.TbSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.tbcBrand = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtbBrandDesc = New System.Windows.Forms.RichTextBox()
        Me.lblstatus1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstBrand = New System.Windows.Forms.ListBox()
        Me.TbBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbcQuality = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtbQualityDesc = New System.Windows.Forms.RichTextBox()
        Me.lblstatus2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstQuality = New System.Windows.Forms.ListBox()
        Me.TbQualityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbSupplierTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbSupplierTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        Me.TbBrandTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbBrandTableAdapter()
        Me.TbQualityTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbQualityTableAdapter()
        ContactLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tbcSuppliers.SuspendLayout()
        CType(Me.TbSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcBrand.SuspendLayout()
        CType(Me.TbBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcQuality.SuspendLayout()
        CType(Me.TbQualityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.Location = New System.Drawing.Point(9, 246)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(69, 20)
        ContactLabel.TabIndex = 10
        ContactLabel.Text = "Contact:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(10, 302)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(52, 20)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "Email:"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.tbcSuppliers)
        Me.TabControl1.Controls.Add(Me.tbcBrand)
        Me.TabControl1.Controls.Add(Me.tbcQuality)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(552, 396)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'tbcSuppliers
        '
        Me.tbcSuppliers.AutoScroll = True
        Me.tbcSuppliers.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.tbcSuppliers.Controls.Add(Me.Label7)
        Me.tbcSuppliers.Controls.Add(EmailLabel)
        Me.tbcSuppliers.Controls.Add(Me.EmailTextBox)
        Me.tbcSuppliers.Controls.Add(ContactLabel)
        Me.tbcSuppliers.Controls.Add(Me.ContactTextBox)
        Me.tbcSuppliers.Controls.Add(Me.Label4)
        Me.tbcSuppliers.Controls.Add(Me.rtbDescription)
        Me.tbcSuppliers.Controls.Add(Me.lblStatus)
        Me.tbcSuppliers.Controls.Add(Me.TextBox1)
        Me.tbcSuppliers.Controls.Add(Me.btn1)
        Me.tbcSuppliers.Controls.Add(Me.Label1)
        Me.tbcSuppliers.Controls.Add(Me.lstSuppliers)
        Me.tbcSuppliers.Location = New System.Drawing.Point(4, 25)
        Me.tbcSuppliers.Name = "tbcSuppliers"
        Me.tbcSuppliers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcSuppliers.Size = New System.Drawing.Size(544, 367)
        Me.tbcSuppliers.TabIndex = 0
        Me.tbcSuppliers.Text = "Add Suppliers"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(313, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Current Registered Suppliers:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(14, 325)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(278, 26)
        Me.EmailTextBox.TabIndex = 12
        '
        'ContactTextBox
        '
        Me.ContactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTextBox.Location = New System.Drawing.Point(14, 269)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(278, 26)
        Me.ContactTextBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(11, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Supplier Description (Optional)"
        '
        'rtbDescription
        '
        Me.rtbDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDescription.Location = New System.Drawing.Point(13, 189)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.Size = New System.Drawing.Size(279, 41)
        Me.rtbDescription.TabIndex = 9
        Me.rtbDescription.Text = ""
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(8, 127)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(199, 24)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Supplier Already Exist!"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(12, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 26)
        Me.TextBox1.TabIndex = 3
        '
        'btn1
        '
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn1.Location = New System.Drawing.Point(221, 76)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(71, 30)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "Add"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type Supplier's Name:"
        '
        'lstSuppliers
        '
        Me.lstSuppliers.DataSource = Me.TbSupplierBindingSource
        Me.lstSuppliers.DisplayMember = "Suppliers"
        Me.lstSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSuppliers.FormattingEnabled = True
        Me.lstSuppliers.ItemHeight = 18
        Me.lstSuppliers.Location = New System.Drawing.Point(316, 26)
        Me.lstSuppliers.Name = "lstSuppliers"
        Me.lstSuppliers.Size = New System.Drawing.Size(219, 328)
        Me.lstSuppliers.TabIndex = 0
        '
        'TbSupplierBindingSource
        '
        Me.TbSupplierBindingSource.DataMember = "tbSupplier"
        Me.TbSupplierBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'AutosupplyDataSet
        '
        Me.AutosupplyDataSet.DataSetName = "autosupplyDataSet"
        Me.AutosupplyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbcBrand
        '
        Me.tbcBrand.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.tbcBrand.Controls.Add(Me.Label8)
        Me.tbcBrand.Controls.Add(Me.Label5)
        Me.tbcBrand.Controls.Add(Me.rtbBrandDesc)
        Me.tbcBrand.Controls.Add(Me.lblstatus1)
        Me.tbcBrand.Controls.Add(Me.TextBox2)
        Me.tbcBrand.Controls.Add(Me.btn2)
        Me.tbcBrand.Controls.Add(Me.Label2)
        Me.tbcBrand.Controls.Add(Me.lstBrand)
        Me.tbcBrand.Location = New System.Drawing.Point(4, 25)
        Me.tbcBrand.Name = "tbcBrand"
        Me.tbcBrand.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcBrand.Size = New System.Drawing.Size(544, 367)
        Me.tbcBrand.TabIndex = 1
        Me.tbcBrand.Text = "Add Brand"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(313, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Current Registered Brand names:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(11, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Brand Description (Optional)"
        '
        'rtbBrandDesc
        '
        Me.rtbBrandDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbBrandDesc.Location = New System.Drawing.Point(13, 189)
        Me.rtbBrandDesc.Name = "rtbBrandDesc"
        Me.rtbBrandDesc.Size = New System.Drawing.Size(279, 165)
        Me.rtbBrandDesc.TabIndex = 11
        Me.rtbBrandDesc.Text = ""
        '
        'lblstatus1
        '
        Me.lblstatus1.AutoSize = True
        Me.lblstatus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus1.Location = New System.Drawing.Point(8, 127)
        Me.lblstatus1.Name = "lblstatus1"
        Me.lblstatus1.Size = New System.Drawing.Size(199, 24)
        Me.lblstatus1.TabIndex = 7
        Me.lblstatus1.Text = "Supplier Already Exist!"
        Me.lblstatus1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(12, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(280, 26)
        Me.TextBox2.TabIndex = 6
        '
        'btn2
        '
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn2.Location = New System.Drawing.Point(221, 76)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(71, 30)
        Me.btn2.TabIndex = 5
        Me.btn2.Text = "Add"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type the Brand Name:"
        '
        'lstBrand
        '
        Me.lstBrand.DataSource = Me.TbBrandBindingSource
        Me.lstBrand.DisplayMember = "BrandName"
        Me.lstBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBrand.FormattingEnabled = True
        Me.lstBrand.ItemHeight = 18
        Me.lstBrand.Location = New System.Drawing.Point(316, 26)
        Me.lstBrand.Name = "lstBrand"
        Me.lstBrand.Size = New System.Drawing.Size(219, 328)
        Me.lstBrand.TabIndex = 1
        '
        'TbBrandBindingSource
        '
        Me.TbBrandBindingSource.DataMember = "tbBrand"
        Me.TbBrandBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'tbcQuality
        '
        Me.tbcQuality.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.tbcQuality.Controls.Add(Me.Label9)
        Me.tbcQuality.Controls.Add(Me.Label6)
        Me.tbcQuality.Controls.Add(Me.rtbQualityDesc)
        Me.tbcQuality.Controls.Add(Me.lblstatus2)
        Me.tbcQuality.Controls.Add(Me.TextBox3)
        Me.tbcQuality.Controls.Add(Me.btn3)
        Me.tbcQuality.Controls.Add(Me.Label3)
        Me.tbcQuality.Controls.Add(Me.lstQuality)
        Me.tbcQuality.Location = New System.Drawing.Point(4, 25)
        Me.tbcQuality.Name = "tbcQuality"
        Me.tbcQuality.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcQuality.Size = New System.Drawing.Size(544, 367)
        Me.tbcQuality.TabIndex = 2
        Me.tbcQuality.Text = "Add Quality"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(313, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Current Registered  Product Qualities:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(11, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Quality Description (Optional)"
        '
        'rtbQualityDesc
        '
        Me.rtbQualityDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbQualityDesc.Location = New System.Drawing.Point(13, 189)
        Me.rtbQualityDesc.Name = "rtbQualityDesc"
        Me.rtbQualityDesc.Size = New System.Drawing.Size(279, 165)
        Me.rtbQualityDesc.TabIndex = 11
        Me.rtbQualityDesc.Text = ""
        '
        'lblstatus2
        '
        Me.lblstatus2.AutoSize = True
        Me.lblstatus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus2.Location = New System.Drawing.Point(8, 127)
        Me.lblstatus2.Name = "lblstatus2"
        Me.lblstatus2.Size = New System.Drawing.Size(199, 24)
        Me.lblstatus2.TabIndex = 7
        Me.lblstatus2.Text = "Supplier Already Exist!"
        Me.lblstatus2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(12, 44)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(280, 26)
        Me.TextBox3.TabIndex = 6
        '
        'btn3
        '
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(221, 76)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(71, 30)
        Me.btn3.TabIndex = 5
        Me.btn3.Text = "Add"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Type Product Quality: "
        '
        'lstQuality
        '
        Me.lstQuality.DataSource = Me.TbQualityBindingSource
        Me.lstQuality.DisplayMember = "ProductQuality"
        Me.lstQuality.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstQuality.FormattingEnabled = True
        Me.lstQuality.ItemHeight = 18
        Me.lstQuality.Location = New System.Drawing.Point(316, 26)
        Me.lstQuality.Name = "lstQuality"
        Me.lstQuality.Size = New System.Drawing.Size(219, 328)
        Me.lstQuality.TabIndex = 1
        '
        'TbQualityBindingSource
        '
        Me.TbQualityBindingSource.DataMember = "tbQuality"
        Me.TbQualityBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'TbSupplierTableAdapter
        '
        Me.TbSupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbAccountsTableAdapter = Nothing
        Me.TableAdapterManager.tbBrandTableAdapter = Me.TbBrandTableAdapter
        Me.TableAdapterManager.tbNameTableAdapter = Nothing
        Me.TableAdapterManager.tbPOSTableAdapter = Nothing
        Me.TableAdapterManager.tbProductsTableAdapter = Nothing
        Me.TableAdapterManager.tbQualityTableAdapter = Me.TbQualityTableAdapter
        Me.TableAdapterManager.tbReturnedTableAdapter = Nothing
        Me.TableAdapterManager.tbSupplierTableAdapter = Me.TbSupplierTableAdapter
        Me.TableAdapterManager.tbtimeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbBrandTableAdapter
        '
        Me.TbBrandTableAdapter.ClearBeforeFill = True
        '
        'TbQualityTableAdapter
        '
        Me.TbQualityTableAdapter.ClearBeforeFill = True
        '
        'frmsuppEtc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 396)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmsuppEtc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Suppliers, Brand and Quality "
        Me.TabControl1.ResumeLayout(False)
        Me.tbcSuppliers.ResumeLayout(False)
        Me.tbcSuppliers.PerformLayout()
        CType(Me.TbSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcBrand.ResumeLayout(False)
        Me.tbcBrand.PerformLayout()
        CType(Me.TbBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcQuality.ResumeLayout(False)
        Me.tbcQuality.PerformLayout()
        CType(Me.TbQualityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbcSuppliers As TabPage
    Friend WithEvents tbcBrand As TabPage
    Friend WithEvents tbcQuality As TabPage
    Friend WithEvents lstSuppliers As ListBox
    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbSupplierBindingSource As BindingSource
    Friend WithEvents TbSupplierTableAdapter As autosupplyDataSetTableAdapters.tbSupplierTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbQualityTableAdapter As autosupplyDataSetTableAdapters.tbQualityTableAdapter
    Friend WithEvents TbQualityBindingSource As BindingSource
    Friend WithEvents TbBrandTableAdapter As autosupplyDataSetTableAdapters.tbBrandTableAdapter
    Friend WithEvents TbBrandBindingSource As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btn2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lstBrand As ListBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btn3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lstQuality As ListBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblstatus1 As Label
    Friend WithEvents lblstatus2 As Label
    Friend WithEvents rtbDescription As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rtbBrandDesc As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rtbQualityDesc As RichTextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
