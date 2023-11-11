<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vendedor
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_logout = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_addcliente = New System.Windows.Forms.Button()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.Btn_logout)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_addcliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "vendedor Opcions "
        '
        'Btn_logout
        '
        Me.Btn_logout.Location = New System.Drawing.Point(0, 112)
        Me.Btn_logout.Name = "Btn_logout"
        Me.Btn_logout.Size = New System.Drawing.Size(219, 25)
        Me.Btn_logout.TabIndex = 4
        Me.Btn_logout.Text = "Logout"
        Me.Btn_logout.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(0, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(219, 25)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "About"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(0, 50)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(219, 25)
        Me.btn_update.TabIndex = 2
        Me.btn_update.Text = "Edit"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_addcliente
        '
        Me.btn_addcliente.Location = New System.Drawing.Point(0, 19)
        Me.btn_addcliente.Name = "btn_addcliente"
        Me.btn_addcliente.Size = New System.Drawing.Size(219, 25)
        Me.btn_addcliente.TabIndex = 1
        Me.btn_addcliente.Text = "Add Client"
        Me.btn_addcliente.UseVisualStyleBackColor = True
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.BackColor = System.Drawing.Color.Lime
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(270, 9)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(63, 20)
        Me.Lbl_Titulo.TabIndex = 1
        Me.Lbl_Titulo.Text = "Label1"
        '
        'vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ventagaming.My.Resources.Resources.green_windows_11_logo_in_green_background_4k_hd_windows_11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Titulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vendedor"
        Me.Text = "vendedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_addcliente As Button
    Friend WithEvents Btn_logout As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Lbl_Titulo As Label
End Class
