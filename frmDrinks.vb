Public Class frmDrinks

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'Clear Drinks radio buttons
        rdoCoke.Checked = False
        rdoPepsi.Checked = False
        rdoPepper.Checked = False
        rdoSprite.Checked = False
        rdoDew.Checked = False
        rdoDietCoke.Checked = False
        rdoDietDew.Checked = False
        rdoWater.Checked = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Add Drinks to Order
        If rdoCoke.Checked = True Then
            frmMain.lstOrder.Items.Add("Coke - $1.99")
        End If
        If rdoPepsi.Checked = True Then
            frmMain.lstOrder.Items.Add("Pepsi - $1.99")
        End If
        If rdoPepper.Checked = True Then
            frmMain.lstOrder.Items.Add("Dr.Pepper - $1.99")
        End If
        If rdoSprite.Checked = True Then
            frmMain.lstOrder.Items.Add("Sprite - $1.99")
        End If
        If rdoDew.Checked = True Then
            frmMain.lstOrder.Items.Add("Mountain Dew - $1.99")
        End If
        If rdoDietCoke.Checked = True Then
            frmMain.lstOrder.Items.Add("Diet Coke - $1.99")
        End If
        If rdoDietDew.Checked = True Then
            frmMain.lstOrder.Items.Add("Diet Mountain Dew - $1.99")
        End If
        If rdoWater.Checked = True Then
            frmMain.lstOrder.Items.Add("Bottled Water - $0.99")
        End If

        CalcTotals()
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Add Drinks to Order
        If rdoCoke.Checked = True Then
            frmMain.lstOrder.Items.Add("Coke - $1.99")
        End If
        If rdoPepsi.Checked = True Then
            frmMain.lstOrder.Items.Add("Pepsi - $1.99")
        End If
        If rdoPepper.Checked = True Then
            frmMain.lstOrder.Items.Add("Dr.Pepper - $1.99")
        End If
        If rdoSprite.Checked = True Then
            frmMain.lstOrder.Items.Add("Sprite - $1.99")
        End If
        If rdoDew.Checked = True Then
            frmMain.lstOrder.Items.Add("Mountain Dew - $1.99")
        End If
        If rdoDietCoke.Checked = True Then
            frmMain.lstOrder.Items.Add("Diet Coke - $1.99")
        End If
        If rdoDietDew.Checked = True Then
            frmMain.lstOrder.Items.Add("Diet Mountain Dew - $1.99")
        End If
        If rdoWater.Checked = True Then
            frmMain.lstOrder.Items.Add("Bottled Water - $0.99")
        End If

        CalcTotals()
    End Sub
End Class