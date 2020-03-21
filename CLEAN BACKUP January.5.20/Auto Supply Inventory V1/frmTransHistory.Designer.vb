<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransHistory
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
        Dim TransactionDateLabel As System.Windows.Forms.Label
        Dim TransactionTimeLabel As System.Windows.Forms.Label
        Dim SignedLabel As System.Windows.Forms.Label
        Dim TokenLabel1 As System.Windows.Forms.Label
        Dim BreakdownsLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransHistory))
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.TbPOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbPOSTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbPOSTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        Me.TbPOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDateTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionTimeTextBox = New System.Windows.Forms.TextBox()
        Me.SignedTextBox = New System.Windows.Forms.TextBox()
        Me.TokenTextBox = New System.Windows.Forms.TextBox()
        Me.BreakdownsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        TransactionDateLabel = New System.Windows.Forms.Label()
        TransactionTimeLabel = New System.Windows.Forms.Label()
        SignedLabel = New System.Windows.Forms.Label()
        TokenLabel1 = New System.Windows.Forms.Label()
        BreakdownsLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransactionDateLabel
        '
        TransactionDateLabel.AutoSize = True
        TransactionDateLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TransactionDateLabel.Location = New System.Drawing.Point(7, 154)
        TransactionDateLabel.Name = "TransactionDateLabel"
        TransactionDateLabel.Size = New System.Drawing.Size(56, 23)
        TransactionDateLabel.TabIndex = 3
        TransactionDateLabel.Text = "Date:"
        '
        'TransactionTimeLabel
        '
        TransactionTimeLabel.AutoSize = True
        TransactionTimeLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TransactionTimeLabel.Location = New System.Drawing.Point(7, 218)
        TransactionTimeLabel.Name = "TransactionTimeLabel"
        TransactionTimeLabel.Size = New System.Drawing.Size(58, 23)
        TransactionTimeLabel.TabIndex = 5
        TransactionTimeLabel.Text = "Time:"
        '
        'SignedLabel
        '
        SignedLabel.AutoSize = True
        SignedLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SignedLabel.Location = New System.Drawing.Point(3, 292)
        SignedLabel.Name = "SignedLabel"
        SignedLabel.Size = New System.Drawing.Size(102, 23)
        SignedLabel.TabIndex = 9
        SignedLabel.Text = "Signature:"
        '
        'TokenLabel1
        '
        TokenLabel1.AutoSize = True
        TokenLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TokenLabel1.Location = New System.Drawing.Point(7, 87)
        TokenLabel1.Name = "TokenLabel1"
        TokenLabel1.Size = New System.Drawing.Size(71, 23)
        TokenLabel1.TabIndex = 10
        TokenLabel1.Text = "Token:"
        '
        'BreakdownsLabel
        '
        BreakdownsLabel.AutoSize = True
        BreakdownsLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BreakdownsLabel.Location = New System.Drawing.Point(516, 87)
        BreakdownsLabel.Name = "BreakdownsLabel"
        BreakdownsLabel.Size = New System.Drawing.Size(125, 23)
        BreakdownsLabel.TabIndex = 11
        BreakdownsLabel.Text = "Breakdowns:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(3, 24)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(54, 23)
        Label1.TabIndex = 10
        Label1.Text = "Find:"
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
        'TbPOSDataGridView
        '
        Me.TbPOSDataGridView.AllowUserToAddRows = False
        Me.TbPOSDataGridView.AutoGenerateColumns = False
        Me.TbPOSDataGridView.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TbPOSDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TbPOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbPOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TbPOSDataGridView.DataSource = Me.TbPOSBindingSource
        Me.TbPOSDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TbPOSDataGridView.Location = New System.Drawing.Point(0, 456)
        Me.TbPOSDataGridView.Name = "TbPOSDataGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TbPOSDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.TbPOSDataGridView.Size = New System.Drawing.Size(790, 372)
        Me.TbPOSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Token"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Token"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TransactionDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TransactionDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TransactionTime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TransactionTime"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Breakdowns"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Breakdowns"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Signed"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Signed"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'TransactionDateTextBox
        '
        Me.TransactionDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbPOSBindingSource, "TransactionDate", True))
        Me.TransactionDateTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionDateTextBox.Location = New System.Drawing.Point(7, 180)
        Me.TransactionDateTextBox.Name = "TransactionDateTextBox"
        Me.TransactionDateTextBox.ReadOnly = True
        Me.TransactionDateTextBox.Size = New System.Drawing.Size(293, 32)
        Me.TransactionDateTextBox.TabIndex = 4
        '
        'TransactionTimeTextBox
        '
        Me.TransactionTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbPOSBindingSource, "TransactionTime", True))
        Me.TransactionTimeTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionTimeTextBox.Location = New System.Drawing.Point(7, 244)
        Me.TransactionTimeTextBox.Name = "TransactionTimeTextBox"
        Me.TransactionTimeTextBox.ReadOnly = True
        Me.TransactionTimeTextBox.Size = New System.Drawing.Size(293, 32)
        Me.TransactionTimeTextBox.TabIndex = 6
        '
        'SignedTextBox
        '
        Me.SignedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbPOSBindingSource, "Signed", True))
        Me.SignedTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignedTextBox.Location = New System.Drawing.Point(7, 318)
        Me.SignedTextBox.Name = "SignedTextBox"
        Me.SignedTextBox.ReadOnly = True
        Me.SignedTextBox.Size = New System.Drawing.Size(162, 32)
        Me.SignedTextBox.TabIndex = 10
        '
        'TokenTextBox
        '
        Me.TokenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbPOSBindingSource, "Token", True))
        Me.TokenTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TokenTextBox.Location = New System.Drawing.Point(7, 113)
        Me.TokenTextBox.Name = "TokenTextBox"
        Me.TokenTextBox.ReadOnly = True
        Me.TokenTextBox.Size = New System.Drawing.Size(293, 32)
        Me.TokenTextBox.TabIndex = 11
        '
        'BreakdownsRichTextBox
        '
        Me.BreakdownsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BreakdownsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbPOSBindingSource, "Breakdowns", True))
        Me.BreakdownsRichTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakdownsRichTextBox.Location = New System.Drawing.Point(317, 126)
        Me.BreakdownsRichTextBox.Name = "BreakdownsRichTextBox"
        Me.BreakdownsRichTextBox.ReadOnly = True
        Me.BreakdownsRichTextBox.Size = New System.Drawing.Size(470, 304)
        Me.BreakdownsRichTextBox.TabIndex = 12
        Me.BreakdownsRichTextBox.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Khaki
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Khaki
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(225, 387)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 43)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = ">>"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(123, 387)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(790, 828)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape2.BorderWidth = 4
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 2
        Me.LineShape2.X2 = 789
        Me.LineShape2.Y1 = 66
        Me.LineShape2.Y2 = 64
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 4
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 787
        Me.LineShape1.Y1 = 445
        Me.LineShape1.Y2 = 444
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(57, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(408, 32)
        Me.txtSearch.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(471, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(550, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 41)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Khaki
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(525, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 43)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Open"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmTransHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(790, 828)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(BreakdownsLabel)
        Me.Controls.Add(Me.BreakdownsRichTextBox)
        Me.Controls.Add(TokenLabel1)
        Me.Controls.Add(Me.TokenTextBox)
        Me.Controls.Add(TransactionDateLabel)
        Me.Controls.Add(Me.TransactionDateTextBox)
        Me.Controls.Add(TransactionTimeLabel)
        Me.Controls.Add(Me.TransactionTimeTextBox)
        Me.Controls.Add(SignedLabel)
        Me.Controls.Add(Me.SignedTextBox)
        Me.Controls.Add(Me.TbPOSDataGridView)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmTransHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction History"
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbPOSBindingSource As BindingSource
    Friend WithEvents TbPOSTableAdapter As autosupplyDataSetTableAdapters.tbPOSTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TbPOSDataGridView As DataGridView
    Friend WithEvents TransactionDateTextBox As TextBox
    Friend WithEvents TransactionTimeTextBox As TextBox
    Friend WithEvents SignedTextBox As TextBox
    Friend WithEvents TokenTextBox As TextBox
    Friend WithEvents BreakdownsRichTextBox As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
