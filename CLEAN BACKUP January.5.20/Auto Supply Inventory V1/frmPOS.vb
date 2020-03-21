Imports System.IO
Imports System.Data.OleDb

Public Class frmPOS

    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
    End Sub
    Private Sub frmparent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbPOS' table. You can move, or remove it, as needed.
        Me.TbPOSTableAdapter.Fill(Me.AutosupplyDataSet.tbPOS)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbPOS' table. You can move, or remove it, as needed.
        Me.TbPOSTableAdapter.Fill(Me.AutosupplyDataSet.tbPOS)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbPOS' table. You can move, or remove it, as needed.
        Me.TbPOSTableAdapter.Fill(Me.AutosupplyDataSet.tbPOS)
        txtBarcode.Focus()

    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown


        'under coding parin 
        If e.KeyCode = Keys.Enter And chkReScan.Checked = True Then
            frmPOScall.Show()

            If Val(lblTotal.Text) < 1 Then
                'no action
            Else
                frmRescan.TopMost = True
                frmRescan.RichTextBox1.Text = Me.RichTextBox1.Text
                frmRescan.Show()
            End If

            e.SuppressKeyPress = True

        End If

        If e.KeyCode = Keys.Enter And chkReScan.Checked = False Then
            frmPOScall.Show()
            e.SuppressKeyPress = True

        End If


        If e.KeyCode = Keys.Q Then
            NumQuantity.Focus()
        End If

        If e.KeyCode = Keys.C Then
            txtCash.Focus()

        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Today.ToLongDateString
        lblTime.Text = TimeOfDay.ToLongTimeString

    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged

        Dim i, i2, i3, i4 As Integer

        Try

            i = Val(txtCash.Text)
            i2 = lblTotal.Text
            i3 = i2 - i

            i4 = i - i2
            If Val(txtCash.Text) = Nothing Or Val(lblTotal.Text) = 0 Then
                lblChange.Font = New Font("Microsoft Sans Serif", 20)
                lblChange.Text = "0.00"
            Else
                lblChange.Text = (i - i2).ToString("n")
            End If

            If Val(lblChange.Text) < 0 Then
                lblChange.Font = New Font("Microsoft Sans Serif", 12)
                lblChange.ForeColor = Color.Red
                lblChange.Text = "You Still Need: " & (i2 - i).ToString("n")

            Else
                lblChange.ForeColor = Color.Black
                lblChange.Font = New Font("Microsoft Sans Serif", 20)

            End If
        Catch o As OverflowException
            MessageBox.Show(o.Message, "Value Overflow Abnormal Change Detected", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something Wen't Wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End Try




    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        Try
            If txtCash.Text = Nothing Then
                Exit Sub
            End If

            Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Daily Sales\Sales"
            Dim s = Val(txtCash.Text)
            Dim s1 = Val(lblTotal.Text)
            If lblTotal.Text = "0.00" Then
                'exit sub
                Exit Sub
            Else
                If s > s1 Or s = s1 Then

                    If (MessageBox.Show("Are you sure you want to end this transaction?", "Checking Out?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then


                        RichTextBox1.AppendText("===========END OF REPORT===========" & vbNewLine)

                        RichTextBox1.AppendText("Total Amount Paid: " & lblTotal.Text & vbNewLine)

                        RichTextBox1.AppendText("Cash: " & txtCash.Text & vbNewLine)

                        RichTextBox1.AppendText("Change: " & lblChange.Text & vbNewLine)

                        Dim sqlconn As New OleDbConnection
                        Dim sqlquery As New OleDb.OleDbCommand
                        Dim connString As String
                        Dim na, na1

                        na = AutosupplyDataSet.tbReturned.Count + 1
                        na1 = TimeOfDay.Hour & TimeOfDay.Minute.ToString & TimeOfDay.Second.ToString
                        Dim d = Date.Today.ToLongDateString

                        connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"
                        sqlconn.ConnectionString = connString
                        sqlquery.Connection = sqlconn

                        sqlconn.Open()

                        sqlquery.CommandText = "INSERT INTO tbPOS ([Token], [TransactionDate], [TransactionTime], [Breakdowns], [Signed])
                           VALUES([@Token], [@TransactionDate], [@TransactionTime], [@Breakdowns], [@Signed])"

                        sqlquery.Parameters.AddWithValue("[@Token]", txtToken.Text)
                        sqlquery.Parameters.AddWithValue("[@TransactionDate]", Date.Today.ToLongDateString)
                        sqlquery.Parameters.AddWithValue("[@TransactionTime]", TimeOfDay.ToLongTimeString)
                        sqlquery.Parameters.AddWithValue("[@Breakdowns]", RichTextBox1.Text)
                        sqlquery.Parameters.AddWithValue("[@Signed]", Form1.lblName.Text)

                        sqlquery.ExecuteNonQuery()
                        sqlconn.Close()

                        File.AppendAllText(log1 & " " & txtToken.Text & ".rtf", "===========END OF REPORT===========" & vbNewLine)

                        File.AppendAllText(log1 & " " & txtToken.Text & ".rtf", "Total Amount Paid: " & lblTotal.Text & vbNewLine)

                        File.AppendAllText(log1 & " " & txtToken.Text & ".rtf", "Cash: " & txtCash.Text & vbNewLine)

                        File.AppendAllText(log1 & " " & txtToken.Text & ".rtf", "Change: " & lblChange.Text & vbNewLine)

                        File.AppendAllText(log1 & " " & txtToken.Text & ".rtf", "Public Token: " & lblToken.Text & vbNewLine)

                        File.AppendAllText(log1 & " " & txtToken.Text & ".rtf", "This receipt is valid for 7 days for replacement of an item " & vbNewLine)


                        frmPOScall.TbProductsBindingSource.EndEdit()
                        frmPOScall.TbProductsTableAdapter.Update(frmPOScall.AutosupplyDataSet.tbProducts)
                        Form1.TbProductsTableAdapter.Fill(Form1.AutosupplyDataSet.tbProducts)
                        RichTextBox1.ResetText()
                        txtBarcode.ResetText()
                        txtCash.ResetText()
                        lblAmt.ResetText()
                        lblItem.ResetText()
                        lblOrigPrice.ResetText()
                        lblChange.Text = "0.00"
                        lblTotal.Text = "0.00"
                        txtToken.ResetText()
                        lblToken.ResetText()

                        MessageBox.Show("Transaction Sucessfully Ended and Transaction Logs Generated that can be use to retrieve transaction details that lasts for 8 hrs navigate to Local>Log Files>Open Folder>Logs>Daily Sales",
                                    "Next Customer Please...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtBarcode.Focus()
                    End If

                Else

                    MessageBox.Show("Sorry Inappropriate Cash Detected" & vbNewLine & lblChange.Text, "Please Insert Enough Cash", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try


    End Sub



    Private Sub frmPOS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        lblAmt.ResetText()
        lblItem.ResetText()
        lblOrigPrice.ResetText()
        lblTotal.Text = "0"
        lblChange.ForeColor = Color.Black
        lblChange.Font = New Font("Microsoft Sans Serif", 20)
        lblChange.Text = "0.00"
        CheckBox1.CheckState = CheckState.Unchecked
        RichTextBox1.ResetText()
        lblToken.ResetText()


    End Sub

    Private Sub frmPOS_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            If (MessageBox.Show("Are you sure you want to exit? all data will be saved automatically", "Exit Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Me.Close()

            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub chkReScan_CheckedChanged(sender As Object, e As EventArgs) Handles chkReScan.CheckedChanged

        ' chkReScan.CheckState = CheckState.Unchecked

        If chkReScan.Checked = True Then
            If (MessageBox.Show("Warning! by proceeding you should remove the record too in the appearing window after scanning to avoid mis-information that can cause data loss!", "Please make sure that you know what you are going to do. Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                MessageBox.Show("Re-scan Feature Activated, Just Uncheck the re-scan box to return to original state", "Enabled Re-Scan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chkReScan.CheckState = CheckState.Checked

            Else
                chkReScan.CheckState = CheckState.Unchecked
            End If

        Else

        End If




    End Sub

    Private Sub TbPOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbPOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 46 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Try
            Dim token = AutosupplyDataSet.tbPOS.Count + 1 & Date.Today.Day & Date.Today.Month & ".rtf"
            Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Daily Sales\Sales"
            Dim read
            If txtToken.Text = Nothing Then
                MessageBox.Show("Please Input Public Token", "Public Token Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                If (MessageBox.Show("Are you sure you want to restore changes? you also needed to Scan all Indicated products in the transaction list again.", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    read = My.Computer.FileSystem.ReadAllText(log1 & " " & txtToken.Text & ".rtf")

                    frmReload.TopMost = True
                    frmReload.Show()
                    frmReload.rtbReload.Text = read
                    RichTextBox1.ResetText()
                    lblTotal.Text = "0.00"
                    lblChange.Text = "0.00"
                    ' MessageBox.Show("Successfully Loaded", "Done")

                Else
                    'no action
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Something Wen't Wrong", "Please Contact Administrator", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

    End Sub

    Private Sub txtCash_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCash.KeyDown

        If e.KeyCode = Keys.Enter And RichTextBox1.TextLength <> 0 Then
            btnCheckout_Click(sender, e)

        Else

        End If

    End Sub
End Class