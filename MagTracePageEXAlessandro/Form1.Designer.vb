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
        Me.lvwArticoli = New System.Windows.Forms.ListView()
        Me.columnReparto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnCategoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnCodice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnDescrizione = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnUM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblDescrizione = New System.Windows.Forms.Label()
        Me.tbxDescrizione = New System.Windows.Forms.TextBox()
        Me.lblUnitOfMeasurement = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblReparto = New System.Windows.Forms.Label()
        Me.lblCodiceArticolo = New System.Windows.Forms.Label()
        Me.tbxCodiceArticolo = New System.Windows.Forms.TextBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.cboUm = New System.Windows.Forms.ComboBox()
        Me.cboReparto = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.File = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpDetails.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwArticoli
        '
        Me.lvwArticoli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwArticoli.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnReparto, Me.columnCategoria, Me.columnCodice, Me.columnDescrizione, Me.columnUM})
        Me.lvwArticoli.FullRowSelect = True
        Me.lvwArticoli.HideSelection = False
        Me.lvwArticoli.Location = New System.Drawing.Point(12, 34)
        Me.lvwArticoli.Name = "lvwArticoli"
        Me.lvwArticoli.Size = New System.Drawing.Size(868, 349)
        Me.lvwArticoli.TabIndex = 0
        Me.lvwArticoli.UseCompatibleStateImageBehavior = False
        Me.lvwArticoli.View = System.Windows.Forms.View.Details
        '
        'columnReparto
        '
        Me.columnReparto.Text = "Reparto"
        Me.columnReparto.Width = 108
        '
        'columnCategoria
        '
        Me.columnCategoria.Text = "Categoria"
        Me.columnCategoria.Width = 118
        '
        'columnCodice
        '
        Me.columnCodice.Text = "Codice"
        Me.columnCodice.Width = 93
        '
        'columnDescrizione
        '
        Me.columnDescrizione.Text = "Descrizione"
        Me.columnDescrizione.Width = 284
        '
        'columnUM
        '
        Me.columnUM.Text = "UM"
        Me.columnUM.Width = 106
        '
        'grpDetails
        '
        Me.grpDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDetails.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpDetails.Controls.Add(Me.btnCancel)
        Me.grpDetails.Controls.Add(Me.btnSave)
        Me.grpDetails.Controls.Add(Me.lblDescrizione)
        Me.grpDetails.Controls.Add(Me.tbxDescrizione)
        Me.grpDetails.Controls.Add(Me.lblUnitOfMeasurement)
        Me.grpDetails.Controls.Add(Me.lblCategoria)
        Me.grpDetails.Controls.Add(Me.lblReparto)
        Me.grpDetails.Controls.Add(Me.lblCodiceArticolo)
        Me.grpDetails.Controls.Add(Me.tbxCodiceArticolo)
        Me.grpDetails.Controls.Add(Me.cboCategoria)
        Me.grpDetails.Controls.Add(Me.cboUm)
        Me.grpDetails.Controls.Add(Me.cboReparto)
        Me.grpDetails.Location = New System.Drawing.Point(12, 408)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(940, 183)
        Me.grpDetails.TabIndex = 4
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Dettaglio Articolo"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(793, 136)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Annulla"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(683, 136)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Salva"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblDescrizione
        '
        Me.lblDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescrizione.AutoSize = True
        Me.lblDescrizione.Location = New System.Drawing.Point(181, 66)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(62, 13)
        Me.lblDescrizione.TabIndex = 9
        Me.lblDescrizione.Text = "Descrizione"
        '
        'tbxDescrizione
        '
        Me.tbxDescrizione.AcceptsTab = True
        Me.tbxDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxDescrizione.Location = New System.Drawing.Point(184, 82)
        Me.tbxDescrizione.Name = "tbxDescrizione"
        Me.tbxDescrizione.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbxDescrizione.Size = New System.Drawing.Size(345, 20)
        Me.tbxDescrizione.TabIndex = 8
        '
        'lblUnitOfMeasurement
        '
        Me.lblUnitOfMeasurement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUnitOfMeasurement.AutoSize = True
        Me.lblUnitOfMeasurement.Location = New System.Drawing.Point(6, 106)
        Me.lblUnitOfMeasurement.Name = "lblUnitOfMeasurement"
        Me.lblUnitOfMeasurement.Size = New System.Drawing.Size(76, 13)
        Me.lblUnitOfMeasurement.TabIndex = 7
        Me.lblUnitOfMeasurement.Text = "Unità di misura"
        '
        'lblCategoria
        '
        Me.lblCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(6, 65)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoria.TabIndex = 6
        Me.lblCategoria.Text = "Categoria"
        '
        'lblReparto
        '
        Me.lblReparto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblReparto.AutoSize = True
        Me.lblReparto.Location = New System.Drawing.Point(6, 25)
        Me.lblReparto.Name = "lblReparto"
        Me.lblReparto.Size = New System.Drawing.Size(45, 13)
        Me.lblReparto.TabIndex = 5
        Me.lblReparto.Text = "Reparto"
        '
        'lblCodiceArticolo
        '
        Me.lblCodiceArticolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodiceArticolo.AutoSize = True
        Me.lblCodiceArticolo.Location = New System.Drawing.Point(181, 25)
        Me.lblCodiceArticolo.Name = "lblCodiceArticolo"
        Me.lblCodiceArticolo.Size = New System.Drawing.Size(78, 13)
        Me.lblCodiceArticolo.TabIndex = 4
        Me.lblCodiceArticolo.Text = "Codice Articolo"
        '
        'tbxCodiceArticolo
        '
        Me.tbxCodiceArticolo.AcceptsTab = True
        Me.tbxCodiceArticolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxCodiceArticolo.Location = New System.Drawing.Point(184, 41)
        Me.tbxCodiceArticolo.Name = "tbxCodiceArticolo"
        Me.tbxCodiceArticolo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbxCodiceArticolo.Size = New System.Drawing.Size(345, 20)
        Me.tbxCodiceArticolo.TabIndex = 3
        '
        'cboCategoria
        '
        Me.cboCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(6, 81)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoria.TabIndex = 2
        '
        'cboUm
        '
        Me.cboUm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboUm.FormattingEnabled = True
        Me.cboUm.Location = New System.Drawing.Point(6, 122)
        Me.cboUm.Name = "cboUm"
        Me.cboUm.Size = New System.Drawing.Size(121, 21)
        Me.cboUm.TabIndex = 1
        '
        'cboReparto
        '
        Me.cboReparto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboReparto.FormattingEnabled = True
        Me.cboReparto.Location = New System.Drawing.Point(6, 40)
        Me.cboReparto.Name = "cboReparto"
        Me.cboReparto.Size = New System.Drawing.Size(121, 21)
        Me.cboReparto.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'File
        '
        Me.File.AccessibleName = "File"
        Me.File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpostazioniToolStripMenuItem})
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(37, 20)
        Me.File.Text = "File"
        Me.File.ToolTipText = "File"
        '
        'ImpostazioniToolStripMenuItem
        '
        Me.ImpostazioniToolStripMenuItem.Name = "ImpostazioniToolStripMenuItem"
        Me.ImpostazioniToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ImpostazioniToolStripMenuItem.Text = "Impostazioni"
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Image = Global.MagTracePageEXAlessandro.My.Resources.Resources.delete1
        Me.btnRemove.Location = New System.Drawing.Point(894, 177)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(58, 67)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Rimuovi"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModify.FlatAppearance.BorderSize = 0
        Me.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModify.Image = Global.MagTracePageEXAlessandro.My.Resources.Resources.edit
        Me.btnModify.Location = New System.Drawing.Point(894, 107)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(58, 67)
        Me.btnModify.TabIndex = 2
        Me.btnModify.Text = "Modifica"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = Global.MagTracePageEXAlessandro.My.Resources.Resources.add__1_1
        Me.btnAdd.Location = New System.Drawing.Point(894, 34)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 67)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Aggiunta"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1008, 617)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lvwArticoli)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwArticoli As ListView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents tbxCodiceArticolo As TextBox
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents cboUm As ComboBox
    Friend WithEvents cboReparto As ComboBox
    Friend WithEvents lblUnitOfMeasurement As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblReparto As Label
    Friend WithEvents lblCodiceArticolo As Label
    Friend WithEvents lblDescrizione As Label
    Friend WithEvents tbxDescrizione As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents columnReparto As ColumnHeader
    Friend WithEvents columnCategoria As ColumnHeader
    Friend WithEvents columnCodice As ColumnHeader
    Friend WithEvents columnDescrizione As ColumnHeader
    Friend WithEvents columnUM As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents File As ToolStripMenuItem
    Friend WithEvents ImpostazioniToolStripMenuItem As ToolStripMenuItem
End Class
