<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim EmployeeIDLabel1 As System.Windows.Forms.Label
        Dim LastNameLabel1 As System.Windows.Forms.Label
        Dim FirstNameLabel1 As System.Windows.Forms.Label
        Dim ContactLabel1 As System.Windows.Forms.Label
        Dim UsernameLabel1 As System.Windows.Forms.Label
        Dim PasswordLabel1 As System.Windows.Forms.Label
        Dim TypeLabel1 As System.Windows.Forms.Label
        Me.AutosupplyDataSet = New Auto_Supply_Inventory_V1.autosupplyDataSet()
        Me.TbAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbAccountsTableAdapter = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.tbAccountsTableAdapter()
        Me.TableAdapterManager = New Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbcRegister = New System.Windows.Forms.TabPage()
        Me.lblMatch = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.tbcAccountInfo = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TypeLabel2 = New System.Windows.Forms.Label()
        Me.EmployeeIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.ContactTextBox1 = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        EmployeeIDLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        EmployeeIDLabel1 = New System.Windows.Forms.Label()
        LastNameLabel1 = New System.Windows.Forms.Label()
        FirstNameLabel1 = New System.Windows.Forms.Label()
        ContactLabel1 = New System.Windows.Forms.Label()
        UsernameLabel1 = New System.Windows.Forms.Label()
        PasswordLabel1 = New System.Windows.Forms.Label()
        TypeLabel1 = New System.Windows.Forms.Label()
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbcRegister.SuspendLayout()
        Me.tbcAccountInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeIDLabel.Location = New System.Drawing.Point(5, 83)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(119, 23)
        EmployeeIDLabel.TabIndex = 1
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(18, 128)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(102, 23)
        LastNameLabel.TabIndex = 3
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(16, 177)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(104, 23)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.Location = New System.Drawing.Point(368, 40)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(79, 23)
        ContactLabel.TabIndex = 7
        ContactLabel.Text = "Contact:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(350, 87)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(99, 23)
        UsernameLabel.TabIndex = 9
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(354, 136)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(94, 23)
        PasswordLabel.TabIndex = 11
        PasswordLabel.Text = "Password:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeLabel.Location = New System.Drawing.Point(59, 40)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(54, 23)
        TypeLabel.TabIndex = 13
        TypeLabel.Text = "Type:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(364, 181)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(82, 23)
        Label1.TabIndex = 11
        Label1.Text = "Confirm:"
        '
        'EmployeeIDLabel1
        '
        EmployeeIDLabel1.AutoSize = True
        EmployeeIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeIDLabel1.Location = New System.Drawing.Point(37, 23)
        EmployeeIDLabel1.Name = "EmployeeIDLabel1"
        EmployeeIDLabel1.Size = New System.Drawing.Size(104, 20)
        EmployeeIDLabel1.TabIndex = 0
        EmployeeIDLabel1.Text = "Employee ID:"
        '
        'LastNameLabel1
        '
        LastNameLabel1.AutoSize = True
        LastNameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel1.Location = New System.Drawing.Point(37, 94)
        LastNameLabel1.Name = "LastNameLabel1"
        LastNameLabel1.Size = New System.Drawing.Size(90, 20)
        LastNameLabel1.TabIndex = 2
        LastNameLabel1.Text = "Last Name:"
        '
        'FirstNameLabel1
        '
        FirstNameLabel1.AutoSize = True
        FirstNameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel1.Location = New System.Drawing.Point(37, 157)
        FirstNameLabel1.Name = "FirstNameLabel1"
        FirstNameLabel1.Size = New System.Drawing.Size(90, 20)
        FirstNameLabel1.TabIndex = 4
        FirstNameLabel1.Text = "First Name:"
        '
        'ContactLabel1
        '
        ContactLabel1.AutoSize = True
        ContactLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel1.Location = New System.Drawing.Point(369, 23)
        ContactLabel1.Name = "ContactLabel1"
        ContactLabel1.Size = New System.Drawing.Size(69, 20)
        ContactLabel1.TabIndex = 6
        ContactLabel1.Text = "Contact:"
        '
        'UsernameLabel1
        '
        UsernameLabel1.AutoSize = True
        UsernameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel1.Location = New System.Drawing.Point(369, 94)
        UsernameLabel1.Name = "UsernameLabel1"
        UsernameLabel1.Size = New System.Drawing.Size(87, 20)
        UsernameLabel1.TabIndex = 8
        UsernameLabel1.Text = "Username:"
        '
        'PasswordLabel1
        '
        PasswordLabel1.AutoSize = True
        PasswordLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel1.Location = New System.Drawing.Point(369, 161)
        PasswordLabel1.Name = "PasswordLabel1"
        PasswordLabel1.Size = New System.Drawing.Size(82, 20)
        PasswordLabel1.TabIndex = 10
        PasswordLabel1.Text = "Password:"
        '
        'TypeLabel1
        '
        TypeLabel1.AutoSize = True
        TypeLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeLabel1.Location = New System.Drawing.Point(37, 229)
        TypeLabel1.Name = "TypeLabel1"
        TypeLabel1.Size = New System.Drawing.Size(46, 21)
        TypeLabel1.TabIndex = 12
        TypeLabel1.Text = "Type:"
        '
        'AutosupplyDataSet
        '
        Me.AutosupplyDataSet.DataSetName = "autosupplyDataSet"
        Me.AutosupplyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbAccountsBindingSource
        '
        Me.TbAccountsBindingSource.DataMember = "tbAccounts"
        Me.TbAccountsBindingSource.DataSource = Me.AutosupplyDataSet
        '
        'TbAccountsTableAdapter
        '
        Me.TbAccountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbAccountsTableAdapter = Me.TbAccountsTableAdapter
        Me.TableAdapterManager.tbBrandTableAdapter = Nothing
        Me.TableAdapterManager.tbNameTableAdapter = Nothing
        Me.TableAdapterManager.tbPOSTableAdapter = Nothing
        Me.TableAdapterManager.tbProductsTableAdapter = Nothing
        Me.TableAdapterManager.tbQualityTableAdapter = Nothing
        Me.TableAdapterManager.tbReturnedTableAdapter = Nothing
        Me.TableAdapterManager.tbSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbtimeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Auto_Supply_Inventory_V1.autosupplyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(129, 78)
        Me.EmployeeIDTextBox.MaxLength = 12
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.ReadOnly = True
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(205, 32)
        Me.EmployeeIDTextBox.TabIndex = 2
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(129, 126)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.ReadOnly = True
        Me.LastNameTextBox.Size = New System.Drawing.Size(205, 32)
        Me.LastNameTextBox.TabIndex = 4
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(129, 175)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.ReadOnly = True
        Me.FirstNameTextBox.Size = New System.Drawing.Size(205, 32)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'ContactTextBox
        '
        Me.ContactTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTextBox.Location = New System.Drawing.Point(453, 31)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.ReadOnly = True
        Me.ContactTextBox.Size = New System.Drawing.Size(186, 32)
        Me.ContactTextBox.TabIndex = 8
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(453, 78)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.ReadOnly = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(186, 32)
        Me.UsernameTextBox.TabIndex = 10
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(453, 127)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(186, 32)
        Me.PasswordTextBox.TabIndex = 12
        '
        'btnReg
        '
        Me.btnReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReg.Enabled = False
        Me.btnReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.Location = New System.Drawing.Point(285, 219)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(92, 51)
        Me.btnReg.TabIndex = 15
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.ComboBox1.Location = New System.Drawing.Point(129, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 31)
        Me.ComboBox1.TabIndex = 16
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.tbcRegister)
        Me.TabControl1.Controls.Add(Me.tbcAccountInfo)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(661, 311)
        Me.TabControl1.TabIndex = 17
        '
        'tbcRegister
        '
        Me.tbcRegister.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.tbcRegister.Controls.Add(Me.lblMatch)
        Me.tbcRegister.Controls.Add(Me.btnReg)
        Me.tbcRegister.Controls.Add(Me.ComboBox1)
        Me.tbcRegister.Controls.Add(TypeLabel)
        Me.tbcRegister.Controls.Add(Me.txtpass)
        Me.tbcRegister.Controls.Add(Me.PasswordTextBox)
        Me.tbcRegister.Controls.Add(Label1)
        Me.tbcRegister.Controls.Add(EmployeeIDLabel)
        Me.tbcRegister.Controls.Add(PasswordLabel)
        Me.tbcRegister.Controls.Add(Me.EmployeeIDTextBox)
        Me.tbcRegister.Controls.Add(Me.UsernameTextBox)
        Me.tbcRegister.Controls.Add(LastNameLabel)
        Me.tbcRegister.Controls.Add(UsernameLabel)
        Me.tbcRegister.Controls.Add(Me.LastNameTextBox)
        Me.tbcRegister.Controls.Add(Me.ContactTextBox)
        Me.tbcRegister.Controls.Add(FirstNameLabel)
        Me.tbcRegister.Controls.Add(ContactLabel)
        Me.tbcRegister.Controls.Add(Me.FirstNameTextBox)
        Me.tbcRegister.Location = New System.Drawing.Point(4, 25)
        Me.tbcRegister.Name = "tbcRegister"
        Me.tbcRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcRegister.Size = New System.Drawing.Size(653, 282)
        Me.tbcRegister.TabIndex = 0
        Me.tbcRegister.Text = "Register Users"
        '
        'lblMatch
        '
        Me.lblMatch.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatch.Location = New System.Drawing.Point(453, 207)
        Me.lblMatch.Name = "lblMatch"
        Me.lblMatch.Size = New System.Drawing.Size(186, 34)
        Me.lblMatch.TabIndex = 17
        Me.lblMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(453, 172)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.ReadOnly = True
        Me.txtpass.Size = New System.Drawing.Size(186, 32)
        Me.txtpass.TabIndex = 12
        '
        'tbcAccountInfo
        '
        Me.tbcAccountInfo.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.tbcAccountInfo.Controls.Add(Me.Button1)
        Me.tbcAccountInfo.Controls.Add(TypeLabel1)
        Me.tbcAccountInfo.Controls.Add(Me.TypeLabel2)
        Me.tbcAccountInfo.Controls.Add(EmployeeIDLabel1)
        Me.tbcAccountInfo.Controls.Add(Me.EmployeeIDTextBox1)
        Me.tbcAccountInfo.Controls.Add(LastNameLabel1)
        Me.tbcAccountInfo.Controls.Add(Me.LastNameTextBox1)
        Me.tbcAccountInfo.Controls.Add(FirstNameLabel1)
        Me.tbcAccountInfo.Controls.Add(Me.FirstNameTextBox1)
        Me.tbcAccountInfo.Controls.Add(ContactLabel1)
        Me.tbcAccountInfo.Controls.Add(Me.ContactTextBox1)
        Me.tbcAccountInfo.Controls.Add(UsernameLabel1)
        Me.tbcAccountInfo.Controls.Add(Me.UsernameTextBox1)
        Me.tbcAccountInfo.Controls.Add(PasswordLabel1)
        Me.tbcAccountInfo.Controls.Add(Me.PasswordTextBox1)
        Me.tbcAccountInfo.Location = New System.Drawing.Point(4, 25)
        Me.tbcAccountInfo.Name = "tbcAccountInfo"
        Me.tbcAccountInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcAccountInfo.Size = New System.Drawing.Size(653, 282)
        Me.tbcAccountInfo.TabIndex = 1
        Me.tbcAccountInfo.Text = "Account Information"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(432, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TypeLabel2
        '
        Me.TypeLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAccountsBindingSource, "Type", True))
        Me.TypeLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeLabel2.Location = New System.Drawing.Point(89, 229)
        Me.TypeLabel2.Name = "TypeLabel2"
        Me.TypeLabel2.Size = New System.Drawing.Size(100, 23)
        Me.TypeLabel2.TabIndex = 13
        Me.TypeLabel2.Text = "Label2"
        '
        'EmployeeIDTextBox1
        '
        Me.EmployeeIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAccountsBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTextBox1.Location = New System.Drawing.Point(41, 46)
        Me.EmployeeIDTextBox1.Name = "EmployeeIDTextBox1"
        Me.EmployeeIDTextBox1.ReadOnly = True
        Me.EmployeeIDTextBox1.Size = New System.Drawing.Size(204, 26)
        Me.EmployeeIDTextBox1.TabIndex = 1
        '
        'LastNameTextBox1
        '
        Me.LastNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAccountsBindingSource, "LastName", True))
        Me.LastNameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox1.Location = New System.Drawing.Point(41, 117)
        Me.LastNameTextBox1.Name = "LastNameTextBox1"
        Me.LastNameTextBox1.Size = New System.Drawing.Size(204, 26)
        Me.LastNameTextBox1.TabIndex = 3
        '
        'FirstNameTextBox1
        '
        Me.FirstNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAccountsBindingSource, "FirstName", True))
        Me.FirstNameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox1.Location = New System.Drawing.Point(41, 184)
        Me.FirstNameTextBox1.Name = "FirstNameTextBox1"
        Me.FirstNameTextBox1.Size = New System.Drawing.Size(204, 26)
        Me.FirstNameTextBox1.TabIndex = 5
        '
        'ContactTextBox1
        '
        Me.ContactTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAccountsBindingSource, "Contact", True))
        Me.ContactTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTextBox1.Location = New System.Drawing.Point(373, 46)
        Me.ContactTextBox1.Name = "ContactTextBox1"
        Me.ContactTextBox1.Size = New System.Drawing.Size(204, 26)
        Me.ContactTextBox1.TabIndex = 7
        '
        'UsernameTextBox1
        '
        Me.UsernameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAccountsBindingSource, "Username", True))
        Me.UsernameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox1.Location = New System.Drawing.Point(373, 117)
        Me.UsernameTextBox1.Name = "UsernameTextBox1"
        Me.UsernameTextBox1.ReadOnly = True
        Me.UsernameTextBox1.Size = New System.Drawing.Size(204, 26)
        Me.UsernameTextBox1.TabIndex = 9
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbAccountsBindingSource, "Password", True))
        Me.PasswordTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox1.Location = New System.Drawing.Point(373, 184)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox1.Size = New System.Drawing.Size(204, 26)
        Me.PasswordTextBox1.TabIndex = 11
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 311)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register System Users"
        CType(Me.AutosupplyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbcRegister.ResumeLayout(False)
        Me.tbcRegister.PerformLayout()
        Me.tbcAccountInfo.ResumeLayout(False)
        Me.tbcAccountInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AutosupplyDataSet As autosupplyDataSet
    Friend WithEvents TbAccountsBindingSource As BindingSource
    Friend WithEvents TbAccountsTableAdapter As autosupplyDataSetTableAdapters.tbAccountsTableAdapter
    Friend WithEvents TableAdapterManager As autosupplyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents btnReg As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbcRegister As TabPage
    Friend WithEvents tbcAccountInfo As TabPage
    Friend WithEvents lblMatch As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TypeLabel2 As Label
    Friend WithEvents EmployeeIDTextBox1 As TextBox
    Friend WithEvents LastNameTextBox1 As TextBox
    Friend WithEvents FirstNameTextBox1 As TextBox
    Friend WithEvents ContactTextBox1 As TextBox
    Friend WithEvents UsernameTextBox1 As TextBox
    Friend WithEvents PasswordTextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
