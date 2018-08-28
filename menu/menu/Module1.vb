'main.vb
'credits to @itzwallker



Module Module1

    Dim white = ConsoleColor.White
    Dim black = ConsoleColor.Black

    Dim red = ConsoleColor.Red
    Dim blue = ConsoleColor.Blue
    Dim cyan = ConsoleColor.Cyan
    Dim green = ConsoleColor.Green
    Dim yellow = ConsoleColor.Yellow
    Dim magenta = ConsoleColor.Magenta
    Dim gray = ConsoleColor.Gray

    Dim dred = ConsoleColor.DarkRed
    Dim dblue = ConsoleColor.DarkBlue
    Dim dcyan = ConsoleColor.DarkCyan
    Dim dgreen = ConsoleColor.DarkGreen
    Dim dyellow = ConsoleColor.DarkYellow
    Dim dmagenta = ConsoleColor.DarkMagenta
    Dim dgray = ConsoleColor.DarkGray


    Dim c As New clsValue()

    Function s(t As Integer)
        Try
            System.Threading.Thread.Sleep(t / 3)
            Console.WriteLine(“.”)
            System.Threading.Thread.Sleep(t / 3)
            Console.Write(“.”)
            System.Threading.Thread.Sleep(t / 3)
            Console.Write(“.”)
        Catch ex As Exception
            Console.Write(ex)
            Console.ReadLine()
        End Try
    End Function

    Function write(s, color, y, x)
        Try
            Console.ForegroundColor = color
            Console.SetCursorPosition(y, x)
            Console.Write(s)
            Console.ResetColor()

        Catch ex As Exception
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.SetCursorPosition(24, 36)
            Console.Write(ex)
            Console.ResetColor()
            Console.ReadLine()

        End Try
    End Function

    Function procK(process)
        Dim prc() As Process = System.Diagnostics.Process.GetProcessesByName(process)
        Try
            For Each p As Process In prc
                p.Kill()
            Next
        Catch ex As Exception
            Console.WriteLine(ex)
            Console.ReadLine()
        End Try
    End Function

    Sub Main()
        menu1()
    End Sub

    Function menu1()

        Console.Clear()

        Dim optionsCount As Integer = 3
        Dim selected As Integer = 0
        Dim done As Boolean = False
        Dim exit1 = 0

        While Not done
            For i As Integer = 0 To optionsCount - 1

                If selected = i Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write("> ")
                Else
                    Console.Write("  ")
                End If

                If i = 0 Then Console.WriteLine("menu1")
                If i = 1 Then Console.WriteLine("menu2")
                If i = 2 Then Console.WriteLine("exit")

                Console.ResetColor()
            Next

            Select Case Console.ReadKey(True).Key
                Case ConsoleKey.UpArrow
                    selected = Math.Max(0, selected - 1)
                Case ConsoleKey.DownArrow
                    selected = Math.Min(optionsCount - 1, selected + 1)
                Case ConsoleKey.Enter
                    done = True
            End Select

            If Not done Then Console.CursorTop = Console.CursorTop - optionsCount
        End While

        Do
            If selected = 0 Then fnc1()
            If selected = 1 Then fnc2()
            If selected = 2 Then Environment.Exit(0)
        Loop

    End Function

    Function fnc1()

        'Console.Clear()

        Dim optionsCount As Integer = 3
        Dim selected As Integer = 0
        Dim done As Boolean = False
        Dim exit1 = 0

        While Not done
            For i As Integer = 0 To optionsCount - 1

                'insira p/ mudar a pos do cursor pra x(optionsCount + 1), y(25) (midscreen)
                'talvez Console.CursorTop = Console.CursorTop + optionsCount + x
                Console.CursorLeft = 15

                If selected = i Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write("> ")
                Else
                    Console.Write("  ")
                End If


                If i = 0 Then Console.WriteLine("wakeup")
                If i = 1 Then Console.WriteLine(“killproc”)
                If i = 2 Then Console.WriteLine("back")

                Console.ResetColor()
            Next

            Select Case Console.ReadKey(True).Key
                Case ConsoleKey.UpArrow
                    selected = Math.Max(0, selected - 1)
                Case ConsoleKey.DownArrow
                    selected = Math.Min(optionsCount - 1, selected + 1)
                Case ConsoleKey.Enter
                    done = True
            End Select

            If Not done Then Console.CursorTop = Console.CursorTop - optionsCount
        End While

        Do
            If selected = 0 Then opt1()
            If selected = 1 Then opt2()
            If selected = 2 Then menu1()
        Loop

    End Function

    Function opt1()
        'console.clear()
        System.Diagnostics.Process.Start("wakeup.bat")
        s(600)
        Console.WriteLine(“done..”)
        fnc1()

    End Function

    Function opt2()
        'console.clear()
        write(“process name:”, White, 30, 0)
        Dim resp = Console.ReadLine()
        Try
            procK(resp)
        Catch ex As Exception
            Console.Write(ex)
            Console.ReadLine()
            fnc1()
        End Try

        s(600)
        Console.WriteLine(“done..”)
        fnc1()

    End Function

    Function fnc2()

        Dim optionsCount As Integer = 4
        Dim selected As Integer = 0
        Dim done As Boolean = False
        Dim exit1 = 0
        Console.CursorTop = 3

        While Not done
            For i As Integer = 0 To optionsCount - 1

                'insira p/ mudar a pos do cursor pra x(optionsCount + 1), y(25) (midscreen)
                'talvez Console.CursorTop = Console.CursorTop + optionsCount + x
                Console.CursorLeft = 15

                If selected = i Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write("> ")
                Else
                    Console.Write("  ")
                End If

                If c.selected2 Then
                    If c.selected3 Then
                        Dim backup = Console.ForegroundColor
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.Write(“ON    “)
                        Console.ForegroundColor = backup

                    Else
                        Dim backup = Console.ForegroundColor
                        Console.ForegroundColor = ConsoleColor.Gray
                        Console.Write(“      “)
                        Console.ForegroundColor = backup
                    End If
                Else
                    Dim backup = Console.ForegroundColor
                    Console.ForegroundColor = ConsoleColor.Gray
                    Console.Write(“      “)
                    Console.ForegroundColor = backup
                End If


                'Console.WriteLine(i)

                If i = 0 Then Console.WriteLine("crpg")
                If i = 1 Then Console.WriteLine(“profilepic”)
                If i = 2 Then Console.WriteLine("back")
                If i = 3 Then Console.WriteLine(“dummy”)

                Console.ResetColor()
            Next

            Select Case Console.ReadKey(True).Key
                Case ConsoleKey.UpArrow
                    selected = Math.Max(0, selected - 1)
                Case ConsoleKey.DownArrow
                    selected = Math.Min(optionsCount - 1, selected + 1)
                Case ConsoleKey.Enter
                    c.selected2 = Not c.selected2
                    c.selected3 = selected
                    done = True
            End Select

            If Not done Then Console.CursorTop = Console.CursorTop - optionsCount
        End While
        Do
            If selected = 0 Then c.selec1 = Not c.selec1
            If selected = 1 Then c.selec2 = Not c.selec2
            If selected = 2 Then menu1()
            If selected = 3 Then c.selec3 = Not c.selec3

            'functions here
            If c.selec1 Then
                System.Diagnostics.Process.Start("crpg.exe")
            Else
                'procK(“crpg”)
            End If

            If c.selec2 Then
                System.Diagnostics.Process.Start("profilepic.exe")
            Else
                'procK(“profilepic”)
            End If

            If c.selec3 Then
                Beep()
                fnc2()
            Else
            End If

        Loop

    End Function

End Module
