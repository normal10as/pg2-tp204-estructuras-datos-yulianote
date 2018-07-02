Module ejercicio4_12
    Sub main()
        Dim nombres As New Stack(Of String)
        Dim ingreso As Decimal
        Dim sumatoria As Decimal = 0
        Do
            Console.WriteLine("La sumatoria es: " & sumatoria)
            Console.Write("1) Ingrese un numero para sumar " & vbCrLf & "0) para eliminar el ultimo valor o salir" & vbCrLf & "Ingreso:")
            ingreso = Console.ReadLine()
            If ingreso = 0 And nombres.Count <> 0 Then
                Console.WriteLine("Valor eliminado: " & nombres.Peek)
                sumatoria -= nombres.Pop
            Else
                nombres.Push(ingreso)
                sumatoria += ingreso
            End If
        Loop Until sumatoria = 0
        Console.WriteLine("Sumatoria = " & sumatoria & "Adios")
    End Sub

    'Sub main()
    '    Dim nombres_comprador As New Queue(Of String)
    '    Dim op As Byte
    '    Dim bandera As Boolean
    '    Console.WriteLine("------- Cargas de turnos ------- ")
    '    Do
    '        Console.WriteLine()
    '        If nombres_comprador.Count = 0 Then
    '            Console.WriteLine("Sin clientes")
    '            bandera = True
    '        Else
    '            Console.WriteLine("nombres_comprador en espera: " & nombres_comprador.Count)
    '            bandera = False
    '        End If
    '        Console.WriteLine("1)-Agregar comprador a la cola" & vbCrLf & "2)-Llamar proximo cliente" & vbCrLf & "0)- Salir")
    '        Console.Write("Ingrese una opcion: ")
    '        op = Console.ReadLine()
    '        Select Case op
    '            Case 0
    '                Exit Do
    '            Case 1
    '                Dim nombre As String
    '                Console.Write("Ingrese nombre del comprador: ")
    '                nombre = Console.ReadLine
    '                nombres_comprador.Enqueue(nombre)
    '            Case 2
    '                If bandera Then
    '                    Console.WriteLine("No hay clientes para llamar !!")
    '                Else
    '                    Console.WriteLine(nombres_comprador.Dequeue)
    '                End If
    '            Case Else
    '                Console.WriteLine("Opcion invalida")
    '        End Select
    '    Loop While (op <> 0)
    '    Console.WriteLine("Adios, Regrese pronto")
    'End Sub
End Module
