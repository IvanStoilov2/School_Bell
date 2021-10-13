Imports System.IO
Public Class HomeScreenForm
    'HomeScreenForm Data Files Locations:
    Dim t1hfd As String = "C:\ProgramData\Училищен Звънец System Data\T1HFD.txt"
    Dim t2hfd As String = "C:\ProgramData\Училищен Звънец System Data\T2HFD.txt"

    'ScheduleForm Data Files Locations:
    Dim t111sfd As String = "C:\ProgramData\Училищен Звънец System Data\T111SFD.txt"
    Dim t112sfd As String = "C:\ProgramData\Училищен Звънец System Data\T112SFD.txt"
    Dim t121sfd As String = "C:\ProgramData\Училищен Звънец System Data\T121SFD.txt"
    Dim t122sfd As String = "C:\ProgramData\Училищен Звънец System Data\T122SFD.txt"
    Dim t131sfd As String = "C:\ProgramData\Училищен Звънец System Data\T131SFD.txt"
    Dim t132sfd As String = "C:\ProgramData\Училищен Звънец System Data\T132SFD.txt"
    Dim t141sfd As String = "C:\ProgramData\Училищен Звънец System Data\T141SFD.txt"
    Dim t142sfd As String = "C:\ProgramData\Училищен Звънец System Data\T142SFD.txt"
    Dim t151sfd As String = "C:\ProgramData\Училищен Звънец System Data\T151SFD.txt"
    Dim t152sfd As String = "C:\ProgramData\Училищен Звънец System Data\T152SFD.txt"
    Dim t161sfd As String = "C:\ProgramData\Училищен Звънец System Data\T161SFD.txt"
    Dim t162sfd As String = "C:\ProgramData\Училищен Звънец System Data\T162SFD.txt"
    Dim t171sfd As String = "C:\ProgramData\Училищен Звънец System Data\T171SFD.txt"
    Dim t172sfd As String = "C:\ProgramData\Училищен Звънец System Data\T172SFD.txt"
    Dim t181sfd As String = "C:\ProgramData\Училищен Звънец System Data\T181SFD.txt"
    Dim t182sfd As String = "C:\ProgramData\Училищен Звънец System Data\T182SFD.txt"
    Dim t211sfd As String = "C:\ProgramData\Училищен Звънец System Data\T211SFD.txt"
    Dim t212sfd As String = "C:\ProgramData\Училищен Звънец System Data\T212SFD.txt"
    Dim t221sfd As String = "C:\ProgramData\Училищен Звънец System Data\T221SFD.txt"
    Dim t222sfd As String = "C:\ProgramData\Училищен Звънец System Data\T222SFD.txt"
    Dim t231sfd As String = "C:\ProgramData\Училищен Звънец System Data\T231SFD.txt"
    Dim t232sfd As String = "C:\ProgramData\Училищен Звънец System Data\T232SFD.txt"
    Dim t241sfd As String = "C:\ProgramData\Училищен Звънец System Data\T241SFD.txt"
    Dim t242sfd As String = "C:\ProgramData\Училищен Звънец System Data\T242SFD.txt"
    Dim t251sfd As String = "C:\ProgramData\Училищен Звънец System Data\T251SFD.txt"
    Dim t252sfd As String = "C:\ProgramData\Училищен Звънец System Data\T252SFD.txt"
    Dim t261sfd As String = "C:\ProgramData\Училищен Звънец System Data\T261SFD.txt"
    Dim t262sfd As String = "C:\ProgramData\Училищен Звънец System Data\T262SFD.txt"
    Dim t271sfd As String = "C:\ProgramData\Училищен Звънец System Data\T271SFD.txt"
    Dim t272sfd As String = "C:\ProgramData\Училищен Звънец System Data\T272SFD.txt"
    Dim t281sfd As String = "C:\ProgramData\Училищен Звънец System Data\T281SFD.txt"
    Dim t282sfd As String = "C:\ProgramData\Училищен Звънец System Data\T282SFD.txt"
    Dim t311sfd As String = "C:\ProgramData\Училищен Звънец System Data\T311SFD.txt"
    Dim t312sfd As String = "C:\ProgramData\Училищен Звънец System Data\T312SFD.txt"
    Dim t321sfd As String = "C:\ProgramData\Училищен Звънец System Data\T321SFD.txt"
    Dim t322sfd As String = "C:\ProgramData\Училищен Звънец System Data\T322SFD.txt"
    Dim t331sfd As String = "C:\ProgramData\Училищен Звънец System Data\T331SFD.txt"
    Dim t332sfd As String = "C:\ProgramData\Училищен Звънец System Data\T332SFD.txt"
    Dim t341sfd As String = "C:\ProgramData\Училищен Звънец System Data\T341SFD.txt"
    Dim t342sfd As String = "C:\ProgramData\Училищен Звънец System Data\T342SFD.txt"
    Dim t351sfd As String = "C:\ProgramData\Училищен Звънец System Data\T351SFD.txt"
    Dim t352sfd As String = "C:\ProgramData\Училищен Звънец System Data\T352SFD.txt"
    Dim t361sfd As String = "C:\ProgramData\Училищен Звънец System Data\T361SFD.txt"
    Dim t362sfd As String = "C:\ProgramData\Училищен Звънец System Data\T362SFD.txt"
    Dim t371sfd As String = "C:\ProgramData\Училищен Звънец System Data\T371SFD.txt"
    Dim t372sfd As String = "C:\ProgramData\Училищен Звънец System Data\T372SFD.txt"
    Dim t381sfd As String = "C:\ProgramData\Училищен Звънец System Data\T381SFD.txt"
    Dim t382sfd As String = "C:\ProgramData\Училищен Звънец System Data\T382SFD.txt"
    Dim t411sfd As String = "C:\ProgramData\Училищен Звънец System Data\T411SFD.txt"
    Dim t412sfd As String = "C:\ProgramData\Училищен Звънец System Data\T412SFD.txt"
    Dim t421sfd As String = "C:\ProgramData\Училищен Звънец System Data\T421SFD.txt"
    Dim t422sfd As String = "C:\ProgramData\Училищен Звънец System Data\T422SFD.txt"
    Dim t431sfd As String = "C:\ProgramData\Училищен Звънец System Data\T431SFD.txt"
    Dim t432sfd As String = "C:\ProgramData\Училищен Звънец System Data\T432SFD.txt"
    Dim t441sfd As String = "C:\ProgramData\Училищен Звънец System Data\T441SFD.txt"
    Dim t442sfd As String = "C:\ProgramData\Училищен Звънец System Data\T442SFD.txt"
    Dim t451sfd As String = "C:\ProgramData\Училищен Звънец System Data\T451SFD.txt"
    Dim t452sfd As String = "C:\ProgramData\Училищен Звънец System Data\T452SFD.txt"
    Dim t461sfd As String = "C:\ProgramData\Училищен Звънец System Data\T461SFD.txt"
    Dim t462sfd As String = "C:\ProgramData\Училищен Звънец System Data\T462SFD.txt"
    Dim t471sfd As String = "C:\ProgramData\Училищен Звънец System Data\T471SFD.txt"
    Dim t472sfd As String = "C:\ProgramData\Училищен Звънец System Data\T472SFD.txt"
    Dim t481sfd As String = "C:\ProgramData\Училищен Звънец System Data\T481SFD.txt"
    Dim t482sfd As String = "C:\ProgramData\Училищен Звънец System Data\T482SFD.txt"
    Dim t511sfd As String = "C:\ProgramData\Училищен Звънец System Data\T511SFD.txt"
    Dim t512sfd As String = "C:\ProgramData\Училищен Звънец System Data\T512SFD.txt"
    Dim t521sfd As String = "C:\ProgramData\Училищен Звънец System Data\T521SFD.txt"
    Dim t522sfd As String = "C:\ProgramData\Училищен Звънец System Data\T522SFD.txt"
    Dim t531sfd As String = "C:\ProgramData\Училищен Звънец System Data\T531SFD.txt"
    Dim t532sfd As String = "C:\ProgramData\Училищен Звънец System Data\T532SFD.txt"
    Dim t541sfd As String = "C:\ProgramData\Училищен Звънец System Data\T541SFD.txt"
    Dim t542sfd As String = "C:\ProgramData\Училищен Звънец System Data\T542SFD.txt"
    Dim t551sfd As String = "C:\ProgramData\Училищен Звънец System Data\T551SFD.txt"
    Dim t552sfd As String = "C:\ProgramData\Училищен Звънец System Data\T552SFD.txt"
    Dim t561sfd As String = "C:\ProgramData\Училищен Звънец System Data\T561SFD.txt"
    Dim t562sfd As String = "C:\ProgramData\Училищен Звънец System Data\T562SFD.txt"
    Dim t571sfd As String = "C:\ProgramData\Училищен Звънец System Data\T571SFD.txt"
    Dim t572sfd As String = "C:\ProgramData\Училищен Звънец System Data\T572SFD.txt"
    Dim t581sfd As String = "C:\ProgramData\Училищен Звънец System Data\T581SFD.txt"
    Dim t582sfd As String = "C:\ProgramData\Училищен Звънец System Data\T582SFD.txt"


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim CurrentTime As String, SplitTime As DateTime, CurrentDate As Date
        CurrentDate = Format(Now(), "short date")
        Label4.Text = CurrentDate
        Label1.Text = TimeOfDay
        CurrentTime = TimeOfDay
        SplitTime = Convert.ToDateTime(CurrentTime)
        If (CurrentDate.DayOfWeek = DayOfWeek.Monday) Then
            If CurrentTime = File.ReadAllText(t111sfd).ToString + ":00" Then
                Dim SAPI
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.Speak(TextBox1.Text)
            End If
            If CurrentTime = File.ReadAllText(t112sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t121sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t122sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t131sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t132sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t141sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t142sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t151sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t152sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t161sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t162sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t171sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t172sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t181sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t182sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
        End If
        If (CurrentDate.DayOfWeek = DayOfWeek.Tuesday) Then
            If CurrentTime = File.ReadAllText(t211sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t212sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t221sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t222sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t231sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t232sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t241sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t242sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t251sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t252sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t261sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t262sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t271sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t272sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t281sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t282sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
        End If
        If (CurrentDate.DayOfWeek = DayOfWeek.Wednesday) Then
            If CurrentTime = File.ReadAllText(t311sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t312sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t321sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t322sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t331sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t332sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t341sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t342sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t351sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t352sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t361sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t362sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t371sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t372sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t381sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t382sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
        End If
        If (CurrentDate.DayOfWeek = DayOfWeek.Thursday) Then
            If CurrentTime = File.ReadAllText(t411sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t412sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t421sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t422sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t431sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t432sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t441sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t442sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t451sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t452sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t461sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t462sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t471sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t472sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t481sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t482sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
        End If
        If (CurrentDate.DayOfWeek = DayOfWeek.Friday) Then
            If CurrentTime = File.ReadAllText(t511sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t512sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t521sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t522sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t531sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t532sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t541sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t542sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t551sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t552sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t561sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t562sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t571sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t572sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t581sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox1.Text, AudioPlayMode.Background)
            End If
            If CurrentTime = File.ReadAllText(t582sfd).ToString + ":00" Then
                My.Computer.Audio.Play(TextBox2.Text, AudioPlayMode.Background)
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Wave Файлове|*.wav"
            If ofd.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Избрана мелодия за начало на часа: " + ofd.FileName, "Избор На Мелодия", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Моля, натиснете бутона Запази за запазване на извършените от вас промени.", "Запазване", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Wave Файлове|*.wav"
            If ofd.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Избрана мелодия за край на часа: " + ofd.FileName, "Избор На Мелодия", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Моля, натиснете бутона Запази за запазване на извършените от вас промени.", "Запазване", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox2.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As String = "C:\ProgramData\Училищен Звънец System Data"
        If (Not System.IO.Directory.Exists(f)) Then
            System.IO.Directory.CreateDirectory(f)
        End If
        If Not File.Exists(t1hfd) Then
            Dim d As FileStream
            d = File.Create(t1hfd)
            d.Close()
        End If
        If Not File.Exists(t2hfd) Then
            Dim d As FileStream
            d = File.Create(t2hfd)
            d.Close()
        End If
        If Not File.Exists(t111sfd) Then
            Dim d As FileStream
            d = File.Create(t111sfd)
            d.Close()
        End If
        If Not File.Exists(t112sfd) Then
            Dim d As FileStream
            d = File.Create(t112sfd)
            d.Close()
        End If
        If Not File.Exists(t121sfd) Then
            Dim d As FileStream
            d = File.Create(t121sfd)
            d.Close()
        End If
        If Not File.Exists(t122sfd) Then
            Dim d As FileStream
            d = File.Create(t122sfd)
            d.Close()
        End If
        If Not File.Exists(t131sfd) Then
            Dim d As FileStream
            d = File.Create(t131sfd)
            d.Close()
        End If
        If Not File.Exists(t132sfd) Then
            Dim d As FileStream
            d = File.Create(t132sfd)
            d.Close()
        End If
        If Not File.Exists(t141sfd) Then
            Dim d As FileStream
            d = File.Create(t141sfd)
            d.Close()
        End If
        If Not File.Exists(t142sfd) Then
            Dim d As FileStream
            d = File.Create(t142sfd)
            d.Close()
        End If
        If Not File.Exists(t151sfd) Then
            Dim d As FileStream
            d = File.Create(t151sfd)
            d.Close()
        End If
        If Not File.Exists(t152sfd) Then
            Dim d As FileStream
            d = File.Create(t152sfd)
            d.Close()
        End If
        If Not File.Exists(t161sfd) Then
            Dim d As FileStream
            d = File.Create(t161sfd)
            d.Close()
        End If
        If Not File.Exists(t162sfd) Then
            Dim d As FileStream
            d = File.Create(t162sfd)
            d.Close()
        End If
        If Not File.Exists(t171sfd) Then
            Dim d As FileStream
            d = File.Create(t171sfd)
            d.Close()
        End If
        If Not File.Exists(t172sfd) Then
            Dim d As FileStream
            d = File.Create(t172sfd)
            d.Close()
        End If
        If Not File.Exists(t181sfd) Then
            Dim d As FileStream
            d = File.Create(t181sfd)
            d.Close()
        End If
        If Not File.Exists(t182sfd) Then
            Dim d As FileStream
            d = File.Create(t182sfd)
            d.Close()
        End If
        If Not File.Exists(t211sfd) Then
            Dim d As FileStream
            d = File.Create(t211sfd)
            d.Close()
        End If
        If Not File.Exists(t212sfd) Then
            Dim d As FileStream
            d = File.Create(t212sfd)
            d.Close()
        End If
        If Not File.Exists(t221sfd) Then
            Dim d As FileStream
            d = File.Create(t221sfd)
            d.Close()
        End If
        If Not File.Exists(t222sfd) Then
            Dim d As FileStream
            d = File.Create(t222sfd)
            d.Close()
        End If
        If Not File.Exists(t231sfd) Then
            Dim d As FileStream
            d = File.Create(t231sfd)
            d.Close()
        End If
        If Not File.Exists(t232sfd) Then
            Dim d As FileStream
            d = File.Create(t232sfd)
            d.Close()
        End If
        If Not File.Exists(t241sfd) Then
            Dim d As FileStream
            d = File.Create(t241sfd)
            d.Close()
        End If
        If Not File.Exists(t242sfd) Then
            Dim d As FileStream
            d = File.Create(t242sfd)
            d.Close()
        End If
        If Not File.Exists(t251sfd) Then
            Dim d As FileStream
            d = File.Create(t251sfd)
            d.Close()
        End If
        If Not File.Exists(t252sfd) Then
            Dim d As FileStream
            d = File.Create(t252sfd)
            d.Close()
        End If
        If Not File.Exists(t261sfd) Then
            Dim d As FileStream
            d = File.Create(t261sfd)
            d.Close()
        End If
        If Not File.Exists(t262sfd) Then
            Dim d As FileStream
            d = File.Create(t262sfd)
            d.Close()
        End If
        If Not File.Exists(t271sfd) Then
            Dim d As FileStream
            d = File.Create(t271sfd)
            d.Close()
        End If
        If Not File.Exists(t272sfd) Then
            Dim d As FileStream
            d = File.Create(t272sfd)
            d.Close()
        End If
        If Not File.Exists(t281sfd) Then
            Dim d As FileStream
            d = File.Create(t281sfd)
            d.Close()
        End If
        If Not File.Exists(t282sfd) Then
            Dim d As FileStream
            d = File.Create(t282sfd)
            d.Close()
        End If
        If Not File.Exists(t311sfd) Then
            Dim d As FileStream
            d = File.Create(t311sfd)
            d.Close()
        End If
        If Not File.Exists(t312sfd) Then
            Dim d As FileStream
            d = File.Create(t312sfd)
            d.Close()
        End If
        If Not File.Exists(t321sfd) Then
            Dim d As FileStream
            d = File.Create(t321sfd)
            d.Close()
        End If

        If Not File.Exists(t322sfd) Then
            Dim d As FileStream
            d = File.Create(t322sfd)
            d.Close()
        End If
        If Not File.Exists(t331sfd) Then
            Dim d As FileStream
            d = File.Create(t331sfd)
            d.Close()
        End If
        If Not File.Exists(t332sfd) Then
            Dim d As FileStream
            d = File.Create(t332sfd)
            d.Close()
        End If
        If Not File.Exists(t341sfd) Then
            Dim d As FileStream
            d = File.Create(t341sfd)
            d.Close()
        End If
        If Not File.Exists(t342sfd) Then
            Dim d As FileStream
            d = File.Create(t342sfd)
            d.Close()
        End If
        If Not File.Exists(t351sfd) Then
            Dim d As FileStream
            d = File.Create(t351sfd)
            d.Close()
        End If
        If Not File.Exists(t352sfd) Then
            Dim d As FileStream
            d = File.Create(t352sfd)
            d.Close()
        End If
        If Not File.Exists(t361sfd) Then
            Dim d As FileStream
            d = File.Create(t361sfd)
            d.Close()
        End If
        If Not File.Exists(t362sfd) Then
            Dim d As FileStream
            d = File.Create(t362sfd)
            d.Close()
        End If
        If Not File.Exists(t371sfd) Then
            Dim d As FileStream
            d = File.Create(t371sfd)
            d.Close()
        End If
        If Not File.Exists(t372sfd) Then
            Dim d As FileStream
            d = File.Create(t372sfd)
            d.Close()
        End If
        If Not File.Exists(t381sfd) Then
            Dim d As FileStream
            d = File.Create(t381sfd)
            d.Close()
        End If
        If Not File.Exists(t382sfd) Then
            Dim d As FileStream
            d = File.Create(t382sfd)
            d.Close()
        End If
        If Not File.Exists(t411sfd) Then
            Dim d As FileStream
            d = File.Create(t411sfd)
            d.Close()
        End If
        If Not File.Exists(t412sfd) Then
            Dim d As FileStream
            d = File.Create(t412sfd)
            d.Close()
        End If
        If Not File.Exists(t421sfd) Then
            Dim d As FileStream
            d = File.Create(t421sfd)
            d.Close()
        End If
        If Not File.Exists(t421sfd) Then
            Dim d As FileStream
            d = File.Create(t421sfd)
            d.Close()
        End If
        If Not File.Exists(t422sfd) Then
            Dim d As FileStream
            d = File.Create(t422sfd)
            d.Close()
        End If
        If Not File.Exists(t431sfd) Then
            Dim d As FileStream
            d = File.Create(t431sfd)
            d.Close()
        End If
        If Not File.Exists(t432sfd) Then
            Dim d As FileStream
            d = File.Create(t432sfd)
            d.Close()
        End If
        If Not File.Exists(t441sfd) Then
            Dim d As FileStream
            d = File.Create(t441sfd)
            d.Close()
        End If
        If Not File.Exists(t442sfd) Then
            Dim d As FileStream
            d = File.Create(t442sfd)
            d.Close()
        End If
        If Not File.Exists(t451sfd) Then
            Dim d As FileStream
            d = File.Create(t451sfd)
            d.Close()
        End If
        If Not File.Exists(t452sfd) Then
            Dim d As FileStream
            d = File.Create(t452sfd)
            d.Close()
        End If
        If Not File.Exists(t461sfd) Then
            Dim d As FileStream
            d = File.Create(t461sfd)
            d.Close()
        End If
        If Not File.Exists(t462sfd) Then
            Dim d As FileStream
            d = File.Create(t462sfd)
            d.Close()
        End If
        If Not File.Exists(t471sfd) Then
            Dim d As FileStream
            d = File.Create(t471sfd)
            d.Close()
        End If
        If Not File.Exists(t472sfd) Then
            Dim d As FileStream
            d = File.Create(t472sfd)
            d.Close()
        End If
        If Not File.Exists(t481sfd) Then
            Dim d As FileStream
            d = File.Create(t481sfd)
            d.Close()
        End If
        If Not File.Exists(t482sfd) Then
            Dim d As FileStream
            d = File.Create(t482sfd)
            d.Close()
        End If
        If Not File.Exists(t511sfd) Then
            Dim d As FileStream
            d = File.Create(t511sfd)
            d.Close()
        End If
        If Not File.Exists(t512sfd) Then
            Dim d As FileStream
            d = File.Create(t512sfd)
            d.Close()
        End If
        If Not File.Exists(t521sfd) Then
            Dim d As FileStream
            d = File.Create(t521sfd)
            d.Close()
        End If
        If Not File.Exists(t522sfd) Then
            Dim d As FileStream
            d = File.Create(t522sfd)
            d.Close()
        End If
        If Not File.Exists(t531sfd) Then
            Dim d As FileStream
            d = File.Create(t531sfd)
            d.Close()
        End If
        If Not File.Exists(t532sfd) Then
            Dim d As FileStream
            d = File.Create(t532sfd)
            d.Close()
        End If
        If Not File.Exists(t541sfd) Then
            Dim d As FileStream
            d = File.Create(t541sfd)
            d.Close()
        End If
        If Not File.Exists(t542sfd) Then
            Dim d As FileStream
            d = File.Create(t542sfd)
            d.Close()
        End If
        If Not File.Exists(t551sfd) Then
            Dim d As FileStream
            d = File.Create(t551sfd)
            d.Close()
        End If
        If Not File.Exists(t552sfd) Then
            Dim d As FileStream
            d = File.Create(t552sfd)
            d.Close()
        End If
        If Not File.Exists(t561sfd) Then
            Dim d As FileStream
            d = File.Create(t561sfd)
            d.Close()
        End If
        If Not File.Exists(t562sfd) Then
            Dim d As FileStream
            d = File.Create(t562sfd)
            d.Close()
        End If
        If Not File.Exists(t571sfd) Then
            Dim d As FileStream
            d = File.Create(t571sfd)
            d.Close()
        End If
        If Not File.Exists(t572sfd) Then
            Dim d As FileStream
            d = File.Create(t572sfd)
            d.Close()
        End If
        If Not File.Exists(t581sfd) Then
            Dim d As FileStream
            d = File.Create(t581sfd)
            d.Close()
        End If
        If Not File.Exists(t582sfd) Then
            Dim d As FileStream
            d = File.Create(t582sfd)
            d.Close()
        End If

        TextBox1.Text = File.ReadAllText(t1hfd)
        TextBox2.Text = File.ReadAllText(t2hfd)

        ScheduleForm.TextBox111.Text = File.ReadAllText(t111sfd)
        ScheduleForm.TextBox112.Text = File.ReadAllText(t112sfd)
        ScheduleForm.TextBox121.Text = File.ReadAllText(t121sfd)
        ScheduleForm.TextBox122.Text = File.ReadAllText(t122sfd)
        ScheduleForm.TextBox131.Text = File.ReadAllText(t131sfd)
        ScheduleForm.TextBox132.Text = File.ReadAllText(t132sfd)
        ScheduleForm.TextBox141.Text = File.ReadAllText(t141sfd)
        ScheduleForm.TextBox142.Text = File.ReadAllText(t142sfd)
        ScheduleForm.TextBox151.Text = File.ReadAllText(t151sfd)
        ScheduleForm.TextBox152.Text = File.ReadAllText(t152sfd)
        ScheduleForm.TextBox161.Text = File.ReadAllText(t161sfd)
        ScheduleForm.TextBox162.Text = File.ReadAllText(t162sfd)
        ScheduleForm.TextBox171.Text = File.ReadAllText(t171sfd)
        ScheduleForm.TextBox172.Text = File.ReadAllText(t172sfd)
        ScheduleForm.TextBox181.Text = File.ReadAllText(t181sfd)
        ScheduleForm.TextBox182.Text = File.ReadAllText(t182sfd)
        ScheduleForm.TextBox211.Text = File.ReadAllText(t211sfd)
        ScheduleForm.TextBox212.Text = File.ReadAllText(t212sfd)
        ScheduleForm.TextBox221.Text = File.ReadAllText(t221sfd)
        ScheduleForm.TextBox222.Text = File.ReadAllText(t222sfd)
        ScheduleForm.TextBox231.Text = File.ReadAllText(t231sfd)
        ScheduleForm.TextBox232.Text = File.ReadAllText(t232sfd)
        ScheduleForm.TextBox241.Text = File.ReadAllText(t241sfd)
        ScheduleForm.TextBox242.Text = File.ReadAllText(t242sfd)
        ScheduleForm.TextBox251.Text = File.ReadAllText(t251sfd)
        ScheduleForm.TextBox252.Text = File.ReadAllText(t252sfd)
        ScheduleForm.TextBox261.Text = File.ReadAllText(t261sfd)
        ScheduleForm.TextBox262.Text = File.ReadAllText(t262sfd)
        ScheduleForm.TextBox271.Text = File.ReadAllText(t271sfd)
        ScheduleForm.TextBox272.Text = File.ReadAllText(t272sfd)
        ScheduleForm.TextBox281.Text = File.ReadAllText(t281sfd)
        ScheduleForm.TextBox282.Text = File.ReadAllText(t282sfd)
        ScheduleForm.TextBox311.Text = File.ReadAllText(t311sfd)
        ScheduleForm.TextBox312.Text = File.ReadAllText(t312sfd)
        ScheduleForm.TextBox321.Text = File.ReadAllText(t321sfd)
        ScheduleForm.TextBox322.Text = File.ReadAllText(t322sfd)
        ScheduleForm.TextBox331.Text = File.ReadAllText(t331sfd)
        ScheduleForm.TextBox332.Text = File.ReadAllText(t332sfd)
        ScheduleForm.TextBox341.Text = File.ReadAllText(t341sfd)
        ScheduleForm.TextBox342.Text = File.ReadAllText(t342sfd)
        ScheduleForm.TextBox351.Text = File.ReadAllText(t351sfd)
        ScheduleForm.TextBox352.Text = File.ReadAllText(t352sfd)
        ScheduleForm.TextBox361.Text = File.ReadAllText(t361sfd)
        ScheduleForm.TextBox362.Text = File.ReadAllText(t362sfd)
        ScheduleForm.TextBox371.Text = File.ReadAllText(t371sfd)
        ScheduleForm.TextBox372.Text = File.ReadAllText(t372sfd)
        ScheduleForm.TextBox381.Text = File.ReadAllText(t381sfd)
        ScheduleForm.TextBox382.Text = File.ReadAllText(t382sfd)
        ScheduleForm.TextBox411.Text = File.ReadAllText(t411sfd)
        ScheduleForm.TextBox412.Text = File.ReadAllText(t412sfd)
        ScheduleForm.TextBox421.Text = File.ReadAllText(t421sfd)
        ScheduleForm.TextBox422.Text = File.ReadAllText(t422sfd)
        ScheduleForm.TextBox431.Text = File.ReadAllText(t431sfd)
        ScheduleForm.TextBox432.Text = File.ReadAllText(t432sfd)
        ScheduleForm.TextBox441.Text = File.ReadAllText(t441sfd)
        ScheduleForm.TextBox442.Text = File.ReadAllText(t442sfd)
        ScheduleForm.TextBox451.Text = File.ReadAllText(t451sfd)
        ScheduleForm.TextBox452.Text = File.ReadAllText(t452sfd)
        ScheduleForm.TextBox461.Text = File.ReadAllText(t461sfd)
        ScheduleForm.TextBox462.Text = File.ReadAllText(t462sfd)
        ScheduleForm.TextBox471.Text = File.ReadAllText(t471sfd)
        ScheduleForm.TextBox472.Text = File.ReadAllText(t472sfd)
        ScheduleForm.TextBox481.Text = File.ReadAllText(t481sfd)
        ScheduleForm.TextBox482.Text = File.ReadAllText(t482sfd)
        ScheduleForm.TextBox511.Text = File.ReadAllText(t511sfd)
        ScheduleForm.TextBox512.Text = File.ReadAllText(t512sfd)
        ScheduleForm.TextBox521.Text = File.ReadAllText(t521sfd)
        ScheduleForm.TextBox522.Text = File.ReadAllText(t522sfd)
        ScheduleForm.TextBox531.Text = File.ReadAllText(t531sfd)
        ScheduleForm.TextBox532.Text = File.ReadAllText(t532sfd)
        ScheduleForm.TextBox541.Text = File.ReadAllText(t541sfd)
        ScheduleForm.TextBox542.Text = File.ReadAllText(t542sfd)
        ScheduleForm.TextBox551.Text = File.ReadAllText(t551sfd)
        ScheduleForm.TextBox552.Text = File.ReadAllText(t552sfd)
        ScheduleForm.TextBox561.Text = File.ReadAllText(t561sfd)
        ScheduleForm.TextBox562.Text = File.ReadAllText(t562sfd)
        ScheduleForm.TextBox571.Text = File.ReadAllText(t571sfd)
        ScheduleForm.TextBox572.Text = File.ReadAllText(t572sfd)
        ScheduleForm.TextBox581.Text = File.ReadAllText(t581sfd)
        ScheduleForm.TextBox582.Text = File.ReadAllText(t582sfd)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ChangeLogForm.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        EmergencyLoginForm.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ScheduleLoginForm.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Избери мелодия за начало на часа!", "ГРЕШКА!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Computer.Audio.Play(TextBox1.Text)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Избери мелодия за начало на часа!", "ГРЕШКА!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox2.Text = Nothing Then
            MessageBox.Show("Избери мелодия за край на часа!", "ГРЕШКА!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Computer.Audio.Play(TextBox2.Text)
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If TextBox2.Text = Nothing Then
            MessageBox.Show("Избери мелодия за начало на часа!", "ГРЕШКА!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        DevInfoForm.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        File.Delete(t1hfd)
        File.Delete(t2hfd)
        My.Computer.FileSystem.WriteAllText(t1hfd, TextBox1.Text, True)
        My.Computer.FileSystem.WriteAllText(t2hfd, TextBox2.Text, True)
        MessageBox.Show("Промените са запазени!", "Запазено", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
