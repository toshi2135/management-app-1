Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bGiaiPT_Click(sender As Object, e As EventArgs) Handles bGiaiPT.Click
        Dim a As Double = Integer.Parse(txtA.Text)
        Dim b As Double = Integer.Parse(txtB.Text)

        Dim nghiem As Double
        Dim SoNghiem As Integer = GiaiPTB1(a, b, nghiem)
        Dim chuoi As String
        If SoNghiem = -1 Then
            chuoi = "Phuong trinh co vo so nghiem"
        ElseIf SoNghiem = 0 Then
            chuoi = "Phuong trinh vo nghiem"
        Else
            chuoi = String.Format("Phuong trinh co 1 nghiem x = {0}", nghiem)
        End If

        lbKetQua.Text = chuoi

    End Sub

    Function GiaiPTB1(ByVal a As Double, ByVal b As Double, ByRef nghiem As Double) As Integer
        Dim SoNghiem As Integer
        If a = 0 Then
            If b = 0 Then
                SoNghiem = -1 'Vo so nghiem
            Else
                SoNghiem = 0 'Vo nghiem
            End If
        Else
            SoNghiem = 1 'Co 1 nghiem
            nghiem = -b / a
        End If
        Return SoNghiem
    End Function

End Class
