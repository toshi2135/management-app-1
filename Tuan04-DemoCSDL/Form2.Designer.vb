<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        dgvDanhSach = New DataGridView()
        tbTen = New TextBox()
        tbSoLuong = New TextBox()
        tbGia = New TextBox()
        cbLoai = New ComboBox()
        btThem = New Button()
        btCapNhat = New Button()
        btXoa = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        tbTim = New TextBox()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDanhSach
        ' 
        dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSach.Location = New Point(26, 63)
        dgvDanhSach.Name = "dgvDanhSach"
        dgvDanhSach.RowTemplate.Height = 25
        dgvDanhSach.Size = New Size(405, 350)
        dgvDanhSach.TabIndex = 0
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(564, 63)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(100, 23)
        tbTen.TabIndex = 1
        ' 
        ' tbSoLuong
        ' 
        tbSoLuong.Location = New Point(564, 113)
        tbSoLuong.Name = "tbSoLuong"
        tbSoLuong.Size = New Size(100, 23)
        tbSoLuong.TabIndex = 1
        ' 
        ' tbGia
        ' 
        tbGia.Location = New Point(564, 170)
        tbGia.Name = "tbGia"
        tbGia.Size = New Size(100, 23)
        tbGia.TabIndex = 1
        ' 
        ' cbLoai
        ' 
        cbLoai.FormattingEnabled = True
        cbLoai.Location = New Point(564, 222)
        cbLoai.Name = "cbLoai"
        cbLoai.Size = New Size(121, 23)
        cbLoai.TabIndex = 2
        ' 
        ' btThem
        ' 
        btThem.Location = New Point(462, 285)
        btThem.Name = "btThem"
        btThem.Size = New Size(75, 23)
        btThem.TabIndex = 3
        btThem.Text = "Them"
        btThem.UseVisualStyleBackColor = True
        ' 
        ' btCapNhat
        ' 
        btCapNhat.Location = New Point(564, 285)
        btCapNhat.Name = "btCapNhat"
        btCapNhat.Size = New Size(75, 23)
        btCapNhat.TabIndex = 3
        btCapNhat.Text = "Cap nhat"
        btCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btXoa
        ' 
        btXoa.Location = New Point(665, 285)
        btXoa.Name = "btXoa"
        btXoa.Size = New Size(75, 23)
        btXoa.TabIndex = 3
        btXoa.Text = "Xoa"
        btXoa.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(460, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 4
        Label1.Text = "Ten"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(460, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 4
        Label2.Text = "So luong"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(462, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 15)
        Label3.TabIndex = 4
        Label3.Text = "Gia"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(462, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 4
        Label4.Text = "Loai san pham"
        ' 
        ' tbTim
        ' 
        tbTim.Location = New Point(26, 34)
        tbTim.Name = "tbTim"
        tbTim.Size = New Size(405, 23)
        tbTim.TabIndex = 5
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tbTim)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btXoa)
        Controls.Add(btCapNhat)
        Controls.Add(btThem)
        Controls.Add(cbLoai)
        Controls.Add(tbGia)
        Controls.Add(tbSoLuong)
        Controls.Add(tbTen)
        Controls.Add(dgvDanhSach)
        Name = "Form2"
        Text = "Form2"
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbSoLuong As TextBox
    Friend WithEvents tbGia As TextBox
    Friend WithEvents cbLoai As ComboBox
    Friend WithEvents btThem As Button
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbTim As TextBox
End Class
