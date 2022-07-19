Module module1

    Sub main()

        Dim sr As IO.StreamReader
        Dim td As String
        Dim i, j, k As Integer
        Dim port, name, lname As String
        Dim loginevent(100, 5) As Integer
        Dim lineinfo As String
        sr = IO.file.opentext("loginfile.txt")
        console.writeline("Enter user name")
        name = console.readline()

        Do Until
                lineinfo = sr.readline()
            lname = mid(lineinfo, 2, 5)
            port = mid(lineinfo, 7, 4)
            td = mid(lineinfo, 12, 13)

            If name = lname Then
                loginevent(i, 0) = port
                loginevent(i, 1) = td
                i = i + 1
            End If

        Loop
        For i = 0 To 100
            For j = 0 To 5
                console.writeline(loginevent(i, j))
            Next j
        Next i
    End Sub

End Module