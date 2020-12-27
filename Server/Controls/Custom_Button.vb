Imports System.ComponentModel
Imports System.IO
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class Custom_Button
    Inherits Button

    Private BN As Color = Color.FromArgb(16, 26, 39)
    'Custom_Form.ThemeInfo.GetThemeColor()

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


        If BN = Color.White Then
            ' Me.ForeColor = Color.FromArgb(60, 60, 60)
        Else
            '   Me.ForeColor = Color.White
        End If

        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 1
        Me.FlatAppearance.BorderColor = Color.FromArgb(0, 120, 215)
        Me.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 130, 225)


    End Sub
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)

        MyBase.OnPaint(pevent)
    End Sub


End Class
