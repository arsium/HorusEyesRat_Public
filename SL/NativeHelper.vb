Imports System.Runtime.InteropServices

Public Class NativeHelper
    <DllImport("user32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Int32, ByVal Y As Int32, ByVal cx As Int32, ByVal cy As Int32, ByVal uFlags As Int32) As Boolean
    End Function

    Public Const HWND_BOTTOM = 1
    Public Const HWND_NOTOPMOST = -2
    Public Const HWND_TOP = 0
    Public Const HWND_TOPMOST = -1


    Public Const SWP_NOSIZE As Int32 = &H1
    Public Const SWP_NOMOVE As Int32 = &H2
    Public Const SWP_NOREDRAW As Int32 = &H8
    Public Const SWP_DEFERERASE As Int32 = &H2000

End Class

Public Class KeyBoardHooking

    Private Const WM_KEYDOWN As Short = &H100S
    Private Const WM_SYSKEYDOWN As Integer = &H104

    Public Structure KBDLLHOOKSTRUCT
        Public vkCode As Integer
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer
    End Structure

    Private Declare Function UnhookWindowsHookEx Lib "user32" (ByVal hHook As Integer) As Integer

    Private Declare Function SetWindowsHookEx Lib "user32" Alias "SetWindowsHookExA" (ByVal idHook As Integer, ByVal lpfn As KeyboardHookDelegate, ByVal hmod As Integer, ByVal dwThreadId As Integer) As Integer

    Private Declare Function CallNextHookEx Lib "user32" (ByVal hHook As Integer, ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As KBDLLHOOKSTRUCT) As Integer

    Private Delegate Function KeyboardHookDelegate(ByVal Code As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer

    Private callback As KeyboardHookDelegate

    Public Sub HookKeyboard()

        callback = New KeyboardHookDelegate(AddressOf KeyboardCallback)

        SetWindowsHookEx(13, callback, Process.GetCurrentProcess.MainModule.BaseAddress, 0)

    End Sub

    Public Function KeyboardCallback(ByVal Code As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer

        Dim Key = lParam.vkCode

        If wParam = WM_KEYDOWN Or wParam = WM_SYSKEYDOWN Then
            'If we can block events
            If Code >= 0 Then
                If Key = 91 Or Key = 92 Then
                    Return 1 'Block event
                End If
            End If
        End If

    End Function

End Class