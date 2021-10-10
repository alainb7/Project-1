<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.radSirloin = New System.Windows.Forms.RadioButton()
        Me.radRibEye = New System.Windows.Forms.RadioButton()
        Me.radTender = New System.Windows.Forms.RadioButton()
        Me.grpBeef = New System.Windows.Forms.GroupBox()
        Me.radUnitOne = New System.Windows.Forms.RadioButton()
        Me.radUnitTwo = New System.Windows.Forms.RadioButton()
        Me.radUnitThree = New System.Windows.Forms.RadioButton()
        Me.radUnitFour = New System.Windows.Forms.RadioButton()
        Me.grpUnit = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkSeasoning = New System.Windows.Forms.CheckBox()
        Me.chkShipping = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.MaskedTextBox()
        Me.mskZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.mskPhoneNum = New System.Windows.Forms.MaskedTextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBeef.SuspendLayout()
        Me.grpUnit.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 68)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Southwest BBQ Order Form"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SouthWestBBQ.My.Resources.Resources._4_512
        Me.PictureBox1.Location = New System.Drawing.Point(12, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 318)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'radSirloin
        '
        Me.radSirloin.AutoSize = True
        Me.radSirloin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSirloin.Location = New System.Drawing.Point(6, 32)
        Me.radSirloin.Name = "radSirloin"
        Me.radSirloin.Size = New System.Drawing.Size(174, 19)
        Me.radSirloin.TabIndex = 3
        Me.radSirloin.TabStop = True
        Me.radSirloin.Text = "Top Sirloin ($13.25/pound)"
        Me.radSirloin.UseVisualStyleBackColor = True
        '
        'radRibEye
        '
        Me.radRibEye.AutoSize = True
        Me.radRibEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRibEye.Location = New System.Drawing.Point(6, 68)
        Me.radRibEye.Name = "radRibEye"
        Me.radRibEye.Size = New System.Drawing.Size(157, 19)
        Me.radRibEye.TabIndex = 4
        Me.radRibEye.TabStop = True
        Me.radRibEye.Text = "Rib Eye ($18.00/pound)"
        Me.radRibEye.UseVisualStyleBackColor = True
        '
        'radTender
        '
        Me.radTender.AutoSize = True
        Me.radTender.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTender.Location = New System.Drawing.Point(6, 104)
        Me.radTender.Name = "radTender"
        Me.radTender.Size = New System.Drawing.Size(174, 19)
        Me.radTender.TabIndex = 5
        Me.radTender.TabStop = True
        Me.radTender.Text = "Tenderloin ($19.95/pound)"
        Me.radTender.UseVisualStyleBackColor = True
        '
        'grpBeef
        '
        Me.grpBeef.Controls.Add(Me.radTender)
        Me.grpBeef.Controls.Add(Me.radRibEye)
        Me.grpBeef.Controls.Add(Me.radSirloin)
        Me.grpBeef.Controls.Add(Me.Label1)
        Me.grpBeef.Location = New System.Drawing.Point(292, 12)
        Me.grpBeef.Name = "grpBeef"
        Me.grpBeef.Size = New System.Drawing.Size(209, 186)
        Me.grpBeef.TabIndex = 6
        Me.grpBeef.TabStop = False
        Me.grpBeef.Text = "Step 1: Pick beef"
        '
        'radUnitOne
        '
        Me.radUnitOne.AutoSize = True
        Me.radUnitOne.Location = New System.Drawing.Point(17, 44)
        Me.radUnitOne.Name = "radUnitOne"
        Me.radUnitOne.Size = New System.Drawing.Size(37, 21)
        Me.radUnitOne.TabIndex = 6
        Me.radUnitOne.TabStop = True
        Me.radUnitOne.Text = "1"
        Me.radUnitOne.UseVisualStyleBackColor = True
        '
        'radUnitTwo
        '
        Me.radUnitTwo.AutoSize = True
        Me.radUnitTwo.Location = New System.Drawing.Point(17, 71)
        Me.radUnitTwo.Name = "radUnitTwo"
        Me.radUnitTwo.Size = New System.Drawing.Size(37, 21)
        Me.radUnitTwo.TabIndex = 7
        Me.radUnitTwo.TabStop = True
        Me.radUnitTwo.Text = "2"
        Me.radUnitTwo.UseVisualStyleBackColor = True
        '
        'radUnitThree
        '
        Me.radUnitThree.AutoSize = True
        Me.radUnitThree.Location = New System.Drawing.Point(17, 98)
        Me.radUnitThree.Name = "radUnitThree"
        Me.radUnitThree.Size = New System.Drawing.Size(37, 21)
        Me.radUnitThree.TabIndex = 8
        Me.radUnitThree.TabStop = True
        Me.radUnitThree.Text = "3"
        Me.radUnitThree.UseVisualStyleBackColor = True
        '
        'radUnitFour
        '
        Me.radUnitFour.AutoSize = True
        Me.radUnitFour.Location = New System.Drawing.Point(17, 125)
        Me.radUnitFour.Name = "radUnitFour"
        Me.radUnitFour.Size = New System.Drawing.Size(37, 21)
        Me.radUnitFour.TabIndex = 9
        Me.radUnitFour.TabStop = True
        Me.radUnitFour.Text = "4"
        Me.radUnitFour.UseVisualStyleBackColor = True
        '
        'grpUnit
        '
        Me.grpUnit.Controls.Add(Me.radUnitFour)
        Me.grpUnit.Controls.Add(Me.radUnitThree)
        Me.grpUnit.Controls.Add(Me.radUnitTwo)
        Me.grpUnit.Controls.Add(Me.radUnitOne)
        Me.grpUnit.Location = New System.Drawing.Point(523, 12)
        Me.grpUnit.Name = "grpUnit"
        Me.grpUnit.Size = New System.Drawing.Size(172, 186)
        Me.grpUnit.TabIndex = 11
        Me.grpUnit.TabStop = False
        Me.grpUnit.Text = "Step 2: Select Number of Units (5lb per unit)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Address: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "City:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Zip Code:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Phone Number:"
        '
        'chkSeasoning
        '
        Me.chkSeasoning.AutoSize = True
        Me.chkSeasoning.Location = New System.Drawing.Point(19, 40)
        Me.chkSeasoning.Name = "chkSeasoning"
        Me.chkSeasoning.Size = New System.Drawing.Size(176, 21)
        Me.chkSeasoning.TabIndex = 17
        Me.chkSeasoning.Text = "Add Seasoning ($4.50)"
        Me.chkSeasoning.UseVisualStyleBackColor = True
        '
        'chkShipping
        '
        Me.chkShipping.AutoSize = True
        Me.chkShipping.Location = New System.Drawing.Point(19, 67)
        Me.chkShipping.Name = "chkShipping"
        Me.chkShipping.Size = New System.Drawing.Size(172, 21)
        Me.chkShipping.TabIndex = 18
        Me.chkShipping.Text = "Add Shipping ($18.00)"
        Me.chkShipping.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkShipping)
        Me.GroupBox1.Controls.Add(Me.chkSeasoning)
        Me.GroupBox1.Location = New System.Drawing.Point(726, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 186)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 3: Pick Extras (Optional)"
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.txtState)
        Me.grpInfo.Controls.Add(Me.Label8)
        Me.grpInfo.Controls.Add(Me.txtName)
        Me.grpInfo.Controls.Add(Me.txtAddress)
        Me.grpInfo.Controls.Add(Me.txtCity)
        Me.grpInfo.Controls.Add(Me.mskZipCode)
        Me.grpInfo.Controls.Add(Me.mskPhoneNum)
        Me.grpInfo.Controls.Add(Me.Label7)
        Me.grpInfo.Controls.Add(Me.Label6)
        Me.grpInfo.Controls.Add(Me.Label5)
        Me.grpInfo.Controls.Add(Me.Label4)
        Me.grpInfo.Controls.Add(Me.Label3)
        Me.grpInfo.Location = New System.Drawing.Point(292, 213)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(313, 229)
        Me.grpInfo.TabIndex = 20
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Step 4: Enter Personal Information"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(135, 124)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(150, 22)
        Me.txtState.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "State:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(135, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(150, 22)
        Me.txtName.TabIndex = 21
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(135, 64)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(150, 22)
        Me.txtAddress.TabIndex = 20
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(135, 94)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(150, 22)
        Me.txtCity.TabIndex = 19
        '
        'mskZipCode
        '
        Me.mskZipCode.Location = New System.Drawing.Point(135, 154)
        Me.mskZipCode.Mask = "00000"
        Me.mskZipCode.Name = "mskZipCode"
        Me.mskZipCode.Size = New System.Drawing.Size(45, 22)
        Me.mskZipCode.TabIndex = 18
        '
        'mskPhoneNum
        '
        Me.mskPhoneNum.Location = New System.Drawing.Point(135, 184)
        Me.mskPhoneNum.Mask = "(999) 000-0000"
        Me.mskPhoneNum.Name = "mskPhoneNum"
        Me.mskPhoneNum.Size = New System.Drawing.Size(100, 22)
        Me.mskPhoneNum.TabIndex = 17
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(839, 222)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 107)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(635, 222)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(123, 107)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(635, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(327, 107)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1001, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpUnit)
        Me.Controls.Add(Me.grpBeef)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Southwest BBQ Order Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBeef.ResumeLayout(False)
        Me.grpBeef.PerformLayout()
        Me.grpUnit.ResumeLayout(False)
        Me.grpUnit.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents radSirloin As RadioButton
    Friend WithEvents radRibEye As RadioButton
    Friend WithEvents radTender As RadioButton
    Friend WithEvents grpBeef As GroupBox
    Friend WithEvents radUnitOne As RadioButton
    Friend WithEvents radUnitTwo As RadioButton
    Friend WithEvents radUnitThree As RadioButton
    Friend WithEvents radUnitFour As RadioButton
    Friend WithEvents grpUnit As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chkSeasoning As CheckBox
    Friend WithEvents chkShipping As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents mskZipCode As MaskedTextBox
    Friend WithEvents mskPhoneNum As MaskedTextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As MaskedTextBox
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents btnExit As Button
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label8 As Label
End Class
