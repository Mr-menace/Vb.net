Imports System.Runtime.InteropServices

Public Class frmUpdate
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)

    End Sub
    Private Sub TbAccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TbProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbProducts' table. You can move, or remove it, as needed.
        Me.TbProductsTableAdapter.Fill(Me.AutosupplyDataSet.tbProducts)


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            If TextBox1.Text = Nothing Or BrandTextBox.Text = Nothing Or QualityTextBox.Text = Nothing Or SupplierTextBox.Text = Nothing Then

                Exit Sub

            Else

                TbProductsBindingSource.EndEdit()
                TbProductsTableAdapter.Update(AutosupplyDataSet.tbProducts)
                MessageBox.Show("Saving Success", "Saving Status: Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.TbProductsTableAdapter.Fill(Form1.AutosupplyDataSet.tbProducts)
            End If

        Catch ex As Exception


            MessageBox.Show(ex.Message, "Saving Status: Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand)



        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            TbProductsBindingSource.Filter = "(CONVERT(ProductID,'System.String')LIKE'" & txtsearc.Text & "')OR(CONVERT(BarcodeEncode,'System.String')LIKE'" & txtsearc.Text & "')
                                               OR(ProductName LIKE'" & txtsearc.Text & "')"

            If TbProductsBindingSource.Count = 0 Then
                MessageBox.Show("No Record Found For: " & txtsearc.Text, "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If


        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtsearc.ResetText()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TbProductsBindingSource.Filter = Nothing
    End Sub

    Private Sub txtsearc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearc.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Button1_Click(sender, e)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If


        If e.KeyCode = Keys.Delete Then
            Button2_Click(sender, e)
        End If

    End Sub

    Private Sub frmUpdate_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub
End Class