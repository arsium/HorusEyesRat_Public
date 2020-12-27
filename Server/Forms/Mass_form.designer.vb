<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mass_form
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Recover Passwords"}, 1, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.Empty, Nothing)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Recover History"}, 0, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.Empty, Nothing)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Recover Wifi Password"}, 2, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.Empty, Nothing)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mass_form))
        Me.Close_BTN = New Server.Custom_Button()
        Me.Custom_ProgressBar2 = New Server.Custom_ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMD_ListView = New Server.AeroListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Command_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LaunchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Command_MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Close_BTN
        '
        Me.Close_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Close_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Close_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_BTN.ForeColor = System.Drawing.Color.White
        Me.Close_BTN.Location = New System.Drawing.Point(377, 0)
        Me.Close_BTN.Name = "Close_BTN"
        Me.Close_BTN.Size = New System.Drawing.Size(28, 28)
        Me.Close_BTN.TabIndex = 5
        Me.Close_BTN.Text = "X"
        Me.Close_BTN.UseVisualStyleBackColor = True
        '
        'Custom_ProgressBar2
        '
        Me.Custom_ProgressBar2.Location = New System.Drawing.Point(12, 222)
        Me.Custom_ProgressBar2.MarqueeAnimationSpeed = 250
        Me.Custom_ProgressBar2.Name = "Custom_ProgressBar2"
        Me.Custom_ProgressBar2.Size = New System.Drawing.Size(381, 23)
        Me.Custom_ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Custom_ProgressBar2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Mass Tasks"
        '
        'CMD_ListView
        '
        Me.CMD_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.CMD_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CMD_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.CMD_ListView.ContextMenuStrip = Me.Command_MenuStrip
        Me.CMD_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMD_ListView.HideSelection = False
        Me.CMD_ListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.CMD_ListView.Location = New System.Drawing.Point(12, 48)
        Me.CMD_ListView.Name = "CMD_ListView"
        Me.CMD_ListView.Size = New System.Drawing.Size(381, 197)
        Me.CMD_ListView.SmallImageList = Me.ImageList1
        Me.CMD_ListView.TabIndex = 45
        Me.CMD_ListView.UseCompatibleStateImageBehavior = False
        Me.CMD_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Command"
        Me.ColumnHeader1.Width = 379
        '
        'Command_MenuStrip
        '
        Me.Command_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.Command_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchToolStripMenuItem})
        Me.Command_MenuStrip.Name = "Command_MenuStrip"
        Me.Command_MenuStrip.Size = New System.Drawing.Size(126, 38)
        '
        'LaunchToolStripMenuItem
        '
        Me.LaunchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.LaunchToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LaunchToolStripMenuItem.Image = CType(resources.GetObject("LaunchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaunchToolStripMenuItem.Name = "LaunchToolStripMenuItem"
        Me.LaunchToolStripMenuItem.Size = New System.Drawing.Size(125, 34)
        Me.LaunchToolStripMenuItem.Text = "Launch"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8_time_machine_32.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8_show_passeword_32.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8_security_wi-fi_32.png")
        '
        'Mass_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 257)
        Me.Controls.Add(Me.CMD_ListView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Close_BTN)
        Me.Controls.Add(Me.Custom_ProgressBar2)
        Me.Name = "Mass_form"
        Me.Text = "Mass_form"
        Me.Command_MenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Custom_ProgressBar2 As Custom_ProgressBar
    Friend WithEvents Close_BTN As Custom_Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CMD_ListView As AeroListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Command_MenuStrip As ContextMenuStrip
    Friend WithEvents LaunchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
End Class
