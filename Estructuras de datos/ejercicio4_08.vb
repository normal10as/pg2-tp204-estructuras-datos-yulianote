Module ejercicio4_08
    Sub main()
        Dim ingresado As String
        Dim Paises As New Hashtable
        Paises.Add("br", "Brasil")
        Paises.Add("ar", "Argentina")
        Paises.Add("fr", "Francia")
        Paises.Add("pr", "Portugal")
        Paises.Add("ch", "Chile")
        Paises.Add("es", "España")
        Console.WriteLine("Dom | Pais  " & vbCrLf & "-------------")
        For indice = 0 To Paises.Count - 1
            Console.WriteLine(Paises.Keys(indice) & "  | " & Paises.Values(indice))
        Next
        Do
            Console.Write("-------------" & vbCrLf & "Ingrese el dominio del pais: ")
            ingresado = Console.ReadLine()
            If Paises.Contains(ingresado) Then
                Console.WriteLine("El pais es: " & Paises.Item(ingresado))
            Else
                Console.WriteLine("El dominio no se encuentra en la lista")
            End If
        Loop Until (ingresado = "")
    End Sub
End Module
