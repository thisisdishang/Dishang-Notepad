Public Class Notepad

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        ' MsgBox("Do You Want To Save?", MsgBoxStyle.YesNoCancel)
        'RichTextBox1.Text = ""
        'New File
        If Me.Text <> "Notepad" Then
            RichTextBox1.SaveFile(Me.Text, RichTextBoxStreamType.PlainText)
            Me.Text = "Notepad"
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem1.Click
        'Open File
        With OpenFileDialog1
            .Filter = "Text File|*.txt|RTF File|*.rtf"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.LoadFile(.FileName, RichTextBoxStreamType.PlainText)
                Me.Text = .FileName
            End If
        End With
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Save File
        If Me.Text = "Notepad" Then
            With SaveFile
                .Filter = "Text File|*.txt|RTF File|*.rtf"
                .Title = "Save File"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    RichTextBox1.SaveFile(.FileName, RichTextBoxStreamType.PlainText)
                    Me.Text = .FileName
                End If
            End With
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        'Save As File
        If Me.Text = "Notepad" Then
            With SaveFile
                .Filter = "Text File|*.txt|RTF File|*.rtf"
                .Title = "Save As File"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    RichTextBox1.SaveFile(.FileName, RichTextBoxStreamType.PlainText)
                    Me.Text = .FileName
                End If
            End With
        End If
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        'Font 
        With FontDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = FontDialog1.Font
            End If
        End With
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMeToolStripMenuItem.Click
        MsgBox("Dishang's Notepad", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub PrintToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        'Color
        With ColorDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.ForeColor = ColorDialog1.Color

            End If
        End With
    End Sub

End Class