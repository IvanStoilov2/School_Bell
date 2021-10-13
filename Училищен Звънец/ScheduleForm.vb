Imports System.IO
Public Class ScheduleForm
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        File.Delete(t111sfd)
        File.Delete(t112sfd)
        File.Delete(t121sfd)
        File.Delete(t122sfd)
        File.Delete(t131sfd)
        File.Delete(t132sfd)
        File.Delete(t141sfd)
        File.Delete(t142sfd)
        File.Delete(t151sfd)
        File.Delete(t152sfd)
        File.Delete(t161sfd)
        File.Delete(t162sfd)
        File.Delete(t171sfd)
        File.Delete(t172sfd)
        File.Delete(t181sfd)
        File.Delete(t182sfd)
        File.Delete(t211sfd)
        File.Delete(t212sfd)
        File.Delete(t221sfd)
        File.Delete(t222sfd)
        File.Delete(t231sfd)
        File.Delete(t232sfd)
        File.Delete(t241sfd)
        File.Delete(t242sfd)
        File.Delete(t251sfd)
        File.Delete(t252sfd)
        File.Delete(t261sfd)
        File.Delete(t262sfd)
        File.Delete(t271sfd)
        File.Delete(t272sfd)
        File.Delete(t281sfd)
        File.Delete(t282sfd)
        File.Delete(t311sfd)
        File.Delete(t312sfd)
        File.Delete(t321sfd)
        File.Delete(t322sfd)
        File.Delete(t331sfd)
        File.Delete(t332sfd)
        File.Delete(t341sfd)
        File.Delete(t342sfd)
        File.Delete(t351sfd)
        File.Delete(t352sfd)
        File.Delete(t361sfd)
        File.Delete(t362sfd)
        File.Delete(t371sfd)
        File.Delete(t372sfd)
        File.Delete(t381sfd)
        File.Delete(t382sfd)
        File.Delete(t411sfd)
        File.Delete(t412sfd)
        File.Delete(t421sfd)
        File.Delete(t422sfd)
        File.Delete(t431sfd)
        File.Delete(t432sfd)
        File.Delete(t441sfd)
        File.Delete(t442sfd)
        File.Delete(t451sfd)
        File.Delete(t452sfd)
        File.Delete(t461sfd)
        File.Delete(t462sfd)
        File.Delete(t471sfd)
        File.Delete(t472sfd)
        File.Delete(t481sfd)
        File.Delete(t482sfd)
        File.Delete(t511sfd)
        File.Delete(t512sfd)
        File.Delete(t521sfd)
        File.Delete(t522sfd)
        File.Delete(t531sfd)
        File.Delete(t532sfd)
        File.Delete(t541sfd)
        File.Delete(t542sfd)
        File.Delete(t551sfd)
        File.Delete(t552sfd)
        File.Delete(t561sfd)
        File.Delete(t562sfd)
        File.Delete(t571sfd)
        File.Delete(t572sfd)
        File.Delete(t581sfd)
        File.Delete(t582sfd)

        My.Computer.FileSystem.WriteAllText(t111sfd, TextBox111.Text, True)
        My.Computer.FileSystem.WriteAllText(t112sfd, TextBox112.Text, True)
        My.Computer.FileSystem.WriteAllText(t121sfd, TextBox121.Text, True)
        My.Computer.FileSystem.WriteAllText(t122sfd, TextBox122.Text, True)
        My.Computer.FileSystem.WriteAllText(t131sfd, TextBox131.Text, True)
        My.Computer.FileSystem.WriteAllText(t132sfd, TextBox132.Text, True)
        My.Computer.FileSystem.WriteAllText(t141sfd, TextBox141.Text, True)
        My.Computer.FileSystem.WriteAllText(t142sfd, TextBox142.Text, True)
        My.Computer.FileSystem.WriteAllText(t151sfd, TextBox151.Text, True)
        My.Computer.FileSystem.WriteAllText(t152sfd, TextBox152.Text, True)
        My.Computer.FileSystem.WriteAllText(t161sfd, TextBox161.Text, True)
        My.Computer.FileSystem.WriteAllText(t162sfd, TextBox162.Text, True)
        My.Computer.FileSystem.WriteAllText(t171sfd, TextBox171.Text, True)
        My.Computer.FileSystem.WriteAllText(t172sfd, TextBox172.Text, True)
        My.Computer.FileSystem.WriteAllText(t181sfd, TextBox181.Text, True)
        My.Computer.FileSystem.WriteAllText(t182sfd, TextBox182.Text, True)

        My.Computer.FileSystem.WriteAllText(t211sfd, TextBox211.Text, True)
        My.Computer.FileSystem.WriteAllText(t212sfd, TextBox212.Text, True)
        My.Computer.FileSystem.WriteAllText(t221sfd, TextBox221.Text, True)
        My.Computer.FileSystem.WriteAllText(t222sfd, TextBox222.Text, True)
        My.Computer.FileSystem.WriteAllText(t231sfd, TextBox231.Text, True)
        My.Computer.FileSystem.WriteAllText(t232sfd, TextBox232.Text, True)
        My.Computer.FileSystem.WriteAllText(t241sfd, TextBox241.Text, True)
        My.Computer.FileSystem.WriteAllText(t242sfd, TextBox242.Text, True)
        My.Computer.FileSystem.WriteAllText(t251sfd, TextBox251.Text, True)
        My.Computer.FileSystem.WriteAllText(t252sfd, TextBox252.Text, True)
        My.Computer.FileSystem.WriteAllText(t261sfd, TextBox261.Text, True)
        My.Computer.FileSystem.WriteAllText(t262sfd, TextBox262.Text, True)
        My.Computer.FileSystem.WriteAllText(t271sfd, TextBox271.Text, True)
        My.Computer.FileSystem.WriteAllText(t272sfd, TextBox272.Text, True)
        My.Computer.FileSystem.WriteAllText(t281sfd, TextBox281.Text, True)
        My.Computer.FileSystem.WriteAllText(t282sfd, TextBox282.Text, True)

        My.Computer.FileSystem.WriteAllText(t311sfd, TextBox311.Text, True)
        My.Computer.FileSystem.WriteAllText(t312sfd, TextBox312.Text, True)
        My.Computer.FileSystem.WriteAllText(t321sfd, TextBox321.Text, True)
        My.Computer.FileSystem.WriteAllText(t322sfd, TextBox322.Text, True)
        My.Computer.FileSystem.WriteAllText(t331sfd, TextBox331.Text, True)
        My.Computer.FileSystem.WriteAllText(t332sfd, TextBox332.Text, True)
        My.Computer.FileSystem.WriteAllText(t341sfd, TextBox341.Text, True)
        My.Computer.FileSystem.WriteAllText(t342sfd, TextBox342.Text, True)
        My.Computer.FileSystem.WriteAllText(t351sfd, TextBox351.Text, True)
        My.Computer.FileSystem.WriteAllText(t352sfd, TextBox352.Text, True)
        My.Computer.FileSystem.WriteAllText(t361sfd, TextBox361.Text, True)
        My.Computer.FileSystem.WriteAllText(t362sfd, TextBox362.Text, True)
        My.Computer.FileSystem.WriteAllText(t371sfd, TextBox371.Text, True)
        My.Computer.FileSystem.WriteAllText(t372sfd, TextBox372.Text, True)
        My.Computer.FileSystem.WriteAllText(t381sfd, TextBox381.Text, True)
        My.Computer.FileSystem.WriteAllText(t382sfd, TextBox382.Text, True)

        My.Computer.FileSystem.WriteAllText(t411sfd, TextBox411.Text, True)
        My.Computer.FileSystem.WriteAllText(t412sfd, TextBox412.Text, True)
        My.Computer.FileSystem.WriteAllText(t421sfd, TextBox421.Text, True)
        My.Computer.FileSystem.WriteAllText(t422sfd, TextBox422.Text, True)
        My.Computer.FileSystem.WriteAllText(t431sfd, TextBox431.Text, True)
        My.Computer.FileSystem.WriteAllText(t432sfd, TextBox432.Text, True)
        My.Computer.FileSystem.WriteAllText(t441sfd, TextBox441.Text, True)
        My.Computer.FileSystem.WriteAllText(t442sfd, TextBox442.Text, True)
        My.Computer.FileSystem.WriteAllText(t451sfd, TextBox451.Text, True)
        My.Computer.FileSystem.WriteAllText(t452sfd, TextBox452.Text, True)
        My.Computer.FileSystem.WriteAllText(t461sfd, TextBox461.Text, True)
        My.Computer.FileSystem.WriteAllText(t462sfd, TextBox462.Text, True)
        My.Computer.FileSystem.WriteAllText(t471sfd, TextBox471.Text, True)
        My.Computer.FileSystem.WriteAllText(t472sfd, TextBox472.Text, True)
        My.Computer.FileSystem.WriteAllText(t481sfd, TextBox481.Text, True)
        My.Computer.FileSystem.WriteAllText(t482sfd, TextBox482.Text, True)

        My.Computer.FileSystem.WriteAllText(t511sfd, TextBox511.Text, True)
        My.Computer.FileSystem.WriteAllText(t512sfd, TextBox512.Text, True)
        My.Computer.FileSystem.WriteAllText(t521sfd, TextBox521.Text, True)
        My.Computer.FileSystem.WriteAllText(t522sfd, TextBox522.Text, True)
        My.Computer.FileSystem.WriteAllText(t531sfd, TextBox531.Text, True)
        My.Computer.FileSystem.WriteAllText(t532sfd, TextBox532.Text, True)
        My.Computer.FileSystem.WriteAllText(t541sfd, TextBox541.Text, True)
        My.Computer.FileSystem.WriteAllText(t542sfd, TextBox542.Text, True)
        My.Computer.FileSystem.WriteAllText(t551sfd, TextBox551.Text, True)
        My.Computer.FileSystem.WriteAllText(t552sfd, TextBox552.Text, True)
        My.Computer.FileSystem.WriteAllText(t561sfd, TextBox561.Text, True)
        My.Computer.FileSystem.WriteAllText(t562sfd, TextBox562.Text, True)
        My.Computer.FileSystem.WriteAllText(t571sfd, TextBox571.Text, True)
        My.Computer.FileSystem.WriteAllText(t572sfd, TextBox572.Text, True)
        My.Computer.FileSystem.WriteAllText(t581sfd, TextBox581.Text, True)
        My.Computer.FileSystem.WriteAllText(t582sfd, TextBox582.Text, True)
        MessageBox.Show("Промените са запазени!", "Запазено", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ScheduleForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        TextBox111.Text = File.ReadAllText(t111sfd)
        TextBox112.Text = File.ReadAllText(t112sfd)
        TextBox121.Text = File.ReadAllText(t121sfd)
        TextBox122.Text = File.ReadAllText(t122sfd)
        TextBox131.Text = File.ReadAllText(t131sfd)
        TextBox132.Text = File.ReadAllText(t132sfd)
        TextBox141.Text = File.ReadAllText(t141sfd)
        TextBox142.Text = File.ReadAllText(t142sfd)
        TextBox151.Text = File.ReadAllText(t151sfd)
        TextBox152.Text = File.ReadAllText(t152sfd)
        TextBox161.Text = File.ReadAllText(t161sfd)
        TextBox162.Text = File.ReadAllText(t162sfd)
        TextBox171.Text = File.ReadAllText(t171sfd)
        TextBox172.Text = File.ReadAllText(t172sfd)
        TextBox181.Text = File.ReadAllText(t181sfd)
        TextBox182.Text = File.ReadAllText(t182sfd)
        TextBox211.Text = File.ReadAllText(t211sfd)
        TextBox212.Text = File.ReadAllText(t212sfd)
        TextBox221.Text = File.ReadAllText(t221sfd)
        TextBox222.Text = File.ReadAllText(t222sfd)
        TextBox231.Text = File.ReadAllText(t231sfd)
        TextBox232.Text = File.ReadAllText(t232sfd)
        TextBox241.Text = File.ReadAllText(t241sfd)
        TextBox242.Text = File.ReadAllText(t242sfd)
        TextBox251.Text = File.ReadAllText(t251sfd)
        TextBox252.Text = File.ReadAllText(t252sfd)
        TextBox261.Text = File.ReadAllText(t261sfd)
        TextBox262.Text = File.ReadAllText(t262sfd)
        TextBox271.Text = File.ReadAllText(t271sfd)
        TextBox272.Text = File.ReadAllText(t272sfd)
        TextBox281.Text = File.ReadAllText(t281sfd)
        TextBox282.Text = File.ReadAllText(t282sfd)
        TextBox311.Text = File.ReadAllText(t311sfd)
        TextBox312.Text = File.ReadAllText(t312sfd)
        TextBox321.Text = File.ReadAllText(t321sfd)
        TextBox322.Text = File.ReadAllText(t322sfd)
        TextBox331.Text = File.ReadAllText(t331sfd)
        TextBox332.Text = File.ReadAllText(t332sfd)
        TextBox341.Text = File.ReadAllText(t341sfd)
        TextBox342.Text = File.ReadAllText(t342sfd)
        TextBox351.Text = File.ReadAllText(t351sfd)
        TextBox352.Text = File.ReadAllText(t352sfd)
        TextBox361.Text = File.ReadAllText(t361sfd)
        TextBox362.Text = File.ReadAllText(t362sfd)
        TextBox371.Text = File.ReadAllText(t371sfd)
        TextBox372.Text = File.ReadAllText(t372sfd)
        TextBox381.Text = File.ReadAllText(t381sfd)
        TextBox382.Text = File.ReadAllText(t382sfd)
        TextBox411.Text = File.ReadAllText(t411sfd)
        TextBox412.Text = File.ReadAllText(t412sfd)
        TextBox421.Text = File.ReadAllText(t421sfd)
        TextBox422.Text = File.ReadAllText(t422sfd)
        TextBox431.Text = File.ReadAllText(t431sfd)
        TextBox432.Text = File.ReadAllText(t432sfd)
        TextBox441.Text = File.ReadAllText(t441sfd)
        TextBox442.Text = File.ReadAllText(t442sfd)
        TextBox451.Text = File.ReadAllText(t451sfd)
        TextBox452.Text = File.ReadAllText(t452sfd)
        TextBox461.Text = File.ReadAllText(t461sfd)
        TextBox462.Text = File.ReadAllText(t462sfd)
        TextBox471.Text = File.ReadAllText(t471sfd)
        TextBox472.Text = File.ReadAllText(t472sfd)
        TextBox481.Text = File.ReadAllText(t481sfd)
        TextBox482.Text = File.ReadAllText(t482sfd)
        TextBox511.Text = File.ReadAllText(t511sfd)
        TextBox512.Text = File.ReadAllText(t512sfd)
        TextBox521.Text = File.ReadAllText(t521sfd)
        TextBox522.Text = File.ReadAllText(t522sfd)
        TextBox531.Text = File.ReadAllText(t531sfd)
        TextBox532.Text = File.ReadAllText(t532sfd)
        TextBox541.Text = File.ReadAllText(t541sfd)
        TextBox542.Text = File.ReadAllText(t542sfd)
        TextBox551.Text = File.ReadAllText(t551sfd)
        TextBox552.Text = File.ReadAllText(t552sfd)
        TextBox561.Text = File.ReadAllText(t561sfd)
        TextBox562.Text = File.ReadAllText(t562sfd)
        TextBox571.Text = File.ReadAllText(t571sfd)
        TextBox572.Text = File.ReadAllText(t572sfd)
        TextBox581.Text = File.ReadAllText(t581sfd)
        TextBox582.Text = File.ReadAllText(t582sfd)
    End Sub
End Class