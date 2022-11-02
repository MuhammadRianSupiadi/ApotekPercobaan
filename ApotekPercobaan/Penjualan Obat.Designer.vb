<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan_Obat
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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AlamatPembeli = New System.Windows.Forms.TextBox()
        Me.NamaPembeli = New System.Windows.Forms.TextBox()
        Me.KodePembeli = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TotalHarga = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.KodePetugas = New System.Windows.Forms.Label()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Dgpenjualan = New System.Windows.Forms.DataGridView()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Kembalian = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Bayar = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.DtPenjualan = New System.Windows.Forms.DateTimePicker()
        Me.TglPinjam = New System.Windows.Forms.Label()
        Me.HargaObat = New System.Windows.Forms.Label()
        Me.JenisObat = New System.Windows.Forms.Label()
        Me.KodeObat = New System.Windows.Forms.Label()
        Me.NoPenjualan = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.JumlahObat = New System.Windows.Forms.TextBox()
        Me.CbNamaObat = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgpenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(261, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(188, 23)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "PENJUALAN OBAT"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.AlamatPembeli)
        Me.GroupBox1.Controls.Add(Me.NamaPembeli)
        Me.GroupBox1.Controls.Add(Me.KodePembeli)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(428, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 160)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PEMBELI"
        '
        'AlamatPembeli
        '
        Me.AlamatPembeli.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatPembeli.Location = New System.Drawing.Point(126, 104)
        Me.AlamatPembeli.Name = "AlamatPembeli"
        Me.AlamatPembeli.Size = New System.Drawing.Size(118, 22)
        Me.AlamatPembeli.TabIndex = 38
        '
        'NamaPembeli
        '
        Me.NamaPembeli.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaPembeli.Location = New System.Drawing.Point(126, 68)
        Me.NamaPembeli.Name = "NamaPembeli"
        Me.NamaPembeli.Size = New System.Drawing.Size(118, 22)
        Me.NamaPembeli.TabIndex = 37
        '
        'KodePembeli
        '
        Me.KodePembeli.AutoSize = True
        Me.KodePembeli.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodePembeli.Location = New System.Drawing.Point(126, 37)
        Me.KodePembeli.Name = "KodePembeli"
        Me.KodePembeli.Size = New System.Drawing.Size(81, 15)
        Me.KodePembeli.TabIndex = 33
        Me.KodePembeli.Text = "Kode Pembeli"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(109, 107)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(11, 15)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(109, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(11, 15)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(109, 37)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 15)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(11, 37)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(81, 15)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "Kode Pembeli"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(11, 71)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(85, 15)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "Nama Pembeli"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(11, 107)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(93, 15)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "Alamat Pembeli"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(114, 301)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 15)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = ":"
        '
        'TotalHarga
        '
        Me.TotalHarga.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalHarga.Location = New System.Drawing.Point(131, 298)
        Me.TotalHarga.Name = "TotalHarga"
        Me.TotalHarga.Size = New System.Drawing.Size(85, 22)
        Me.TotalHarga.TabIndex = 69
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(28, 301)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 15)
        Me.Label20.TabIndex = 68
        Me.Label20.Text = "Total Harga"
        '
        'KodePetugas
        '
        Me.KodePetugas.AutoSize = True
        Me.KodePetugas.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodePetugas.Location = New System.Drawing.Point(532, 108)
        Me.KodePetugas.Name = "KodePetugas"
        Me.KodePetugas.Size = New System.Drawing.Size(81, 15)
        Me.KodePetugas.TabIndex = 67
        Me.KodePetugas.Text = "Kode Petugas"
        '
        'btn_keluar
        '
        Me.btn_keluar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_keluar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(364, 339)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 30)
        Me.btn_keluar.TabIndex = 80
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_simpan.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(272, 339)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 30)
        Me.btn_simpan.TabIndex = 79
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'Dgpenjualan
        '
        Me.Dgpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgpenjualan.Location = New System.Drawing.Point(27, 375)
        Me.Dgpenjualan.Name = "Dgpenjualan"
        Me.Dgpenjualan.Size = New System.Drawing.Size(657, 191)
        Me.Dgpenjualan.TabIndex = 78
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(571, 307)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(11, 15)
        Me.Label32.TabIndex = 77
        Me.Label32.Text = ":"
        '
        'Kembalian
        '
        Me.Kembalian.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kembalian.Location = New System.Drawing.Point(590, 304)
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.Size = New System.Drawing.Size(94, 22)
        Me.Kembalian.TabIndex = 76
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(500, 307)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 15)
        Me.Label33.TabIndex = 75
        Me.Label33.Text = "Kembalian"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(371, 307)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(11, 15)
        Me.Label30.TabIndex = 74
        Me.Label30.Text = ":"
        '
        'Bayar
        '
        Me.Bayar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bayar.Location = New System.Drawing.Point(388, 304)
        Me.Bayar.Name = "Bayar"
        Me.Bayar.Size = New System.Drawing.Size(87, 22)
        Me.Bayar.TabIndex = 73
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(325, 307)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 15)
        Me.Label31.TabIndex = 72
        Me.Label31.Text = "Bayar"
        '
        'DtPenjualan
        '
        Me.DtPenjualan.CustomFormat = "dd/MM/yyyy"
        Me.DtPenjualan.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtPenjualan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtPenjualan.Location = New System.Drawing.Point(131, 173)
        Me.DtPenjualan.Name = "DtPenjualan"
        Me.DtPenjualan.Size = New System.Drawing.Size(85, 20)
        Me.DtPenjualan.TabIndex = 82
        '
        'TglPinjam
        '
        Me.TglPinjam.AutoSize = True
        Me.TglPinjam.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglPinjam.Location = New System.Drawing.Point(532, 77)
        Me.TglPinjam.Name = "TglPinjam"
        Me.TglPinjam.Size = New System.Drawing.Size(84, 15)
        Me.TglPinjam.TabIndex = 66
        Me.TglPinjam.Text = "Tgl Penjualan"
        '
        'HargaObat
        '
        Me.HargaObat.AutoSize = True
        Me.HargaObat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaObat.Location = New System.Drawing.Point(131, 206)
        Me.HargaObat.Name = "HargaObat"
        Me.HargaObat.Size = New System.Drawing.Size(70, 15)
        Me.HargaObat.TabIndex = 65
        Me.HargaObat.Text = "Harga Obat"
        '
        'JenisObat
        '
        Me.JenisObat.AutoSize = True
        Me.JenisObat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisObat.Location = New System.Drawing.Point(131, 239)
        Me.JenisObat.Name = "JenisObat"
        Me.JenisObat.Size = New System.Drawing.Size(66, 15)
        Me.JenisObat.TabIndex = 64
        Me.JenisObat.Text = "Jenis Obat"
        '
        'KodeObat
        '
        Me.KodeObat.AutoSize = True
        Me.KodeObat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeObat.Location = New System.Drawing.Point(131, 109)
        Me.KodeObat.Name = "KodeObat"
        Me.KodeObat.Size = New System.Drawing.Size(63, 15)
        Me.KodeObat.TabIndex = 63
        Me.KodeObat.Text = "Kode Obat"
        '
        'NoPenjualan
        '
        Me.NoPenjualan.AutoSize = True
        Me.NoPenjualan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoPenjualan.Location = New System.Drawing.Point(131, 77)
        Me.NoPenjualan.Name = "NoPenjualan"
        Me.NoPenjualan.Size = New System.Drawing.Size(80, 15)
        Me.NoPenjualan.TabIndex = 62
        Me.NoPenjualan.Text = "No Penjualan"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(515, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 15)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(515, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 15)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(114, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 15)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(114, 141)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 15)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(114, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 15)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(114, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 15)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(114, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 15)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(114, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 15)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = ":"
        '
        'JumlahObat
        '
        Me.JumlahObat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahObat.Location = New System.Drawing.Point(131, 266)
        Me.JumlahObat.Name = "JumlahObat"
        Me.JumlahObat.Size = New System.Drawing.Size(85, 22)
        Me.JumlahObat.TabIndex = 53
        '
        'CbNamaObat
        '
        Me.CbNamaObat.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNamaObat.FormattingEnabled = True
        Me.CbNamaObat.Location = New System.Drawing.Point(131, 141)
        Me.CbNamaObat.Name = "CbNamaObat"
        Me.CbNamaObat.Size = New System.Drawing.Size(121, 21)
        Me.CbNamaObat.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(114, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 15)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(425, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Tgl Penjualan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(425, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Kode Petugas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Jumlah Obat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 15)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Exp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Harga Obat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Jenis Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Nama Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Kode Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "No Penjualan"
        '
        'Penjualan_Obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(710, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TotalHarga)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.KodePetugas)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Dgpenjualan)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Kembalian)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Bayar)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.DtPenjualan)
        Me.Controls.Add(Me.TglPinjam)
        Me.Controls.Add(Me.HargaObat)
        Me.Controls.Add(Me.JenisObat)
        Me.Controls.Add(Me.KodeObat)
        Me.Controls.Add(Me.NoPenjualan)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.JumlahObat)
        Me.Controls.Add(Me.CbNamaObat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Penjualan_Obat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgpenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AlamatPembeli As TextBox
    Friend WithEvents NamaPembeli As TextBox
    Friend WithEvents KodePembeli As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TotalHarga As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents KodePetugas As Label
    Friend WithEvents btn_keluar As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Dgpenjualan As DataGridView
    Friend WithEvents Label32 As Label
    Friend WithEvents Kembalian As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Bayar As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents DtPenjualan As DateTimePicker
    Friend WithEvents TglPinjam As Label
    Friend WithEvents HargaObat As Label
    Friend WithEvents JenisObat As Label
    Friend WithEvents KodeObat As Label
    Friend WithEvents NoPenjualan As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents JumlahObat As TextBox
    Friend WithEvents CbNamaObat As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
