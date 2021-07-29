Imports System.Data.Odbc
Imports alfathNET
Imports MySql.Data.MySqlClient

Public Class Formtransjual

    Public db As New Database
    Public fs As New Fungsi
    Public kondisi As Boolean
    Public stok As Integer

    Sub KoneksiDatabase()
        db.Koneksi("127.0.0.1", "root", " ", "db_penjualan", "3306", Me)
    End Sub

    Sub kondisiawal()
        lblNama.Text = ""
        lblalamat.Text = ""
        lbltelepon.Text = ""
        lbltanggal.Text = Today
        lblkembali.Text = ""


    End Sub

    Sub idpelanggan()
        Call koneksi()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan", conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            cbidpelanggan.Items.Add(Rd.Item(0))
        Loop

    End Sub

    Sub cbKodeBarang()
        Call koneksi()
        Cmd = New OdbcCommand("select * from tbl_barang", conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            cbIdBarang.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Sub otoIdJual()
        Dim r As Integer
        r = Int(Rnd() * 100)
        txtIdPenjualan.Text = "P-" & r & "-" & Format(Now, "mmss")
    End Sub

    Private Sub Formtransjual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call idpelanggan()
        Call cbKodeBarang()
        Call otoIdJual()
        lblTotal.Text = "0"
        TextBox1.Text = "0"
        lbladmin.Text = Formlogin.txtUser.Text
        txtIdPenjualan.ReadOnly = True
        txtHarga.ReadOnly = True
        txtNamaBarang.ReadOnly = True
        txtJumlah.Enabled = False
        txtTotal.Enabled = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbljam.Text = TimeOfDay
    End Sub

    Private Sub cbidpelanggan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbidpelanggan.SelectedIndexChanged
        Call koneksi()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan where id_pelanggan = '" & cbidpelanggan.Text & "' ", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            lblNama.Text = Rd!nama_pelanggan
            lblalamat.Text = Rd!alamat_pelanggan
            lbltelepon.Text = Rd!no_hp

        End If

        otoIdJual()
        lblTotal.Text = "0"
        DataGridView1.Rows.Clear()
        lblkembali.Text = 0
        TextBox1.Text = 0
        txtJumlah.Text = 0
        txtTotal.Text = 0
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbIdBarang.SelectedIndexChanged
        Call koneksi()
        Cmd = New OdbcCommand("select * from tbl_barang where idBarang= '" & cbIdBarang.Text & "'", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            cbIdBarang.Text = Rd!idBarang
            txtHarga.Text = Rd!hargaBarang
            txtNamaBarang.Text = Rd!namaBarang
            stok = Rd!jumlahBarang
        End If

        txtJumlah.Text = 0
        txtTotal.Text = 0
        txtJumlah.Enabled = True
        txtTotal.Enabled = True
    End Sub
    Public temp As String
    Private Sub txtJumlah_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtJumlah.KeyUp

        Call koneksi()
        Cmd = New OdbcCommand("Select * from tbl_barang where idBarang= '" & cbIdBarang.Text & "'", conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            temp = Rd!jumlahBarang
        End If
        If txtJumlah.Text = "" Then
            txtJumlah.Text = "0"
        End If
        If CInt(txtJumlah.Text) > temp Then
            MsgBox("Stok tidak cukup")
            txtTotal.Text = ""
        Else
            txtTotal.Text = CInt(txtHarga.Text) * CInt(txtJumlah.Text)
        End If
    End Sub

    Private Sub btnInputBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputBarang.Click
        KoneksiDatabase()

        Dim waktu As String = Now
        Dim jam As String = TimeOfDay
        Dim inc As String = ""
        If cbIdBarang.Text = "" Then
            MsgBox("Masukkan Data yang valid")
        Else
            db.manipulasi("insert into tbl_detailjual value( '" & inc & "', '" & txtIdPenjualan.Text &
                      "', '" & cbidpelanggan.Text & "', '" & cbIdBarang.Text & "' , '" & waktu &
                      "', '" & txtJumlah.Text &
                      "', '" & txtTotal.Text & "' )", "Simpan")
            MsgBox("Data disimpan")
            Dim total, t As Integer
            t = lblTotal.Text
            total = CInt(txtTotal.Text) + CInt(lblTotal.Text)
            lblTotal.Text = total
            ambilIsiTabel()
            upStok(txtJumlah.Text, stok, cbIdBarang.Text)
            bersihkan()
        End If

        txtJumlah.Enabled = True
        txtTotal.Enabled = True

    End Sub

    Sub ambilIsiTabel()
        With DataGridView1
            .Rows.Add(cbIdBarang.Text, txtNamaBarang.Text, txtHarga.Text, txtJumlah.Text, txtTotal.Text)
        End With

    End Sub

    Sub upStok(ByRef a, ByRef b, ByRef id)
        b -= a
        db.manipulasi("update tbl_barang set jumlahBarang = '" & b & "' where idBarang= '" & id & "' ", "Ubah")

    End Sub

    Sub bersihkan()
        txtHarga.Text = ""
        txtJumlah.Text = ""
        txtNamaBarang.Text = ""
        txtTotal.Text = ""
        cbIdBarang.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        menuutama.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub
    Dim conf As String
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Dim nilai As Integer
            If TextBox1.Text = "" Then
                TextBox1.Text = 0
            End If
            nilai = CInt(TextBox1.Text) - CInt(lblTotal.Text)
            lblkembali.Text = nilai
            db.manipulasi("insert into tbl_jual value( '" & "" & "' ,'" & txtIdPenjualan.Text &
                              "', '" & lblTotal.Text &
                      "', '" & TextBox1.Text &
                      "', '" & lblkembali.Text & "' )", "Simpan")
            bersihkan()

            
                conf = MsgBox("lihat transaksi penjulan?", MsgBoxStyle.YesNo)
                If conf = "6" Then

                FormNota.Show()
                End If
                otoIdJual()
            End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblTotal.Text = 0
        lblkembali.Text = 0
        TextBox1.Text = 0
        DataGridView1.Rows.Clear()
    End Sub

End Class