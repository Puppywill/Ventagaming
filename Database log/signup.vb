Imports MySql.Data.MySqlClient


Public Class signup
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=ventagaming")
    Dim i As Integer





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_return.Click
        If MsgBox("Esta seguro que quiere volver al login??", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Dim loggin As New Form1()
            loggin.Show()
            Me.Hide()
            Me.Close()
        Else
            Return
        End If
    End Sub


    Private Sub Btn_saves_Click(sender As Object, e As EventArgs) Handles Btn_saves.Click
        saves()
    End Sub





    Private Sub saves()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_vendedor`(`Apellidos_paterno`, `Apellidos_materno`, `Nombre`, `Inicial`, `Dirección_Física`, `Dirección_Postal`, `Pueblo`, `Zip_Code`, `Fechainiciotrabajo`, `Número_Celular`, `Email`, `Departamento`, `Espacialidad`, `username`, `password`) VALUES (@Apellidos_paterno, @Apellidos_materno, @Nombre, @Inicial, @Dirección_Física, @Dirección_Postal, @Pueblo, @Zip_Code, @Fechainiciotrabajo, @Número_Celular, @Email, @Departamento, @Espacialidad, @username, @password)", conn)
            cmd.Parameters.Clear()
            'Esto es del apellido que lo pide si esta vacio'
            Dim lastpaterno As String = Txt_apellidopaterno.Text.Trim()

            If String.IsNullOrEmpty(lastpaterno) Then
                MessageBox.Show("El apellido paterno no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not lastpaterno.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El apellido paterno debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Apellidos_paterno", lastpaterno)
            End If


            Dim lastmaterna As String = Txt_apellidomaterno.Text.Trim()
            If String.IsNullOrEmpty(lastmaterna) Then
                MessageBox.Show("El apellido materna no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not lastmaterna.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El apellido materna debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Apellidos_materno", lastmaterna)
            End If

            Dim name As String = Txt_nombre.Text.Trim()
            If String.IsNullOrEmpty(name) Then
                MessageBox.Show("El nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not name.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El nombre debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Nombre", name)
            End If

            Dim inicial As String = Txt_nombreinicial.Text.Trim()
            If String.IsNullOrEmpty(inicial) Then
                MessageBox.Show("El inicial no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not inicial.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El inicial debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Inicial", inicial)
            End If

            Dim dfisica As String = Txt_direccionfisica.Text.Trim()

            If String.IsNullOrEmpty(dfisica) Then
                MessageBox.Show("El direcccion fisica no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not dfisica.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El direccion fisica debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Dirección_Física", dfisica)
            End If


            Dim dportal As String = Txt_direccionpostal.Text.Trim()

            If String.IsNullOrEmpty(dportal) Then
                MessageBox.Show("El direccion postal no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not dportal.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El direccion postal debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Dirección_Postal", dportal)
            End If




            Dim pueblo As String = Txt_pueblo.Text.Trim()

            If String.IsNullOrEmpty(pueblo) Then
                MessageBox.Show("El pueblo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not pueblo.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El pueblo debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Pueblo", pueblo)
            End If

            Dim zipCode As Integer

            If Decimal.TryParse(Txt_zipcode.Text, zipCode) Then
                ' Si la conversión es exitosa, asigna el valor al parámetro del comando.
                cmd.Parameters.AddWithValue("@ZipCode", zipCode)
            Else
                ' Manejar el caso en el que el ZipCode no sea un número entero válido.
                If String.IsNullOrEmpty(Txt_zipcode.Text) Then
                    ' Muestra un mensaje si el ZipCode está vacío.
                    MessageBox.Show("El ZipCode no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Muestra un mensaje si el ZipCode no es un número entero válido.
                    MessageBox.Show("El ZipCode debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                ' Salir del método si hay un error.
                Return
            End If



            cmd.Parameters.AddWithValue("Fechainiciotrabajo", CDate(DateTime.Value))


            cmd.Parameters.AddWithValue("@Número_celular", Txt_celular.Text)


            Dim email As String = Txt_email.Text.Trim

            If String.IsNullOrEmpty(email) Then
                MessageBox.Show("El correo electrónico no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not IsValidEmail(email) OrElse Not email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida de Gmail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Email", email)
            End If


            Dim depart As String = Txt_departamento.Text.Trim()
            If String.IsNullOrEmpty(depart) Then
                MessageBox.Show("El departamento no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not depart.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El departamento debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Departamento", depart)
            End If

            Dim especial As String = Txt_especialida.Text.Trim()
            If String.IsNullOrEmpty(especial) Then
                MessageBox.Show("El espacialidad no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not especial.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El espacialidad debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Espacialidad", especial)
            End If


            If String.IsNullOrEmpty(Txtusername.Text) OrElse String.IsNullOrEmpty(Txtcontrasena.Text) Then
                MessageBox.Show("Debe llenar tanto el nombre de usuario como la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Salir del método si hay campos vacíos
            End If

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record guardado del vendedor!")
            Else
                MessageBox.Show("Record no guardo del vendedp !")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub






    Private Function IsValidEmail(ByVal email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch ex As Exception
            Return False
        End Try

    End Function


End Class