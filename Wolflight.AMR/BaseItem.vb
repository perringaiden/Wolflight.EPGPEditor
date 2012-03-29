Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


<JsonObject(MemberSerialization:=MemberSerialization.OptOut)> _
Public MustInherit Class BaseItem

    Implements ICloneable

    Public Property ID As Integer = 0
    Public Property VariantID As Integer? = 0
    Public Property Name As String
    Public Property ItemLevel As Integer? = 0
    Public Property Quality As Quality? = Enumerations.Quality.Cheap
    Public Property Icon As String

    <JsonProperty(NullValueHandling:=NullValueHandling.Include)> _
    Public Property Stats As Dictionary(Of Stat, Integer)

    Protected Overridable Sub CopyTo(ByVal aOther As BaseItem)
        aOther.ID = ID
        aOther.VariantID = VariantID
        aOther.Name = Name
        aOther.ItemLevel = ItemLevel
        aOther.Quality = Quality
        aOther.Icon = Icon

        ' ValueType, ValueType means a shallow copy is fine.
        If Stats IsNot Nothing Then
            aOther.Stats = New Dictionary(Of Stat, Integer)(Stats)
        Else
            aOther.Stats = Nothing
        End If
    End Sub

    Public MustOverride Function Clone() As Object Implements System.ICloneable.Clone

End Class
