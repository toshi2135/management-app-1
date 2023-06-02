<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lbLoaiSanPham = New ListBox()
        btThem = New Button()
        btSua = New Button()
        btXoa = New Button()
        tbTen = New TextBox()
        SuspendLayout()
        ' 
        ' lbLoaiSanPham
        ' 
        lbLoaiSanPham.FormattingEnabled = True
        lbLoaiSanPham.ItemHeight = 15
        lbLoaiSanPham.Location = New Point(35, 28)
        lbLoaiSanPham.Name = "lbLoaiSanPham"
        lbLoaiSanPham.Size = New Size(120, 94)
        lbLoaiSanPham.TabIndex = 0
        ' 
        ' btThem
        ' 
        btThem.Location = New Point(236, 99)
        btThem.Name = "btThem"
        btThem.Size = New Size(75, 23)
        btThem.TabIndex = 1
        btThem.Text = "Them"
        btThem.UseVisualStyleBackColor = True
        ' 
        ' btSua
        ' 
        btSua.Location = New Point(317, 99)
        btSua.Name = "btSua"
        btSua.Size = New Size(75, 23)
        btSua.TabIndex = 1
        btSua.Text = "Cap nhat"
        btSua.UseVisualStyleBackColor = True
        ' 
        ' btXoa
        ' 
        btXoa.Location = New Point(398, 99)
        btXoa.Name = "btXoa"
        btXoa.Size = New Size(75, 23)
        btXoa.TabIndex = 1
        btXoa.Text = "Xoa"
        btXoa.UseVisualStyleBackColor = True
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(236, 28)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(238, 23)
        tbTen.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tbTen)
        Controls.Add(btXoa)
        Controls.Add(btSua)
        Controls.Add(btThem)
        Controls.Add(lbLoaiSanPham)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbLoaiSanPham As ListBox
    Friend WithEvents btThem As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents tbTen As TextBox
End Class
