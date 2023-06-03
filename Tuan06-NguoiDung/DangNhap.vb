Imports System.Security.Principal

Public Class frmDangNhap
    Dim retries As Integer = 0
    Public account As DataRow
    Public dsChiNhanh As DataTable
    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm As frmDangNhap = New frmDangNhap()
        Dim dr As DialogResult = frm.ShowDialog()
        If dr = DialogResult.Yes Then
            MessageBox.Show("Đăng nhập thành công")
            account = frm.account

        Else
            MessageBox.Show("Đăng nhập thất bại")
            Me.Close()
        End If
    End Sub

    Private Sub btDangNhap_Click(sender As Object, e As EventArgs) Handles btDangNhap.Click
        Dim str As String = "
            SELECT tk_MatKhau 
            FROM TaiKhoan, NguoiDung 
            WHERE tk_MaNguoiDung = nd_MaNguoiDung
            AND tk_Xoa = False AND nd_Xoa = False
            AND tk_TenDangNhap LIKE '" + tbTenDangNhap.Text + "'"
        Dim dsTaiKhoan As DataTable = DuLieu.DocDuLieu(str)
        If dsTaiKhoan.Rows.Count > 0 Then
            If dsTaiKhoan.Rows(0)("tk_MatKhau") = Util.getHash(tbMatKhau.Text) Then
                str = "SELECT tk_MaTaiKhoan, tk_TenDangNhao, nd_MaNguoiDung, nd_Ten 
                        FROM TaiKhoan, NguoiDung 
                        WHERE tk_MaNguoiDung = nd_MaNguoiDung 
                        AND tk_Xoa = False 
                        AND nd_Xoa = False 
                        AND tk_TenDangNhap LIKE '" + tbTenDangNhap.Text + "'"
                dsTaiKhoan = DuLieu.DocDuLieu(str)
                account = dsTaiKhoan.Rows(0)

                btDangNhap.DialogResult = DialogResult.Yes 'Kiem tra thanh cong

            End If
        End If

        retries += 1
        MessageBox.Show("Sai tên hoặc mật khẩu")
        If retries = 5 Then
            Me.Close()
        End If

    End Sub
End Class