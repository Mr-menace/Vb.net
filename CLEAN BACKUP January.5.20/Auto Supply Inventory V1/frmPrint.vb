Imports ZXing.Common
Imports ZXing
Imports System.Data.OleDb
Imports System.IO




Public Class frmPrint
    Dim id = 0
    Dim iT = 0
    Dim data As New DataTable

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged

        If txtBarcode.TextLength > 12 Then
            RadioButton2.Checked = True

        Else
            RadioButton1.Checked = True
        End If


        Dim bcode As New BarcodeWriter
        bcode.Format = BarcodeFormat.CODE_128


        If txtBarcode.Text = Nothing Then
            BarcodeimgPictureBox.Image = Nothing
            Exit Sub

        Else
            BarcodeimgPictureBox.Image = bcode.Write(txtBarcode.Text)
        End If


        Dim barcode, check12digits As String

        If Not (String.IsNullOrEmpty(txtBarcode.Text)) Then

            check12digits = txtBarcode.Text.PadRight(12, CChar("0"))
            barcode = EAN13(check12digits)
            lblOut.Text = barcode

        End If
    End Sub

    Dim pageNumber As Integer = 1
    Dim numberOfPages As Integer = 1
    Dim i As Integer = 0
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Code EAN13", 48, FontStyle.Regular)
        Dim font2 As New Font("Microsoft Tai Le", 12, FontStyle.Regular)



        If RadioButton1.Checked Then

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 45, 35)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 20, 50)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 245, 35)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 220, 50)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 445, 35)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 420, 50)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 645, 35)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 620, 50)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 45, 150)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 20, 165)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 245, 150)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 220, 165)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 445, 150)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 420, 165)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 645, 150)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 620, 165)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 45, 260)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 20, 275)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 245, 260)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 220, 275)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 445, 260)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 420, 275)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 645, 260)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 620, 275)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 45, 370)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 20, 385)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 245, 370)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 220, 385)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 445, 370)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 420, 385)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 645, 370)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 620, 385)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 45, 480)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 20, 495)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 245, 480)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 220, 495)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 445, 480)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 420, 495)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 645, 480)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 620, 495)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 45, 590)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 20, 605)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 245, 590)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 220, 605)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 445, 590)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 420, 605)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 645, 590)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 620, 605)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 45, 705)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 20, 720)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 245, 705)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 220, 720)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 445, 705)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 420, 720)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 645, 705)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 620, 720)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 45, 815)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 20, 830)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 245, 815)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 220, 830)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 445, 815)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 420, 830)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 645, 815)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 620, 830)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 45, 925)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 20, 940)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 245, 925)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 220, 940)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 445, 925)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 420, 940)
            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, 645, 925)
            e.Graphics.DrawString(lblOut.Text, font1, Brushes.Black, 620, 940)

        Else

            ' For left side

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - 20)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Left, e.MarginBounds.Top)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 130)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Left, e.MarginBounds.Top + 150)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 280)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Left, e.MarginBounds.Top + 300)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 430)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Left, e.MarginBounds.Top + 450)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 580)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Left, e.MarginBounds.Top + 600)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 730)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Left, e.MarginBounds.Top + 750)

            'for right side

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Right - 200, e.MarginBounds.Top - 20)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Right - 200, e.MarginBounds.Top)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Right - 200, e.MarginBounds.Top + 130)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Right - 200, e.MarginBounds.Top + 150)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Right - 200, e.MarginBounds.Top + 280)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Right - 200, e.MarginBounds.Top + 300)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Right - 200, e.MarginBounds.Top + 430)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Right - 200, e.MarginBounds.Top + 450)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Right - 200, e.MarginBounds.Top + 580)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Right - 200, e.MarginBounds.Top + 600)

            e.Graphics.DrawString(txtName.Text, font2, Brushes.Black, e.MarginBounds.Right - 200, e.MarginBounds.Top + 730)
            e.Graphics.DrawImage(BarcodeimgPictureBox.Image, e.MarginBounds.Right - 200, e.MarginBounds.Top + 750)


        End If

        ' End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.TopMost = False
            PrintPreviewDialog1.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Make Sure That This Computer Have a Printer Drivers Installed", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintPreviewDialog1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles PrintPreviewDialog1.FormClosing
        Me.TopMost = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then

            BarcodeimgPictureBox.Visible = True
            lblOut.Visible = False
        Else
            BarcodeimgPictureBox.Visible = False
            lblOut.Visible = True


        End If
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Visible = True
        ProgressBar1.PerformStep()

        lblPercent.Text = ProgressBar1.Value & "%"

        If ProgressBar1.Value = 5 Then
            lblStat.Text = "Preparing Data..."

        ElseIf ProgressBar1.Value = 40 Then
            lblStat.Text = "Fetching Resources....."

        ElseIf ProgressBar1.Value = 60 Then
            lblStat.Text = "Almost Done..."

        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            lblStat.Text = "Successfully Generated [" & ComboBox1.Text & "] Report"
            SendMessage(ProgressBar1.Handle, 1040, 1, 0)
            ComboBox1.Enabled = True
            pbProcess.Enabled = True
            pbProcess.BackColor = Color.LightGoldenrodYellow
            pbPrint.Enabled = True
            pbPrint.BackColor = Color.LightGoldenrodYellow


        End If


    End Sub

    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbProducts' table. You can move, or remove it, as needed.
        Me.TbProductsTableAdapter.Fill(Me.AutosupplyDataSet.tbProducts)


    End Sub

    Private Sub TbProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        Timer1.Enabled = False
        ProgressBar1.Visible = False
        ProgressBar1.Value = 0
        lblStat.ResetText()
        lblPercent.ResetText()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbPrint.Click


        Dim d = Date.Today.ToLongDateString

        If ComboBox1.SelectedIndex = 0 Then

            Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\Daily Inventory\Daily Inventory " & d & ".rtf"

            Try

                Process.Start(log1)

            Catch i As Exception

                MessageBox.Show(i.Message, "You haven't generated this kind of Report yet today", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            End Try

        ElseIf ComboBox1.SelectedIndex = 1 Then

            Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\General Inventory\General Inventory.rtf"

            Try

                Process.Start(log1)

            Catch i As Exception

                MessageBox.Show(i.Message, "You haven't generated this kind of Report yet today", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            End Try

        ElseIf ComboBox1.SelectedIndex = 2 Then

            Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\Daily Stocks\Daily Stocks " & d & ".rtf"

            Try

                Process.Start(log1)

            Catch i As Exception

                MessageBox.Show(i.Message, "You haven't generated this kind of Report yet today", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            End Try

        ElseIf ComboBox1.SelectedIndex = 3 Then

            Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\Daily Purchase\Daily Purchase" & d & ".rtf"

            Try

                Process.Start(log1)

            Catch i As Exception

                MessageBox.Show(i.Message, "You haven't generated this kind of Report yet today", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            End Try

        ElseIf ComboBox1.SelectedIndex = 4 Then

            Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports\General Purchase\General Purchase.rtf"

            Try

                Process.Start(log1)

            Catch i As Exception

                MessageBox.Show(i.Message, "You haven't generated this kind of Report yet today", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            End Try

        End If


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pbProcess.Click

        Timer1.Enabled = False
        ProgressBar1.Visible = False
        ProgressBar1.Value = 0
        lblStat.ResetText()
        SendMessage(ProgressBar1.Handle, 1040, 2, 0)



        If ComboBox1.SelectedIndex = 0 Then

            frmReports.Show()

        ElseIf ComboBox1.SelectedIndex = 1 Then

            frmReports.Show()

        ElseIf ComboBox1.SelectedIndex = 2 Then
            frmReports.Show()

        ElseIf ComboBox1.SelectedIndex = 3 Then
            frmReports.Show()

        ElseIf ComboBox1.SelectedIndex = 4 Then
            frmReports.Show()

        End If

    End Sub

    Private Sub pbFiles_Click(sender As Object, e As EventArgs) Handles pbFiles.Click
        Dim log1 As String = System.AppDomain.CurrentDomain.BaseDirectory & "Documents\Reports"

        Try
            Process.Start(Path.Combine(log1))

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong")
        End Try

    End Sub

    Private Sub frmPrint_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub
End Class