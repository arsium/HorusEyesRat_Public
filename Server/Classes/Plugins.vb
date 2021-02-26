Imports System.Text

Public Class Plugins

    Public Shared _PW As Byte() = IO.File.ReadAllBytes("Plugins\PW.dll")

    Public Shared _W_PW As Byte() = IO.File.ReadAllBytes("Plugins\NW.dll")

    Public Shared _WB As Byte() = IO.File.ReadAllBytes("Plugins\WB.dll")

    Public Shared _TASKS_MGR As Byte() = IO.File.ReadAllBytes("Plugins\TM.dll")

    Public Shared _MS As Byte() = IO.File.ReadAllBytes("Plugins\MS.dll")
    '' Public Shared _RD As Byte() = IO.File.ReadAllBytes("Plugins\RD.dll") Code is included in client
    Public Shared _KB As Byte() = IO.File.ReadAllBytes("Plugins\KB.dll")

    Public Shared _SL As Byte() = IO.File.ReadAllBytes("Plugins\SL.dll")

    Public Shared _LD As Byte() = IO.File.ReadAllBytes("Plugins\LD.dll")

    Public Shared _MO As Byte() = IO.File.ReadAllBytes("Plugins\MO.dll")

    Public Shared _PR As Byte() = IO.File.ReadAllBytes("Plugins\PR.dll")

    Public Shared _FM As Byte() = IO.File.ReadAllBytes("Plugins\FM.dll")

End Class
