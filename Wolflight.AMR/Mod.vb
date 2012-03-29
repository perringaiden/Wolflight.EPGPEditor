Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Public Class [Mod]
    Inherits BaseItem


    Public Property Slot As ModSlot = ModSlot.None

    Public Overrides Function Clone() As Object
        Dim rc As New [Mod]


        CopyTo(rc)

        Return rc
    End Function

    Protected Overrides Sub CopyTo(ByVal aOther As BaseItem)
#If DEBUG Then
        If Not (TypeOf aOther Is [Mod]) Then _
            Throw New ArgumentException("Parameter 'aOther' is not a Mod object.")
#End If

        MyBase.CopyTo(aOther)

        DirectCast(aOther, [Mod]).Slot = Slot
    End Sub

End Class

