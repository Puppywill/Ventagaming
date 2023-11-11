Imports MySql.Data.MySqlClient

Public Class vendedor
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=ventagaming")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub vendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As String

        user = Form1.Txtusername.Text

        'Llamar lo cliente'
        Lbl_Titulo.Text = "Hola " & user & " Bienvenido a venta gaming"






    End Sub



    ' Private Sub DBV_Load()
    ' DataGridView1.Rows.Clear()

    'Try
    '           conn.Open()
    '  Dim cmd As New MySqlCommand("SELECT * FROM tbl_cliente", conn)
    '         dr = cmd.ExecuteReader
    'While dr.Read
    '           DataGridView1.Rows.Add(dr("id_cliente"), dr("Numero_empleado"), dr("Apellidos_paterno"), dr("Apellidos_materna"), dr("Nombre"), dr("Inicial"), dr("Dirección_física"), dr("Dirección_postal"), dr("Pueblo"), dr("Zip_code"), dr("Fecha_Nacimiento"), dr("Número_celular"), dr("Email"), dr("nombre_compañía"), dr("Cuota_cliente"))
    'End While
    'Catch ex As Exception
    '       MsgBox(ex.Message)
    'Finally
    'If dr IsNot Nothing Then
    '           dr.Close()
    'End If
    '       conn.Close()
    'End Try
    'End Sub



    Private Sub Btn_logoutClick(sender As Object, e As EventArgs) Handles Btn_logout.Click

        If MsgBox("Esta seguro que quiere volver al login??", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Dim loggin As New Form1()
            loggin.Show()
            Me.Hide()
        Else
            Return
        End If


    End Sub

    Private Sub btn_addcliente_Click(sender As Object, e As EventArgs) Handles btn_addcliente.Click
        Cliente.Show()
        Me.Hide()

    End Sub
End Class