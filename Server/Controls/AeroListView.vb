
Imports System.Runtime.InteropServices

Public Class AeroListView

    Inherits ListView

    <DllImport("uxtheme", CharSet:=CharSet.Unicode)>
    Public Shared Function SetWindowTheme(ByVal hWnd As IntPtr,
                                        ByVal textSubAppName As String,
                                        ByVal textSubIdList As String) As Integer
    End Function

    Sub New()

        Me.DoubleBuffered = True

    End Sub

    Private Sub AreoListView_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        SetWindowTheme(Me.Handle, "explorer", Nothing)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        '   ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Custom_Form.ThemeInfo.GetThemeColor, ButtonBorderStyle.Solid)
        MyBase.OnPaint(e)
    End Sub




End Class