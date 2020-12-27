Imports System.Runtime.InteropServices
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class Custom_Form
    Inherits Form
    Public Sub New()
        '      ControlPaint.DrawBorder(Me.CreateGraphics, Me.ClientRectangle, Color.FromArgb(51, 204, 255), ButtonBorderStyle.Solid)
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub


    Private SizeableP As Boolean = True
    Public Property Sizeable As Boolean
        Get
            Return SizeableP
            Me.Refresh()
        End Get
        Set(ByVal value As Boolean)
            SizeableP = value
            Me.Refresh()
        End Set
    End Property



    Private DragF As Boolean = True
    Public Property Draggable As Boolean
        Get
            Return DragF
            Me.Refresh()
        End Get
        Set(ByVal value As Boolean)
            DragF = value
            Me.Refresh()
        End Set
    End Property


    ''Native API adpated from  : https://github.com/RiyadPathan/DragControl/blob/master/DragControl.vb
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal a As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function









    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        Dim p As Point = Me.PointToClient(Me.MousePosition)

        'SHChangeNotify(&H8000000, &H0, Nothing, Nothing)
        ' If p.Y < 36 And
        If Draggable = True Then


            ReleaseCapture()
            '  Me.CreateGraphics.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(100, 88, 255)), 1), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
            '  ControlPaint.DrawBorder(Me.CreateGraphics, Me.ClientRectangle, Color.Red, ButtonBorderStyle.Solid)
            SendMessage(Me.FindForm().Handle, 161, 2, 0)


        End If
        '  ControlPaint.DrawBorder(Me.CreateGraphics, Me.ClientRectangle, Color.FromArgb(51, 204, 255), ButtonBorderStyle.Solid)
        ' Me.CreateGraphics.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(80, 68, 235)), 1), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))

        MyBase.OnMouseDown(e)
    End Sub
    Public Class ThemeInfo

        ''Converted : https://stackoverflow.com/questions/37774307/c-get-windows-8-1-10-selected-color-theme with Tangible instant VBNET
        <DllImport("uxtheme.dll", EntryPoint:="#95")>
        Public Shared Function GetImmersiveColorFromColorSetEx(ByVal dwImmersiveColorSet As UInteger, ByVal dwImmersiveColorType As UInteger, ByVal bIgnoreHighContrast As Boolean, ByVal dwHighContrastCacheMode As UInteger) As UInteger
        End Function
        <DllImport("uxtheme.dll", EntryPoint:="#96")>
        Public Shared Function GetImmersiveColorTypeFromName(ByVal pName As IntPtr) As UInteger
        End Function
        <DllImport("uxtheme.dll", EntryPoint:="#98")>
        Public Shared Function GetImmersiveUserColorSetPreference(ByVal bForceCheckRegistry As Boolean, ByVal bSkipCheckOnFail As Boolean) As Integer
        End Function

        Public Shared Function GetThemeColor() As Color
            Dim colorSetEx = GetImmersiveColorFromColorSetEx(CUInt(Math.Truncate(GetImmersiveUserColorSetPreference(False, False))), GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveStartSelectionBackground")), False, 0)

            Dim colour = Color.FromArgb(CByte((&HFF000000UI And colorSetEx) >> 24), CByte(&HFF And colorSetEx), CByte((&HFF00 And colorSetEx) >> 8), CByte((&HFF0000 And colorSetEx) >> 16))

            Return colour
        End Function
    End Class

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        'ThemeInfo.GetThemeColor
        ' Color.FromArgb(0, 120, 215)
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.FromArgb(0, 120, 215), ButtonBorderStyle.Solid)
        MyBase.OnPaint(e)

    End Sub


    Protected Overrides Sub OnResize(e As EventArgs)
        Me.Invalidate()
        Me.Refresh()
        MyBase.OnResize(e)
    End Sub








    Const WM_NCHITTEST As Integer = &H84


    Const HTBOTTOMRIGHT As Integer = 17

    Const HTBOTTOM As Integer = 15

    Const HTRIGHT As Integer = 11


    Const HTBOTTOMLEFT As Integer = 16

    'Const HTTOPRIGHT As Integer = 14

    Const HTLEFT As Integer = 10


    Const WM_PAINT = &HF

    Const WM_NCPAINT = &H85

    Const WM_PAINTICON = &H26

    'https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest 
    'https://social.msdn.microsoft.com/Forums/vstudio/en-US/0262637f-2448-4da2-a40c-b3232ba798bc/float-a-borderless-form-on-desktop?forum=vbgeneral
    'Second link modified By Arsium reading doc in first link

    Protected Overrides Sub WndProc(ByRef m As Message)

        Select Case m.Msg



                '   If Me.Icon.Width > 0 And Me.Icon.Height > 0 Then

               ' End If


            Case WM_NCHITTEST
                If SizeableP = True Then
                    Dim loc As New Point(m.LParam.ToInt32 And &HFFFF, m.LParam.ToInt32 >> 16)
                    loc = PointToClient(loc)


                    Dim blnRight As Boolean = (loc.X > Width - 9)


                    Dim blnBottom As Boolean = (loc.Y > Height - 9)

                    Dim blnHTLEFT As Boolean = (loc.X < Width - (Width - 9))


                    If blnRight And blnBottom Then

                        m.Result = CType(HTBOTTOMRIGHT, IntPtr)
                        Return


                    ElseIf blnHTLEFT And blnBottom Then

                        m.Result = CType(HTBOTTOMLEFT, IntPtr)
                        Return

                    ElseIf blnRight Then

                        m.Result = CType(HTRIGHT, IntPtr)
                        Return

                    ElseIf blnBottom Then

                        m.Result = CType(HTBOTTOM, IntPtr)
                        Return


                    ElseIf blnHTLEFT Then

                        m.Result = CType(HTLEFT, IntPtr)
                        Return


                    End If
                Else

                End If
        End Select

        MyBase.WndProc(m)

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Custom_Form
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "Custom_Form"
        Me.ResumeLayout(False)

    End Sub

    Private Sub Custom_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
