Module ejercicio4_06
    Sub main()
        Dim codigo_empleado As String
        Dim dia_elegido As Byte
        Dim producido As Integer
        Dim dias(6) As Integer
        Dim dia As String
        Dim producido_semanal As New ArrayList
        Dim empleados As New Collection
        empleados.Add("Jose", "jo")
        empleados.Add("Maria", "ma")
        empleados.Add("Pepe", "pe")

        For i = 0 To 6
            dias(i) = 0
        Next
        For Each empleado In empleados
            producido_semanal.Add(dias)
        Next

        Console.WriteLine(vbCrLf & "Productores de chipas" & vbCrLf)
        Do
            Console.Write("codigo de empleado: ")
            codigo_empleado = Console.ReadLine()
            If empleados.Contains(codigo_empleado) Then
                Console.WriteLine("El empleado es: " & empleados.Item(codigo_empleado))
                Console.WriteLine("Posicion de empleado: " & Buscar_posicion(empleados, empleados.Item(codigo_empleado)))

                Console.WriteLine("Ingrese el numero de dia para cargar la produccion: ")
                Console.Write("1-Lunes" & vbCrLf & "2-Martes" & vbCrLf & "3-Miercoles " & vbCrLf & "4-Jueves " &
                              vbCrLf & "5-Viernes" & vbCrLf & "6-Sabado " & vbCrLf & "7-Domingo" & vbCrLf & "Ingreso:")
                dia_elegido = Console.ReadLine()
                dia = Buscar_dia(dia_elegido)
                Console.WriteLine("El dia ingresado es: " & dia)
                Console.Write("Ingrese la cantidad producida por el empleado {0} :", empleados.Item(codigo_empleado))
                producido = Console.ReadLine()

            Else
                Console.WriteLine("no existe empleado")
            End If
        Loop Until (codigo_empleado = "")

    End Sub

    Private Function Buscar_dia(dia_elegido As Byte) As String
        Dim dia As String = ""
        Select Case dia_elegido

            Case 1
                dia = "lunes"
            Case 2
                dia = "martes"
            Case 3
                dia = "miercoles"
            Case 4
                dia = "jueves"
            Case 5
                dia = "viernes"
            Case 6
                dia = "sabado"
            Case 7
                dia = "domingo"
            Case Else
                Console.WriteLine("Seleccion Invalida")
        End Select

        Return dia
    End Function

    Private Function Buscar_posicion(empleados As Collection, nombre_empleado As String) As Byte

        For j As Byte = 1 To empleados.Count
            If nombre_empleado = empleados(j) Then
                Return j
            End If
        Next
        Return 0
    End Function
End Module
