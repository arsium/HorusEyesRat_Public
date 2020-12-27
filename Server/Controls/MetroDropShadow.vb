'https://github.com/peters/winforms-modernui/blob/master/MetroFramework/Forms/MetroForm.cs
Public Class MetroDropShadow
	Inherits Form

	Private shadowTargetForm As Form

	Public Sub New(ByVal targetForm As Form)
		SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)

		shadowTargetForm = targetForm
		AddHandler shadowTargetForm.Activated, AddressOf shadowTargetForm_Activated
		AddHandler shadowTargetForm.ResizeBegin, AddressOf shadowTargetForm_ResizeBegin
		AddHandler shadowTargetForm.ResizeEnd, AddressOf shadowTargetForm_ResizeEnd
		AddHandler shadowTargetForm.VisibleChanged, AddressOf shadowTargetForm_VisibleChanged


		Opacity = 0.2
		ShowInTaskbar = False
		ShowIcon = False
		FormBorderStyle = FormBorderStyle.None
		StartPosition = shadowTargetForm.StartPosition

		If shadowTargetForm.Owner IsNot Nothing Then
			Owner = shadowTargetForm.Owner
		End If

		shadowTargetForm.Owner = Me
	End Sub

	Private Sub shadowTargetForm_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
		Visible = shadowTargetForm.Visible
	End Sub

	Private Sub shadowTargetForm_Activated(ByVal sender As Object, ByVal e As EventArgs)
		Bounds = New Rectangle(shadowTargetForm.Location.X - 5, shadowTargetForm.Location.Y - 5, shadowTargetForm.Width + 10, shadowTargetForm.Height + 10)

		Visible = (shadowTargetForm.WindowState = FormWindowState.Normal)
		If Visible Then
			Show()
		End If
	End Sub

	Private Sub shadowTargetForm_ResizeBegin(ByVal sender As Object, ByVal e As EventArgs)
		Visible = False
		Hide()
	End Sub

	Private Sub shadowTargetForm_ResizeEnd(ByVal sender As Object, ByVal e As EventArgs)
		Bounds = New Rectangle(shadowTargetForm.Location.X - 5, shadowTargetForm.Location.Y - 5, shadowTargetForm.Width + 10, shadowTargetForm.Height + 10)

		Visible = (shadowTargetForm.WindowState = FormWindowState.Normal)
		If Visible Then
			Show()
		End If
	End Sub

	Private Const WS_EX_TRANSPARENT As Integer = &H20
	Private Const WS_EX_NOACTIVATE As Integer = &H8000000

	Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
		Get
			Dim cp As CreateParams = MyBase.CreateParams
			cp.ExStyle = cp.ExStyle Or WS_EX_TRANSPARENT Or WS_EX_NOACTIVATE
			Return cp
		End Get
	End Property

	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		e.Graphics.Clear(Color.FromArgb(16, 26, 39))

		Using b As Brush = New SolidBrush(Color.Black)
			e.Graphics.FillRectangle(b, New Rectangle(4, 4, ClientRectangle.Width - 8, ClientRectangle.Height - 8))
		End Using
	End Sub

	Private Sub InitializeComponent()
		Me.SuspendLayout()
		'
		'MetroDropShadow
		'
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Name = "MetroDropShadow"
		Me.ResumeLayout(False)

	End Sub

	Private Sub MetroDropShadow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class