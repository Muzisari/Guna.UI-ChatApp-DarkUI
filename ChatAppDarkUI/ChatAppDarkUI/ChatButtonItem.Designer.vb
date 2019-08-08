<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatButtonItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lb_asal = New Guna.UI.WinForms.GunaLabel()
        Me.lb_nama_kontak = New Guna.UI.WinForms.GunaLabel()
        Me.lb_waktu = New Guna.UI.WinForms.GunaLabel()
        Me.lb_lokasi_pengirim = New Guna.UI.WinForms.GunaLabel()
        Me.lb_pesan = New Guna.UI.WinForms.GunaLabel()
        Me.bt_jumlah_pesan_baru = New Guna.UI.WinForms.GunaButton()
        Me.p_aktif = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.p_picture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaMouseStateHelper1 = New Guna.UI.WinForms.GunaMouseStateHelper()
        CType(Me.p_aktif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_asal
        '
        Me.lb_asal.AutoSize = True
        Me.lb_asal.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lb_asal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lb_asal.Location = New System.Drawing.Point(20, 15)
        Me.lb_asal.Name = "lb_asal"
        Me.lb_asal.Size = New System.Drawing.Size(36, 12)
        Me.lb_asal.TabIndex = 0
        Me.lb_asal.Text = "Kontak"
        '
        'lb_nama_kontak
        '
        Me.lb_nama_kontak.AutoSize = True
        Me.lb_nama_kontak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lb_nama_kontak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lb_nama_kontak.Location = New System.Drawing.Point(19, 32)
        Me.lb_nama_kontak.Name = "lb_nama_kontak"
        Me.lb_nama_kontak.Size = New System.Drawing.Size(82, 15)
        Me.lb_nama_kontak.TabIndex = 1
        Me.lb_nama_kontak.Text = "Nama Kontak"
        '
        'lb_waktu
        '
        Me.lb_waktu.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lb_waktu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lb_waktu.Location = New System.Drawing.Point(194, 35)
        Me.lb_waktu.Name = "lb_waktu"
        Me.lb_waktu.Size = New System.Drawing.Size(46, 12)
        Me.lb_waktu.TabIndex = 4
        Me.lb_waktu.Text = "10:30"
        Me.lb_waktu.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lb_lokasi_pengirim
        '
        Me.lb_lokasi_pengirim.AutoSize = True
        Me.lb_lokasi_pengirim.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lb_lokasi_pengirim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lb_lokasi_pengirim.Location = New System.Drawing.Point(20, 107)
        Me.lb_lokasi_pengirim.Name = "lb_lokasi_pengirim"
        Me.lb_lokasi_pengirim.Size = New System.Drawing.Size(74, 12)
        Me.lb_lokasi_pengirim.TabIndex = 5
        Me.lb_lokasi_pengirim.Text = "Lokasi Pengirim"
        '
        'lb_pesan
        '
        Me.lb_pesan.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lb_pesan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lb_pesan.Location = New System.Drawing.Point(66, 57)
        Me.lb_pesan.Name = "lb_pesan"
        Me.lb_pesan.Size = New System.Drawing.Size(140, 40)
        Me.lb_pesan.TabIndex = 6
        Me.lb_pesan.Text = "Isi pesan isi pesan isi pesan"
        '
        'bt_jumlah_pesan_baru
        '
        Me.bt_jumlah_pesan_baru.AnimationHoverSpeed = 0.07!
        Me.bt_jumlah_pesan_baru.AnimationSpeed = 0.03!
        Me.bt_jumlah_pesan_baru.BaseColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.bt_jumlah_pesan_baru.BorderColor = System.Drawing.Color.Black
        Me.bt_jumlah_pesan_baru.Enabled = False
        Me.bt_jumlah_pesan_baru.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.bt_jumlah_pesan_baru.ForeColor = System.Drawing.Color.White
        Me.bt_jumlah_pesan_baru.Image = Nothing
        Me.bt_jumlah_pesan_baru.ImageSize = New System.Drawing.Size(20, 20)
        Me.bt_jumlah_pesan_baru.Location = New System.Drawing.Point(220, 99)
        Me.bt_jumlah_pesan_baru.Name = "bt_jumlah_pesan_baru"
        Me.bt_jumlah_pesan_baru.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_jumlah_pesan_baru.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bt_jumlah_pesan_baru.OnHoverForeColor = System.Drawing.Color.White
        Me.bt_jumlah_pesan_baru.OnHoverImage = Nothing
        Me.bt_jumlah_pesan_baru.OnPressedColor = System.Drawing.Color.Black
        Me.bt_jumlah_pesan_baru.Radius = 4
        Me.bt_jumlah_pesan_baru.Size = New System.Drawing.Size(20, 20)
        Me.bt_jumlah_pesan_baru.TabIndex = 7
        Me.bt_jumlah_pesan_baru.Text = "5"
        Me.bt_jumlah_pesan_baru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'p_aktif
        '
        Me.p_aktif.BaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.p_aktif.Location = New System.Drawing.Point(48, 77)
        Me.p_aktif.Name = "p_aktif"
        Me.p_aktif.Size = New System.Drawing.Size(8, 8)
        Me.p_aktif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_aktif.TabIndex = 3
        Me.p_aktif.TabStop = False
        Me.p_aktif.UseTransfarantBackground = False
        '
        'p_picture
        '
        Me.p_picture.BaseColor = System.Drawing.Color.White
        Me.p_picture.Location = New System.Drawing.Point(22, 57)
        Me.p_picture.Name = "p_picture"
        Me.p_picture.Size = New System.Drawing.Size(28, 28)
        Me.p_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_picture.TabIndex = 2
        Me.p_picture.TabStop = False
        Me.p_picture.UseTransfarantBackground = False
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.GunaSeparator1.Location = New System.Drawing.Point(22, 134)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(218, 1)
        Me.GunaSeparator1.TabIndex = 8
        '
        'GunaMouseStateHelper1
        '
        Me.GunaMouseStateHelper1.BackColor = System.Drawing.Color.Transparent
        Me.GunaMouseStateHelper1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaMouseStateHelper1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaMouseStateHelper1.Location = New System.Drawing.Point(0, 0)
        Me.GunaMouseStateHelper1.Name = "GunaMouseStateHelper1"
        Me.GunaMouseStateHelper1.Size = New System.Drawing.Size(260, 135)
        Me.GunaMouseStateHelper1.TabIndex = 9
        '
        'ChatButtonItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.GunaMouseStateHelper1)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.bt_jumlah_pesan_baru)
        Me.Controls.Add(Me.lb_pesan)
        Me.Controls.Add(Me.lb_lokasi_pengirim)
        Me.Controls.Add(Me.lb_waktu)
        Me.Controls.Add(Me.p_aktif)
        Me.Controls.Add(Me.p_picture)
        Me.Controls.Add(Me.lb_nama_kontak)
        Me.Controls.Add(Me.lb_asal)
        Me.Name = "ChatButtonItem"
        Me.Size = New System.Drawing.Size(260, 135)
        CType(Me.p_aktif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_asal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_nama_kontak As Guna.UI.WinForms.GunaLabel
    Friend WithEvents p_picture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents p_aktif As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lb_waktu As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_lokasi_pengirim As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_pesan As Guna.UI.WinForms.GunaLabel
    Friend WithEvents bt_jumlah_pesan_baru As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaMouseStateHelper1 As Guna.UI.WinForms.GunaMouseStateHelper
End Class
