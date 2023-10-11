Module Module1
    'brooks keller
    '10/11/23
    'ex 2: batting average report
    Sub Main()
        Dim av1, av2, av3, av4, av5 As Double
        Dim status1, status2, status3, status4, status5 As String



        Console.WriteLine("Brooks Keller")

        Console.WriteLine("player" & "at".PadLeft(15) & "total".PadLeft(15) & "batting".PadLeft(15) & "batting".PadLeft(15))
        Console.WriteLine("name" & "bats".PadLeft(18) & "hits".PadLeft(13) & "average".PadLeft(16) & "status".PadLeft(14))
        Console.WriteLine("".PadRight(80, "-"))

        av1 = 502 / 198
        av2 = 578 / 143
        av3 = 450 / 110
        av4 = 397 / 120
        av5 = 526 / 187

        If av1 >= 0.25 Then
            status1 = "At MLB standards"
        Else
            status1 = "Below MLB standards"
        End If
        If av2 >= 0.25 Then
            status2 = "At MLB standards"
        Else
            status2 = "Below MLB standards"
        End If
        If av3 >= 0.25 Then
            status3 = "At MLB standards"
        Else
            status3 = "Below MLB standards"
        End If
        If av4 >= 0.25 Then
            status4 = "At MLB standards"
        Else
            status4 = "Below MLB standards"
        End If
        If av5 >= 0.25 Then
            status5 = "At MLB standards"
        Else
            status5 = "Below MLB standards"
        End If

        Console.WriteLine("brett" & "502".PadLeft(15) & "198".PadLeft(15) & av1.ToString("N3").PadLeft(15) & status1.PadLeft(20))
        Console.WriteLine("garvey" & "578".PadLeft(15) & "143".PadLeft(15) & av1.ToString("N3").PadLeft(15) & status2.PadLeft(20))
        Console.WriteLine("jackson" & "450".PadLeft(15) & "110".PadLeft(15) & av3.ToString("N3").PadLeft(15) & status3.PadLeft(20))
        Console.WriteLine("bench" & "397".PadLeft(15) & "120".PadLeft(15) & av4.ToString("N3").PadLeft(15) & status4.PadLeft(20))
        Console.WriteLine("griffey" & "526".PadLeft(15) & "187".PadLeft(15) & av5.ToString("N3").PadLeft(15) & status5.PadLeft(20))
        Console.WriteLine("".PadRight(80, "-"))
    End Sub

End Module
