Imports alfathNET
Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class Formmasterpelanggan

    Public db As New Database
    Public fs As New Fungsi
    Public kondisi As Boolean


    Sub KoneksiDatabase()
        db.Koneksi("127.0.0.1", "root", " ", "db_penjualan", "3306", Me)
    End Sub

    Sub TampilData()
        db.tampilTabel1(DataGridView1, "select * from tbl_pelanggan")
    End Sub

    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        btnInput.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        TampilData()

    End Sub

    Private Sub Formmasterpelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Call kondisiawal()
        Call TampilData()
    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Silahkan Lengkapi Informasi yang di Butuhkan")
        Else
            db.manipulasi("insert into tbl_pelanggan value('" & TextBox1.Text &
                          "','" & TextBox2.Text & "','" & TextBox3.Text &
                          "','" & TextBox4.Text & "')", "Simpan")
            TampilData()
            Call kondisiawal()
        End If
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        db.manipulasi("update tbl_pelanggan set id_pelanggan= '" & TextBox1.Text &
                      "', nama_pelanggan= '" & TextBox2.Text &
                      "', alamat_pelanggan= '" & TextBox3.Text &
                      "', no_hp= '" & TextBox4.Text &
                      "' where id_pelanggan= '" & TextBox1.Text & "' ", "Ubah")
        MsgBox("OK", MsgBoxStyle.OkOnly)
        TampilData()
        kondisiawal()
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        TextBox1.ReadOnly = True
        btnInput.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        With DataGridView1
            TextBox1.Text = .Item(0, .CurrentRow.Index).Value
            TextBox2.Text = .Item(1, .CurrentRow.Index).Value
            TextBox3.Text = .Item(2, .CurrentRow.Index).Value
            TextBox4.Text = .Item(3, .CurrentRow.Index).Value
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim conf = MsgBox("Anda akan menhapus ini..", MsgBoxStyle.OkCancel)
        If conf = 1 Then
            db.manipulasi("delete from tbl_pelanggan where id_pelanggan= '" & TextBox1.Text & "'", "Hapus")
        End If
        kondisiawal()
        TampilData()
    End Sub
End Class