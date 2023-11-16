Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel
Public Class vendedor
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=ventagaming2")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim datatable As New DataTable()
    Property venderdorid As Integer





    Private Sub vendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Obtener el nombre del usuario del formulario Form1
            Dim user As String = ""
            user = Form1.Txtusername.Text
            ' Mostrar bienvenida
            MostrarBienvenida(user)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            MessageBox.Show("Error al cargar el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarBienvenida(ByVal user As String)
        ' Mostrar bienvenida con el nombre del vendedor actual
        Dim userName As String = user
        Lbl_Titulo.Text = "Hola " & userName & " Bienvenido a venta gaming"





        ' Llamar la función para cargar los datos de la base de datos al DataGridView
        DBV_Load()
    End Sub


    Public Sub DBV_Load()

        datatable.Rows.Clear()


        If datatable.Columns.Count = 0 Then
            datatable.Columns.Add("id_cliente")
            datatable.Columns.Add("Apellido_paterno")
            datatable.Columns.Add("Apellido_materna")
            datatable.Columns.Add("Nombre")
            datatable.Columns.Add("Inicial")
            datatable.Columns.Add("Dirección_fisica")
            datatable.Columns.Add("Dirección_postal")
            datatable.Columns.Add("Pueblo")
            datatable.Columns.Add("Zip_code")
            datatable.Columns.Add("Fecha_nacimiento")
            datatable.Columns.Add("Numero_celular")
            datatable.Columns.Add("Email")
            datatable.Columns.Add("Nombre_compañía")
            datatable.Columns.Add("Cuota_cliente")
            datatable.Columns.Add("id_vendedor")
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_cliente", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                datatable.Rows.Add(dr.Item("id_cliente"), dr.Item("Apellido_paterno"), dr.Item("Apellidos_materna"), dr.Item("Nombre"), dr.Item("Inicial"), dr.Item("Dirección_fisica"), dr.Item("Dirección_postal"), dr.Item("Pueblo"), dr.Item("Zip_code"), dr.Item("Fecha_nacimiento"), dr.Item("Numero_celular"), dr.Item("Email"), dr.Item("Nombre_compañía"), dr.Item("Cuota_cliente"), dr.Item("id_vendedor"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        Data.DataSource = datatable
    End Sub





    Private Sub Btn_logoutClick(sender As Object, e As EventArgs) Handles Btn_logout.Click

        If MsgBox("¿Está seguro de que desea volver al login?", MsgBoxStyle.Question + vbYesNo) = vbYes Then


            ' Mostrar el formulario de login
            Dim loggin As New Form1()
            loggin.Show()
            Me.Hide()
        Else
            Return
        End If

    End Sub

    Private Sub btn_addcliente_Click(sender As Object, e As EventArgs) Handles btn_addcliente.Click
        Cliente.venderdorid = Me.venderdorid
        Cliente.Show()
        Me.Hide()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        edit.venderdorid = Me.venderdorid
        edit.Show()
        Me.Hide()
    End Sub

    Private Sub Txt_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_search.TextChanged
        Data.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_cliente WHERE id_cliente LIKE @search OR Nombre LIKE @search", conn)
            cmd.Parameters.AddWithValue("@search", "%" & Txt_search.Text & "%")
            dr = cmd.ExecuteReader
            While dr.Read
                Data.Rows.Add(dr.Item("id_cliente"), dr.Item("Apellido_paterno"), dr.Item("Apellidos_materna"), dr.Item("Nombre"), dr.Item("Inicial"), dr.Item("Dirección_fisica"), dr.Item("Dirección_postal"), dr.Item("Pueblo"), dr.Item("Zip_code"), dr.Item("Fecha_nacimiento"), dr.Item("Numero_celular"), dr.Item("Email"), dr.Item("Nombre_compañía"), dr.Item("Cuota_cliente"), dr.Item("id_vendedor"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Excel_Click(sender As Object, e As EventArgs) Handles Excel.Click

        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}

            If sfd.ShowDialog() = DialogResult.OK Then
                Try

                    Using workbook As XLWorkbook = New XLWorkbook()


                        Dim datatable As New DataTable()


                        For Each col As DataGridViewColumn In Data.Columns
                            datatable.Columns.Add(col.Name)
                        Next


                        For Each row As DataGridViewRow In Data.Rows
                            Dim dataRow As DataRow = datatable.NewRow()
                            For Each column As DataGridViewColumn In Data.Columns
                                dataRow(column.Name) = row.Cells(column.Index).Value
                            Next
                            datatable.Rows.Add(dataRow)
                        Next

                        Dim worksheet = workbook.Worksheets.Add(datatable, "Clients")

                        worksheet.Columns().AdjustToContents()


                        workbook.SaveAs(sfd.FileName)

                        MessageBox.Show("Successful export to Excel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End Using
                Catch ex As Exception
                    MessageBox.Show("An error occurred while exporting to Excel:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub



End Class