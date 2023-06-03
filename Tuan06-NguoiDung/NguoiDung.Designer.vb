<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNguoiDung
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
        dgvNguoiDung = New DataGridView()
        Label1 = New Label()
        btThem = New Button()
        tbTen = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        tbCMND = New TextBox()
        tbDienThoai = New TextBox()
        tbDiaChi = New TextBox()
        tbTenDangNhap = New TextBox()
        tbMatKhau = New TextBox()
        dtpNgaySinh = New DateTimePicker()
        btSua = New Button()
        btXoa = New Button()
        CType(dgvNguoiDung, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvNguoiDung
        ' 
        dgvNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNguoiDung.Location = New Point(12, 12)
        dgvNguoiDung.Name = "dgvNguoiDung"
        dgvNguoiDung.RowTemplate.Height = 25
        dgvNguoiDung.Size = New Size(517, 426)
        dgvNguoiDung.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(552, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 1
        Label1.Text = "Ten"
        ' 
        ' btThem
        ' 
        btThem.Location = New Point(552, 337)
        btThem.Name = "btThem"
        btThem.Size = New Size(75, 23)
        btThem.TabIndex = 2
        btThem.Text = "Them"
        btThem.UseVisualStyleBackColor = True
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(664, 12)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(100, 23)
        tbTen.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(548, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 1
        Label2.Text = "CMND"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(549, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 1
        Label3.Text = "Dien thoai"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(548, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 1
        Label4.Text = "Ngay sinh"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(549, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 1
        Label5.Text = "Dia chi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(549, 246)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 15)
        Label6.TabIndex = 1
        Label6.Text = "Ten dang nhap"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(552, 277)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 15)
        Label7.TabIndex = 1
        Label7.Text = "Mat khau"
        ' 
        ' tbCMND
        ' 
        tbCMND.Location = New Point(664, 47)
        tbCMND.Name = "tbCMND"
        tbCMND.Size = New Size(100, 23)
        tbCMND.TabIndex = 3
        ' 
        ' tbDienThoai
        ' 
        tbDienThoai.Location = New Point(665, 82)
        tbDienThoai.Name = "tbDienThoai"
        tbDienThoai.Size = New Size(100, 23)
        tbDienThoai.TabIndex = 3
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(664, 178)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(100, 23)
        tbDiaChi.TabIndex = 3
        ' 
        ' tbTenDangNhap
        ' 
        tbTenDangNhap.Location = New Point(664, 243)
        tbTenDangNhap.Name = "tbTenDangNhap"
        tbTenDangNhap.Size = New Size(100, 23)
        tbTenDangNhap.TabIndex = 3
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(664, 272)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.Size = New Size(100, 23)
        tbMatKhau.TabIndex = 3
        ' 
        ' dtpNgaySinh
        ' 
        dtpNgaySinh.CustomFormat = "dd/MM/yyyy"
        dtpNgaySinh.Format = DateTimePickerFormat.Custom
        dtpNgaySinh.Location = New Point(664, 149)
        dtpNgaySinh.Name = "dtpNgaySinh"
        dtpNgaySinh.Size = New Size(100, 23)
        dtpNgaySinh.TabIndex = 4
        ' 
        ' btSua
        ' 
        btSua.Location = New Point(633, 337)
        btSua.Name = "btSua"
        btSua.Size = New Size(75, 23)
        btSua.TabIndex = 2
        btSua.Text = "Sua"
        btSua.UseVisualStyleBackColor = True
        ' 
        ' btXoa
        ' 
        btXoa.Location = New Point(714, 337)
        btXoa.Name = "btXoa"
        btXoa.Size = New Size(75, 23)
        btXoa.TabIndex = 2
        btXoa.Text = "Xoa"
        btXoa.UseVisualStyleBackColor = True
        ' 
        ' frmNguoiDung
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dtpNgaySinh)
        Controls.Add(tbMatKhau)
        Controls.Add(tbTenDangNhap)
        Controls.Add(tbDiaChi)
        Controls.Add(tbDienThoai)
        Controls.Add(tbCMND)
        Controls.Add(tbTen)
        Controls.Add(btXoa)
        Controls.Add(btSua)
        Controls.Add(btThem)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvNguoiDung)
        Name = "frmNguoiDung"
        Text = "Nguoi dung"
        CType(dgvNguoiDung, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvNguoiDung As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btThem As Button
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbCMND As TextBox
    Friend WithEvents tbDienThoai As TextBox
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents btSua As Button
    Friend WithEvents btXoa As Button
End Class
