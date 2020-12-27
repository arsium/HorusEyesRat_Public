''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class UserControl1

    Private IM As Image

    Public Property ImageDescriptor As Image
        Get
            Return IM
            Me.Refresh()
        End Get
        Set(value As Image)
            IM = value
            Me.Refresh()
        End Set
    End Property


    Private TTX As String = "Test"

    Public Property TextEx As String
        Get
            Return TTX
            Me.Refresh()
        End Get
        Set(value As String)
            TTX = value
            Me.Refresh()
        End Set
    End Property


    Private TTXx As Color = Color.White

    Public Property ImageDescriptorBackColor As Color
        Get
            Return TTXx
            Me.Refresh()
        End Get
        Set(value As Color)
            TTXx = value
            Me.Refresh()
        End Set
    End Property




    Private TTXxxx As Color = Color.FromArgb(255, 159, 0)

    Public Property TextExColor As Color
        Get
            Return TTXxxx
            Me.Refresh()
        End Get
        Set(value As Color)
            TTXxxx = value
            Me.Refresh()
        End Set
    End Property

    Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub
    Protected Overrides Sub OnHandleCreated(e As EventArgs)

        MyBase.OnHandleCreated(e)

    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(0, 120, 215), ButtonBorderStyle.Solid)

        PictureBox1.Image = IM
        PictureBox1.BackColor = TTXx

        Label1.ForeColor = TTXxxx
        Label1.Text = TTX
        MyBase.OnPaint(e)
    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
