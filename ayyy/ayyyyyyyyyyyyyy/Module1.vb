Imports System.Globalization

Module Module1

    Function FileExists(FilePath As String) As Boolean
        Dim TestStr As String
        TestStr = ""
        On Error Resume Next
        TestStr = Dir(FilePath)
        On Error GoTo 0
        If TestStr = "" Then
            FileExists = False
        Else
            FileExists = True
        End If
    End Function

    '-----------------------------------------------------------------------------------------

    Sub Main()

        Dim index As Integer

        If FileExists("exec\test.txt") = False Then
            Console.WriteLine(vbCrLf + "name, please?")
            Dim name = Console.ReadLine()
            Dim currentDate = DateTime.Now
            My.Computer.FileSystem.WriteAllText("exec\test.txt", name, False)
            Console.WriteLine($"{vbCrLf}welcome {name}, today is {currentDate:d} at {currentDate:t}")
            Console.Write(vbCrLf + "press any key to exit... ")
            Console.ReadKey(True)
            index = 1
            Console.Clear()
        Else
            index = 1
            Console.Clear()
        End If

        While index = 1

            Console.Title = "eLparedero`s menyoo"
            Dim nome As String = My.Computer.FileSystem.ReadAllText("exec\test.txt")
            Dim currentDate = DateTime.Now
            Console.BackgroundColor = ConsoleColor.Blue
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine($"                     welcome, {nome} - {currentDate:d} | {currentDate:t}                   ")
            Console.BackgroundColor = ConsoleColor.Black
            Console.WriteLine("-------------------------------------------------------------------------------")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("                               avaible programs:                               ")
            Console.WriteLine("                     steam.exe   discord.exe   synapse.exe                     ")
            Console.WriteLine("                 spotify.exe   gclauncher.exe   arma3server.exe                ")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("-------------------------------------------------------------------------------")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("                                startup/wakeup                                 ")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("-------------------------------------------------------------------------------")
            Console.BackgroundColor = ConsoleColor.Blue
            Console.WriteLine("commands: execute %% | quit | shutdown | disconnect | restart | logoff | psycho")
            Console.BackgroundColor = ConsoleColor.Black
            Console.WriteLine("-------------------------------------------------------------------------------")
            Console.ForegroundColor = ConsoleColor.Yellow

            Dim execute = Console.ReadLine()

            If execute = "execute steam.exe" Then
                System.Diagnostics.Process.Start("exec\1.bat")
                Console.WriteLine("steam.exe sucessfully started..")
                System.Threading.Thread.Sleep(500)
                Console.Clear()

            ElseIf execute = "execute discord.exe" Then
                System.Diagnostics.Process.Start("exec\2.bat")
                Console.WriteLine("discord.exe sucessfully started..")
                System.Threading.Thread.Sleep(500)
                Console.Clear()

            ElseIf execute = "execute gclauncher.exe" Then
                System.Diagnostics.Process.Start("exec\3.bat")
                Console.WriteLine("gclauncher.exe sucessfully started..")
                System.Threading.Thread.Sleep(500)
                Console.Clear()

            ElseIf execute = "execute spotify.exe" Then
                System.Diagnostics.Process.Start("exec\4.bat")
                Console.WriteLine("spotify.exe sucessfully started..")
                System.Threading.Thread.Sleep(500)
                Console.Clear()

            ElseIf execute = "execute synapse.exe" Then
                System.Diagnostics.Process.Start("exec\5.bat")
                Console.WriteLine("synapse.exe sucessfully started..")
                System.Threading.Thread.Sleep(500)
                Console.Clear()

            ElseIf execute = "execute arma3server.exe" Then
                System.Diagnostics.Process.Start("exec\6.bat")
                Console.WriteLine("arma3server.exe sucessfully started..")
                System.Threading.Thread.Sleep(500)
                Console.Clear()

            ElseIf execute = "startup" Then
                System.Diagnostics.Process.Start("exec\1.bat")
                System.Diagnostics.Process.Start("exec\2.bat")
                System.Diagnostics.Process.Start("exec\4.bat")
                System.Diagnostics.Process.Start("exec\5.bat")
                Console.WriteLine("startup sucessfull..")
                System.Threading.Thread.Sleep(500)
                Console.Clear()

            ElseIf execute = "wakeup" Then
                System.Diagnostics.Process.Start("exec\1.bat")
                System.Diagnostics.Process.Start("exec\2.bat")
                System.Diagnostics.Process.Start("exec\4.bat")
                System.Diagnostics.Process.Start("exec\5.bat")
                Console.WriteLine("startup sucessfull..")
                System.Threading.Thread.Sleep(500)
                Console.Clear()

            ElseIf execute = "shutdown" Then
                Console.Clear()
                Console.WriteLine("goodbye..")
                System.Threading.Thread.Sleep(1000)
                System.Diagnostics.Process.Start("shutdown", "-s -t 00")
                Console.Clear()

            ElseIf execute = "restart" Then
                Console.Clear()
                Console.WriteLine("see ya..")
                System.Threading.Thread.Sleep(500)
                System.Diagnostics.Process.Start("shutdown", "-r -t 00")
                Console.Clear()

            ElseIf execute = "logoff" Then
                Console.Clear()
                Console.WriteLine("goodbye..")
                System.Threading.Thread.Sleep(500)
                System.Diagnostics.Process.Start("shutdown", "-l -t 00")
                Console.Clear()

            ElseIf execute = "psycho" Then
                Console.Clear()
                Console.WriteLine("tell me about your day:")
                Dim psic As String = Console.ReadLine()
                Console.WriteLine("what day`s today?")
                Dim day = Console.ReadLine()
                My.Computer.FileSystem.WriteAllText("psic\" + day + ".dat", psic, True)
                Console.WriteLine("thank u.. be well..")
                System.Threading.Thread.Sleep(400)
                Console.Clear()

            Else

                Console.Clear()

            End If

            ' If index is 0, exit the loop.
            If index = 0 Then
                Exit While
            End If
        End While

    End Sub

End Module
