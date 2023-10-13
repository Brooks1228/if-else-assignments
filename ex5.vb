Module ex5
    'brooks keller
    '10/13/23
    'ex5
    Sub main()
        Console.WriteLine("brooks keller" & vbNewLine)

        Console.WriteLine("{0} {1} {2} {3} {4}", "employee".PadRight(15), "hours".PadRight(15), "pay".PadRight(15), "gross".PadRight(15), "hours".PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4}", "name".PadRight(15), "worked".PadRight(15), "rate".PadRight(15), "pay".PadRight(15), "status".PadRight(15))
        Console.WriteLine("".PadRight(75, "-"))

        Dim g1, g2, g3, g4, g5, g6 As Double
        Dim s1, s2, s3, s4, s5, s6 As String
        Dim h1, h2, h3, h4, h5, h6 As Integer

        h1 = 40
        h2 = 40
        h3 = 32
        h4 = 40
        h5 = 40
        h6 = 32

        g1 = 17.85 * 40
        g2 = 26.8 * 40
        g3 = 25.9 * 32
        g4 = 27.0 * 40
        g5 = 26.85 * 40
        g6 = 32 * 32

        If h1 < 40 Then
            s1 = "part time"
        Else
            s1 = "full time"
        End If

        If h2 < 40 Then
            s2 = "part time"
        Else
            s2 = "full time"
        End If

        If h3 < 40 Then
            s3 = "part time"
        Else
            s3 = "full time"
        End If

        If h4 < 40 Then
            s4 = "part time"
        Else
            s4 = "full time"
        End If

        If h5 < 40 Then
            s5 = "part time"
        Else
            s5 = "full time"
        End If

        If h6 < 40 Then
            s6 = "part time"
        Else
            s6 = "full time"
        End If

        Console.WriteLine("{0} {1} {2} {3} {4}", "young".PadRight(15), h1.ToString.PadRight(15), "17.85".PadRight(15), g1.ToString("N2").PadRight(15), s1.PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4}", "miller".PadRight(15), h2.ToString.PadRight(15), "26.80".PadRight(15), g2.ToString("N2").PadRight(15), s2.PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4}", "north".PadRight(15), h3.ToString.PadRight(15), "25.90".PadRight(15), g3.ToString("N2").PadRight(15), s3.PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4}", "black".PadRight(15), h4.ToString.PadRight(15), "27.00".PadRight(15), g4.ToString("N2").PadRight(15), s4.PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4}", "marsh".PadRight(15), h5.ToString.PadRight(15), "26.85".PadRight(15), g5.ToString("N2").PadRight(15), s5.PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4}", "jones".PadRight(15), h6.ToString.PadRight(15), "19.95".PadRight(15), g6.ToString("N2").PadRight(15), s6.PadRight(15))
        Console.WriteLine("".PadRight(75, "-"))
    End Sub
End Module
