﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTickets
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpSelection = New System.Windows.Forms.GroupBox()
        Me.radTwo = New System.Windows.Forms.RadioButton()
        Me.radWhole = New System.Windows.Forms.RadioButton()
        Me.radHalf = New System.Windows.Forms.RadioButton()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnCalcCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.grpSelection.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(4, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(277, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Anderson's NYE Celebration"
        '
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.radTwo)
        Me.grpSelection.Controls.Add(Me.radWhole)
        Me.grpSelection.Controls.Add(Me.radHalf)
        Me.grpSelection.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelection.Location = New System.Drawing.Point(42, 69)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(200, 100)
        Me.grpSelection.TabIndex = 1
        Me.grpSelection.TabStop = False
        Me.grpSelection.Text = "Ticket Type"
        '
        'radTwo
        '
        Me.radTwo.AutoSize = True
        Me.radTwo.Location = New System.Drawing.Point(7, 77)
        Me.radTwo.Name = "radTwo"
        Me.radTwo.Size = New System.Drawing.Size(162, 20)
        Me.radTwo.TabIndex = 2
        Me.radTwo.Text = "Military ID Full Dinner"
        Me.radTwo.UseVisualStyleBackColor = True
        '
        'radWhole
        '
        Me.radWhole.AutoSize = True
        Me.radWhole.Location = New System.Drawing.Point(7, 50)
        Me.radWhole.Name = "radWhole"
        Me.radWhole.Size = New System.Drawing.Size(169, 20)
        Me.radWhole.TabIndex = 1
        Me.radWhole.Text = "Apps Only Celebration"
        Me.radWhole.UseVisualStyleBackColor = True
        '
        'radHalf
        '
        Me.radHalf.AutoSize = True
        Me.radHalf.Checked = True
        Me.radHalf.Location = New System.Drawing.Point(7, 23)
        Me.radHalf.Name = "radHalf"
        Me.radHalf.Size = New System.Drawing.Size(170, 20)
        Me.radHalf.TabIndex = 0
        Me.radHalf.TabStop = True
        Me.radHalf.Text = "Full Dinner Celebration"
        Me.radHalf.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(39, 172)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(120, 16)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = "Final Ticket Cost: "
        '
        'btnCalcCost
        '
        Me.btnCalcCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalcCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalcCost.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcCost.Location = New System.Drawing.Point(12, 191)
        Me.btnCalcCost.Name = "btnCalcCost"
        Me.btnCalcCost.Size = New System.Drawing.Size(122, 23)
        Me.btnCalcCost.TabIndex = 3
        Me.btnCalcCost.Text = "Calculate"
        Me.btnCalcCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(150, 191)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(122, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.PowerWasherRentalApplication.My.Resources.Resources.WomenAtFair
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 220)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.Location = New System.Drawing.Point(39, 43)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(88, 16)
        Me.lblTickets.TabIndex = 6
        Me.lblTickets.Text = "# of Tickets:"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(152, 40)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 23)
        Me.txtInput.TabIndex = 0
        '
        'frmTickets
        '
        Me.AcceptButton = Me.btnCalcCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(284, 333)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcCost)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.Name = "frmTickets"
        Me.Text = "NYE Tickets"
        Me.grpSelection.ResumeLayout(False)
        Me.grpSelection.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpSelection As System.Windows.Forms.GroupBox
    Friend WithEvents radTwo As System.Windows.Forms.RadioButton
    Friend WithEvents radWhole As System.Windows.Forms.RadioButton
    Friend WithEvents radHalf As System.Windows.Forms.RadioButton
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnCalcCost As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTickets As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox

End Class
