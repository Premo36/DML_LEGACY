Public Class Form3
    Dim PercorsiMod() As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StartGame()
    End Sub

    Sub StartGame()
        Dim PMod As String = ""
        For i As Integer = 0 To lstMod.Items.Count - 1
            Dim Sav As Byte
            For D As Integer = 0 To PercorsiMod.Length - 1
                If lstMod.Items(i).ToString() = IO.Path.GetFileName(PercorsiMod(D)) Then
                    Sav = D
                End If
            Next
            PMod = PMod & Chr(34) & PercorsiMod(Sav) & Chr(34) & " "
        Next

        Dim l As New ProcessStartInfo
        l.FileName = Form1.EXEpaths
        l.Arguments = "-IWAD " & Chr(34) & Form1.IWADpaths(Form1.cboxIWAD.SelectedIndex) & Chr(34) & " -file " & PMod & Form1.AP
        Dim proc As Process = Process.Start(l)
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PercorsiMod = Form1.ModPaths
        For i As Integer = 0 To Form1.lstMod.SelectedItems.Count - 1
            lstMod.Items.Add(Form1.lstMod.SelectedItems(i))
        Next
        If lstMod.Items.Count < 2 Then
            StartGame()
            Me.Close()
        Else
            lstMod.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmdSU_Click(sender As Object, e As EventArgs) Handles cmdSU.Click

        Dim ind As Byte = lstMod.SelectedIndex
            If ind > 0 Then
                Dim A As Object = lstMod.Items(ind)
                Dim AA As String = PercorsiMod(ind)

                lstMod.Items(ind) = lstMod.Items(ind - 1)
                PercorsiMod(ind) = PercorsiMod(ind - 1)

                lstMod.Items(ind - 1) = A
                PercorsiMod(ind - 1) = AA

                lstMod.SelectedIndex = ind - 1
            Else
                Beep()
            End If




    End Sub

    Private Sub cmdDown_Click(sender As Object, e As EventArgs) Handles cmdDown.Click
        Dim ind As Byte = lstMod.SelectedIndex
        If ind < lstMod.Items.Count - 1 Then
            Dim A As Object = lstMod.Items(ind)
            Dim AA As String = PercorsiMod(ind)

            lstMod.Items(ind) = lstMod.Items(ind + 1)
            PercorsiMod(ind) = PercorsiMod(ind + 1)

            lstMod.Items(ind + 1) = A
            PercorsiMod(ind + 1) = AA

            lstMod.SelectedIndex = ind + 1
        Else
            Beep()
        End If
    End Sub
End Class