Public Class frmReturnEdit
    Private Sub TbReturnedBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbReturnedBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmReturnEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbReturned' table. You can move, or remove it, as needed.
        Me.TbReturnedTableAdapter.Fill(Me.AutosupplyDataSet.tbReturned)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If (MessageBox.Show("Save Any Changes You've Made?", "Save if there is change on Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                EncodeByTextBox.Text = Form1.lblName.Text
                TbReturnedBindingSource.EndEdit()
                TbReturnedTableAdapter.Update(AutosupplyDataSet.tbReturned)
                frmReturn.TbReturnedTableAdapter.Fill(frmReturn.AutosupplyDataSet.tbReturned)

            Else
                'no action
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error Occured")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TbReturnedTableAdapter.Fill(AutosupplyDataSet.tbReturned)
        Me.Close()

    End Sub

    Private Sub frmReturnEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.TbReturnedBindingSource.Filter = Nothing
        frmReturn.TopMost = True

    End Sub


End Class