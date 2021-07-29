Imports alfathNET
Imports MySql.Data.MySqlClient

Public Class menuutama
    Public db As New Database
    Public fs As New Fungsi
    Public kondisi As Boolean
    Public stok As Integer

    Sub connek()
        db.Koneksi("127.0.0.1", "root", "", "db_penjualan", "3306", Me)
    End Sub

    Sub loadTble()
        connek()
        db.tampilTabel1(tabelJoin, "SELECT tbl_detailjual.idPenjualan, tbl_pelanggan.nama_pelanggan, tbl_pelanggan.no_Hp, tbl_barang.namaBarang, tbl_barang.hargaBarang, tbl_detailjual.tglJual, tbl_detailjual.jumlahJual, tbl_detailjual.subTotal FROM tbl_detailjual JOIN tbl_pelanggan ON tbl_detailjual.idPelanggan=tbl_pelanggan.id_pelanggan JOIN tbl_barang ON tbl_detailjual.kodeBarang=tbl_barang.idBarang")

        'db.tampilTabel1(tabelJoin, "select * From tbl_detailJual ORDER BY tglJual DESC")

    End Sub

    Sub terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogOutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False

        stlabel2.Text = ""
        stlabel4.Text = ""
        stlabel6.Text = ""

    End Sub


    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click

        Formlogin.ShowDialog()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Formlogin.Close()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Formadminmaster.ShowDialog()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem.Click
        Formmasterpelanggan.ShowDialog()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        Formmasterbarang.ShowDialog()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        stlabel8.Text = TimeOfDay
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        Formtransjual.Show()
    End Sub

    Private Sub menuutama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        stlabel10.Text = Today
        Call loadTble()
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        FormNota.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class