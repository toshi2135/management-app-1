<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        MenuStrip1 = New MenuStrip()
        HeThongToolStripMenuItem = New ToolStripMenuItem()
        QuanLyToolStripMenuItem = New ToolStripMenuItem()
        NghiepVuToolStripMenuItem = New ToolStripMenuItem()
        NguoiDungToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {HeThongToolStripMenuItem, QuanLyToolStripMenuItem, NghiepVuToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HeThongToolStripMenuItem
        ' 
        HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem"
        HeThongToolStripMenuItem.Size = New Size(69, 20)
        HeThongToolStripMenuItem.Text = "He thong"
        ' 
        ' QuanLyToolStripMenuItem
        ' 
        QuanLyToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NguoiDungToolStripMenuItem})
        QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem"
        QuanLyToolStripMenuItem.Size = New Size(60, 20)
        QuanLyToolStripMenuItem.Text = "Quan ly"
        ' 
        ' NghiepVuToolStripMenuItem
        ' 
        NghiepVuToolStripMenuItem.Name = "NghiepVuToolStripMenuItem"
        NghiepVuToolStripMenuItem.Size = New Size(74, 20)
        NghiepVuToolStripMenuItem.Text = "Nghiep vu"
        ' 
        ' NguoiDungToolStripMenuItem
        ' 
        NguoiDungToolStripMenuItem.Name = "NguoiDungToolStripMenuItem"
        NguoiDungToolStripMenuItem.Size = New Size(180, 22)
        NguoiDungToolStripMenuItem.Text = "Nguoi dung"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmMain"
        Text = "Main"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HeThongToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuanLyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NguoiDungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NghiepVuToolStripMenuItem As ToolStripMenuItem
End Class
