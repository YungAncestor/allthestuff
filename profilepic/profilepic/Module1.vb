Imports System
Imports System.Object
Imports System.MarshalByRefObject
Imports System.Globalization
Imports System.IO
Imports System.Xml
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.String


Module Module1

    Dim fdir = "D:\Everything\new\"

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

    Function GetN(ByVal folderPath As String) As String
        Dim files() As String = Directory.GetFiles(folderPath, "*.*")
        Dim random As Random = New Random()
        Return files(random.Next(0, files.Length - 1))
    End Function

    Function md5f(ByVal Filename As String) As String

        Dim MD5 = System.Security.Cryptography.MD5.Create
        Dim Hash As Byte()
        Dim sb As New System.Text.StringBuilder

        Using st As New IO.FileStream(Filename, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Hash = MD5.ComputeHash(st)
        End Using

        For Each b In Hash
            sb.Append(b.ToString("X2"))
        Next

        Return sb.ToString
    End Function


    Function rand(ini, fin) As String
        Dim s As String = "abcdefghijklmnopqrstuvwxyz0123456789"
        Dim r As New Random()
        Dim sb As New System.Text.StringBuilder

        For i As Integer = ini To fin
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next

        Return sb.ToString
    End Function

    Function hash()
        Dim searchPattern As String = "*.*"
        For Each fileName As String In Directory.GetFiles(fdir, searchPattern, SearchOption.AllDirectories)
            Dim md5String = md5f(fileName)

            If FileExists(fdir + md5String + ".jpg") = True Then
                Do
                    md5String += rand(0, 8)
                Loop Until FileExists(fdir + md5String + ".jpg") = False
            End If

            Dim newfn = Path.Combine(fdir, md5String & ".jpg")

            Try
                File.Move(Path.Combine(fdir, fileName), newfn)

            Catch ex As Exception
                Console.Write(ex)
                Console.ReadLine()
                'System.Threading.Thread.Sleep(1000)

            End Try
            Console.WriteLine(vbCrLf + $"renamed: [ {fileName} ] > [ {newfn} ]")
        Next
        Console.WriteLine("done")
        System.Threading.Thread.Sleep(1000)

        main1()
    End Function

    Function random()
        Dim searchPattern As String = "*.*"
        Dim i As Integer = 0
        For Each fileName As String In Directory.GetFiles(fdir, searchPattern, SearchOption.AllDirectories)
            Dim str = rand(0, 20)

            If FileExists(fdir + str + ".jpg") = True Then
                Do
                    str = rand(0, 20)
                Loop Until FileExists(fdir + str + ".jpg") = False
            End If

            Dim newfn = Path.Combine(fdir, str & ".jpg")

            Try
                File.Move(Path.Combine(fdir, fileName), newfn)

            Catch ex As Exception
                Console.Write(ex)
                Console.ReadLine()
                'System.Threading.Thread.Sleep(1000)

            End Try
            i += 1
            Console.WriteLine(vbCrLf + $"renamed[{i}]: [ {fileName} ] > [ {newfn} ]")
        Next
        Console.WriteLine()
        Console.WriteLine("done")
        System.Threading.Thread.Sleep(1000)

        main1()
    End Function

    Function rename()
        Dim searchPattern As String = "*.*"
        Dim i As Integer = 0
        For Each fileName As String In Directory.GetFiles(fdir, searchPattern, SearchOption.AllDirectories)
            If FileExists(Path.Combine(fdir, i & ".jpg")) = True Then
                Do
                    i += 1
                Loop Until FileExists(Path.Combine(fdir, i & ".jpg")) = False
            End If

            Dim newfn = Path.Combine(fdir, i & ".jpg")

            Try

                File.Move(Path.Combine(fdir, fileName), newfn)
                i += 1

            Catch ex As Exception
                Console.WriteLine(ex)
                Console.ReadLine()
                'System.Threading.Thread.Sleep(1000)

            End Try
            Console.WriteLine(vbCrLf + $"renamed: [ {fileName} ] > [ {newfn} ]")
        Next
        Console.WriteLine("done")
        System.Threading.Thread.Sleep(1000)

        main1()
    End Function

    Dim lp = 0

    Public Sub tick(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        Console.Write(" tick")
    End Sub

    Sub Main()
        main1()
    End Sub

    Function main1()
        'Do
        'Console.Clear()
        'Console.WriteLine("loop, hash, random or rename?")
        'Dim resp = Console.ReadLine
        'If resp = "loop" Then
        'loop1()
        'ElseIf resp = "rename" Then
        'rename()
        'ElseIf resp = "hash" Then
        'hash()
        'ElseIf resp = "random" Then
        'random()
        'End If
        'Loop

        Console.Clear()

        Dim optionsCount As Integer = 5
        Dim selected As Integer = 0
        Dim done As Boolean = False
        Dim opt As Integer
        Dim exit1 = 0

        While Not done
            For i As Integer = 0 To optionsCount - 1

                If selected = i Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write("> ")
                Else
                    Console.Write("  ")
                End If

                'Console.WriteLine(i)
                If i = 0 Then Console.WriteLine("loop")
                If i = 1 Then Console.WriteLine("hash")
                If i = 2 Then Console.WriteLine("rename")
                If i = 3 Then Console.WriteLine("random")
                If i = 4 Then Console.WriteLine("exit")

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
            If selected = 0 Then loop1()
            If selected = 1 Then hash()
            If selected = 2 Then rename()
            If selected = 3 Then random()
            If selected = 4 Then exit1 = 1
        Loop Until exit1 = 1

    End Function

    Function loop1()
        Dim aTimer As New System.Timers.Timer
        aTimer.AutoReset = True
        aTimer.Interval = 100000 '2 seconds
        AddHandler aTimer.Elapsed, AddressOf tick
        aTimer.Start()

        Do
            Console.ForegroundColor = ConsoleColor.White
            Console.BackgroundColor = ConsoleColor.Black

            Console.Clear()

            Console.ForegroundColor = ConsoleColor.White
            Console.BackgroundColor = ConsoleColor.Blue

            Console.WriteLine()
            Console.WriteLine($"file: [ {GetN(fdir)} ]")
            Console.WriteLine()

            MsgBox("update your profile pic")

            'System.Threading.Thread.Sleep(1000)
            System.Threading.Thread.Sleep(2700000)

            If Console.KeyAvailable Then
                If Console.ReadKey(True).KeyChar = "q"c Then lp = 1
            End If
        Loop Until lp = 1
        Main()
    End Function

End Module
