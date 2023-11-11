'William A.Rosado Pérez'
'Y00599440'
'Comp-3900'

Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Cliente
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=ventagaming")
    Dim i As Integer




    Public Sub saves()
        Try
            conn.Open()

            '' Verificar si Txt_id.Text está vacío o no es un número entero válido.
            'If String.IsNullOrEmpty(Txt_id.Text) OrElse Not IsNumeric(Txt_id.Text) Then
            '    MessageBox.Show("El campo ID debe contener un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Return ' Salir del método si hay un error.
            'End If

            'If String.IsNullOrEmpty(Txt_numeroid.Text) OrElse Not IsNumeric(Txt_id.Text) Then
            '    MessageBox.Show("El campo number id debe contener un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Return ' Salir del método si hay un error.
            'End If










            Dim cmd As New MySqlCommand("INSERT INTO `tbl_cliente`(`id_cliente`, `Numero_empleado`, `Apellidos_paterno`, `Apellidos_materna`, `Nombre`, `Inicial`, `Dirección_física`, `Dirección_postal`, `Pueblo`, `Zip_code`, `Fecha_Nacimiento`, `Número_celular`, `Email`, `nombre_compañía`, `Cuota_cliente`, `id_vendedor`) VALUES (@id_cliente, @Numero_empleado, @Apellidos_paterno, @Apellidos_materna, @Nombre, @Inicial, @Dirección_física, @Dirección_postal, @Pueblo, @Zip_code, @Fecha_Nacimiento, @Número_celular, @Email, @nombre_compañía, @Cuota_cliente, @id_vendedor)", conn)

            'cmd.Parameters.AddWithValue("@id_cliente", CInt(Txt_id.Text))
            'cmd.Parameters.AddWithValue("@Numero_empleado", Txt_numeroid.Text)
            'cmd.Parameters.AddWithValue("@Apellidos_paterno", Txt_apellidopaterno.Text)

            'Esto es del apellido que lo pide si esta vacio'
            Dim lastpaterno As String = Txt_apellidopaterno.Text.Trim()

            If String.IsNullOrEmpty(lastpaterno) Then
                MessageBox.Show("El apellido paterno no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not lastpaterno.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El apellido paterno debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Apellidos_paterno", lastpaterno)
            End If

            'Esto del materno lo mismo que hace parterno
            Dim lastmaterno As String = Txt_apellidomaterno.Text.Trim
            If String.IsNullOrEmpty(lastmaterno) Then
                MessageBox.Show("El apellido materno no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not lastpaterno.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El apellido de materno debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Apellidos_materno", lastmaterno)
            End If

            Dim nombre As String = Txt_apellidomaterno.Text.Trim
            If String.IsNullOrEmpty(nombre) Then
                MessageBox.Show("El nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not nombre.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El nombre ddebe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Nombre", nombre)
            End If


            Dim inicial As String = Txt_inicial.Text.Trim
            If String.IsNullOrEmpty(inicial) Then
                MessageBox.Show("La inicial no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not nombre.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("La inicial debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Inicial", nombre)
            End If

            Dim derfisica As String = Txt_direccionfisica.Text.Trim
            If String.IsNullOrEmpty(derfisica) Then
                MessageBox.Show("La direccion fisica no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not derfisica.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("La direccion fisica debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Direccion_física", derfisica)
            End If

            Dim derpost As String = Txt_direccionpostal.Text.Trim
            If String.IsNullOrEmpty(derpost) Then
                MessageBox.Show("La direccion postal no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not derpost.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("La direccion postal debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Direccion_postal", derpost)
            End If



            Dim pueblo As String = Txt_pueblo.Text.Trim
            If String.IsNullOrEmpty(pueblo) Then
                MessageBox.Show("El pueblo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not derpost.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El pueblo debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Pueblo", pueblo)
            End If


            'cmd.Parameters.AddWithValue("@Apellidos_materna", Txt_apellidomaterno.Text)
            'cmd.Parameters.AddWithValue("@Nombre", Txt_nombre.Text)
            'cmd.Parameters.AddWithValue("@Inicial", Txt_inicial.Text)
            'cmd.Parameters.AddWithValue("@Dirección_física", Txt_direccionfisica.Text)
            'cmd.Parameters.AddWithValue("@Dirección_postal", Txt_direccionpostal.Text)
            'cmd.Parameters.AddWithValue("@Pueblo", Txt_pueblo.Text)

            ' Asegurarse de que el Zip Code sea un número.
            Dim zipCode As Integer
            If Integer.TryParse(Txt_zipcode.Text, zipCode) Then
                cmd.Parameters.AddWithValue("@Zip_code", zipCode)
            Else
                ' Manejar el caso en el que el Zip Code no sea un número válido.
                MessageBox.Show("El código postal debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Salir del método si hay un error.
            End If



            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", CDate(DateTime.Value.Date))



            cmd.Parameters.AddWithValue("@Número_celular", Txt_celular.Text)

            'cmd.Parameters.AddWithValue("@Email", Txt_email.Text)



            'Esto es del correo cuando esta vacio
            Dim email As String = Txt_email.Text.Trim

            If String.IsNullOrEmpty(email) Then
                MessageBox.Show("El correo electrónico no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not IsValidEmail(email) OrElse Not email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida de Gmail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Email", email)
            End If







            Dim nombrecompañia As String = Txt_nombrecompañia.Text.Trim
            If String.IsNullOrEmpty(nombrecompañia) Then
                MessageBox.Show("El nombre de la compañia no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not derpost.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El nombre de la compañia debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@nombre_compañia", pueblo)
            End If


            'cmd.Parameters.AddWithValue("@nombre_compañía", Txt_nombrecompañia.Text)

            ' Asegurarse de que la Cuota del cliente sea un número decimal.
            Dim cuotaCliente As Decimal

            If Decimal.TryParse(Txt_coutacliente.Text, cuotaCliente) Then
                cmd.Parameters.AddWithValue("@Cuota_cliente", cuotaCliente)
            Else
                ' Manejar el caso en el que la cuota del cliente no sea un número decimal válido.
                If String.IsNullOrEmpty(Txt_coutacliente.Text) Then
                    MessageBox.Show("La cuota del cliente no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("La cuota del cliente debe ser un número decimal válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Return ' Salir del método si hay un error.
            End If




            i = cmd.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("Registro de cliente fue salvado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Registro de cliente no fue salvado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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






    Public Sub clear()
        'Txt_numeroid.Clear()
        Txt_apellidopaterno.Clear()
        Txt_apellidomaterno.Clear()
        Txt_nombre.Clear()
        Txt_inicial.Clear()
        Txt_direccionfisica.Clear()
        Txt_direccionpostal.Clear()
        Txt_pueblo.Clear()
        Txt_zipcode.Clear()
        DateTime.Value = Now
        Txt_celular.Clear()
        Txt_email.Clear()
        Txt_nombrecompañia.Clear()
        Txt_coutacliente.Clear()
        'Txt_numeroid.ReadOnly = False
        Btn_saves.Enabled = True
    End Sub












    'El boton para regresar al login'
    Private Sub Btn_return_Click(sender As Object, e As EventArgs) Handles Btn_return.Click


        ' Si el usuario es un cliente, muestra el formulario del cliente y cierra el formulario actual

        vendedor.Show()
        Me.Hide()
    End Sub


    'El boton de save'
    Private Sub Btn_saves_Click(sender As Object, e As EventArgs) Handles Btn_saves.Click
        saves()

    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        clear()
        'If String.IsNullOrEmpty(Txt_id.Text) AndAlso String.IsNullOrEmpty(Txt_numeroid.Text) AndAlso String.IsNullOrEmpty(Txt_apellidopaterno.Text) AndAlso String.IsNullOrEmpty(Txt_apellidomaterno.Text) AndAlso String.IsNullOrEmpty(Txt_celular.Text) AndAlso String.IsNullOrEmpty(Txt_coutacliente.Text) AndAlso String.IsNullOrEmpty(Txt_direccionfisica.Text) AndAlso String.IsNullOrEmpty(Txt_direccionpostal.Text) AndAlso String.IsNullOrEmpty(Txt_email.Text) AndAlso String.IsNullOrEmpty(Txt_inicial.Text) AndAlso String.IsNullOrEmpty(Txt_nombre.Text) AndAlso String.IsNullOrEmpty(Txt_nombrecompañia.Text) AndAlso String.IsNullOrEmpty(Txt_pueblo.Text) AndAlso String.IsNullOrEmpty(Txt_zipcode.Text) Then

        '    MessageBox.Show("No se limpio porque tienes los campo vacio", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Question)


        'Else
        '    MessageBox.Show("Se limpio", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Txt_apellidomaterno.Clear()
        '    Txt_apellidopaterno.Clear()
        '    Txt_celular.Clear()
        '    Txt_coutacliente.Clear()
        '    Txt_direccionfisica.Clear()
        '    Txt_direccionpostal.Clear()
        '    Txt_email.Clear()
        '    Txt_id.Clear()
        '    Txt_inicial.Clear()
        '    Txt_nombrecompañia.Clear()
        '    Txt_numeroid.Clear()
        '    Txt_pueblo.Clear()
        '    Txt_zipcode.Clear()

        'End If
    End Sub


End Class