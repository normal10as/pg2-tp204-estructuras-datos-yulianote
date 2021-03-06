﻿Module ejercicio4_03
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

        Dim nombre_alumnos = New String(cantidad_alumnos - 1) {}
        Dim nota_alumnos = New String(cantidad_notas - 1) {}
        Dim lista_promedio = New String(cantidad_alumnos - 1) {}
        Dim promedio As Double
        Dim mejor_nota As Double
        For i = 0 To (cantidad_alumnos - 1)
            Console.Write("Ingrese nombre del alumno numero {0} : ", i + 1)
            nombre_alumnos(i) = Console.ReadLine()
            While Validar_nombre(nombre_alumnos(i), nombre_alumnos, i)
                Console.WriteLine("Incorrecto, el nombre es vacio o ya existe")
                Console.Write("Ingrese nombre del alumno numero {0} : ", i + 1)
                nombre_alumnos(i) = Console.ReadLine()
            End While
            For j = 0 To (cantidad_notas - 1)
                Console.Write("Ingrese la nota numero {0} : ", j + 1)
                nota_alumnos(j) = Console.ReadLine()
                While Validar_nota(nota_alumnos(j), nota_alumnos)
                    Console.WriteLine("Incorrecto, la nota supero el limite entre 0 y 10 o es vacio ")
                    Console.Write("Ingrese la nota de " & nombre_alumnos(i) & " numero {0} : ", j + 1)
                    nota_alumnos(j) = Console.ReadLine()
                End While
            Next
            promedio = Promedio_alumnos(nota_alumnos, promedio)
            Console.WriteLine("el Promedio es: " & promedio)
            lista_promedio(i) = promedio
            mejor_nota = La_mejor_nota(promedio, mejor_nota)
        Next

        For x = 0 To nombre_alumnos.Length() - 1
            Console.WriteLine("El alumno: " & nombre_alumnos(x) & "---> Promedio: " & lista_promedio(x) & " Estado: " & Estado(lista_promedio(x)))
        Next

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

    Private Function Validar_nombre(ByRef nombre As String, ByVal lista_nombres() As String, ByVal i As Byte) As Boolean
        Do
            If nombre = "" Then
                Return True
            Else
                For x = 0 To i - 1
                    If nombre = lista_nombres(x) Then
                        Return True
                    End If
                Next
                Return False
            End If
        Loop
    End Function

    Private Function Validar_nota(ByVal nota As String, ByVal lista_notas() As String) As Boolean
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

    Private Function Promedio_alumnos(ByVal lista_deun_alumno() As String, ByVal promedio As Double) As Double
        promedio = 0
        Dim contador As Byte
        For Each notas In lista_deun_alumno
            promedio = promedio + notas
            contador += 1
        Next
        promedio = promedio / contador
        Return promedio
    End Function

    Private Function Estado(ByVal promedios As Double) As String
        If promedios >= 6 Then
            Return "Aprobado"
        Else
            Return "Desaprobado"
        End If
    End Function

    Private Sub Mejores_alumnos(nombre_alumnos() As String, lista_promedio() As String, mejor_nota As Double)
        Console.WriteLine("Los mejores promedios es: " & mejor_nota)
        For i = 0 To lista_promedio.Length - 1
            If lista_promedio(i) = mejor_nota Then
                Console.WriteLine("Alumno: " & nombre_alumnos(i) & "  promedio de: " & mejor_nota)
            End If
        Next
    End Sub

    Private Function La_mejor_nota(promedio As Double, mejor_nota As Double) As Double
        If promedio >= mejor_nota Then
            mejor_nota = promedio
        End If
        Return mejor_nota
    End Function

End Module
