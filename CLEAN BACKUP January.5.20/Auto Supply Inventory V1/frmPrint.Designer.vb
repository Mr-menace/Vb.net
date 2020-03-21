<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrint))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbcBarcode = New System.Windows.Forms.TabPage()
        Me.BarcodeimgPictureBox = New System.Windows.Forms.PictureBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbcReports = New System.Windows.Forms.TabPage()
        Me.pbFiles = New System.Windows.Forms.PictureBox()
        Me.pbProcess = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.pbPrint = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TbProductsTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbProductsTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tbcBarcode.SuspendLayout()
        CType(Me.BarcodeimgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcReports.SuspendLayout()
        CType(Me.pbFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(419, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(419, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 37)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Preview"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(156, 237)
        Me.txtBarcode.MaxLength = 30
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(201, 32)
        Me.txtBarcode.TabIndex = 1
        Me.txtBarcode.Text = "123456789012"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Barcode Digit:"
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Font = New System.Drawing.Font("Code EAN13", 66.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblOut.Location = New System.Drawing.Point(138, 70)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(287, 107)
        Me.lblOut.TabIndex = 3
        Me.lblOut.Text = "1CDOFQR*ijabci+"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.tbcBarcode)
        Me.TabControl1.Controls.Add(Me.tbcReports)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 393)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 4
        '
        'tbcBarcode
        '
        Me.tbcBarcode.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.tbcBarcode.Controls.Add(Me.BarcodeimgPictureBox)
        Me.tbcBarcode.Controls.Add(Me.RadioButton2)
        Me.tbcBarcode.Controls.Add(Me.RadioButton1)
        Me.tbcBarcode.Controls.Add(Me.Label3)
        Me.tbcBarcode.Controls.Add(Me.txtName)
        Me.tbcBarcode.Controls.Add(Me.lblOut)
        Me.tbcBarcode.Controls.Add(Me.Button1)
        Me.tbcBarcode.Controls.Add(Me.Label2)
        Me.tbcBarcode.Controls.Add(Me.Label1)
        Me.tbcBarcode.Controls.Add(Me.Button2)
        Me.tbcBarcode.Controls.Add(Me.txtBarcode)
        Me.tbcBarcode.Location = New System.Drawing.Point(4, 28)
        Me.tbcBarcode.Name = "tbcBarcode"
        Me.tbcBarcode.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcBarcode.Size = New System.Drawing.Size(520, 361)
        Me.tbcBarcode.TabIndex = 0
        Me.tbcBarcode.Text = "Print Barcode "
        '
        'BarcodeimgPictureBox
        '
        Me.BarcodeimgPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.BarcodeimgPictureBox.Location = New System.Drawing.Point(133, 70)
        Me.BarcodeimgPictureBox.Name = "BarcodeimgPictureBox"
        Me.BarcodeimgPictureBox.Size = New System.Drawing.Size(287, 107)
        Me.BarcodeimgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BarcodeimgPictureBox.TabIndex = 20
        Me.BarcodeimgPictureBox.TabStop = False
        Me.BarcodeimgPictureBox.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(329, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(112, 27)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "CODE 128"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(120, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(131, 27)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CODEAN-13"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(198, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "(Optional)"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(156, 278)
        Me.txtName.MaxLength = 21
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 32)
        Me.txtName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name:"
        '
        'tbcReports
        '
        Me.tbcReports.AutoScroll = True
        Me.tbcReports.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.tbcReports.Controls.Add(Me.pbFiles)
        Me.tbcReports.Controls.Add(Me.pbProcess)
        Me.tbcReports.Controls.Add(Me.PictureBox2)
        Me.tbcReports.Controls.Add(Me.lblPercent)
        Me.tbcReports.Controls.Add(Me.lblStat)
        Me.tbcReports.Controls.Add(Me.ProgressBar1)
        Me.tbcReports.Controls.Add(Me.pbPrint)
        Me.tbcReports.Controls.Add(Me.Label5)
        Me.tbcReports.Controls.Add(Me.ComboBox1)
        Me.tbcReports.Controls.Add(Me.Label4)
        Me.tbcReports.Location = New System.Drawing.Point(4, 28)
        Me.tbcReports.Name = "tbcReports"
        Me.tbcReports.Size = New System.Drawing.Size(520, 361)
        Me.tbcReports.TabIndex = 1
        Me.tbcReports.Text = "Reports"
        '
        'pbFiles
        '
        Me.pbFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFiles.Image = CType(resources.GetObject("pbFiles.Image"), System.Drawing.Image)
        Me.pbFiles.Location = New System.Drawing.Point(3, 94)
        Me.pbFiles.Name = "pbFiles"
        Me.pbFiles.Size = New System.Drawing.Size(63, 54)
        Me.pbFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFiles.TabIndex = 11
        Me.pbFiles.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbFiles, "Open Report Folder")
        '
        'pbProcess
        '
        Me.pbProcess.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.pbProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbProcess.Image = CType(resources.GetObject("pbProcess.Image"), System.Drawing.Image)
        Me.pbProcess.Location = New System.Drawing.Point(220, 94)
        Me.pbProcess.Name = "pbProcess"
        Me.pbProcess.Size = New System.Drawing.Size(63, 54)
        Me.pbProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProcess.TabIndex = 10
        Me.pbProcess.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbProcess, "Generate Choosen Report")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(311, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 230)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'lblPercent
        '
        Me.lblPercent.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(67, 219)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(75, 21)
        Me.lblPercent.TabIndex = 8
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStat
        '
        Me.lblStat.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStat.Location = New System.Drawing.Point(8, 283)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(508, 45)
        Me.lblStat.TabIndex = 7
        Me.lblStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.LightGreen
        Me.ProgressBar1.ForeColor = System.Drawing.Color.DarkRed
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 243)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(513, 37)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 6
        Me.ProgressBar1.Visible = False
        '
        'pbPrint
        '
        Me.pbPrint.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.pbPrint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPrint.Image = CType(resources.GetObject("pbPrint.Image"), System.Drawing.Image)
        Me.pbPrint.Location = New System.Drawing.Point(110, 94)
        Me.pbPrint.Name = "pbPrint"
        Me.pbPrint.Size = New System.Drawing.Size(63, 54)
        Me.pbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPrint.TabIndex = 5
        Me.pbPrint.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbPrint, "Click this after generating reports")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "|Status:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Silver
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Daily Inventory", "General Inventory", "Daily Stocks", "Daily Purchase", "General Purchase"})
        Me.ComboBox1.Location = New System.Drawing.Point(3, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(280, 32)
        Me.ComboBox1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Choose Report to Generate")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 34)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "|Report Generator:"
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
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
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
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 20
        Me.ToolTip1.ToolTipTitle = "|Report Generator"
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 393)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printing"
        Me.TabControl1.ResumeLayout(False)
        Me.tbcBarcode.ResumeLayout(False)
        Me.tbcBarcode.PerformLayout()
        CType(Me.BarcodeimgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcReports.ResumeLayout(False)
        Me.tbcReports.PerformLayout()
        CType(Me.pbFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOut As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbcBarcode As TabPage
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents tbcReports As TabPage
    Friend WithEvents BarcodeimgPictureBox As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pbPrint As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbProductsBindingSource As BindingSource
    Friend WithEvents TbProductsTableAdapter As autosupplyDataSetTableAdapters.tbProductsTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblStat As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents pbProcess As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pbFiles As PictureBox
End Class
