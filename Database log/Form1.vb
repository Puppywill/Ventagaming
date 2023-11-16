'William A.Rosado Pérez'
'Y00599440'
'Comp-3900'

Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Form1
#Region "Declare"

    Dim Objadapter As MySqlDataAdapter

    Dim reader As MySqlDataReader

    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=ventagaming2")
#End Region

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Objadapter = New MySqlDataAdapter("select * From tbl_vendedor where username='" & Txtusername.Text & "' and password='" & Txtcontrasena.Text & "'", conn)
        'Dim query As New MySqlCommand("select * From tbl_vendedor where username='" & Txtusername.Text & "' and password='" & Txtcontrasena.Text & "'", conn)

        Try
            conn.Open()
            ' Ejecuta tu consulta aquí

            If String.IsNullOrEmpty(Txtusername.Text) OrElse String.IsNullOrEmpty(Txtcontrasena.Text) Then
                MessageBox.Show("El usuario o la contraseña no pueden estar vacíos.")
            Else
                ' Verifica si se devuelven filas
                Dim dt As New DataTable
                Objadapter.Fill(dt)

                If dt.Rows.Count > 0 Then
                    MessageBox.Show("¡Inicio de sesión exitoso!")
                    Me.Hide()


                    Dim query As New MySqlCommand("select * From tbl_vendedor where username='" & Txtusername.Text & "' and password='" & Txtcontrasena.Text & "'", conn)

                    reader = query.ExecuteReader()

                    While reader.Read()
                        vendedor.venderdorid = CInt(reader("id_vendedor").ToString())
                    End While

                    'Try
                    '    vendedor.venderdorid = CInt(reader("id_vendedor").ToString())
                    'Catch ex As Exception
                    '    MsgBox(ex.Message)
                    'End Try
                    ' vendedor.venderdorid = CInt(reader("id_vendedor").ToString())

                    vendedor.Show()
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try


        ' Si el usuario es un cliente, muestra el formulario del cliente y cierra el formulario actual



    End Sub

    Private Sub lbl_forgetpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_forgetpassword.LinkClicked

        forget_password.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_signup_Click(sender As Object, e As EventArgs) Handles Btn_signup.Click
        signup.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_cloase_Click(sender As Object, e As EventArgs) Handles Btn_cloase.Click
        If MsgBox("Esta seguro que se quiere salir??", MsgBoxStyle.Question + vbYesNo) = vbYes Then

            Application.Exit()
            Me.Hide()
            Me.Close()
        Else
            Return
        End If
    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        If String.IsNullOrEmpty(Txtusername.Text) AndAlso String.IsNullOrEmpty(Txtcontrasena.Text) Then

            MessageBox.Show("No se limpio porque tiene el username y password vacio!!!", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Question)


        Else
            MessageBox.Show("Se limpio", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Txtusername.Clear()
            Txtcontrasena.Clear()
        End If
    End Sub
End Class
