' Program:      Comic Convention
' Author:       Mark Bulmer
' Date:         February 26, 2022
' Purpose:      This application computes the cost of bringing a group to a comic book convention.

Option Strict On

Public Class frmComicConvention
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' The btnCalculate event handler calculates the group cost.

        ' Declaration Section
        Dim decSize As Decimal
        Dim decBadgeCost As Decimal
        Dim decCostTotal As Decimal
        Dim decConventionSuper As Decimal = 380D
        Dim decConventionAutograph As Decimal = 275D
        Dim decConvention As Decimal = 209D

        ' Did user enter a numeric value?
        If IsNumeric(txtSize.Text) Then
            decSize = Convert.ToDecimal(txtSize.Text)
            ' Is group size greater than zero
            If decSize > 0 And decSize < 21 Then
                ' Determine cost of group
                If radConventionSuperhero.Checked Then
                    decBadgeCost = decConventionSuper
                ElseIf radConventionAutographs.Checked Then
                    decBadgeCost = decConventionAutograph
                ElseIf radConvention.Checked Then
                    decBadgeCost = decConvention
                End If
                ' Calculate and display the cost 
                decCostTotal = decSize * decBadgeCost
                lblCostTotal.Text = decCostTotal.ToString("C")
            Else
                ' Display error message if user entered a negative value, or one greater than 20.
                MsgBox("Please enter a number between 1 and 20.", , "Input Error")
                txtSize.Text = ""
                txtSize.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value.
            MsgBox("Nonnumeric value detected, please enter a number between 1 and 20.", , "Input Error")
            txtSize.Text = ""
            txtSize.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the Clear button. It 
        ' clears the group size text box and the cost  label

        txtSize.Clear()
        lblCostTotal.Text = ""
        radConventionSuperhero.Checked = True
        radConventionAutographs.Checked = False
        radConvention.Checked = False
        txtSize.Focus()
    End Sub

    Private Sub frmConvention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of the 
        ' program. It sets the focus to the group size text box and
        ' clears the cost  label.

        txtSize.Focus()
        lblCostTotal.Text = ""
    End Sub

End Class
