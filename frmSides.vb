Public Class frmSides

    Private Sub frmSides_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Sides radio buttons unchecked
        rdoFries.Checked = False
        rdoSteakFries.Checked = False
        rdoOnionRings.Checked = False
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'Clear Sides radio buttons
        rdoFries.Checked = False
        rdoSteakFries.Checked = False
        rdoOnionRings.Checked = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        'Add Sides to Order
        If rdoFries.Checked = True Then
            frmMain.lstOrder.Items.Add("Fries - $1.29")
        End If
        If rdoSteakFries.Checked = True Then
            frmMain.lstOrder.Items.Add("Steak Fries - $1.99")
        End If
        If rdoOnionRings.Checked = True Then
            frmMain.lstOrder.Items.Add("Onion Rings - $2.50")
        End If

        CalcTotals()
    End Sub
End Class