Imports System.IO
Public Class Form1
    Public ModPaths(1000) As String
    Public IWADpaths(100) As String
    Public EXEpaths As String
    Public AP As String

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software") = False Then

            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software")
        End If

        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML") = False Then
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML")
        End If

        If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\dml.cfg") = False Then
            Using sw As StreamWriter = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\dml.cfg")
                sw.WriteLine("C:\")
                sw.WriteLine("C:\")
                sw.WriteLine("C:\")
            End Using
            MsgBox("Before you can use Doom Mod Load by P36 Software, you should specify:" & vbCrLf & "1)The path to your IWAD's folder (original game like doom.wad, chex3.wad etc...) " & vbCrLf & "2)Your PWAD's folder (the folder with all your mods, like brutalv20.pk3, psychophobia.pk3 etc...) " & vbCrLf & "3)The path to the port's executable (the path to your zdoom.exe or gzdoom.exe or zandronum.exe etc...)" & vbCrLf & "(However, you can do this later by clicking on File-->Change...)")
            ChangeIWAD()
            ChangePWAD()
            ChangePort()
        End If
        LoadFile()
        txtWidth.Text = Screen.PrimaryScreen.Bounds.Width
        txtHeight.Text = Screen.PrimaryScreen.Bounds.Height
    End Sub


    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click


        If cboxIWAD.SelectedIndex >= 0 Then
            AP = ""


            If rbNosound.Checked Then
                AP = AP & " -nosound "
            ElseIf rbNomusic.Checked Then
                AP = AP & " -nomusic "
            ElseIf rbNosfx.Checked Then
                AP = AP & " -nosfx "
            End If



            If chkRespawn.Checked And txtWarp.Text <> "" Then
                AP = AP & " -respawn "
            End If

            If txtWarp.Text <> "" Then
                AP = AP + " -warp " & txtWarp.Text

                If chkNoMonster.Checked Then
                    AP = AP & " -nomonsters "
                End If

                If chkFast.Checked Then
                    AP = AP & " -fast "
                End If

                AP = AP & " -skill " & nudSkill.Value


            End If

            If txtHeight.Text <> "" Then
                AP = AP & " -height  " & txtHeight.Text
            End If

            If txtWidth.Text <> "" Then
                AP = AP & " -width " & txtWidth.Text
            End If

            AP = AP & " " & txtCustom.Text

            If Application.OpenForms().OfType(Of Form3).Any Then
                Form3.Close()
                Form3.Show()

            Else
                Form3.Show()
            End If


        Else
            MsgBox("You must specify your original game in order to play!", 16, "ERROR - IWAD UNSELECTED!")
        End If
    End Sub

    Sub ChangeIWAD()
        Dim path() As String = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\dml.cfg")
        Using iw As New FolderBrowserDialog
            iw.Description = "Specify the IWAD's folder (Original Game)"
            If iw.ShowDialog() = DialogResult.OK Then
                path(0) = iw.SelectedPath
            End If
        End Using
        File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\dml.cfg", path)
    End Sub

    Sub ChangePWAD()
        Dim path() As String = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\dml.cfg")
        Using pw As New FolderBrowserDialog
            pw.Description = "Specify the PWAD's folder (User's mod)"
            If pw.ShowDialog() = DialogResult.OK Then
                path(1) = pw.SelectedPath
            End If
        End Using
        File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\dml.cfg", path)
    End Sub

    Sub ChangePort()
        Dim path() As String = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\dml.cfg")
        Using exe As New OpenFileDialog
            exe.Title = "Select the .exe of your favourite doom engine port"
            exe.Filter = "Executable|*exe"
            If exe.ShowDialog() = DialogResult.OK Then
                path(2) = exe.FileName
            End If
        End Using
        File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\dml.cfg", path)
    End Sub



    Sub LoadFile()
        Dim per() As String = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\dml.cfg")
        Dim WAD() As String = Directory.GetFiles(per(0))
        Dim modd() = Directory.GetFiles(per(1))
        lstMod.Items.Clear()
        cboxIWAD.Items.Clear()
        cboxCFG.Items.Clear()
        EXEpaths = per(2)
        Dim y As Byte = 0
        For Each s As String In modd
            Dim z As String = Path.GetExtension(UCase(s))
            If z = ".WAD" Or z = ".PK3" Or z = ".ZIP" Or z = ".7Z" Or z = ".PK7" Then

                lstMod.Items.Add(Path.GetFileName(s))

                ModPaths(y) = s
                y = y + 1

            End If
        Next



        Dim Q As Byte = 0
        For Each Str As String In WAD
            Dim w As String = Path.GetFileName(UCase(Str))
            If w = "DOOM1.WAD" Or w = "DOOM.WAD" Or w = "FREEDOOM1.WAD" Or w = "DOOM2.WAD" Or w = "TNT.WAD" Or w = "PLUTONIA.WAD" Or w = "FREEDM.WAD" Or w = "FREEDOOM2.WAD" Or w = "DOOM2F.WAD" Or w = "HERETIC1.WAD" Or w = "HERETIC.WAD" Or w = "HEXEN.WAD" Or w = "HEXDD.WAD" Or w = "STRIFE0.WAD" Or w = "STRIFE1.WAD" Or w = "CHEX.WAD" Or w = "CHEX3.WAD" Or w = "ACTION2.WAD" Or w = "HARM1.WAD" Or w = "HACX.WAD" Or w = "SQUARE1.PK3" Then

                cboxIWAD.Items.Add(Path.GetFileName(Str))

                IWADpaths(Q) = Str

                Q = Q + 1
            End If
        Next

        Dim pre() As String = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\")

        For Each s As String In pre
            Dim z As String = Path.GetExtension(UCase(s))
            If z = ".SAV" Then

                cboxCFG.Items.Add(Path.GetFileName(s))


            End If
        Next

        cboxCFG.Text = "Select a saved preset"
        cboxIWAD.Text = "Select IWAD (Original Game)"
    End Sub

    Private Sub cmdSavePreset_Click(sender As Object, e As EventArgs) Handles cmdSavePreset.Click
        Dim NMD() As Object = (From item In Me.lstMod.SelectedItems Select item).ToArray()
        Dim Nome As String = InputBox("What's the preset's name?")
        If Nome <> "" Then

            Using sw As StreamWriter = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\" & Nome & ".sav")
                For Each obj In NMD
                    sw.WriteLine(obj.ToString())
                Next
            End Using
            LoadFile()

        Else
            MsgBox("Preset's saving aborted", 64)
        End If



    End Sub



    Private Sub cboxCFG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxCFG.SelectedIndexChanged

        Dim ModPreset() As String = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\P36_Software\DML\" & cboxCFG.SelectedItem.ToString())
        Dim y As Byte = 0
        lstMod.SelectedItems.Clear()
        Dim k As Byte
        For y = 0 To ModPreset.Length - 1
            For k = 0 To lstMod.Items.Count - 1
                If lstMod.Items(k).ToString() = ModPreset(y) Then

                    lstMod.SetSelected(k, True)
                End If
            Next k
        Next y
    End Sub

    Private Sub txtWarp_TextChanged(sender As Object, e As EventArgs) Handles txtWarp.TextChanged
        If txtWarp.Text <> "" Then
            chkNoMonster.Enabled = True
            chkRespawn.Enabled = True
            chkFast.Enabled = True
            nudSkill.Enabled = True
            lblSkill.Enabled = True
        Else
            chkNoMonster.Enabled = False
            chkRespawn.Enabled = False
            chkFast.Enabled = False
            nudSkill.Enabled = False
            lblSkill.Enabled = False
        End If
    End Sub

    Private Sub ChangeIWADDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeIWADDirectoryToolStripMenuItem.Click
        ChangeIWAD()
        LoadFile()
    End Sub

    Private Sub ChangePWADDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePWADDirectoryToolStripMenuItem.Click
        ChangePWAD()
        LoadFile()
    End Sub

    Private Sub ChangePortExecutablePathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePortExecutablePathToolStripMenuItem.Click
        ChangePort()
        LoadFile()
    End Sub

    Private Sub RefreshResourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshResourceToolStripMenuItem.Click
        LoadFile()
    End Sub

    Private Sub ChandePortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChandePortToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class