Imports System.Data.OleDb

Public Class frmBgWorker
    Dim i As Integer = 0
    Dim con As New OleDbConnection
    Private Sub TbProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmBgWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbProducts' table. You can move, or remove it, as needed.
        Me.TbProductsTableAdapter.Fill(Me.AutosupplyDataSet.tbProducts)


        TbProductsTableAdapter.Fill(AutosupplyDataSet.tbProducts)

        TbProductsBindingSource.Filter = "(CONVERT(Quantity,'System.String')LIKE'" & "2" & "') OR(CONVERT(Quantity,'System.String')LIKE'" & "1" & "') OR(CONVERT(Quantity,'System.String')LIKE'" & "0" & "')"
        Label2.Text = "Detected: " & TbProductsBindingSource.Count.ToString
        'Form1.lblMes.Visible = True
        'Form1.lblMes.Text = TbProductsBindingSource.Count.ToString

        Try

            Dim connectionString As String

            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"

            'gawa ng Connection
            con = New OleDbConnection(connectionString)

            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something Wen't Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Finally


        End Try


        Me.Location = New Point(
            Screen.PrimaryScreen.Bounds.Width - 800, 'Yung pwesto nya sa gilid
            Screen.PrimaryScreen.Bounds.Height - 1000) 'Yung taas nya 




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'ORIGINAL=====
        'If i = 200 Then

        '    Me.Close()

        'End If

        'If Not Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Height - 200 Then
        '    Me.Location = New Point(Me.Location.X, Me.Location.Y - 2)
        'End If

        'i += 1

        If i >= 300 Then

            Me.Close()

        End If


        If Not Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Height - 900 Then 'yung bababaan nya or pupuntahan
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 2) 'para gumalaw ang form pababa -2 naman kung pataas 
        End If

        i += 1



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick





    End Sub

    Private Sub frmBgWorker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        con.Close()
        'Form1.Timer2.Enabled = True

    End Sub

    Private Sub frmBgWorker_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub
End Class