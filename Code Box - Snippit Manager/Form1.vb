Imports System.Data.SQLite
Imports System.IO
Imports System.Security.Cryptography
'     ____          _          _   _              ____ _           _                                                             
'    / ___|___   __| | ___  __| | | |__  _   _   / ___| |_   _ ___| |_ ___ _ __ ____                                             
'   | |   / _ \ / _` |/ _ \/ _` | | '_ \| | | | | |   | | | | / __| __/ _ \ '__|_  /                                             
'   | |__| (_) | (_| |  __/ (_| | | |_) | |_| | | |___| | |_| \__ \ ||  __/ |   / /                                              
'    \____\___/ \__,_|\___|\__,_| |_.__/ \__, |  \____|_|\__,_|___/\__\___|_|  /___|                                             
'                                        |___/                                                  

'    _     _   _                  ____    _ _   _           _                            __   _           _                      
'   | |__ | |_| |_ _ __  ___ _   / / /_ _(_) |_| |__  _   _| |__   ___ ___  _ __ ___    / /__| |_   _ ___| |_ ___ _ __ ______  __
'   | '_ \| __| __| '_ \/ __(_) / / / _` | | __| '_ \| | | | '_ \ / __/ _ \| '_ ` _ \  / / __| | | | / __| __/ _ \ '__|_  /\ \/ /
'   | | | | |_| |_| |_) \__ \_ / / / (_| | | |_| | | | |_| | |_) | (_| (_) | | | | | |/ / (__| | |_| \__ \ ||  __/ |   / /  >  < 
'   |_| |_|\__|\__| .__/|___(_)_/_/ \__, |_|\__|_| |_|\__,_|_.__(_)___\___/|_| |_| |_/_/ \___|_|\__,_|___/\__\___|_|  /___|/_/\_\
'                 |_|               |___/                                                                                        

Public Class Form1
    Const CONNECTION_STR As String = "Data Source="
    Dim openedDabatasePath As String = ""
    Dim titel As String = "Code Box - Snippit Manager - "
#Region "Encryption"
    Public Function EncodeBase64(input As String) As String
        Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input))
    End Function

    Public Function DecodeBase64(input As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input))
    End Function
#End Region

    Private Sub cmd_about_Click(sender As Object, e As EventArgs) Handles cmd_about.Click
        MsgBox("Coded by : Clusterz" & vbNewLine & "FastColoredTextBox by Pavel Torgashov" & vbNewLine &
               "Based on SQLite Database" & vbNewLine & vbNewLine & "Version: 1.1 - 31.12.2017", vbInformation, "About")
    End Sub
    Private Sub cmd_exit_Click(sender As Object, e As EventArgs) Handles cmd_exit.Click
        Application.Exit()
    End Sub
    Private Sub cmd_minimize_Click(sender As Object, e As EventArgs) Handles cmd_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
hauptstart:
        Try
            If Directory.Exists(My.Computer.FileSystem.CurrentDirectory & "\database") Then
                Dim files As String() = System.IO.Directory.GetFiles(My.Computer.FileSystem.CurrentDirectory & "\database", "*_codebox.cbox", System.IO.SearchOption.TopDirectoryOnly)
                If files.Length > 0 Then
                    'Mindestens 1 Container exestiert!
                Else
                    Dim firstDatabaseName = InputBox("Please enter the name for your first Codebox container!", "No container found")
                    If Not firstDatabaseName = "" Then
                        Dim connect As New SQLite.SQLiteConnection
                        connect.ConnectionString = "Data Source=" & My.Computer.FileSystem.CurrentDirectory & "\database\" & firstDatabaseName & "_codebox.cbox"
                        connect.Open()
                        connect.Close()
                        openedDabatasePath = My.Computer.FileSystem.CurrentDirectory & "\database\" & firstDatabaseName & "_codebox.cbox"
                        Me.Text = titel + firstDatabaseName
                    Else
                        GoTo hauptstart
                    End If
                End If
            Else
                Directory.CreateDirectory(My.Computer.FileSystem.CurrentDirectory & "\database")
                MsgBox("Created database folder for first startup.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error on startup")
        End Try
    End Sub

    Private Sub cmd_open_Click(sender As Object, e As EventArgs) Handles cmd_open.Click
        If fd_open.ShowDialog = DialogResult.OK Then
            openedDabatasePath = fd_open.FileName
            ReadDatabase(fd_open.FileName)
        End If
    End Sub
    Function ReadDatabase(ByVal path As String)
        Try
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = CONNECTION_STR & path
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT * FROM Main"
            Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
            lb_snippits.Items.Clear()
            While SQLreader.Read()
                lb_snippits.Items.Add(String.Format("{0}", SQLreader(0)))
            End While
            SQLcommand.Dispose()
            SQLconnect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error while reading")
        End Try
    End Function
    Function ReadSourceCode(ByVal path As String, ByVal name As String)
        Try
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = CONNECTION_STR & path
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "SELECT * FROM Main Where Name = '" & name & "'" 'Hier muss was getan werden. Komischerweise hat SQLite Probleme mit dem Standard MySQL Syntax
            Dim SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
            While SQLreader.Read()
                code_new.Language = FastColoredTextBoxNS.Language.VB
                code_new.Text = DecodeBase64(SQLreader(1))
            End While
            SQLcommand.Dispose()
            SQLconnect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error while reading")
        End Try
    End Function
    Function UpdateSourceCode(ByVal path As String, ByVal name As String)
        Try
            Dim base64Encoded As String = EncodeBase64(code_new.Text)
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = CONNECTION_STR & path
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "UPDATE Main SET SRC = '" & base64Encoded & "' WHERE name = '" & name & "'"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
            SQLconnect.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error while saving")
        End Try
    End Function
    Function DeleteSourceCode(ByVal path As String, ByVal name As String)
        Try
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = CONNECTION_STR & path
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "DELETE FROM Main WHERE Name = '" & name & "'"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
            SQLconnect.Close()
            code_new.Text = ""
            lb_snippits.Items.Remove(lb_snippits.SelectedItem)
        Catch ex As Exception

        End Try
    End Function
    Function AddSourceCode(ByVal path As String, ByVal name As String, ByVal src As String)
        Try
            Dim base64Encoded As String = EncodeBase64(src)
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = CONNECTION_STR & path
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "INSERT INTO Main (Name,SRC) VALUES ('" & name & "','" & base64Encoded & "')"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
            SQLconnect.Close()
        Catch ex As Exception

        End Try
    End Function
    Private Sub lb_snippits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_snippits.SelectedIndexChanged
        ReadSourceCode(openedDabatasePath, lb_snippits.SelectedItem.ToString)
    End Sub

    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click
        Try
            If openedDabatasePath = "" Then
                MsgBox("No database opened!")
            Else
                UpdateSourceCode(openedDabatasePath, lb_snippits.SelectedItem.ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error while updating")
        End Try
    End Sub

    Private Sub cmd_delete_Click(sender As Object, e As EventArgs) Handles cmd_delete.Click
        Try
            If openedDabatasePath = "" Then
                MsgBox("No database opened!")
            Else
                DeleteSourceCode(openedDabatasePath, lb_snippits.SelectedItem.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click
        Try
            If Not txt_search.Text = "" Then
                For Each item In lb_snippits.Items
                    If item = txt_search.Text Then
                        lb_snippits.SelectedIndex = lb_snippits.FindStringExact(txt_search.Text)
                        ReadSourceCode(openedDabatasePath, lb_snippits.SelectedItem.ToString)
                    End If
                Next
            Else
                MsgBox("You have to enter a search string!", vbExclamation, "Warning!")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmd_newsnippit_Click(sender As Object, e As EventArgs) Handles cmd_newsnippit.Click
        Dim newSnippitName As String = InputBox("Please name your new snippit", "New snippit", "new_")
        If newSnippitName = "" Or newSnippitName = "new_" Then
            MsgBox("You did not provide a proper name. example: new_enumeration_wrapping or you have canceled")
        Else
            MsgBox(newSnippitName & " + " & code_new.Text)
            AddSourceCode(openedDabatasePath, newSnippitName, code_new.Text)
        End If
    End Sub

    Private Sub cmd_newcointainer_Click(sender As Object, e As EventArgs) Handles cmd_newcointainer.Click
        If fd_save.ShowDialog = DialogResult.OK Then
            Try
                Dim SQLconnect As New SQLite.SQLiteConnection()
                Dim SQLcommand As SQLiteCommand
                SQLconnect.ConnectionString = CONNECTION_STR & fd_save.FileName
                SQLconnect.Open()
                SQLcommand = SQLconnect.CreateCommand
                SQLcommand.CommandText = "CREATE TABLE Main(Name TEXT, SRC TEXT);"
                SQLcommand.ExecuteNonQuery()
                SQLcommand.Dispose()
                SQLconnect.Close()
                ReadDatabase(fd_save.FileName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error while creating")
            End Try
        End If
    End Sub
End Class
