Module ejercicio4_02
    Sub main()
        Dim ingreso As Byte
        Dim codigo = New Integer() {1, 2, 3, 4}
        Dim nombre = New String() {"minita", "escabio", "candombe", "descontrol"}
        Dim precio = New Decimal() {350.5, 70.5, 200.4, 120.0}
        Dim cantidad As UShort
        Dim totaldetotales As Decimal
        Console.WriteLine("  -------- Ingrese 0(cero) para salir --------  ")
        Do
            Console.WriteLine("Ingrese el codigo del producto:")
            ingreso = Console.ReadLine()
            Validar(ingreso, codigo.Length)
            For i = 0 To codigo.Length - 1
                If ingreso = codigo(i) Then
                    Console.WriteLine("    Nombre del producto: " & nombre(i))
                    Console.WriteLine("    Precio del producto: " & precio(i) & " $")
                    Console.WriteLine("Ingrese la cantidad de productos: ")
                    cantidad = Console.ReadLine()
                    totaldetotales = Total(cantidad, precio(i), totaldetotales)

                End If
            Next
        Loop While (ingreso <> 0)
    End Sub

    Private Function Total(ByRef cantidad As Integer, ByRef precio As Decimal, ByRef tot As Decimal) As Decimal
        Console.WriteLine("subtotal a pagar es: " & cantidad * precio & " $")
        tot = tot + (cantidad * precio)
        Console.WriteLine("El total a pagar es: " & tot & " $")
        Return tot
    End Function

    Private Function Validar(ByRef ing As Integer, largo_array As Integer) As Boolean
        If ing > largo_array Then
            Console.WriteLine("--- No existe un producto con ese codigo ---")
            Return False
        Else
            Return True
        End If
    End Function


End Module
