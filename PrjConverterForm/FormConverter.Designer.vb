<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConverter
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtKilometers = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenüüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SulgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(153, 56)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(198, 28)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Teisenda"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtKilometers
        '
        Me.txtKilometers.Location = New System.Drawing.Point(153, 30)
        Me.txtKilometers.Name = "txtKilometers"
        Me.txtKilometers.Size = New System.Drawing.Size(198, 20)
        Me.txtKilometers.TabIndex = 1
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(153, 90)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(198, 20)
        Me.txtMiles.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sisesta kilomeetrid:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vastus miilides:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(181, 145)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(48, 13)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Kellaaeg"
        '
        'timerClock
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenüüToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(424, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenüüToolStripMenuItem
        '
        Me.MenüüToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SulgeToolStripMenuItem})
        Me.MenüüToolStripMenuItem.Name = "MenüüToolStripMenuItem"
        Me.MenüüToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.MenüüToolStripMenuItem.Text = "Menüü"
        '
        'SulgeToolStripMenuItem
        '
        Me.SulgeToolStripMenuItem.Name = "SulgeToolStripMenuItem"
        Me.SulgeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SulgeToolStripMenuItem.Text = "Sulge"
        '
        'FormConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 199)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtKilometers)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormConverter"
        Me.Text = "Distantsi teisendaja"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents txtKilometers As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents timerClock As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenüüToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SulgeToolStripMenuItem As ToolStripMenuItem
End Class
