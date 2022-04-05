<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCabinet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCabinet))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblLinearFeet = New System.Windows.Forms.Label()
        Me.picBG = New System.Windows.Forms.PictureBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.grpWood = New System.Windows.Forms.GroupBox()
        Me.radCherry = New System.Windows.Forms.RadioButton()
        Me.radOak = New System.Windows.Forms.RadioButton()
        Me.radPine = New System.Windows.Forms.RadioButton()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnCalcCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picCabinets = New System.Windows.Forms.PictureBox()
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWood.SuspendLayout()
        CType(Me.picCabinets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(89, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(211, 27)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Cabinet Estimates"
        '
        'lblLinearFeet
        '
        Me.lblLinearFeet.AutoSize = True
        Me.lblLinearFeet.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLinearFeet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLinearFeet.Location = New System.Drawing.Point(69, 61)
        Me.lblLinearFeet.Name = "lblLinearFeet"
        Me.lblLinearFeet.Size = New System.Drawing.Size(107, 19)
        Me.lblLinearFeet.TabIndex = 1
        Me.lblLinearFeet.Text = "Linear Feet:"
        '
        'picBG
        '
        Me.picBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBG.Location = New System.Drawing.Point(12, 44)
        Me.picBG.Name = "picBG"
        Me.picBG.Size = New System.Drawing.Size(365, 218)
        Me.picBG.TabIndex = 2
        Me.picBG.TabStop = False
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(200, 58)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 27)
        Me.txtInput.TabIndex = 0
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpWood
        '
        Me.grpWood.Controls.Add(Me.radCherry)
        Me.grpWood.Controls.Add(Me.radOak)
        Me.grpWood.Controls.Add(Me.radPine)
        Me.grpWood.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpWood.Location = New System.Drawing.Point(94, 96)
        Me.grpWood.Name = "grpWood"
        Me.grpWood.Size = New System.Drawing.Size(200, 113)
        Me.grpWood.TabIndex = 3
        Me.grpWood.TabStop = False
        Me.grpWood.Text = "Wood Type"
        '
        'radCherry
        '
        Me.radCherry.AutoSize = True
        Me.radCherry.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.radCherry.Location = New System.Drawing.Point(7, 81)
        Me.radCherry.Name = "radCherry"
        Me.radCherry.Size = New System.Drawing.Size(73, 21)
        Me.radCherry.TabIndex = 2
        Me.radCherry.Text = "Cherry"
        Me.radCherry.UseVisualStyleBackColor = True
        '
        'radOak
        '
        Me.radOak.AutoSize = True
        Me.radOak.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.radOak.Location = New System.Drawing.Point(7, 54)
        Me.radOak.Name = "radOak"
        Me.radOak.Size = New System.Drawing.Size(53, 21)
        Me.radOak.TabIndex = 1
        Me.radOak.Text = "Oak"
        Me.radOak.UseVisualStyleBackColor = True
        '
        'radPine
        '
        Me.radPine.AutoSize = True
        Me.radPine.Checked = True
        Me.radPine.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.radPine.Location = New System.Drawing.Point(7, 27)
        Me.radPine.Name = "radPine"
        Me.radPine.Size = New System.Drawing.Size(55, 21)
        Me.radPine.TabIndex = 0
        Me.radPine.TabStop = True
        Me.radPine.Text = "Pine"
        Me.radPine.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblOutput.Location = New System.Drawing.Point(87, 226)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(128, 19)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "Cost Estimate:"
        '
        'btnCalcCost
        '
        Me.btnCalcCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalcCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalcCost.Location = New System.Drawing.Point(12, 269)
        Me.btnCalcCost.Name = "btnCalcCost"
        Me.btnCalcCost.Size = New System.Drawing.Size(177, 27)
        Me.btnCalcCost.TabIndex = 5
        Me.btnCalcCost.Text = "Calculate Cost"
        Me.btnCalcCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(200, 269)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(177, 27)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'picCabinets
        '
        Me.picCabinets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCabinets.Image = Global.WoodCabinEstimateApplication.My.Resources.Resources.Cabinets
        Me.picCabinets.Location = New System.Drawing.Point(-2, 303)
        Me.picCabinets.Name = "picCabinets"
        Me.picCabinets.Size = New System.Drawing.Size(393, 205)
        Me.picCabinets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCabinets.TabIndex = 7
        Me.picCabinets.TabStop = False
        '
        'frmCabinet
        '
        Me.AcceptButton = Me.btnCalcCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(389, 452)
        Me.Controls.Add(Me.picCabinets)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcCost)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.grpWood)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblLinearFeet)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBG)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Teal
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmCabinet"
        Me.Text = "Ethan Anderson's Cabinets"
        CType(Me.picBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWood.ResumeLayout(False)
        Me.grpWood.PerformLayout()
        CType(Me.picCabinets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblLinearFeet As System.Windows.Forms.Label
    Friend WithEvents picBG As System.Windows.Forms.PictureBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents grpWood As System.Windows.Forms.GroupBox
    Friend WithEvents radCherry As System.Windows.Forms.RadioButton
    Friend WithEvents radOak As System.Windows.Forms.RadioButton
    Friend WithEvents radPine As System.Windows.Forms.RadioButton
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnCalcCost As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents picCabinets As System.Windows.Forms.PictureBox

End Class
