Imports ClosedXML
Imports System.IO
Imports System.Xml.Serialization




Public Class Form2
    Dim settings As New SettingsData
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        settings.checkFullscreen = chkFullscreen.Checked
        settings.checkFilter = chkFilter.Checked
        Dim xs As New XmlSerializer(GetType(SettingsData))

        Using fs As New FileStream("Settings.xml", FileMode.Create)

            xs.Serialize(fs, settings)

        End Using
        MessageBox.Show("Attenzione: sto per riavviare l'applicativo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Me.Close()

        Application.Restart()
    End Sub


    Private Sub Form2_load()
        If File.Exists("Settings.xml") Then

            Dim xs As New XmlSerializer(GetType(SettingsData))

            Using fs As New FileStream("Settings.xml", FileMode.Open)

                Dim settings As SettingsData = CType(xs.Deserialize(fs), SettingsData)

                chkFullscreen.Checked = settings.checkFullscreen

                chkFilter.Checked = settings.checkFilter

            End Using
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class


Public Class SettingsData
    Public Property checkFullscreen As Boolean
    Public Property checkFilter As Boolean
End Class