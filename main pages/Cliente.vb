'William A.Rosado Pérez'
'Y00599440'
'Comp-3900'

Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Cliente
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=ventagaming2")
    Dim i As Integer
    Property venderdorid As Integer
    Private lol As New vendedor

    Public Sub saves()


        Try
            conn.Open()

            Dim cmd As New MySqlCommand("INSERT INTO `tbl_cliente` (`Apellido_paterno`, `Apellidos_materna`, `Nombre`, `Inicial`, `Dirección_fisica`, `Dirección_postal`, `Pueblo`, `Zip_code`, `Fecha_nacimiento`, `Numero_celular`, `Email`, `Nombre_compañía`, `Cuota_cliente`,`id_vendedor`) VALUES (@Apellido_paterno, @Apellidos_materna, @Nombre, @Inicial, @Dirección_fisica, @Dirección_postal, @Pueblo, @Zip_code, @Fecha_Nacimiento, @Numero_celular, @Email, @Nombre_compañía, @Cuota_cliente,@id_vendedor)", conn)


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
                cmd.Parameters.AddWithValue("@Apellidos_materna", lastmaterna)
            End If

            Dim name As String = Txt_nombre.Text.Trim()
            If String.IsNullOrEmpty(name) Then
                MessageBox.Show("El nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not name.All(Function(c) Char.IsLetterOrDigit(c)) Then
                MessageBox.Show("El nombre debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Nombre", name)
            End If

            Dim inicial As String = Txt_inicial.Text.Trim()
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
                cmd.Parameters.AddWithValue("@Dirección_fisica", dfisica)
            End If

            Dim dportal As String = Txt_direccionpostal.Text.Trim()

            If String.IsNullOrEmpty(dportal) Then
                MessageBox.Show("El direccion postal no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                cmd.Parameters.AddWithValue("@Dirección_postal", dportal)
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
                cmd.Parameters.AddWithValue("@Zip_code", zipCode)
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


            cmd.Parameters.AddWithValue("@Fecha_nacimiento", CDate(DateTime.Value.Date))
            cmd.Parameters.AddWithValue("@Numero_celular", Txt_celular.Text)

            Dim email As String = Txt_email.Text.Trim

            If String.IsNullOrEmpty(email) Then
                MessageBox.Show("El correo electrónico no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not IsValidEmail(email) OrElse Not email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida de Gmail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cmd.Parameters.AddWithValue("@Email", email)
            End If

            Dim depart As String = Txt_nombrecompañia.Text.Trim()
            If String.IsNullOrEmpty(depart) Then
                MessageBox.Show("El nombre de compañia no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                cmd.Parameters.AddWithValue("@Nombre_compañía", depart)
            End If

            Dim cuota As Decimal

            If Decimal.TryParse(Txt_coutacliente.Text, cuota) Then
                ' Si la conversión es exitosa, asigna el valor al parámetro del comando.
                cmd.Parameters.AddWithValue("@Cuota_cliente", cuota)
            Else
                ' Manejar el caso en el que el ZipCode no sea un número entero válido.
                If String.IsNullOrEmpty(Txt_coutacliente.Text) Then
                    ' Muestra un mensaje si el ZipCode está vacío.
                    MessageBox.Show("La cuota del cliente no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Muestra un mensaje si el ZipCode no es un número entero válido.
                    MessageBox.Show("La cuota del cliente debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                ' Salir del método si hay un error.
                Return
            End If

            cmd.Parameters.AddWithValue("@id_vendedor", venderdorid)

            i = cmd.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("Registro de cliente fue salvado!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            Else
                MessageBox.Show("Registro de cliente no fue salvado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            vendedor.DBV_Load()
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
        If CamposLlenos() Then
            clear()
            MessageBox.Show("Se han limpiado los campos.", "Limpiar campos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se pueden limpiar porque los estan campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Function CamposLlenos() As Boolean
        ' Verificar si al menos un campo de texto está lleno
        Return Txt_apellidopaterno.Text <> "" OrElse
               Txt_apellidomaterno.Text <> "" OrElse
               Txt_celular.Text <> "" OrElse
               Txt_coutacliente.Text <> "" OrElse
               Txt_direccionfisica.Text <> "" OrElse
               Txt_direccionpostal.Text <> "" OrElse
               Txt_email.Text <> "" OrElse
               Txt_inicial.Text <> "" OrElse
               Txt_nombre.Text <> "" OrElse
               Txt_nombrecompañia.Text <> "" OrElse
               Txt_pueblo.Text <> "" OrElse
               Txt_zipcode.Text <> ""

    End Function

End Class