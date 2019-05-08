<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpotifyCheckForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpotifyCheckForm))
        Me.FormSkin1 = New FlatUI.FormSkin()
        Me.FlatLabel2 = New FlatUI.FlatLabel()
        Me.FlatLabel1 = New FlatUI.FlatLabel()
        Me.ProgressBar = New FlatUI.FlatProgressBar()
        Me.WaitLabel = New FlatUI.FlatLabel()
        Me.FlatStatusBar1 = New FlatUI.FlatStatusBar()
        Me.StartChecking = New FlatUI.FlatButton()
        Me.TopMostToggle = New FlatUI.FlatCheckBox()
        Me.Hits = New FlatUI.FlatLabel()
        Me.CheckedLabel = New FlatUI.FlatLabel()
        Me.AmountOfThreads = New FlatUI.FlatNumeric()
        Me.ThreadsLabel = New FlatUI.FlatLabel()
        Me.ClearHitsButton = New FlatUI.FlatButton()
        Me.SaveHitsButton = New FlatUI.FlatButton()
        Me.Minimize = New FlatUI.FlatMini()
        Me.Close = New FlatUI.FlatClose()
        Me.AmountLoaded = New FlatUI.FlatLabel()
        Me.LoadedCombosLabel = New FlatUI.FlatLabel()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.EmailUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Subscription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Renew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LoadComboButton = New FlatUI.FlatButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.ProgressBar)
        Me.FormSkin1.Controls.Add(Me.WaitLabel)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Controls.Add(Me.StartChecking)
        Me.FormSkin1.Controls.Add(Me.TopMostToggle)
        Me.FormSkin1.Controls.Add(Me.Hits)
        Me.FormSkin1.Controls.Add(Me.CheckedLabel)
        Me.FormSkin1.Controls.Add(Me.AmountOfThreads)
        Me.FormSkin1.Controls.Add(Me.ThreadsLabel)
        Me.FormSkin1.Controls.Add(Me.ClearHitsButton)
        Me.FormSkin1.Controls.Add(Me.SaveHitsButton)
        Me.FormSkin1.Controls.Add(Me.Minimize)
        Me.FormSkin1.Controls.Add(Me.Close)
        Me.FormSkin1.Controls.Add(Me.AmountLoaded)
        Me.FormSkin1.Controls.Add(Me.LoadedCombosLabel)
        Me.FormSkin1.Controls.Add(Me.ListView)
        Me.FormSkin1.Controls.Add(Me.LoadComboButton)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(665, 375)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Spotify Checker"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(137, 289)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(17, 20)
        Me.FlatLabel2.TabIndex = 21
        Me.FlatLabel2.Text = "0"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(137, 263)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(17, 20)
        Me.FlatLabel1.TabIndex = 20
        Me.FlatLabel1.Text = "0"
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ProgressBar.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ProgressBar.Location = New System.Drawing.Point(679, 3)
        Me.ProgressBar.Maximum = 100
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Pattern = True
        Me.ProgressBar.PercentSign = False
        Me.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ProgressBar.ShowBalloon = True
        Me.ProgressBar.Size = New System.Drawing.Size(378, 42)
        Me.ProgressBar.TabIndex = 19
        Me.ProgressBar.Text = "ProgressBar"
        Me.ProgressBar.Value = 0
        '
        'WaitLabel
        '
        Me.WaitLabel.AutoSize = True
        Me.WaitLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.WaitLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaitLabel.ForeColor = System.Drawing.Color.White
        Me.WaitLabel.Location = New System.Drawing.Point(564, 356)
        Me.WaitLabel.Name = "WaitLabel"
        Me.WaitLabel.Size = New System.Drawing.Size(97, 15)
        Me.WaitLabel.TabIndex = 18
        Me.WaitLabel.Text = "Waiting to start..."
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 352)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(665, 23)
        Me.FlatStatusBar1.TabIndex = 17
        Me.FlatStatusBar1.Text = "Created By Salt"
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'StartChecking
        '
        Me.StartChecking.BackColor = System.Drawing.Color.Transparent
        Me.StartChecking.BaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.StartChecking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartChecking.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StartChecking.Location = New System.Drawing.Point(23, 312)
        Me.StartChecking.Name = "StartChecking"
        Me.StartChecking.Rounded = False
        Me.StartChecking.Size = New System.Drawing.Size(129, 32)
        Me.StartChecking.TabIndex = 16
        Me.StartChecking.Text = "Start"
        Me.StartChecking.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TopMostToggle
        '
        Me.TopMostToggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TopMostToggle.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TopMostToggle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.TopMostToggle.Checked = False
        Me.TopMostToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TopMostToggle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TopMostToggle.Location = New System.Drawing.Point(521, 17)
        Me.TopMostToggle.Name = "TopMostToggle"
        Me.TopMostToggle.Options = FlatUI.FlatCheckBox._Options.Style1
        Me.TopMostToggle.Size = New System.Drawing.Size(87, 22)
        Me.TopMostToggle.TabIndex = 15
        Me.TopMostToggle.Text = "TopMost"
        '
        'Hits
        '
        Me.Hits.AutoSize = True
        Me.Hits.BackColor = System.Drawing.Color.Transparent
        Me.Hits.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hits.ForeColor = System.Drawing.Color.White
        Me.Hits.Location = New System.Drawing.Point(21, 286)
        Me.Hits.Name = "Hits"
        Me.Hits.Size = New System.Drawing.Size(38, 20)
        Me.Hits.TabIndex = 13
        Me.Hits.Text = "Hits:"
        '
        'CheckedLabel
        '
        Me.CheckedLabel.AutoSize = True
        Me.CheckedLabel.BackColor = System.Drawing.Color.Transparent
        Me.CheckedLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedLabel.ForeColor = System.Drawing.Color.White
        Me.CheckedLabel.Location = New System.Drawing.Point(21, 262)
        Me.CheckedLabel.Name = "CheckedLabel"
        Me.CheckedLabel.Size = New System.Drawing.Size(68, 20)
        Me.CheckedLabel.TabIndex = 11
        Me.CheckedLabel.Text = "Checked:"
        '
        'AmountOfThreads
        '
        Me.AmountOfThreads.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.AmountOfThreads.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.AmountOfThreads.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.AmountOfThreads.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AmountOfThreads.ForeColor = System.Drawing.Color.White
        Me.AmountOfThreads.Location = New System.Drawing.Point(25, 199)
        Me.AmountOfThreads.Maximum = CType(10, Long)
        Me.AmountOfThreads.Minimum = CType(1, Long)
        Me.AmountOfThreads.Name = "AmountOfThreads"
        Me.AmountOfThreads.Size = New System.Drawing.Size(129, 30)
        Me.AmountOfThreads.TabIndex = 10
        Me.AmountOfThreads.Value = CType(1, Long)
        '
        'ThreadsLabel
        '
        Me.ThreadsLabel.AutoSize = True
        Me.ThreadsLabel.BackColor = System.Drawing.Color.Transparent
        Me.ThreadsLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreadsLabel.ForeColor = System.Drawing.Color.White
        Me.ThreadsLabel.Location = New System.Drawing.Point(29, 172)
        Me.ThreadsLabel.Name = "ThreadsLabel"
        Me.ThreadsLabel.Size = New System.Drawing.Size(123, 20)
        Me.ThreadsLabel.TabIndex = 9
        Me.ThreadsLabel.Text = "Threads (Max 10)"
        '
        'ClearHitsButton
        '
        Me.ClearHitsButton.BackColor = System.Drawing.Color.Transparent
        Me.ClearHitsButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClearHitsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearHitsButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ClearHitsButton.Location = New System.Drawing.Point(25, 135)
        Me.ClearHitsButton.Name = "ClearHitsButton"
        Me.ClearHitsButton.Rounded = False
        Me.ClearHitsButton.Size = New System.Drawing.Size(129, 32)
        Me.ClearHitsButton.TabIndex = 7
        Me.ClearHitsButton.Text = "Clear Hits"
        Me.ClearHitsButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'SaveHitsButton
        '
        Me.SaveHitsButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveHitsButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.SaveHitsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveHitsButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SaveHitsButton.Location = New System.Drawing.Point(25, 97)
        Me.SaveHitsButton.Name = "SaveHitsButton"
        Me.SaveHitsButton.Rounded = False
        Me.SaveHitsButton.Size = New System.Drawing.Size(129, 32)
        Me.SaveHitsButton.TabIndex = 6
        Me.SaveHitsButton.Text = "Save Hits"
        Me.SaveHitsButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Minimize
        '
        Me.Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimize.BackColor = System.Drawing.Color.White
        Me.Minimize.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Minimize.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.Minimize.Location = New System.Drawing.Point(611, 16)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(18, 18)
        Me.Minimize.TabIndex = 5
        Me.Minimize.Text = "FlatMini1"
        Me.Minimize.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Close
        '
        Me.Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close.BackColor = System.Drawing.Color.White
        Me.Close.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Close.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.Close.Location = New System.Drawing.Point(635, 17)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(18, 18)
        Me.Close.TabIndex = 4
        Me.Close.Text = "FlatClose1"
        Me.Close.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'AmountLoaded
        '
        Me.AmountLoaded.AutoSize = True
        Me.AmountLoaded.BackColor = System.Drawing.Color.Transparent
        Me.AmountLoaded.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLoaded.ForeColor = System.Drawing.Color.White
        Me.AmountLoaded.Location = New System.Drawing.Point(137, 237)
        Me.AmountLoaded.Name = "AmountLoaded"
        Me.AmountLoaded.Size = New System.Drawing.Size(17, 20)
        Me.AmountLoaded.TabIndex = 3
        Me.AmountLoaded.Text = "0"
        '
        'LoadedCombosLabel
        '
        Me.LoadedCombosLabel.AutoSize = True
        Me.LoadedCombosLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoadedCombosLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadedCombosLabel.ForeColor = System.Drawing.Color.White
        Me.LoadedCombosLabel.Location = New System.Drawing.Point(21, 237)
        Me.LoadedCombosLabel.Name = "LoadedCombosLabel"
        Me.LoadedCombosLabel.Size = New System.Drawing.Size(121, 20)
        Me.LoadedCombosLabel.TabIndex = 2
        Me.LoadedCombosLabel.Text = "Loaded Combos:"
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EmailUser, Me.Password, Me.Subscription, Me.Renew})
        Me.ListView.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.ForeColor = System.Drawing.Color.White
        Me.ListView.Location = New System.Drawing.Point(182, 58)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(471, 288)
        Me.ListView.TabIndex = 1
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'EmailUser
        '
        Me.EmailUser.Text = "Email/Username"
        Me.EmailUser.Width = 127
        '
        'Password
        '
        Me.Password.Text = "Password"
        Me.Password.Width = 107
        '
        'Subscription
        '
        Me.Subscription.Text = "Subscription"
        Me.Subscription.Width = 117
        '
        'Renew
        '
        Me.Renew.Text = "Renewal"
        Me.Renew.Width = 120
        '
        'LoadComboButton
        '
        Me.LoadComboButton.BackColor = System.Drawing.Color.Transparent
        Me.LoadComboButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.LoadComboButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoadComboButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LoadComboButton.Location = New System.Drawing.Point(25, 58)
        Me.LoadComboButton.Name = "LoadComboButton"
        Me.LoadComboButton.Rounded = False
        Me.LoadComboButton.Size = New System.Drawing.Size(129, 32)
        Me.LoadComboButton.TabIndex = 0
        Me.LoadComboButton.Text = "Load Combo"
        Me.LoadComboButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Timer1
        '
        '
        'SpotifyCheckForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 375)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SpotifyCheckForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spotify Checker"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FlatUI.FormSkin
    Friend WithEvents FlatStatusBar1 As FlatUI.FlatStatusBar
    Friend WithEvents StartChecking As FlatUI.FlatButton
    Friend WithEvents TopMostToggle As FlatUI.FlatCheckBox
    Friend WithEvents Hits As FlatUI.FlatLabel
    Friend WithEvents CheckedLabel As FlatUI.FlatLabel
    Friend WithEvents AmountOfThreads As FlatUI.FlatNumeric
    Friend WithEvents ThreadsLabel As FlatUI.FlatLabel
    Friend WithEvents ClearHitsButton As FlatUI.FlatButton
    Friend WithEvents SaveHitsButton As FlatUI.FlatButton
    Friend WithEvents Minimize As FlatUI.FlatMini
    Friend WithEvents Close As FlatUI.FlatClose
    Friend WithEvents AmountLoaded As FlatUI.FlatLabel
    Friend WithEvents LoadedCombosLabel As FlatUI.FlatLabel
    Friend WithEvents ListView As ListView
    Friend WithEvents EmailUser As ColumnHeader
    Friend WithEvents Password As ColumnHeader
    Friend WithEvents Subscription As ColumnHeader
    Friend WithEvents Renew As ColumnHeader
    Friend WithEvents LoadComboButton As FlatUI.FlatButton
    Friend WithEvents WaitLabel As FlatUI.FlatLabel
    Friend WithEvents ProgressBar As FlatUI.FlatProgressBar
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FlatLabel2 As FlatUI.FlatLabel
    Friend WithEvents FlatLabel1 As FlatUI.FlatLabel
End Class
