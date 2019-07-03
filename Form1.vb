Public Class batexpert
    Dim filepath As String
    Dim file1 As String
    Dim file2 As String
    Dim file3 As String
    Dim file4 As String
    Dim file5 As String
    Dim filepath1 As String
    Dim filepath2 As String
    Dim filepath3 As String
    Dim filepath4 As String
    Dim filepath5 As String
    Dim fileselected As Integer = 1 'because its default value is 0
    Private Sub bunew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        codebox.Text = ""
        filepath = ""
    End Sub

    Private Sub buopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog.Filter = "Batch Files|*.bat"
        OpenFileDialog.ShowDialog()
        filepath = OpenFileDialog.FileName
        If System.IO.File.Exists(filepath) Then

            Me.Text = Me.Text & ": " & filepath

            Dim batreader As New System.IO.StreamReader(filepath)
            codebox.Text = batreader.ReadToEnd
            batreader.Close()
        End If
    End Sub

    Private Sub busave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If filepath = "" Then
            SaveFileDialog.Filter = "Batch Files|*.bat"
            SaveFileDialog.ShowDialog()
            filepath = SaveFileDialog.FileName
            Dim batwriter As New System.IO.StreamWriter(filepath)
            batwriter.Write(codebox.Text)
            batwriter.Close()
        Else
            Dim batwriter As New System.IO.StreamWriter(filepath)
            batwriter.Write(codebox.Text)
            batwriter.Close()
        End If
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub bupause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buspeak.Click
        Dim message As String
        message = InputBox("Write Message")
        If message = "" Then
        Else
            codebox.Text = codebox.Text & vbNewLine & "echo StrText=""" & message & """>spk.vbs" & vbNewLine & "echo set ObjVoice=CreateObject(""SAPI.SpVoice"") >> spk.vbs" & vbNewLine & "echo ObjVoice.Speak StrText >> spk.vbs" & vbNewLine & "start spk.vbs"
        End If
    End Sub

    Private Sub batexpert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buexecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'This check to insure we don"t get blank app error
        If codebox.Text = "" Then
            MsgBox("Error Invalid Code")
        Else
            Dim batwriter As New System.IO.StreamWriter("test.bat")
            batwriter.Write(codebox.Text)
            batwriter.Close()
            System.Diagnostics.Process.Start("test.bat")
        End If
    End Sub

    '-------------------------------------File_Menu----------------------------------
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        filepath = ""

        'Caution:This code is quite buggy,makes only bufile2 visible if reversed
        If bufile1.Visible = True And bufile2.Visible = True And bufile3.Visible = True And bufile4.Visible = True Then
            bufile5.Visible = True
        ElseIf bufile1.Visible = True And bufile2.Visible = True And bufile3.Visible = True Then
            bufile4.Visible = True
        ElseIf bufile1.Visible = True And bufile2.Visible = True Then
            bufile3.Visible = True
        ElseIf bufile1.Visible = True Then
            bufile2.Visible = True
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog.Filter = "Batch Files|*.bat|Text Files|*.txt|All Files|*.*"
        OpenFileDialog.ShowDialog()
        filepath = OpenFileDialog.FileName
        If System.IO.File.Exists(filepath) Then

            Me.Text = Me.Text & ": " & filepath

            Dim batreader As New System.IO.StreamReader(filepath)
            codebox.Text = batreader.ReadToEnd
            batreader.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If filepath = "" Then
            SaveFileDialog.Filter = "Batch Files|*.bat"
            SaveFileDialog.ShowDialog()
            filepath = SaveFileDialog.FileName
            Dim batwriter As New System.IO.StreamWriter(filepath)
            batwriter.Write(codebox.Text)
            batwriter.Close()
        Else
            Dim batwriter As New System.IO.StreamWriter(filepath)
            batwriter.Write(codebox.Text)
            batwriter.Close()
        End If
    End Sub

    Private Sub ExecuteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteToolStripMenuItem.Click
        'This check to insure we don"t get blank app error
        If codebox.Text = "" Then
            MsgBox("Error Invalid Code")
        Else
            Dim batwriter As New System.IO.StreamWriter("test.bat")
            batwriter.Write(codebox.Text)
            batwriter.Close()
            System.Diagnostics.Process.Start("test.bat")
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    '------------------------------------------------------------------------------

    Private Sub bulookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bulookup.Click
        If searchbox.Text = "" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        Else
            Dim p As New Process
            p.StartInfo.FileName = "cmd"
            p.StartInfo.Arguments = "/K @ECHO OFF && TITLE BateXpert HELP && CLS && " & "HELP " & searchbox.Text & " && PAUSE && " & searchbox.Text & " -h"
            p.Start()
        End If
    End Sub

    Private Sub LoopsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoopsToolStripMenuItem.Click
        codebox.Text = ""
    End Sub

    Private Sub STARTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bufile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub


    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        'Caution:This code is quite buggy,makes only bufile2 visible if reversed
        If bufile1.Visible = True And bufile2.Visible = True And bufile3.Visible = True And bufile4.Visible = True Then
            bufile5.Visible = True
        ElseIf bufile1.Visible = True And bufile2.Visible = True And bufile3.Visible = True Then
            bufile4.Visible = True
        ElseIf bufile1.Visible = True And bufile2.Visible = True Then
            bufile3.Visible = True
        ElseIf bufile1.Visible = True Then
            bufile2.Visible = True
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog.Filter = "Batch Files|*.bat;*.cmd|Text Files|*.txt|All Files|*.*"
        OpenFileDialog.ShowDialog()
        'filepath = OpenFileDialog.FileName
        If fileselected = 1 Then
            filepath1 = OpenFileDialog.FileName
            filepath = filepath1
        ElseIf fileselected = 2 Then
            filepath2 = OpenFileDialog.FileName
            filepath = filepath2
        ElseIf fileselected = 3 Then
            filepath3 = OpenFileDialog.FileName
            filepath = filepath3
        ElseIf fileselected = 4 Then
            filepath4 = OpenFileDialog.FileName
            filepath = filepath4
        ElseIf fileselected = 5 Then
            filepath5 = OpenFileDialog.FileName
            filepath = filepath5
        End If
        If System.IO.File.Exists(filepath) Then
            Dim batreader As New System.IO.StreamReader(filepath)
            codebox.Text = batreader.ReadToEnd
            batreader.Close()
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If filepath = "" Then
            SaveFileDialog.Filter = "Batch Files|*.bat|Text Files|*.txt|All Files|*.*"
            SaveFileDialog.ShowDialog()
            filepath = SaveFileDialog.FileName
            Dim batwriter As New System.IO.StreamWriter(filepath)
            batwriter.Write(codebox.Text)
            batwriter.Close()
        Else
            Dim batwriter As New System.IO.StreamWriter(filepath)
            batwriter.Write(codebox.Text)
            batwriter.Close()
        End If
    End Sub

    Private Sub ExecuteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteToolStripButton.Click
        'This check to insure we don"t get blank app error
        If codebox.Text = "" Then
            Beep()
            labhelp.Text = "Error,invalid code"
        Else
            Dim batwriter As New System.IO.StreamWriter("test.bat")
            batwriter.Write(codebox.Text)
            batwriter.Close()
            System.Diagnostics.Process.Start("test.bat")
        End If

    End Sub
    'File:Hover menu-------------------------------------------------------------------------
    Private Sub codebox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles codebox.MouseHover
        labhelp.Text = "Write your codes here"
    End Sub
    Private Sub bulookup_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bulookup.MouseHover
        labhelp.Text = "Lookup for CMD syntax"
    End Sub
    Private Sub AssocToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssocToolStripMenuItem.MouseHover
        labhelp.Text = "Displays or modifies file extension associations."
    End Sub
    Private Sub AttribToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttribToolStripMenuItem.MouseHover
        labhelp.Text = "Displays or changes file attributes."
    End Sub
    Private Sub CompToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPToolStripMenuItem.MouseHover
        labhelp.Text = "Compares the contents of two files or sets of files."
    End Sub
    Private Sub CompactToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPACTToolStripMenuItem.MouseHover
        labhelp.Text = "Displays or alters the compression of files on NTFS partitions."
    End Sub
    Private Sub DelToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELToolStripMenuItem.MouseHover
        labhelp.Text = "Deletes one or more files."
    End Sub
    Private Sub FcToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCToolStripMenuItem.MouseHover
        labhelp.Text = "Compares two files or sets of files, and displays the differences between them."
    End Sub
    Private Sub FindToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FINDToolStripMenuItem.MouseHover
        labhelp.Text = "Searches for a text string in a file or files."
    End Sub
    Private Sub FtypeToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FTTYPEToolStripMenuItem.MouseHover
        labhelp.Text = "Displays or modifies file types used in file extension associations."
    End Sub
    Private Sub MoveToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOVEToolStripMenuItem.MouseHover
        labhelp.Text = "Moves one or more files from one directory to another directory."
    End Sub
    Private Sub OpenfilesToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENFILESToolStripMenuItem.MouseHover
        labhelp.Text = "Displays files opened by remote users for a file share."
    End Sub
    Private Sub RenToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RENToolStripMenuItem.MouseHover
        labhelp.Text = "Renames a file or files."
    End Sub
    Private Sub ReplaceToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPLACEToolStripMenuItem.MouseHover
        labhelp.Text = "Replaces files."
    End Sub
    Private Sub XcopyToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XCOPYToolStripMenuItem.MouseHover
        labhelp.Text = "Copies files and directory trees."
    End Sub
    '___________________________________________________________________________________
    'FileMenu:click
    Private Sub AssocToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssocToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "ASSOC "
    End Sub

    Private Sub AttribToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttribToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "ATTRIB "
    End Sub

    Private Sub COMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "COMP "
    End Sub

    Private Sub COMPACTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPACTToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "COMPACT "
    End Sub

    Private Sub DELToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "DEL "
    End Sub

    Private Sub FCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "FC "
    End Sub

    Private Sub FINDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FINDToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "FIND "
    End Sub

    Private Sub FTTYPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FTTYPEToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "FTTYPE "
    End Sub

    Private Sub MOVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOVEToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "MOVE "
    End Sub

    Private Sub OPENFILESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENFILESToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "OPENFILES "
    End Sub

    Private Sub RENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RENToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "REN "
    End Sub

    Private Sub REPLACEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPLACEToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "REPLACE "
    End Sub

    Private Sub XCOPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XCOPYToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "XCOPY "
    End Sub

    Private Sub HellowWorldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HellowWorldToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "@ECHO OFF" & vbNewLine & "ECHO Hellow World" & vbNewLine & "PAUSE"
    End Sub


    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub bucolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bucolor.Click
        If bucolor.Text = "OK BG" Then
            If colorc.SelectedIndex = -1 Then
            Else
                codebox.Text = codebox.Text & vbNewLine & "COLOR " & colorc.SelectedIndex
                colorc.Text = "Foreground"
                bucolor.Text = "OK FG"
            End If

        ElseIf bucolor.Text = "OK FG" Then
            If colorc.SelectedIndex = -1 Then
            Else
                codebox.Text = codebox.Text & colorc.SelectedIndex
                colorc.Visible = False
                bucolor.Text = "Color"
            End If

        Else
                colorc.Visible = True
                bucolor.Text = "OK BG"
        End If
    End Sub
    'MultipleFileControlTAB-----------------------------------------------------------------------
    Private Sub bufile1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bufile1.Click
        'Function is to find previous tab,save work in its fileX,load text from its file1 and set new previous file record in fileselected
        'And to add new filepath
        If fileselected = 1 Then
            file1 = codebox.Text
        ElseIf fileselected = 2 Then
            file2 = codebox.Text
        ElseIf fileselected = 3 Then
            file3 = codebox.Text
        ElseIf fileselected = 4 Then
            file4 = codebox.Text
        ElseIf fileselected = 5 Then
            file5 = codebox.Text
        End If
        codebox.Text = file1
        fileselected = 1
        filepath = filepath1
        bufile1.BackColor = Color.Green
        bufile2.BackColor = Color.BurlyWood
        bufile3.BackColor = Color.BurlyWood
        bufile4.BackColor = Color.BurlyWood
        bufile5.BackColor = Color.BurlyWood

    End Sub

    Private Sub bufile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bufile2.Click
        If fileselected = 1 Then
            file1 = codebox.Text
        ElseIf fileselected = 2 Then
            file2 = codebox.Text
        ElseIf fileselected = 3 Then
            file3 = codebox.Text
        ElseIf fileselected = 4 Then
            file4 = codebox.Text
        ElseIf fileselected = 5 Then
            file5 = codebox.Text
        End If
        codebox.Text = file2
        fileselected = 2
        filepath = filepath2
        bufile1.BackColor = Color.BurlyWood
        bufile2.BackColor = Color.Green
        bufile3.BackColor = Color.BurlyWood
        bufile4.BackColor = Color.BurlyWood
        bufile5.BackColor = Color.BurlyWood
    End Sub

    Private Sub bufile3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bufile3.Click
        If fileselected = 1 Then
            file1 = codebox.Text
        ElseIf fileselected = 2 Then
            file2 = codebox.Text
        ElseIf fileselected = 3 Then
            file3 = codebox.Text
        ElseIf fileselected = 4 Then
            file4 = codebox.Text
        ElseIf fileselected = 5 Then
            file5 = codebox.Text
        End If
        codebox.Text = file3
        fileselected = 3
        filepath = filepath3
        bufile1.BackColor = Color.BurlyWood
        bufile2.BackColor = Color.BurlyWood
        bufile3.BackColor = Color.Green
        bufile4.BackColor = Color.BurlyWood
        bufile5.BackColor = Color.BurlyWood
    End Sub

    Private Sub bufile4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bufile4.Click
        If fileselected = 1 Then
            file1 = codebox.Text
        ElseIf fileselected = 2 Then
            file2 = codebox.Text
        ElseIf fileselected = 3 Then
            file3 = codebox.Text
        ElseIf fileselected = 4 Then
            file4 = codebox.Text
        ElseIf fileselected = 5 Then
            file5 = codebox.Text
        End If
        codebox.Text = file4
        fileselected = 4
        filepath = filepath4
        bufile1.BackColor = Color.BurlyWood
        bufile2.BackColor = Color.BurlyWood
        bufile3.BackColor = Color.BurlyWood
        bufile4.BackColor = Color.Green
        bufile5.BackColor = Color.BurlyWood
    End Sub

    Private Sub bufile5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bufile5.Click
        If fileselected = 1 Then
            file1 = codebox.Text
        ElseIf fileselected = 2 Then
            file2 = codebox.Text
        ElseIf fileselected = 3 Then
            file3 = codebox.Text
        ElseIf fileselected = 4 Then
            file4 = codebox.Text
        ElseIf fileselected = 5 Then
            file5 = codebox.Text
        End If
        codebox.Text = file5
        fileselected = 5
        filepath = filepath5
        bufile1.BackColor = Color.BurlyWood
        bufile2.BackColor = Color.BurlyWood
        bufile3.BackColor = Color.BurlyWood
        bufile4.BackColor = Color.BurlyWood
        bufile5.BackColor = Color.Green
    End Sub
    'DISK HOVER MENU______________________________________________________
    Private Sub LABELToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LABELToolStripMenuItem.MouseHover
        labhelp.Text = "Creates, changes, or deletes the volume label of a disk."
    End Sub
    Private Sub CHDIRToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CHDIRToolStripMenuItem.MouseHover
        labhelp.Text = "Displays the name of or changes the current directory."
    End Sub
    Private Sub CHDSKToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CHKDSKToolStripMenuItem.MouseHover
        labhelp.Text = "Checks a disk and displays a status report."
    End Sub
    Private Sub RECOVERToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles RECOVERToolStripMenuItem.MouseHover
        labhelp.Text = "Recovers readable information from a bad or defective disk."
    End Sub
    Private Sub RMDIRToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles RMDIRToolStripMenuItem.MouseHover
        labhelp.Text = "Removes a directory."
    End Sub
    Private Sub ROBOCOPYToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ROBOCOPYToolStripMenuItem.MouseHover
        labhelp.Text = "Advanced utility to copy files and directory trees"
    End Sub
    Private Sub TREEToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TREEToolStripMenuItem.MouseHover
        labhelp.Text = "Graphically displays the directory structure of a drive or path."
    End Sub
    Private Sub VOLToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles VOLToolStripMenuItem.MouseHover
        labhelp.Text = "Displays a disk volume label and serial number."
    End Sub
    Private Sub CONVERTToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CONVERTToolStripMenuItem1.MouseHover
        labhelp.Text = "Converts FAT volumes to NTFS.  You cannot convert thecurrent drive."
    End Sub
    Private Sub DIRToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles DIRToolStripMenuItem.MouseHover
        labhelp.Text = "Displays a list of files and subdirectories in a directory."
    End Sub
    Private Sub DISKPARTToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles DISKPARTToolStripMenuItem.MouseHover
        labhelp.Text = "Displays or configures Disk Partition properties."
    End Sub
    Private Sub FORMATToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles FORMATToolStripMenuItem.MouseHover
        labhelp.Text = "Formats a disk for use with Windows."
    End Sub
    Private Sub FSUTILToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles FSUTILToolStripMenuItem.MouseHover
        labhelp.Text = "Displays or configures the file system properties."
    End Sub
    Private Sub CDToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CDToolStripMenuItem.MouseHover
        labhelp.Text = "Displays the name of or changes the current directory."
    End Sub

    Private Sub bucall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bucall.Click
        OpenFileDialog.ShowDialog()
        codebox.Text = codebox.Text & " " & OpenFileDialog.FileName
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        codebox.Paste()
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        codebox.Copy()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        codebox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        codebox.Paste()
    End Sub

    Private Sub DISKToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISKToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub CutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(codebox.SelectedText)
    End Sub

    'Hover menu 3----------------------------------------------------------------------
    Private Sub ToolStripMenuItem4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.MouseHover
        labhelp.Text = "Calls one batch program from another."
    End Sub

    Private Sub ToolStripMenuItem5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.MouseHover
        labhelp.Text = "Starts a new instance of the Windows command interpreter."
    End Sub

    Private Sub ToolStripMenuItem6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.MouseHover
        labhelp.Text = "Displays messages, or turns command echoing on or off."
    End Sub

    Private Sub ToolStripMenuItem7_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        labhelp.Text = "Quits the CMD.EXE program (command interpreter)."
    End Sub

    Private Sub ToolStripMenuItem8_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.MouseHover
        labhelp.Text = "Runs a specified command for each file in a set of files."
    End Sub

    Private Sub ToolStripMenuItem9_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.MouseHover
        labhelp.Text = "Directs the Windows command interpreter to a labeled line in a batch program."
    End Sub

    Private Sub ToolStripMenuItem10_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.MouseHover
        labhelp.Text = "Performs conditional processing in batch programs."
    End Sub

    Private Sub ToolStripMenuItem11_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.MouseHover
        labhelp.Text = "Starts a separate window to run a specified program or command."
    End Sub

    Private Sub MICSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
    '---------------------------------------------------------
    Private Sub DATEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATEToolStripMenuItem1.Click
        codebox.Text = codebox.Text & vbNewLine & "DATE"
    End Sub
    Private Sub DATEToolStripMenuItem1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATEToolStripMenuItem1.MouseHover
        labhelp.Text = "Displays or sets the date."
    End Sub


    Private Sub PATHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PATHToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "PATH"
    End Sub
    Private Sub PATHToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PATHToolStripMenuItem.MouseHover
        labhelp.Text = "Displays or sets a search path for executable files."
    End Sub

    Private Sub TASKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TASKToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "TASKKIL"
    End Sub
    Private Sub TASKToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TASKToolStripMenuItem.MouseHover
        labhelp.Text = "Kill or stop a running process or application."
    End Sub

    Private Sub VERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VERToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "VER"
    End Sub
    Private Sub VERToolStripMenuItem_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VERToolStripMenuItem.MouseHover
        labhelp.Text = "Displays the Windows version."
    End Sub

    Private Sub EXITToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem1.Click
        codebox.Text = codebox.Text & vbNewLine & "EXIT"
    End Sub
    Private Sub EXITToolStripMenuItem1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem1.MouseHover
        labhelp.Text = "Quits the CMD.EXE program (command interpreter)."
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If codebox.Text = "" Then
            codebox.Text = "MSG * YOUR MESSAGE"
        Else
            codebox.Text = codebox.Text & vbCrLf & "MSG * YOUR MESSAGE"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        codebox.Text = codebox.Text & vbCrLf & "TASKKILL /F /IM Processname.exe"
    End Sub

    Private Sub bucompile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bucompile.Click
        If System.IO.File.Exists("Bat_To_Exe_Converter.exe") Then
            Shell("Bat_To_Exe_Converter.exe")
        Else
            MsgBox("To compile scripts.Download the compiler from www.f2ko.de ")
        End If
    End Sub
    'SCRIPTS----------------------------------------------------------------------------
    Private Sub MatrixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatrixToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "@ECHO off" & vbNewLine & "COLOR A" & vbNewLine & ":loop" & vbNewLine & "ECHO %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random%" & vbNewLine & "GOTO loop"
    End Sub

    Private Sub AnnoyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnoyToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "REM This program will just annoy you.You can restart your pc to stop it." & vbNewLine & "@ECHO OFF" & vbNewLine & ":loop" & vbNewLine & "msg * Hi there!" & vbNewLine & "msg * How u doin ?" & vbNewLine & "msg * Are you fine ?" & vbNewLine & "msg * Never mind about me...." & "msg * I am not here to annoy you...." & vbNewLine & "msg * I am caring for you....." & vbNewLine & "msg * start counting from 1 to 3, i Will be outta this place....." & vbNewLine & "msg * 1" & vbNewLine & "msg * 2" & vbNewLine & "msg * 3" & vbNewLine & "msg * 4" & vbNewLine & "msg * Oops! I counted up to four." & vbNewLine & "msg * So let us start again..." & vbNewLine & "GOTO loop"
    End Sub

    Private Sub CrashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrashToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "REM This program will crash the system by starting several programs" & vbNewLine & "@ECHO OFF" & vbNewLine & ":loop" & vbNewLine & "start notepad" & vbNewLine & "start calc" & vbNewLine & "start cmd" & vbNewLine & "start explorer" & vbNewLine & "goto loop"
    End Sub

    Private Sub SpeakUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeakUpToolStripMenuItem.Click
        codebox.Text = codebox.Text & vbNewLine & "REM This will log the programs running on the system, in a text file" & vbNewLine & "@echo off" & vbNewLine & "echo. > plog.txt" & vbNewLine & "echo Log File >> logfile.txt" & vbNewLine & "echo. >> logfile.txt" & vbNewLine & "echo User : %username% >> logfile.txt" & vbNewLine & "Date /t >>logfile.txt" & vbNewLine & "Time /t >> logfile.txt" & vbNewLine & "echo. >> logfile.txt" & vbNewLine & "echo Process Ran by %username% >> logfile.txt" & vbNewLine & "echo. >> logfile.txt" & vbNewLine & "qprocess >> logfile.txt" & vbNewLine & "START logfile.txt"
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub bushutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bushutdown.Click
        codebox.Text = codebox.Text & vbNewLine & "SHUTDOWN -s -t 15 -c YOUR_MESSAGE(eg.Your_system_has_been_infected,it_needs_a_restart)"
    End Sub

    Private Sub colorc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorc.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Shell("explorer www.darkstars.coffeecup.com")
    End Sub


    Private Sub ToolStripMenuItem137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem137.Click
        codebox.Cut()
    End Sub

    Private Sub FalseVirusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FalseVirusToolStripMenuItem.Click
        codebox.Text = codebox.Text & "@ECHO OFF" & vbNewLine & "echo StrText=""Its your PC speaking, windows system has been infected by a boot virus."">spk.vbs" & vbNewLine & "echo set ObjVoice=CreateObject(""SAPI.SpVoice"") >> spk.vbs" & vbNewLine & "echo ObjVoice.Speak StrText >> spk.vbs" & vbNewLine & "start spk.vbs" & vbNewLine & "SHUTDOWN -s -t 15 -c VirusFond"
    End Sub
End Class
