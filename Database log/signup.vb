Imports MySql.Data.MySqlClient


Public Class signup
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=ventagaming2")
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
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_vendedor`(`Apellido_paterno`, `Apellido_materno`, `Nombre`, `Inicial`, `Direccion_Física`, `Direccion_Postal`, `Pueblo`, `Zip_code`, `Fechainiciotrabajo`, `Numero_Celular`, `Email`, `Departamento`, `Espacialidad`, `username`, `password`) VALUES (@Apellido_paterno, @Apellido_materno, @Nombre, @Inicial, @Direccion_Física, @Direccion_Postal, @Pueblo, @Zip_Code, @Fechainiciotrabajo, @Numero_Celular, @Email, @Departamento, @Espacialidad, @username, @password)", conn)


            Dim apellido_paterno As String = Txt_apellidopaterno.Text.Trim()

            If String.IsNullOrEmpty(apellido_paterno) Then
                MessageBox.Show("El apellido paterno no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not apellido_paterno.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El apellido paterno debe contener solo letras y/o dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Apellido_paterno", apellido_paterno)
            End If


            Dim lastmaterna As String = Txt_apellidomaterno.Text.Trim()
            If String.IsNullOrEmpty(lastmaterna) Then
                MessageBox.Show("El apellido materna no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not lastmaterna.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El apellido materna debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Apellido_materno", lastmaterna)
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

            Else
                cmd.Parameters.AddWithValue("@Direccion_Física", dfisica)
            End If


            Dim dportal As String = Txt_direccionpostal.Text.Trim()

            If String.IsNullOrEmpty(dportal) Then
                MessageBox.Show("El direccion postal no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                cmd.Parameters.AddWithValue("@Direccion_Postal", dportal)
            End If



            Dim pueblo As String = Txt_pueblo.Text.Trim()

            If String.IsNullOrEmpty(pueblo) Then
                MessageBox.Show("El pueblo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            Else
                cmd.Parameters.AddWithValue("@Pueblo", pueblo)
            End If



            Dim zipCode As Integer

            If Decimal.TryParse(Txt_zipcode.Text, zipCode) Then
                ' Si la conversión es exitosa, asigna el valor al parámetro del comando.
                cmd.Parameters.AddWithValue("@Zip_Code", zipCode)
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





            cmd.Parameters.AddWithValue("Numero_Celular", Txt_celular.Text)




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

            Else
                cmd.Parameters.AddWithValue("@Departamento", depart)
            End If

            Dim especial As String = Txt_especialida.Text.Trim()
            If String.IsNullOrEmpty(especial) Then
                MessageBox.Show("El espacialidad no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                cmd.Parameters.AddWithValue("@Espacialidad", especial)
            End If



            cmd.Parameters.AddWithValue("Fechainiciotrabajo", CDate(Fcht.Value))

            Dim username As String = Txt_username.Text.Trim()
            If String.IsNullOrEmpty(username) Then
                MessageBox.Show("El Username no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                cmd.Parameters.AddWithValue("@username", username)
            End If

            Dim contrasena As String = Txt_contrasena.Text.Trim()
            If String.IsNullOrEmpty(username) Then
                MessageBox.Show("La contraseña no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                cmd.Parameters.AddWithValue("@password", contrasena)
            End If








            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("El Record del vendedor fue guardado !", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            Else
                MessageBox.Show("El Record del vendedor no fue guardado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        If CamposLlenos() Then
            clear()
            MessageBox.Show("Se han limpiado los campos.", "Limpiar campos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se pueden limpiar porque los estan campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Public Sub clear()
        Txt_apellidopaterno.Clear()
        Txt_apellidomaterno.Clear()
        Txt_celular.Clear()
        Txt_contrasena.Clear()
        Txt_departamento.Clear()
        Txt_direccionfisica.Clear()
        Txt_direccionpostal.Clear()
        Txt_email.Clear()
        Txt_especialida.Clear()
        Txt_nombre.Clear()
        Txt_nombreinicial.Clear()
        Txt_pueblo.Clear()
        Txt_username.Clear()
        Txt_zipcode.Clear()

    End Sub

    Private Function CamposLlenos() As Boolean
        ' Verificar si al menos un campo de texto está lleno
        Return Txt_apellidopaterno.Text <> "" OrElse
               Txt_apellidomaterno.Text <> "" OrElse
               Txt_celular.Text <> "" OrElse
               Txt_contrasena.Text <> "" OrElse
               Txt_departamento.Text <> "" OrElse
               Txt_direccionfisica.Text <> "" OrElse
               Txt_direccionpostal.Text <> "" OrElse
               Txt_email.Text <> "" OrElse
               Txt_especialida.Text <> "" OrElse
               Txt_nombre.Text <> "" OrElse
               Txt_nombreinicial.Text <> "" OrElse
               Txt_pueblo.Text <> "" OrElse
               Txt_username.Text <> "" OrElse
               Txt_zipcode.Text <> ""
    End Function

End Class