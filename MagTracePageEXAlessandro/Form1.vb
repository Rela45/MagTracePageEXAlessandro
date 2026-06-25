Imports ClosedXML
Imports System.IO
Imports System.Xml.Serialization

Public Class Form1
    Dim articolo As New Anag_Articoli()
    Dim edit As Boolean = False
    Dim settings As New SettingsData
    Dim filtroAttivo As Boolean = False
    Dim formloaded As Boolean = False
    Dim filterUpdate As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("Settings.xml") Then
            Dim xs As New XmlSerializer(GetType(SettingsData))

            Using fs As New FileStream("Settings.xml", FileMode.Open)

                settings = CType(xs.Deserialize(fs), SettingsData)

            End Using

            If settings.checkFullscreen = True Then
                Me.WindowState = FormWindowState.Maximized
            End If
        End If
        lvwArticoli.Enabled = True
        grpDetails.Enabled = False
        RecoLoad()
#Region "caricamento CBO"
        'CARICAMENTO CBO
        Using db As New MagTraceEntities()

            Dim reparti = db.Anag_Reparti.ToList()
            reparti.Insert(0, New Anag_Reparti With {.KeyId = 0, .strDescrizione = ""})
            cboReparto.DataSource = reparti
            cboReparto.DisplayMember = "strDescrizione"
            cboReparto.ValueMember = "KeyId"
            cboFiltroReparto.DataSource = reparti
            cboFiltroReparto.DisplayMember = "strDescrizione"
            cboFiltroReparto.ValueMember = "KeyId"

            Dim categorie = db.Anag_Gm.ToList()
            categorie.Insert(0, New Anag_Gm With {.KeyId = 0, .strDescrizione = ""})
            cboCategoria.DataSource = categorie
            cboCategoria.DisplayMember = "strDescrizione"
            cboCategoria.ValueMember = "KeyId"
            cboFiltroCategoria.DataSource = categorie
            cboFiltroCategoria.DisplayMember = "strDescrizione"
            cboFiltroCategoria.ValueMember = "KeyId"

            Dim um = db.Anag_Um.ToList()
            um.Insert(0, New Anag_Um With {.KeyId = 0, .codeUm = ""})
            cboUm.DataSource = um
            cboUm.DisplayMember = "codeUm"
            cboUm.ValueMember = "KeyId"
            cboFiltroUm.DataSource = um
            cboFiltroUm.DisplayMember = "codeUm"
            cboFiltroUm.ValueMember = "KeyId"
        End Using
