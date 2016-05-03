Public Class frmMain

    Private Sub mnuReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReset.Click

        'Reset main form
        lstOrder.Items.Clear()
        lblSubTotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblDiscount.Text = String.Empty
        lblTotal.Text = String.Empty
        txtOrder.Clear()
        txtCustomer.Clear()



    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Conformation for closing the program
        If MessageBox.Show("Are you sure you want to close the program?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False 'Close the program
        Else
            e.Cancel = True 'Do not close the program
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuBurgers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBurgers.Click

        'Opening Burgers form in modal type
        Dim formBurgers As New frmBurgers
        formBurgers.ShowDialog()

    End Sub

    Private Sub mnuSides_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSides.Click

        'Opening Sides form in modal type
        Dim formSides As New frmSides
        formSides.ShowDialog()
    End Sub

    Private Sub mnuDrinks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDrinks.Click

        'Opening Drinks form in modal type
        Dim formDrinks As New frmDrinks
        formDrinks.ShowDialog()

    End Sub

    Private Sub txtOrder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrder.TextChanged

        Dim intOrder As Integer
        Try
            intOrder = CInt(txtOrder.Text)
        Catch ex As Exception
            MessageBox.Show("Order number should be a valid integer")
        End Try

    End Sub
End Class