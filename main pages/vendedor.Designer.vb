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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vendedor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_logout = New System.Windows.Forms.Button()
        Me.Excel = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_addcliente = New System.Windows.Forms.Button()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Data = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_search = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Btn_logout)
        Me.GroupBox1.Controls.Add(Me.Excel)
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
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
        'Excel
        '
        Me.Excel.Location = New System.Drawing.Point(0, 81)
        Me.Excel.Name = "Excel"
        Me.Excel.Size = New System.Drawing.Size(219, 25)
        Me.Excel.TabIndex = 3
        Me.Excel.Text = "Excel"
        Me.Excel.UseVisualStyleBackColor = True
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
        Me.Lbl_Titulo.Location = New System.Drawing.Point(357, 9)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(63, 20)
        Me.Lbl_Titulo.TabIndex = 1
        Me.Lbl_Titulo.Text = "Label1"
        '
        'Data
        '
        Me.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data.Location = New System.Drawing.Point(234, 61)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(554, 234)
        Me.Data.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lime
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search:"
        '
        'Txt_search
        '
        Me.Txt_search.Location = New System.Drawing.Point(311, 312)
        Me.Txt_search.Name = "Txt_search"
        Me.Txt_search.Size = New System.Drawing.Size(417, 20)
        Me.Txt_search.TabIndex = 4
        '
        'vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ventagaming.My.Resources.Resources.green_windows_11_logo_in_green_background_4k_hd_windows_11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Txt_search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Data)
        Me.Controls.Add(Me.Lbl_Titulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vendedor"
        Me.Text = "vendedor"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_addcliente As Button
    Friend WithEvents Btn_logout As Button
    Friend WithEvents Excel As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Data As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_search As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
