Module Module1
    Sub Main()
        ' Crear un arreglo de nombres'
        Dim nombres() As String = {"Juan", "María", "Pedro", "Luisa"}

        ' Recorrer el arreglo e imprimir cada nombre'
        Console.WriteLine("Los nombres en el arreglo son:")
        For i As Integer = 0 To nombres.Length - 1
            Console.WriteLine(nombres(i))
        Next

        ' Esperar a que el usuario presione una tecla para salir'
        Console.ReadKey()
    End Sub
End Module
