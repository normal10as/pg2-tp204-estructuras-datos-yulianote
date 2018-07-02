Module ejercicio4_10
    Private nombres As New Stack
    Sub main()
        Dim op As Byte
        Do
            Console.WriteLine("Seleccione una opcion" & vbCrLf & "1-Ingresar un nombre" & vbCrLf & "2-Eliminar nombre")
            Console.Write("Ingrese una opcion: ")
            op = Console.ReadLine
            Select Case op
                Case 1
                    Console.Write("Ingrese el nombre: ")
                    nombres.Push(Console.ReadLine)
                Case 2
                    Console.WriteLine(nombres.Pop)
                    If nombres.Count = 0 Then
                        Exit Do
                    End If
                Case Else
                    Console.WriteLine("Fuera de rango")
            End Select
        Loop
        Console.WriteLine("Adios, no tenemos mas en la lista")
    End Sub
End Module
