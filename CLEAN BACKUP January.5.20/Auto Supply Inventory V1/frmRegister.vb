Imports System.Data.OleDb
Public Class frmRegister
    Private Sub TbAccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbAccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbAccounts' table. You can move, or remove it, as needed.
        Me.TbAccountsTableAdapter.Fill(Me.AutosupplyDataSet.tbAccounts)

        If Form1.lblType.Text = "ADMIN" Then

            tbcRegister.Enabled = True

        Else

            tbcRegister.Enabled = False

        End If


        TbAccountsBindingSource.Filter = "(Username LIKE'" & Form1.lblName.Text & "')"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReg.Click


        Dim connectionString As String

        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"



        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String

        Try

            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\autosupply.mdb;Persist Security Info=True;Jet OLEDB:Database Password=supply_data"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn

            sqlconn.Open()
            'note always enclose password with [] to avoid syntax error fck :)
            sqlquery.CommandText = "INSERT INTO tbAccounts ([EmployeeID], [LastName], [FirstName], [Contact], Username, [Password], [Type])
                           VALUES([@EmployeeID], [@LastName], [@FirstName], [@Contact], [@Username], [@Password], [@Type])"

            sqlquery.Parameters.AddWithValue("[@EmployeeID]", EmployeeIDTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@LastName]", LastNameTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@FirstName]", FirstNameTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@Contact]", ContactTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@Username]", UsernameTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@Password]", PasswordTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@Type]", ComboBox1.Text)

            sqlquery.ExecuteNonQuery()
            sqlconn.Close()

            ComboBox1.SelectedItem = Nothing
            EmployeeIDTextBox.ResetText()
            LastNameTextBox.ResetText()
            FirstNameTextBox.ResetText()
            ContactTextBox.ResetText()
            UsernameTextBox.ResetText()
            PasswordTextBox.ResetText()
            txtpass.ResetText()
            lblMatch.ResetText()


            MessageBox.Show("User Successfully Added", "Registration Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee ID or Username Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

    End Sub

    Private Sub ContactTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 46 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub EmployeeIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeIDTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 46 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = Nothing Then
            EmployeeIDTextBox.ReadOnly = True

        Else

            EmployeeIDTextBox.ReadOnly = False


        End If
    End Sub

    Private Sub EmployeeIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmployeeIDTextBox.TextChanged
        If EmployeeIDTextBox.TextLength > 0 Then
            LastNameTextBox.ReadOnly = False

        Else
            LastNameTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged
        If LastNameTextBox.TextLength > 0 Then
            FirstNameTextBox.ReadOnly = False

        Else
            FirstNameTextBox.ReadOnly = True
        End If

    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged
        If FirstNameTextBox.TextLength > 0 Then
            ContactTextBox.ReadOnly = False

        Else
            ContactTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub ContactTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactTextBox.TextChanged
        If ContactTextBox.TextLength > 0 Then
            UsernameTextBox.ReadOnly = False

        Else
            UsernameTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        If UsernameTextBox.TextLength > 4 Then
            PasswordTextBox.ReadOnly = False

        Else
            PasswordTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If PasswordTextBox.TextLength > 4 Then
            txtpass.ReadOnly = False

        Else
            txtpass.ReadOnly = True

        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        If txtpass.Text = PasswordTextBox.Text Then
            lblMatch.ForeColor = Color.Green
            lblMatch.Text = "**Password Match**"
            btnReg.Enabled = True
        Else
            lblMatch.ForeColor = Color.Red
            lblMatch.Text = "**Password Doesn't Match**"
            btnReg.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If EmployeeIDTextBox.ReadOnly = True Or LastNameTextBox.ReadOnly = True Or FirstNameTextBox.ReadOnly = True Or ContactTextBox.ReadOnly = True Or
                UsernameTextBox.ReadOnly = True Or PasswordTextBox.ReadOnly = True Or txtpass.ReadOnly = True Then
            btnReg.Enabled = False

        Else
            If lblMatch.ForeColor = Color.Green Then
                btnReg.Enabled = True
            End If
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TbAccountsBindingSource.EndEdit()
            TbAccountsTableAdapter.Update(AutosupplyDataSet.tbAccounts)

            MessageBox.Show("Successfully Updated!", "Changes Has Been Save", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Something Wen't Wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End Try

    End Sub

    Private Sub frmRegister_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Form1.chkNotif.Checked Then
            Form1.Timer2.Enabled = False

        Else
            Form1.Timer2.Enabled = True

        End If
    End Sub

    Private Sub tbcRegister_Click(sender As Object, e As EventArgs) Handles tbcRegister.Click

        If Form1.lblType.Text = "ADMIN" Then

            tbcRegister.Enabled = True

        Else

            tbcRegister.Enabled = False

        End If
    End Sub

    Private Sub frmRegister_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub
End Class