'William A.Rosado Pérez'
'Y00599440'
'Comp-3900'

Imports MySql.Data.MySqlClient

Public Class Form1
#Region "Declare"

    Dim Objadapter As MySqlDataAdapter
    Dim dtable As New DataTable

    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=ventagaming")
#End Region

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Objadapter = New MySqlDataAdapter("select * From tbl_vendedor where username='" & Txtusername.Text & "' and password='" & Txtcontrasena.Text & "'", conn)
        dtable = New DataTable
        dtable.Clear()
        Objadapter.Fill(dtable)
        If dtable.Rows.Count <= 0 Then
            MessageBox.Show("Esta incorrecto username o password!!")
            conn.Close()
        Else

            MessageBox.Show("Fue encontra!!!")
            Me.Hide()
            vendedor.Show()
        End If

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
