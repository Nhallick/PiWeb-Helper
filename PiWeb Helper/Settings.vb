Imports System.ComponentModel

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Settings.FreqUsed.Clear()

        Dim spl As String()
        Dim i As Integer = 0
        LVSettings.View = View.Details
        'LVSettings.Items.Add(New ListViewItem(New String() {"1", "content", "third thing"}))
        If My.Settings.FreqUsed Is Nothing Then
            My.Settings.FreqUsed = New Specialized.StringCollection
        End If
        'For Each item In My.Settings.FreqUsed
        Do Until i = My.Settings.FreqUsed.Count
            If My.Settings.FreqUsed.Count > 0 Then

                spl = My.Settings.FreqUsed(i).Split(",")
                LVSettings.Items.Add(New ListViewItem(New String() {spl(0), spl(1), spl(2)}))
                i = i + 1

            End If
        Loop

        'Next
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tbCustomer.Text <> "" And tbPartNumber.Text <> "" And tbOperation.Text <> "" Then
            LVSettings.Items.Add(New ListViewItem(New String() {tbCustomer.Text, tbPartNumber.Text, tbOperation.Text}))
            My.Settings.FreqUsed.Add(tbCustomer.Text & "," & tbPartNumber.Text & "," & tbOperation.Text)
            My.Settings.Save()
            tbCustomer.Text = ""
            tbPartNumber.Text = ""
            tbOperation.Text = ""
        Else
            MsgBox("All textboxes must be filled out in order to add an item to the list.", vbCritical, "Error")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If LVSettings.SelectedItems.Count = 0 Then
            MsgBox("You must first select an item in order to delete it!", vbCritical, "Error")
            Exit Sub
        End If
        Dim del As Boolean = False
        Dim spl As String()
        Dim i As Integer = 0

        Do Until del = True
            spl = My.Settings.FreqUsed(i).Split(",")
            If LVSettings.SelectedItems.Item(0).Text = spl(0) Then
                If LVSettings.SelectedItems.Item(0).SubItems(1).Text = spl(1) Then
                    If LVSettings.SelectedItems.Item(0).SubItems(2).Text = spl(2) Then
                        LVSettings.SelectedItems.Clear()
                        My.Settings.FreqUsed.RemoveAt(i)
                        My.Settings.Save()
                        del = True
                    End If
                End If
            End If

            i = i + 1
        Loop
        i = 0
        LVSettings.Items.Clear()
        Do Until i = My.Settings.FreqUsed.Count
            If My.Settings.FreqUsed.Count > 0 Then

                spl = My.Settings.FreqUsed(i).Split(",")
                LVSettings.Items.Add(New ListViewItem(New String() {spl(0), spl(1), spl(2)}))
                i = i + 1

            End If
        Loop
        tbCustomer.Text = ""
        tbOperation.Text = ""
        tbPartNumber.Text = ""
    End Sub

    Private Sub LVSettings_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles LVSettings.ItemSelectionChanged

        tbCustomer.Text = LVSettings.SelectedItems.Item(0).Text
        tbPartNumber.Text = LVSettings.SelectedItems.Item(0).SubItems(1).Text
        tbOperation.Text = LVSettings.SelectedItems.Item(0).SubItems(2).Text
    End Sub

    Private Sub btnMoveup_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
        If LVSettings.SelectedItems.Count = 0 Then
            MsgBox("You must first select an item in order to move it!", vbCritical, "Error")
            Exit Sub
        End If
        Dim spl As String()
        Dim i As Integer = 0
        Dim mov = False
        Dim indx As Integer

        Do Until mov = True
            spl = My.Settings.FreqUsed(i).Split(",")
            If LVSettings.SelectedItems.Item(0).Text = spl(0) Then
                If LVSettings.SelectedItems.Item(0).SubItems(1).Text = spl(1) Then
                    If LVSettings.SelectedItems.Item(0).SubItems(2).Text = spl(2) Then

                        If i > 0 Then
                            My.Settings.FreqUsed.RemoveAt(i)
                            My.Settings.FreqUsed.Insert(i - 1, (spl(0) + "," + spl(1) + "," + spl(2)))
                            indx = i - 1
                        Else
                            MsgBox("Item is already at the top of the list", vbInformation, "Top Limit")
                            indx = 0
                        End If

                        mov = True
                    End If
                End If
            End If

            i = i + 1
        Loop

        i = 0
        LVSettings.Items.Clear()
        Do Until i = My.Settings.FreqUsed.Count
            If My.Settings.FreqUsed.Count > 0 Then

                spl = My.Settings.FreqUsed(i).Split(",")
                LVSettings.Items.Add(New ListViewItem(New String() {spl(0), spl(1), spl(2)}))
                i = i + 1

            End If
        Loop
        LVSettings.Items(indx).Selected = True
        LVSettings.Select()
    End Sub

    Private Sub BtnMoveDown_Click(sender As Object, e As EventArgs) Handles BtnMoveDown.Click
        If LVSettings.SelectedItems.Count = 0 Then
            MsgBox("You must first select an item in order to move it!", vbCritical, "Error")
            Exit Sub
        End If
        Dim spl As String()
        Dim i As Integer = 0
        Dim mov = False
        Dim indx As Integer

        Do Until mov = True
            spl = My.Settings.FreqUsed(i).Split(",")
            If LVSettings.SelectedItems.Item(0).Text = spl(0) Then
                If LVSettings.SelectedItems.Item(0).SubItems(1).Text = spl(1) Then
                    If LVSettings.SelectedItems.Item(0).SubItems(2).Text = spl(2) Then


                        If i < My.Settings.FreqUsed.Count - 1 Then
                            My.Settings.FreqUsed.RemoveAt(i)
                            My.Settings.FreqUsed.Insert(i + 1, (spl(0) + "," + spl(1) + "," + spl(2)))
                            indx = i + 1
                        Else
                            MsgBox("Item is already at the bottom of the list", vbInformation, "Bottom Limit")
                            indx = My.Settings.FreqUsed.Count - 1
                        End If

                        mov = True
                    End If
                End If
            End If

            i = i + 1
        Loop

        i = 0
        LVSettings.Items.Clear()
        Do Until i = My.Settings.FreqUsed.Count
            If My.Settings.FreqUsed.Count > 0 Then

                spl = My.Settings.FreqUsed(i).Split(",")
                LVSettings.Items.Add(New ListViewItem(New String() {spl(0), spl(1), spl(2)}))
                i = i + 1

            End If
        Loop
        LVSettings.Items(indx).Selected = True
        LVSettings.Select()
    End Sub

    Private Sub Settings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim i As Integer = 0
        Dim spl As String()
        Form1.CBFreqUsed.Items.Clear()
        If LVSettings.Items.Count = 0 Then
            Exit Sub
        End If
        Do Until i = My.Settings.FreqUsed.Count
            Form1.CBFreqUsed.Items.Add(My.Settings.FreqUsed(i))
            i = i + 1
        Loop
        Form1.CBFreqUsed.Text = Form1.CBFreqUsed.Items(0)
        spl = Form1.CBFreqUsed.Text.Split(",")
        Form1.tbCustomer.Text = spl(0)
        Form1.tbPartNumber.Text = spl(1)
        Form1.tbOPN.Text = spl(2)
    End Sub
End Class