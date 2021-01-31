Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class NativeAPI
    Public Shared Sub PowerOptions(ByVal flg As Integer, Optional ByVal minRea As Integer = 0)
        Dim t1 As Boolean
        RtlAdjustPrivilege(19, True, False, t1)
        ExitWindowsEx(flg, 0 Or minRea)
    End Sub
    Public Shared Sub BSOD()
        Dim t1 As Boolean
        Dim t2 As UInteger
        RtlAdjustPrivilege(19, True, False, t1)
        NtRaiseHardError(i, 0, 0, IntPtr.Zero, 6, t2)
    End Sub
    Public Shared Sub HIBSUSPEND(ByVal B As Boolean)
        Dim t1 As Boolean
        RtlAdjustPrivilege(19, True, False, t1)
        SetSuspendState(B, True, True)
        '    SetSystemPowerState(B, True)
    End Sub
    Public Shared Sub Hide_TaskBar(ByVal i As Integer)
        ShowWindow(FindWindow("Shell_TrayWnd", Nothing), i)
    End Sub

    Public Shared Sub HSDesktopIcons(ByVal l As Boolean)
        If l = True Then
            Dim handle As IntPtr
            Dim progManager As IntPtr = FindWindow("Progman", Nothing)
            'If (progManager) ??
            Dim desktop As IntPtr = FindWindowEx(progManager, IntPtr.Zero, "SHELLDLL_DefView", Nothing)
            'If (desktop) ??
            handle = FindWindowEx(desktop, IntPtr.Zero, "SysListView32", Nothing)
            ShowWindow(handle, 5)
        Else

            Dim handle As IntPtr
            Dim progManager As IntPtr = FindWindow("Progman", Nothing)
            'If (progManager) ??
            Dim desktop As IntPtr = FindWindowEx(progManager, IntPtr.Zero, "SHELLDLL_DefView", Nothing)
            'If (desktop) ??
            handle = FindWindowEx(desktop, IntPtr.Zero, "SysListView32", Nothing)
            ShowWindow(handle, 0)
        End If
    End Sub
    Public Shared Sub SwapMB(ByVal B As Boolean)
        SwapMouseButton(B)
    End Sub
    Public Shared Sub EmptyBin()
        Try
            SHEmptyRecycleBinA(0, "", 1 Or 2 Or 3)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub CursorVisibility(ByVal B As Boolean)
        NtUserShowSystemCursor(B)
    End Sub

    Public Shared Async Sub SetWallpapertoBackground(ByVal Name As String, ByVal Img As Byte())

        Await Task.Run(Sub() IO.File.WriteAllBytes(IO.Path.GetTempPath + "\" + Name, Img))

        SystemParametersInfo(param1, 0, IO.Path.GetTempPath + "\" + Name, param2 Or param3)

    End Sub

    Const param1 As Integer = 20
    Const param2 As Integer = &H1
    Const param3 As Integer = &H2

    Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer


    <DllImport("win32u.dll", SetLastError:=True, CallingConvention:=CallingConvention.Winapi)>
    Private Shared Function NtUserShowSystemCursor(ByVal bshow As Boolean) As Boolean

    End Function

    <DllImport("Shell32.dll")>
    Public Shared Function SHEmptyRecycleBinA(ByVal hWnd As IntPtr, pszRootPath As String, ByVal FLGs As Integer) As IntPtr

    End Function


    Public Declare Auto Function ShowWindow Lib "user32.dll" (hwnd As IntPtr, nCmdShow As Integer) As Boolean
    Public Declare Auto Function FindWindowEx Lib "user32.dll" (parentHandle As IntPtr, childAfter As IntPtr, lclassName As String, windowTitle As String) As IntPtr
    Public Declare Auto Function FindWindow Lib "user32.dll" (lpClassName As String, lpWindowName As String) As IntPtr
    Public Declare Function SwapMouseButton Lib "user32.dll" (Swap As Boolean) As Boolean

    Private Const i = &HC0000022  ''error code

    <DllImport("user32.dll", ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function ExitWindowsEx(ByVal flg As Integer, ByVal rea As Integer) As Boolean

    End Function


    Friend Const EWX_LOGOFF As Integer = &H0
    Friend Const EWX_SHUTDOWN As Integer = &H1
    Friend Const EWX_REBOOT As Integer = &H2
    Friend Const EWX_FORCE As Integer = &H4
    Friend Const EWX_POWEROFF As Integer = &H8
    Friend Const EWX_FORCEIFHUNG As Integer = &H10

    Friend Const SHTDN_REASON_MINOR_BLUESCREEN = &HF
    Friend Const SHTDN_REASON_MAJOR_SOFTWARE = &H30000

    <DllImport("ntdll.dll")>
    Private Shared Function RtlAdjustPrivilege(ByVal Privilege As Integer, ByVal bEnablePrivilege As Boolean, ByVal IsThreadPrivilege As Boolean, <Out> ByRef PreviousValue As Boolean) As UInteger

    End Function

    <DllImport("ntdll.dll")>
    Private Shared Function NtRaiseHardError(ByVal ErrorStatus As Integer, ByVal NumberOfParameters As UInteger, ByVal UnicodeStringParameterMask As UInteger, ByVal Parameters As IntPtr, ByVal ValidResponseOption As UInteger, <Out> ByRef Response As UInteger) As UInteger

    End Function
    <DllImport("user32.dll")>
    Private Shared Function SetDeskWallpaper(ByVal FileName As String) As Long

    End Function

    ''Those 2 functions are equivalent
    <DllImport("PowrProf.dll", ExactSpelling:=True, SetLastError:=True)>
    Private Shared Function SetSuspendState(ByVal bHibernate As Boolean, ByVal bForce As Boolean, ByVal bWakeupEventsDisabled As Boolean) As Boolean

    End Function
    <DllImport("kernel32.dll")>
    Private Shared Function SetSystemPowerState(ByVal fSuspend As Boolean, ByVal fForce As Boolean) As Boolean

    End Function




    Public Class AppCommand

        Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
        Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
        Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
        Private Const WM_APPCOMMAND As Integer = &H319

        <DllImport("user32.dll")>
        Private Shared Function SendMessageW(ByVal hWnd As IntPtr,
        ByVal Msg As Integer, ByVal wParam As IntPtr,
        ByVal lParam As IntPtr) As IntPtr

        End Function

        Private Shared fwHandle As New Form

        Public Shared Sub Mute_Sound()
            SendMessageW(fwHandle.Handle, WM_APPCOMMAND, fwHandle.Handle, APPCOMMAND_VOLUME_MUTE)
        End Sub

        Public Shared Sub Volume(ByVal UP As Boolean)
            If UP = True Then
                SendMessageW(fwHandle.Handle, WM_APPCOMMAND, fwHandle.Handle, APPCOMMAND_VOLUME_UP)
            Else
                SendMessageW(fwHandle.Handle, WM_APPCOMMAND, fwHandle.Handle, APPCOMMAND_VOLUME_DOWN)

            End If
        End Sub
        '    Public Shared Sub VolDown()

        '        SendMessageW(fwHandle.Handle, WM_APPCOMMAND, fwHandle.Handle, APPCOMMAND_VOLUME_DOWN)
        '     End Sub

        '    Public Shared Sub VolUp()
        ' SendMessageW(fwHandle.Handle, WM_APPCOMMAND, fwHandle.Handle, APPCOMMAND_VOLUME_UP)
        '   End Sub


    End Class

    Public Class Display

        Private Shared output As Object = New System.Dynamic.ExpandoObject()

        Friend Class NativeMethods
            <DllImport("user32.dll")>
            Friend Shared Function ChangeDisplaySettingsEx(ByVal lpszDeviceName As String, ByRef lpDevMode As DEVMODE, ByVal hwnd As IntPtr, ByVal dwflags As DisplaySettingsFlags, ByVal lParam As IntPtr) As DISP_CHANGE
            End Function

            <DllImport("user32.dll")>
            Friend Shared Function EnumDisplayDevices(ByVal lpDevice As String, ByVal iDevNum As UInteger, ByRef lpDisplayDevice As DISPLAY_DEVICE, ByVal dwFlags As UInteger) As Boolean
            End Function

            <DllImport("user32.dll", CharSet:=CharSet.Ansi)>
            Friend Shared Function EnumDisplaySettings(ByVal lpszDeviceName As String, ByVal iModeNum As Integer, ByRef lpDevMode As DEVMODE) As Integer
            End Function

            Public Const DMDO_DEFAULT As Integer = 0
            Public Const DMDO_90 As Integer = 1
            Public Const DMDO_180 As Integer = 2
            Public Const DMDO_270 As Integer = 3

            Public Const ENUM_CURRENT_SETTINGS As Integer = -1

        End Class
        Private Shared Function RotateScreen(ByVal DisplayNumber As UInteger, ByVal Orientation As Orientations) As Boolean
            If DisplayNumber = 0 Then
                Throw New ArgumentOutOfRangeException("DisplayNumber", DisplayNumber, "First display is 1.")
            End If

            Dim result As Boolean = False
            Dim d As New DISPLAY_DEVICE()
            Dim dm As New DEVMODE()
            d.cb = Marshal.SizeOf(d)

            If Not NativeMethods.EnumDisplayDevices(Nothing, DisplayNumber - 1, d, 0) Then
                Throw New ArgumentOutOfRangeException("DisplayNumber", DisplayNumber, "Number is greater than connected displays.")
            End If

            If 0 <> NativeMethods.EnumDisplaySettings(d.DeviceName, NativeMethods.ENUM_CURRENT_SETTINGS, dm) Then
                If (dm.dmDisplayOrientation + CInt(Orientation)) Mod 2 = 1 Then ' Need to swap height and width?
                    Dim temp As Integer = dm.dmPelsHeight
                    dm.dmPelsHeight = dm.dmPelsWidth
                    dm.dmPelsWidth = temp
                End If

                Select Case Orientation
                    Case Orientations.DEGREES_CW_90
                        dm.dmDisplayOrientation = NativeMethods.DMDO_270
                    Case Orientations.DEGREES_CW_180
                        dm.dmDisplayOrientation = NativeMethods.DMDO_180
                    Case Orientations.DEGREES_CW_270
                        dm.dmDisplayOrientation = NativeMethods.DMDO_90
                    Case Orientations.DEGREES_CW_0
                        dm.dmDisplayOrientation = NativeMethods.DMDO_DEFAULT
                    Case Else
                End Select

                Dim ret As DISP_CHANGE = NativeMethods.ChangeDisplaySettingsEx(d.DeviceName, dm, IntPtr.Zero, DisplaySettingsFlags.CDS_UPDATEREGISTRY, IntPtr.Zero)

                result = ret = 0
            End If

            Return result
        End Function
        Public Shared Sub Rotate(ByVal degrees As String)
            Try
                Dim i As UInteger = 0
                i += 1

                Do While i <= 64

                    Select Case degrees
                        Case "0"
                            RotateScreen(i, 0)
                            Exit Select
                        Case "90"
                            RotateScreen(i, Orientations.DEGREES_CW_90)
                            Exit Select
                        Case "180"
                            RotateScreen(i, Orientations.DEGREES_CW_180)
                            Exit Select
                        Case "270"
                            RotateScreen(i, Orientations.DEGREES_CW_270)
                            Exit Select
                        Case Else
                            output.error = True

                            Exit Select
                    End Select
                    output.degrees = Int32.Parse(degrees)

                    i += 1
                Loop
            Catch e1 As Exception

            End Try
        End Sub

        Private Enum Orientations
            DEGREES_CW_0 = 0
            DEGREES_CW_90 = 3
            DEGREES_CW_180 = 2
            DEGREES_CW_270 = 1
        End Enum

        <StructLayout(LayoutKind.Explicit, CharSet:=CharSet.Ansi)>
        Friend Structure DEVMODE
            Public Const CCHDEVICENAME As Integer = 32
            Public Const CCHFORMNAME As Integer = 32

            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=CCHDEVICENAME)>
            <FieldOffset(0)>
            Public dmDeviceName As String
            <FieldOffset(32)>
            Public dmSpecVersion As Int16
            <FieldOffset(34)>
            Public dmDriverVersion As Int16
            <FieldOffset(36)>
            Public dmSize As Int16
            <FieldOffset(38)>
            Public dmDriverExtra As Int16
            <FieldOffset(40)>
            Public dmFields As DM

            <FieldOffset(44)>
            Private dmOrientation As Int16
            <FieldOffset(46)>
            Private dmPaperSize As Int16
            <FieldOffset(48)>
            Private dmPaperLength As Int16
            <FieldOffset(50)>
            Private dmPaperWidth As Int16
            <FieldOffset(52)>
            Private dmScale As Int16
            <FieldOffset(54)>
            Private dmCopies As Int16
            <FieldOffset(56)>
            Private dmDefaultSource As Int16
            <FieldOffset(58)>
            Private dmPrintQuality As Int16

            <FieldOffset(44)>
            Public dmPosition As POINTL
            <FieldOffset(52)>
            Public dmDisplayOrientation As Int32
            <FieldOffset(56)>
            Public dmDisplayFixedOutput As Int32

            <FieldOffset(60)>
            Public dmColor As Short
            <FieldOffset(62)>
            Public dmDuplex As Short
            <FieldOffset(64)>
            Public dmYResolution As Short
            <FieldOffset(66)>
            Public dmTTOption As Short
            <FieldOffset(68)>
            Public dmCollate As Short
            <FieldOffset(72)>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=CCHFORMNAME)>
            Public dmFormName As String
            <FieldOffset(102)>
            Public dmLogPixels As Int16
            <FieldOffset(104)>
            Public dmBitsPerPel As Int32
            <FieldOffset(108)>
            Public dmPelsWidth As Int32
            <FieldOffset(112)>
            Public dmPelsHeight As Int32
            <FieldOffset(116)>
            Public dmDisplayFlags As Int32
            <FieldOffset(116)>
            Public dmNup As Int32
            <FieldOffset(120)>
            Public dmDisplayFrequency As Int32
        End Structure

        ' See: https://msdn.microsoft.com/en-us/library/windows/desktop/dd183569(v=vs.85).aspx
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)>
        Friend Structure DISPLAY_DEVICE
            <MarshalAs(UnmanagedType.U4)>
            Public cb As Integer
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
            Public DeviceName As String
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)>
            Public DeviceString As String
            <MarshalAs(UnmanagedType.U4)>
            Public StateFlags As DisplayDeviceStateFlags
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)>
            Public DeviceID As String
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)>
            Public DeviceKey As String
        End Structure

        ' See: https://msdn.microsoft.com/de-de/library/windows/desktop/dd162807(v=vs.85).aspx
        <StructLayout(LayoutKind.Sequential)>
        Friend Structure POINTL
            Private x As Long
            Private y As Long
        End Structure

        Friend Enum DISP_CHANGE As Integer
            Successful = 0
            Restart = 1
            Failed = -1
            BadMode = -2
            NotUpdated = -3
            BadFlags = -4
            BadParam = -5
            BadDualView = -6
        End Enum

        ' http://www.pinvoke.net/default.aspx/Enums/DisplayDeviceStateFlags.html
        <Flags()>
        Friend Enum DisplayDeviceStateFlags As Integer
            ''' <summary>The device is part of the desktop.</summary>
            AttachedToDesktop = &H1
            MultiDriver = &H2
            ''' <summary>The device is part of the desktop.</summary>
            PrimaryDevice = &H4
            ''' <summary>Represents a pseudo device used to mirror application drawing for remoting or other purposes.</summary>
            MirroringDriver = &H8
            ''' <summary>The device is VGA compatible.</summary>
            VGACompatible = &H10
            ''' <summary>The device is removable; it cannot be the primary display.</summary>
            Removable = &H20
            ''' <summary>The device has more display modes than its output devices support.</summary>
            ModesPruned = &H8000000
            Remote = &H4000000
            Disconnect = &H2000000
        End Enum

        ' http://www.pinvoke.net/default.aspx/user32/ChangeDisplaySettingsFlags.html
        <Flags()>
        Friend Enum DisplaySettingsFlags As Integer
            CDS_NONE = 0
            CDS_UPDATEREGISTRY = &H1
            CDS_TEST = &H2
            CDS_FULLSCREEN = &H4
            CDS_GLOBAL = &H8
            CDS_SET_PRIMARY = &H10
            CDS_VIDEOPARAMETERS = &H20
            CDS_ENABLE_UNSAFE_MODES = &H100
            CDS_DISABLE_UNSAFE_MODES = &H200
            CDS_RESET = &H40000000
            CDS_RESET_EX = &H20000000
            CDS_NORESET = &H10000000
        End Enum

        <Flags()>
        Friend Enum DM As Integer
            Orientation = &H1
            PaperSize = &H2
            PaperLength = &H4
            PaperWidth = &H8
            Scale = &H10
            Position = &H20
            NUP = &H40
            DisplayOrientation = &H80
            Copies = &H100
            DefaultSource = &H200
            PrintQuality = &H400
            Color = &H800
            Duplex = &H1000
            YResolution = &H2000
            TTOption = &H4000
            Collate = &H8000
            FormName = &H10000
            LogPixels = &H20000
            BitsPerPixel = &H40000
            PelsWidth = &H80000
            PelsHeight = &H100000
            DisplayFlags = &H200000
            DisplayFrequency = &H400000
            ICMMethod = &H800000
            ICMIntent = &H1000000
            MediaType = &H2000000
            DitherType = &H4000000
            PanningWidth = &H8000000
            PanningHeight = &H10000000
            DisplayFixedOutput = &H20000000
        End Enum
    End Class
End Class
