Imports System.Runtime.InteropServices

Public Class NativeAPI

    'https://www.fluxbytes.com/csharp/delete-files-or-folders-to-recycle-bin-in-c/
    Public Const FO_DELETE As Integer = &H3
    Public Const FOF_ALLOWUNDO As Integer = &H40
    Public Const FOF_NOCONFIRMATION As Integer = &H10

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)>
    Public Structure SHFILEOPSTRUCT
        Public hwnd As IntPtr
        <MarshalAs(UnmanagedType.U4)>
        Public wFunc As Integer
        Public pFrom As String
        Public pTo As String
        Public fFlags As Short
        <MarshalAs(UnmanagedType.Bool)>
        Public fAnyOperationsAborted As Boolean
        Public hNameMappings As IntPtr
        Public lpszProgressTitle As String
    End Structure

    <DllImport("shell32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function SHFileOperation(ByRef FileOp As SHFILEOPSTRUCT) As Integer

    End Function
End Class
