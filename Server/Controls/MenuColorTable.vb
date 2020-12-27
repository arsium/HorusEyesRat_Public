Public Class MenuColorTable
	Inherits ProfessionalColorTable
	'https://stackoverflow.com/questions/60734258/how-to-handle-contextmenustrip-property-exspecially-border-color
	Public Sub New()
		UseSystemColors = True
	End Sub

	Public Overrides ReadOnly Property MenuBorder() As Color
		Get
			Return Color.FromArgb(16, 26, 39)
		End Get
	End Property
	Public Overrides ReadOnly Property MenuItemBorder() As Color
		Get
			Return Color.DarkViolet
		End Get
	End Property
	Public Overrides ReadOnly Property MenuItemSelected() As Color
		Get
			Return Color.Cornsilk
		End Get
	End Property
	Public Overrides ReadOnly Property MenuItemSelectedGradientBegin() As Color
		Get
			Return Color.LawnGreen
		End Get
	End Property
	Public Overrides ReadOnly Property MenuItemSelectedGradientEnd() As Color
		Get
			Return Color.MediumSeaGreen
		End Get
	End Property
	Public Overrides ReadOnly Property MenuStripGradientBegin() As Color
		Get
			Return Color.AliceBlue
		End Get
	End Property
	Public Overrides ReadOnly Property MenuStripGradientEnd() As Color
		Get
			Return Color.DodgerBlue
		End Get
	End Property
End Class
