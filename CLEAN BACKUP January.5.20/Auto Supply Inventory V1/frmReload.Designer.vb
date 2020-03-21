<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReload
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rtbReload = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbReload
        '
        Me.rtbReload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbReload.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbReload.Location = New System.Drawing.Point(0, 0)
        Me.rtbReload.Name = "rtbReload"
        Me.rtbReload.Size = New System.Drawing.Size(658, 618)
        Me.rtbReload.TabIndex = 0
        Me.rtbReload.Text = ""
        '
        'frmReload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 618)
        Me.Controls.Add(Me.rtbReload)
        Me.Name = "frmReload"
        Me.Text = "Reload View"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbReload As RichTextBox
End Class
