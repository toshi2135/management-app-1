Imports System.Net.Security

Public Class frmNguoiDung
    Dim dsNguoiDung As DataTable
    Dim dsTaiKhoan As DataTable
    Private Sub frmNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "SELECT * FROM NguoiDung, TaiKhoan WHERE nd_MaNguoiDung = tk_MaNguoiDung AND nd_Xoa = False"
        dsNguoiDung = DuLieu.DocDuLieu(str)

        dgvNguoiDung.DataSource = dsNguoiDung

        dsTaiKhoan = DuLieu.DocCauTruc("SELECT * FROM TaiKhoan")
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        If String.IsNullOrEmpty(tbTenDangNhap.Text) Then
            MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo")
            Return
        Else
            Dim str As String = String.Format("SELECT * FROM TaiKhoan WHERE tk_TenDangNhap LIKE '{0}'", tbTenDangNhap.Text)
            Dim dsTaiKhoan As DataTable = DuLieu.DocDuLieu(str)
            If dsTaiKhoan.Rows.Count > 0 Then
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo")
                Return
            End If
        End If

        Dim user As DataRow = dsNguoiDung.NewRow()
        user("nd_Ten") = tbTen.Text
        user("nd_CMND") = tbCMND.Text
        user("nd_DienThoai") = tbDienThoai.Text
        user("nd_NgaySinh") = dtpNgaySinh.Value
        user("nd_DiaChi") = tbDiaChi.Text
        user("nd_Xoa") = False
        dsNguoiDung.Rows.Add(user)
        DuLieu.GhiDuLieu("NguoiDung", dsNguoiDung)

        Dim account As DataRow = dsTaiKhoan.NewRow()
        user("tk_TenDangNhap") = tbTenDangNhap.Text
        user("tk_MatKhau") = Util.getHash(tbMatKhau.Text)
        dsTaiKhoan.Rows.Add(account)
        DuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)

        user("tk_MaTaiKhoan") = account("tk_MaTaiKhoan")
        dsTaiKhoan.Rows.Remove(account)
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        If dgvNguoiDung.SelectedCells.Count > 0 Then
            Dim nd_View As DataRowView = dgvNguoiDung.Rows(dgvNguoiDung.SelectedCells(0).RowIndex).DataBoundItem
            Dim nd As DataRow = nd_View.Row
            nd("nd_Xoa") = True
            DuLieu.GhiDuLieu("NguoiDung", dsNguoiDung)
            dsNguoiDung.Rows.Remove(nd)
        End If
    End Sub
End Class
