

Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient


Public Class forget_password
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=db-login")
    Dim i As Integer

    Private Sub BtnActualizarContraseña_Click(sender As Object, e As EventArgs) Handles Btn_saves.Click
        Dim query As String = "UPDATE login SET password = @password WHERE username = @username"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", Txtusername.Text)
        cmd.Parameters.AddWithValue("@password", Txtcontrasena.Text)

        Try
            conn.Open()
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Contraseña actualizada correctamente!", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo actualizar la contraseña. Nombre de usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la contraseña: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub






    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        If MsgBox("Esta seguro que quiere volver al login??", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Dim loggin As New Form1()
            loggin.Show()
            Me.Hide()
            Me.Close()
        Else
            Return
        End If
    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click

        If String.IsNullOrEmpty(Txtusername.Text) AndAlso String.IsNullOrEmpty(Txtcontrasena.Text) Then

            MessageBox.Show("No se limpio porque  tienes los campo vacio", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Question)


        Else
            MessageBox.Show("Se limpio", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Txtusername.Clear()
            Txtcontrasena.Clear()
        End If
    End Sub
End Class