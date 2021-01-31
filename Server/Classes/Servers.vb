Imports System.Threading

Public Class Servers

    Sub New()

    End Sub

    Public Sub HandleClients()

    End Sub

    Public Shared Sub PingClient(ByVal C As Clients, ByVal LI As AeroListView)

        While C.Connected
            Try
                C.C.GetStream.Write(Dark.TestBytes, 0, Dark.TestBytes.Length)
            Catch ex As Exception

                For Each h As ListViewItem In LI.Items
                    If h.Text = C.C.Client.RemoteEndPoint.ToString Then

                        For Each Cli As Clients In Dark.L

                            If h.Text = Cli.C.Client.RemoteEndPoint.ToString Then
                                Try
                                    Dark.L.Remove(Cli)
                                Catch ex

                                End Try

                                Try
                                    Cli.Dispose()
                                Catch

                                End Try

                                Try
                                    LI.Items.Remove(h) ''If not removed for any reason with MenuStripItem from Dark.CloseToolStrip or U_Close

                                Catch ex

                                End Try
                                LI.BeginUpdate()
                                LI.EndUpdate()

                                C.Connected = False

                                Exit Sub

                            End If

                        Next

                    End If

                Next

            End Try

            Thread.Sleep(2000)

        End While
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
End Class
