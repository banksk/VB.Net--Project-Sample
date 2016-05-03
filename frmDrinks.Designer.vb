<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrinks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDrinks))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoWater = New System.Windows.Forms.RadioButton()
        Me.rdoDietDew = New System.Windows.Forms.RadioButton()
        Me.rdoDietCoke = New System.Windows.Forms.RadioButton()
        Me.rdoDew = New System.Windows.Forms.RadioButton()
        Me.rdoSprite = New System.Windows.Forms.RadioButton()
        Me.rdoPepper = New System.Windows.Forms.RadioButton()
        Me.rdoPepsi = New System.Windows.Forms.RadioButton()
        Me.rdoCoke = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdoWater)
        Me.GroupBox1.Controls.Add(Me.rdoDietDew)
        Me.GroupBox1.Controls.Add(Me.rdoDietCoke)
        Me.GroupBox1.Controls.Add(Me.rdoDew)
        Me.GroupBox1.Controls.Add(Me.rdoSprite)
        Me.GroupBox1.Controls.Add(Me.rdoPepper)
        Me.GroupBox1.Controls.Add(Me.rdoPepsi)
        Me.GroupBox1.Controls.Add(Me.rdoCoke)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(126, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 287)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drinks"
        '
        'rdoWater
        '
        Me.rdoWater.AutoSize = True
        Me.rdoWater.Location = New System.Drawing.Point(7, 200)
        Me.rdoWater.Name = "rdoWater"
        Me.rdoWater.Size = New System.Drawing.Size(147, 17)
        Me.rdoWater.TabIndex = 7
        Me.rdoWater.TabStop = True
        Me.rdoWater.Text = "Bottled Water - $0.99"
        Me.rdoWater.UseVisualStyleBackColor = True
        '
        'rdoDietDew
        '
        Me.rdoDietDew.AutoSize = True
        Me.rdoDietDew.Location = New System.Drawing.Point(7, 176)
        Me.rdoDietDew.Name = "rdoDietDew"
        Me.rdoDietDew.Size = New System.Drawing.Size(177, 17)
        Me.rdoDietDew.TabIndex = 6
        Me.rdoDietDew.TabStop = True
        Me.rdoDietDew.Text = "Diet Mountain Dew - $1.99"
        Me.rdoDietDew.UseVisualStyleBackColor = True
        '
        'rdoDietCoke
        '
        Me.rdoDietCoke.AutoSize = True
        Me.rdoDietCoke.Location = New System.Drawing.Point(7, 152)
        Me.rdoDietCoke.Name = "rdoDietCoke"
        Me.rdoDietCoke.Size = New System.Drawing.Size(125, 17)
        Me.rdoDietCoke.TabIndex = 5
        Me.rdoDietCoke.TabStop = True
        Me.rdoDietCoke.Text = "Diet Coke - $1.99"
        Me.rdoDietCoke.UseVisualStyleBackColor = True
        '
        'rdoDew
        '
        Me.rdoDew.AutoSize = True
        Me.rdoDew.Location = New System.Drawing.Point(7, 128)
        Me.rdoDew.Name = "rdoDew"
        Me.rdoDew.Size = New System.Drawing.Size(150, 17)
        Me.rdoDew.TabIndex = 4
        Me.rdoDew.TabStop = True
        Me.rdoDew.Text = "Mountain Dew - $1.99"
        Me.rdoDew.UseVisualStyleBackColor = True
        '
        'rdoSprite
        '
        Me.rdoSprite.AutoSize = True
        Me.rdoSprite.Location = New System.Drawing.Point(7, 104)
        Me.rdoSprite.Name = "rdoSprite"
        Me.rdoSprite.Size = New System.Drawing.Size(102, 17)
        Me.rdoSprite.TabIndex = 3
        Me.rdoSprite.TabStop = True
        Me.rdoSprite.Text = "Sprite - $1.99"
        Me.rdoSprite.UseVisualStyleBackColor = True
        '
        'rdoPepper
        '
        Me.rdoPepper.AutoSize = True
        Me.rdoPepper.Location = New System.Drawing.Point(7, 80)
        Me.rdoPepper.Name = "rdoPepper"
        Me.rdoPepper.Size = New System.Drawing.Size(126, 17)
        Me.rdoPepper.TabIndex = 2
        Me.rdoPepper.TabStop = True
        Me.rdoPepper.Text = "Dr.Pepper - $1.99"
        Me.rdoPepper.UseVisualStyleBackColor = True
        '
        'rdoPepsi
        '
        Me.rdoPepsi.AutoSize = True
        Me.rdoPepsi.Location = New System.Drawing.Point(7, 56)
        Me.rdoPepsi.Name = "rdoPepsi"
        Me.rdoPepsi.Size = New System.Drawing.Size(100, 17)
        Me.rdoPepsi.TabIndex = 1
        Me.rdoPepsi.TabStop = True
        Me.rdoPepsi.Text = "Pepsi - $1.99"
        Me.rdoPepsi.UseVisualStyleBackColor = True
        '
        'rdoCoke
        '
        Me.rdoCoke.AutoSize = True
        Me.rdoCoke.Location = New System.Drawing.Point(6, 32)
        Me.rdoCoke.Name = "rdoCoke"
        Me.rdoCoke.Size = New System.Drawing.Size(98, 17)
        Me.rdoCoke.TabIndex = 0
        Me.rdoCoke.TabStop = True
        Me.rdoCoke.Text = "Coke - $1.99"
        Me.rdoCoke.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(329, 327)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 39)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(198, 327)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 39)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add to Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.Location = New System.Drawing.Point(66, 327)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 39)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmDrinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(459, 387)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDrinks"
        Me.Text = "frmDrinks"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoPepper As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPepsi As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCoke As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDew As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSprite As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWater As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDietDew As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDietCoke As System.Windows.Forms.RadioButton
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
