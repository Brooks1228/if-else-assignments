Module ex4
    'brooks keller
    '10/12/23
    'ex4
    Sub main()
        Console.WriteLine("brooks keller" & vbNewLine)
        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "student".PadRight(15), "subject".PadRight(15), "grade".PadRight(15), "grade".PadRight(15), "grade".PadRight(15), "grade".PadRight(15), "grade".PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "name".PadRight(15), "".PadRight(15), "1".PadRight(15), "2".PadRight(15), "3".PadRight(15), "avg".PadRight(15), "status".PadRight(15))
        Console.WriteLine("".PadRight(110, "-"))

        Dim av1, av2, av3, av4, av5, av6 As Double
        Dim s1, s2, s3, s4, s5, s6 As String
        av1 = (88 + 89 + 85) / 3
        av2 = (54 + 59 + 55) / 3
        av3 = (91 + 99 + 92) / 3
        av4 = (77 + 75 + 78) / 3
        av5 = (79 + 79 + 75) / 3
        av6 = (72 + 73 + 65) / 3

        If av1 > 90 Then
            s1 = "honors"
        ElseIf av1 < 70 Then
            s1 = "failing"
        Else
            s1 = ""
        End If

        If av2 > 90 Then
            s2 = "honors"
        ElseIf av2 < 70 Then
            s2 = "failing"
        Else
            s2 = ""
        End If

        If av3 > 90 Then
            s3 = "honors"
        ElseIf av3 < 70 Then
            s3 = "failing"
        Else
            s3 = ""
        End If

        If av4 > 90 Then
            s4 = "honors"
        ElseIf av4 < 70 Then
            s4 = "failing"
        Else
            s4 = ""
        End If

        If av5 > 90 Then
            s5 = "honors"
        ElseIf av5 < 70 Then
            s5 = "failing"
        Else
            s5 = ""
        End If

        If av6 > 90 Then
            s6 = "honors"
        ElseIf av6 < 70 Then
            s6 = "failing"
        Else
            s6 = ""
        End If

        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "white".PadRight(15), "chemistry".PadRight(15), "88".PadRight(15), "89".PadRight(15), "85".PadRight(15), av1.ToString("N2").PadRight(15), s1.PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "parker".PadRight(15), "history".PadRight(15), "54".PadRight(15), "59".PadRight(15), "55".PadRight(15), av2.ToString("N2").PadRight(15), s2.PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "jones".PadRight(15), "astronomy".PadRight(15), "91".PadRight(15), "99".PadRight(15), "92".PadRight(15), av3.ToString("N2").PadRight(15), s3.PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "miller".PadRight(15), "biology".PadRight(15), "77".PadRight(15), "75".PadRight(15), "78".PadRight(15), av4.ToString("N2").PadRight(15), s4.PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "harper".PadRight(15), "chemistry".PadRight(15), "79".PadRight(15), "79".PadRight(15), "75".PadRight(15), av5.ToString("N2").PadRight(15), s5.PadRight(15))
        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "hooper".PadRight(15), "algebra".PadRight(15), "72".PadRight(15), "73".PadRight(15), "65".PadRight(15), av6.ToString("N2").PadRight(15), s6.PadRight(15))
    End Sub
End Module