#End Region
        formloaded = True
    End Sub

    ''' <summary>
    ''' Serve per caricare i record della tabella anag_articoli nella listview
    ''' </summary>
    Private Sub RecoLoad()
        Using db As New MagTraceEntities()

            '    Dim records = db.Anag_Articoli.Where(Function(x) x.bitEliminato = False).OrderByDescending(Function(x) x.KeyId).Take(200).Select(Function(x) New With {
            '    .reparto = x.Anag_Reparti.strDescrizione,
            '    .um = x.Anag_Um.codeUm,
            '    .categoria = x.Anag_Gm.strDescrizione,
            '    .codice = x.strCodice,
            '    .descrizione = x.strDescrizione,
            '    .id = x.KeyId
            '})

            Dim records = db.Anag_Articoli.Where(Function(x) x.bitEliminato = False).Select(Function(x) New With {
                    .reparto = x.Anag_Reparti.strDescrizione,
                    .um = x.Anag_Um.codeUm,
                    .categoria = x.Anag_Gm.strDescrizione,
                    .codice = x.strCodice,
                    .descrizione = x.strDescrizione,
                    .id = x.KeyId,
                    .categoriaid = x.KeyIdAnag_Gm,
                    .repartoid = x.KeyIdAnag_Reparti,
                    .umid = x.KeyIdAnag_Um
                })
            If filtroAttivo = False Then
                For Each r In records.OrderByDescending(Function(x) x.id).Take(200).ToList()
                    Dim articoli As New ListViewItem(r.reparto)          'str descrizione della tabella reparto e str descrizione della tabella UM
                    articoli.SubItems.Add(r.categoria)
                    articoli.SubItems.Add(r.codice)
                    articoli.SubItems.Add(r.descrizione)
                    If Not r.um Is Nothing Then
                        articoli.SubItems.Add(r.um)
                    Else
                        articoli.SubItems.Add("NULL")
                    End If
                    articoli.Tag = r.id
                    lvwArticoli.Items.Add(articoli)
                Next
            Else
                If CInt(cboFiltroReparto.SelectedValue) > 0 Then
                    Dim reparto = CInt(cboFiltroReparto.SelectedValue)
                    records = records.Where(Function(x) x.repartoid = reparto)
                End If


                If tbxFiltroDescrizione.Text.Trim() <> "" Then

                    Dim desc = tbxFiltroDescrizione.Text.Trim()

                    records = records.Where(Function(x) x.descrizione.Contains(desc))

                End If

                If CInt(cboFiltroCategoria.SelectedValue) > 0 Then

                    Dim categoria = cboFiltroCategoria.SelectedValue.ToString()

                    records = records.Where(Function(x) x.categoriaid = categoria)

                End If

                If CInt(cboFiltroUm.SelectedValue) > 0 Then

                    Dim um = CInt(cboFiltroUm.SelectedValue)

                    records = records.Where(Function(x) x.umid = um)

                End If

                If tbxFiltroCodiceArticolo.Text.Trim() <> "" Then

                    Dim codice = tbxFiltroCodiceArticolo.Text.Trim()

                    records = records.Where(Function(x) x.codice.Contains(codice))

                End If
                'NON SI CARICA BENE LA LIST VIEW PER VIA DI QUESTO CONTROLLA 
                'Dim results = records.OrderByDescending(Function(x) x.id).Take(200).ToList()
                lvwArticoli.Items.Clear()

                For Each r In records.ToList()
                    Dim articoli As New ListViewItem(r.reparto)          'str descrizione della tabella reparto e str descrizione della tabella UM
                    articoli.SubItems.Add(r.categoria)
                    articoli.SubItems.Add(r.codice)
                    articoli.SubItems.Add(r.descrizione)
                    If Not r.um Is Nothing Then
                        articoli.SubItems.Add(r.um)
                    Else
                        articoli.SubItems.Add("NULL")
                    End If
                    articoli.Tag = r.id
                    lvwArticoli.Items.Add(articoli)
                Next
            End If

        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lvwArticoli.Enabled = False
        grpDetails.Enabled = True
    End Sub

    Private Sub ClearBoxes()
        tbxCodiceArticolo.Clear()
        tbxDescrizione.Clear()
        cboCategoria.SelectedIndex = 0
        cboUm.SelectedIndex = 0
        cboReparto.SelectedIndex = 0
        tbxFiltroCodiceArticolo.Clear()
        tbxFiltroDescrizione.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not edit = True Then
            Using db As New MagTraceEntities()

                If Not String.IsNullOrWhiteSpace(tbxCodiceArticolo.Text) Then
                    articolo.strCodice = tbxCodiceArticolo.Text.Trim()
                Else
                    MessageBox.Show("Codice obbligatorio")
                    Exit Sub
                End If

                If Not String.IsNullOrWhiteSpace(tbxDescrizione.Text) Then
                    articolo.strDescrizione = tbxDescrizione.Text.Trim()
                Else
                    MessageBox.Show("Descrizione obbligatoria")
                    Exit Sub
                End If

                If cboCategoria.SelectedIndex > 0 Then
                    articolo.KeyIdAnag_Gm = CInt(cboCategoria.SelectedValue)
                Else
                    MessageBox.Show("Categoria obbligatoria")
                    Exit Sub
                End If

                If cboUm.SelectedIndex > 0 Then
                    articolo.KeyIdAnag_Um = CInt(cboUm.SelectedValue)
                Else
                    MessageBox.Show("UM obbligatoria")
                    Exit Sub
                End If

                If cboReparto.SelectedIndex > 0 Then
                    articolo.KeyIdAnag_Reparti = CInt(cboReparto.SelectedValue)
                Else
                    MessageBox.Show("Reparto obbligatorio")
                    Exit Sub
                End If
                articolo.strCodiceStatistico = 2
                articolo.bitEliminato = 0
                articolo.bitVariato = 0
                Try
                    db.Anag_Articoli.Add(articolo)
                    db.SaveChanges()
                    lvwArticoli.Items.Clear()
                    RecoLoad()
                    ClearBoxes()
                    lvwArticoli.Enabled = True
                    grpDetails.Enabled = False
                Catch ex As System.Data.Entity.Validation.DbEntityValidationException

                    For Each eve In ex.EntityValidationErrors
                        For Each ve In eve.ValidationErrors
                            MessageBox.Show(ve.PropertyName & " - " & ve.ErrorMessage)
                        Next
                    Next

                End Try
            End Using
        Else
            Using db As New MagTraceEntities()
                Dim idArticolo As Integer = CInt(lvwArticoli.SelectedItems(0).Tag)
                articolo = db.Anag_Articoli.Find(idArticolo)

                If Not String.IsNullOrWhiteSpace(tbxCodiceArticolo.Text) Then
                    articolo.strCodice = tbxCodiceArticolo.Text.Trim()
                Else
                    MessageBox.Show("Codice obbligatorio")
                    Exit Sub
                End If

                If Not String.IsNullOrWhiteSpace(tbxDescrizione.Text) Then
                    articolo.strDescrizione = tbxDescrizione.Text.Trim()
                Else
                    MessageBox.Show("Descrizione obbligatoria")
                    Exit Sub
                End If
                'modificato questo parametro siccome la categoria non è obbligatoria da db
                If cboCategoria.SelectedValue >= 0 Then
                    articolo.KeyIdAnag_Gm = CInt(cboCategoria.SelectedValue)
                End If

                If cboUm.SelectedValue > 0 Then
                    articolo.KeyIdAnag_Um = CInt(cboUm.SelectedValue)
                Else
                    MessageBox.Show("UM obbligatoria")
                    Exit Sub
                End If

                If cboReparto.SelectedValue > 0 Then
                    articolo.KeyIdAnag_Reparti = CInt(cboReparto.SelectedValue)
                Else
                    MessageBox.Show("Reparto obbligatorio")
                    Exit Sub
                End If
                articolo.strCodiceStatistico = 2
                articolo.bitEliminato = 0
                articolo.bitVariato = 0
                db.SaveChanges()
                lvwArticoli.Items.Clear()
                RecoLoad()
                ClearBoxes()
                edit = False
                lvwArticoli.Enabled = True
                grpDetails.Enabled = False
            End Using
        End If
        ClearBoxes()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lvwArticoli.Enabled = True
        grpDetails.Enabled = False
        If edit = True Then
            edit = False
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lvwArticoli.SelectedItems.Count = 0 Then
            MessageBox.Show("Devi selezionare almeno un record della tabella")
        Else
            Dim idArticolo As Integer = CInt(lvwArticoli.SelectedItems(0).Tag)

            Using db As New MagTraceEntities()

                Dim articolo = db.Anag_Articoli.Find(idArticolo)

                If articolo IsNot Nothing Then
                    articolo.bitEliminato = True
                    db.SaveChanges()
                End If
            End Using
            lvwArticoli.Items.Clear()
            RecoLoad()
            ClearBoxes()
        End If

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If lvwArticoli.SelectedItems.Count = 0 Then
            MessageBox.Show("devi selezionare almeno un record della tabella")
        Else
            lvwArticoli.Enabled = False
            grpDetails.Enabled = True
            edit = True
        End If
    End Sub

    Private Sub lvwArticoli_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lvwArticoli.ItemSelectionChanged
        If lvwArticoli.SelectedItems.Count = 0 Then Exit Sub

        Dim idArticolo As Integer = CInt(lvwArticoli.SelectedItems(0).Tag)
        Using db As New MagTraceEntities()
            Dim selArticolo = db.Anag_Articoli.Include("Anag_Reparti").Include("Anag_Gm").Include("Anag_Um").FirstOrDefault(Function(x) x.KeyId = idArticolo)
            If selArticolo IsNot Nothing Then
                filterUpdate = True
                cboReparto.SelectedValue = selArticolo.KeyIdAnag_Reparti
                'qui ci sono dei valori null nella listview e sulle tabelle possono effettivamente esserlo quindi vado a valorizzare 0 la cbo in caso sia null
                If selArticolo.KeyIdAnag_Gm Is Nothing Then
                    cboCategoria.SelectedIndex = 0
                    cboFiltroCategoria.SelectedIndex = 0
                Else
                    cboCategoria.SelectedValue = selArticolo.KeyIdAnag_Gm
                    cboFiltroCategoria.SelectedValue = selArticolo.KeyIdAnag_Gm
                End If
                cboUm.SelectedValue = selArticolo.KeyIdAnag_Um
                tbxCodiceArticolo.Text = selArticolo.strCodice
                tbxDescrizione.Text = selArticolo.strDescrizione
                cboFiltroReparto.SelectedValue = selArticolo.KeyIdAnag_Reparti
                cboFiltroUm.SelectedValue = selArticolo.KeyIdAnag_Um
                tbxFiltroCodiceArticolo.Text = selArticolo.strCodice
                tbxFiltroDescrizione.Text = selArticolo.strDescrizione
                filterUpdate = False
            End If
        End Using
    End Sub

    Private Sub ImpostazioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpostazioniToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub



    'forse è da cancellare

    Private Sub AggiornaFiltro()
        Dim testo = tbxFiltroDescrizione.Text.Trim()
        Dim codice = tbxFiltroCodiceArticolo.Text.Trim()
        If testo.Length >= 3 OrElse
        codice.Length >= 3 OrElse
        cboFiltroCategoria.SelectedIndex > 0 OrElse
        cboFiltroReparto.SelectedIndex > 0 OrElse
        cboFiltroUm.SelectedIndex > 0 Then
            filtroAttivo = True
        Else
            filtroAttivo = False
            lvwArticoli.Items.Clear()
            RecoLoad()
        End If

    End Sub

    Private Sub tbxFiltroDescrizione_TextChanged(sender As Object, e As EventArgs) Handles tbxFiltroDescrizione.TextChanged
        If formloaded = False Then Exit Sub
        If filterUpdate Then Exit Sub
        AggiornaFiltro()
        If filtroAttivo = True Then
            RecoLoad()
        End If
    End Sub

    Private Sub cboFiltroCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroCategoria.SelectedIndexChanged
        If formloaded = False Then Exit Sub
        If filterUpdate Then Exit Sub
        AggiornaFiltro()
        If filtroAttivo = True Then
            RecoLoad()
        End If
    End Sub

    Private Sub cboFiltroReparto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroReparto.SelectedIndexChanged
        If filterUpdate Then Exit Sub
        If formloaded = False Then Exit Sub
        AggiornaFiltro()
        If filtroAttivo = True Then
            RecoLoad()
        End If
    End Sub

    Private Sub cboFiltroUm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroUm.SelectedIndexChanged
        If formloaded = False Then Exit Sub
        If filterUpdate Then Exit Sub
        AggiornaFiltro()
        If filtroAttivo = True Then
            RecoLoad()
        End If
    End Sub

    Private Sub tbxFiltroCodiceArticolo_TextChanged(sender As Object, e As EventArgs) Handles tbxFiltroCodiceArticolo.TextChanged
        If formloaded = False Then Exit Sub
        If filterUpdate Then Exit Sub
        AggiornaFiltro()
        If filtroAttivo = True Then
            RecoLoad()
        End If
    End Sub

    Private Sub btnFilterCancel_Click(sender As Object, e As EventArgs) Handles btnFilterCancel.Click
        ClearBoxes()
        cboFiltroCategoria.SelectedIndex = 0
        cboFiltroUm.SelectedIndex = 0
        cboFiltroReparto.SelectedIndex = 0
        filtroAttivo = False
    End Sub
End Class
