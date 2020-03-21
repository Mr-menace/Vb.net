Imports System.Data.OleDb
Imports WMPLib
Imports System.IO
Imports System.Runtime.InteropServices



Public Class frmReturn
    Dim sound As New WindowsMediaPlayer


    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
    End Sub
    Private Sub TbProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbReturned' table. You can move, or remove it, as needed.
        Me.TbReturnedTableAdapter.Fill(Me.AutosupplyDataSet.tbReturned)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbProducts' table. You can move, or remove it, as needed.
        Me.TbProductsTableAdapter.Fill(Me.AutosupplyDataSet.tbProducts)

    End Sub

    Private Sub PartNoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String
        Dim na, na1

        na = AutosupplyDataSet.tbReturned.Count + 1
        na1 = TimeOfDay.Hour & TimeOfDay.Minute.ToString & TimeOfDay.Second.ToString
        Dim d = Date.Today.ToLongDateString

        TbProductsTableAdapter.Fill(AutosupplyDataSet.tbProducts)
        TbProductsBindingSource.Filter = "(CONVERT(BarcodeEncode, 'System.String')LIKE '" & Val(BarcodeEncodeTextBox.Text) & "')"

        Try
            If BarcodeEncodeTextBox.Text = Nothing Then

                Exit Sub

            Else


                If Me.TbProductsBindingSource.Count = 0 Then
                    sound.URL = Path.Combine("SoundPacks\ScanError.mp3")
                    lblData.Visible = True
                    Exit Sub

                Else

                    lblReturnID.Text = na & na1

                    lblQuantity.Text = Val(lblQuantity.Text) + Val(txtQuantity.Text)


                    sound.URL = Path.Combine("SoundPacks\Scan.mp3")

                    connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"
                    sqlconn.ConnectionString = connString
                    sqlquery.Connection = sqlconn

                    sqlconn.Open()

                    sqlquery.CommandText = "INSERT INTO tbReturned ([ID], [ProductName], [Brand], Quantity, [Barcode], [ReturnedDate], [EncodeBy], [Status], [DatePurchased], [OrigPrice])
                           VALUES([@ID], [@ProductName], [@Brand], [@Quantity], [@Barcode], [@ReturnedDate], [@EncodeBy], [@Status], [@DatePurchased], [OrigPrice])"

                    sqlquery.Parameters.AddWithValue("[@ID]", lblReturnID.Text)
                    sqlquery.Parameters.AddWithValue("[@ProductName]", ProductNameTextBox.Text)
                    sqlquery.Parameters.AddWithValue("[@Brand]", BrandTextBox.Text)
                    sqlquery.Parameters.AddWithValue("[@Quantity]", txtQuantity.Text)
                    sqlquery.Parameters.AddWithValue("[@Barcode]", BarcodeEncodeTextBox.Text)
                    sqlquery.Parameters.AddWithValue("[@ReturnedDate]", dtpDate.Text & " " & dtpTime.Text)
                    sqlquery.Parameters.AddWithValue("[@EncodeBy]", Form1.lblName.Text)


                    Dim nas = Date.Today.ToLongDateString


                    If rbtDamage.Checked Then
                        sqlquery.Parameters.AddWithValue("[@Status]", "Item Was Rejected [" & txtQuantity.Text & "]")

                        File.AppendAllText("Documents\Logs\Returns\Rejected, " & d & ".rtf", "=========================Rejected From Prod Returns======================" & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Rejected, " & d & ".rtf", "Barcode#: " & BarcodeEncodeTextBox.Text & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Rejected, " & d & ".rtf", "Purchase Date: " & dtpPurchased.Value.ToLongDateString & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Rejected, " & d & ".rtf", "Product Name: " & ProductNameTextBox.Text & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Rejected, " & d & ".rtf", "Total Quantity: " & lblQuantity.Text & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Rejected, " & d & ".rtf", "Returned Date: " & Date.Today.ToLongDateString & " " & TimeOfDay.ToLongTimeString & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Rejected, " & d & ".rtf", "By: " & Form1.lblName.Text & vbNewLine & vbNewLine)


                    ElseIf rbtGood.Checked Then
                        sqlquery.Parameters.AddWithValue("[@Status]", "Item Was Added To Inventory [" & txtQuantity.Text & "]")

                        File.AppendAllText("Documents\Logs\Returns\Returned in Good, " & d & ".rtf", "====================Re-Amounted From Prod Returns====================" & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Returned in Good, " & d & ".rtf", "Barcode#: " & BarcodeEncodeTextBox.Text & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Returned in Good, " & d & ".rtf", "Purchase Date: " & dtpPurchased.Value.ToLongDateString & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Returned in Good, " & d & ".rtf", "Product Name: " & ProductNameTextBox.Text & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Returned in Good, " & d & ".rtf", "Total Quantity: " & lblQuantity.Text & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Returned in Good, " & d & ".rtf", "Added Quantity: " & txtQuantity.Text & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Returned in Good, " & d & ".rtf", "New Quantity: " & Val(lblQuantity.Text) + Val(txtQuantity.Text) & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Returned in Good, " & d & ".rtf", "Returned Date: " & Date.Today.ToLongDateString & " " & TimeOfDay.ToLongTimeString & vbNewLine)
                        File.AppendAllText("Documents\Logs\Returns\Returned in Good, " & d & ".rtf", "By: " & Form1.lblName.Text & vbNewLine & vbNewLine)


                    End If
                    sqlquery.Parameters.AddWithValue("[@DatePurchased]", dtpPurchased.Value.ToLongDateString)
                    sqlquery.Parameters.AddWithValue("[@OrigPrice]", Val(txtOrig.Text))
                    sqlquery.ExecuteNonQuery()
                    sqlconn.Close()

                    Me.TbReturnedTableAdapter.Fill(AutosupplyDataSet.tbReturned)
                    'reset immidiately id for returns
                    lblReturnID.ResetText()

                    If rbtGood.Checked Then


                        TbProductsBindingSource.EndEdit()
                                TbProductsTableAdapter.Update(AutosupplyDataSet.tbProducts)
                                BarcodeEncodeTextBox.ResetText()

                            Else
                                BarcodeEncodeTextBox.ResetText()
                                Exit Sub

                            End If


                    'refresh form 1
                    Form1.TbProductsTableAdapter.Fill(Form1.AutosupplyDataSet.tbProducts)
                    If Form1.chkNotif.Checked Then
                        Form1.Timer2.Enabled = False

                    Else
                        Form1.Timer2.Enabled = True

                    End If

                End If

                    End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something Wen't Wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End Try


    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If BarcodeEncodeTextBox.Text = Nothing Then
            lblData.Visible = False
        End If


        If txtQuantity.Text = Nothing Or rbtDamage.Checked = False And rbtGood.Checked = False Then

            BarcodeEncodeTextBox.Enabled = False


        Else

            BarcodeEncodeTextBox.Enabled = True

        End If



    End Sub



    Private Sub rbtGood_CheckedChanged(sender As Object, e As EventArgs) Handles rbtGood.CheckedChanged
        If rbtGood.Checked And BarcodeEncodeTextBox.TextLength = 12 Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFind.Click


        If txtfind.Text = Nothing Then
            Exit Sub

        Else

            TbReturnedBindingSource.Filter = "(CONVERT(Barcode, 'System.String')LIKE '" & txtfind.Text & "') OR(ProductName LIKE'" & txtfind.Text & "')
                                            OR(Brand LIKE'" & txtfind.Text & "')"

        If TbReturnedBindingSource.Count = 0 Then

            MessageBox.Show("No Record Found For :" & txtfind.Text & "", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else

        End If

        End If


    End Sub

    Private Sub txtfind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfind.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Button2_Click(sender, e)

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtfind.ResetText()
        TbReturnedTableAdapter.Fill(AutosupplyDataSet.tbReturned)
        TbReturnedBindingSource.Filter = Nothing

    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 46 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmReturn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Form1.chkNotif.Checked Then
            Form1.Timer2.Enabled = False

        Else
            Form1.Timer2.Enabled = True

        End If
    End Sub

    Private Sub BarcodeEncodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeEncodeTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        If Form1.lblType.Text = "ADMIN" Then

            If (MessageBox.Show("Are you sure you want to delete this Record?", "Please Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                If TbReturnedBindingSource.Count <> 0 Then
                    TbReturnedBindingSource.RemoveCurrent()
                    TbReturnedBindingSource.EndEdit()
                    TbReturnedTableAdapter.Update(AutosupplyDataSet.tbReturned)
                    TbReturnedTableAdapter.Fill(AutosupplyDataSet.tbReturned)
                Else
                    MessageBox.Show("No Record To Delete", "No Action")
                End If

            Else
                    'no action
                End If



            Else

            MessageBox.Show("Only Admin Can Delete Records", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)


        End If

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim na

        If TbReturnedBindingSource.Count <> 0 Then

            Dim row As DataGridViewRow = TbReturnedDataGridView.CurrentRow
            na = row.Cells(0).Value.ToString

            Try
                'frmReturnEdit.TbReturnedTableAdapter.Fill(frmReturnEdit.AutosupplyDataSet.tbReturned)
                frmReturnEdit.TbReturnedBindingSource.Filter = "(CONVERT(Barcode, 'System.String') LIKE '" & na & "')"
                Me.TopMost = False
                frmReturnEdit.ShowDialog()



            Catch o As Exception
                MessageBox.Show(o.Message, "Error Occured")
            End Try

        Else
            Exit Sub

        End If



    End Sub

    Private Sub frmReturn_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub
End Class