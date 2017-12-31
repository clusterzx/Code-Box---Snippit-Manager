<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim cmd_settings As Code_Box___Snippit_Manager.InfluxButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim InfluxGroupBox1 As Code_Box___Snippit_Manager.InfluxGroupBox
        Me.fd_open = New System.Windows.Forms.OpenFileDialog()
        Me.InfluxThemeControl1 = New Code_Box___Snippit_Manager.InfluxThemeControl()
        Me.cmd_search = New Code_Box___Snippit_Manager.InfluxButton()
        Me.txt_search = New Code_Box___Snippit_Manager.InfluxTextBox()
        Me.cmd_newcointainer = New Code_Box___Snippit_Manager.InfluxButton()
        Me.cmd_open = New Code_Box___Snippit_Manager.InfluxButton()
        Me.InfluxGroupBox2 = New Code_Box___Snippit_Manager.InfluxGroupBox()
        Me.panel_new = New System.Windows.Forms.Panel()
        Me.InfluxGroupBox3 = New Code_Box___Snippit_Manager.InfluxGroupBox()
        Me.InfluxLabel4 = New Code_Box___Snippit_Manager.InfluxLabel()
        Me.InfluxLabel3 = New Code_Box___Snippit_Manager.InfluxLabel()
        Me.InfluxLabel2 = New Code_Box___Snippit_Manager.InfluxLabel()
        Me.cmd_newsnippit = New System.Windows.Forms.PictureBox()
        Me.cmd_delete = New System.Windows.Forms.PictureBox()
        Me.cmd_save = New System.Windows.Forms.PictureBox()
        Me.code_new = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.cmd_about = New Code_Box___Snippit_Manager.InfluxButton()
        Me.cmd_minimize = New Code_Box___Snippit_Manager.InfluxButton()
        Me.cmd_exit = New Code_Box___Snippit_Manager.InfluxButton()
        Me.InfluxLabel1 = New Code_Box___Snippit_Manager.InfluxLabel()
        Me.lb_snippits = New Code_Box___Snippit_Manager.InfluxListbox()
        Me.fd_save = New System.Windows.Forms.SaveFileDialog()
        cmd_settings = New Code_Box___Snippit_Manager.InfluxButton()
        InfluxGroupBox1 = New Code_Box___Snippit_Manager.InfluxGroupBox()
        Me.InfluxThemeControl1.SuspendLayout()
        Me.InfluxGroupBox2.SuspendLayout()
        Me.panel_new.SuspendLayout()
        Me.InfluxGroupBox3.SuspendLayout()
        CType(Me.cmd_newsnippit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmd_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmd_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.code_new, System.ComponentModel.ISupportInitialize).BeginInit()
        InfluxGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fd_open
        '
        Me.fd_open.Filter = "Only Code Box container (*.cbox)|*.cbox"
        '
        'InfluxThemeControl1
        '
        Me.InfluxThemeControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.InfluxThemeControl1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.InfluxThemeControl1.Controls.Add(Me.cmd_search)
        Me.InfluxThemeControl1.Controls.Add(Me.txt_search)
        Me.InfluxThemeControl1.Controls.Add(cmd_settings)
        Me.InfluxThemeControl1.Controls.Add(Me.cmd_newcointainer)
        Me.InfluxThemeControl1.Controls.Add(Me.cmd_open)
        Me.InfluxThemeControl1.Controls.Add(Me.InfluxGroupBox2)
        Me.InfluxThemeControl1.Controls.Add(Me.cmd_about)
        Me.InfluxThemeControl1.Controls.Add(Me.cmd_minimize)
        Me.InfluxThemeControl1.Controls.Add(Me.cmd_exit)
        Me.InfluxThemeControl1.Controls.Add(InfluxGroupBox1)
        Me.InfluxThemeControl1.Customization = "NTU1/+Xl5f8="
        Me.InfluxThemeControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfluxThemeControl1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.InfluxThemeControl1.Image = Nothing
        Me.InfluxThemeControl1.Location = New System.Drawing.Point(0, 0)
        Me.InfluxThemeControl1.MinimumSize = New System.Drawing.Size(80, 55)
        Me.InfluxThemeControl1.Movable = True
        Me.InfluxThemeControl1.Name = "InfluxThemeControl1"
        Me.InfluxThemeControl1.NoRounding = False
        Me.InfluxThemeControl1.Sizable = False
        Me.InfluxThemeControl1.Size = New System.Drawing.Size(937, 687)
        Me.InfluxThemeControl1.SmartBounds = True
        Me.InfluxThemeControl1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.InfluxThemeControl1.TabIndex = 0
        Me.InfluxThemeControl1.Text = "Code Box - Snippit Manager"
        Me.InfluxThemeControl1.TransparencyKey = System.Drawing.Color.Empty
        Me.InfluxThemeControl1.Transparent = False
        '
        'cmd_search
        '
        Me.cmd_search.Customization = "TU1N/+Xl5f88PDz/"
        Me.cmd_search.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cmd_search.Image = Nothing
        Me.cmd_search.Location = New System.Drawing.Point(871, 38)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.NoRounding = False
        Me.cmd_search.Size = New System.Drawing.Size(54, 24)
        Me.cmd_search.TabIndex = 4
        Me.cmd_search.Text = "Search"
        Me.cmd_search.Transparent = False
        '
        'txt_search
        '
        Me.txt_search.Customization = "5eXl/0lJSf9RUVH/PDw8/w=="
        Me.txt_search.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt_search.Image = Nothing
        Me.txt_search.Location = New System.Drawing.Point(685, 38)
        Me.txt_search.MaxLength = 32767
        Me.txt_search.Multiline = False
        Me.txt_search.Name = "txt_search"
        Me.txt_search.NoRounding = False
        Me.txt_search.ReadOnly = False
        Me.txt_search.Size = New System.Drawing.Size(184, 24)
        Me.txt_search.TabIndex = 3
        Me.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_search.Transparent = False
        Me.txt_search.UseSystemPasswordChar = False
        '
        'cmd_settings
        '
        cmd_settings.Customization = "TU1N/+Xl5f88PDz/"
        cmd_settings.Font = New System.Drawing.Font("Verdana", 8.0!)
        cmd_settings.Image = Nothing
        cmd_settings.Location = New System.Drawing.Point(229, 31)
        cmd_settings.Name = "cmd_settings"
        cmd_settings.NoRounding = False
        cmd_settings.Size = New System.Drawing.Size(101, 31)
        cmd_settings.TabIndex = 2
        cmd_settings.Text = "Settings"
        cmd_settings.Transparent = False
        '
        'cmd_newcointainer
        '
        Me.cmd_newcointainer.Customization = "TU1N/+Xl5f88PDz/"
        Me.cmd_newcointainer.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cmd_newcointainer.Image = Nothing
        Me.cmd_newcointainer.Location = New System.Drawing.Point(122, 31)
        Me.cmd_newcointainer.Name = "cmd_newcointainer"
        Me.cmd_newcointainer.NoRounding = False
        Me.cmd_newcointainer.Size = New System.Drawing.Size(101, 31)
        Me.cmd_newcointainer.TabIndex = 2
        Me.cmd_newcointainer.Text = "New Container"
        Me.cmd_newcointainer.Transparent = False
        '
        'cmd_open
        '
        Me.cmd_open.Customization = "TU1N/+Xl5f88PDz/"
        Me.cmd_open.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cmd_open.Image = Nothing
        Me.cmd_open.Location = New System.Drawing.Point(10, 31)
        Me.cmd_open.Name = "cmd_open"
        Me.cmd_open.NoRounding = False
        Me.cmd_open.Size = New System.Drawing.Size(105, 31)
        Me.cmd_open.TabIndex = 2
        Me.cmd_open.Text = "Open Container"
        Me.cmd_open.Transparent = False
        '
        'InfluxGroupBox2
        '
        Me.InfluxGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.InfluxGroupBox2.Controls.Add(Me.panel_new)
        Me.InfluxGroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.InfluxGroupBox2.Location = New System.Drawing.Point(229, 66)
        Me.InfluxGroupBox2.Name = "InfluxGroupBox2"
        Me.InfluxGroupBox2.Size = New System.Drawing.Size(702, 612)
        Me.InfluxGroupBox2.TabIndex = 0
        '
        'panel_new
        '
        Me.panel_new.Controls.Add(Me.InfluxGroupBox3)
        Me.panel_new.Controls.Add(Me.code_new)
        Me.panel_new.Location = New System.Drawing.Point(10, 12)
        Me.panel_new.Name = "panel_new"
        Me.panel_new.Size = New System.Drawing.Size(686, 597)
        Me.panel_new.TabIndex = 0
        '
        'InfluxGroupBox3
        '
        Me.InfluxGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.InfluxGroupBox3.Controls.Add(Me.InfluxLabel4)
        Me.InfluxGroupBox3.Controls.Add(Me.InfluxLabel3)
        Me.InfluxGroupBox3.Controls.Add(Me.InfluxLabel2)
        Me.InfluxGroupBox3.Controls.Add(Me.cmd_newsnippit)
        Me.InfluxGroupBox3.Controls.Add(Me.cmd_delete)
        Me.InfluxGroupBox3.Controls.Add(Me.cmd_save)
        Me.InfluxGroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.InfluxGroupBox3.Location = New System.Drawing.Point(9, 518)
        Me.InfluxGroupBox3.Name = "InfluxGroupBox3"
        Me.InfluxGroupBox3.Size = New System.Drawing.Size(669, 74)
        Me.InfluxGroupBox3.TabIndex = 1
        Me.InfluxGroupBox3.Text = "Actions"
        '
        'InfluxLabel4
        '
        Me.InfluxLabel4.AutoSize = True
        Me.InfluxLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.InfluxLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.InfluxLabel4.Location = New System.Drawing.Point(461, 59)
        Me.InfluxLabel4.Name = "InfluxLabel4"
        Me.InfluxLabel4.Size = New System.Drawing.Size(74, 13)
        Me.InfluxLabel4.TabIndex = 1
        Me.InfluxLabel4.Text = "New Snippit"
        '
        'InfluxLabel3
        '
        Me.InfluxLabel3.AutoSize = True
        Me.InfluxLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.InfluxLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.InfluxLabel3.Location = New System.Drawing.Point(286, 59)
        Me.InfluxLabel3.Name = "InfluxLabel3"
        Me.InfluxLabel3.Size = New System.Drawing.Size(87, 13)
        Me.InfluxLabel3.TabIndex = 1
        Me.InfluxLabel3.Text = "Delete Snippit"
        '
        'InfluxLabel2
        '
        Me.InfluxLabel2.AutoSize = True
        Me.InfluxLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.InfluxLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.InfluxLabel2.Location = New System.Drawing.Point(121, 59)
        Me.InfluxLabel2.Name = "InfluxLabel2"
        Me.InfluxLabel2.Size = New System.Drawing.Size(79, 13)
        Me.InfluxLabel2.TabIndex = 1
        Me.InfluxLabel2.Text = "Save Snippit"
        '
        'cmd_newsnippit
        '
        Me.cmd_newsnippit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmd_newsnippit.Image = Global.Code_Box___Snippit_Manager.My.Resources.Resources.add
        Me.cmd_newsnippit.Location = New System.Drawing.Point(478, 16)
        Me.cmd_newsnippit.Name = "cmd_newsnippit"
        Me.cmd_newsnippit.Size = New System.Drawing.Size(40, 40)
        Me.cmd_newsnippit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmd_newsnippit.TabIndex = 0
        Me.cmd_newsnippit.TabStop = False
        '
        'cmd_delete
        '
        Me.cmd_delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmd_delete.Image = Global.Code_Box___Snippit_Manager.My.Resources.Resources.delete
        Me.cmd_delete.Location = New System.Drawing.Point(310, 16)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(40, 40)
        Me.cmd_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmd_delete.TabIndex = 0
        Me.cmd_delete.TabStop = False
        '
        'cmd_save
        '
        Me.cmd_save.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cmd_save.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmd_save.Image = Global.Code_Box___Snippit_Manager.My.Resources.Resources.save
        Me.cmd_save.Location = New System.Drawing.Point(138, 16)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(40, 40)
        Me.cmd_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmd_save.TabIndex = 0
        Me.cmd_save.TabStop = False
        '
        'code_new
        '
        Me.code_new.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.code_new.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.code_new.AutoScrollMinSize = New System.Drawing.Size(195, 14)
        Me.code_new.BackBrush = Nothing
        Me.code_new.BackColor = System.Drawing.Color.DarkGray
        Me.code_new.CharHeight = 14
        Me.code_new.CharWidth = 8
        Me.code_new.CommentPrefix = "'"
        Me.code_new.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.code_new.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.code_new.FoldingIndicatorColor = System.Drawing.Color.ForestGreen
        Me.code_new.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.code_new.ForeColor = System.Drawing.Color.Black
        Me.code_new.IndentBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.code_new.IsReplaceMode = False
        Me.code_new.Language = FastColoredTextBoxNS.Language.VB
        Me.code_new.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.code_new.LineNumberColor = System.Drawing.Color.LimeGreen
        Me.code_new.Location = New System.Drawing.Point(5, 3)
        Me.code_new.Name = "code_new"
        Me.code_new.Paddings = New System.Windows.Forms.Padding(0)
        Me.code_new.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.code_new.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.code_new.ServiceColors = CType(resources.GetObject("code_new.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.code_new.Size = New System.Drawing.Size(674, 509)
        Me.code_new.TabIndex = 0
        Me.code_new.Text = "'Enter your code here"
        Me.code_new.Zoom = 100
        '
        'cmd_about
        '
        Me.cmd_about.Customization = "TU1N/+Xl5f88PDz/"
        Me.cmd_about.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cmd_about.Image = Nothing
        Me.cmd_about.Location = New System.Drawing.Point(871, 6)
        Me.cmd_about.Name = "cmd_about"
        Me.cmd_about.NoRounding = False
        Me.cmd_about.Size = New System.Drawing.Size(14, 15)
        Me.cmd_about.TabIndex = 1
        Me.cmd_about.Text = "?"
        Me.cmd_about.Transparent = False
        '
        'cmd_minimize
        '
        Me.cmd_minimize.Customization = "TU1N/+Xl5f88PDz/"
        Me.cmd_minimize.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cmd_minimize.Image = Nothing
        Me.cmd_minimize.Location = New System.Drawing.Point(891, 6)
        Me.cmd_minimize.Name = "cmd_minimize"
        Me.cmd_minimize.NoRounding = False
        Me.cmd_minimize.Size = New System.Drawing.Size(14, 15)
        Me.cmd_minimize.TabIndex = 1
        Me.cmd_minimize.Text = "_"
        Me.cmd_minimize.Transparent = False
        '
        'cmd_exit
        '
        Me.cmd_exit.Customization = "TU1N/+Xl5f88PDz/"
        Me.cmd_exit.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cmd_exit.Image = Nothing
        Me.cmd_exit.Location = New System.Drawing.Point(911, 6)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.NoRounding = False
        Me.cmd_exit.Size = New System.Drawing.Size(14, 15)
        Me.cmd_exit.TabIndex = 1
        Me.cmd_exit.Text = "X"
        Me.cmd_exit.Transparent = False
        '
        'InfluxGroupBox1
        '
        InfluxGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        InfluxGroupBox1.Controls.Add(Me.InfluxLabel1)
        InfluxGroupBox1.Controls.Add(Me.lb_snippits)
        InfluxGroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        InfluxGroupBox1.Location = New System.Drawing.Point(10, 66)
        InfluxGroupBox1.Name = "InfluxGroupBox1"
        InfluxGroupBox1.Size = New System.Drawing.Size(213, 612)
        InfluxGroupBox1.TabIndex = 0
        '
        'InfluxLabel1
        '
        Me.InfluxLabel1.AutoSize = True
        Me.InfluxLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.InfluxLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.InfluxLabel1.Location = New System.Drawing.Point(3, 0)
        Me.InfluxLabel1.Name = "InfluxLabel1"
        Me.InfluxLabel1.Size = New System.Drawing.Size(52, 13)
        Me.InfluxLabel1.TabIndex = 1
        Me.InfluxLabel1.Text = "Snippits"
        '
        'lb_snippits
        '
        Me.lb_snippits.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lb_snippits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lb_snippits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lb_snippits.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lb_snippits.ForeColor = System.Drawing.Color.Black
        Me.lb_snippits.FormattingEnabled = True
        Me.lb_snippits.IntegralHeight = False
        Me.lb_snippits.ItemHeight = 22
        Me.lb_snippits.ItemImage = Nothing
        Me.lb_snippits.Location = New System.Drawing.Point(6, 15)
        Me.lb_snippits.Name = "lb_snippits"
        Me.lb_snippits.Size = New System.Drawing.Size(204, 589)
        Me.lb_snippits.TabIndex = 0
        '
        'fd_save
        '
        Me.fd_save.Filter = "Only Code Box container (*.cbox)|*.cbox"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 687)
        Me.Controls.Add(Me.InfluxThemeControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(80, 55)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code Box - Snippit Manager"
        Me.InfluxThemeControl1.ResumeLayout(False)
        Me.InfluxGroupBox2.ResumeLayout(False)
        Me.panel_new.ResumeLayout(False)
        Me.InfluxGroupBox3.ResumeLayout(False)
        Me.InfluxGroupBox3.PerformLayout()
        CType(Me.cmd_newsnippit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmd_delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmd_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.code_new, System.ComponentModel.ISupportInitialize).EndInit()
        InfluxGroupBox1.ResumeLayout(False)
        InfluxGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InfluxThemeControl1 As InfluxThemeControl
    Friend WithEvents InfluxGroupBox2 As InfluxGroupBox
    Friend WithEvents cmd_minimize As InfluxButton
    Friend WithEvents cmd_exit As InfluxButton
    Friend WithEvents panel_new As Panel
    Friend WithEvents code_new As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents InfluxGroupBox3 As InfluxGroupBox
    Friend WithEvents cmd_newcointainer As InfluxButton
    Friend WithEvents cmd_open As InfluxButton
    Friend WithEvents cmd_about As InfluxButton
    Friend WithEvents InfluxLabel1 As InfluxLabel
    Friend WithEvents lb_snippits As InfluxListbox
    Friend WithEvents fd_open As OpenFileDialog
    Friend WithEvents cmd_delete As PictureBox
    Friend WithEvents cmd_save As PictureBox
    Friend WithEvents cmd_search As InfluxButton
    Friend WithEvents txt_search As InfluxTextBox
    Friend WithEvents InfluxLabel4 As InfluxLabel
    Friend WithEvents InfluxLabel3 As InfluxLabel
    Friend WithEvents InfluxLabel2 As InfluxLabel
    Friend WithEvents cmd_newsnippit As PictureBox
    Friend WithEvents fd_save As SaveFileDialog
End Class
