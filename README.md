# 📦 Gestione Articoli - WinForms CRUD

## 📌 Descrizione

Progetto Windows Forms per la gestione di articoli tramite operazioni CRUD (Create, Read, Update, Delete).

L'applicazione permette la gestione di un archivio articoli collegato a tabelle di riferimento (reparti, categorie e unità di misura), con interfaccia semplice basata su ListView e form di dettaglio.

---

## ⚙️ Funzionalità

### 📄 Visualizzazione dati
- Elenco articoli in una ListView
- Selezione elemento per visualizzazione dettagli
- Refresh automatico dei dati

### ➕ Inserimento
- Creazione nuovo articolo
- Validazione campi obbligatori

### ✏️ Modifica
- Aggiornamento dati articolo selezionato
- Binding dei dati nei controlli UI

### 🗑️ Eliminazione
- Eliminazione logica tramite flag (soft delete)
- Aggiornamento lista immediato

---

## 🧩 Interfaccia

- ListView per elenco articoli
- Form di dettaglio con:
  - Campi testuali (codice, descrizione)
  - ComboBox per selezioni riferite
- Pulsanti operativi:
  - Nuovo
  - Modifica
  - Salva
  - Elimina
  - Annulla

---

## 🗄️ Architettura dati

Il progetto utilizza Entity Framework per la gestione dei dati.

Le entità principali includono:
- Articoli
- Tabelle di classificazione (reparti / categorie / unità di misura)

Le relazioni sono gestite tramite chiavi esterne.

---

## 🔄 Flusso applicativo

1. Caricamento elenco articoli
2. Selezione elemento dalla lista
3. Visualizzazione dettagli nel form
4. Eventuale modifica o inserimento
5. Salvataggio su database
6. Aggiornamento interfaccia

---

## ⚠️ Note tecniche

- Utilizzo Entity Framework per accesso dati
- Binding manuale delle ComboBox
- Gestione ID tramite SelectedValue
- Soft delete degli elementi

---

## 🚀 Miglioramenti futuri

- Validazione input avanzata
- Sistema di ricerca e filtri
- Logging operazioni

---

## 🔐 Sicurezza / Privacy

Il progetto è stato pubblicato con dati generici o anonimizzati per evitare esposizione di informazioni sensibili relative a database o ambiente di sviluppo.

---

## 👨‍💻 Autore

Progetto sviluppato a scopo didattico per la gestione di anagrafiche tramite Windows Forms.