'-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
'Project: PiWeb Helper
'Description: Software built with the purpose of assisting in the navigation and opening of template files for the PiWeb software in inspection. Built to be used exclusively on the inspection cmm computer
'Created By: Nick Hallick
'            Process Engineer
'            nhallick@strite.com
'            519-658-9361 ext.344
'Project Start Date: 12/09/2017
'Project End Date: 12/09/2017
'Revision: 1.0.0 (Published)

'***********************************************************************************************************************************************************************
'The Dreaded TODO Section


'***********************************************************************************************************************************************************************
'-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Imports System.IO
Public Class Form1
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click


        'use tiered if/elseif statement to check if each of the textboxes is empty. If any of them are a messagebox will inform the user and then exit the sub
        If tbCustomer.Text = "" Then
            MsgBox("Customer cannot be blank, please enter a customer.", vbCritical, "Error")
            tbCustomer.Focus()
            Exit Sub
        ElseIf tbPartNumber.Text = "" Then
            MsgBox("Part number cannot be blank, please enter a part number.", vbCritical, "Error")
            tbPartNumber.Focus()
            Exit Sub
        ElseIf tbOPN.Text = "" Then
            MsgBox("Operation cannot be blank, please enter an operation number.", vbCritical, "Error")
            tbOPN.Focus()
            Exit Sub
        End If

        'set the file location using the info entered by the user in the three textboxes
        'Dim FileLocation As DirectoryInfo = New DirectoryInfo("C:\Users\nhallick\Desktop\Checksheets\" & tbCustomer.Text & "\" & tbPartNumber.Text & "\" & tbOPN.Text)
        Dim FileLocation As DirectoryInfo = New DirectoryInfo("C:\Users\Inspection CMM\Desktop\PiWEB Templates\" & tbCustomer.Text & "\" & tbPartNumber.Text & "\" & tbOPN.Text)
        Dim fi As FileInfo()

        'use try catch method to get all the files from the filelocation directory and store in fi (file info array)
        Try
            fi = FileLocation.GetFiles("*.ptx")
        Catch ex As Exception
            'if the file directory is typed wrong or not found then throw an error
            MsgBox("Directory not found, ensure directory exists and all info is typed correctly before trying again.", vbCritical, "Error")
            Exit Sub
        End Try

        'clear the listbox of items before adding new ones
        lbFiles.Items.Clear()

        'loop through each item in the file info array and add each one to the listbox as an item
        For Each thing In fi
            lbFiles.Items.Add(thing)
        Next

    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'check to see if the listbox has items selected in it, if it doesnt then tell the user this
        If lbFiles.SelectedItems.Count = 0 Then
            MsgBox("Please select at least one file from the list before continuing", vbCritical, "Error")
        Else
            'if there are items selected then use the directory string to open the selected files
            For Each filething In lbFiles.SelectedItems
                'Process.Start("C:\Users\nhallick\Desktop\Checksheets\" & tbCustomer.Text + "\" & tbPartNumber.Text & "\" & tbOPN.Text & "\" & Convert.ToString(filething))
                Process.Start("C:\Users\Inspection CMM\Desktop\PiWEB Templates\" & tbCustomer.Text & "\" & tbPartNumber.Text & "\" & tbOPN.Text & "\" & Convert.ToString(filething))
            Next
        End If


    End Sub
End Class
