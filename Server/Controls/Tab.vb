Option Infer On

' ***********************************************************************
' Assembly         : HZH_Controls
' Created          : 08-17-2019
'
' ***********************************************************************
' <copyright file="TabControlExt.cs">
'     Copyright by Huang Zhenghui(黄正辉) All, QQ group:568015492 QQ:623128629 Email:623128629@qq.com
' </copyright>
'
' Blog: https://www.cnblogs.com/bfyx
' GitHub：https://github.com/kwwwvagaa/NetWinformControl
' gitee：https://gitee.com/kwwwvagaa/net_winform_custom_control.git
'
' If you use this code, please keep this note.
' ***********************************************************************
'Converted using InstantVB by Arsium
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms

Namespace HZH_Controls.Controls
	''' <summary>
	''' Class TabControlExt.
	''' Implements the <see cref="System.Windows.Forms.TabControl" />
	''' </summary>
	''' <seealso cref="System.Windows.Forms.TabControl" />
	Public Class TabControlExt
		Inherits TabControl

		''' <summary>
		''' Initializes a new instance of the <see cref="TabControlExt" /> class.
		''' </summary>
		Public Sub New()
			MyBase.New()
			SetStyles()
			'this.Multiline = true;
			Me.ItemSize = New Size(Me.ItemSize.Width, 50)
		End Sub
		''' <summary>
		''' Sets the styles.
		''' </summary>
		Private Sub SetStyles()
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.DoubleBuffer Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor, True)
			MyBase.UpdateStyles()
		End Sub
		''' <summary>
		''' Gets or sets a value indicating whether this instance is show close BTN.
		''' </summary>
		''' <value><c>true</c> if this instance is show close BTN; otherwise, <c>false</c>.</value>
		<Description("是否显示关闭按钮"), Category("自定义")>
		Public Property IsShowCloseBtn() As Boolean

		<Description("不可关闭的标签序号列表，下标0"), Category("自定义")>
		Public Property UncloseTabIndexs() As Integer()
		''' <summary>
		''' The back color
		''' </summary>
		Private _backColor As Color = Color.White
		''' <summary>
		''' 此成员对于此控件无意义。
		''' </summary>
		''' <value>The color of the back.</value>
		<Browsable(True)>
		<EditorBrowsable(EditorBrowsableState.Always)>
		<DefaultValue(GetType(Color), "White")>
		Public Overrides Property BackColor() As Color
			Get
				Return _backColor
			End Get
			Set(ByVal value As Color)
				_backColor = value
				MyBase.Invalidate(True)
			End Set
		End Property

		'INSTANT VB NOTE: The field closeBtnColor was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private closeBtnColor_Renamed As Color = Color.FromArgb(255, 85, 51)

		<Description("关闭按钮颜色")>
		Public Property CloseBtnColor() As Color
			Get
				Return closeBtnColor_Renamed
			End Get
			Set(ByVal value As Color)
				closeBtnColor_Renamed = value
			End Set
		End Property

		''' <summary>
		''' The border color
		''' </summary>
		Private _borderColor As Color = Color.FromArgb(232, 232, 232)
		''' <summary>
		''' Gets or sets the color of the border.
		''' </summary>
		''' <value>The color of the border.</value>
		<DefaultValue(GetType(Color), "232, 232, 232")>
		<Description("TabContorl边框色")>
		Public Property BorderColor() As Color
			Get
				Return _borderColor
			End Get
			Set(ByVal value As Color)
				_borderColor = value
				MyBase.Invalidate(True)
			End Set
		End Property

		''' <summary>
		''' The head selected back color
		''' </summary>
		Private _headSelectedBackColor As Color = Color.FromArgb(255, 85, 51)
		''' <summary>
		''' Gets or sets the color of the head selected back.
		''' </summary>
		''' <value>The color of the head selected back.</value>
		<DefaultValue(GetType(Color), "255, 85, 51")>
		<Description("TabPage头部选中后的背景颜色")>
		Public Property HeadSelectedBackColor() As Color
			Get
				Return _headSelectedBackColor
			End Get
			Set(ByVal value As Color)
				_headSelectedBackColor = value
			End Set
		End Property

		Private COLOR_FORE_BASE As Color = Color.FromArgb(0, 0, 0)

		Public Property ForeColorBase() As Color
			Get
				Return COLOR_FORE_BASE
			End Get
			Set(ByVal value As Color)
				COLOR_FORE_BASE = value
			End Set
		End Property

		''' <summary>
		''' The head selected border color
		''' </summary>
		Private _headSelectedBorderColor As Color = Color.FromArgb(232, 232, 232)
		''' <summary>
		''' Gets or sets the color of the head selected border.
		''' </summary>
		''' <value>The color of the head selected border.</value>
		<DefaultValue(GetType(Color), "232, 232, 232")>
		<Description("TabPage头部选中后的边框颜色")>
		Public Property HeadSelectedBorderColor() As Color
			Get
				Return _headSelectedBorderColor
			End Get
			Set(ByVal value As Color)
				_headSelectedBorderColor = value
			End Set
		End Property

		''' <summary>
		''' The header back color
		''' </summary>
		Private _headerBackColor As Color = Color.White
		''' <summary>
		''' Gets or sets the color of the header back.
		''' </summary>
		''' <value>The color of the header back.</value>
		<DefaultValue(GetType(Color), "White")>
		<Description("TabPage头部默认背景颜色")>
		Public Property HeaderBackColor() As Color
			Get
				Return _headerBackColor
			End Get
			Set(ByVal value As Color)
				_headerBackColor = value
			End Set
		End Property

		''' <summary>
		''' 绘制控件的背景。
		''' </summary>
		''' <param name="pevent">包含有关要绘制的控件的信息的 <see cref="T:System.Windows.Forms.PaintEventArgs" />。</param>
		Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
			If Me.DesignMode = True Then
				Dim backBrush As New LinearGradientBrush(Me.Bounds, SystemColors.ControlLightLight, SystemColors.ControlLight, LinearGradientMode.Vertical)
				pevent.Graphics.FillRectangle(backBrush, Me.Bounds)
				backBrush.Dispose()
			Else
				Me.PaintTransparentBackground(pevent.Graphics, Me.ClientRectangle)
			End If
		End Sub

		''' <summary>
		''' TabContorl 背景色设置
		''' </summary>
		''' <param name="g">The g.</param>
		''' <param name="clipRect">The clip rect.</param>
		Protected Sub PaintTransparentBackground(ByVal g As Graphics, ByVal clipRect As Rectangle)
			If (Me.Parent IsNot Nothing) Then
				clipRect.Offset(Me.Location)
				Dim e As New PaintEventArgs(g, clipRect)
				Dim state As GraphicsState = g.Save()
				g.SmoothingMode = SmoothingMode.HighSpeed
				Try
					g.TranslateTransform(CSng(-Me.Location.X), CSng(-Me.Location.Y))
					Me.InvokePaintBackground(Me.Parent, e)
					Me.InvokePaint(Me.Parent, e)
				Finally
					g.Restore(state)
					clipRect.Offset(-Me.Location.X, -Me.Location.Y)
					'新加片段,待测试
					Using brush As New SolidBrush(_backColor)
						clipRect.Inflate(1, 1)
						g.FillRectangle(brush, clipRect)
					End Using
				End Try
			Else
				Dim backBrush As New System.Drawing.Drawing2D.LinearGradientBrush(Me.Bounds, SystemColors.ControlLightLight, SystemColors.ControlLight, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
				g.FillRectangle(backBrush, Me.Bounds)
				backBrush.Dispose()
			End If
		End Sub

		''' <summary>
		''' 引发 <see cref="E:System.Windows.Forms.Control.Paint" /> 事件。
		''' </summary>
		''' <param name="e">包含事件数据的 <see cref="T:System.Windows.Forms.PaintEventArgs" />。</param>
		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			' Paint the Background 
			MyBase.OnPaint(e)
			Me.PaintTransparentBackground(e.Graphics, Me.ClientRectangle)
			Me.PaintAllTheTabs(e)
			Me.PaintTheTabPageBorder(e)
			Me.PaintTheSelectedTab(e)
		End Sub

		''' <summary>
		''' Paints all the tabs.
		''' </summary>
		''' <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs" /> instance containing the event data.</param>
		Private Sub PaintAllTheTabs(ByVal e As System.Windows.Forms.PaintEventArgs)
			If Me.TabCount > 0 Then
				For index As Integer = 0 To Me.TabCount - 1
					Me.PaintTab(e, index)
				Next index
			End If
		End Sub

		''' <summary>
		''' Paints the tab.
		''' </summary>
		''' <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs" /> instance containing the event data.</param>
		''' <param name="index">The index.</param>
		Private Sub PaintTab(ByVal e As System.Windows.Forms.PaintEventArgs, ByVal index As Integer)
			Dim path As GraphicsPath = Me.GetTabPath(index)
			Me.PaintTabBackground(e.Graphics, index, path)
			Me.PaintTabBorder(e.Graphics, index, path)
			Me.PaintTabText(e.Graphics, index)
			Me.PaintTabImage(e.Graphics, index)
			If IsShowCloseBtn Then
				If UncloseTabIndexs IsNot Nothing Then
					If UncloseTabIndexs.ToList().Contains(index) Then
						Return
					End If
				End If
				Dim rect As Rectangle = Me.GetTabRect(index)
				e.Graphics.DrawLine(New Pen(closeBtnColor_Renamed, 1.0F), New Point(rect.Right - 15, rect.Top + 5), New Point(rect.Right - 5, rect.Top + 15))
				e.Graphics.DrawLine(New Pen(closeBtnColor_Renamed, 1.0F), New Point(rect.Right - 5, rect.Top + 5), New Point(rect.Right - 15, rect.Top + 15))
			End If
		End Sub

		''' <summary>
		''' 设置选项卡头部颜色
		''' </summary>
		''' <param name="graph">The graph.</param>
		''' <param name="index">The index.</param>
		''' <param name="path">The path.</param>
		Private Sub PaintTabBackground(ByVal graph As System.Drawing.Graphics, ByVal index As Integer, ByVal path As System.Drawing.Drawing2D.GraphicsPath)
			Dim rect As Rectangle = Me.GetTabRect(index)
			If rect.Width = 0 OrElse rect.Height = 0 Then
				Return
			End If
			Dim buttonBrush As System.Drawing.Brush = New System.Drawing.Drawing2D.LinearGradientBrush(rect, _headerBackColor, _headerBackColor, LinearGradientMode.Vertical) '非选中时候的 TabPage 页头部背景色
			graph.FillPath(buttonBrush, path)
			'if (index == this.SelectedIndex)
			'{
			'    //buttonBrush = new System.Drawing.SolidBrush(_headSelectedBackColor);
			'    graph.DrawLine(new Pen(_headerBackColor), rect.Right+2, rect.Bottom, rect.Left + 1, rect.Bottom);
			'}
			buttonBrush.Dispose()
		End Sub

		''' <summary>
		''' 设置选项卡头部边框色
		''' </summary>
		''' <param name="graph">The graph.</param>
		''' <param name="index">The index.</param>
		''' <param name="path">The path.</param>
		Private Sub PaintTabBorder(ByVal graph As System.Drawing.Graphics, ByVal index As Integer, ByVal path As System.Drawing.Drawing2D.GraphicsPath)
			Dim borderPen As New Pen(_borderColor) ' TabPage 非选中时候的 TabPage 头部边框色
			If index = Me.SelectedIndex Then
				borderPen = New Pen(_headSelectedBorderColor) ' TabPage 选中后的 TabPage 头部边框色
			End If
			graph.DrawPath(borderPen, path)
			borderPen.Dispose()
		End Sub

		''' <summary>
		''' Paints the tab image.
		''' </summary>
		''' <param name="g">The g.</param>
		''' <param name="index">The index.</param>
		Private Sub PaintTabImage(ByVal g As System.Drawing.Graphics, ByVal index As Integer)
			Dim tabImage As Image = Nothing
			If Me.TabPages(index).ImageIndex > -1 AndAlso Me.ImageList IsNot Nothing Then
				tabImage = Me.ImageList.Images(Me.TabPages(index).ImageIndex)
			ElseIf Me.TabPages(index).ImageKey.Trim().Length > 0 AndAlso Me.ImageList IsNot Nothing Then
				tabImage = Me.ImageList.Images(Me.TabPages(index).ImageKey)
			End If
			If tabImage IsNot Nothing Then
				Dim rect As Rectangle = Me.GetTabRect(index)
				g.DrawImage(tabImage, rect.Right - rect.Height - 4, 4, rect.Height - 2, rect.Height - 2)
			End If
		End Sub

		''' <summary>
		''' Paints the tab text.
		''' </summary>
		''' <param name="graph">The graph.</param>
		''' <param name="index">The index.</param>
		Private Sub PaintTabText(ByVal graph As System.Drawing.Graphics, ByVal index As Integer)
			Dim tabtext As String = Me.TabPages(index).Text

			Dim format As New System.Drawing.StringFormat()
			format.Alignment = StringAlignment.Near
			format.LineAlignment = StringAlignment.Center
			format.Trimming = StringTrimming.EllipsisCharacter

			Dim forebrush As Brush = Nothing

			If Me.TabPages(index).Enabled = False Then
				forebrush = New SolidBrush(Color.DeepSkyBlue)
			Else
				forebrush = New SolidBrush(COLOR_FORE_BASE)
			End If

			Dim tabFont As Font = Me.Font
			If index = Me.SelectedIndex Then
				If Me.TabPages(index).Enabled <> False Then
					forebrush = New SolidBrush(_headSelectedBackColor)
				End If
			End If

			Dim rect As Rectangle = Me.GetTabRect(index)

			Dim txtSize = GetStringWidth(tabtext, graph, tabFont)
			'INSTANT VB WARNING: Instant VB cannot determine whether both operands of this division are integer types - if they are then you should use the VB integer division operator:
			Dim rect2 As New Rectangle(rect.Left + (rect.Width - txtSize) / 2 - 1, rect.Top, rect.Width, rect.Height)

			graph.DrawString(tabtext, tabFont, forebrush, rect2, format)
		End Sub

		Public Shared Function GetStringWidth(ByVal strSource As String, ByVal g As System.Drawing.Graphics, ByVal font As System.Drawing.Font) As Integer
			Dim strs() As String = strSource.Split(New String() {vbCrLf}, StringSplitOptions.RemoveEmptyEntries)
			Dim fltWidth As Single = 0
			For Each item In strs
				Dim sizeF As System.Drawing.SizeF = g.MeasureString(strSource.Replace(" ", "A"), font)
				If sizeF.Width > fltWidth Then
					fltWidth = sizeF.Width
				End If
			Next item

			Return CInt(Math.Truncate(fltWidth))
		End Function


		''' <summary>
		''' 设置 TabPage 内容页边框色
		''' </summary>
		''' <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs" /> instance containing the event data.</param>
		Private Sub PaintTheTabPageBorder(ByVal e As System.Windows.Forms.PaintEventArgs)
			If Me.TabCount > 0 Then
				Dim borderRect As Rectangle = Me.TabPages(0).Bounds
				'borderRect.Inflate(1, 1);
				Dim rect As New Rectangle(borderRect.X - 2, borderRect.Y - 1, borderRect.Width + 5, borderRect.Height + 2)
				ControlPaint.DrawBorder(e.Graphics, rect, Me.BorderColor, ButtonBorderStyle.Solid)
			End If
		End Sub

		''' <summary>
		''' Paints the selected tab.
		''' </summary>
		''' <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs" /> instance containing the event data.</param>
		Private Sub PaintTheSelectedTab(ByVal e As System.Windows.Forms.PaintEventArgs)
			If Me.SelectedIndex = -1 Then
				Return
			End If
			Dim selrect As Rectangle
			Dim selrectRight As Integer = 0
			selrect = Me.GetTabRect(Me.SelectedIndex)
			selrectRight = selrect.Right
			e.Graphics.DrawLine(New Pen(_headSelectedBackColor), selrect.Left, selrect.Bottom + 1, selrectRight, selrect.Bottom + 1)
		End Sub

		''' <summary>
		''' Gets the tab path.
		''' </summary>
		''' <param name="index">The index.</param>
		''' <returns>GraphicsPath.</returns>
		Private Function GetTabPath(ByVal index As Integer) As GraphicsPath
			Dim path As New System.Drawing.Drawing2D.GraphicsPath()
			path.Reset()

			Dim rect As Rectangle = Me.GetTabRect(index)

			Select Case Alignment
				Case TabAlignment.Top

				Case TabAlignment.Bottom

				Case TabAlignment.Left

				Case TabAlignment.Right

			End Select

			path.AddLine(rect.Left, rect.Top, rect.Left, rect.Bottom + 1)
			path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top)
			path.AddLine(rect.Right, rect.Top, rect.Right, rect.Bottom + 1)
			path.AddLine(rect.Right, rect.Bottom + 1, rect.Left, rect.Bottom + 1)

			Return path
		End Function

		''' <summary>
		''' Sends the message.
		''' </summary>
		''' <param name="hWnd">The h WND.</param>
		''' <param name="Msg">The MSG.</param>
		''' <param name="wParam">The w parameter.</param>
		''' <param name="lParam">The l parameter.</param>
		''' <returns>IntPtr.</returns>
		<DllImport("user32.dll")>
		Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
		End Function

		''' <summary>
		''' The wm setfont
		''' </summary>
		Private Const WM_SETFONT As Integer = &H30
		''' <summary>
		''' The wm fontchange
		''' </summary>
		Private Const WM_FONTCHANGE As Integer = &H1D

		''' <summary>
		''' 引发 <see cref="M:System.Windows.Forms.Control.CreateControl" /> 方法。
		''' </summary>
		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
			Me.OnFontChanged(EventArgs.Empty)
		End Sub

		''' <summary>
		''' 引发 <see cref="E:System.Windows.Forms.Control.FontChanged" /> 事件。
		''' </summary>
		''' <param name="e">包含事件数据的 <see cref="T:System.EventArgs" />。</param>
		Protected Overrides Sub OnFontChanged(ByVal e As EventArgs)
			MyBase.OnFontChanged(e)
			Dim hFont As IntPtr = Me.Font.ToHfont()
			SendMessage(Me.Handle, WM_SETFONT, hFont, New IntPtr(-1))
			SendMessage(Me.Handle, WM_FONTCHANGE, IntPtr.Zero, IntPtr.Zero)
			Me.UpdateStyles()
		End Sub

		''' <summary>
		''' 此成员重写 <see cref="M:System.Windows.Forms.Control.WndProc(System.Windows.Forms.Message@)" />。
		''' </summary>
		''' <param name="m">一个 Windows 消息对象。</param>
		Protected Overrides Sub WndProc(ByRef m As Message)
			MyBase.WndProc(m)
			If m.Msg = &H201 Then ' WM_LBUTTONDOWN
				If Not DesignMode Then
					If IsShowCloseBtn Then
						Dim mouseLocation = Me.PointToClient(Control.MousePosition)
						Dim index As Integer = GetMouseDownTabHead(mouseLocation)
						If index >= 0 Then
							If UncloseTabIndexs IsNot Nothing Then
								If UncloseTabIndexs.ToList().Contains(index) Then
									Return
								End If
							End If
							Dim rect As Rectangle = Me.GetTabRect(index)
							Dim closeRect = New Rectangle(rect.Right - 15, rect.Top + 5, 10, 10)
							If closeRect.Contains(mouseLocation) Then
								Me.TabPages.RemoveAt(index)
								Return
							End If
						End If
					End If
				End If
			End If


		End Sub
		''' <summary>
		''' 在调度键盘或输入消息之前，在消息循环内对它们进行预处理。
		''' </summary>
		''' <param name="msg">通过引用传递的 <see cref="T:System.Windows.Forms.Message" />，它表示要处理的消息。可能的值有 WM_KEYDOWN、WM_SYSKEYDOWN、WM_CHAR 和 WM_SYSCHAR。</param>
		''' <returns>如果消息已由控件处理，则为 true；否则为 false。</returns>
		''' <PermissionSet>
		'''   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		'''   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		'''   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		'''   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		''' </PermissionSet>
		Public Overrides Function PreProcessMessage(ByRef msg As Message) As Boolean

			Return MyBase.PreProcessMessage(msg)
		End Function

		''' <summary>
		''' Gets the mouse down tab head.
		''' </summary>
		''' <param name="point">The point.</param>
		''' <returns>System.Int32.</returns>
		Private Function GetMouseDownTabHead(ByVal point As Point) As Integer
			For i As Integer = 0 To Me.TabCount - 1
				Dim rect As Rectangle = Me.GetTabRect(i)
				If rect.Contains(point) Then
					Return i
				End If
			Next i
			Return -1
		End Function
	End Class
End Namespace
