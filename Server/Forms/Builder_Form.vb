Public Class Builder_Form
    Private Sub Custom_Button1_Click(sender As Object, e As EventArgs) Handles Custom_Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim B As New Helpers.Builder
        B.Build(New Object() {NumericUpDown1.Value, TextBox1.Text, CheckBox1.Checked, CheckBox2.Checked, CheckBox3.Checked, CheckBox4.Checked, CheckBox5.Checked, TextBox2.Text, TextBox3.Text})
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            TextBox2.Enabled = True
            TextBox3.Enabled = True
        Else
            TextBox2.Enabled = False
            TextBox3.Enabled = False
        End If
    End Sub
End Class