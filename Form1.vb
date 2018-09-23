Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Single
        r = TextBox1.Text
        TextBox2.Text = Math.PI * r ^ 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress ''判断是否是数字、小数点、退格键，如果不是，则不输入
        If Not ((e.KeyChar >= "0") And (e.KeyChar <= "9") Or (e.KeyChar = ".") Or e.KeyChar = Chr(8)) Then ''有两种实现方法，一种是在输入中限制数据，keychar/ascii码值 判断，另一种是输入后，失去焦点时判断，最好用正则表达式判断
            e.Handled = True
        End If
    End Sub
End Class
