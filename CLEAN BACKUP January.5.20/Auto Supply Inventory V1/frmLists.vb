Public Class frmLists
    Private Sub TbSupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbSupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbBrand' table. You can move, or remove it, as needed.
        Me.TbBrandTableAdapter.Fill(Me.AutosupplyDataSet.tbBrand)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbQuality' table. You can move, or remove it, as needed.
        Me.TbQualityTableAdapter.Fill(Me.AutosupplyDataSet.tbQuality)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbSupplier' table. You can move, or remove it, as needed.
        Me.TbSupplierTableAdapter.Fill(Me.AutosupplyDataSet.tbSupplier)
        cboDisplay.SelectedItem = "20"

    End Sub

    Private Sub cboDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDisplay.SelectedIndexChanged
        Dim na
        na = cboDisplay.SelectedItem.ToString

        TbSupplierDataGridView.RowTemplate.Height = na
        TbBrandDataGridView.RowTemplate.Height = na
        TbQualityDataGridView.RowTemplate.Height = na

        TbSupplierTableAdapter.Fill(AutosupplyDataSet.tbSupplier)
        TbBrandTableAdapter.Fill(AutosupplyDataSet.tbBrand)
        TbQualityTableAdapter.Fill(AutosupplyDataSet.tbQuality)

        If cboDisplay.Text = Nothing Then
            Exit Sub
        End If

    End Sub

    Private Sub frmLists_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            TbSupplierDataGridView.ReadOnly = False
            DeleteToolStripMenuItem.Enabled = True
            SaveChangesToolStripMenuItem.Enabled = True
        End If

        If TabControl1.SelectedTab Is TabPage2 Then
            TbBrandDataGridView.ReadOnly = False
            DeleteToolStripMenuItem.Enabled = True
            SaveChangesToolStripMenuItem.Enabled = True
        End If

        If TabControl1.SelectedTab Is TabPage3 Then
            TbQualityDataGridView.ReadOnly = False
            DeleteToolStripMenuItem.Enabled = True
            SaveChangesToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            Try
                TbSupplierBindingSource.RemoveCurrent()
                SaveChangesToolStripMenuItem_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If

        If TabControl1.SelectedTab Is TabPage2 Then
            Try
                TbBrandBindingSource.RemoveCurrent()
                SaveChangesToolStripMenuItem_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If

        If TabControl1.SelectedTab Is TabPage3 Then
            Try
                TbQualityBindingSource.RemoveCurrent()
                SaveChangesToolStripMenuItem_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If

    End Sub

    Private Sub SaveChangesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveChangesToolStripMenuItem.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            Try
                TbSupplierBindingSource.EndEdit()
                TbSupplierTableAdapter.Update(AutosupplyDataSet.tbSupplier)
                TbSupplierDataGridView.ReadOnly = True
                DeleteToolStripMenuItem.Enabled = False
                SaveChangesToolStripMenuItem.Enabled = False
                MessageBox.Show("Changes Save", "Done")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If

        If TabControl1.SelectedTab Is TabPage2 Then
            Try
                TbBrandBindingSource.EndEdit()
                TbBrandTableAdapter.Update(AutosupplyDataSet.tbBrand)
                TbBrandDataGridView.ReadOnly = True
                DeleteToolStripMenuItem.Enabled = False
                SaveChangesToolStripMenuItem.Enabled = False
                MessageBox.Show("Changes Save", "Done")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If

        If TabControl1.SelectedTab Is TabPage3 Then
            Try
                TbQualityBindingSource.EndEdit()
                TbQualityTableAdapter.Update(AutosupplyDataSet.tbQuality)
                TbBrandDataGridView.ReadOnly = True
                DeleteToolStripMenuItem.Enabled = False
                SaveChangesToolStripMenuItem.Enabled = False
                MessageBox.Show("Changes Save", "Done")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        TbSupplierDataGridView.ReadOnly = True
        TbBrandDataGridView.ReadOnly = True
        TbBrandDataGridView.ReadOnly = True
        DeleteToolStripMenuItem.Enabled = False
        SaveChangesToolStripMenuItem.Enabled = False
    End Sub
End Class