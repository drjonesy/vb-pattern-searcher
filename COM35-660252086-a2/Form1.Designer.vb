<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtLoad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.checkCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.cbFileType = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalResults = New System.Windows.Forms.Label()
        Me.lblTotalSeconds = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLoad
        '
        Me.txtLoad.Location = New System.Drawing.Point(12, 34)
        Me.txtLoad.Name = "txtLoad"
        Me.txtLoad.Size = New System.Drawing.Size(398, 20)
        Me.txtLoad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Location"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(414, 32)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(77, 23)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(414, 62)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(264, 65)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(146, 20)
        Me.txtSearch.TabIndex = 4
        '
        'checkCaseSensitive
        '
        Me.checkCaseSensitive.AutoSize = True
        Me.checkCaseSensitive.Location = New System.Drawing.Point(153, 66)
        Me.checkCaseSensitive.Name = "checkCaseSensitive"
        Me.checkCaseSensitive.Size = New System.Drawing.Size(96, 17)
        Me.checkCaseSensitive.TabIndex = 5
        Me.checkCaseSensitive.Text = "Case Sensitive"
        Me.checkCaseSensitive.UseVisualStyleBackColor = True
        '
        'cbFileType
        '
        Me.cbFileType.FormattingEnabled = True
        Me.cbFileType.Items.AddRange(New Object() {"*.txt", "*.html", "*.xml", "*.*"})
        Me.cbFileType.Location = New System.Drawing.Point(12, 65)
        Me.cbFileType.Name = "cbFileType"
        Me.cbFileType.Size = New System.Drawing.Size(121, 21)
        Me.cbFileType.TabIndex = 6
        Me.cbFileType.Text = "*.*"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(12, 93)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(479, 118)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total Results: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Loaded Files in Seconds: "
        '
        'lblTotalResults
        '
        Me.lblTotalResults.AutoSize = True
        Me.lblTotalResults.Location = New System.Drawing.Point(97, 218)
        Me.lblTotalResults.Name = "lblTotalResults"
        Me.lblTotalResults.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalResults.TabIndex = 10
        Me.lblTotalResults.Text = "0"
        '
        'lblTotalSeconds
        '
        Me.lblTotalSeconds.AutoSize = True
        Me.lblTotalSeconds.Location = New System.Drawing.Point(316, 218)
        Me.lblTotalSeconds.Name = "lblTotalSeconds"
        Me.lblTotalSeconds.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalSeconds.TabIndex = 11
        Me.lblTotalSeconds.Text = "0.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 258)
        Me.Controls.Add(Me.lblTotalSeconds)
        Me.Controls.Add(Me.lblTotalResults)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cbFileType)
        Me.Controls.Add(Me.checkCaseSensitive)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLoad)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLoad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents checkCaseSensitive As CheckBox
    Friend WithEvents cbFileType As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalResults As Label
    Friend WithEvents lblTotalSeconds As Label
End Class
