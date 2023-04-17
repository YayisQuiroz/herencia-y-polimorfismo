Public MustInherit Class Persona
    Public Property Nombre As String

    Public Sub New(ByVal nombre As String)
        Me.Nombre = nombre
    End Sub

    Public MustOverride Sub MostrarInformacion()
End Class

Public MustInherit Class EntidadContacto
    Inherits Persona

    Public Property Direccion As String
    Public Property Telefono As String
    Public Property Email As String

    Public Sub New(ByVal nombre As String, ByVal direccion As String, ByVal telefono As String, ByVal email As String)
        MyBase.New(nombre)
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Email = email
    End Sub

    Public MustOverride Overrides Sub MostrarInformacion()
End Class

Public Class Contacto
    Inherits EntidadContacto

    Public Sub New(ByVal nombre As String, ByVal direccion As String, ByVal telefono As String, ByVal email As String)
        MyBase.New(nombre, direccion, telefono, email)
    End Sub

    Public Overrides Sub MostrarInformacion()
        Console.WriteLine($"Nombre: {Nombre}")
        Console.WriteLine($"Dirección: {Direccion}")
        Console.WriteLine($"Teléfono: {Telefono}")
        Console.WriteLine($"Email: {Email}")
    End Sub
End Class
Module Module1

    Sub Main()
        Dim contacto As New Contacto("Juan Pérez", "Av. Siempre Viva 123", "555-1234", "juanperez@example.com")
        Dim contacto2 As New Contacto("Diana Quiroz", "calle josevasconcelos", "555-2004", "mariana24@example.com")

        contacto.MostrarInformacion()
        Console.WriteLine("--------------------------------------------------------------------------")
        contacto2.MostrarInformacion()
        Console.ReadKey()

    End Sub

End Module
