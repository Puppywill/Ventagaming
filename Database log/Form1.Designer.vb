<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Txtcontrasena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_clear = New System.Windows.Forms.Button()
        Me.lbl_forgetpassword = New System.Windows.Forms.LinkLabel()
        Me.Btn_cloase = New System.Windows.Forms.Button()
        Me.Btn_signup = New System.Windows.Forms.Button()
        Me.Btn_login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'Txtusername
        '
        Me.Txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusername.Location = New System.Drawing.Point(92, 23)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(233, 20)
        Me.Txtusername.TabIndex = 2
        '
        'Txtcontrasena
        '
        Me.Txtcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcontrasena.Location = New System.Drawing.Point(92, 49)
        Me.Txtcontrasena.Name = "Txtcontrasena"
        Me.Txtcontrasena.Size = New System.Drawing.Size(233, 20)
        Me.Txtcontrasena.TabIndex = 3
        Me.Txtcontrasena.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(324, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.BackgroundImage = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(70, 327)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 135)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Red
        Me.RichTextBox1.Location = New System.Drawing.Point(15, 32)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(672, 97)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox2.BackgroundImage = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Btn_clear)
        Me.GroupBox2.Controls.Add(Me.lbl_forgetpassword)
        Me.GroupBox2.Controls.Add(Me.Btn_cloase)
        Me.GroupBox2.Controls.Add(Me.Btn_signup)
        Me.GroupBox2.Controls.Add(Me.Btn_login)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Txtcontrasena)
        Me.GroupBox2.Controls.Add(Me.Txtusername)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(276, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 178)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login"
        '
        'Btn_clear
        '
        Me.Btn_clear.Location = New System.Drawing.Point(79, 141)
        Me.Btn_clear.Name = "Btn_clear"
        Me.Btn_clear.Size = New System.Drawing.Size(72, 32)
        Me.Btn_clear.TabIndex = 9
        Me.Btn_clear.Text = "Clear"
        Me.Btn_clear.UseVisualStyleBackColor = True
        '
        'lbl_forgetpassword
        '
        Me.lbl_forgetpassword.AutoSize = True
        Me.lbl_forgetpassword.BackColor = System.Drawing.Color.Black
        Me.lbl_forgetpassword.LinkColor = System.Drawing.Color.Red
        Me.lbl_forgetpassword.Location = New System.Drawing.Point(117, 72)
        Me.lbl_forgetpassword.Name = "lbl_forgetpassword"
        Me.lbl_forgetpassword.Size = New System.Drawing.Size(174, 20)
        Me.lbl_forgetpassword.TabIndex = 8
        Me.lbl_forgetpassword.TabStop = True
        Me.lbl_forgetpassword.Text = "Forget Passoword??"
        '
        'Btn_cloase
        '
        Me.Btn_cloase.Location = New System.Drawing.Point(202, 141)
        Me.Btn_cloase.Name = "Btn_cloase"
        Me.Btn_cloase.Size = New System.Drawing.Size(83, 32)
        Me.Btn_cloase.TabIndex = 7
        Me.Btn_cloase.Text = "Close"
        Me.Btn_cloase.UseVisualStyleBackColor = True
        '
        'Btn_signup
        '
        Me.Btn_signup.Location = New System.Drawing.Point(198, 102)
        Me.Btn_signup.Name = "Btn_signup"
        Me.Btn_signup.Size = New System.Drawing.Size(87, 32)
        Me.Btn_signup.TabIndex = 6
        Me.Btn_signup.Text = "SignUp"
        Me.Btn_signup.UseVisualStyleBackColor = True
        '
        'Btn_login
        '
        Me.Btn_login.Location = New System.Drawing.Point(79, 102)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(72, 32)
        Me.Btn_login.TabIndex = 5
        Me.Btn_login.Text = "Enter"
        Me.Btn_login.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.PictureBox1.Location = New System.Drawing.Point(-307, -167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(250, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(295, 27)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Bienvenido a Ventagaming"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.PictureBox2.Location = New System.Drawing.Point(133, 130)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 178)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImage = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 522)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Ventagaming"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents Txtcontrasena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_login As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Btn_cloase As Button
    Friend WithEvents Btn_signup As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_forgetpassword As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_clear As Button
End Class
