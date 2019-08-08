Imports Guna.UI.WinForms

Public Class ChatButtonItem


    Public Property CustomAsal As String
        Get
            Return lb_asal.Text
        End Get
        Set(value As String)
            lb_asal.Text = value
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property

    Public Property CustomNamaKontak As String
        Get
            Return lb_nama_kontak.Text
        End Get
        Set(value As String)
            lb_nama_kontak.Text = value
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property

    Public Property CustomLokasiPengirim As String
        Get
            Return lb_lokasi_pengirim.Text
        End Get
        Set(value As String)
            lb_lokasi_pengirim.Text = value
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property

    Public Property CustomPicture As Image
        Get
            Return p_picture.Image
        End Get
        Set(value As Image)
            p_picture.Image = value
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property

    Private _CustomAktif As Boolean
    Public Property CustomAktif As Boolean
        Get
            Return _CustomAktif
        End Get
        Set(value As Boolean)
            _CustomAktif = value
            If value Then
                p_aktif.BaseColor = Color.FromArgb(33, 203, 170)
            Else
                p_aktif.BaseColor = Color.FromArgb(252, 69, 96)
            End If
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property

    Private _CustomJumlahPesanBaru As Integer
    Public Property CustomJumlahPesanBaru As Integer
        Get
            Return _CustomJumlahPesanBaru
        End Get
        Set(value As Integer)
            _CustomJumlahPesanBaru = value
            If value > 0 Then
                bt_jumlah_pesan_baru.Visible = True
                bt_jumlah_pesan_baru.Text = value
            Else
                bt_jumlah_pesan_baru.Visible = False
            End If
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property

    Public Property CustomWaktu As String
        Get
            Return lb_waktu.Text
        End Get
        Set(value As String)
            lb_waktu.Text = value
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property

    Public Property CustomPesan As String
        Get
            Return lb_pesan.Text
        End Get
        Set(value As String)
            lb_pesan.Text = value
            GunaMouseStateHelper1.RefreshMouseState()
        End Set
    End Property

    Public Event CheckedChanged As EventHandler
    Private _checked As Boolean

    Public Property Checked As Boolean
        Get
            Return _checked
        End Get
        Set(value As Boolean)
            Guna.UI.Lib.OtherHelper.OnlyOneChecked(Me)
            _checked = value
            GunaMouseStateHelper1.RefreshMouseState()
            If CheckedChangedEvent IsNot Nothing Then
                RaiseEvent CheckedChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property



    Private Sub GunaMouseStateHelper1_MouseStateChanged(sender As Object, state As MouseState) Handles GunaMouseStateHelper1.MouseStateChanged
        If Checked Then
            Me.BackColor = Color.FromArgb(25, 34, 41)
        Else
            Select Case state
                Case MouseState.DOWN
                    Me.BackColor = Color.FromArgb(25, 34, 41)
                Case MouseState.HOVER
                    Me.BackColor = Color.FromArgb(46, 57, 71)
                Case MouseState.OUT
                    Me.BackColor = Color.FromArgb(31, 39, 49)
            End Select
        End If

    End Sub

    Private Sub GunaMouseStateHelper1_Click(sender As Object, e As EventArgs) Handles GunaMouseStateHelper1.Click
        If Checked = False Then
            Checked = True
        End If
    End Sub
End Class
