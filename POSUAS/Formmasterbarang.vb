Imports System.Data.Odbc
Imports alfathNET
Imports MySql.Data.MySqlClient

Public Class Formmasterbarang

    Public db As New Database
    Public fs As New Fungsi
    Public kondisi As Boolean

    Sub KoneksiDatabase()
        db.Koneksi("127.0.0.1", "root", " ", "db_penjualan", "3306", Me)
    End Sub

    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""

        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        'munculSatuan()

        Call KoneksiDatabase()
        db.tampilTabel1(DataGridView1, "select * from tbl_barang")


    End Sub

    Sub munculSatuan()
        ComboBox1.Items.Clear()
        koneksi()
        Cmd = New OdbcCommand("select distinct satuanBarang from tbl_barang", conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item("satuanBarang"))
        Loop

    End Sub

    Private Sub Formbarangmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
        munculSatuan()
    End Sub

    Private Sub bntInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Silahkan Lengkapi Informasi yang di Butuhkan")
        Else
            Call KoneksiDatabase()
            db.manipulasi("insert into tbl_barang value('" & TextBox1.Text & "','" & TextBox2.Text &
                          "','" & TextBox3.Text & "','" & TextBox4.Text &
                          "','" & ComboBox1.Text & "')", "Simpan")
            MsgBox("Input Data Berhasil")
            Call kondisiawal()
        End If
        munculSatuan()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        btnSimpan.Enabled = False
        btnEdit.Enabled = True
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Silahkan Lengkapi Informasi yang di Butuhkan")
        Else
            Call KoneksiDatabase()
            db.manipulasi("Update  tbl_barang set namaBarang='" & TextBox2.Text & "',hargaBarang='" & TextBox3.Text & "',jumlahBarang='" & TextBox4.Text & "' ,satuanBarang='" & ComboBox1.Text & " ' where idBarang='" & TextBox1.Text & "'", "Ubah")
            MsgBox("update Data Berhasil")
            Call kondisiawal()
        End If
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        btnSimpan.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        With DataGridView1
            TextBox1.Text = .Item(0, .CurrentRow.Index).Value
            TextBox2.Text = .Item(1, .CurrentRow.Index).Value
            TextBox3.Text = .Item(2, .CurrentRow.Index).Value
            TextBox4.Text = .Item(3, .CurrentRow.Index).Value
            ComboBox1.Text = .Item(4, .CurrentRow.Index).Value


        End With

    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Call KoneksiDatabase()
        If TextBox1.Text = "" Then
            MsgBox("Pilih data dulu")
        Else
            db.manipulasi("delete from tbl_barang where idBarang = '" & TextBox1.Text & "'", "Hapus")
            MsgBox("Hapus Data Berhasil")
        End If

        Call kondisiawal()
    End Sub
End Class