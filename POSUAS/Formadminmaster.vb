Imports System.Data.Odbc


Public Class Formadminmaster


    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"

        Call koneksi()
        Da = New OdbcDataAdapter("Select id,username,level From tbl_admin", conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_admin")
        DataGridView1.DataSource = Ds.Tables("tbl_admin")
        DataGridView1.ReadOnly = True

    End Sub


    Sub isi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")

    End Sub




    Private Sub Formadminmaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call isi()

            Call kodeadmin()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Lengkapi Informasi yang di Butuhkan")
            Else
                Call koneksi()
                Dim InputData As String = "insert into tbl_admin value('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
                Cmd = New OdbcCommand(InputData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call kondisiawal()


            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call isi()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Lengkapi Informasi yang di Butuhkan")
            Else
                Call koneksi()
                Dim UpdateData As String = "Update  tbl_admin set nama_admin='" & TextBox2.Text & "',password_admin='" & TextBox3.Text & "',level_admin='" & ComboBox1.Text & "' where idadmin='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(UpdateData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("update Data Berhasil")
                Call kondisiawal()

            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Cmd = New OdbcCommand("Select * From tbl_admin where idadmin='" & TextBox1.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("kode Admin/User tidak ada")
            Else
                TextBox1.Text = Rd.Item("idadmin")
                TextBox2.Text = Rd.Item("nama_admin")
                TextBox3.Text = Rd.Item("password_admin")
                ComboBox1.Text = Rd.Item("level_admin")
            End If


        End If
    End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Tutup" Then
            Me.Close()
        Else
            Call kondisiawal()

        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Delte"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            Call isi()

        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Lengkapi Informasi yang di Butuhkan")
            Else
                Call koneksi()
                Dim HapusData As String = "Delete  from tbl_admin  where idadmin='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(HapusData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call kondisiawal()

            End If
        End If

    End Sub

    Sub kodeadmin()
        Call koneksi()
        Cmd = New OdbcCommand("Select * from tbl_admin where idadmin in (select max(idadmin) from tbl_admin)", conn)
        Dim kode As String
        Dim hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Not Rd.HasRows Then
            kode = "ADM" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            kode = "ADM" + Microsoft.VisualBasic.Right("000" & hitung, 3)

        End If
        TextBox1.Text = kode


    End Sub


End Class