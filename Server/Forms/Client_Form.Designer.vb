<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Client_Form
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Log Out", 22)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Reboot", 23)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Shutdown", 13)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Suspend", 21)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hibernate", 12)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("BSOD", 24)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mute Sound", 25)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Volume Up", 18)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Volume Down"}, 19, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer)), Nothing)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lock Keyboard", 27)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Unlock Keyboard", 26)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hide Taskbar", 28)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Show Taskbar", 29)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hide Desktop Icons", 28)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Show Desktop Icons", 29)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Swap Mouse Buttons", 30)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Normal Mouse Buttons", 31)
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Empty Bin", 20)
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Rotate Screen 0", 16)
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Rotate Screen 90", 14)
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Rotate Screen 180", 15)
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Rotate Screen 270", 17)
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hide Cursor", 28)
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Show Cursor", 29)
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Start Blur Screen Locker", 32)
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Stop Blur Screen Locker", 33)
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lock Mouse Left Click")
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lock Mouse Right Click")
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lock Mouse Movement")
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lock All Mouse Interactions")
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Unlock Mouse")
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Change WallPaper")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client_Form))
        Dim ListViewItem33 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeCreateTokenPrivilege")
        Dim ListViewItem34 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeAssignPrimaryTokenPrivilege")
        Dim ListViewItem35 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeLockMemoryPrivilege")
        Dim ListViewItem36 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeIncreaseQuotaPrivilege")
        Dim ListViewItem37 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeUnsolicitedInputPrivilege")
        Dim ListViewItem38 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeMachineAccountPrivilege")
        Dim ListViewItem39 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeTcbPrivilege")
        Dim ListViewItem40 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeSecurityPrivilege")
        Dim ListViewItem41 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeTakeOwnershipPrivilege")
        Dim ListViewItem42 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeLoadDriverPrivilege")
        Dim ListViewItem43 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeSystemProfilePrivilege")
        Dim ListViewItem44 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeSystemtimePrivilege")
        Dim ListViewItem45 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeProfileSingleProcessPrivilege")
        Dim ListViewItem46 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeIncreaseBasePriorityPrivilege")
        Dim ListViewItem47 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeCreatePagefilePrivilege")
        Dim ListViewItem48 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeCreatePermanentPrivilege")
        Dim ListViewItem49 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeBackupPrivilege")
        Dim ListViewItem50 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeRestorePrivilege")
        Dim ListViewItem51 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeShutdownPrivilege")
        Dim ListViewItem52 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeDebugPrivilege")
        Dim ListViewItem53 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeAuditPrivilege")
        Dim ListViewItem54 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeSystemEnvironmentPrivilege")
        Dim ListViewItem55 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeChangeNotifyPrivilege")
        Dim ListViewItem56 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeRemoteShutdownPrivilege")
        Dim ListViewItem57 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeUndockPrivilege")
        Dim ListViewItem58 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeSyncAgentPrivilege")
        Dim ListViewItem59 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeEnableDelegationPrivilege")
        Dim ListViewItem60 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeManageVolumePrivilege")
        Dim ListViewItem61 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeImpersonatePrivilege")
        Dim ListViewItem62 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeCreateGlobalPrivilege")
        Dim ListViewItem63 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeTrustedCredManAccessPrivilege")
        Dim ListViewItem64 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeRelabelPrivilege")
        Dim ListViewItem65 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeIncreaseWorkingSetPrivilege")
        Dim ListViewItem66 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeTimeZonePrivilege")
        Dim ListViewItem67 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SeCreateSymbolicLinkPrivilege")
        Me.Pass_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RecoverPasswordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save_PassMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSV_PASSWORDS = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hist_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Recover_history = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save_HistoryMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSV_HISTORY = New System.Windows.Forms.ToolStripMenuItem()
        Me.W_PW_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RecoverWifiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSV_W_PW = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tasks_MGR_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Custom_Button1 = New Server.Custom_Button()
        Me.TabControlExt1 = New Server.HZH_Controls.Controls.TabControlExt()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Loading_PW = New MRG.Controls.UI.LoadingCircle()
        Me.Passwords_ListView = New Server.AeroListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Loading_Hist = New MRG.Controls.UI.LoadingCircle()
        Me.Hist_ListView = New Server.AeroListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Loading_W_PW = New MRG.Controls.UI.LoadingCircle()
        Me.W_PW_ListView = New Server.AeroListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.CMD_ListView = New Server.AeroListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Command_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LaunchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Loading_tasks = New MRG.Controls.UI.LoadingCircle()
        Me.Helper_Task_Label = New System.Windows.Forms.Label()
        Me.Tasks_listview = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.XuiCustomGroupbox1 = New XanderUI.XUICustomGroupbox()
        Me.DLL_NAT_ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ADD_DLL_NAT_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Inject_Nat_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemvoeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.XuiCustomGroupbox4 = New XanderUI.XUICustomGroupbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chk_UAC_Btn = New Server.Custom_Button()
        Me.XuiCustomGroupbox3 = New XanderUI.XUICustomGroupbox()
        Me.Priv_ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Priv_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XuiCustomGroupbox2 = New XanderUI.XUICustomGroupbox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Change_Prio_Btn = New Server.Custom_Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Get_Prio_Btn = New Server.Custom_Button()
        Me.Pass_MenuStrip.SuspendLayout()
        Me.Hist_MenuStrip.SuspendLayout()
        Me.W_PW_MenuStrip.SuspendLayout()
        Me.Tasks_MGR_MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlExt1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Command_MenuStrip.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.XuiCustomGroupbox1.SuspendLayout()
        Me.ADD_DLL_NAT_MenuStrip.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.XuiCustomGroupbox4.SuspendLayout()
        Me.XuiCustomGroupbox3.SuspendLayout()
        Me.Priv_MenuStrip.SuspendLayout()
        Me.XuiCustomGroupbox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pass_MenuStrip
        '
        Me.Pass_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.Pass_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecoverPasswordsToolStripMenuItem, Me.Save_PassMenu, Me.CSV_PASSWORDS})
        Me.Pass_MenuStrip.Name = "Pass_MenuStrip"
        Me.Pass_MenuStrip.Size = New System.Drawing.Size(187, 106)
        '
        'RecoverPasswordsToolStripMenuItem
        '
        Me.RecoverPasswordsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.RecoverPasswordsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RecoverPasswordsToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_show_passeword_32
        Me.RecoverPasswordsToolStripMenuItem.Name = "RecoverPasswordsToolStripMenuItem"
        Me.RecoverPasswordsToolStripMenuItem.Size = New System.Drawing.Size(186, 34)
        Me.RecoverPasswordsToolStripMenuItem.Text = "Recover Passwords"
        '
        'Save_PassMenu
        '
        Me.Save_PassMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Save_PassMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Save_PassMenu.Image = Global.Server.My.Resources.Resources.icons8_save_as_322
        Me.Save_PassMenu.Name = "Save_PassMenu"
        Me.Save_PassMenu.Size = New System.Drawing.Size(186, 34)
        Me.Save_PassMenu.Text = "Save"
        '
        'CSV_PASSWORDS
        '
        Me.CSV_PASSWORDS.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.CSV_PASSWORDS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CSV_PASSWORDS.Image = Global.Server.My.Resources.Resources.icons8_microsoft_excel_2019_32
        Me.CSV_PASSWORDS.Name = "CSV_PASSWORDS"
        Me.CSV_PASSWORDS.Size = New System.Drawing.Size(186, 34)
        Me.CSV_PASSWORDS.Text = "Export To .CSV"
        '
        'Hist_MenuStrip
        '
        Me.Hist_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.Hist_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Recover_history, Me.Save_HistoryMenu, Me.CSV_HISTORY})
        Me.Hist_MenuStrip.Name = "Pass_MenuStrip"
        Me.Hist_MenuStrip.Size = New System.Drawing.Size(170, 106)
        '
        'Recover_history
        '
        Me.Recover_history.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Recover_history.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Recover_history.Image = Global.Server.My.Resources.Resources.icons8_time_machine_321
        Me.Recover_history.Name = "Recover_history"
        Me.Recover_history.Size = New System.Drawing.Size(169, 34)
        Me.Recover_history.Text = "Recover History"
        '
        'Save_HistoryMenu
        '
        Me.Save_HistoryMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Save_HistoryMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Save_HistoryMenu.Image = Global.Server.My.Resources.Resources.icons8_save_as_322
        Me.Save_HistoryMenu.Name = "Save_HistoryMenu"
        Me.Save_HistoryMenu.Size = New System.Drawing.Size(169, 34)
        Me.Save_HistoryMenu.Text = "Save"
        '
        'CSV_HISTORY
        '
        Me.CSV_HISTORY.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.CSV_HISTORY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CSV_HISTORY.Image = Global.Server.My.Resources.Resources.icons8_microsoft_excel_2019_32
        Me.CSV_HISTORY.Name = "CSV_HISTORY"
        Me.CSV_HISTORY.Size = New System.Drawing.Size(169, 34)
        Me.CSV_HISTORY.Text = "Export To .CSV"
        '
        'W_PW_MenuStrip
        '
        Me.W_PW_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.W_PW_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecoverWifiPasswordToolStripMenuItem, Me.SaveToolStripMenuItem, Me.CSV_W_PW})
        Me.W_PW_MenuStrip.Name = "W_PW_MenuStrip"
        Me.W_PW_MenuStrip.Size = New System.Drawing.Size(206, 106)
        '
        'RecoverWifiPasswordToolStripMenuItem
        '
        Me.RecoverWifiPasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.RecoverWifiPasswordToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RecoverWifiPasswordToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_security_wi_fi_321
        Me.RecoverWifiPasswordToolStripMenuItem.Name = "RecoverWifiPasswordToolStripMenuItem"
        Me.RecoverWifiPasswordToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.RecoverWifiPasswordToolStripMenuItem.Text = "Recover Wifi Password"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_save_as_322
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'CSV_W_PW
        '
        Me.CSV_W_PW.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.CSV_W_PW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CSV_W_PW.Image = Global.Server.My.Resources.Resources.icons8_microsoft_excel_2019_32
        Me.CSV_W_PW.Name = "CSV_W_PW"
        Me.CSV_W_PW.Size = New System.Drawing.Size(205, 34)
        Me.CSV_W_PW.Text = "Export To .CSV"
        '
        'Tasks_MGR_MenuStrip
        '
        Me.Tasks_MGR_MenuStrip.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Tasks_MGR_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.Tasks_MGR_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.KillTaskToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ResumseToolStripMenuItem})
        Me.Tasks_MGR_MenuStrip.Name = "Tasks_MGR_MenuStrip"
        Me.Tasks_MGR_MenuStrip.Size = New System.Drawing.Size(129, 140)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RefreshToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_repeat_32
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(128, 34)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'KillTaskToolStripMenuItem
        '
        Me.KillTaskToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.KillTaskToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KillTaskToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_stop_32
        Me.KillTaskToolStripMenuItem.Name = "KillTaskToolStripMenuItem"
        Me.KillTaskToolStripMenuItem.Size = New System.Drawing.Size(128, 34)
        Me.KillTaskToolStripMenuItem.Text = "Kill Task"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PauseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PauseToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_pause_321
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(128, 34)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'ResumseToolStripMenuItem
        '
        Me.ResumseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ResumseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResumseToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_pdlay_32
        Me.ResumseToolStripMenuItem.Name = "ResumseToolStripMenuItem"
        Me.ResumseToolStripMenuItem.Size = New System.Drawing.Size(128, 34)
        Me.ResumseToolStripMenuItem.Text = "Resume"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(38, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "255.255.255.255:65535"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Custom_Button1
        '
        Me.Custom_Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Custom_Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Custom_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Custom_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Custom_Button1.ForeColor = System.Drawing.Color.White
        Me.Custom_Button1.Location = New System.Drawing.Point(940, 0)
        Me.Custom_Button1.Name = "Custom_Button1"
        Me.Custom_Button1.Size = New System.Drawing.Size(28, 28)
        Me.Custom_Button1.TabIndex = 1
        Me.Custom_Button1.Text = "X"
        Me.Custom_Button1.UseVisualStyleBackColor = True
        '
        'TabControlExt1
        '
        Me.TabControlExt1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControlExt1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlExt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabControlExt1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabControlExt1.CloseBtnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabControlExt1.Controls.Add(Me.TabPage1)
        Me.TabControlExt1.Controls.Add(Me.TabPage2)
        Me.TabControlExt1.Controls.Add(Me.TabPage3)
        Me.TabControlExt1.Controls.Add(Me.TabPage5)
        Me.TabControlExt1.Controls.Add(Me.TabPage4)
        Me.TabControlExt1.Controls.Add(Me.TabPage6)
        Me.TabControlExt1.Controls.Add(Me.TabPage7)
        Me.TabControlExt1.ForeColorBase = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TabControlExt1.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabControlExt1.HeadSelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabControlExt1.HeadSelectedBorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabControlExt1.IsShowCloseBtn = False
        Me.TabControlExt1.ItemSize = New System.Drawing.Size(0, 100)
        Me.TabControlExt1.Location = New System.Drawing.Point(7, 37)
        Me.TabControlExt1.Multiline = True
        Me.TabControlExt1.Name = "TabControlExt1"
        Me.TabControlExt1.SelectedIndex = 0
        Me.TabControlExt1.Size = New System.Drawing.Size(956, 525)
        Me.TabControlExt1.TabIndex = 0
        Me.TabControlExt1.UncloseTabIndexs = Nothing
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Loading_PW)
        Me.TabPage1.Controls.Add(Me.Passwords_ListView)
        Me.TabPage1.Location = New System.Drawing.Point(104, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 28, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(848, 517)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Passwords"
        '
        'Loading_PW
        '
        Me.Loading_PW.Active = False
        Me.Loading_PW.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Loading_PW.InnerCircleRadius = 5
        Me.Loading_PW.Location = New System.Drawing.Point(6, 3)
        Me.Loading_PW.Name = "Loading_PW"
        Me.Loading_PW.NumberSpoke = 12
        Me.Loading_PW.OuterCircleRadius = 11
        Me.Loading_PW.RotationSpeed = 100
        Me.Loading_PW.Size = New System.Drawing.Size(28, 25)
        Me.Loading_PW.SpokeThickness = 2
        Me.Loading_PW.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX
        Me.Loading_PW.TabIndex = 6
        Me.Loading_PW.Text = "LoadingCircle2"
        Me.Loading_PW.Visible = False
        '
        'Passwords_ListView
        '
        Me.Passwords_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Passwords_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Passwords_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.Passwords_ListView.ContextMenuStrip = Me.Pass_MenuStrip
        Me.Passwords_ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Passwords_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Passwords_ListView.HideSelection = False
        Me.Passwords_ListView.Location = New System.Drawing.Point(3, 28)
        Me.Passwords_ListView.Name = "Passwords_ListView"
        Me.Passwords_ListView.Size = New System.Drawing.Size(842, 486)
        Me.Passwords_ListView.TabIndex = 0
        Me.Passwords_ListView.UseCompatibleStateImageBehavior = False
        Me.Passwords_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "URL"
        Me.ColumnHeader1.Width = 247
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Username"
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Password"
        Me.ColumnHeader3.Width = 212
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Application"
        Me.ColumnHeader4.Width = 254
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Loading_Hist)
        Me.TabPage2.Controls.Add(Me.Hist_ListView)
        Me.TabPage2.Location = New System.Drawing.Point(104, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 28, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(848, 517)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "History"
        '
        'Loading_Hist
        '
        Me.Loading_Hist.Active = False
        Me.Loading_Hist.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Loading_Hist.InnerCircleRadius = 5
        Me.Loading_Hist.Location = New System.Drawing.Point(6, 3)
        Me.Loading_Hist.Name = "Loading_Hist"
        Me.Loading_Hist.NumberSpoke = 12
        Me.Loading_Hist.OuterCircleRadius = 11
        Me.Loading_Hist.RotationSpeed = 100
        Me.Loading_Hist.Size = New System.Drawing.Size(28, 25)
        Me.Loading_Hist.SpokeThickness = 2
        Me.Loading_Hist.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX
        Me.Loading_Hist.TabIndex = 7
        Me.Loading_Hist.Text = "LoadingCircle2"
        Me.Loading_Hist.Visible = False
        '
        'Hist_ListView
        '
        Me.Hist_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Hist_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Hist_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.Hist_ListView.ContextMenuStrip = Me.Hist_MenuStrip
        Me.Hist_ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hist_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Hist_ListView.HideSelection = False
        Me.Hist_ListView.Location = New System.Drawing.Point(3, 28)
        Me.Hist_ListView.Name = "Hist_ListView"
        Me.Hist_ListView.Size = New System.Drawing.Size(842, 486)
        Me.Hist_ListView.TabIndex = 1
        Me.Hist_ListView.UseCompatibleStateImageBehavior = False
        Me.Hist_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Application"
        Me.ColumnHeader5.Width = 142
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Title"
        Me.ColumnHeader6.Width = 215
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "URL"
        Me.ColumnHeader7.Width = 289
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Last Visit"
        Me.ColumnHeader8.Width = 201
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Loading_W_PW)
        Me.TabPage3.Controls.Add(Me.W_PW_ListView)
        Me.TabPage3.Location = New System.Drawing.Point(104, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 28, 3, 3)
        Me.TabPage3.Size = New System.Drawing.Size(848, 517)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Networking"
        '
        'Loading_W_PW
        '
        Me.Loading_W_PW.Active = False
        Me.Loading_W_PW.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Loading_W_PW.InnerCircleRadius = 5
        Me.Loading_W_PW.Location = New System.Drawing.Point(6, 3)
        Me.Loading_W_PW.Name = "Loading_W_PW"
        Me.Loading_W_PW.NumberSpoke = 12
        Me.Loading_W_PW.OuterCircleRadius = 11
        Me.Loading_W_PW.RotationSpeed = 100
        Me.Loading_W_PW.Size = New System.Drawing.Size(28, 25)
        Me.Loading_W_PW.SpokeThickness = 2
        Me.Loading_W_PW.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX
        Me.Loading_W_PW.TabIndex = 8
        Me.Loading_W_PW.Text = "LoadingCircle2"
        Me.Loading_W_PW.Visible = False
        '
        'W_PW_ListView
        '
        Me.W_PW_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.W_PW_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.W_PW_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.W_PW_ListView.ContextMenuStrip = Me.W_PW_MenuStrip
        Me.W_PW_ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.W_PW_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.W_PW_ListView.HideSelection = False
        Me.W_PW_ListView.Location = New System.Drawing.Point(3, 28)
        Me.W_PW_ListView.Name = "W_PW_ListView"
        Me.W_PW_ListView.Size = New System.Drawing.Size(842, 486)
        Me.W_PW_ListView.TabIndex = 0
        Me.W_PW_ListView.UseCompatibleStateImageBehavior = False
        Me.W_PW_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "SSID"
        Me.ColumnHeader9.Width = 197
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Password"
        Me.ColumnHeader10.Width = 174
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.CMD_ListView)
        Me.TabPage5.Location = New System.Drawing.Point(104, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(848, 517)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Miscellaneous"
        '
        'CMD_ListView
        '
        Me.CMD_ListView.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.CMD_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.CMD_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CMD_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12})
        Me.CMD_ListView.ContextMenuStrip = Me.Command_MenuStrip
        Me.CMD_ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CMD_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMD_ListView.FullRowSelect = True
        Me.CMD_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.CMD_ListView.HideSelection = False
        Me.CMD_ListView.ImeMode = System.Windows.Forms.ImeMode.Off
        ListViewItem31.ToolTipText = "Use to unlock any lock mouse"
        Me.CMD_ListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30, ListViewItem31, ListViewItem32})
        Me.CMD_ListView.Location = New System.Drawing.Point(3, 3)
        Me.CMD_ListView.Name = "CMD_ListView"
        Me.CMD_ListView.Size = New System.Drawing.Size(842, 511)
        Me.CMD_ListView.SmallImageList = Me.ImageList1
        Me.CMD_ListView.TabIndex = 0
        Me.CMD_ListView.UseCompatibleStateImageBehavior = False
        Me.CMD_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Command"
        Me.ColumnHeader12.Width = 835
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
        Me.LaunchToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_rorcket_32
        Me.LaunchToolStripMenuItem.Name = "LaunchToolStripMenuItem"
        Me.LaunchToolStripMenuItem.Size = New System.Drawing.Size(125, 34)
        Me.LaunchToolStripMenuItem.Text = "Launch"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ImageList1.Images.SetKeyName(0, "icons8_shutdown_32.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8_restart_32.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8_sign_out_32.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8_poison_32.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8_minus_32.png")
        Me.ImageList1.Images.SetKeyName(5, "icons8_plus_32.png")
        Me.ImageList1.Images.SetKeyName(6, "icons8_mute_32.png")
        Me.ImageList1.Images.SetKeyName(7, "icons8_poison_32.png")
        Me.ImageList1.Images.SetKeyName(8, "icons8_sign_out_32.png")
        Me.ImageList1.Images.SetKeyName(9, "icons8_shutdown_32.png")
        Me.ImageList1.Images.SetKeyName(10, "icons8_restart_32.png")
        Me.ImageList1.Images.SetKeyName(11, "icons8_stop_32.png")
        Me.ImageList1.Images.SetKeyName(12, "icons8_hibernate_32.png")
        Me.ImageList1.Images.SetKeyName(13, "icons8_shutdown_32.png")
        Me.ImageList1.Images.SetKeyName(14, "icons8_25%_32.png")
        Me.ImageList1.Images.SetKeyName(15, "icons8_50%.ico")
        Me.ImageList1.Images.SetKeyName(16, "icons8_100%_32.png")
        Me.ImageList1.Images.SetKeyName(17, "icons8_fraction_32.png")
        Me.ImageList1.Images.SetKeyName(18, "icons8_audio_32.png")
        Me.ImageList1.Images.SetKeyName(19, "icons8_voice_32.png")
        Me.ImageList1.Images.SetKeyName(20, "icons8_empty_trash_32.png")
        Me.ImageList1.Images.SetKeyName(21, "icons8_sleep_32.png")
        Me.ImageList1.Images.SetKeyName(22, "icons8_enter_32.png")
        Me.ImageList1.Images.SetKeyName(23, "icons8_restart_32.png")
        Me.ImageList1.Images.SetKeyName(24, "icons8_poison_32.png")
        Me.ImageList1.Images.SetKeyName(25, "icons8_no_audio_32.png")
        Me.ImageList1.Images.SetKeyName(26, "icons8_padldock_32.png")
        Me.ImageList1.Images.SetKeyName(27, "icons8_lodck_32.png")
        Me.ImageList1.Images.SetKeyName(28, "icons8_invisible_32.png")
        Me.ImageList1.Images.SetKeyName(29, "icons8_esqdye_32.png")
        Me.ImageList1.Images.SetKeyName(30, "icons8_swap_32.png")
        Me.ImageList1.Images.SetKeyName(31, "icons8_normal_32.png")
        Me.ImageList1.Images.SetKeyName(32, "icons8_blue_screefn_of_death_32.png")
        Me.ImageList1.Images.SetKeyName(33, "icons8_unlocksss.png")
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.Loading_tasks)
        Me.TabPage4.Controls.Add(Me.Helper_Task_Label)
        Me.TabPage4.Controls.Add(Me.Tasks_listview)
        Me.TabPage4.Location = New System.Drawing.Point(104, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 28, 3, 3)
        Me.TabPage4.Size = New System.Drawing.Size(848, 517)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Tasks MGR"
        '
        'Loading_tasks
        '
        Me.Loading_tasks.Active = False
        Me.Loading_tasks.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Loading_tasks.InnerCircleRadius = 5
        Me.Loading_tasks.Location = New System.Drawing.Point(184, 2)
        Me.Loading_tasks.Name = "Loading_tasks"
        Me.Loading_tasks.NumberSpoke = 12
        Me.Loading_tasks.OuterCircleRadius = 11
        Me.Loading_tasks.RotationSpeed = 100
        Me.Loading_tasks.Size = New System.Drawing.Size(28, 25)
        Me.Loading_tasks.SpokeThickness = 2
        Me.Loading_tasks.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX
        Me.Loading_tasks.TabIndex = 5
        Me.Loading_tasks.Text = "LoadingCircle1"
        Me.Loading_tasks.Visible = False
        '
        'Helper_Task_Label
        '
        Me.Helper_Task_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Helper_Task_Label.Location = New System.Drawing.Point(3, 2)
        Me.Helper_Task_Label.Name = "Helper_Task_Label"
        Me.Helper_Task_Label.Size = New System.Drawing.Size(182, 23)
        Me.Helper_Task_Label.TabIndex = 4
        Me.Helper_Task_Label.Text = "Wait until you see name appearing...."
        Me.Helper_Task_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Helper_Task_Label.Visible = False
        '
        'Tasks_listview
        '
        Me.Tasks_listview.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Tasks_listview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tasks_listview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11})
        Me.Tasks_listview.ContextMenuStrip = Me.Tasks_MGR_MenuStrip
        Me.Tasks_listview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tasks_listview.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Tasks_listview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Tasks_listview.HideSelection = False
        Me.Tasks_listview.Location = New System.Drawing.Point(3, 28)
        Me.Tasks_listview.Name = "Tasks_listview"
        Me.Tasks_listview.Size = New System.Drawing.Size(842, 486)
        Me.Tasks_listview.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.Tasks_listview.TabIndex = 1
        Me.Tasks_listview.UseCompatibleStateImageBehavior = False
        Me.Tasks_listview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Name"
        Me.ColumnHeader11.Width = 258
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.XuiCustomGroupbox1)
        Me.TabPage6.Location = New System.Drawing.Point(104, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(848, 517)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Injection | Native"
        '
        'XuiCustomGroupbox1
        '
        Me.XuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XuiCustomGroupbox1.BorderWidth = 1
        Me.XuiCustomGroupbox1.Controls.Add(Me.DLL_NAT_ListView)
        Me.XuiCustomGroupbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XuiCustomGroupbox1.Location = New System.Drawing.Point(3, 3)
        Me.XuiCustomGroupbox1.Name = "XuiCustomGroupbox1"
        Me.XuiCustomGroupbox1.ShowText = True
        Me.XuiCustomGroupbox1.Size = New System.Drawing.Size(842, 511)
        Me.XuiCustomGroupbox1.TabIndex = 5
        Me.XuiCustomGroupbox1.TabStop = False
        Me.XuiCustomGroupbox1.Text = "Native Injection | For Unmanaged DLL"
        Me.XuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        '
        'DLL_NAT_ListView
        '
        Me.DLL_NAT_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.DLL_NAT_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DLL_NAT_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14})
        Me.DLL_NAT_ListView.ContextMenuStrip = Me.ADD_DLL_NAT_MenuStrip
        Me.DLL_NAT_ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DLL_NAT_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DLL_NAT_ListView.HideSelection = False
        Me.DLL_NAT_ListView.Location = New System.Drawing.Point(3, 16)
        Me.DLL_NAT_ListView.Name = "DLL_NAT_ListView"
        Me.DLL_NAT_ListView.Size = New System.Drawing.Size(836, 492)
        Me.DLL_NAT_ListView.TabIndex = 4
        Me.DLL_NAT_ListView.UseCompatibleStateImageBehavior = False
        Me.DLL_NAT_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "FilePath"
        Me.ColumnHeader13.Width = 709
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Size"
        Me.ColumnHeader14.Width = 117
        '
        'ADD_DLL_NAT_MenuStrip
        '
        Me.ADD_DLL_NAT_MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.ADD_DLL_NAT_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ADD_DLL_NAT_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Inject_Nat_ToolStripMenuItem, Me.AddToolStripMenuItem, Me.RemvoeToolStripMenuItem})
        Me.ADD_DLL_NAT_MenuStrip.Name = "ADD_DLL_NAT_MenuStrip"
        Me.ADD_DLL_NAT_MenuStrip.Size = New System.Drawing.Size(130, 106)
        '
        'Inject_Nat_ToolStripMenuItem
        '
        Me.Inject_Nat_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Inject_Nat_ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Inject_Nat_ToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_electronics_32
        Me.Inject_Nat_ToolStripMenuItem.Name = "Inject_Nat_ToolStripMenuItem"
        Me.Inject_Nat_ToolStripMenuItem.Size = New System.Drawing.Size(129, 34)
        Me.Inject_Nat_ToolStripMenuItem.Text = "Inject"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.AddToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_add_32
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(129, 34)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'RemvoeToolStripMenuItem
        '
        Me.RemvoeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.RemvoeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RemvoeToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_minus_32
        Me.RemvoeToolStripMenuItem.Name = "RemvoeToolStripMenuItem"
        Me.RemvoeToolStripMenuItem.Size = New System.Drawing.Size(129, 34)
        Me.RemvoeToolStripMenuItem.Text = "Remvoe"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage7.Controls.Add(Me.XuiCustomGroupbox4)
        Me.TabPage7.Controls.Add(Me.XuiCustomGroupbox3)
        Me.TabPage7.Controls.Add(Me.XuiCustomGroupbox2)
        Me.TabPage7.Location = New System.Drawing.Point(104, 4)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(848, 517)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Native"
        '
        'XuiCustomGroupbox4
        '
        Me.XuiCustomGroupbox4.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XuiCustomGroupbox4.BorderWidth = 1
        Me.XuiCustomGroupbox4.Controls.Add(Me.Label7)
        Me.XuiCustomGroupbox4.Controls.Add(Me.Label6)
        Me.XuiCustomGroupbox4.Controls.Add(Me.Label5)
        Me.XuiCustomGroupbox4.Controls.Add(Me.Label4)
        Me.XuiCustomGroupbox4.Controls.Add(Me.Chk_UAC_Btn)
        Me.XuiCustomGroupbox4.Location = New System.Drawing.Point(6, 392)
        Me.XuiCustomGroupbox4.Name = "XuiCustomGroupbox4"
        Me.XuiCustomGroupbox4.ShowText = True
        Me.XuiCustomGroupbox4.Size = New System.Drawing.Size(326, 112)
        Me.XuiCustomGroupbox4.TabIndex = 12
        Me.XuiCustomGroupbox4.TabStop = False
        Me.XuiCustomGroupbox4.Text = "UAC"
        Me.XuiCustomGroupbox4.TextColor = System.Drawing.Color.DodgerBlue
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(25, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "?"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(25, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "?"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(25, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "?"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "?"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Chk_UAC_Btn
        '
        Me.Chk_UAC_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Chk_UAC_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Chk_UAC_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chk_UAC_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Chk_UAC_Btn.Location = New System.Drawing.Point(6, 19)
        Me.Chk_UAC_Btn.Name = "Chk_UAC_Btn"
        Me.Chk_UAC_Btn.Size = New System.Drawing.Size(314, 29)
        Me.Chk_UAC_Btn.TabIndex = 11
        Me.Chk_UAC_Btn.Text = "Check UAC"
        Me.Chk_UAC_Btn.UseVisualStyleBackColor = True
        '
        'XuiCustomGroupbox3
        '
        Me.XuiCustomGroupbox3.AutoSize = True
        Me.XuiCustomGroupbox3.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XuiCustomGroupbox3.BorderWidth = 1
        Me.XuiCustomGroupbox3.Controls.Add(Me.Priv_ListView)
        Me.XuiCustomGroupbox3.Location = New System.Drawing.Point(6, 6)
        Me.XuiCustomGroupbox3.Name = "XuiCustomGroupbox3"
        Me.XuiCustomGroupbox3.ShowText = True
        Me.XuiCustomGroupbox3.Size = New System.Drawing.Size(831, 245)
        Me.XuiCustomGroupbox3.TabIndex = 11
        Me.XuiCustomGroupbox3.TabStop = False
        Me.XuiCustomGroupbox3.Text = "Privileges"
        Me.XuiCustomGroupbox3.TextColor = System.Drawing.Color.DodgerBlue
        '
        'Priv_ListView
        '
        Me.Priv_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Priv_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16})
        Me.Priv_ListView.ContextMenuStrip = Me.Priv_MenuStrip
        Me.Priv_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Priv_ListView.HideSelection = False
        Me.Priv_ListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem33, ListViewItem34, ListViewItem35, ListViewItem36, ListViewItem37, ListViewItem38, ListViewItem39, ListViewItem40, ListViewItem41, ListViewItem42, ListViewItem43, ListViewItem44, ListViewItem45, ListViewItem46, ListViewItem47, ListViewItem48, ListViewItem49, ListViewItem50, ListViewItem51, ListViewItem52, ListViewItem53, ListViewItem54, ListViewItem55, ListViewItem56, ListViewItem57, ListViewItem58, ListViewItem59, ListViewItem60, ListViewItem61, ListViewItem62, ListViewItem63, ListViewItem64, ListViewItem65, ListViewItem66, ListViewItem67})
        Me.Priv_ListView.Location = New System.Drawing.Point(6, 19)
        Me.Priv_ListView.Name = "Priv_ListView"
        Me.Priv_ListView.Size = New System.Drawing.Size(819, 207)
        Me.Priv_ListView.TabIndex = 0
        Me.Priv_ListView.UseCompatibleStateImageBehavior = False
        Me.Priv_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Privileges"
        Me.ColumnHeader15.Width = 356
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Status"
        Me.ColumnHeader16.Width = 299
        '
        'Priv_MenuStrip
        '
        Me.Priv_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.Priv_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetToolStripMenuItem})
        Me.Priv_MenuStrip.Name = "Priv_MenuStrip"
        Me.Priv_MenuStrip.Size = New System.Drawing.Size(93, 26)
        '
        'GetToolStripMenuItem
        '
        Me.GetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GetToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GetToolStripMenuItem.Name = "GetToolStripMenuItem"
        Me.GetToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.GetToolStripMenuItem.Text = "Get"
        '
        'XuiCustomGroupbox2
        '
        Me.XuiCustomGroupbox2.AutoSize = True
        Me.XuiCustomGroupbox2.BorderColor = System.Drawing.Color.DodgerBlue
        Me.XuiCustomGroupbox2.BorderWidth = 1
        Me.XuiCustomGroupbox2.Controls.Add(Me.ComboBox1)
        Me.XuiCustomGroupbox2.Controls.Add(Me.Label3)
        Me.XuiCustomGroupbox2.Controls.Add(Me.Change_Prio_Btn)
        Me.XuiCustomGroupbox2.Controls.Add(Me.Label2)
        Me.XuiCustomGroupbox2.Controls.Add(Me.Get_Prio_Btn)
        Me.XuiCustomGroupbox2.Location = New System.Drawing.Point(6, 257)
        Me.XuiCustomGroupbox2.Name = "XuiCustomGroupbox2"
        Me.XuiCustomGroupbox2.ShowText = True
        Me.XuiCustomGroupbox2.Size = New System.Drawing.Size(499, 129)
        Me.XuiCustomGroupbox2.TabIndex = 10
        Me.XuiCustomGroupbox2.TabStop = False
        Me.XuiCustomGroupbox2.Text = "Priority"
        Me.XuiCustomGroupbox2.TextColor = System.Drawing.Color.DodgerBlue
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"NORMAL_PRIORITY_CLASS", "ABOVE_NORMAL_PRIORITY_CLASS", "HIGH_PRIORITY_CLASS", "BELOW_NORMAL_PRIORITY_CLASS", "IDLE_PRIORITY_CLASS"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(439, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(455, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Change_Prio_Btn
        '
        Me.Change_Prio_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Change_Prio_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Change_Prio_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Change_Prio_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Change_Prio_Btn.Location = New System.Drawing.Point(6, 46)
        Me.Change_Prio_Btn.Name = "Change_Prio_Btn"
        Me.Change_Prio_Btn.Size = New System.Drawing.Size(439, 29)
        Me.Change_Prio_Btn.TabIndex = 7
        Me.Change_Prio_Btn.Text = "Change Priority"
        Me.Change_Prio_Btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(455, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Get_Prio_Btn
        '
        Me.Get_Prio_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Get_Prio_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Get_Prio_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Get_Prio_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Get_Prio_Btn.Location = New System.Drawing.Point(6, 81)
        Me.Get_Prio_Btn.Name = "Get_Prio_Btn"
        Me.Get_Prio_Btn.Size = New System.Drawing.Size(439, 29)
        Me.Get_Prio_Btn.TabIndex = 8
        Me.Get_Prio_Btn.Text = "Get Priority"
        Me.Get_Prio_Btn.UseVisualStyleBackColor = True
        '
        'Client_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 574)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Custom_Button1)
        Me.Controls.Add(Me.TabControlExt1)
        Me.Name = "Client_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client_Form"
        Me.Pass_MenuStrip.ResumeLayout(False)
        Me.Hist_MenuStrip.ResumeLayout(False)
        Me.W_PW_MenuStrip.ResumeLayout(False)
        Me.Tasks_MGR_MenuStrip.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlExt1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Command_MenuStrip.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.XuiCustomGroupbox1.ResumeLayout(False)
        Me.ADD_DLL_NAT_MenuStrip.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.XuiCustomGroupbox4.ResumeLayout(False)
        Me.XuiCustomGroupbox4.PerformLayout()
        Me.XuiCustomGroupbox3.ResumeLayout(False)
        Me.Priv_MenuStrip.ResumeLayout(False)
        Me.XuiCustomGroupbox2.ResumeLayout(False)
        Me.XuiCustomGroupbox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlExt1 As HZH_Controls.Controls.TabControlExt
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Passwords_ListView As AeroListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Pass_MenuStrip As ContextMenuStrip
    Friend WithEvents RecoverPasswordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Save_PassMenu As ToolStripMenuItem
    Friend WithEvents Hist_ListView As AeroListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Hist_MenuStrip As ContextMenuStrip
    Friend WithEvents Recover_history As ToolStripMenuItem
    Friend WithEvents Save_HistoryMenu As ToolStripMenuItem
    Friend WithEvents Custom_Button1 As Custom_Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents W_PW_ListView As AeroListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents W_PW_MenuStrip As ContextMenuStrip
    Friend WithEvents RecoverWifiPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Tasks_listview As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Tasks_MGR_MenuStrip As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KillTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Helper_Task_Label As Label
    Friend WithEvents Loading_tasks As MRG.Controls.UI.LoadingCircle
    Friend WithEvents Loading_PW As MRG.Controls.UI.LoadingCircle
    Friend WithEvents Loading_Hist As MRG.Controls.UI.LoadingCircle
    Friend WithEvents Loading_W_PW As MRG.Controls.UI.LoadingCircle
    Friend WithEvents PauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResumseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents CMD_ListView As AeroListView
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Command_MenuStrip As ContextMenuStrip
    Friend WithEvents LaunchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents DLL_NAT_ListView As ListView
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ADD_DLL_NAT_MenuStrip As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemvoeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Inject_Nat_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XuiCustomGroupbox1 As XanderUI.XUICustomGroupbox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Priv_ListView As ListView
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents Priv_MenuStrip As ContextMenuStrip
    Friend WithEvents GetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Get_Prio_Btn As Custom_Button
    Friend WithEvents Change_Prio_Btn As Custom_Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents XuiCustomGroupbox2 As XanderUI.XUICustomGroupbox
    Friend WithEvents XuiCustomGroupbox3 As XanderUI.XUICustomGroupbox
    Friend WithEvents XuiCustomGroupbox4 As XanderUI.XUICustomGroupbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Chk_UAC_Btn As Custom_Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CSV_W_PW As ToolStripMenuItem
    Friend WithEvents CSV_PASSWORDS As ToolStripMenuItem
    Friend WithEvents CSV_HISTORY As ToolStripMenuItem
End Class
