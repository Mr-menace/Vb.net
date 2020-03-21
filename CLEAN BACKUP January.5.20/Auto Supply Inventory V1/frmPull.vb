Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Imports System.IO
Imports WMPLib


Public Class frmPull

    Dim na As New WindowsMediaPlayer

    Dim ans = Date.Today.ToLongDateString

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

    Private Sub frmPull_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbProducts' table. You can move, or remove it, as needed.
        Me.TbProductsTableAdapter.Fill(Me.AutosupplyDataSet.tbProducts)
        SetCueText(BarcodeEncodeTextBox, "Click here and scan...")

        lbltips.Text = "Tips:" & vbNewLine & "Click C to clear the textbox for Barcodes" & vbNewLine & "Click R to Toggle Re-Stock Button or D for Deduct Button."

        lblPrice.ResetText()
    End Sub

    Private Sub BarcodeEncodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles BarcodeEncodeTextBox.TextChanged




        Me.TbProductsBindingSource.Filter = "(CONVERT(BarcodeEncode,'System.String')LIKE'" & Me.BarcodeEncodeTextBox.Text & "')"





    End Sub

    Private Sub BarcodeEncodeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BarcodeEncodeTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 46 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub BarcodeEncodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeEncodeTextBox.KeyDown
        Dim d = Date.Today.ToLongDateString
        If e.KeyCode = Keys.Delete Then

            Me.BarcodeEncodeTextBox.Clear()

        End If

        If e.KeyCode = Keys.D Then

            RadioButton2.Checked = True

        ElseIf e.KeyCode = Keys.R

            RadioButton1.Checked = True

        End If


        'PROCESS


        If e.KeyCode = Keys.Enter Then


            Me.TbProductsBindingSource.Filter = "(CONVERT(BarcodeEncode,'System.String')LIKE'" & Me.BarcodeEncodeTextBox.Text & "')"

            Try
                If Me.TbProductsBindingSource.Count = 0 Then

                    lblnoFound.Text = "*Product Not Found*" & vbNewLine & " ID: " & BarcodeEncodeTextBox.Text
                    na.URL = Path.Combine("SoundPacks\ScanError.mp3")
                    lblnoFound.Visible = True
                    BarcodeEncodeTextBox.ResetText()
                    Exit Sub

                Else
                    lblnoFound.Visible = False

                    'Pag mag Re-stock
                    If RadioButton1.Checked Then
                        DeliveryDateLabel2.Text = Date.Today.ToLongDateString
                        DeliveryTimeLabel2.Text = TimeOfDay.ToLongTimeString

                        na.URL = Path.Combine("SoundPacks\Scan.mp3")

                        'Creates Text sa rtbStat natin

                        rtbStat.AppendText("Barcode#: " & BarcodeEncodeTextBox.Text & vbNewLine)
                        rtbStat.AppendText("Product Name: " & ProductNameLabel2.Text & vbNewLine)
                        rtbStat.AppendText("Original Price: " & Val(lblPrice.Text).ToString("n") & vbNewLine)
                        rtbStat.AppendText("Total Quantity: " & QuantityLabel1.Text & vbNewLine)
                        rtbStat.AppendText("Added Quantity: " & NumericUpDown1.Value & vbNewLine)
                        rtbStat.AppendText("New Quantity: " & Val(QuantityLabel1.Text) + Val(NumericUpDown1.Value) & vbNewLine)
                        rtbStat.AppendText("Amount in Price: " & Val(lblPrice.Text) * NumericUpDown1.Value & vbNewLine)
                        rtbStat.AppendText("Date: " & Date.Today.ToLongDateString & " " & TimeOfDay.ToLongTimeString & vbNewLine)
                        rtbStat.AppendText("By: " & txtCashier.Text & vbNewLine & vbNewLine)

                        rtbStat.ScrollToCaret()


                        QuantityLabel1.Text = Val(QuantityLabel1.Text) + Val(NumericUpDown1.Value)

                        'Write on the file
                        File.AppendAllText("Documents\Logs\Delivery\DeliveryLogs, " & d & ".rtf", "======================Re-Amounted==================" & vbNewLine)
                        File.AppendAllText("Documents\Logs\Delivery\DeliveryLogs, " & d & ".rtf", "Date: " & Date.Today.ToLongDateString & " " & TimeOfDay.ToLongTimeString & vbNewLine)
                        File.AppendAllText("Documents\Logs\Delivery\DeliveryLogs, " & d & ".rtf", "Barcode#: " & BarcodeEncodeTextBox.Text & vbNewLine)
                        File.AppendAllText("Documents\Logs\Delivery\DeliveryLogs, " & d & ".rtf", "Product Name: " & ProductNameLabel2.Text & vbNewLine)
                        File.AppendAllText("Documents\Logs\Delivery\DeliveryLogs, " & d & ".rtf", "Original Price: " & Val(lblPrice.Text).ToString("n") & vbNewLine)
                        File.AppendAllText("Documents\Logs\Delivery\DeliveryLogs, " & d & ".rtf", "Total Quantity: " & QuantityLabel1.Text & vbNewLine)
                        File.AppendAllText("Documents\Logs\Delivery\DeliveryLogs, " & d & ".rtf", "Added Quantity: " & NumericUpDown1.Value & vbNewLine)
                        File.AppendAllText("Documents\Logs\Delivery\DeliveryLogs, " & d & ".rtf", "New Quantity: " & Val(QuantityLabel1.Text) + Val(NumericUpDown1.Value) & vbNewLine)
                        File.AppendAllText("Documents\Logs\Delivery\DeliveryLogs, " & d & ".rtf", "Amount in Price: " & Val(lblPrice.Text) * NumericUpDown1.Value & vbNewLine)
                        File.AppendAllText("Documents\Logs\Delivery\DeliveryLogs, " & d & ".rtf", "By: " & txtCashier.Text & vbNewLine & vbNewLine)

                        TbProductsBindingSource.EndEdit()
                        TbProductsTableAdapter.Update(AutosupplyDataSet.tbProducts)
                        BarcodeEncodeTextBox.ResetText()
                        Form1.TbProductsTableAdapter.Fill(Form1.AutosupplyDataSet.tbProducts)

                        If Form1.chkNotif.Checked Then
                            Form1.Timer2.Enabled = False

                        Else
                            Form1.Timer2.Enabled = True

                        End If

                        'pag babawasan
                    ElseIf RadioButton2.Checked Then

                        If QuantityLabel1.Text < NumericUpDown1.Value Then

                            na.URL = Path.Combine("SoundPacks\notify.wav")
                            MessageBox.Show("Unable to Deduct Such Amount It's Greater Than the Product Quantity You're About to Deduct: " & NumericUpDown1.Value & " And The Stocks Left Are: " & QuantityLabel1.Text, "Out Of Stock")
                            BarcodeEncodeTextBox.ResetText()
                        Else

                            na.URL = Path.Combine("SoundPacks\Scan.mp3")

                            'Creates Text sa rtbStat natin
                            rtbStat.AppendText("Barcode#: " & BarcodeEncodeTextBox.Text & vbNewLine)
                            rtbStat.AppendText("Product Name: " & ProductNameLabel2.Text & vbNewLine)
                            rtbStat.AppendText("Original Price: " & Val(lblPrice.Text).ToString("n") & vbNewLine)
                            rtbStat.AppendText("Total Quantity: " & QuantityLabel1.Text & vbNewLine)
                            rtbStat.AppendText("Deduct Quantity: " & NumericUpDown1.Value & vbNewLine)
                            rtbStat.AppendText("New Quantity: " & Val(QuantityLabel1.Text) - Val(NumericUpDown1.Value) & vbNewLine)
                            rtbStat.AppendText("Amount in Price: " & Val(lblPrice.Text) * NumericUpDown1.Value & vbNewLine)
                            rtbStat.AppendText("Date: " & Date.Today.ToLongDateString & " " & TimeOfDay.ToLongTimeString & vbNewLine)
                            rtbStat.AppendText("By: " & txtCashier.Text & vbNewLine & vbNewLine)

                            rtbStat.ScrollToCaret()



                            'Write on the file
                            File.AppendAllText("Documents\Logs\Deduc\DeducLogs, " & d & ".rtf", "===================Deducted==================" & vbNewLine)
                            File.AppendAllText("Documents\Logs\Deduc\DeducLogs, " & d & ".rtf", "Date: " & Date.Today.ToLongDateString & " " & TimeOfDay.ToLongTimeString & vbNewLine)
                            File.AppendAllText("Documents\Logs\Deduc\DeducLogs, " & d & ".rtf", "Barcode#: " & BarcodeEncodeTextBox.Text & vbNewLine)
                            File.AppendAllText("Documents\Logs\Deduc\DeducLogs, " & d & ".rtf", "Product Name: " & ProductNameLabel2.Text & vbNewLine)
                            File.AppendAllText("Documents\Logs\Deduc\DeducLogs, " & d & ".rtf", "Original Price: " & Val(lblPrice.Text).ToString("n") & vbNewLine)
                            File.AppendAllText("Documents\Logs\Deduc\DeducLogs, " & d & ".rtf", "Total Quantity: " & QuantityLabel1.Text & vbNewLine)
                            File.AppendAllText("Documents\Logs\Deduc\DeducLogs, " & d & ".rtf", "Deduct Quantity: " & NumericUpDown1.Value & vbNewLine)
                            File.AppendAllText("Documents\Logs\Deduc\DeducLogs, " & d & ".rtf", "New Quantity: " & Val(QuantityLabel1.Text) - Val(NumericUpDown1.Value) & vbNewLine)
                            File.AppendAllText("Documents\Logs\Deduc\DeducLogs, " & d & ".rtf", "Amount in Price: " & Val(lblPrice.Text) * NumericUpDown1.Value & vbNewLine)
                            File.AppendAllText("Documents\Logs\Deduc\DeducLogs, " & d & ".rtf", "By: " & txtCashier.Text & vbNewLine & vbNewLine)

                            QuantityLabel1.Text = Val(QuantityLabel1.Text) - Val(NumericUpDown1.Value)

                            TbProductsBindingSource.EndEdit()
                            TbProductsTableAdapter.Update(AutosupplyDataSet.tbProducts)
                            BarcodeEncodeTextBox.ResetText()
                            Form1.TbProductsTableAdapter.Fill(Form1.AutosupplyDataSet.tbProducts)

                            If Form1.chkNotif.Checked Then
                                Form1.Timer2.Enabled = False

                            Else
                                Form1.Timer2.Enabled = True

                            End If

                        End If

                    End If

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message, "Error Occured Please Contact Developer For Assistance", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            End Try


        End If


        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub NumericUpDown1_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown1.KeyDown
        If e.KeyCode = Keys.C Then

            Me.BarcodeEncodeTextBox.Clear()


        End If

        If e.KeyCode = Keys.D Then

            RadioButton2.Checked = True

        ElseIf e.KeyCode = Keys.R

            RadioButton1.Checked = True

        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub Panel1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Panel1.PreviewKeyDown
        If e.KeyCode = Keys.C Then

            Me.BarcodeEncodeTextBox.Clear()


        End If
    End Sub

    Private Sub frmPull_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Form1.chkNotif.Checked Then
            Form1.Timer2.Enabled = False

        Else
            Form1.Timer2.Enabled = True

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCashier.TextChanged
        If txtCashier.TextLength = 0 Then
            '  Timer1.Enabled = False
            BarcodeEncodeTextBox.ReadOnly = True
            lblnoFound.Visible = True
            lblnoFound.Text = "Please input Cashier's name first."
        Else
            'Timer1.Enabled = False
            BarcodeEncodeTextBox.ReadOnly = False
            lblnoFound.Visible = False
            lblnoFound.ResetText()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub frmPull_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub
End Class