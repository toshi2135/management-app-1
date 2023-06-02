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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtA = New TextBox()
        txtB = New TextBox()
        bGiaiPT = New Button()
        lbKetQua = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 15)
        Label1.TabIndex = 0
        Label1.Text = "Giai phuong trinh ax + b = 0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(16, 15)
        Label2.TabIndex = 1
        Label2.Text = "a:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(17, 15)
        Label3.TabIndex = 2
        Label3.Text = "b:"
        ' 
        ' txtA
        ' 
        txtA.Location = New Point(56, 53)
        txtA.Name = "txtA"
        txtA.PlaceholderText = "Nhap gia tri a la so thuc"
        txtA.Size = New Size(119, 23)
        txtA.TabIndex = 3
        ' 
        ' txtB
        ' 
        txtB.Location = New Point(56, 86)
        txtB.Name = "txtB"
        txtB.PlaceholderText = "Nhap gia tri b la so thuc"
        txtB.Size = New Size(119, 23)
        txtB.TabIndex = 4
        ' 
        ' bGiaiPT
        ' 
        bGiaiPT.Location = New Point(34, 115)
        bGiaiPT.Name = "bGiaiPT"
        bGiaiPT.Size = New Size(156, 23)
        bGiaiPT.TabIndex = 5
        bGiaiPT.Text = "Giai phuong trinh"
        bGiaiPT.UseVisualStyleBackColor = True
        ' 
        ' lbKetQua
        ' 
        lbKetQua.AutoSize = True
        lbKetQua.Location = New Point(34, 166)
        lbKetQua.Name = "lbKetQua"
        lbKetQua.Size = New Size(53, 15)
        lbKetQua.TabIndex = 6
        lbKetQua.Text = "Ket qua: "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbKetQua)
        Controls.Add(bGiaiPT)
        Controls.Add(txtB)
        Controls.Add(txtA)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents bGiaiPT As Button
    Friend WithEvents lbKetQua As Label
End Class
