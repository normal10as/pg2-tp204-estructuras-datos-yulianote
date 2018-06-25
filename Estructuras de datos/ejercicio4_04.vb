Module ejercicio4_04
    Sub main()
        Dim ingresado As String
        Dim Paises As New Collection
        Paises.Add("Brasil", "br")
        Paises.Add("Argentina", "ar")
        Paises.Add("Francia", "fr")
        Paises.Add("Portugal", "pr")
        Paises.Add("Chile", "ch")
        Paises.Add("España", "es")
        For indice = 1 To Paises.Count
            Console.WriteLine(Paises.Item(indice))
        Next

        Do
            Console.WriteLine("Ingrese el dominio del pais: ")
            ingresado = Console.ReadLine()
            If Paises.Contains(ingresado) Then
                Console.WriteLine(Paises.Item(ingresado))
            Else
                Console.WriteLine("El dominio no se encuentra en la lista")
            End If
        Loop Until (ingresado = "")
    End Sub


End Module
