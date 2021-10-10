'Name: Alain J. Berard II
'Date: 2/7/2020
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.


Public Class frmOrder
    Private arrRadBeef(2) As RadioButton 'array for beef
    Private arrRadUnit(3) As RadioButton 'array for units selected
    Private arrChkExtras(1) As CheckBox 'checkboxes for the extra options 
    Private strBeef As String 'type of beef selected
    Private strUnitNum As String 'number of units purchased
    Private beefTotal As Double 'total per pound of beef
    Private beefWithUnitTotal As Double 'this is the total that is price per pound multiplied by the number of units
    Private subtotal As Double 'this is the total without tax. Accounts for any extras the user adds
    Private taxAmount As Double 'the amount of tax calculated
    Private grandTotal As Double 'the total amount accounting for units, extras and tax
    Private Summary As frmSummary

    Public Const TAX_PERCENTAGE As Double = 0.075 'constant with 7.5% tax rate
    Public Const SIRLOIN_PRICE As Double = 13.25 'price for sirloin
    Public Const RIBEYE_PRICE As Double = 18.0 'price for ribeye
    Public Const TENDERLOIN_PRICE As Double = 19.95 'price for tenderloin
    Public Const SEASONING_COST As Double = 4.5 'price for seasoning
    Public Const SHIPPING_COST As Double = 18.0 'price for shipping

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        'assigning array elements to the user choices
        arrRadBeef(0) = radSirloin
        arrRadBeef(1) = radRibEye
        arrRadBeef(2) = radTender
        arrRadUnit(0) = radUnitOne
        arrRadUnit(1) = radUnitTwo
        arrRadUnit(2) = radUnitThree
        arrRadUnit(3) = radUnitFour
        arrChkExtras(0) = chkSeasoning
        arrChkExtras(1) = chkShipping

        radSirloin.Checked = False 'remove pre selected option
    End Sub

    Private Sub radBeef_CheckedChanged(sender As Object, e As EventArgs) Handles radSirloin.CheckedChanged, radRibEye.CheckedChanged, radTender.CheckedChanged
        Dim rad As RadioButton
        Dim i As Integer
        rad = DirectCast(sender, RadioButton)
        For i = 0 To arrRadBeef.Length - 1 'for loop to grab user choice into a string
            If arrRadBeef(i).Checked Then
                strBeef = rad.Text
                Select Case arrRadBeef(i).Checked
                    Case i = 0
                        beefTotal = SIRLOIN_PRICE
                    Case i = 1
                        beefTotal = RIBEYE_PRICE
                    Case i = 2
                        beefTotal = TENDERLOIN_PRICE
                End Select

            End If

        Next
    End Sub

    Private Sub radUnitNum_CheckedChanged(sender As Object, e As EventArgs) Handles radUnitOne.CheckedChanged, radUnitTwo.CheckedChanged, radUnitThree.CheckedChanged, radUnitFour.CheckedChanged
        Dim rad As RadioButton
        Dim i As Integer
        rad = DirectCast(sender, RadioButton)
        For i = 0 To arrRadUnit.Length - 1 'for loop to grab the number of units into a string
            If arrRadUnit(i).Checked Then
                strUnitNum = rad.Text
            End If
        Next
        If arrRadUnit(0).Checked Then ' adds this for unit total. beefTotal * (5lb unit * number of units)
            beefWithUnitTotal = beefTotal * 5
        End If
        If arrRadUnit(1).Checked Then
            beefWithUnitTotal = beefTotal * 10
        End If
        If arrRadUnit(2).Checked Then
            beefWithUnitTotal = beefTotal * 15
        End If
        If arrRadUnit(3).Checked Then
            beefWithUnitTotal = beefTotal * 20
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click 'clears user options
        Dim i As Integer
        For i = 0 To arrRadBeef.Length - 1
            arrRadBeef(i).Checked = False
        Next
        For i = 0 To arrRadUnit.Length - 1
            arrRadUnit(i).Checked = False
        Next
        For i = 0 To arrChkExtras.Length - 1
            arrChkExtras(i).Checked = False
        Next
        strUnitNum = 0
        strBeef = ""
        errP.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtName.Clear()
        txtState.Clear()
        mskPhoneNum.Clear()
        mskZipCode.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'use exit buttont to close application
        Application.Exit()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click 'checks input validation and calls for summary 
        Dim blnErrors As Boolean 'check errors

        errP.Clear() 'clear any previous error messages 

        'user input validation
        If strBeef = "" Then ' no beef was selected
            errP.SetError(grpBeef, "You must select a type of beef")
            blnErrors = True
        End If
        If strUnitNum = "" Then 'no number of units was selected
            errP.SetError(grpUnit, "You must select a number of units to purchase")
        End If
        If txtName.Text = "" Then 'user did not input a name
            errP.SetError(grpInfo, "You must enter your name")
            blnErrors = True
        End If
        If txtAddress.Text = "" Then 'then user did not put their street
            errP.SetError(grpInfo, "You must enter a street")
            blnErrors = True
        End If
        If txtState.Text = "" Then 'user did not put a state
            errP.SetError(grpInfo, "You must enter a state")
            blnErrors = True
        End If
        If txtCity.Text = "" Then 'user did not put a city
            errP.SetError(grpInfo, "You must enter a city")
            blnErrors = True
        End If
        If mskZipCode.Text = "" Then 'user did not put a zip code
            errP.SetError(grpInfo, "You must enter a zip code")
            blnErrors = True
        End If
        If mskPhoneNum.Text = "" Then 'user did not put a phone number
            errP.SetError(grpInfo, "You must enter a phone number")
            blnErrors = True
        End If
        If blnErrors Then 'can't go forward. some of the data is missing or bad 
            Exit Sub
        End If

        backupSummary()
    End Sub

    Private Sub CalculateTotal() 'does the math for the totals

        subtotal = beefWithUnitTotal

        If chkSeasoning.Checked Then
            subtotal += SEASONING_COST
        End If
        If chkShipping.Checked Then
            subtotal += SHIPPING_COST
        End If

        taxAmount = subtotal * TAX_PERCENTAGE
        grandTotal = subtotal + taxAmount
    End Sub

    Private Sub backupSummary() 'creating summary in a message box in case passing values to frmConfirmation doesn't work
        Dim strSummary As String
        Dim i As Integer

        CalculateTotal() 'does the math for the summary

        strSummary = "Summary of your order: " & vbCrLf
        strSummary &= vbCrLf
        strSummary &= "Beef Selected: " & strBeef & vbCrLf
        strSummary &= "Number of Units Selected: " & strUnitNum & vbCrLf
        strSummary &= vbCrLf
        strSummary &= "Extras Selected: " & vbCrLf
        If arrChkExtras(0).Checked Then
            strSummary &= arrChkExtras(0).Text & vbCrLf
        End If
        If arrChkExtras(1).Checked Then
            strSummary &= arrChkExtras(1).Text & vbCrLf
        End If
        If arrChkExtras(0).Checked = False And arrChkExtras(1).Checked = False Then
            strSummary &= "No extras selected" & vbCrLf
        End If
        strSummary &= vbCrLf
        strSummary &= "Personal Information: " & vbCrLf
        strSummary &= "Name: " & txtName.Text & vbCrLf
        strSummary &= "Address: " & txtAddress.Text & vbCrLf
        strSummary &= "City: " & txtCity.Text & vbCrLf
        strSummary &= "Zip Code: " & mskZipCode.Text & vbCrLf
        strSummary &= "State: " & txtState.Text & vbCrLf
        strSummary &= "Phone Number: " & mskPhoneNum.Text & vbCrLf
        strSummary &= vbCrLf
        strSummary &= "Subtotal: " & FormatCurrency(subtotal) & vbCrLf
        strSummary &= "Tax: " & FormatCurrency(taxAmount) & vbCrLf
        strSummary &= "Grand Total: " & FormatCurrency(grandTotal) & vbCrLf
        strSummary &= vbCrLf
        'MessageBox.Show(strSummary, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Summary = New frmSummary
        Summary.lblSummary.Text = strSummary
        Summary.ShowDialog()
        btnClear.PerformClick() 'clears form
    End Sub
End Class
