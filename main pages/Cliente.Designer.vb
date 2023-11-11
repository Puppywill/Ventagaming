<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_return = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_clear = New System.Windows.Forms.Button()
        Me.Btn_saves = New System.Windows.Forms.Button()
        Me.Txt_coutacliente = New System.Windows.Forms.TextBox()
        Me.Txt_nombrecompañia = New System.Windows.Forms.TextBox()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.Txt_celular = New System.Windows.Forms.TextBox()
        Me.Txt_zipcode = New System.Windows.Forms.TextBox()
        Me.Txt_pueblo = New System.Windows.Forms.TextBox()
        Me.Txt_direccionpostal = New System.Windows.Forms.TextBox()
        Me.Txt_direccionfisica = New System.Windows.Forms.TextBox()
        Me.Txt_inicial = New System.Windows.Forms.TextBox()
        Me.Txt_nombre = New System.Windows.Forms.TextBox()
        Me.Txt_apellidomaterno = New System.Windows.Forms.TextBox()
        Me.Txt_apellidopaterno = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(358, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Btn_return)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Txt_coutacliente)
        Me.GroupBox1.Controls.Add(Me.Txt_nombrecompañia)
        Me.GroupBox1.Controls.Add(Me.Txt_email)
        Me.GroupBox1.Controls.Add(Me.DateTime)
        Me.GroupBox1.Controls.Add(Me.Txt_celular)
        Me.GroupBox1.Controls.Add(Me.Txt_zipcode)
        Me.GroupBox1.Controls.Add(Me.Txt_pueblo)
        Me.GroupBox1.Controls.Add(Me.Txt_direccionpostal)
        Me.GroupBox1.Controls.Add(Me.Txt_direccionfisica)
        Me.GroupBox1.Controls.Add(Me.Txt_inicial)
        Me.GroupBox1.Controls.Add(Me.Txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Txt_apellidomaterno)
        Me.GroupBox1.Controls.Add(Me.Txt_apellidopaterno)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(164, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 354)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Btn_return
        '
        Me.Btn_return.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_return.Location = New System.Drawing.Point(357, 269)
        Me.Btn_return.Name = "Btn_return"
        Me.Btn_return.Size = New System.Drawing.Size(131, 68)
        Me.Btn_return.TabIndex = 4
        Me.Btn_return.Text = "Return"
        Me.Btn_return.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Btn_clear)
        Me.GroupBox2.Controls.Add(Me.Btn_saves)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(9, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 99)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Botones"
        '
        'Btn_clear
        '
        Me.Btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_clear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_clear.Location = New System.Drawing.Point(145, 37)
        Me.Btn_clear.Name = "Btn_clear"
        Me.Btn_clear.Size = New System.Drawing.Size(88, 34)
        Me.Btn_clear.TabIndex = 4
        Me.Btn_clear.Text = "Clear"
        Me.Btn_clear.UseVisualStyleBackColor = False
        '
        'Btn_saves
        '
        Me.Btn_saves.BackColor = System.Drawing.Color.YellowGreen
        Me.Btn_saves.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_saves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_saves.Location = New System.Drawing.Point(34, 37)
        Me.Btn_saves.Name = "Btn_saves"
        Me.Btn_saves.Size = New System.Drawing.Size(88, 34)
        Me.Btn_saves.TabIndex = 3
        Me.Btn_saves.Text = "Saves"
        Me.Btn_saves.UseVisualStyleBackColor = False
        '
        'Txt_coutacliente
        '
        Me.Txt_coutacliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_coutacliente.Location = New System.Drawing.Point(121, 139)
        Me.Txt_coutacliente.Name = "Txt_coutacliente"
        Me.Txt_coutacliente.Size = New System.Drawing.Size(102, 20)
        Me.Txt_coutacliente.TabIndex = 28
        '
        'Txt_nombrecompañia
        '
        Me.Txt_nombrecompañia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_nombrecompañia.Location = New System.Drawing.Point(121, 113)
        Me.Txt_nombrecompañia.Name = "Txt_nombrecompañia"
        Me.Txt_nombrecompañia.Size = New System.Drawing.Size(102, 20)
        Me.Txt_nombrecompañia.TabIndex = 27
        '
        'Txt_email
        '
        Me.Txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_email.Location = New System.Drawing.Point(93, 90)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(140, 20)
        Me.Txt_email.TabIndex = 26
        '
        'DateTime
        '
        Me.DateTime.Location = New System.Drawing.Point(149, 47)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(123, 20)
        Me.DateTime.TabIndex = 2
        '
        'Txt_celular
        '
        Me.Txt_celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_celular.Location = New System.Drawing.Point(144, 69)
        Me.Txt_celular.Name = "Txt_celular"
        Me.Txt_celular.Size = New System.Drawing.Size(102, 20)
        Me.Txt_celular.TabIndex = 25
        '
        'Txt_zipcode
        '
        Me.Txt_zipcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_zipcode.Location = New System.Drawing.Point(333, 161)
        Me.Txt_zipcode.Name = "Txt_zipcode"
        Me.Txt_zipcode.Size = New System.Drawing.Size(102, 20)
        Me.Txt_zipcode.TabIndex = 23
        '
        'Txt_pueblo
        '
        Me.Txt_pueblo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_pueblo.Location = New System.Drawing.Point(329, 132)
        Me.Txt_pueblo.Name = "Txt_pueblo"
        Me.Txt_pueblo.Size = New System.Drawing.Size(102, 20)
        Me.Txt_pueblo.TabIndex = 22
        '
        'Txt_direccionpostal
        '
        Me.Txt_direccionpostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_direccionpostal.Location = New System.Drawing.Point(333, 106)
        Me.Txt_direccionpostal.Name = "Txt_direccionpostal"
        Me.Txt_direccionpostal.Size = New System.Drawing.Size(223, 20)
        Me.Txt_direccionpostal.TabIndex = 21
        '
        'Txt_direccionfisica
        '
        Me.Txt_direccionfisica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_direccionfisica.Location = New System.Drawing.Point(333, 85)
        Me.Txt_direccionfisica.Name = "Txt_direccionfisica"
        Me.Txt_direccionfisica.Size = New System.Drawing.Size(223, 20)
        Me.Txt_direccionfisica.TabIndex = 20
        '
        'Txt_inicial
        '
        Me.Txt_inicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_inicial.Location = New System.Drawing.Point(144, 21)
        Me.Txt_inicial.Name = "Txt_inicial"
        Me.Txt_inicial.Size = New System.Drawing.Size(70, 20)
        Me.Txt_inicial.TabIndex = 19
        '
        'Txt_nombre
        '
        Me.Txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_nombre.Location = New System.Drawing.Point(386, 64)
        Me.Txt_nombre.Name = "Txt_nombre"
        Me.Txt_nombre.Size = New System.Drawing.Size(164, 20)
        Me.Txt_nombre.TabIndex = 18
        '
        'Txt_apellidomaterno
        '
        Me.Txt_apellidomaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_apellidomaterno.Location = New System.Drawing.Point(386, 42)
        Me.Txt_apellidomaterno.Name = "Txt_apellidomaterno"
        Me.Txt_apellidomaterno.Size = New System.Drawing.Size(164, 20)
        Me.Txt_apellidomaterno.TabIndex = 17
        '
        'Txt_apellidopaterno
        '
        Me.Txt_apellidopaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_apellidopaterno.Location = New System.Drawing.Point(386, 16)
        Me.Txt_apellidopaterno.Name = "Txt_apellidopaterno"
        Me.Txt_apellidopaterno.Size = New System.Drawing.Size(164, 20)
        Me.Txt_apellidopaterno.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "CuotaCliente:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "NombreCompañia:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(48, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Email:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(50, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "NumeroCelular:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Fechnacimiento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(273, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Zipcode:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(273, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Pueblo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(239, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "DireccionPostal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "DireccionFisica:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Inicial:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(280, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ApellidoMaterno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ApellidoPaterno:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.PictureBox2.Location = New System.Drawing.Point(11, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 354)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.PictureBox1.Location = New System.Drawing.Point(720, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 354)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.ClientSize = New System.Drawing.Size(895, 521)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents DateTime As DateTimePicker
    Friend WithEvents Txt_celular As TextBox
    Friend WithEvents Txt_zipcode As TextBox
    Friend WithEvents Txt_pueblo As TextBox
    Friend WithEvents Txt_direccionpostal As TextBox
    Friend WithEvents Txt_direccionfisica As TextBox
    Friend WithEvents Txt_inicial As TextBox
    Friend WithEvents Txt_nombre As TextBox
    Friend WithEvents Txt_apellidomaterno As TextBox
    Friend WithEvents Txt_apellidopaterno As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Txt_coutacliente As TextBox
    Friend WithEvents Txt_nombrecompañia As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_clear As Button
    Friend WithEvents Btn_saves As Button
    Friend WithEvents Btn_return As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
