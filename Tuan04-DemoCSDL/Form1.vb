Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DocDSLoaiSanPham()
    End Sub

    Sub DocDSLoaiSanPham()
        Dim connection As OleDbConnection = New OleDbConnection(DuLieu.conn_string)
        Dim command As OleDbCommand = New OleDbCommand("SELECT * FROM LoaiSanPham", connection)
        connection.Open()
        Dim data As OleDbDataReader = command.ExecuteReader()
        While data.Read()
            Dim str As String = ""
            str = str + data("Ma").ToString()
            str = str + " - " + data("Ten")
            lbLoaiSanPham.Items.Add(str)
        End While
        connection.Close()
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim ten As String = tbTen.Text
        Dim connection As OleDbConnection = New OleDbConnection(DuLieu.conn_string)
        Dim command As OleDbCommand = New OleDbCommand("INSERT INTO LoaiSanPham(Ten) VALUES(?)", connection)
        command.Parameters.AddWithValue("@Ten", ten)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        lbLoaiSanPham.Items.Clear()
        DocDSLoaiSanPham()
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        If lbLoaiSanPham.SelectedIndex > 0 Then
            Dim str As String = lbLoaiSanPham.SelectedItem.ToString()
            Dim ma As String = str(0)
            Dim connection As OleDbConnection = New OleDbConnection(DuLieu.conn_string)
            Dim command As OleDbCommand = New OleDbCommand("DELETE FROM LoaiSanPham WHERE Ma = ?", connection)
            command.Parameters.AddWithValue("@Ma", ma)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            lbLoaiSanPham.Items.Clear()
            DocDSLoaiSanPham()
        End If
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim str As String = lbLoaiSanPham.SelectedItem.ToString()
        Dim ma As String = str(0)
        Dim connection As OleDbConnection = New OleDbConnection(DuLieu.conn_string)
        Dim command As OleDbCommand = New OleDbCommand("UPDATE LoaiSanPham SET Ten = ? WHERE Ma = ?", connection)
        command.Parameters.AddWithValue("@Ten", tbTen.Text)
        command.Parameters.AddWithValue("@Ma", ma)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        lbLoaiSanPham.Items.Clear()
        DocDSLoaiSanPham()
    End Sub
End Class
