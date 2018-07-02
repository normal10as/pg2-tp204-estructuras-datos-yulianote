Module ejercicio4_01
    Sub main()
        Dim arreglo(5) As Decimal
        Dim cantidad As Byte
        Dim media As Decimal
        Dim sumatoria As Decimal
        Dim desviacion As Decimal

        For i = 1 To arreglo.Length - 1
            Console.Write("ingrese un numero: ")
            arreglo(i) = Console.ReadLine()
            cantidad += 1
            sumatoria = sumatoria + arreglo(i)
        Next

        Console.WriteLine("La sumatoria total: " & sumatoria)
        media = sumatoria / cantidad
        Console.WriteLine("La media es: " & media)

        For j = 1 To arreglo.Length - 1
            desviacion = arreglo(j) - media
            Console.WriteLine("el valor del elemento {0}", j & " es " & arreglo(j) & " y tiene una desviacion de: " &
                              desviacion & " respecto a la media de " & media)
        Next
    End Sub
End Module
