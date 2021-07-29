Imports alfathNET
Imports MySql.Data.MySqlClient

Public Class FormNota

    Public db As New Database
    Public fs As New Fungsi
    Public kondisi As Boolean
    Public stok As Integer

    Sub KoneksiDatabase()
        db.Koneksi("127.0.0.1", "root", " ", "db_penjualan", "3306", Me)
    End Sub

    Sub loadTble()
        KoneksiDatabase()
        'db.tampilTabel1(DataGridView2, "SELECT tbl_detailjual.namaBarang, tbl_detailjual.hargaBarang, tbl_detailjual.jumlahJual, tbl_detailjual.subTotal, tbl_jual.totalJual, tbl_jual.diBayar, tbl_jual.kembali FROM tbl_detailjual INNER JOIN tbl_jual ON tbl_detailjual.idPenjualan=tbl_jual.idPenjualan")

        'db.tampilTabel1(tabelJoin, "select * From tbl_detailJual ORDER BY tglJual DESC")

        db.tampilTabel1(DataGridView2, "SELECT tbl_barang.namaBarang, tbl_barang.hargaBarang, tbl_detailjual.jumlahJual, tbl_detailjual.subTotal from tbl_detailjual JOIN tbl_barang ON tbl_detailjual.kodeBarang=tbl_barang.idBarang where tbl_detailjual.idPenjualan= '" & Formtransjual.txtIdPenjualan.Text & "'")

    End Sub

    Sub tampilDB()
        KoneksiDatabase()
        db.tampilTabel1(DataGridView1, "select totalJual, diBayar, kembali from tbl_jual where idPenjualan= '" & Formtransjual.txtIdPenjualan.Text & "' ")
    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksiDatabase()
        tampilDB()
        loadTble()

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class