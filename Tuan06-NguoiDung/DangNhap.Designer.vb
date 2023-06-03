<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        btDangNhap = New Button()
        btThoat = New Button()
        Label1 = New Label()
        Label2 = New Label()
        tbTenDangNhap = New TextBox()
        tbMatKhau = New TextBox()
        SuspendLayout()
        ' 
        ' btDangNhap
        ' 
        btDangNhap.Location = New Point(117, 232)
        btDangNhap.Name = "btDangNhap"
        btDangNhap.Size = New Size(75, 23)
        btDangNhap.TabIndex = 0
        btDangNhap.Text = "Dang nhap"
        btDangNhap.UseVisualStyleBackColor = True
        ' 
        ' btThoat
        ' 
        btThoat.Location = New Point(233, 232)
        btThoat.Name = "btThoat"
        btThoat.Size = New Size(75, 23)
        btThoat.TabIndex = 1
        btThoat.Text = "Thoat"
        btThoat.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(117, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 2
        Label1.Text = "Ten dang nhap"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(117, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 2
        Label2.Text = "Mat khau"
        ' 
        ' tbTenDangNhap
        ' 
        tbTenDangNhap.Location = New Point(208, 89)
        tbTenDangNhap.Name = "tbTenDangNhap"
        tbTenDangNhap.Size = New Size(100, 23)
        tbTenDangNhap.TabIndex = 3
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(208, 149)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.PasswordChar = "*"c
        tbMatKhau.Size = New Size(100, 23)
        tbMatKhau.TabIndex = 3
        ' 
        ' frmDangNhap
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 349)
        Controls.Add(tbMatKhau)
        Controls.Add(tbTenDangNhap)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btThoat)
        Controls.Add(btDangNhap)
        Name = "frmDangNhap"
        Text = "DangNhap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btDangNhap As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents tbMatKhau As TextBox
End Class
