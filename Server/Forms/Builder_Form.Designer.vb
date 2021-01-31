<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Builder_Form
    Inherits Custom_Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Custom_Button1 = New Server.Custom_Button()
        Me.Button1 = New WindowsFormsAero.Button()
        Me.TextBox1 = New WindowsFormsAero.TextBox()
        Me.LabeledDivider1 = New WindowsFormsAero.LabeledDivider()
        Me.LabeledDivider3 = New WindowsFormsAero.LabeledDivider()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New WindowsFormsAero.TextBox()
        Me.LabeledDivider2 = New WindowsFormsAero.LabeledDivider()
        Me.LabeledDivider4 = New WindowsFormsAero.LabeledDivider()
        Me.TextBox3 = New WindowsFormsAero.TextBox()
        Me.LabeledDivider5 = New WindowsFormsAero.LabeledDivider()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox2.Location = New System.Drawing.Point(58, 125)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(40, 17)
        Me.CheckBox2.TabIndex = 38
        Me.CheckBox2.Text = "C#"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(12, 125)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(40, 17)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "VB"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Custom_Button1
        '
        Me.Custom_Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Custom_Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Custom_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Custom_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Custom_Button1.ForeColor = System.Drawing.Color.White
        Me.Custom_Button1.Location = New System.Drawing.Point(192, 0)
        Me.Custom_Button1.Name = "Custom_Button1"
        Me.Custom_Button1.Size = New System.Drawing.Size(28, 28)
        Me.Custom_Button1.TabIndex = 36
        Me.Custom_Button1.Text = "X"
        Me.Custom_Button1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(12, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 33)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Build !"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(12, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 23)
        Me.TextBox1.TabIndex = 34
        Me.TextBox1.Text = "127.0.0.1"
        '
        'LabeledDivider1
        '
        Me.LabeledDivider1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabeledDivider1.DividerColor = System.Drawing.Color.Transparent
        Me.LabeledDivider1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabeledDivider1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabeledDivider1.Location = New System.Drawing.Point(9, 35)
        Me.LabeledDivider1.Name = "LabeledDivider1"
        Me.LabeledDivider1.Size = New System.Drawing.Size(199, 15)
        Me.LabeledDivider1.TabIndex = 33
        Me.LabeledDivider1.Text = "IP : "
        '
        'LabeledDivider3
        '
        Me.LabeledDivider3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabeledDivider3.DividerColor = System.Drawing.Color.Transparent
        Me.LabeledDivider3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabeledDivider3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabeledDivider3.Location = New System.Drawing.Point(9, 76)
        Me.LabeledDivider3.Name = "LabeledDivider3"
        Me.LabeledDivider3.Size = New System.Drawing.Size(199, 15)
        Me.LabeledDivider3.TabIndex = 32
        Me.LabeledDivider3.Text = "Port :"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NumericUpDown1.Location = New System.Drawing.Point(12, 95)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {90000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(196, 23)
        Me.NumericUpDown1.TabIndex = 31
        Me.NumericUpDown1.Value = New Decimal(New Integer() {8080, 0, 0, 0})
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox3.Location = New System.Drawing.Point(12, 148)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox3.TabIndex = 39
        Me.CheckBox3.Text = "32 bit"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox4.Location = New System.Drawing.Point(70, 148)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox4.TabIndex = 40
        Me.CheckBox4.Text = "64 bit"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox5.Location = New System.Drawing.Point(12, 177)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox5.TabIndex = 41
        Me.CheckBox5.Text = "Install"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(12, 217)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(135, 23)
        Me.TextBox2.TabIndex = 42
        Me.TextBox2.Text = "1"
        '
        'LabeledDivider2
        '
        Me.LabeledDivider2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabeledDivider2.DividerColor = System.Drawing.Color.Transparent
        Me.LabeledDivider2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabeledDivider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabeledDivider2.Location = New System.Drawing.Point(9, 197)
        Me.LabeledDivider2.Name = "LabeledDivider2"
        Me.LabeledDivider2.Size = New System.Drawing.Size(199, 15)
        Me.LabeledDivider2.TabIndex = 43
        Me.LabeledDivider2.Text = "Scheduled Task Time :"
        '
        'LabeledDivider4
        '
        Me.LabeledDivider4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabeledDivider4.DividerColor = System.Drawing.Color.Transparent
        Me.LabeledDivider4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabeledDivider4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabeledDivider4.Location = New System.Drawing.Point(153, 220)
        Me.LabeledDivider4.Name = "LabeledDivider4"
        Me.LabeledDivider4.Size = New System.Drawing.Size(55, 15)
        Me.LabeledDivider4.TabIndex = 44
        Me.LabeledDivider4.Text = "Minutes"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(12, 261)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(135, 23)
        Me.TextBox3.TabIndex = 45
        Me.TextBox3.Text = "Client"
        '
        'LabeledDivider5
        '
        Me.LabeledDivider5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabeledDivider5.DividerColor = System.Drawing.Color.Transparent
        Me.LabeledDivider5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabeledDivider5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabeledDivider5.Location = New System.Drawing.Point(9, 243)
        Me.LabeledDivider5.Name = "LabeledDivider5"
        Me.LabeledDivider5.Size = New System.Drawing.Size(199, 15)
        Me.LabeledDivider5.TabIndex = 46
        Me.LabeledDivider5.Text = "Task Name:"
        '
        'Builder_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(220, 347)
        Me.Controls.Add(Me.LabeledDivider5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LabeledDivider4)
        Me.Controls.Add(Me.LabeledDivider2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Custom_Button1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabeledDivider1)
        Me.Controls.Add(Me.LabeledDivider3)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Name = "Builder_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Builder_Form"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As WindowsFormsAero.TextBox
    Friend WithEvents LabeledDivider1 As WindowsFormsAero.LabeledDivider
    Friend WithEvents LabeledDivider3 As WindowsFormsAero.LabeledDivider
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button1 As WindowsFormsAero.Button
    Friend WithEvents Custom_Button1 As Custom_Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents TextBox2 As WindowsFormsAero.TextBox
    Friend WithEvents LabeledDivider2 As WindowsFormsAero.LabeledDivider
    Friend WithEvents LabeledDivider4 As WindowsFormsAero.LabeledDivider
    Friend WithEvents TextBox3 As WindowsFormsAero.TextBox
    Friend WithEvents LabeledDivider5 As WindowsFormsAero.LabeledDivider
End Class
