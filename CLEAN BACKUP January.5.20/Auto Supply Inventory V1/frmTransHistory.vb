Imports System.IO

Public Class frmTransHistory

    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
    End Sub
    Private Sub TbPOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbPOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmTransHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbPOS' table. You can move, or remove it, as needed.
        Me.TbPOSTableAdapter.Fill(Me.AutosupplyDataSet.tbPOS)

    End Sub

    Private Sub frmTransHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If


        If e.KeyCode = Keys.Left Then
            Button1_Click(sender, e)

        End If

        If e.KeyCode = Keys.Right Then
            Button3_Click(sender, e)

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TbPOSBindingSource.Filter = "(CONVERT(Token,'System.String') LIKE'" & txtSearch.Text & "') OR(TransactionDate LIKE'" & txtSearch.Text & "')"

        If TbPOSBindingSource.Count = 0 Then
            MessageBox.Show("Nothing Found Please Try Another Keywords", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TbPOSBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TbPOSBindingSource.MoveNext()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TbPOSBindingSource.Filter = Nothing
        txtSearch.ResetText()



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Daily Sales\To Print"
        If BreakdownsRichTextBox.Text = Nothing Then
            MessageBox.Show("Unable to print Empty Resource", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            Try
                If File.Exists(log1 & " " & TokenTextBox.Text & ".rtf") Then

                    If (MessageBox.Show("This Kind of File Already Exist Would you like to Replace it?", "Replace Existing File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                        File.Delete(log1 & " " & TokenTextBox.Text & ".rtf")

                        File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", "File Type: Transaction History File" & vbNewLine)
                        File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", "Public Token: " & TokenTextBox.Text & vbNewLine)
                        File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", "Generated: " & Date.Today.ToShortDateString & " " & TimeOfDay.ToShortTimeString & vbNewLine)
                        File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", "==================START====================" & vbNewLine & vbNewLine)
                        File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", BreakdownsRichTextBox.Text & vbNewLine)
                        File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", "==============END OF REPORT================" & vbNewLine)
                        MessageBox.Show("Report Successfully Replaced!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        '
                        ' File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", BreakdownsRichTextBox.Text)


                    End If

                Else

                    File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", "File Type: Transaction History File" & vbNewLine)
                    File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", "Public Token: " & TokenTextBox.Text & vbNewLine)
                    File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", "Generated: " & Date.Today.ToShortDateString & " " & TimeOfDay.ToShortTimeString & vbNewLine)
                    File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", "==================START====================" & vbNewLine & vbNewLine)
                    File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", BreakdownsRichTextBox.Text & vbNewLine)
                    File.AppendAllText(log1 & " " & TokenTextBox.Text & ".rtf", "==============END OF REPORT================" & vbNewLine)

                    MessageBox.Show("Report Successfully Created!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Something Wen't Wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            End Try

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Logs\Daily Sales\To Print"

        Try
            If File.Exists(log1 & " " & TokenTextBox.Text & ".rtf") Then
                Process.Start(log1 & " " & TokenTextBox.Text & ".rtf")

            Else

                MessageBox.Show("Report Not Yet Created", "Please Create the report first to open", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBox2_Click(sender, e)
            e.SuppressKeyPress = True
        End If

        If e.KeyCode = Keys.Delete Then
            PictureBox3_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub
End Class