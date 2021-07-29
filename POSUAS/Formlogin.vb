Imports System.Data.Odbc
Imports alfathNET
Imports MySql.Data.MySqlClient

Public Class Formlogin
    Public db As New Database
    Public fs As New Fungsi
    Public kondisi As Boolean
    Public lp As New Laporan
    Dim user(99) As String

    Sub KoneksiDatabase()
        db.Koneksi("127.0.0.1", "root", " ", "db_penjualan", "3306", Me)
    End Sub

    Sub TampilData()
        db.tampilTabel1(user, "select * from tbl_admin")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncancel.Click

       
    End Sub
    Sub terbuka()

        menuutama.LoginToolStripMenuItem.Enabled = False
        menuutama.LogOutToolStripMenuItem.Enabled = True
        menuutama.MasterToolStripMenuItem.Enabled = True
        menuutama.TransaksiToolStripMenuItem.Enabled = True
        menuutama.LaporanToolStripMenuItem.Enabled = True
        menuutama.Show()

    End Sub


    Sub kosong()
        txtUser.Text = ""
        txtPassword.Text = ""
    End Sub




    Private Sub Formlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call kosong()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtUser.Text = "" Or txtPassword.Text = "" Then
                MsgBox("ID adimin dan password tidak boleh kosong")
            Else

                KoneksiDatabase()
                db.tampilTabel1(user, "select username, password from tbl_admin where username = '" & txtUser.Text & "' and password = '" & txtPassword.Text & "'")

                menuutama.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub TextBoxpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Buttonlogin_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Buttonlogin.Enter

  


    End Sub


    Private Sub Buttonlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonlogin.Click
        If txtUser.Text = "" Or txtPassword.Text = "" Then
            MsgBox("ID adimin dan password tidak boleh kosong")
        Else

            KoneksiDatabase()
            db.tampilTabel1(user, "select username, password from tbl_admin where username = '" & txtUser.Text & "' and password = '" & txtPassword.Text & "'")
           
            menuutama.Show()
            Me.Hide()

        End If

    End Sub
    
End Class