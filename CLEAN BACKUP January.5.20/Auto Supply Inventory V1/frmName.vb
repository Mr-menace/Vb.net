Public Class frmName
    Private Sub TbNameBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbNameBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbName' table. You can move, or remove it, as needed.
        Me.TbNameTableAdapter.Fill(Me.AutosupplyDataSet.tbName)

    End Sub

    Private Sub CompanyTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CompanyTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TbNameBindingSource.EndEdit()
                TbNameTableAdapter.Update(AutosupplyDataSet.tbName)
                MessageBox.Show("System Name Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.TbNameTableAdapter.Fill(Form1.AutosupplyDataSet.tbName)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Something wen't wrong")
            End Try
            Me.Close()

        End If
    End Sub
End Class