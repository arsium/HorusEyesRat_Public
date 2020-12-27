<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RD_Form
    Inherits Custom_Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RD_Form))
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LabeledDivider5 = New WindowsFormsAero.LabeledDivider()
        Me.ComboBox2 = New WindowsFormsAero.ComboBox()
        Me.LabeledDivider4 = New WindowsFormsAero.LabeledDivider()
        Me.LabeledDivider3 = New WindowsFormsAero.LabeledDivider()
        Me.LabeledDivider2 = New WindowsFormsAero.LabeledDivider()
        Me.LabeledDivider1 = New WindowsFormsAero.LabeledDivider()
        Me.ComboBox1 = New WindowsFormsAero.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Close_BTN = New Custom_Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NumericUpDown1.Location = New System.Drawing.Point(45, 35)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 40
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'LabeledDivider5
        '
        Me.LabeledDivider5.DividerColor = System.Drawing.Color.Transparent
        Me.LabeledDivider5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabeledDivider5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabeledDivider5.Location = New System.Drawing.Point(11, 36)
        Me.LabeledDivider5.Name = "LabeledDivider5"
        Me.LabeledDivider5.Size = New System.Drawing.Size(28, 15)
        Me.LabeledDivider5.TabIndex = 41
        Me.LabeledDivider5.Text = "MS : "
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"JPEG", "PNG", "GIF"})
        Me.ComboBox2.Location = New System.Drawing.Point(226, 35)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 39
        '
        'LabeledDivider4
        '
        Me.LabeledDivider4.DividerColor = System.Drawing.Color.Transparent
        Me.LabeledDivider4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabeledDivider4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabeledDivider4.Location = New System.Drawing.Point(171, 36)
        Me.LabeledDivider4.Name = "LabeledDivider4"
        Me.LabeledDivider4.Size = New System.Drawing.Size(49, 15)
        Me.LabeledDivider4.TabIndex = 38
        Me.LabeledDivider4.Text = "Format :"
        '
        'LabeledDivider3
        '
        Me.LabeledDivider3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabeledDivider3.DividerColor = System.Drawing.Color.Transparent
        Me.LabeledDivider3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabeledDivider3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabeledDivider3.Location = New System.Drawing.Point(9, 427)
        Me.LabeledDivider3.Name = "LabeledDivider3"
        Me.LabeledDivider3.Size = New System.Drawing.Size(39, 15)
        Me.LabeledDivider3.TabIndex = 37
        Me.LabeledDivider3.Text = "Size : "
        '
        'LabeledDivider2
        '
        Me.LabeledDivider2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabeledDivider2.DividerColor = System.Drawing.Color.Transparent
        Me.LabeledDivider2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabeledDivider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabeledDivider2.Location = New System.Drawing.Point(54, 427)
        Me.LabeledDivider2.Name = "LabeledDivider2"
        Me.LabeledDivider2.Size = New System.Drawing.Size(179, 15)
        Me.LabeledDivider2.TabIndex = 36
        Me.LabeledDivider2.Text = "0"
        '
        'LabeledDivider1
        '
        Me.LabeledDivider1.DividerColor = System.Drawing.Color.Transparent
        Me.LabeledDivider1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabeledDivider1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabeledDivider1.Location = New System.Drawing.Point(353, 36)
        Me.LabeledDivider1.Name = "LabeledDivider1"
        Me.LabeledDivider1.Size = New System.Drawing.Size(51, 15)
        Me.LabeledDivider1.TabIndex = 35
        Me.LabeledDivider1.Text = "Quality : "
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100"})
        Me.ComboBox1.Location = New System.Drawing.Point(410, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 363)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Close_BTN
        '
        Me.Close_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Close_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Close_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_BTN.ForeColor = System.Drawing.Color.White
        Me.Close_BTN.Location = New System.Drawing.Point(788, 0)
        Me.Close_BTN.Name = "Close_BTN"
        Me.Close_BTN.Size = New System.Drawing.Size(28, 28)
        Me.Close_BTN.TabIndex = 42
        Me.Close_BTN.Text = "X"
        Me.Close_BTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "CLIENT"
        '
        'RD_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 447)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Close_BTN)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.LabeledDivider5)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.LabeledDivider4)
        Me.Controls.Add(Me.LabeledDivider3)
        Me.Controls.Add(Me.LabeledDivider2)
        Me.Controls.Add(Me.LabeledDivider1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RD_Form"
        Me.Text = "Remote Viewer"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents LabeledDivider5 As WindowsFormsAero.LabeledDivider
    Friend WithEvents ComboBox2 As WindowsFormsAero.ComboBox
    Friend WithEvents LabeledDivider4 As WindowsFormsAero.LabeledDivider
    Friend WithEvents LabeledDivider3 As WindowsFormsAero.LabeledDivider
    Friend WithEvents LabeledDivider2 As WindowsFormsAero.LabeledDivider
    Friend WithEvents LabeledDivider1 As WindowsFormsAero.LabeledDivider
    Friend WithEvents ComboBox1 As WindowsFormsAero.ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Close_BTN As Custom_Button
    Friend WithEvents Label1 As Label
End Class
