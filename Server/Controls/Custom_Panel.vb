Imports System.ComponentModel
Imports System.Runtime.InteropServices
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class Custom_Panel
    Inherits Panel
    Private BN As Color = Custom_Form.ThemeInfo.GetThemeColor()

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Always)>
    Public Overrides Property BackColor() As Color
        Get
            Return BN
        End Get
        Set(ByVal value As Color)
            BN = value
        End Set
    End Property
    Sub New()
        Me.BackColor = Color.FromArgb(16, 26, 39)
        'Color.FromArgb(0, 120, 215)
        'Custom_Form.ThemeInfo.GetThemeColor()

        '    AddHandler Me.FindForm.Activated, AddressOf Color_Activated
        '  AddHandler Me.FindForm.Deactivate, AddressOf Color_Deactivated
    End Sub

    ''Native API adpated from  : https://github.com/RiyadPathan/DragControl/blob/master/DragControl.vb
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal a As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)

        ReleaseCapture()

        SendMessage(Me.FindForm().Handle, 161, 2, 0)

        MyBase.OnMouseDown(e)
    End Sub

End Class
