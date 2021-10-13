Imports System.IO
Public Class EmergencyForm
    Dim b As String = "C:\Училищен Звънец\T1ED.txt"
    Private Sub EmergencyForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As String = "C:\Училищен Звънец"
        If (Not System.IO.Directory.Exists(f)) Then
            System.IO.Directory.CreateDirectory(f)
        End If
        If Not File.Exists(b) Then
            Dim d As FileStream
            d = File.Create(b)
            d.Close()
        End If
        TextBox1.Text = File.ReadAllText(b)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Wave Файлове|*.wav"
            If ofd.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Избрана мелодия за авария: " + ofd.FileName, "Избор На Мелодия", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Моля, натиснете бутона Запази за запазване на извършените от вас промени.", "Запазване", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        File.Delete(b)
        My.Computer.FileSystem.WriteAllText(b, TextBox1.Text, True)
        MessageBox.Show("Промените са запазени!", "Запазено", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class