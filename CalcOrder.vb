Module CalcOrder
    Const decTAX_RATE As Decimal = 0.07D 'Declare Tax Rate

    Public Sub CalcTotals()

        'Declare Variables
        Dim decSubTotal As Decimal = 0
        Dim decTax As Decimal = 0
        Dim decTotal As Decimal = 0
        Dim intCount As Integer

        'Calculate cost of order items
        For intCount = 0 To (frmMain.lstOrder.Items.Count - 1)
            Select Case frmMain.lstOrder.Items(intCount)
                Case "Hamburger - $3.29"
                    decSubTotal += 3.29D
                Case "Cheeseburger - $3.79"
                    decSubTotal += 3.79D
                Case "Baconburger - $4.49"
                    decSubTotal += 4.49D
                Case "Fries - $1.29"
                    decSubTotal += 1.29D
                Case "Steak Fries - $1.99"
                    decSubTotal += 1.99D
                Case "Onion Rings - $2.50"
                    decSubTotal += 2.5D
                Case "Coke - $1.99"
                    decSubTotal += 1.99D
                Case "Pepsi - $1.99"
                    decSubTotal += 1.99D
                Case "Dr.Pepper - $1.99"
                    decSubTotal += 1.99D
                Case "Sprite - $1.99"
                    decSubTotal += 1.99D
                Case "Mountain Dew - $1.99"
                    decSubTotal += 1.99D
                Case "Diet Coke - $1.99"
                    decSubTotal += 1.99D
                Case "Diet Mountain Dew - $1.99"
                    decSubTotal += 1.99D
                Case "Bottled Water - $0.99"
                    decSubTotal += 0.99D
            End Select
        Next intCount

        decTax = decSubTotal * decTAX_RATE 'Calculate Tax
        decTotal = decSubTotal + decTax

        'Display Calculations on Main Form
        frmMain.lblSubTotal.Text = decSubTotal.ToString("c")
        frmMain.lblTax.Text = decTax.ToString("c")
        frmMain.lblTotal.Text = decTotal.ToString("c")



    End Sub

End Module
