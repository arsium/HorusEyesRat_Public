Imports System.Net
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class Countries

    Public Shared x As Integer = 0
    Public Shared ListOfFlags As New List(Of String)
    Public Shared Function countryinfo(ByVal IP As String, ByRef ClientDetails As IPAPI.IP)
        Try
            Dim Details As IPAPI.IP = IPAPI.IPAPI.GetDetails(IP, 10000)

            ClientDetails = Details

            If Details.status = "success" Then
                Return Details.countryCode
            Else

                Return "LOCALIP"
            End If

        Catch ex As Exception

            Return "NOCONNECTIONORLOCAL"
        End Try
    End Function

    Public Shared Sub GetFlags(ByVal IPP As String, ByVal ImageLi As ImageList, ByVal ListVItem As AeroListView, ByVal iD As Object(), ByVal Port As String, ByRef ClientDetails As IPAPI.IP)
        ''https://datahub.io/core/country-list#resource-data
        Dim IPPV2 As String() = Split(IPP, ":")

        'Dim ReadFLG As String() = IO.File.ReadAllLines("FLGS.txt")

        Dim test As String = countryinfo(IPPV2(0), ClientDetails)

        Dim u As Image

        Dim newClientID As New ListViewItem

        If test = "LOCALIP" Then

            u = Image.FromFile(Application.StartupPath & "\FLAGSV2\" & "LOCALIP" & ".png")

            newClientID.Text = IPP

            ImageLi.Images.Add(u)

            newClientID.ImageIndex = x

            x += 1

            ListVItem.Items.Add(newClientID)

        ElseIf test = "NOCONNECTIONORLOCAL" Then

            u = Image.FromFile(Application.StartupPath & "\FLAGSV2\" & "NOCONNECTIONORLOCAL" & ".png")

            newClientID.Text = IPP

            ImageLi.Images.Add(u)

            newClientID.ImageIndex = x

            x += 1

            ListVItem.Items.Add(newClientID)

        Else

            For Each i As String In ListOfFlags

                If test.ToUpper.Contains(i) Or test.ToLower.Contains(i) Then

                    u = Image.FromFile(Application.StartupPath & "\FLAGSV2\" & i.ToLower & ".png")

                    newClientID.Text = IPP

                    ImageLi.Images.Add(u)

                    newClientID.ImageIndex = x

                    x += 1

                    ListVItem.Items.Add(newClientID)

                End If

            Next

        End If

        For Each h In iD
            '   newClientID.SubItems.Add("No")
            newClientID.SubItems.Add(h)

        Next

        newClientID.SubItems.Add(Port)

        If iD(8) = True Then

            newClientID.SubItems.Add("64")

        Else

            newClientID.SubItems.Add("32")

        End If


        Dim today = Date.Today
        Dim day = today.Day
        Dim month = today.Month


    End Sub



End Class
