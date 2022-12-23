<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Pembelian
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_Pembelian_Obat = New System.Windows.Forms.DataGridView()
        Me.LblKodePetugas = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblooo = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txt_kodeobat = New System.Windows.Forms.TextBox()
        Me.txt_namaobat = New System.Windows.Forms.TextBox()
        Me.txt_jenis = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpembelian = New System.Windows.Forms.DateTimePicker()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_Hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.dtExp = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        CType(Me.dg_Pembelian_Obat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(386, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PEMBELIAN OBAT"
        '
        'dg_Pembelian_Obat
        '
        Me.dg_Pembelian_Obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Pembelian_Obat.GridColor = System.Drawing.Color.Gainsboro
        Me.dg_Pembelian_Obat.Location = New System.Drawing.Point(331, 93)
        Me.dg_Pembelian_Obat.Name = "dg_Pembelian_Obat"
        Me.dg_Pembelian_Obat.Size = New System.Drawing.Size(687, 431)
        Me.dg_Pembelian_Obat.TabIndex = 23
        '
        'LblKodePetugas
        '
        Me.LblKodePetugas.AutoSize = True
        Me.LblKodePetugas.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKodePetugas.Location = New System.Drawing.Point(935, 66)
        Me.LblKodePetugas.Name = "LblKodePetugas"
        Me.LblKodePetugas.Size = New System.Drawing.Size(81, 15)
        Me.LblKodePetugas.TabIndex = 37
        Me.LblKodePetugas.Text = "Kode Petugas"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(918, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 15)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(831, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Kode Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Obat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tgl Pembelian"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Exp"
        '
        'lblooo
        '
        Me.lblooo.AutoSize = True
        Me.lblooo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblooo.Location = New System.Drawing.Point(12, 229)
        Me.lblooo.Name = "lblooo"
        Me.lblooo.Size = New System.Drawing.Size(48, 17)
        Me.lblooo.TabIndex = 6
        Me.lblooo.Text = "Harga"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(12, 295)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(79, 17)
        Me.lbl.TabIndex = 7
        Me.lbl.Text = "Jenis Obat"
        '
        'txt_kodeobat
        '
        Me.txt_kodeobat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kodeobat.Location = New System.Drawing.Point(129, 97)
        Me.txt_kodeobat.Name = "txt_kodeobat"
        Me.txt_kodeobat.Size = New System.Drawing.Size(195, 21)
        Me.txt_kodeobat.TabIndex = 8
        '
        'txt_namaobat
        '
        Me.txt_namaobat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaobat.Location = New System.Drawing.Point(129, 130)
        Me.txt_namaobat.Name = "txt_namaobat"
        Me.txt_namaobat.Size = New System.Drawing.Size(195, 21)
        Me.txt_namaobat.TabIndex = 9
        '
        'txt_jenis
        '
        Me.txt_jenis.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jenis.Location = New System.Drawing.Point(129, 295)
        Me.txt_jenis.Name = "txt_jenis"
        Me.txt_jenis.Size = New System.Drawing.Size(195, 21)
        Me.txt_jenis.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(109, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 19)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(109, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 19)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(109, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 19)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(109, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 19)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(109, 225)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 19)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(109, 293)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 19)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = ":"
        '
        'dtpembelian
        '
        Me.dtpembelian.CustomFormat = "dd/MM/yyyy"
        Me.dtpembelian.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpembelian.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpembelian.Location = New System.Drawing.Point(129, 163)
        Me.dtpembelian.Name = "dtpembelian"
        Me.dtpembelian.Size = New System.Drawing.Size(195, 21)
        Me.dtpembelian.TabIndex = 18
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_tambah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambah.Location = New System.Drawing.Point(55, 434)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(86, 34)
        Me.btn_tambah.TabIndex = 19
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'btn_keluar
        '
        Me.btn_keluar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_keluar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(167, 490)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(86, 34)
        Me.btn_keluar.TabIndex = 20
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = False
        '
        'btn_Hapus
        '
        Me.btn_Hapus.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_Hapus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Hapus.Location = New System.Drawing.Point(55, 490)
        Me.btn_Hapus.Name = "btn_Hapus"
        Me.btn_Hapus.Size = New System.Drawing.Size(86, 34)
        Me.btn_Hapus.TabIndex = 24
        Me.btn_Hapus.Text = "Hapus"
        Me.btn_Hapus.UseVisualStyleBackColor = False
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_ubah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubah.Location = New System.Drawing.Point(167, 434)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(86, 34)
        Me.btn_ubah.TabIndex = 25
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'dtExp
        '
        Me.dtExp.CustomFormat = "dd/MM/yyyy"
        Me.dtExp.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtExp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtExp.Location = New System.Drawing.Point(129, 196)
        Me.dtExp.Name = "dtExp"
        Me.dtExp.Size = New System.Drawing.Size(195, 21)
        Me.dtExp.TabIndex = 26
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(110, 351)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 15)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "CARI OBAT"
        '
        'TxtCari
        '
        Me.TxtCari.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCari.Location = New System.Drawing.Point(55, 369)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(198, 22)
        Me.TxtCari.TabIndex = 34
        '
        'txt_harga
        '
        Me.txt_harga.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_harga.Location = New System.Drawing.Point(129, 228)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(195, 21)
        Me.txt_harga.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Jumlah Obat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(109, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 19)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = ":"
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jumlah.Location = New System.Drawing.Point(129, 262)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(195, 21)
        Me.txt_jumlah.TabIndex = 41
        '
        'Form_Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1030, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_jumlah)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_harga)
        Me.Controls.Add(Me.LblKodePetugas)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtExp)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_Hapus)
        Me.Controls.Add(Me.dg_Pembelian_Obat)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.dtpembelian)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_jenis)
        Me.Controls.Add(Me.txt_namaobat)
        Me.Controls.Add(Me.txt_kodeobat)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblooo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Pembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dg_Pembelian_Obat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dg_Pembelian_Obat As DataGridView
    Friend WithEvents LblKodePetugas As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblooo As Label
    Friend WithEvents lbl As Label
    Friend WithEvents txt_kodeobat As TextBox
    Friend WithEvents txt_namaobat As TextBox
    Friend WithEvents txt_jenis As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpembelian As DateTimePicker
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents btn_Hapus As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents dtExp As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents txt_harga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_jumlah As TextBox
End Class
