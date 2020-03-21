Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class frmsuppEtc
    Dim con As New OleDbConnection

    Private Sub TbSupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbSupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmsuppEtc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbBrand' table. You can move, or remove it, as needed.
        Me.TbBrandTableAdapter.Fill(Me.AutosupplyDataSet.tbBrand)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbQuality' table. You can move, or remove it, as needed.
        Me.TbQualityTableAdapter.Fill(Me.AutosupplyDataSet.tbQuality)
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbSupplier' table. You can move, or remove it, as needed.
        Me.TbSupplierTableAdapter.Fill(Me.AutosupplyDataSet.tbSupplier)
        lblStatus.ResetText()
        lblstatus1.ResetText()
        lblstatus2.ResetText()



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim connectionString As String

        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"

        'gawa ng Connection
        Try

            con = New OleDbConnection(connectionString)

        con.Open()

        Dim cmd1 As New OleDbCommand("select count(*) from tbSupplier where Suppliers=?", con)
        cmd1.Parameters.Add("@Suppliers", OleDbType.VarChar).Value = TextBox1.Text
        Dim count = Convert.ToInt32(cmd1.ExecuteScalar)


            If count > 0 Then

                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "Supplier Already Exist!"
                btn1.Enabled = False

            ElseIf count = 0

                lblStatus.ForeColor = Color.Green
                lblStatus.Text = "Supplier Name is Available"
                btn1.Enabled = True

            End If

        Catch ex As Exception
            Exit Sub
        End Try

        If TextBox1.Text = "" Then
            lblStatus.ResetText()
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim connectionString As String

        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"

        'gawa ng Connection
        Try
            con = New OleDbConnection(connectionString)

        con.Open()

        Dim cmd1 As New OleDbCommand("select count(*) from tbBrand where BrandName=?", con)
        cmd1.Parameters.Add("@BrandName", OleDbType.VarChar).Value = TextBox2.Text
        Dim count = Convert.ToInt32(cmd1.ExecuteScalar)

            If count > 0 Then

                lblstatus1.ForeColor = Color.Red
                lblstatus1.Text = "Brand Already Exist!"
                btn2.Enabled = False

            ElseIf count = 0

                lblstatus1.ForeColor = Color.Green
                lblstatus1.Text = "Brand Name is Available"
                btn2.Enabled = True

            End If

        Catch ex As Exception
            Exit Sub
        End Try

        If TextBox2.Text = "" Then
            lblstatus1.ResetText()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim connectionString As String

        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"

        Try
            'gawa ng Connection
            con = New OleDbConnection(connectionString)

        con.Open()

        Dim cmd1 As New OleDbCommand("select count(*) from tbQuality where ProductQuality=?", con)
        cmd1.Parameters.Add("@ProductQuality", OleDbType.VarChar).Value = TextBox3.Text
        Dim count = Convert.ToInt32(cmd1.ExecuteScalar)

            If count > 0 Then

                lblstatus2.ForeColor = Color.Red
                lblstatus2.Text = "Choosen Quality Already Exist!"
                btn3.Enabled = False

            ElseIf count = 0

                lblstatus2.ForeColor = Color.Green
                lblstatus2.Text = "Quality Name is Available"
                btn3.Enabled = True

            End If

        Catch ex As Exception
            Exit Sub
        End Try

        If TextBox3.Text = "" Then
            lblstatus2.ResetText()
        End If
    End Sub

    Private Sub frmsuppEtc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TextBox1.ResetText()
        lblStatus.ResetText()
        TextBox2.ResetText()
        lblstatus1.ResetText()
        TextBox3.ResetText()
        lblstatus2.ResetText()
        TabControl1.SelectedTab = tbcSuppliers
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String
        Dim c As Integer
        c = AutosupplyDataSet.tbSupplier.Count + 1

        If TextBox1.Text = Nothing Then

            Exit Sub

        Else

            Try
                connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"
                sqlconn.ConnectionString = connString
                sqlquery.Connection = sqlconn

                sqlconn.Open()

                sqlquery.CommandText = "INSERT INTO tbSupplier ([ID], [Suppliers], [Description], [Contact], [Email])
                               VALUES([@ID], [@Suppliers], [@Description], [@Contact], [@Email])"

                sqlquery.Parameters.AddWithValue("[@ID]", c.ToString)
                sqlquery.Parameters.AddWithValue("[@Suppliers]", TextBox1.Text)
                sqlquery.Parameters.AddWithValue("[@Description]", rtbDescription.Text)
                sqlquery.Parameters.AddWithValue("[@Contact]", ContactTextBox.Text)
                sqlquery.Parameters.AddWithValue("[@Email]", EmailTextBox.Text)
                sqlquery.ExecuteNonQuery()
                sqlconn.Close()

                MessageBox.Show("Successfully Added", "Status: Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.ResetText()
                rtbDescription.ResetText()
                ContactTextBox.ResetText()
                EmailTextBox.ResetText()

                TbSupplierTableAdapter.Fill(AutosupplyDataSet.tbSupplier)
                ' frmAdd.TbSupplierTableAdapter.Fill(frmAdd.AutosupplyDataSet.tbSupplier)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please Contact Administrator If You Don't Know How To Fix The Error")
            End Try
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String
        Dim c As Integer
        c = AutosupplyDataSet.tbBrand.Count + 1

        If TextBox2.Text = Nothing Then

            Exit Sub

        Else

            Try
                connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"
                sqlconn.ConnectionString = connString
                sqlquery.Connection = sqlconn

                sqlconn.Open()

                sqlquery.CommandText = "INSERT INTO tbBrand ([ID], [BrandName], [Description])
                               VALUES([@ID], [@BrandName], [@Description])"

                sqlquery.Parameters.AddWithValue("[@ID]", c)
                sqlquery.Parameters.AddWithValue("[@BrandName]", TextBox2.Text)
                sqlquery.Parameters.AddWithValue("[@Description]", rtbBrandDesc.Text)
                sqlquery.ExecuteNonQuery()
                sqlconn.Close()

                MessageBox.Show("Successfully Added", "Status: Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox2.ResetText()
                rtbBrandDesc.ResetText()
                TbBrandTableAdapter.Fill(AutosupplyDataSet.tbBrand)


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please Contact Administrator If You Don't Know How To Fix The Error")
            End Try
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String
        Dim c As Integer
        c = AutosupplyDataSet.tbQuality.Count + 1

        If TextBox3.Text = Nothing Then

            Exit Sub

        Else

            Try
                connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"
                sqlconn.ConnectionString = connString
                sqlquery.Connection = sqlconn

                sqlconn.Open()

                sqlquery.CommandText = "INSERT INTO tbQuality ([ID], [ProductQuality], [Description])
                               VALUES([@ID], [@Suppliers], [@Description])"

                sqlquery.Parameters.AddWithValue("[@ID]", c)
                sqlquery.Parameters.AddWithValue("[@ProductQuality]", TextBox3.Text)
                sqlquery.Parameters.AddWithValue("[@Description]", rtbQualityDesc.Text)
                sqlquery.ExecuteNonQuery()
                sqlconn.Close()

                MessageBox.Show("Successfully Added", "Status: Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox3.ResetText()
                rtbQualityDesc.ResetText()
                TbQualityTableAdapter.Fill(AutosupplyDataSet.tbQuality)
                ' frmAdd.TbSupplierTableAdapter.Fill(frmAdd.AutosupplyDataSet.tbSupplier)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please Contact Administrator If You Don't Know How To Fix The Error")
            End Try
        End If
    End Sub

    Private Sub tbcSuppliers_Click(sender As Object, e As EventArgs) Handles tbcSuppliers.Click

    End Sub

    Private Sub frmsuppEtc_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn1_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn2_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn3_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub
End Class