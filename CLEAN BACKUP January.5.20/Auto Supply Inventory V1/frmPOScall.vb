Imports System.IO

Public Class frmPOScall
    Private Sub TbProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmPOScall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbPOS' table. You can move, or remove it, as needed.
        Me.TbPOSTableAdapter.Fill(Me.AutosupplyDataSet.tbPOS)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbProducts' table. You can move, or remove it, as needed.
        Me.TbProductsTableAdapter.Fill(Me.AutosupplyDataSet.tbProducts)


        Me.TbProductsBindingSource.Filter = "(CONVERT(BarcodeEncode, 'System.String')LIKE '" & frmPOS.txtBarcode.Text & "')"

        Try

            Dim token = AutosupplyDataSet.tbPOS.Count + 1 & Date.Today.Day & Date.Today.Month & ".rtf"

            Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Daily Sales\Sales"

            If File.Exists(log1 & " " & token) Then
                'no action
                frmPOS.txtToken.Text = AutosupplyDataSet.tbPOS.Count + 1 & Date.Today.Day & Date.Today.Month
                frmPOS.lblToken.Text = AutosupplyDataSet.tbPOS.Count + 1 & Date.Today.Day & Date.Today.Month
            Else
                frmPOS.txtToken.Text = AutosupplyDataSet.tbPOS.Count + 1 & Date.Today.Day & Date.Today.Month
                frmPOS.lblToken.Text = AutosupplyDataSet.tbPOS.Count + 1 & Date.Today.Day & Date.Today.Month
                File.Create(log1 & " " & token).Close()


            End If


            Dim na, na1, na2, na3, na4, na5
            Dim na6, na7, na8 As Integer

            If TbProductsBindingSource.Count = 0 Then
                frmPOS.lblItem.Text = "Product Doesn't Exist"
                frmPOS.lblAmt.Text = "Null"
                frmPOS.lblOrigPrice.Text = "Null"


            Else

                'IF di naka check ang re-scan checkbox sa POS Form
                If frmPOS.chkReScan.Checked = False Then
                    If frmPOS.NumQuantity.Value > Me.QuantityLabel1.Text Then

                        MessageBox.Show("Sorry Not Enough Stocks for this Product, You are about to Deduct: {" & frmPOS.NumQuantity.Value & "} But you only have: {" & Me.QuantityLabel1.Text & "} stocks left for this product", "Failed to process please re-stock", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                    Else

                        na = frmPOS.lblItem.Text
                        na1 = Val(frmPOS.lblAmt.Text)
                        na2 = Val(frmPOS.NumQuantity.Value)
                        na3 = Val(frmPOS.lblTotal.Text)
                        na4 = Val(frmPOS.txtCash.Text)
                        na5 = Val(frmPOS.lblChange.Text)

                        na7 = Val(OrigPriceTextBox.Text)

                        'for Product Quantity
                        na8 = Val(QuantityLabel1.Text) - na2

                        'for frmposlblTotal
                        na6 = (frmPOS.NumQuantity.Value * na7) + frmPOS.lblTotal.Text
                        QuantityLabel1.Text = na8
                        frmPOS.lblItem.Text = Me.ProductNameLabel1.Text & " x" & na2
                        frmPOS.lblOrigPrice.Text = Me.OrigPriceTextBox.Text
                        frmPOS.lblAmt.Text = Val(frmPOS.NumQuantity.Value * na7).ToString("n")
                        frmPOS.lblTotal.Text = na6.ToString("n")

                        'write on richtextbox

                        frmPOS.RichTextBox1.AppendText("Scanned: " & Date.Today.ToShortDateString & " " & TimeOfDay.ToShortTimeString & vbNewLine)
                        frmPOS.RichTextBox1.AppendText("=======================" & vbNewLine)
                        frmPOS.RichTextBox1.AppendText("Barcode: " & BarcodeEncodeLabel1.Text & vbNewLine)
                        frmPOS.RichTextBox1.AppendText("Product: " & ProductNameLabel1.Text & vbNewLine)
                        frmPOS.RichTextBox1.AppendText("Qty: " & frmPOS.NumQuantity.Value & vbNewLine)
                        frmPOS.RichTextBox1.AppendText("Price: " & OrigPriceTextBox.Text & vbNewLine)
                        frmPOS.RichTextBox1.AppendText("Total: " & frmPOS.NumQuantity.Value * na7 & vbNewLine)
                        frmPOS.RichTextBox1.AppendText("=======================" & vbNewLine & vbNewLine)

                        frmPOS.RichTextBox1.ScrollToCaret()

                        'write to texfile
                        File.AppendAllText(log1 & " " & token, "Scanned: " & Date.Today.ToShortDateString & " " & TimeOfDay.ToShortTimeString & vbNewLine)
                        File.AppendAllText(log1 & " " & token, "=======================" & vbNewLine)
                        File.AppendAllText(log1 & " " & token, "Barcode: " & BarcodeEncodeLabel1.Text & vbNewLine)
                        File.AppendAllText(log1 & " " & token, "Product: " & ProductNameLabel1.Text & vbNewLine)
                        File.AppendAllText(log1 & " " & token, "Qty: " & frmPOS.NumQuantity.Value & vbNewLine)
                        File.AppendAllText(log1 & " " & token, "Price: " & OrigPriceTextBox.Text & vbNewLine)
                        File.AppendAllText(log1 & " " & token, "Total: " & frmPOS.NumQuantity.Value * na7 & vbNewLine)
                        File.AppendAllText(log1 & " " & token, "=======================" & vbNewLine & vbNewLine)

                        Me.TbProductsBindingSource.EndEdit()
                        TbProductsTableAdapter.Update(AutosupplyDataSet.tbProducts)
                        Form1.TbProductsTableAdapter.Fill(Form1.AutosupplyDataSet.tbProducts)

                        If frmPOS.CheckBox1.Checked = True Then
                            'no action
                        Else

                            frmPOS.NumQuantity.Value = 1

                        End If

                    End If


                Else

                    'Test!~~ MsgBox("Re-scan Checked!")

                    'if nakacheck ang chkrescan

                    If frmPOS.lblTotal.Text = "0.00" Then
                        'null
                    Else

                        na = frmPOS.lblItem.Text
                        na1 = Val(frmPOS.lblAmt.Text)
                        na2 = Val(frmPOS.NumQuantity.Value)
                        na3 = Val(frmPOS.lblTotal.Text)
                        na4 = Val(frmPOS.txtCash.Text)
                        na5 = Val(frmPOS.lblChange.Text)

                        na7 = Val(OrigPriceTextBox.Text)

                        'for Product Quantity
                        na8 = Val(QuantityLabel1.Text) + na2

                        'for frmposlblTotal
                        na6 = frmPOS.lblTotal.Text - (frmPOS.NumQuantity.Value * na7)

                        QuantityLabel1.Text = na8
                        frmPOS.lblItem.Text = "Deducted " & Me.ProductNameLabel1.Text & " x" & na2
                        frmPOS.lblOrigPrice.Text = Me.OrigPriceTextBox.Text
                        frmPOS.lblAmt.Text = Val(frmPOS.NumQuantity.Value * na7).ToString("n")

                        If na6 > 0 Then
                            frmPOS.lblTotal.Text = na6.ToString("n")
                        Else
                            frmPOS.lblTotal.Text = "0.00"
                        End If

                        Me.TbProductsBindingSource.EndEdit()
                        TbProductsTableAdapter.Update(AutosupplyDataSet.tbProducts)
                        Form1.TbProductsTableAdapter.Fill(Form1.AutosupplyDataSet.tbProducts)

                    End If


                End If

            End If


            Me.TbProductsBindingSource.Filter = Nothing

        Catch i As OverflowException
            MessageBox.Show(i.Message & " Please Try Another Transaction Limit Reached.", "Sorry Overflow to the Total Price Detected", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Catch i2 As Exception
            MessageBox.Show(i2.Message, "Something Wen't Wrong Please Contact Administrator", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
        frmPOS.txtBarcode.ResetText()

        Me.Close()


    End Sub
End Class