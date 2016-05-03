Public Class frmBurgers

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'Clear Hamburger radio buttons
        rdoHamburger.Checked = True
        rdoCheese.Checked = False
        rdoBacon.Checked = False

        'Clear Toppings
        chkMayo.Checked = False
        chkLettuce.Checked = False
        chkPickles.Checked = False
        chkTomatoes.Checked = False
        chkOnions.Checked = False
        chkMushrooms.Checked = False
        chkJalapeno.Checked = False
        chkMustard.Checked = False
        chkKetchup.Checked = False
        chkBBQ.Checked = False



    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'Close Burger form
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        'Add Burgers to Order
        If rdoHamburger.Checked = True Then
            frmMain.lstOrder.Items.Add("Hamburger - $3.29")
        End If
        If rdoCheese.Checked = True Then
            frmMain.lstOrder.Items.Add("Cheeseburger - $3.79")
        End If
        If rdoBacon.Checked = True Then
            frmMain.lstOrder.Items.Add("Baconburger - $4.49")
        End If

        'Add Toppings to Order
        If chkMayo.Checked = True Then
            frmMain.lstOrder.Items.Add("Mayo")
        End If
        If chkLettuce.Checked = True Then
            frmMain.lstOrder.Items.Add("Lettuce")
        End If
        If chkPickles.Checked = True Then
            frmMain.lstOrder.Items.Add("Pickles")
        End If
        If chkTomatoes.Checked = True Then
            frmMain.lstOrder.Items.Add("Tomatoes")
        End If
        If chkOnions.Checked = True Then
            frmMain.lstOrder.Items.Add("Onions")
        End If
        If chkMushrooms.Checked = True Then
            frmMain.lstOrder.Items.Add("Mushrooms")
        End If
        If chkJalapeno.Checked = True Then
            frmMain.lstOrder.Items.Add("Jalapeno Peppers")
        End If
        If chkKetchup.Checked = True Then
            frmMain.lstOrder.Items.Add("Ketchup")
        End If
        If chkMustard.Checked = True Then
            frmMain.lstOrder.Items.Add("Mustard")
        End If
        If chkBBQ.Checked = True Then
            frmMain.lstOrder.Items.Add("BBQ Sauce")
        End If

        CalcTotals()

    End Sub
End Class