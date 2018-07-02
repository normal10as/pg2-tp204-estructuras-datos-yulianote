Module ejercicio4_07
    Sub main()
        Dim cantidad_alumnos As SByte
        Dim cantidad_notas As SByte

        Console.Write("Ingrese la cantidad de Alumnos: ")
        cantidad_alumnos = Console.ReadLine()
        Do While Validar_cantidad(cantidad_alumnos, 40)
            Console.WriteLine("incorrecto, debe ser entre 1 y 40")
            Console.Write("Ingrese la cantidad de Alumnos: ")
            cantidad_alumnos = Console.ReadLine()
        Loop
        Console.Write("Ingrese la cantidad de Notas: ")
        cantidad_notas = Console.ReadLine()
        Do While Validar_cantidad(cantidad_notas, 5)
            Console.WriteLine("incorrecto, debe ser entre 1 y 4")
            Console.Write("Ingrese la cantidad de Notas: ")
            cantidad_notas = Console.ReadLine()
        Loop
        Console.WriteLine("cantidad alumnos: " & cantidad_alumnos & "   cantidad notas: " & cantidad_notas)
        Console.WriteLine("----------------------------------------")

        Dim nombre_alumnos As New ArrayList
        Dim nombre As String
        Dim nota_alumnos As New ArrayList
        Dim nota As String
        Dim vector_nota(cantidad_notas - 1) As Single
        Dim lista_promedio As New ArrayList
        Dim promedio As Single
        Dim mejor_nota As Double = 0

        For i = 0 To (cantidad_alumnos - 1)
            promedio = 0
            Console.Write("Ingrese nombre del alumno numero {0} : ", i + 1)
            nombre = Console.ReadLine()
            While Validar_nombre(nombre, nombre_alumnos)
                Console.WriteLine("Incorrecto, el nombre es vacio o ya existe")
                Console.Write("Ingrese nombre del alumno numero {0} : ", i + 1)
                nombre = Console.ReadLine()
            End While
            nombre_alumnos.Add(nombre)
            For j = 0 To (cantidad_notas - 1)
                Console.Write("Ingrese la nota numero {0} : ", j + 1)
                nota = Console.ReadLine()
                While Validar_nota(nota)
                    Console.WriteLine("Incorrecto, la nota supero el limite entre 0 y 10 o es vacio ")
                    Console.Write("Ingrese la nota de " & nombre & " numero {0} : ", j + 1)
                    nota = Console.ReadLine()
                End While
                vector_nota(j) = nota
                promedio += vector_nota(j)
            Next
            nota_alumnos.Add(vector_nota)
            lista_promedio.Add(promedio / cantidad_notas)
            Console.WriteLine("El promedio es: " & lista_promedio(i))
        Next
        Console.WriteLine("--------------------------------------")
        For x = 0 To nombre_alumnos.Count - 1
            Console.WriteLine("El alumno: " & nombre_alumnos(x) & "---> Promedio: " & lista_promedio(x) & " Estado: " & Estado(lista_promedio(x)))
        Next
        Console.WriteLine("--------------------------------------")


        mejor_nota = La_mejor_nota(promedio, mejor_nota, lista_promedio)

        Mejores_alumnos(nombre_alumnos, lista_promedio, mejor_nota)

    End Sub

    Private Function Validar_cantidad(ByRef cantidad As SByte, ByRef valor_maximo As Byte) As Boolean
        Do
            If cantidad >= valor_maximo Or cantidad <= 0 Then
                Return True
            Else
                Return False
            End If
        Loop
    End Function

    Private Function Validar_nombre(ByVal nombre As String, ByVal lista As ArrayList) As Boolean
        Do
            If nombre = "" Then
                Return True
            ElseIf lista.Contains(nombre) Then
                Return True
            Else
                Return False
            End If
        Loop
    End Function

    Private Function Validar_nota(ByVal nota As String) As Boolean
        If nota = "" Then
            Return True
        End If
        Do
            If (nota > 10 Or nota < 0) Then
                Return True
            Else
                Return False
            End If
        Loop
    End Function

    Private Function Estado(ByVal promedio As Single) As String
        If promedio >= 6 Then
            Return "Aprobado"
        Else
            Return "Desaprobado"
        End If
    End Function

    Private Function La_mejor_nota(ByVal promedio As Double, ByVal mejor_nota As Single, ByVal lista As ArrayList) As Single
        For Each promedio In lista
            If promedio >= mejor_nota Then
                mejor_nota = promedio
            End If
        Next
        Return mejor_nota
    End Function

    Private Sub Mejores_alumnos(nombre_alumnos As ArrayList, lista_promedio As ArrayList, mejor_nota As Single)
        Console.WriteLine("El mejor promedios es: " & mejor_nota)
        For i = 0 To lista_promedio.Count - 1
            If lista_promedio(i) = mejor_nota Then
                Console.WriteLine("El Alumno: " & nombre_alumnos(i) & "  Tiene el mejor promedio de: " & mejor_nota)
            End If
        Next
    End Sub

End Module