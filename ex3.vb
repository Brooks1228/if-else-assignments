Module ex3
    'brooks keller
    '10/12/23
    'ex3
    Sub main()
        Console.WriteLine("brooks keller" & vbNewLine)

        Console.WriteLine("{0} {1} {2} {3} {4}", "customer".PadRight(20), "magazine".PadRight(20), "total".PadRight(20), "payment".PadRight(20), "payment".PadRight(20))
        Console.WriteLine("{0} {1} {2} {3} {4}", "name".PadRight(20), "name".PadRight(20), "cost".PadRight(20), "made".PadRight(20), "status".PadRight(20))
        Console.WriteLine("".PadRight(100, "-"))
        Dim st1, st2, st3, st4 As String
        Dim cost1, cost2, cost3, cost4, pay1, pay2, pay3, pay4 As Double

        cost1 = 12.99
        cost2 = 25.0
        cost3 = 19.95
        cost4 = 16.5
        pay1 = 0.00
        pay2 = 25.0
        pay3 = 13.5
        pay4 = 0

        If cost1 <> pay1 Then
            st1 = "Payment due"
        Else
            st1 = "Payment made"
        End If
        If cost2 <> pay2 Then
            st2 = "Payment due"
        Else
            st2 = "Payment made"
        End If
        If cost3 <> pay3 Then
            st3 = "Payment due"
        Else
            st3 = "Payment made"
        End If
        If cost4 <> pay4 Then
            st4 = "Payment due"
        Else
            st4 = "Payment made"
        End If

        Console.WriteLine("{0} {1} {2} {3} {4}", "J.R. Sample".PadRight(20), "Redbook".PadRight(20), cost1.ToString("C2").PadRight(20), pay1.ToString("C2").PadRight(20), st1.PadRight(20))
        Console.WriteLine("{0} {1} {2} {3} {4}", "Lester Hayes".PadRight(20), "Yankee".PadRight(20), cost2.ToString("C2").PadRight(20), pay2.ToString("C2").PadRight(20), st2.PadRight(20))
        Console.WriteLine("{0} {1} {2} {3} {4}", "Bill White".PadRight(20), "Runner".PadRight(20), cost3.ToString("C2").PadRight(20), pay3.ToString("C2").PadRight(20), st3.PadRight(20))
        Console.WriteLine("{0} {1} {2} {3} {4}", "Wayne Jones".PadRight(20), "Today".PadRight(20), cost4.ToString("C2").PadRight(20), pay4.ToString("C2").PadRight(20), st4.PadRight(20))
        Console.WriteLine("".PadRight(100, "-"))

    End Sub
End Module
