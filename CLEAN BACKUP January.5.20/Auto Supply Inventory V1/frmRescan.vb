Imports System.IO

Public Class frmRescan
    Private Sub frmRescan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbPOS' table. You can move, or remove it, as needed.
        Me.TbPOSTableAdapter.Fill(Me.AutosupplyDataSet.tbPOS)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPOS.RichTextBox1.Text = Me.RichTextBox1.Text
        frmPOS.chkReScan.CheckState = CheckState.Unchecked
        frmPOS.NumQuantity.Value = 1
        Me.Close()

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TbPOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbPOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim token = AutosupplyDataSet.tbPOS.Count + 1 & Date.Today.Day & Date.Today.Month & ".rtf"
            Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Daily Sales\Sales"
            Dim read

            read = My.Computer.FileSystem.ReadAllText(log1 & " " & token)
            RichTextBox1.Text = read

            MessageBox.Show("Successfully Loaded", "Done")
        Catch ex As Exception
            MessageBox.Show("Something Wen't Wrong", "Please Contact Administrator", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

    End Sub
End Class