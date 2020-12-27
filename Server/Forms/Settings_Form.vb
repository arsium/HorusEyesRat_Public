Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Settings_Form
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        If Me.WindowState = FormWindowState.Maximized Then

            Me.WindowState = FormWindowState.Normal

        Else

            Me.WindowState = FormWindowState.Minimized

        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dark.Start()
    End Sub

    Private Sub Settings_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MKWFGA.Animations.Animation(Me.Handle, 250, MKWFGA.Animations.AnimtedFlags.Blend)
        Me.ShowInTaskbar = False
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click

        For i = 0 To AeroListView1.Items.Count - 1
            If AeroListView1.Items(i).Text = AeroListView1.SelectedItems(0).Text Then
                AeroListView1.Items(i).Remove()
                Exit For
            End If
        Next
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim I As String = InputBox("Add a port : ")

        AeroListView1.Items.Add(I)
    End Sub

    Private Async Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Await Task.Run(Sub()
                           Dim Settings_Txt As New StringBuilder
                           If Pass_CHK.Checked = True Then
                               Settings_Txt.Append("1,")
                           Else
                               Settings_Txt.Append("0,")
                           End If
                           If Hist_CHK.Checked = True Then
                               Settings_Txt.Append("1,")
                           Else
                               Settings_Txt.Append("0,")
                           End If
                           If WF_CHK.Checked = True Then
                               Settings_Txt.Append("1")
                           Else
                               Settings_Txt.Append("0")
                           End If

                           IO.File.WriteAllText("Settings.ini", Settings_Txt.ToString)
                       End Sub)
    End Sub

    Private Sub Custom_Button1_Click_1(sender As Object, e As EventArgs) Handles Custom_Button1.Click
        Me.Hide()
    End Sub
End Class