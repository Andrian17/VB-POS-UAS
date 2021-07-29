<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuutama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stlabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabelJoin = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabelJoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(887, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(62, 22)
        Me.OptionToolStripMenuItem.Text = "Option"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PelangganToolStripMenuItem, Me.BarangToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(64, 22)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(82, 22)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(74, 22)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlabel2, Me.stlabel4, Me.stlabel6, Me.stlabel7, Me.stlabel8, Me.stlabel9, Me.stlabel10})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 370)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(887, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stlabel2
        '
        Me.stlabel2.Name = "stlabel2"
        Me.stlabel2.Size = New System.Drawing.Size(0, 17)
        '
        'stlabel4
        '
        Me.stlabel4.Name = "stlabel4"
        Me.stlabel4.Size = New System.Drawing.Size(0, 17)
        '
        'stlabel6
        '
        Me.stlabel6.Name = "stlabel6"
        Me.stlabel6.Size = New System.Drawing.Size(0, 17)
        '
        'stlabel7
        '
        Me.stlabel7.Name = "stlabel7"
        Me.stlabel7.Size = New System.Drawing.Size(51, 17)
        Me.stlabel7.Text = "| Jam :"
        '
        'stlabel8
        '
        Me.stlabel8.Name = "stlabel8"
        Me.stlabel8.Size = New System.Drawing.Size(0, 17)
        '
        'stlabel9
        '
        Me.stlabel9.Name = "stlabel9"
        Me.stlabel9.Size = New System.Drawing.Size(75, 17)
        Me.stlabel9.Text = "| Tanggal :"
        '
        'stlabel10
        '
        Me.stlabel10.Name = "stlabel10"
        Me.stlabel10.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabelJoin)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 311)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'tabelJoin
        '
        Me.tabelJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelJoin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelJoin.Location = New System.Drawing.Point(3, 16)
        Me.tabelJoin.Name = "tabelJoin"
        Me.tabelJoin.Size = New System.Drawing.Size(856, 292)
        Me.tabelJoin.TabIndex = 0
        '
        'menuutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menuutama"
        Me.Text = "menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.tabelJoin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stlabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stlabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stlabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stlabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stlabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stlabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stlabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tabelJoin As System.Windows.Forms.DataGridView
End Class
