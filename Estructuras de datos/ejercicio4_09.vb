Module ejercicio4_09
    Sub main()
        Dim nombres_comprador As New Queue
        Dim op As Byte
        Dim bandera As Boolean
        Console.WriteLine("------- Cargas de turnos ------- ")
        Do
            Console.WriteLine()
            If nombres_comprador.Count = 0 Then
                Console.WriteLine(" Sin clientes")
                bandera = True
            Else
                Console.WriteLine("Nombres de comprador en espera: " & nombres_comprador.Count)
                bandera = False
            End If
            Console.WriteLine("1)-Agregar comprador a la cola" & vbCrLf & "2)-Llamar proximo cliente" & vbCrLf & "0)- Salir")
            Console.Write("Ingrese una opcion: ")
            op = Console.ReadLine()
            Select Case op
                Case 0
                    Exit Do
                Case 1
                    Dim nombre As String
                    Console.Write("Ingrese nombre del comprador: ")
                    nombre = Console.ReadLine
                    nombres_comprador.Enqueue(nombre)
                Case 2
                    If bandera Then
                        Console.WriteLine("No hay clientes para llamar !!")
                    Else
                        Console.WriteLine(nombres_comprador.Dequeue)
                    End If
                Case Else
                    Console.WriteLine("Opcion invalida")
            End Select
        Loop While (op <> 0)
        Console.WriteLine("Adios, Regrese pronto")
    End Sub
End Module
