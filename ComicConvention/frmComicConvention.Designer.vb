<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicConvention
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
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radConventionAutographs = New System.Windows.Forms.RadioButton()
        Me.radConventionSuperhero = New System.Windows.Forms.RadioButton()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picDeck = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCostTotal = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.grpBadgeType.SuspendLayout()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBadgeType
        '
        Me.grpBadgeType.BackColor = System.Drawing.Color.SkyBlue
        Me.grpBadgeType.Controls.Add(Me.radConvention)
        Me.grpBadgeType.Controls.Add(Me.radConventionAutographs)
        Me.grpBadgeType.Controls.Add(Me.radConventionSuperhero)
        Me.grpBadgeType.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.Chocolate
        Me.grpBadgeType.Location = New System.Drawing.Point(175, 213)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(315, 106)
        Me.grpBadgeType.TabIndex = 13
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Location = New System.Drawing.Point(6, 76)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(121, 27)
        Me.radConvention.TabIndex = 2
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radConventionAutographs
        '
        Me.radConventionAutographs.AutoSize = True
        Me.radConventionAutographs.Location = New System.Drawing.Point(6, 49)
        Me.radConventionAutographs.Name = "radConventionAutographs"
        Me.radConventionAutographs.Size = New System.Drawing.Size(229, 27)
        Me.radConventionAutographs.TabIndex = 1
        Me.radConventionAutographs.Text = "Convention + Autographs"
        Me.radConventionAutographs.UseVisualStyleBackColor = True
        '
        'radConventionSuperhero
        '
        Me.radConventionSuperhero.AutoSize = True
        Me.radConventionSuperhero.Checked = True
        Me.radConventionSuperhero.Location = New System.Drawing.Point(6, 22)
        Me.radConventionSuperhero.Name = "radConventionSuperhero"
        Me.radConventionSuperhero.Size = New System.Drawing.Size(310, 27)
        Me.radConventionSuperhero.TabIndex = 0
        Me.radConventionSuperhero.TabStop = True
        Me.radConventionSuperhero.Text = "Convention + Superhero Experience"
        Me.radConventionSuperhero.UseVisualStyleBackColor = True
        '
        'txtSize
        '
        Me.txtSize.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.ForeColor = System.Drawing.Color.Chocolate
        Me.txtSize.Location = New System.Drawing.Point(381, 160)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(47, 33)
        Me.txtSize.TabIndex = 12
        Me.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Chocolate
        Me.lblGroupSize.Location = New System.Drawing.Point(170, 163)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(113, 25)
        Me.lblGroupSize.TabIndex = 11
        Me.lblGroupSize.Text = "Group Size:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Chocolate
        Me.lblHeading.Location = New System.Drawing.Point(105, 120)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(433, 37)
        Me.lblHeading.TabIndex = 10
        Me.lblHeading.Text = "Comic Convention Registration"
        '
        'picDeck
        '
        Me.picDeck.Image = Global.ComicConvention.My.Resources.Resources.comic
        Me.picDeck.Location = New System.Drawing.Point(0, 0)
        Me.picDeck.Name = "picDeck"
        Me.picDeck.Size = New System.Drawing.Size(645, 117)
        Me.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeck.TabIndex = 18
        Me.picDeck.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(411, 397)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 41)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(112, 397)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 41)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblCostTotal
        '
        Me.lblCostTotal.AutoSize = True
        Me.lblCostTotal.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostTotal.ForeColor = System.Drawing.Color.Chocolate
        Me.lblCostTotal.Location = New System.Drawing.Point(406, 339)
        Me.lblCostTotal.Name = "lblCostTotal"
        Me.lblCostTotal.Size = New System.Drawing.Size(94, 25)
        Me.lblCostTotal.TabIndex = 15
        Me.lblCostTotal.Text = "$0000.00"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Chocolate
        Me.lblCost.Location = New System.Drawing.Point(153, 339)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(168, 25)
        Me.lblCost.TabIndex = 14
        Me.lblCost.Text = "Registration Cost:"
        '
        'frmComicConvention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(643, 450)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picDeck)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostTotal)
        Me.Controls.Add(Me.lblCost)
        Me.Name = "frmComicConvention"
        Me.Text = "Comic Convention Registration"
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radConventionAutographs As RadioButton
    Friend WithEvents radConventionSuperhero As RadioButton
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents picDeck As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblCostTotal As Label
    Friend WithEvents lblCost As Label
End Class
