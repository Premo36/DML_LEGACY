<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lstMod = New System.Windows.Forms.ListBox()
        Me.cmdSU = New System.Windows.Forms.Button()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMod
        '
        Me.lstMod.FormattingEnabled = True
        Me.lstMod.Location = New System.Drawing.Point(12, 22)
        Me.lstMod.Name = "lstMod"
        Me.lstMod.Size = New System.Drawing.Size(301, 225)
        Me.lstMod.TabIndex = 0
        '
        'cmdSU
        '
        Me.cmdSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSU.Location = New System.Drawing.Point(319, 88)
        Me.cmdSU.Name = "cmdSU"
        Me.cmdSU.Size = New System.Drawing.Size(99, 37)
        Me.cmdSU.TabIndex = 1
        Me.cmdSU.Text = "UP"
        Me.cmdSU.UseVisualStyleBackColor = True
        '
        'cmdDown
        '
        Me.cmdDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDown.Location = New System.Drawing.Point(319, 131)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(99, 37)
        Me.cmdDown.TabIndex = 2
        Me.cmdDown.Text = "DOWN"
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(319, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 38)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "PLAY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdDown)
        Me.Controls.Add(Me.cmdSU)
        Me.Controls.Add(Me.lstMod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "DML - Mod Loading Order"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMod As ListBox
    Friend WithEvents cmdSU As Button
    Friend WithEvents cmdDown As Button
    Friend WithEvents Button2 As Button
End Class
