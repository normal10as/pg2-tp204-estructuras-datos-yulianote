Module ejercicio4_11
    Sub main()
        Dim cadena_suma As New Stack
        Dim ingreso As Decimal
        Dim sumatoria As Decimal = 0
        Do
            Console.WriteLine("La sumatoria es: " & sumatoria)
            Console.Write("1) Ingrese un numero para sumar " & vbCrLf & "0) para eliminar el ultimo valor o salir" & vbCrLf & "Ingreso:")
            ingreso = Console.ReadLine()
            If ingreso = 0 And cadena_suma.Count <> 0 Then
                Console.WriteLine("Valor eliminado: " & cadena_suma.Peek)
                sumatoria -= cadena_suma.Pop
            Else
                cadena_suma.Push(ingreso)
                sumatoria += ingreso
            End If
        Loop Until sumatoria = 0
        Console.WriteLine("Sumatoria = " & sumatoria & "Adios")
    End Sub
End Module
