Imports System.Configuration

Public NotInheritable Class FruitCollection
    Inherits ApplicationSettingsBase

    <UserScopedSettingAttribute()>
    <DefaultSettingValue("")>
    Public Property Fruits() As List(Of Fruit)
        Get
            Fruits = Me("Fruits")
        End Get
        Set(ByVal value As List(Of Fruit))
            Me("Fruits") = value
        End Set
    End Property
End Class
