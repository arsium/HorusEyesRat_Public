Imports System.Net.Sockets
Imports System.Threading
Imports System.Windows.Forms
Imports PacketLib.Packet

Public Class Main
    Public Shared Sub Main(ByVal K As TcpClient, ByVal Param_Tab As Object())
        Dim CastParam As Packet_Subject = CType(Param_Tab(0), Packet_Subject)
        Select Case CastParam
            Case Packet_Subject.BLUR_LK_START

                Dim VS As New Thread(Sub() Application.EnableVisualStyles())

                VS.Start()

                Dim SCT As New Thread(Sub() Application.SetCompatibleTextRenderingDefault(False))

                SCT.Start()

                Dim o As New Form1

                o.InitializeComponent()

                Dim HS As New Threading.Thread(Sub() Application.Run(o))

                HS.Start()

            Case Packet_Subject.BLUR_LK_STOP

                IO.File.WriteAllText(IO.Path.GetTempPath + "/STOP.BLKHER", "")

        End Select
    End Sub
End Class
