Public Class Form2
    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsSanPham = DuLieu.DocDuLieu("SELECT SanPham.*, LoaiSanPham.Ten AS TenLoai FROM SanPham, LoaiSanPham WHERE LoaiSanPham.Ma = SanPham.MaLoai")
        dsSanPhamView = New DataView(dsSanPham)
        dgvDanhSach.DataSource = dsSanPhamView
        dgvDanhSach.Columns(4).Visible = False

        Dim dsLoaiSanPham = DuLieu.DocDuLieu("SELECT * FROM LoaiSanPham")
        cbLoai.DataSource = dsLoaiSanPham
        cbLoai.DisplayMember = "Ten"
        cbLoai.ValueMember = "Ma"
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim sp As DataRow = dsSanPham.NewRow()
        sp("Ten") = tbTen.Text
        sp("SoLuong") = Integer.Parse(tbSoLuong.Text)
        sp("Gia") = Integer.Parse(tbGia.Text)
        sp("MaLoai") = cbLoai.SelectedValue
        sp("TenLoai") = cbLoai.SelectedItem("Ten")

        dsSanPham.Rows.Add(sp)

        DuLieu.GhiDuLieu("SanPham", dsSanPham)
    End Sub

    Private Sub dgvDanhSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSach.SelectionChanged
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim spv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim sp As DataRow = spv.Row
            tbTen.Text = sp("Ten")
            tbSoLuong.Text = sp("SoLuong")
            tbGia.Text = sp("Gia")
            cbLoai.SelectedValue = sp("MaLoai")
        End If
    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim spv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            If spv Is Nothing Then
                Return
            End If
            Dim sp As DataRow = spv.Row
            sp("Ten") = tbTen.Text
            sp("SoLuong") = Integer.Parse(tbSoLuong.Text)
            sp("Gia") = Integer.Parse(tbGia.Text)
            sp("MaLoai") = cbLoai.SelectedValue
            sp("TenLoai") = cbLoai.SelectedItem("Ten")
            DuLieu.GhiDuLieu("SanPham", dsSanPham)
        End If
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim spv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim sp As DataRow = spv.Row
            sp.Delete() 'Khong dung Rows.Remove(sp) vi se khong cap nhat duoc du lieu
            DuLieu.GhiDuLieu("SanPham", dsSanPham)
        End If
    End Sub

    Private Sub tbTim_TextChanged(sender As Object, e As EventArgs) Handles tbTim.TextChanged
        If String.IsNullOrEmpty(tbTim.Text) = False Then
            dsSanPhamView.RowFilter = "Ten LIKE '%" + tbTim.Text + "%'"
        Else
            dsSanPhamView.RowFilter = ""
        End If
    End Sub
End Class