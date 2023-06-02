Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbDanhSach.Items.Add("Phan tu 1")
        lbDanhSach.Items.Add("Phan tu 2")
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        If String.IsNullOrEmpty(tbGiaTri.Text) = False Then
            lbDanhSach.Items.Add(tbGiaTri.Text)
        End If
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        If String.IsNullOrEmpty(tbGiaTri.Text) = False Then
            If lbDanhSach.SelectedIndex >= 0 Then
                lbDanhSach.Items(lbDanhSach.SelectedIndex) = tbGiaTri.Text
            End If
        End If
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        If lbDanhSach.SelectedIndex >= 0 Then
            lbDanhSach.Items.RemoveAt(lbDanhSach.SelectedIndex)
        End If
    End Sub

    Private Sub lbDanhSach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDanhSach.SelectedIndexChanged

    End Sub
End Class
