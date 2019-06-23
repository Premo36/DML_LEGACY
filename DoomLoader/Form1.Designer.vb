<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cboxIWAD = New System.Windows.Forms.ComboBox()
        Me.lstMod = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeIWADDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePWADDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePortExecutablePathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshResourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChandePortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboxCFG = New System.Windows.Forms.ComboBox()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.cmdSavePreset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Groupbox6 = New System.Windows.Forms.GroupBox()
        Me.txtCustom = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblSkill = New System.Windows.Forms.Label()
        Me.nudSkill = New System.Windows.Forms.NumericUpDown()
        Me.chkFast = New System.Windows.Forms.CheckBox()
        Me.txtWarp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkRespawn = New System.Windows.Forms.CheckBox()
        Me.chkNoMonster = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbEnableAllSounds = New System.Windows.Forms.RadioButton()
        Me.rbNomusic = New System.Windows.Forms.RadioButton()
        Me.rbNosfx = New System.Windows.Forms.RadioButton()
        Me.rbNosound = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Groupbox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nudSkill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboxIWAD
        '
        Me.cboxIWAD.FormattingEnabled = True
        Me.cboxIWAD.Location = New System.Drawing.Point(194, 161)
        Me.cboxIWAD.Name = "cboxIWAD"
        Me.cboxIWAD.Size = New System.Drawing.Size(272, 21)
        Me.cboxIWAD.TabIndex = 1
        Me.cboxIWAD.Text = "Select IWAD (Original Game)"
        '
        'lstMod
        '
        Me.lstMod.FormattingEnabled = True
        Me.lstMod.Location = New System.Drawing.Point(6, 19)
        Me.lstMod.Name = "lstMod"
        Me.lstMod.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstMod.Size = New System.Drawing.Size(327, 251)
        Me.lstMod.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(841, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeIWADDirectoryToolStripMenuItem, Me.ChangePWADDirectoryToolStripMenuItem, Me.ChangePortExecutablePathToolStripMenuItem, Me.RefreshResourceToolStripMenuItem, Me.ChandePortToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ChangeIWADDirectoryToolStripMenuItem
        '
        Me.ChangeIWADDirectoryToolStripMenuItem.Name = "ChangeIWADDirectoryToolStripMenuItem"
        Me.ChangeIWADDirectoryToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ChangeIWADDirectoryToolStripMenuItem.Text = "Change IWAD directory path..."
        '
        'ChangePWADDirectoryToolStripMenuItem
        '
        Me.ChangePWADDirectoryToolStripMenuItem.Name = "ChangePWADDirectoryToolStripMenuItem"
        Me.ChangePWADDirectoryToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ChangePWADDirectoryToolStripMenuItem.Text = "Change PWAD directory path..."
        '
        'ChangePortExecutablePathToolStripMenuItem
        '
        Me.ChangePortExecutablePathToolStripMenuItem.Name = "ChangePortExecutablePathToolStripMenuItem"
        Me.ChangePortExecutablePathToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ChangePortExecutablePathToolStripMenuItem.Text = "Change port executable path..."
        '
        'RefreshResourceToolStripMenuItem
        '
        Me.RefreshResourceToolStripMenuItem.Name = "RefreshResourceToolStripMenuItem"
        Me.RefreshResourceToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.RefreshResourceToolStripMenuItem.Text = "Reload Resource"
        '
        'ChandePortToolStripMenuItem
        '
        Me.ChandePortToolStripMenuItem.Name = "ChandePortToolStripMenuItem"
        Me.ChandePortToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ChandePortToolStripMenuItem.Text = "Quit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'cboxCFG
        '
        Me.cboxCFG.FormattingEnabled = True
        Me.cboxCFG.Location = New System.Drawing.Point(6, 323)
        Me.cboxCFG.Name = "cboxCFG"
        Me.cboxCFG.Size = New System.Drawing.Size(327, 21)
        Me.cboxCFG.TabIndex = 5
        Me.cboxCFG.Text = "Select a saved preset"
        '
        'cmdPlay
        '
        Me.cmdPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlay.Location = New System.Drawing.Point(362, 296)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(472, 88)
        Me.cmdPlay.TabIndex = 6
        Me.cmdPlay.Text = "PLAY"
        Me.cmdPlay.UseVisualStyleBackColor = True
        '
        'cmdSavePreset
        '
        Me.cmdSavePreset.Location = New System.Drawing.Point(6, 276)
        Me.cmdSavePreset.Name = "cmdSavePreset"
        Me.cmdSavePreset.Size = New System.Drawing.Size(327, 33)
        Me.cmdSavePreset.TabIndex = 7
        Me.cmdSavePreset.Text = "Save curret selected mod in a preset"
        Me.cmdSavePreset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSavePreset)
        Me.GroupBox1.Controls.Add(Me.cboxCFG)
        Me.GroupBox1.Controls.Add(Me.lstMod)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 349)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mod List"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Groupbox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.cboxIWAD)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(362, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 263)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lunch Options"
        '
        'Groupbox6
        '
        Me.Groupbox6.Controls.Add(Me.txtCustom)
        Me.Groupbox6.Location = New System.Drawing.Point(11, 202)
        Me.Groupbox6.Name = "Groupbox6"
        Me.Groupbox6.Size = New System.Drawing.Size(455, 53)
        Me.Groupbox6.TabIndex = 6
        Me.Groupbox6.TabStop = False
        Me.Groupbox6.Text = "Custom Command line Parameters"
        '
        'txtCustom
        '
        Me.txtCustom.Location = New System.Drawing.Point(9, 19)
        Me.txtCustom.Name = "txtCustom"
        Me.txtCustom.Size = New System.Drawing.Size(446, 20)
        Me.txtCustom.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtWidth)
        Me.GroupBox5.Controls.Add(Me.txtHeight)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 126)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(177, 70)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Video"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(48, 19)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(123, 20)
        Me.txtWidth.TabIndex = 3
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(48, 44)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(123, 20)
        Me.txtHeight.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "-Width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "-Height"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblSkill)
        Me.GroupBox4.Controls.Add(Me.nudSkill)
        Me.GroupBox4.Controls.Add(Me.chkFast)
        Me.GroupBox4.Controls.Add(Me.txtWarp)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.chkRespawn)
        Me.GroupBox4.Controls.Add(Me.chkNoMonster)
        Me.GroupBox4.Location = New System.Drawing.Point(194, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(272, 126)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gameplay"
        '
        'lblSkill
        '
        Me.lblSkill.AutoSize = True
        Me.lblSkill.Enabled = False
        Me.lblSkill.Location = New System.Drawing.Point(3, 39)
        Me.lblSkill.Name = "lblSkill"
        Me.lblSkill.Size = New System.Drawing.Size(83, 13)
        Me.lblSkill.TabIndex = 6
        Me.lblSkill.Text = "Skill level (-skill):"
        '
        'nudSkill
        '
        Me.nudSkill.Enabled = False
        Me.nudSkill.Location = New System.Drawing.Point(128, 37)
        Me.nudSkill.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudSkill.Name = "nudSkill"
        Me.nudSkill.Size = New System.Drawing.Size(100, 20)
        Me.nudSkill.TabIndex = 5
        '
        'chkFast
        '
        Me.chkFast.AutoSize = True
        Me.chkFast.Enabled = False
        Me.chkFast.Location = New System.Drawing.Point(6, 61)
        Me.chkFast.Name = "chkFast"
        Me.chkFast.Size = New System.Drawing.Size(110, 17)
        Me.chkFast.TabIndex = 1
        Me.chkFast.Text = "Fast Moster (-fast)"
        Me.chkFast.UseVisualStyleBackColor = True
        '
        'txtWarp
        '
        Me.txtWarp.Location = New System.Drawing.Point(128, 14)
        Me.txtWarp.Name = "txtWarp"
        Me.txtWarp.Size = New System.Drawing.Size(100, 20)
        Me.txtWarp.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start From Level (-map):"
        '
        'chkRespawn
        '
        Me.chkRespawn.AutoSize = True
        Me.chkRespawn.Enabled = False
        Me.chkRespawn.Location = New System.Drawing.Point(6, 84)
        Me.chkRespawn.Name = "chkRespawn"
        Me.chkRespawn.Size = New System.Drawing.Size(164, 17)
        Me.chkRespawn.TabIndex = 2
        Me.chkRespawn.Text = "Monster Respawn (-respawn)"
        Me.chkRespawn.UseVisualStyleBackColor = True
        '
        'chkNoMonster
        '
        Me.chkNoMonster.AutoSize = True
        Me.chkNoMonster.Enabled = False
        Me.chkNoMonster.Location = New System.Drawing.Point(6, 107)
        Me.chkNoMonster.Name = "chkNoMonster"
        Me.chkNoMonster.Size = New System.Drawing.Size(173, 17)
        Me.chkNoMonster.TabIndex = 0
        Me.chkNoMonster.Text = "Remove Monster (-nomonsters)"
        Me.chkNoMonster.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbEnableAllSounds)
        Me.GroupBox3.Controls.Add(Me.rbNomusic)
        Me.GroupBox3.Controls.Add(Me.rbNosfx)
        Me.GroupBox3.Controls.Add(Me.rbNosound)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(177, 106)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Audio"
        '
        'rbEnableAllSounds
        '
        Me.rbEnableAllSounds.AutoSize = True
        Me.rbEnableAllSounds.Checked = True
        Me.rbEnableAllSounds.Location = New System.Drawing.Point(6, 17)
        Me.rbEnableAllSounds.Name = "rbEnableAllSounds"
        Me.rbEnableAllSounds.Size = New System.Drawing.Size(111, 17)
        Me.rbEnableAllSounds.TabIndex = 10
        Me.rbEnableAllSounds.TabStop = True
        Me.rbEnableAllSounds.Text = "Enable All Sounds"
        Me.rbEnableAllSounds.UseVisualStyleBackColor = True
        '
        'rbNomusic
        '
        Me.rbNomusic.AutoSize = True
        Me.rbNomusic.Location = New System.Drawing.Point(6, 81)
        Me.rbNomusic.Name = "rbNomusic"
        Me.rbNomusic.Size = New System.Drawing.Size(142, 17)
        Me.rbNomusic.TabIndex = 9
        Me.rbNomusic.Text = "Disable Music (-nomusic)"
        Me.rbNomusic.UseVisualStyleBackColor = True
        '
        'rbNosfx
        '
        Me.rbNosfx.AutoSize = True
        Me.rbNosfx.Location = New System.Drawing.Point(6, 59)
        Me.rbNosfx.Name = "rbNosfx"
        Me.rbNosfx.Size = New System.Drawing.Size(120, 17)
        Me.rbNosfx.TabIndex = 8
        Me.rbNosfx.Text = "Disable SFX (-nosfx)"
        Me.rbNosfx.UseVisualStyleBackColor = True
        '
        'rbNosound
        '
        Me.rbNosound.AutoSize = True
        Me.rbNosound.Location = New System.Drawing.Point(6, 38)
        Me.rbNosound.Name = "rbNosound"
        Me.rbNosound.Size = New System.Drawing.Size(171, 17)
        Me.rbNosound.TabIndex = 7
        Me.rbNosound.Text = "Disable All Sounds (-nosounds)"
        Me.rbNosound.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 391)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Doom Mod Loader v1.1 by Premo36"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Groupbox6.ResumeLayout(False)
        Me.Groupbox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nudSkill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboxIWAD As ComboBox
    Friend WithEvents lstMod As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeIWADDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChandePortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboxCFG As ComboBox
    Friend WithEvents cmdPlay As Button
    Friend WithEvents cmdSavePreset As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkRespawn As CheckBox
    Friend WithEvents chkFast As CheckBox
    Friend WithEvents chkNoMonster As CheckBox
    Friend WithEvents txtWarp As TextBox
    Friend WithEvents lblSkill As Label
    Friend WithEvents nudSkill As NumericUpDown
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Groupbox6 As GroupBox
    Friend WithEvents txtCustom As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents rbNosound As RadioButton
    Friend WithEvents rbNomusic As RadioButton
    Friend WithEvents rbNosfx As RadioButton
    Friend WithEvents rbEnableAllSounds As RadioButton
    Friend WithEvents ChangePWADDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePortExecutablePathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshResourceToolStripMenuItem As ToolStripMenuItem
End Class
