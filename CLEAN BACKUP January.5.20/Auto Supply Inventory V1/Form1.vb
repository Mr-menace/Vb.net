Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Diagnostics
Imports System.Data.OleDb
Imports System.Linq


Public Class Form1

    Dim i As Integer = 0
    Dim con As OleDbConnection
    Dim na = Date.Today.ToLongDateString
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)

    End Sub

    Private Const WTM As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub SetCueText(ByVal control As Control, ByVal text As String)
        SendMessage(control.Handle, WTM, 0, text)

    End Sub
    Private Sub TbAccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbAccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbName' table. You can move, or remove it, as needed.
        Me.TbNameTableAdapter.Fill(Me.AutosupplyDataSet.tbName)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbName' table. You can move, or remove it, as needed.
        Me.TbNameTableAdapter.Fill(Me.AutosupplyDataSet.tbName)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbProducts' table. You can move, or remove it, as needed.
        Me.TbProductsTableAdapter.Fill(Me.AutosupplyDataSet.tbProducts)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbAccounts' table. You can move, or remove it, as needed.
        Me.TbAccountsTableAdapter.Fill(Me.AutosupplyDataSet.tbAccounts)

        lblRec.Text = AutosupplyDataSet.tbProducts.Count.ToString

        SetCueText(txtSearch, "Search Barcode,Name,Brand Etc..")


        'Dim total As Integer
        'For Each row As DataGridViewRow In TbProductsDataGridView.Rows
        '    total += row.Cells("OrigPrice").Value
        'Next
        'MessageBox.Show(total)


    End Sub

    Private Sub btnProd_MouseClick(sender As Object, e As MouseEventArgs) Handles btnProd.MouseClick
        btnProd.FillColor = Color.Cornsilk
    End Sub

    Private Sub btnProd_MouseHover(sender As Object, e As EventArgs) Handles btnProd.MouseHover
        lblButType.Text = "Product Registration"
        btnProd.FillColor = Color.Cyan
    End Sub

    Private Sub btnProd_MouseLeave(sender As Object, e As EventArgs) Handles btnProd.MouseLeave
        lblButType.ResetText()
        btnProd.FillColor = Color.Transparent
    End Sub

    Private Sub btnSuppliers_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSuppliers.MouseClick
        btnSuppliers.FillColor = Color.Cornsilk
    End Sub

    Private Sub btnSuppliers_MouseHover(sender As Object, e As EventArgs) Handles btnSuppliers.MouseHover
        lblButType.Text = "List of Suppliers, Brand And Qualities"
        btnSuppliers.FillColor = Color.Cyan
    End Sub

    Private Sub btnSuppliers_MouseLeave(sender As Object, e As EventArgs) Handles btnSuppliers.MouseLeave
        lblButType.ResetText()
        btnSuppliers.FillColor = Color.Transparent
    End Sub

    Private Sub btnDelivery_MouseClick(sender As Object, e As MouseEventArgs) Handles btnReturn.MouseClick
        btnReturn.FillColor = Color.Cornsilk
    End Sub

    Private Sub btnDelivery_MouseHover(sender As Object, e As EventArgs) Handles btnReturn.MouseHover
        lblButType.Text = "Return an item or View Returned Items"
        btnReturn.FillColor = Color.Cyan
    End Sub

    Private Sub btnDelivery_MouseLeave(sender As Object, e As EventArgs) Handles btnReturn.MouseLeave
        lblButType.ResetText()
        btnReturn.FillColor = Color.Transparent
    End Sub

    Private Sub btnReg_MouseClick(sender As Object, e As MouseEventArgs) Handles btnReg.MouseClick
        btnReg.FillColor = Color.Cornsilk
    End Sub

    Private Sub btnReg_MouseHover(sender As Object, e As EventArgs) Handles btnReg.MouseHover
        lblButType.Text = "Add Users"
        btnReg.FillColor = Color.Cyan
    End Sub

    Private Sub btnReg_MouseLeave(sender As Object, e As EventArgs) Handles btnReg.MouseLeave
        lblButType.ResetText()
        btnReg.FillColor = Color.Transparent

    End Sub

    Private Sub btnSettings_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSettings.MouseClick
        btnSettings.FillColor = Color.Cornsilk
    End Sub

    Private Sub btnSettings_MouseHover(sender As Object, e As EventArgs) Handles btnSettings.MouseHover
        lblButType.Text = "Stocks Look-Out"
        btnSettings.FillColor = Color.Cyan
    End Sub

    Private Sub btnSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        lblButType.ResetText()
        btnSettings.FillColor = Color.Transparent
    End Sub

    Private Sub btnApp_MouseClick(sender As Object, e As MouseEventArgs) Handles btnpull2.MouseClick
        btnpull2.FillColor = Color.Cornsilk
    End Sub

    Private Sub btnApp_MouseHover(sender As Object, e As EventArgs) Handles btnpull2.MouseHover
        lblButType.Text = "Pull Out or Re-Stock"
        btnpull2.FillColor = Color.Cyan
    End Sub

    Private Sub btnApp_MouseLeave(sender As Object, e As EventArgs) Handles btnpull2.MouseLeave
        lblButType.ResetText()
        btnpull2.FillColor = Color.Transparent
    End Sub

    Private Sub btnSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSearch.MouseClick
        btnSearch.FillColor = Color.Red
    End Sub

    Private Sub btnSearch_MouseHover(sender As Object, e As EventArgs) Handles btnSearch.MouseHover
        lblDataView.Text = "Search Product"
        btnSearch.FillColor = Color.Cyan
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        lblDataView.ResetText()
        btnSearch.FillColor = Color.Transparent
    End Sub

    Private Sub btnReset_MouseClick(sender As Object, e As MouseEventArgs) Handles btnReset.MouseClick
        btnReset.FillColor = Color.Red
        btnReset.FillColor = Color.Cyan
    End Sub

    Private Sub btnReset_MouseHover(sender As Object, e As EventArgs) Handles btnReset.MouseHover
        lblDataView.Text = "Clear Fields"
        btnReset.FillColor = Color.Cyan
    End Sub

    Private Sub btnReset_MouseLeave(sender As Object, e As EventArgs) Handles btnReset.MouseLeave
        lblDataView.ResetText()
        btnReset.FillColor = Color.Transparent
    End Sub

    Private Sub btnAdd_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAdd.MouseClick
        btnAdd.FillColor = Color.Red
    End Sub

    Private Sub btnAdd_MouseHover(sender As Object, e As EventArgs) Handles btnAdd.MouseHover
        lblDataView.Text = "Product Registration"
        btnAdd.FillColor = Color.Cyan
    End Sub

    Private Sub btnAdd_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        lblDataView.ResetText()
        btnAdd.FillColor = Color.Transparent
    End Sub

    Private Sub btnRemove_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRemove.MouseClick
        btnRemove.FillColor = Color.Red
    End Sub

    Private Sub btnRemove_MouseHover(sender As Object, e As EventArgs) Handles btnRemove.MouseHover
        lblDataView.Text = "Delete Data"
        btnRemove.FillColor = Color.Cyan
    End Sub

    Private Sub btnRemove_MouseLeave(sender As Object, e As EventArgs) Handles btnRemove.MouseLeave
        lblDataView.ResetText()
        btnRemove.FillColor = Color.Transparent
    End Sub

    Private Sub btnRefresh_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRefresh.MouseClick
        btnRefresh.FillColor = Color.Red
    End Sub

    Private Sub btnRefresh_MouseHover(sender As Object, e As EventArgs) Handles btnRefresh.MouseHover
        lblDataView.Text = "Refresh Database"
        btnRefresh.FillColor = Color.Cyan
    End Sub

    Private Sub btnRefresh_MouseLeave(sender As Object, e As EventArgs) Handles btnRefresh.MouseLeave
        lblDataView.ResetText()
        btnRefresh.FillColor = Color.Transparent
    End Sub

    Private Sub btnPrevious_MouseClick(sender As Object, e As MouseEventArgs) Handles btnPrevious.MouseClick
        btnPrevious.FillColor = Color.Red
    End Sub

    Private Sub btnPrevious_MouseHover(sender As Object, e As EventArgs) Handles btnPrevious.MouseHover
        lblDataView.Text = "Navigate Previous"
        btnPrevious.FillColor = Color.Cyan
    End Sub

    Private Sub btnPrevious_MouseLeave(sender As Object, e As EventArgs) Handles btnPrevious.MouseLeave
        lblDataView.ResetText()
        btnPrevious.FillColor = Color.Transparent
    End Sub

    Private Sub btnNext_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNext.MouseClick
        btnNext.FillColor = Color.Red
    End Sub

    Private Sub btnNext_MouseHover(sender As Object, e As EventArgs) Handles btnNext.MouseHover
        lblDataView.Text = "Navigate Next"
        btnNext.FillColor = Color.Cyan
    End Sub

    Private Sub btnNext_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        lblDataView.ResetText()
        btnNext.FillColor = Color.Transparent
    End Sub

    Private Sub TbProductsDataGridView_MouseHover(sender As Object, e As EventArgs) Handles TbProductsDataGridView.MouseHover
        lblButType.ResetText()
        lblDataView.ResetText()
        btnProd.FillColor = Color.Transparent
        btnSuppliers.FillColor = Color.Transparent
        btnReturn.FillColor = Color.Transparent
        btnReg.FillColor = Color.Transparent
        btnSettings.FillColor = Color.Transparent
        btnpull2.FillColor = Color.Transparent

        btnSearch.FillColor = Color.Transparent
        btnReset.FillColor = Color.Transparent
        btnPrint.FillColor = Color.Transparent
        btnPull.FillColor = Color.Transparent
        btnAdd.FillColor = Color.Transparent
        btnRemove.FillColor = Color.Transparent
        btnRefresh.FillColor = Color.Transparent
        btnPrevious.FillColor = Color.Transparent
        btnNext.FillColor = Color.Transparent

    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        lblButType.ResetText()
        lblDataView.ResetText()
        btnSearch.FillColor = Color.Transparent
        btnReset.FillColor = Color.Transparent
        btnPrint.FillColor = Color.Transparent
        btnPull.FillColor = Color.Transparent
        btnAdd.FillColor = Color.Transparent
        btnRemove.FillColor = Color.Transparent
        btnRefresh.FillColor = Color.Transparent
        btnPrevious.FillColor = Color.Transparent
        btnNext.FillColor = Color.Transparent
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToLongTimeString
        lblDate.Text = Date.Today.ToLongDateString

        For i = 0 To TbProductsDataGridView.Rows.Count - 1
            'pag ang column quantity ay <3 ang value mag chachangeto red ang background ng row if not back to default
            If TbProductsDataGridView.Rows(i).Cells(6).Value < 3 Then
                TbProductsDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red

            Else

                TbProductsDataGridView.Rows(i).DefaultCellStyle.BackColor = SystemColors.ButtonFace

            End If
        Next



    End Sub

    Private Sub btnProd_Click(sender As Object, e As EventArgs) Handles btnProd.Click
        ' btnProd.FillColor = Color.Transparent
        frmAdd.TbProductsTableAdapter.Fill(frmAdd.AutosupplyDataSet.tbProducts)
        frmAdd.ShowDialog()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = Nothing Then
            Exit Sub

        Else

            TbProductsBindingSource.Filter = "(CONVERT(ProductID, 'System.String')LIKE '" & txtSearch.Text & "') OR(CONVERT(BarcodeEncode, 'System.String')LIKE '" & txtSearch.Text & "')
                                            OR(ProductName LIKE '" & txtSearch.Text & "') OR(Quality LIKE'" & txtSearch.Text & "') OR(PartNo LIKE'" & txtSearch.Text & "') 
                                            OR(Supplier LIKE'" & txtSearch.Text & "') OR(DeliveryDate LIKE'" & txtSearch.Text & "') OR(Brand LIKE '" & txtSearch.Text & "')"

            lblSearch.Text = "Record Found: " & TbProductsBindingSource.Count.ToString

            If TbProductsBindingSource.Count = 0 Then
                lblSearch.Text = "No Record Found"
                MessageBox.Show("No Such Record Found", "Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If


        End If


    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        TbProductsTableAdapter.Fill(AutosupplyDataSet.tbProducts)
        TbProductsBindingSource.Filter = Nothing
        lblSearch.ResetText()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        TbProductsBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        TbProductsBindingSource.MoveNext()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblSearch.ResetText()
        txtSearch.ResetText()


    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        btnProd.FillColor = Color.Transparent
        btnSuppliers.FillColor = Color.Transparent
        btnReturn.FillColor = Color.Transparent
        btnReg.FillColor = Color.Transparent
        btnSettings.FillColor = Color.Transparent
        btnpull2.FillColor = Color.Transparent
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        frmAdd.ShowDialog()
        frmAdd.TbProductsTableAdapter.Fill(frmAdd.AutosupplyDataSet.tbProducts)

    End Sub



    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        frmsuppEtc.TabControl1.SelectedTab = frmsuppEtc.tbcSuppliers
        frmsuppEtc.ShowDialog()
    End Sub

    Private Sub BrandNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrandNameToolStripMenuItem.Click
        frmsuppEtc.TabControl1.SelectedTab = frmsuppEtc.tbcBrand
        frmsuppEtc.ShowDialog()
    End Sub

    Private Sub QualityStandardsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QualityStandardsToolStripMenuItem.Click
        frmsuppEtc.TabControl1.SelectedTab = frmsuppEtc.tbcQuality
        frmsuppEtc.ShowDialog()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lblType.Text = "ADMIN" Then

            If (MessageBox.Show("Do you want to delete this product? deleting products may come with a cost sometimes or conflict", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                TbProductsBindingSource.RemoveCurrent()
                TbProductsBindingSource.EndEdit()
                TbProductsTableAdapter.Update(AutosupplyDataSet.tbProducts)
                lblRec.Text = AutosupplyDataSet.tbProducts.Count.ToString

            Else
                Exit Sub

            End If

        Else
            MessageBox.Show("You don't have Permission to Delete this. ", "For Admin Access Only", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim na
        na = ComboBox1.SelectedItem.ToString

        TbProductsDataGridView.RowTemplate.Height = na
        TbProductsTableAdapter.Fill(AutosupplyDataSet.tbProducts)

        If ComboBox1.Text = Nothing Then
            Exit Sub
        End If


    End Sub



    Private Sub btnPull_MouseClick(sender As Object, e As MouseEventArgs) Handles btnPull.MouseClick
        btnPull.FillColor = Color.Red
    End Sub

    Private Sub btnPull_MouseHover(sender As Object, e As EventArgs) Handles btnPull.MouseHover
        lblDataView.Text = "Production"
        btnPull.FillColor = Color.Cyan
    End Sub

    Private Sub btnPull_MouseLeave(sender As Object, e As EventArgs) Handles btnPull.MouseLeave
        lblDataView.ResetText()
        btnPull.FillColor = Color.Transparent
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        frmLists.WindowState = FormWindowState.Normal
        frmLists.Show()
        frmLists.TopMost = True
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmReturn.WindowState = FormWindowState.Normal
        frmReturn.Show()
        frmReturn.TabControl1.SelectedTab = frmReturn.tbcReturn
        frmReturn.TopMost = True
    End Sub

    Private Sub btnItems_MouseClick(sender As Object, e As MouseEventArgs) Handles btnPrint.MouseClick
        btnPrint.FillColor = Color.Red
    End Sub

    Private Sub btnItems_MouseHover(sender As Object, e As EventArgs) Handles btnPrint.MouseHover
        lblDataView.Text = "Print"
        btnPrint.FillColor = Color.Cyan
    End Sub

    Private Sub btnItems_MouseLeave(sender As Object, e As EventArgs) Handles btnPrint.MouseLeave
        lblDataView.ResetText()
        btnPrint.FillColor = Color.Transparent
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSearch_Click(sender, e)

        End If

    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintBarcodeToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub ManageReturnedItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageReturnedItemsToolStripMenuItem.Click
        btnReturn_Click(sender, e)
    End Sub

    Private Sub ListsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListsToolStripMenuItem.Click
        btnSuppliers_Click(sender, e)
    End Sub

    Private Sub PrintBarcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBarcodeToolStripMenuItem.Click
        frmPrint.WindowState = FormWindowState.Normal
        frmPrint.Show()
        frmPrint.TopMost = True

    End Sub

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductToolStripMenuItem.Click
        btnProd_Click(sender, e)
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Application.Restart()

    End Sub

    Private Sub LockToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Enabled = False

        Me.Text = Me.Text & " ?System is Lock"
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        frmRegister.TbAccountsBindingSource.Filter = "(Username LIKE'" & lblName.Text & "')"
        frmRegister.ShowDialog()
    End Sub

    Private Sub DateTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateTimeToolStripMenuItem.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            lblDate.ForeColor = ColorDialog1.Color
            lblTime.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub QuickSettingsPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickSettingsPanelToolStripMenuItem.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Panel1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub DatagridColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatagridColorToolStripMenuItem.Click

        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            TbProductsDataGridView.BackgroundColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

    Private Sub RestoreDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDefaultToolStripMenuItem.Click
        lblDate.ForeColor = Color.Chartreuse
        lblTime.ForeColor = Color.Chartreuse

        Panel1.BackColor = Color.LightCoral

        TbProductsDataGridView.BackgroundColor = SystemColors.ButtonFace

    End Sub

    Private Sub btnPull_Click(sender As Object, e As EventArgs) Handles btnPull.Click

        'Timer2.Enabled = False
        frmPull.TopMost = True
        frmPull.txtCashier.Text = Me.lblName.Text
        frmPull.Show()
        frmPull.WindowState = FormWindowState.Normal


    End Sub

    Private Sub BarcodeEncodeLabel1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ResetLogFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetLogFilesToolStripMenuItem.Click
        'To be repair Tomorrow 30/11/2019
        'Today: 12:28 AM


        Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Deduc"
        Dim log2 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Delivery"
        Dim log3 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\New Product"
        Dim log4 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Returns"
        Dim log5 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Daily Sales"

        Dim x, x2, x3, x4, x5


        'Check if Folders are exist
        x = My.Computer.FileSystem.DirectoryExists(log1)
        x2 = My.Computer.FileSystem.DirectoryExists(log2)
        x3 = My.Computer.FileSystem.DirectoryExists(log3)
        x4 = My.Computer.FileSystem.DirectoryExists(log4)
        x5 = My.Computer.FileSystem.DirectoryExists(log5)


        Try
            If (MessageBox.Show("Are you sure you want To reset? it will delete all the log files data?", "Confirmation Needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                If x And x2 And x3 And x4 And x5 Then


                    My.Computer.FileSystem.DeleteDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Deduc", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log1)


                    My.Computer.FileSystem.DeleteDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Delivery", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log2)

                    My.Computer.FileSystem.DeleteDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\New Product", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log3)

                    My.Computer.FileSystem.DeleteDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Returns", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log4)


                    My.Computer.FileSystem.DeleteDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Daily Sales", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log5)

                Else

                    'no action rekta sa baba to create folders

                End If

                My.Computer.FileSystem.CreateDirectory(log1)
                My.Computer.FileSystem.CreateDirectory(log2)
                My.Computer.FileSystem.CreateDirectory(log3)
                My.Computer.FileSystem.CreateDirectory(log4)
                My.Computer.FileSystem.CreateDirectory(log5)
                MessageBox.Show("Action Successfully Finished.", "Formatting Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                Exit Sub

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unable To Proceed Something Wen't Wrong Please Contact Administrator ", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try


    End Sub

    Private Sub OpenLogFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenLogFilesToolStripMenuItem.Click
        Try
            Process.Start("explorer.exe", Path.Combine("Documents"))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try


    End Sub




    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        frmRegister.TopMost = True
        frmRegister.Show()
        frmRegister.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnApp_Click(sender As Object, e As EventArgs) Handles btnpull2.Click

        btnPull_Click(sender, e)


    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        StocksToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try

            Dim connectionString As String

            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"

            'gawa ng Connection
            con = New OleDbConnection(connectionString)

            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something Wen't Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Finally


        End Try


        Try
            'NOTE::
            'Irurun natin to sa background then madedetect nya ang Low Quantity Products na Less than 3

            Dim query As String = "SELECT * FROM tbProducts WHERE  Quantity ='" & "2" & "' OR Quantity ='" & "1" & "' OR Quantity ='" & "0" & "'"

            Dim cmd As OleDbCommand = New OleDbCommand(query, con)

            'create data reader
            Dim read As OleDbDataReader = cmd.ExecuteReader

            read.Read()

            If read.HasRows = True Then

                frmBgWorker.TopMost = True
                frmBgWorker.Show()
                Timer2.Enabled = False
                frmStocks.TbProductsTableAdapter.Fill(frmStocks.AutosupplyDataSet.tbProducts)

            Else

                con.Close()
                frmBgWorker.Close()


            End If

        Catch

            Timer2.Enabled = False
            MessageBox.Show("Too Many Forms Close the other form to Proceed", "Limit Exceeds", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try


    End Sub

    Private Sub chkNotif_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotif.CheckedChanged
        If chkNotif.Checked Then

            Timer2.Enabled = False

        Else
            frmBgWorker.TbProductsTableAdapter.Fill(frmBgWorker.AutosupplyDataSet.tbProducts)
            Timer2.Enabled = True

        End If

    End Sub

    Public Sub StocksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StocksToolStripMenuItem.Click


        frmStocks.TbProductsTableAdapter.Fill(frmStocks.AutosupplyDataSet.tbProducts)

        frmStocks.TbProductsBindingSource.Filter = "(CONVERT(Quantity,'System.String')LIKE'" & "2" & "') OR(CONVERT(Quantity,'System.String')LIKE'" & "1" & "') OR(CONVERT(Quantity,'System.String')LIKE'" & "0" & "')"
        frmStocks.Label2.Text = frmStocks.TbProductsBindingSource.Count

        frmStocks.ShowDialog()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub





    Private Sub UpdateProductInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateProductInfoToolStripMenuItem.Click
        frmUpdate.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Try
            Process.Start("explorer.exe", Path.Combine("Data\Help.txt"))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub ReStockEtcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReStockEtcToolStripMenuItem.Click
        btnPull_Click(sender, e)
    End Sub

    Private Sub FormatToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ChangeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeNameToolStripMenuItem.Click
        frmName.ShowDialog()
    End Sub

    Private Sub TbProductsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TbProductsDataGridView.CellContentClick

    End Sub

    Private Sub Panel1_MouseHover(sender As Object, e As EventArgs) Handles Panel1.MouseHover
        lblButType.ResetText()
        lblDataView.ResetText()
        btnSearch.FillColor = Color.Transparent
        btnReset.FillColor = Color.Transparent
        btnPrint.FillColor = Color.Transparent
        btnPull.FillColor = Color.Transparent
        btnAdd.FillColor = Color.Transparent
        btnRemove.FillColor = Color.Transparent
        btnRefresh.FillColor = Color.Transparent
        btnPrevious.FillColor = Color.Transparent
        btnNext.FillColor = Color.Transparent
    End Sub

    Private Sub lblButType_MouseHover(sender As Object, e As EventArgs) Handles lblButType.MouseHover
        lblButType.ResetText()
        lblDataView.ResetText()
        btnSearch.FillColor = Color.Transparent
        btnReset.FillColor = Color.Transparent
        btnPrint.FillColor = Color.Transparent
        btnPull.FillColor = Color.Transparent
        btnAdd.FillColor = Color.Transparent
        btnRemove.FillColor = Color.Transparent
        btnRefresh.FillColor = Color.Transparent
        btnPrevious.FillColor = Color.Transparent
        btnNext.FillColor = Color.Transparent
    End Sub

    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles Panel4.MouseHover
        lblButType.ResetText()
        lblDataView.ResetText()
        btnProd.FillColor = Color.Transparent
        btnSuppliers.FillColor = Color.Transparent
        btnReturn.FillColor = Color.Transparent
        btnReg.FillColor = Color.Transparent
        btnSettings.FillColor = Color.Transparent
        btnpull2.FillColor = Color.Transparent

        btnSearch.FillColor = Color.Transparent
        btnReset.FillColor = Color.Transparent
        btnPrint.FillColor = Color.Transparent
        btnPull.FillColor = Color.Transparent
        btnAdd.FillColor = Color.Transparent
        btnRemove.FillColor = Color.Transparent
        btnRefresh.FillColor = Color.Transparent
        btnPrevious.FillColor = Color.Transparent
        btnNext.FillColor = Color.Transparent
    End Sub

    Private Sub ResetReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetReportsToolStripMenuItem.Click

        Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\Daily Inventory"
        Dim log2 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\Daily Stocks"
        Dim log3 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\Daily Purchase"
        Dim log4 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\General Inventory"
        Dim log5 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\Daily Purchase"
        Dim log6 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\General Purchase"
        Dim x, x2, x3, x4, x5, x6


        'Check if Folders are exist
        x = My.Computer.FileSystem.DirectoryExists(log1)
        x2 = My.Computer.FileSystem.DirectoryExists(log2)
        x3 = My.Computer.FileSystem.DirectoryExists(log3)
        x4 = My.Computer.FileSystem.DirectoryExists(log4)
        x5 = My.Computer.FileSystem.DirectoryExists(log5)
        x6 = My.Computer.FileSystem.DirectoryExists(log6)

        Try
            If (MessageBox.Show("Are you sure you want To reset? it will delete all the log files data?", "Confirmation Needed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                If x And x2 And x3 And x4 And x5 And x6 Then


                    My.Computer.FileSystem.DeleteDirectory(log1, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log1)

                    My.Computer.FileSystem.DeleteDirectory(log2, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log2)

                    My.Computer.FileSystem.DeleteDirectory(log3, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log3)

                    My.Computer.FileSystem.DeleteDirectory(log4, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log4)

                    My.Computer.FileSystem.DeleteDirectory(log5, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log5)

                    My.Computer.FileSystem.DeleteDirectory(log6, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log6)

                Else
                    'no action rekta sa baba

                End If

                My.Computer.FileSystem.CreateDirectory(log1)
                My.Computer.FileSystem.CreateDirectory(log2)
                My.Computer.FileSystem.CreateDirectory(log3)
                My.Computer.FileSystem.CreateDirectory(log4)
                My.Computer.FileSystem.CreateDirectory(log5)
                My.Computer.FileSystem.CreateDirectory(log6)

                MessageBox.Show("Action Successfully Finished.", "Formatting Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                Exit Sub

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unable To Proceed Something Wen't Wrong Please Contact Administrator ", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click
        frmPOS.ShowDialog()
        frmPOS.txtBarcode.Focus()

    End Sub

    Private Sub TransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionHistoryToolStripMenuItem.Click
        frmTransHistory.ShowDialog()

    End Sub

    Private Sub tmDeleter_Tick(sender As Object, e As EventArgs) Handles tmDeleter.Tick

        tmDeleter.Enabled = False

        Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Deduc"
        Dim log2 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Delivery"
        Dim log3 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\New Product"
        Dim log4 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Returns"
        Dim log5 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Daily Sales"

        Dim x, x2, x3, x4, x5


        'Check if Folders are exist
        x = My.Computer.FileSystem.DirectoryExists(log1)
        x2 = My.Computer.FileSystem.DirectoryExists(log2)
        x3 = My.Computer.FileSystem.DirectoryExists(log3)
        x4 = My.Computer.FileSystem.DirectoryExists(log4)
        x5 = My.Computer.FileSystem.DirectoryExists(log5)


        Try
            If (MessageBox.Show("Log Files need to refresh Every 8 hrs do you want to proceed?", "Log File Deleter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                If x And x2 And x3 And x4 And x5 Then


                    My.Computer.FileSystem.DeleteDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Deduc", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log1)


                    My.Computer.FileSystem.DeleteDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Delivery", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log2)

                    My.Computer.FileSystem.DeleteDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\New Product", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log3)

                    My.Computer.FileSystem.DeleteDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Returns", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log4)


                    My.Computer.FileSystem.DeleteDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Daily Sales", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(log5)

                Else

                    'no action rekta sa baba to create folders

                End If

                My.Computer.FileSystem.CreateDirectory(log1)
                My.Computer.FileSystem.CreateDirectory(log2)
                My.Computer.FileSystem.CreateDirectory(log3)
                My.Computer.FileSystem.CreateDirectory(log4)
                My.Computer.FileSystem.CreateDirectory(log5)

                MessageBox.Show("Log Files Refreshed", "Done")
                tmDeleter.Interval = 28800000
                tmDeleter.Enabled = True

            Else
                tmDeleter.Interval = 1800000
                MessageBox.Show("Ok i'll do it later after 30 mins", "Re-Scheduled")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unable To Proceed Something Wen't Wrong Please Contact Administrator ", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try


    End Sub
End Class
