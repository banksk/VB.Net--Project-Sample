<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSides
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSides))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoOnionRings = New System.Windows.Forms.RadioButton()
        Me.rdoSteakFries = New System.Windows.Forms.RadioButton()
        Me.rdoFries = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdoOnionRings)
        Me.GroupBox1.Controls.Add(Me.rdoSteakFries)
        Me.GroupBox1.Controls.Add(Me.rdoFries)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(109, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sides"
        '
        'rdoOnionRings
        '
        Me.rdoOnionRings.AutoSize = True
        Me.rdoOnionRings.Location = New System.Drawing.Point(7, 114)
        Me.rdoOnionRings.Name = "rdoOnionRings"
        Me.rdoOnionRings.Size = New System.Drawing.Size(138, 17)
        Me.rdoOnionRings.TabIndex = 2
        Me.rdoOnionRings.TabStop = True
        Me.rdoOnionRings.Text = "Onion Rings - $2.50"
        Me.rdoOnionRings.UseVisualStyleBackColor = True
        '
        'rdoSteakFries
        '
        Me.rdoSteakFries.AutoSize = True
        Me.rdoSteakFries.Location = New System.Drawing.Point(7, 74)
        Me.rdoSteakFries.Name = "rdoSteakFries"
        Me.rdoSteakFries.Size = New System.Drawing.Size(133, 17)
        Me.rdoSteakFries.TabIndex = 1
        Me.rdoSteakFries.TabStop = True
        Me.rdoSteakFries.Text = "Steak Fries - $1.99"
        Me.rdoSteakFries.UseVisualStyleBackColor = True
        '
        'rdoFries
        '
        Me.rdoFries.AutoSize = True
        Me.rdoFries.Location = New System.Drawing.Point(7, 34)
        Me.rdoFries.Name = "rdoFries"
        Me.rdoFries.Size = New System.Drawing.Size(96, 17)
        Me.rdoFries.TabIndex = 0
        Me.rdoFries.TabStop = True
        Me.rdoFries.Text = "Fries - $1.29"
        Me.rdoFries.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(24, 318)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 39)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(156, 318)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 39)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add to Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(287, 318)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 39)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(401, 384)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSides"
        Me.Text = "frmSides"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoOnionRings As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSteakFries As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFries As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
