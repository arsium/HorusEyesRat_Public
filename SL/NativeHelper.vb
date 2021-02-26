Imports System.Runtime.InteropServices
Imports System.Windows.Forms

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

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function SetWindowsHookEx(ByVal id As Integer, ByVal callback As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr

    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function GetModuleHandle(ByVal name As String) As IntPtr

    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure KBDLLHOOKSTRUCT
        Public key As Keys
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public extra As IntPtr
    End Structure

    Public Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function UnhookWindowsHookEx(ByVal hook As IntPtr) As Boolean

    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function CallNextHookEx(ByVal hook As IntPtr, ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr

    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function GetAsyncKeyState(ByVal key As Keys) As Short

    End Function
    Public Shared ptrHook As IntPtr
    Public Shared callback As LowLevelKeyboardProc
    Public Sub HookKeyboard()

        callback = New LowLevelKeyboardProc(AddressOf BlockKey)

        SetWindowsHookEx(13, callback, Process.GetCurrentProcess.MainModule.BaseAddress, 0)

    End Sub

    Public Shared Function BlockKey(ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr)

        If nCode >= 0 Then

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

        ' Return NativeAPI.CallNextHookEx(NativeAPI.ptrHook, nCode, wp, lp)



        '   Else

        '  Return CallNextHookEx(ptrHook, nCode, wp, lp)
        ' End If
    End Function

End Class