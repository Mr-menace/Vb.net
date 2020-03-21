Imports System.IO
Imports WMPLib
Imports System.Runtime.InteropServices

Public Class frmExistProd
    Dim ans = Date.Today.ToLongDateString
    Private Sub TbProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmExistProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbProducts' table. You can move, or remove it, as needed.
        Me.TbProductsTableAdapter.Fill(Me.AutosupplyDataSet.tbProducts)

        QuantityTextBox.Text = Val(frmAdd.QuantityTextBox.Text) + Val(QuantityTextBox.Text)
        DeliveryDateLabel2.Text = frmAdd.dtpDate.Text
        DeliveryTimeLabel2.Text = frmAdd.dtpTime.Text


        File.AppendAllText("Documents\Logs\Delivery\Add, " & ans & ".rtf", "=========================PRODUCT DELIVERY(EXIST)======================" & vbNewLine)
        File.AppendAllText("Documents\Logs\Delivery\Add, " & ans & ".rtf", "Barcode#: " & BarcodeEncodeTextBox.Text & vbNewLine)
        File.AppendAllText("Documents\Logs\Delivery\Add, " & ans & ".rtf", "Product Name: " & ProductNameTextBox.Text & vbNewLine)
        File.AppendAllText("Documents\Logs\Delivery\Add, " & ans & ".rtf", "Total Quantity: " & QuantityTextBox.Text & vbNewLine)
        File.AppendAllText("Documents\Logs\Delivery\Add, " & ans & ".rtf", "Added Quantity: " & frmAdd.QuantityTextBox.Text & vbNewLine)
        File.AppendAllText("Documents\Logs\Delivery\Add, " & ans & ".rtf", "New Quantity: " & Val(QuantityTextBox.Text) + Val(frmAdd.QuantityTextBox.Text) & vbNewLine)
        File.AppendAllText("Documents\Logs\Delivery\Add, " & ans & ".rtf", "Date: " & Date.Today.ToLongDateString & " " & TimeOfDay.ToLongTimeString & vbNewLine)
        File.AppendAllText("Documents\Logs\Delivery\Add, " & ans & ".rtf", "By: " & Form1.lblName.Text & vbNewLine & vbNewLine)

        TbProductsBindingSource.EndEdit()
        TbProductsTableAdapter.Update(AutosupplyDataSet.tbProducts)
        Form1.TbProductsTableAdapter.Fill(Form1.AutosupplyDataSet.tbProducts)
        Me.Close()


    End Sub
End Class