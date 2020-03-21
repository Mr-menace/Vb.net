Imports System.Data.OleDb
Public Class frmLogin

    Dim con As New OleDbConnection

    Dim trial As Integer = 5

    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        MyBase.WndProc(m)
    End Sub


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutosupplyDataSet.tbtime' table. You can move, or remove it, as needed.
        Me.TbtimeTableAdapter.Fill(Me.AutosupplyDataSet.tbtime)


        'Dim intWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        'Dim intHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        'If intWidth < 1024 AndAlso intHeight < 768 Then
        'Messagebox with 0 & 1 feature
        '    MsgBox(String.Format("Your screen resolution must be at least '1024x768' where you are currently at {0}x{1}. If you need assistance changing your resolution then contact the Help desk. Press Okay to exit the application.", intWidth, intHeight))
        '    e.Cancel = True
        'End If

        'Detect the Resolution 
        Dim intWidth As Integer = My.Computer.Screen.Bounds.Width
        Dim intHeight As Integer = My.Computer.Screen.Bounds.Height

        If intWidth <> 1280 AndAlso intHeight <> 960 Then
            If (MessageBox.Show("Your Screen Resolution Must be At Least '1280x960' Where You Are Currently At" & " {" & intWidth & "X" & intHeight & "} " & ". When you Proceed Without Changing to Recommended Display There is a Big Chance That the System Display are Disagreeable. If You Need Help on Changing The Screen Resolution Please Contact Administrator Do you want to Proceed?.", "Incompatible Resolution Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.No) Then
                Me.Close()

            Else
                'if you click proceed without changing display then go to Line Yes
                GoTo Yes
            End If

        Else
            ' MessageBox.Show(My.Computer.Screen.Bounds.Size.ToString)
Yes:
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


            If lbltimer.Text <> 60 Then
                txtUser.Enabled = False
                txtPassword.Enabled = False
                Timer1.Enabled = True
            End If
        End If

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If


        If e.KeyCode = Keys.Enter Then

            Try

                Dim query As String = "SELECT * FROM tbAccounts WHERE  Username = '" & Me.txtUser.Text & "' AND Password = '" & Me.txtPassword.Text & "'"

                Dim cmd As OleDbCommand = New OleDbCommand(query, con)

                'create data reader
                Dim read As OleDbDataReader = cmd.ExecuteReader

                read.Read()
                If read.HasRows = True Then


                    Dim Username As String = read(Convert.ToString("Username"))
                    Dim Password As String = read(Convert.ToString("Password"))

                    Form1.TbAccountsBindingSource.Filter = "(Username LIKE '" & txtUser.Text & "') AND(Password LIKE '" & txtPassword.Text & "')"
                    Form1.Show()
                    Me.Hide()


                    txtUser.ResetText()
                    txtPassword.ResetText()
                    trial = 5
                    Me.Hide()
                    con.Close()
                Else

                    trial = trial - 1
                    If trial < 0 Then
                        MessageBox.Show("You've Reach The Maximum Attempts To Login, Please Try Again", "Failed to Login")
                        txtUser.Enabled = False
                        txtPassword.Enabled = False

                        Timer1.Enabled = True
                        txtPassword.ResetText()
                    Else
                        txtPassword.ResetText()
                        MessageBox.Show("Account Doesn't Exist!" & vbNewLine & "Remaining Trials: " & trial & "/5", "Please Confirm Your Account is Registered", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                    End If
                End If

                If trial = 0 Then

                    MessageBox.Show("You've Reach The Maximum Attempts To Login, Please Try Again", "Failed to Login")
                    txtUser.Enabled = False
                    txtPassword.Enabled = False

                    Timer1.Enabled = True
                    txtPassword.ResetText()
                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            txtPassword.PasswordChar = Nothing
        Else
            txtPassword.PasswordChar = "*"
        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltimer.Text = Val(lbltimer.Text) - 1
        TbtimeBindingSource.EndEdit()
        TbtimeTableAdapter.Update(AutosupplyDataSet.tbtime)

        Me.Text = "Authentication Required " & " Try Again After: " & lbltimer.Text & " Second(s)"

        If lbltimer.Text = 0 Then
            Timer1.Enabled = False
            lbltimer.Text = "60"
            TbtimeBindingSource.EndEdit()
            TbtimeTableAdapter.Update(AutosupplyDataSet.tbtime)
            txtUser.Enabled = True
            txtPassword.Enabled = True
            Me.Text = "Authentication Required"

        End If
    End Sub

    Private Sub TbtimeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbtimeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AutosupplyDataSet)

    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class