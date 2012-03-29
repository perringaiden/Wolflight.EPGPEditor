Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


<JsonObject(MemberSerialization:=MemberSerialization.OptOut)> _
Public Class Item
    Inherits BaseItem

    Public Sub New()
        '
    End Sub

    Public Property Slot As ItemSlot

    <JsonProperty(NullValueHandling:=NullValueHandling.Include)> _
    Public Property ArmorType As ArmorType? = Enumerations.ArmorType.None

    <JsonProperty(NullValueHandling:=NullValueHandling.Include)> _
    Public Property WeaponType As WeaponType? = Enumerations.WeaponType.None

    <JsonProperty(NullValueHandling:=NullValueHandling.Include)> _
    Public Property ShieldType As ShieldType? = Enumerations.ShieldType.None

    Public Property ItemSetID As Integer?

    <JsonProperty(NullValueHandling:=NullValueHandling.Include)> _
    Public Property Mods As List(Of [Mod])


    Public Overrides Function Clone() As Object
        Dim rc As New Item


        CopyTo(rc)

        Return rc
    End Function

    Protected Overrides Sub CopyTo(ByVal aOther As BaseItem)
#If DEBUG Then
        If Not (TypeOf aOther Is Item) Then _
            Throw New ArgumentException("Parameter 'aOther' is not an Item object.")
#End If

        Dim itm As Item = DirectCast(aOther, Item)


        MyBase.CopyTo(aOther)

        itm.Slot = Slot
        itm.ArmorType = ArmorType
        itm.WeaponType = WeaponType
        itm.ShieldType = ShieldType
        itm.ItemSetID = ItemSetID

        If Mods IsNot Nothing Then
            ' Perform a deep copy, cloning the Mods array.
            itm.Mods = New List(Of [Mod])(Mods.Count)

            For Each m As [Mod] In Mods
                itm.Mods.Add(m.Clone)
            Next m
        Else
            itm.Mods = Nothing
        End If
    End Sub

End Class


