<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBurgers))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBBQ = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkKetchup = New System.Windows.Forms.CheckBox()
        Me.chkJalapeno = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkTomatoes = New System.Windows.Forms.CheckBox()
        Me.chkPickles = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoBacon = New System.Windows.Forms.RadioButton()
        Me.rdoCheese = New System.Windows.Forms.RadioButton()
        Me.rdoHamburger = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Location = New System.Drawing.Point(405, 452)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 40)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add to Order"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(174, 452)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 40)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.Location = New System.Drawing.Point(631, 452)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 40)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.chkBBQ)
        Me.GroupBox2.Controls.Add(Me.chkMustard)
        Me.GroupBox2.Controls.Add(Me.chkKetchup)
        Me.GroupBox2.Controls.Add(Me.chkJalapeno)
        Me.GroupBox2.Controls.Add(Me.chkMushrooms)
        Me.GroupBox2.Controls.Add(Me.chkOnions)
        Me.GroupBox2.Controls.Add(Me.chkTomatoes)
        Me.GroupBox2.Controls.Add(Me.chkPickles)
        Me.GroupBox2.Controls.Add(Me.chkLettuce)
        Me.GroupBox2.Controls.Add(Me.chkMayo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox2.Location = New System.Drawing.Point(429, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 289)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings"
        '
        'chkBBQ
        '
        Me.chkBBQ.AutoSize = True
        Me.chkBBQ.Location = New System.Drawing.Point(6, 248)
        Me.chkBBQ.Name = "chkBBQ"
        Me.chkBBQ.Size = New System.Drawing.Size(91, 17)
        Me.chkBBQ.TabIndex = 10
        Me.chkBBQ.Text = "BBQ Sauce"
        Me.chkBBQ.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(7, 225)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(71, 17)
        Me.chkMustard.TabIndex = 9
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkKetchup
        '
        Me.chkKetchup.AutoSize = True
        Me.chkKetchup.Location = New System.Drawing.Point(7, 202)
        Me.chkKetchup.Name = "chkKetchup"
        Me.chkKetchup.Size = New System.Drawing.Size(73, 17)
        Me.chkKetchup.TabIndex = 8
        Me.chkKetchup.Text = "Ketchup"
        Me.chkKetchup.UseVisualStyleBackColor = True
        '
        'chkJalapeno
        '
        Me.chkJalapeno.AutoSize = True
        Me.chkJalapeno.Location = New System.Drawing.Point(7, 179)
        Me.chkJalapeno.Name = "chkJalapeno"
        Me.chkJalapeno.Size = New System.Drawing.Size(127, 17)
        Me.chkJalapeno.TabIndex = 6
        Me.chkJalapeno.Text = "Jalapeno Peppers"
        Me.chkJalapeno.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Location = New System.Drawing.Point(7, 155)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(89, 17)
        Me.chkMushrooms.TabIndex = 5
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Location = New System.Drawing.Point(7, 131)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(65, 17)
        Me.chkOnions.TabIndex = 4
        Me.chkOnions.Text = "Onions"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'chkTomatoes
        '
        Me.chkTomatoes.AutoSize = True
        Me.chkTomatoes.Location = New System.Drawing.Point(7, 107)
        Me.chkTomatoes.Name = "chkTomatoes"
        Me.chkTomatoes.Size = New System.Drawing.Size(81, 17)
        Me.chkTomatoes.TabIndex = 3
        Me.chkTomatoes.Text = "Tomatoes"
        Me.chkTomatoes.UseVisualStyleBackColor = True
        '
        'chkPickles
        '
        Me.chkPickles.AutoSize = True
        Me.chkPickles.Location = New System.Drawing.Point(7, 83)
        Me.chkPickles.Name = "chkPickles"
        Me.chkPickles.Size = New System.Drawing.Size(67, 17)
        Me.chkPickles.TabIndex = 2
        Me.chkPickles.Text = "Pickles"
        Me.chkPickles.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(7, 59)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(69, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(7, 35)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(56, 17)
        Me.chkMayo.TabIndex = 0
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdoBacon)
        Me.GroupBox1.Controls.Add(Me.rdoCheese)
        Me.GroupBox1.Controls.Add(Me.rdoHamburger)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Location = New System.Drawing.Point(62, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 207)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hamburgers"
        '
        'rdoBacon
        '
        Me.rdoBacon.AutoSize = True
        Me.rdoBacon.Location = New System.Drawing.Point(6, 117)
        Me.rdoBacon.Name = "rdoBacon"
        Me.rdoBacon.Size = New System.Drawing.Size(141, 17)
        Me.rdoBacon.TabIndex = 2
        Me.rdoBacon.TabStop = True
        Me.rdoBacon.Text = "Baconburger - $4.49"
        Me.rdoBacon.UseVisualStyleBackColor = True
        '
        'rdoCheese
        '
        Me.rdoCheese.AutoSize = True
        Me.rdoCheese.Location = New System.Drawing.Point(7, 74)
        Me.rdoCheese.Name = "rdoCheese"
        Me.rdoCheese.Size = New System.Drawing.Size(147, 17)
        Me.rdoCheese.TabIndex = 1
        Me.rdoCheese.TabStop = True
        Me.rdoCheese.Text = "Cheeseburger - $3.79"
        Me.rdoCheese.UseVisualStyleBackColor = True
        '
        'rdoHamburger
        '
        Me.rdoHamburger.AutoSize = True
        Me.rdoHamburger.Location = New System.Drawing.Point(7, 35)
        Me.rdoHamburger.Name = "rdoHamburger"
        Me.rdoHamburger.Size = New System.Drawing.Size(130, 17)
        Me.rdoHamburger.TabIndex = 0
        Me.rdoHamburger.TabStop = True
        Me.rdoHamburger.Text = "Hamburger - $3.29"
        Me.rdoHamburger.UseVisualStyleBackColor = True
        '
        'frmBurgers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(787, 523)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBurgers"
        Me.Text = "frmBurgers"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBBQ As System.Windows.Forms.CheckBox
    Friend WithEvents chkMustard As System.Windows.Forms.CheckBox
    Friend WithEvents chkKetchup As System.Windows.Forms.CheckBox
    Friend WithEvents chkJalapeno As System.Windows.Forms.CheckBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomatoes As System.Windows.Forms.CheckBox
    Friend WithEvents chkPickles As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoBacon As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCheese As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHamburger As System.Windows.Forms.RadioButton
End Class
