Imports System.Runtime.InteropServices

Public Class NativeAPI
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As WM_Message, ByVal wParam As SC_Message, ByVal lParam As IntPtr) As IntPtr
    End Function
    Public Enum WM_Message As UInteger
        WM_SYSCOMMAND = &H112
    End Enum
    Public Enum SC_Message As UInteger
        SC_CLOSE = &HF060
    End Enum
    <DllImport("ntdll.dll")>
    Public Shared Function NtTerminateProcess(ByVal ProcHandle As IntPtr, Optional ByVal ErrorStatus As Integer = 0) As UInteger
    End Function
    <DllImport("ntdll.dll")>
    Public Shared Function ZwTerminateProcess(ByVal ProcHandle As IntPtr, Optional ByVal ErrorStatus As Integer = 0) As UInteger
    End Function
    <DllImport("kernel32.dll")>
    Public Shared Function TerminateProcess(ByVal Handle As IntPtr, ByVal uExitCoed As UInteger) As Boolean
    End Function


    <DllImport("ntdll.dll")>
    Public Shared Function NtSuspendProcess(ByVal ProcHandle As IntPtr) As UInteger
    End Function
    <DllImport("ntdll.dll")>
    Public Shared Function ZwSuspendProcess(ByVal ProcHandle As IntPtr) As UInteger
    End Function
    <DllImport("ntdll.dll")>
    Public Shared Function NtResumeProcess(ByVal ProcessHandle As IntPtr) As UInteger
    End Function

    <DllImport("ntdll.dll")>
    Public Shared Function ZwResumeProcess(ByVal ProcessHandle As IntPtr) As UInteger
    End Function

End Class
