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
        lbDanhSach = New ListBox()
        tbGiaTri = New TextBox()
        btThem = New Button()
        btSua = New Button()
        btXoa = New Button()
        SuspendLayout()
        ' 
        ' lbDanhSach
        ' 
        lbDanhSach.FormattingEnabled = True
        lbDanhSach.ItemHeight = 15
        lbDanhSach.Location = New Point(34, 25)
        lbDanhSach.Name = "lbDanhSach"
        lbDanhSach.Size = New Size(169, 364)
        lbDanhSach.TabIndex = 0
        ' 
        ' tbGiaTri
        ' 
        tbGiaTri.Location = New Point(258, 42)
        tbGiaTri.Name = "tbGiaTri"
        tbGiaTri.Size = New Size(100, 23)
        tbGiaTri.TabIndex = 1
        ' 
        ' btThem
        ' 
        btThem.Location = New Point(258, 112)
        btThem.Name = "btThem"
        btThem.Size = New Size(75, 23)
        btThem.TabIndex = 2
        btThem.Text = "Them"
        btThem.UseVisualStyleBackColor = True
        ' 
        ' btSua
        ' 
        btSua.Location = New Point(372, 112)
        btSua.Name = "btSua"
        btSua.Size = New Size(75, 23)
        btSua.TabIndex = 3
        btSua.Text = "Cap nhat"
        btSua.UseVisualStyleBackColor = True
        ' 
        ' btXoa
        ' 
        btXoa.Location = New Point(490, 112)
        btXoa.Name = "btXoa"
        btXoa.Size = New Size(75, 23)
        btXoa.TabIndex = 4
        btXoa.Text = "Xoa"
        btXoa.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btXoa)
        Controls.Add(btSua)
        Controls.Add(btThem)
        Controls.Add(tbGiaTri)
        Controls.Add(lbDanhSach)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbDanhSach As ListBox
    Friend WithEvents tbGiaTri As TextBox
    Friend WithEvents btThem As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btXoa As Button
End Class
