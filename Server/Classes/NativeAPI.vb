Imports System.Runtime.InteropServices

Public Class NativeAPI
    <DllImport("kernel32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function SetProcessWorkingSetSize(ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
    End Function
    Public Declare Function NtTerminateProcess Lib "ntdll.dll" (hfandle As IntPtr, ErrorStatus As Integer) As UInteger
    <DllImport("psapi")>
    Public Shared Function EmptyWorkingSet(ByVal hfandle As IntPtr) As Boolean
    End Function
End Class
