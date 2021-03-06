﻿Module ejercicio4_05
    Sub main()
        Dim Paises As New Collection
        Paises.Add("Brasil", "br")
        Paises.Add("Argentina", "ar")
        Paises.Add("Francia", "fr")
        Paises.Add("Portugal", "pr")
        Paises.Add("Chile", "ch")
        Paises.Add("España", "es")

        Dim ingresado As String
        Dim nombre_pais As String
        Dim codigo_pais As String
        Do
            Console.WriteLine("----------  Ingrese una de las Opciones  ----------")
            Console.WriteLine("    0)- Salir  " & vbCrLf & "    1)- Agregar " & vbCrLf & "    2)- Modificar " &
                          vbCrLf & "    3)- Eliminar " & vbCrLf & "    4)- Mostrar ")
            Console.WriteLine("La cantidad de elementos de la lista es: " & Paises.Count)
            Console.Write("Ingrese una Opcion: ")
            ingresado = Console.ReadLine()
            Select Case (ingresado)
                Case 0
                    Exit Do

                Case 1
                    Console.Write("Ingrese el Codigo del pais para agregar: ")
                    codigo_pais = Console.ReadLine()
                    While (Validar_existencia(codigo_pais, Paises))
                        Console.WriteLine("El codigo de ese pais ya existe")
                        Console.Write("Ingrese el Codigo del pais para agregar: ")
                        codigo_pais = Console.ReadLine()
                    End While

                    Console.Write("Ingrese el Nombre del pais: ")
                    nombre_pais = Console.ReadLine()
                    Paises.Add(nombre_pais, codigo_pais)

                Case 2
                    Console.Write("Ingrese el Codigo del pais para modificar: ")
                    codigo_pais = Console.ReadLine()
                    If (Validar_existencia(codigo_pais, Paises)) = False Then
                        Console.WriteLine("No se encuentra en la lista")
                    End If
                    While (Validar_existencia(codigo_pais, Paises))
                        Dim pais_capturado As String
                        Console.WriteLine("El codigo de ese pais existe")
                        pais_capturado = Paises.Item(codigo_pais)
                        For Each pais In Paises
                            If pais = pais_capturado Then
                                Console.WriteLine(pais)
                                Paises.Remove(codigo_pais)
                                Console.Write("Ingrese el codigo del nuevo pais ")
                                codigo_pais = Console.ReadLine()
                                Console.Write("Ingrese el nombre del nuevo pais ")
                                nombre_pais = Console.ReadLine()
                                Paises.Add(nombre_pais, codigo_pais)
                                Exit While
                            End If
                        Next
                    End While

                Case 3
                    Console.Write("Ingrese el Codigo del pais para eliminar: ")
                    codigo_pais = Console.ReadLine()
                    If Validar_existencia(codigo_pais, Paises) = False Then
                        Console.WriteLine("El codigo de ese pais no existe")
                    End If
                    While (Validar_existencia(codigo_pais, Paises))
                        Console.WriteLine("Pais eliminado: " & Paises.Item(codigo_pais))
                        Paises.Remove(codigo_pais)
                    End While

                Case 4
                    Console.WriteLine("Lista de paises: ")
                    For Each Pais In Paises
                        Console.WriteLine(Pais)
                    Next

                Case Else
                    Console.WriteLine("Fuera de Rango.")

            End Select
        Loop While (ingresado <> 0)
        Console.WriteLine("Adios.")
    End Sub

    Private Function Validar_existencia(ByRef valor As String, ByRef paises As Collection) As Boolean
        For Each Pais In paises
            If paises.Contains(valor) Then
                Return True
            End If
        Next
        Return False

    End Function
End Module
