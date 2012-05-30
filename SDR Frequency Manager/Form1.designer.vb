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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lstUser = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.rdoNFM = New System.Windows.Forms.RadioButton()
        Me.rdoWFM = New System.Windows.Forms.RadioButton()
        Me.rdoAM = New System.Windows.Forms.RadioButton()
        Me.rdoDSB = New System.Windows.Forms.RadioButton()
        Me.rdoLSB = New System.Windows.Forms.RadioButton()
        Me.rdoUSB = New System.Windows.Forms.RadioButton()
        Me.rdoCWL = New System.Windows.Forms.RadioButton()
        Me.rdoCWU = New System.Windows.Forms.RadioButton()
        Me.txtFreq = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstBand = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(396, 150)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(156, 20)
        Me.txtName.TabIndex = 11
        '
        'lstUser
        '
        Me.lstUser.FormattingEnabled = True
        Me.lstUser.Location = New System.Drawing.Point(155, 30)
        Me.lstUser.Name = "lstUser"
        Me.lstUser.Size = New System.Drawing.Size(225, 225)
        Me.lstUser.Sorted = True
        Me.lstUser.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(396, 232)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'rdoNFM
        '
        Me.rdoNFM.AutoSize = True
        Me.rdoNFM.Location = New System.Drawing.Point(399, 31)
        Me.rdoNFM.Name = "rdoNFM"
        Me.rdoNFM.Size = New System.Drawing.Size(77, 17)
        Me.rdoNFM.TabIndex = 3
        Me.rdoNFM.TabStop = True
        Me.rdoNFM.Text = "Narrow FM"
        Me.rdoNFM.UseVisualStyleBackColor = True
        '
        'rdoWFM
        '
        Me.rdoWFM.AutoSize = True
        Me.rdoWFM.Location = New System.Drawing.Point(399, 54)
        Me.rdoWFM.Name = "rdoWFM"
        Me.rdoWFM.Size = New System.Drawing.Size(68, 17)
        Me.rdoWFM.TabIndex = 4
        Me.rdoWFM.TabStop = True
        Me.rdoWFM.Text = "Wide FM"
        Me.rdoWFM.UseVisualStyleBackColor = True
        '
        'rdoAM
        '
        Me.rdoAM.AutoSize = True
        Me.rdoAM.Location = New System.Drawing.Point(399, 77)
        Me.rdoAM.Name = "rdoAM"
        Me.rdoAM.Size = New System.Drawing.Size(41, 17)
        Me.rdoAM.TabIndex = 5
        Me.rdoAM.TabStop = True
        Me.rdoAM.Text = "AM"
        Me.rdoAM.UseVisualStyleBackColor = True
        '
        'rdoDSB
        '
        Me.rdoDSB.AutoSize = True
        Me.rdoDSB.Location = New System.Drawing.Point(399, 100)
        Me.rdoDSB.Name = "rdoDSB"
        Me.rdoDSB.Size = New System.Drawing.Size(47, 17)
        Me.rdoDSB.TabIndex = 6
        Me.rdoDSB.TabStop = True
        Me.rdoDSB.Text = "DSB"
        Me.rdoDSB.UseVisualStyleBackColor = True
        '
        'rdoLSB
        '
        Me.rdoLSB.AutoSize = True
        Me.rdoLSB.Location = New System.Drawing.Point(496, 31)
        Me.rdoLSB.Name = "rdoLSB"
        Me.rdoLSB.Size = New System.Drawing.Size(45, 17)
        Me.rdoLSB.TabIndex = 7
        Me.rdoLSB.TabStop = True
        Me.rdoLSB.Text = "LSB"
        Me.rdoLSB.UseVisualStyleBackColor = True
        '
        'rdoUSB
        '
        Me.rdoUSB.AutoSize = True
        Me.rdoUSB.Location = New System.Drawing.Point(496, 54)
        Me.rdoUSB.Name = "rdoUSB"
        Me.rdoUSB.Size = New System.Drawing.Size(47, 17)
        Me.rdoUSB.TabIndex = 8
        Me.rdoUSB.TabStop = True
        Me.rdoUSB.Text = "USB"
        Me.rdoUSB.UseVisualStyleBackColor = True
        '
        'rdoCWL
        '
        Me.rdoCWL.AutoSize = True
        Me.rdoCWL.Location = New System.Drawing.Point(496, 77)
        Me.rdoCWL.Name = "rdoCWL"
        Me.rdoCWL.Size = New System.Drawing.Size(52, 17)
        Me.rdoCWL.TabIndex = 9
        Me.rdoCWL.TabStop = True
        Me.rdoCWL.Text = "CW-L"
        Me.rdoCWL.UseVisualStyleBackColor = True
        '
        'rdoCWU
        '
        Me.rdoCWU.AutoSize = True
        Me.rdoCWU.Location = New System.Drawing.Point(496, 100)
        Me.rdoCWU.Name = "rdoCWU"
        Me.rdoCWU.Size = New System.Drawing.Size(54, 17)
        Me.rdoCWU.TabIndex = 10
        Me.rdoCWU.TabStop = True
        Me.rdoCWU.Text = "CW-U"
        Me.rdoCWU.UseVisualStyleBackColor = True
        '
        'txtFreq
        '
        Me.txtFreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFreq.Location = New System.Drawing.Point(396, 200)
        Me.txtFreq.Name = "txtFreq"
        Me.txtFreq.Size = New System.Drawing.Size(156, 20)
        Me.txtFreq.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(397, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Label"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(397, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Frequency"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Bands"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(152, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "User Frequencies"
        '
        'lstBand
        '
        Me.lstBand.FormattingEnabled = True
        Me.lstBand.Location = New System.Drawing.Point(12, 30)
        Me.lstBand.Name = "lstBand"
        Me.lstBand.Size = New System.Drawing.Size(127, 225)
        Me.lstBand.Sorted = True
        Me.lstBand.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(477, 232)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(304, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 15)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 278)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstBand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFreq)
        Me.Controls.Add(Me.rdoCWU)
        Me.Controls.Add(Me.rdoCWL)
        Me.Controls.Add(Me.rdoUSB)
        Me.Controls.Add(Me.rdoLSB)
        Me.Controls.Add(Me.rdoDSB)
        Me.Controls.Add(Me.rdoAM)
        Me.Controls.Add(Me.rdoWFM)
        Me.Controls.Add(Me.rdoNFM)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstUser)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "SDRSharp Frequency Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lstUser As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents rdoNFM As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWFM As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAM As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDSB As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLSB As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUSB As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCWL As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCWU As System.Windows.Forms.RadioButton
    Friend WithEvents txtFreq As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstBand As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
