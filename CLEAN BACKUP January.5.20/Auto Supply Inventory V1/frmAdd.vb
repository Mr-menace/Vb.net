Imports ZXing.Common
Imports ZXing
Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Imports WMPLib
Imports System.IO


Public Class frmAdd
    Dim ans = Date.Today.ToLongDateString
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
    End Sub

    Dim na As New WindowsMediaPlayer
    Private Const WTM As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub SetCueText(ByVal control As Control, ByVal text As String)
        SendMessage(control.Handle, WTM, 0, text)

    End Sub


    Private Sub TbProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbQuality' table. You can move, or remove it, as needed.
        Me.TbQualityTableAdapter.Fill(Me.AutosupplyDataSet.tbQuality)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbSupplier' table. You can move, or remove it, as needed.
        Me.TbSupplierTableAdapter.Fill(Me.AutosupplyDataSet.tbSupplier)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbBrand' table. You can move, or remove it, as needed.
        Me.TbBrandTableAdapter.Fill(Me.AutosupplyDataSet.tbBrand)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbSupplier' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbQuality' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbProducts' table. You can move, or remove it, as needed.
        Me.TbProductsTableAdapter.Fill(Me.AutosupplyDataSet.tbProducts)

        CheckBox1.CheckState = CheckState.Checked


        cboBrand.SelectedItem = Nothing
        cboQuality.SelectedItem = Nothing
        cboSupplier.SelectedItem = Nothing


        SetCueText(ProductIDTextBox, "Input Product ID")
        SetCueText(ProductNameTextBox, "Product Name")

        SetCueText(PartNoTextBox, "Product Part Number")

        SetCueText(QuantityTextBox, "How many pcs? ")

        SetCueText(BarcodeEncodeTextBox, "Click here and scan")

    End Sub

    Private Sub BarcodeEncodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles BarcodeEncodeTextBox.TextChanged

        Dim bcode As New BarcodeWriter
        bcode.Format = BarcodeFormat.CODE_128


        If BarcodeEncodeTextBox.Text = Nothing Then
            BarcodeimgPictureBox.Image = Nothing
            Exit Sub

        Else
            BarcodeimgPictureBox.Image = bcode.Write(BarcodeEncodeTextBox.Text)
        End If



    End Sub

    Private Sub dtpTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpTime.ValueChanged
        'BarcodeEncodeTextBox.Text = dtpTime.Value.ToLongTimeString

    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged

    End Sub

    Private Sub BarcodeimgLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim na, na1
        na = AutosupplyDataSet.tbProducts.Count + 1
        na1 = TimeOfDay.Hour & TimeOfDay.Minute.ToString & TimeOfDay.Second.ToString

        If CheckBox1.Checked Then
            ProductIDTextBox.ReadOnly = True
            ProductIDTextBox.Text = na & na1

        Else
            ProductIDTextBox.ReadOnly = False
            ProductIDTextBox.ResetText()
        End If
    End Sub


    Private Sub cboSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupplier.SelectedIndexChanged

    End Sub



    Private Sub ProductIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductIDTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 46 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BarcodeEncodeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BarcodeEncodeTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 46 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub QuantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 46 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        BarcodeEncodeTextBox.ResetText()
        PartNoTextBox.ResetText()
        'auto generate ID
        If CheckBox1.Checked Then


        Else
            CheckBox1.CheckState = CheckState.Unchecked
            ProductIDTextBox.ResetText()
        End If

        'product name remember
        If CheckBox2.Checked Then


        Else
            CheckBox2.CheckState = CheckState.Unchecked
            ProductNameTextBox.ResetText()
        End If

        'quantity remember
        If CheckBox3.Checked Then


        Else
            CheckBox3.CheckState = CheckState.Unchecked

            QuantityTextBox.ResetText()
        End If


        If Form1.chkNotif.Checked Then
            Form1.Timer2.Enabled = False

        Else
            Form1.Timer2.Enabled = True

        End If





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim d = Date.Today.ToLongDateString
        Dim con As New OleDbConnection

        Dim connectionString As String

        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"

        'gawa ng Connection
        Try
            con = New OleDbConnection(connectionString)

            con.Open()

            Dim cmd1 As New OleDbCommand("select count(*) from tbProducts where BarcodeEncode=?", con)
            cmd1.Parameters.Add("@BarcodeEncode", OleDbType.VarChar).Value = BarcodeEncodeTextBox.Text
            Dim count = Convert.ToInt32(cmd1.ExecuteScalar)


            If count = 0 Then
                lblExist.Visible = False


            ElseIf count > 0
                na.URL = Path.Combine("SoundPacks\ScanError.mp3")
                lblExist.Visible = True

            End If
            con.Close()
        Catch ex As Exception
            Exit Sub
        End Try

        Dim bcode As New BarcodeWriter
        bcode.Format = BarcodeFormat.CODE_128



        If BarcodeEncodeTextBox.Text = Nothing Then
            BarcodeimgPictureBox.Image = Nothing
            Exit Sub

        Else
            BarcodeimgPictureBox.Image = bcode.Write(BarcodeEncodeTextBox.Text)
        End If



        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String


        If BarcodeEncodeTextBox.TextLength = 0 Then

            Exit Sub

        End If

        If lblExist.Visible = True Then

            MessageBox.Show("The System Detected That The Barcode You Are Using is Already Exist on the Database Please Click Add Existing If You Wish To Add it to Existing Product or Change The Barcode Info To Proceed.", "Unable to Process ")

            Exit Sub

            Else

                Try

                    If ProductIDTextBox.Text = Nothing Or ProductNameTextBox.Text = Nothing Or cboBrand.Text = Nothing Or
                       PartNoTextBox.Text = Nothing Or cboQuality.Text = Nothing Or QuantityTextBox.Text = Nothing Or
                       cboSupplier.Text = Nothing Or BarcodeEncodeTextBox.Text = Nothing Then

                        MessageBox.Show("You Forgot Something to Fill or You're Re-Stocking a Product But the Barcode Not Found Please Check it Carefully.", "Completing Fields Required ", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                    Else
                    File.AppendAllText("Documents\Logs\New Product\New Product, " & d & ".rtf", "======================PRODUCT DELIVERY======================" & vbNewLine)
                    File.AppendAllText("Documents\Logs\New Product\New Product, " & d & ".rtf", "Date: " & Date.Today.ToLongDateString & " " & TimeOfDay.ToLongTimeString & vbNewLine)
                    File.AppendAllText("Documents\Logs\New Product\New Product, " & d & ".rtf", "Barcode#: " & BarcodeEncodeTextBox.Text & vbNewLine)
                    File.AppendAllText("Documents\Logs\New Product\New Product, " & d & ".rtf", "Product Name: " & ProductNameTextBox.Text & vbNewLine)
                    File.AppendAllText("Documents\Logs\New Product\New Product, " & d & ".rtf", "Total Quantity: " & QuantityTextBox.Text & vbNewLine)
                    File.AppendAllText("Documents\Logs\New Product\New Product, " & d & ".rtf", "Supplier: " & cboSupplier.Text & vbNewLine)
                    File.AppendAllText("Documents\Logs\New Product\New Product, " & d & ".rtf", "original Price: " & (NumOrigPrice.Value).ToString("n") & vbNewLine)
                    File.AppendAllText("Documents\Logs\New Product\New Product, " & d & ".rtf", "By: " & Form1.lblName.Text & vbNewLine & vbNewLine)



                    na.URL = Path.Combine("SoundPacks\Scan.mp3")

                        connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"
                        sqlconn.ConnectionString = connString
                        sqlquery.Connection = sqlconn

                        sqlconn.Open()

                    sqlquery.CommandText = "INSERT INTO tbProducts ([ProductID], [ProductName], [Brand], PartNo, Quality, Quantity, Supplier, [DeliveryDate], [DeliveryTime], [BarcodeEncode], EncodedBy, [OrigPrice])
                           VALUES([@ProductID], [@ProductName], [@Brand], [@PartNo], [@Quality], [@Quantity], [@Supplier],[DeliveryDate], [@DeliveryTime], [@BarcodeEncode], [@EncodedBy], [@OrigPrice])"

                    sqlquery.Parameters.AddWithValue("[@ProductID]", ProductIDTextBox.Text)
                    sqlquery.Parameters.AddWithValue("[@ProductName]", ProductNameTextBox.Text)
                    sqlquery.Parameters.AddWithValue("[@Brand]", cboBrand.Text)
                    sqlquery.Parameters.AddWithValue("[@PartNo]", PartNoTextBox.Text)
                    sqlquery.Parameters.AddWithValue("[@Quantity]", cboQuality.Text)
                    sqlquery.Parameters.AddWithValue("[@Quality]", QuantityTextBox.Text)
                    sqlquery.Parameters.AddWithValue("[@Supplier]", cboSupplier.Text)
                    sqlquery.Parameters.AddWithValue("[@DeliveryDate]", dtpDate.Text)
                    sqlquery.Parameters.AddWithValue("[@DeliveryTime]", dtpTime.Text)
                    sqlquery.Parameters.AddWithValue("[@BarcodeEncode]", BarcodeEncodeTextBox.Text)
                    sqlquery.Parameters.AddWithValue("[@EncodedBy]", Form1.lblName.Text)
                    sqlquery.Parameters.AddWithValue("[@OrigPrice]", NumOrigPrice.Value)
                    sqlquery.ExecuteNonQuery()
                    sqlconn.Close()

                    'frmaddMsgbox.ShowDialog() 'for future purpose

                    Form1.TbProductsTableAdapter.Fill(Form1.AutosupplyDataSet.tbProducts)
                    TbProductsTableAdapter.Fill(AutosupplyDataSet.tbProducts)
                    BarcodeEncodeTextBox.ResetText()
                        PartNoTextBox.ResetText()

                    Form1.lblRec.Text = Form1.AutosupplyDataSet.tbProducts.Count.ToString

                        If CheckBox1.Checked Then

                            CheckBox1_CheckedChanged(sender, e)

                        Else
                            Exit Sub
                        End If
                        If CheckBox2.Checked Then
                            Exit Sub

                        Else
                            ProductNameTextBox.ResetText()
                        End If

                        If CheckBox3.Checked Then
                            Exit Sub

                        Else
                            QuantityTextBox.ResetText()
                        End If

                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Product Adding Status: Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End Try
            End If



    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then

            lblExist.Visible = False

            CheckBox1.CheckState = CheckState.Unchecked
            CheckBox2.CheckState = CheckState.Unchecked
            CheckBox3.CheckState = CheckState.Unchecked


            ProductIDTextBox.Enabled = False
            ProductNameTextBox.Enabled = False
            ProductNameTextBox.ResetText()

            cboBrand.Enabled = False
            cboBrand.SelectedItem = Nothing

            PartNoTextBox.Enabled = False
            PartNoTextBox.ResetText()

            cboQuality.Enabled = False
            cboQuality.SelectedItem = Nothing

            cboSupplier.Enabled = False
            cboSupplier.SelectedItem = Nothing

            Button2.Enabled = False
            Button2.BackColor = Color.LightGray


        Else

            ProductIDTextBox.Enabled = True
            ProductNameTextBox.Enabled = True
            cboBrand.Enabled = True
            PartNoTextBox.Enabled = True
            cboQuality.Enabled = True
            cboSupplier.Enabled = True
            Button2.Enabled = True
            Button2.BackColor = Color.Transparent

        End If


    End Sub

    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged
        If QuantityTextBox.TextLength > 0 Then
            BarcodeEncodeTextBox.Enabled = True

        Else
            BarcodeEncodeTextBox.Enabled = False
        End If
    End Sub

    Private Sub QuantityTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles QuantityTextBox.KeyDown
        If e.KeyCode = Keys.B Then

            Me.BarcodeEncodeTextBox.Focus()


        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If


    End Sub

    Private Sub BarcodeEncodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeEncodeTextBox.KeyDown

        If e.KeyCode = Keys.Delete Then
            BarcodeEncodeTextBox.ResetText()
        End If

        If e.KeyCode = Keys.Enter And CheckBox4.Checked = False Then

            Button2_Click(sender, e)

        End If




        '====== checking of barcode if exist========

        Dim con As New OleDbConnection

        Dim connectionString As String

        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"

        'gawa ng Connection
        Try
            con = New OleDbConnection(connectionString)

            con.Open()

            Dim cmd1 As New OleDbCommand("select count(*) from tbProducts where BarcodeEncode=?", con)
            cmd1.Parameters.Add("@BarcodeEncode", OleDbType.VarChar).Value = BarcodeEncodeTextBox.Text
            Dim count = Convert.ToInt32(cmd1.ExecuteScalar)



            If e.KeyCode = Keys.Enter And CheckBox4.Checked = True Then 'Pag naka check ang For Existing Checkbox 

                If count = 0 And CheckBox4.Checked = False Then
                    Button2_Click(sender, e)
                    lblExist.Visible = False

                ElseIf count > 0 And CheckBox4.Checked = True
                    na.URL = Path.Combine("SoundPacks\Scan.mp3")
                    frmExistProd.TbProductsBindingSource.Filter = "(CONVERT(BarcodeEncode, 'System.String')LIKE'" & BarcodeEncodeTextBox.Text & "')"
                    frmExistProd.Show()
                    BarcodeEncodeTextBox.ResetText()
                    QuantityTextBox.ResetText()

                    If Form1.chkNotif.Checked Then
                        Form1.Timer2.Enabled = False

                    Else
                        Form1.Timer2.Enabled = True

                    End If

                ElseIf count = 0 And CheckBox4.Checked = True Then
                    MessageBox.Show("Barcode Not Exist", "Please Re Check Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    BarcodeEncodeTextBox.ResetText()
                Else
                    If count > 0 Then
                        na.URL = Path.Combine("SoundPacks\ScanError.mp3")
                        lblExist.Visible = True
                        lblExist.Text = "Barcode Already Exist!"
                        MessageBox.Show("The System Detected That The Barcode Used Are Already Exist in the Database Please Check the For Existing Product Above If You Wish To Add it to Existing Product or Change The Barcode Info To Proceed.", "Unable to Process ")
                        BarcodeEncodeTextBox.ResetText()
                    End If

                End If

                con.Close()

            End If


        Catch
            Exit Sub
        End Try


        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If




    End Sub

    Private Sub ProductIDTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductIDTextBox.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ProductNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductNameTextBox.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub PartNoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PartNoTextBox.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


End Class