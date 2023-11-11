<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forget_password
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_back = New System.Windows.Forms.Button()
        Me.Btn_clear = New System.Windows.Forms.Button()
        Me.Btn_saves = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Txtcontrasena = New System.Windows.Forms.TextBox()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox2.BackgroundImage = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Btn_back)
        Me.GroupBox2.Controls.Add(Me.Btn_clear)
        Me.GroupBox2.Controls.Add(Me.Btn_saves)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Txtcontrasena)
        Me.GroupBox2.Controls.Add(Me.Txtusername)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(208, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 140)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login"
        '
        'Btn_back
        '
        Me.Btn_back.Location = New System.Drawing.Point(281, 102)
        Me.Btn_back.Name = "Btn_back"
        Me.Btn_back.Size = New System.Drawing.Size(72, 32)
        Me.Btn_back.TabIndex = 7
        Me.Btn_back.Text = "Back"
        Me.Btn_back.UseVisualStyleBackColor = True
        '
        'Btn_clear
        '
        Me.Btn_clear.Location = New System.Drawing.Point(141, 102)
        Me.Btn_clear.Name = "Btn_clear"
        Me.Btn_clear.Size = New System.Drawing.Size(93, 32)
        Me.Btn_clear.TabIndex = 6
        Me.Btn_clear.Text = "Clear"
        Me.Btn_clear.UseVisualStyleBackColor = True
        '
        'Btn_saves
        '
        Me.Btn_saves.Location = New System.Drawing.Point(19, 102)
        Me.Btn_saves.Name = "Btn_saves"
        Me.Btn_saves.Size = New System.Drawing.Size(72, 32)
        Me.Btn_saves.TabIndex = 5
        Me.Btn_saves.Text = "Saves"
        Me.Btn_saves.UseVisualStyleBackColor = True
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
        'Txtcontrasena
        '
        Me.Txtcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcontrasena.Location = New System.Drawing.Point(92, 49)
        Me.Txtcontrasena.Name = "Txtcontrasena"
        Me.Txtcontrasena.Size = New System.Drawing.Size(233, 20)
        Me.Txtcontrasena.TabIndex = 3
        Me.Txtcontrasena.UseSystemPasswordChar = True
        '
        'Txtusername
        '
        Me.Txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusername.Location = New System.Drawing.Point(92, 23)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(233, 20)
        Me.Txtusername.TabIndex = 2
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 27)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Forget Password"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.PictureBox2.Location = New System.Drawing.Point(65, 153)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'forget_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ventagaming.My.Resources.Resources.gaming_logo_4x
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "forget_password"
        Me.Text = "forget_password"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_back As Button
    Friend WithEvents Btn_clear As Button
    Friend WithEvents Btn_saves As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txtcontrasena As TextBox
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
