Imports MySql.Data.MySqlClient

Public Class edit
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=ventagaming2")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Property venderdorid As Integer

    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBV_Load()
    End Sub




    Public Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE`tbl_cliente`SET`Apellido_paterno`=@Apellido_paterno,`Apellidos_materna`=@Apellidos_materna,`Nombre`=@Nombre,`Inicial`=@Inicial,`Dirección_fisica`=@Dirección_fisica,`Dirección_postal`=@Dirección_postal,`Pueblo`=@Pueblo,`Zip_code`=@Zip_code,`Fecha_nacimiento`=@Fecha_nacimiento,`Numero_celular`=@Numero_celular,`Email`=@Email,`Nombre_compañía`=@Nombre_compañía,`Cuota_cliente`=@Cuota_cliente,`id_vendedor`=@id_vendedor WHERE `id_cliente`=@id_cliente", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@Apellido_paterno", Txt_apellidopaterno.Text)
            cmd.Parameters.AddWithValue("@Apellidos_materna", Txt_apellidomaterno.Text)
            cmd.Parameters.AddWithValue("@Nombre", Txt_nombre.Text)
            cmd.Parameters.AddWithValue("@Inicial", Txt_inicial.Text)
            cmd.Parameters.AddWithValue("@Dirección_fisica", Txt_direccionfisica.Text)
            cmd.Parameters.AddWithValue("@Dirección_postal", Txt_direccionpostal.Text)
            cmd.Parameters.AddWithValue("@Pueblo", Txt_pueblo.Text)
            cmd.Parameters.AddWithValue("@Zip_code", Txt_zipcode.Text)
            cmd.Parameters.AddWithValue("@Fecha_nacimiento", CDate(DateTime.Value))
            cmd.Parameters.AddWithValue("@Numero_celular", Txt_celular.Text)
            cmd.Parameters.AddWithValue("@Email", Txt_email.Text)
            cmd.Parameters.AddWithValue("@Nombre_compañía", Txt_nombrecompañia.Text)
            cmd.Parameters.AddWithValue("@Cuota_cliente", Txt_coutacliente.Text)
            cmd.Parameters.AddWithValue("@id_vendedor", venderdorid)
            cmd.Parameters.AddWithValue("@id_cliente", CInt(DataGridView1.CurrentRow.Cells(0).Value))
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record de cliente fue Actualizado!", "Saves", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record de cliente no fue Actualizado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
        clear()
        DBV_Load()


    End Sub






    Public Sub DBV_Load()
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_cliente", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                DataGridView1.Rows.Add(dr.Item("id_cliente"), dr.Item("Apellido_paterno"), dr.Item("Apellidos_materna"), dr.Item("Nombre"), dr.Item("Inicial"), dr.Item("Dirección_fisica"), dr.Item("Dirección_postal"), dr.Item("Pueblo"), dr.Item("Zip_code"), dr.Item("Fecha_nacimiento"), dr.Item("Numero_celular"), dr.Item("Email"), dr.Item("Nombre_compañía"), dr.Item("Cuota_cliente"), dr.Item("id_vendedor"))
            End While


            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            vendedor.DBV_Load()
        End Try
    End Sub


    Public Sub delete()

        If MsgBox("Esta seguro que quieres borrar el cliente!!", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `tbl_cliente` WHERE Apellido_paterno=@Apellido_paterno", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Apellido_paterno", Txt_apellidopaterno.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record de Cliente fue borrado!", "Saves", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record de Cliente no fue borrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()

            End Try
            DBV_Load()
            vendedor.DBV_Load()
            clear()

        Else
            Return
        End If
    End Sub

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
        Btn_update.Enabled = True
    End Sub



    Private Sub Btn_return_Click(sender As Object, e As EventArgs) Handles Btn_return.Click
        vendedor.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Txt_apellidopaterno.Text = DataGridView1.CurrentRow.Cells(1).Value
        Txt_apellidomaterno.Text = DataGridView1.CurrentRow.Cells(2).Value
        Txt_nombre.Text = DataGridView1.CurrentRow.Cells(3).Value
        Txt_inicial.Text = DataGridView1.CurrentRow.Cells(4).Value
        Txt_direccionfisica.Text = DataGridView1.CurrentRow.Cells(5).Value
        Txt_direccionpostal.Text = DataGridView1.CurrentRow.Cells(6).Value
        Txt_pueblo.Text = DataGridView1.CurrentRow.Cells(7).Value
        Txt_zipcode.Text = DataGridView1.CurrentRow.Cells(8).Value
        DateTime.Text = DataGridView1.CurrentRow.Cells(9).Value
        Txt_celular.Text = DataGridView1.CurrentRow.Cells(10).Value
        Txt_email.Text = DataGridView1.CurrentRow.Cells(11).Value
        Txt_nombrecompañia.Text = DataGridView1.CurrentRow.Cells(12).Value
        Txt_coutacliente.Text = DataGridView1.CurrentRow.Cells(13).Value


    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click
        ' Agrega un punto de interrupción en la siguiente línea y verifica si se alcanza
        Edit()

    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        delete()
    End Sub
End Class