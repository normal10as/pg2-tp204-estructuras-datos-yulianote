Module ejercicio4_03
    Sub main()
        Dim cantidad_alumnos As SByte
        Dim cantidad_notas As SByte
        Console.Write("Ingrese la cantidad de Alumnos: ")
        cantidad_alumnos = Console.ReadLine()
        Do While Validar_ingreso(cantidad_alumnos, 1)
            Console.WriteLine("incorrecto, debe ser mayor que 0 y menor que 40")
            Console.Write("Ingrese la cantidad de Alumnos: ")
            cantidad_alumnos = Console.ReadLine()
        Loop
        Console.Write("Ingrese la cantidad de notas: ")
        cantidad_notas = Console.ReadLine()
        Do While Validar_ingreso(cantidad_notas, 2)
            Console.WriteLine("incorrecto, debe ser mayor que 0 y menor que 5")
            Console.Write("Ingrese la cantidad de Notas: ")
            cantidad_notas = Console.ReadLine()
        Loop

        Console.WriteLine("cantidad alumnos" & cantidad_alumnos & "cantidad notas: " & cantidad_notas)
        Dim nombre_alumnos = New String(cantidad_alumnos) {}
        Dim nota_alumnos = New String(cantidad_notas) {}
        Console.WriteLine(nombre_alumnos)

        For i = 0 To cantidad_alumnos - 1
            Console.Write("Ingrese el nombre del alumno: ")
            nombre_alumnos(i) = Console.ReadLine()
            Console.WriteLine(nombre_alumnos(i))
            For j = 0 To cantidad_notas - 1

            Next
        Next


    End Sub

    Private Function Validar_ingreso(ByRef ingresado As SByte, ByRef opcion As Byte) As Boolean
        Select Case (opcion)
            Case 1
                If ingresado > 40 Or ingresado <= 0 Then
                    Return True
                End If
            Case 2
                If ingresado > 4 Or ingresado <= 0 Then
                    Return True
                End If
        End Select
        Return False
    End Function


End Module
