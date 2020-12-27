Imports System.Runtime.InteropServices
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class Custom_ProgressBar
    Inherits ProgressBar

    ''Solution from : https://stackoverflow.com/questions/298486/how-do-i-disable-visual-styles-for-just-one-control-and-not-its-children
    <DllImportAttribute("uxtheme.dll")>
    Private Shared Function SetWindowTheme(ByVal hWnd As IntPtr, ByVal appname As String, ByVal idlist As String) As Integer

    End Function

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        SetWindowTheme(Me.Handle, "", "")
        MyBase.OnHandleCreated(e)
    End Sub


    Sub New()
        Me.DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)


        MyBase.OnPaint(e)
    End Sub
End Class
