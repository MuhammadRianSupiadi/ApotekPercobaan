<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Utama))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Master = New System.Windows.Forms.ToolStripMenuItem()
        Me.Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.PETUGAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSI = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENJULAN_OBAT = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.Laporan_Pembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.Laporan_penjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Master, Me.TRANSAKSI, Me.LAPORAN})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip.Location = New System.Drawing.Point(9, 9)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(357, 30)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Master
        '
        Me.Master.BackColor = System.Drawing.Color.Transparent
        Me.Master.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Login, Me.KELUAR, Me.PETUGAS})
        Me.Master.ForeColor = System.Drawing.Color.Black
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(104, 26)
        Me.Master.Text = "MASTER"
        '
        'Login
        '
        Me.Login.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(170, 26)
        Me.Login.Text = "LOGIN"
        '
        'KELUAR
        '
        Me.KELUAR.Name = "KELUAR"
        Me.KELUAR.Size = New System.Drawing.Size(170, 26)
        Me.KELUAR.Text = "KELUAR"
        '
        'PETUGAS
        '
        Me.PETUGAS.Name = "PETUGAS"
        Me.PETUGAS.Size = New System.Drawing.Size(170, 26)
        Me.PETUGAS.Text = "PETUGAS"
        '
        'TRANSAKSI
        '
        Me.TRANSAKSI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TRANSAKSI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PENJULAN_OBAT, Me.Pembelian})
        Me.TRANSAKSI.ForeColor = System.Drawing.Color.Black
        Me.TRANSAKSI.Name = "TRANSAKSI"
        Me.TRANSAKSI.Size = New System.Drawing.Size(132, 26)
        Me.TRANSAKSI.Text = "TRANSAKSI"
        '
        'PENJULAN_OBAT
        '
        Me.PENJULAN_OBAT.Name = "PENJULAN_OBAT"
        Me.PENJULAN_OBAT.Size = New System.Drawing.Size(253, 26)
        Me.PENJULAN_OBAT.Text = "PENJUALAN OBAT"
        '
        'Pembelian
        '
        Me.Pembelian.Name = "Pembelian"
        Me.Pembelian.Size = New System.Drawing.Size(253, 26)
        Me.Pembelian.Text = "PEMBELIAN OBAT"
        '
        'LAPORAN
        '
        Me.LAPORAN.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Laporan_Pembelian, Me.Laporan_penjualan})
        Me.LAPORAN.ForeColor = System.Drawing.Color.Black
        Me.LAPORAN.Name = "LAPORAN"
        Me.LAPORAN.Size = New System.Drawing.Size(115, 26)
        Me.LAPORAN.Text = "LAPORAN"
        '
        'Laporan_Pembelian
        '
        Me.Laporan_Pembelian.Name = "Laporan_Pembelian"
        Me.Laporan_Pembelian.Size = New System.Drawing.Size(293, 26)
        Me.Laporan_Pembelian.Text = "LAPORAN PEMBELIAN"
        '
        'Laporan_penjualan
        '
        Me.Laporan_penjualan.Name = "Laporan_penjualan"
        Me.Laporan_penjualan.Size = New System.Drawing.Size(293, 26)
        Me.Laporan_penjualan.Text = "LAPORAN PENJUALAN"
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Menu_Utama"
        Me.Text = "Menu_Utama"
        Me.TransparencyKey = System.Drawing.Color.LightSeaGreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents TRANSAKSI As ToolStripMenuItem
    Friend WithEvents PENJULAN_OBAT As ToolStripMenuItem
    Friend WithEvents LAPORAN As ToolStripMenuItem
    Friend WithEvents Master As ToolStripMenuItem
    Friend WithEvents Login As ToolStripMenuItem
    Friend WithEvents KELUAR As ToolStripMenuItem
    Friend WithEvents PETUGAS As ToolStripMenuItem
    Friend WithEvents Pembelian As ToolStripMenuItem
    Friend WithEvents Laporan_Pembelian As ToolStripMenuItem
    Friend WithEvents Laporan_penjualan As ToolStripMenuItem
End Class
