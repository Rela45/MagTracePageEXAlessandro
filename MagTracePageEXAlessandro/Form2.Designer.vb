<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.chkFilter = New System.Windows.Forms.CheckBox()
        Me.chkFullscreen = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkFilter
        '
        Me.chkFilter.AutoSize = True
        Me.chkFilter.Location = New System.Drawing.Point(84, 36)
        Me.chkFilter.Name = "chkFilter"
        Me.chkFilter.Size = New System.Drawing.Size(79, 17)
        Me.chkFilter.TabIndex = 0
        Me.chkFilter.Text = "Abilita Filtro"
        Me.chkFilter.UseVisualStyleBackColor = True
        '
        'chkFullscreen
        '
        Me.chkFullscreen.AutoSize = True
        Me.chkFullscreen.Location = New System.Drawing.Point(188, 36)
        Me.chkFullscreen.Name = "chkFullscreen"
        Me.chkFullscreen.Size = New System.Drawing.Size(98, 17)
        Me.chkFullscreen.TabIndex = 1
        Me.chkFullscreen.Text = "Schermo Intero"
        Me.chkFullscreen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(67, 148)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Salva"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(205, 148)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Annulla"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 308)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkFullscreen)
        Me.Controls.Add(Me.chkFilter)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkFilter As CheckBox
    Friend WithEvents chkFullscreen As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
