Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


<JsonObject(MemberSerialization:=MemberSerialization.OptOut)> _
Public Class Character
    Implements ICloneable


    Public ProfileId As String
    Public ProfileName As String
    Public LastUpdated As Date
    Public Region As SwtorRegion
    Public Server As String
    Public Name As String
    Public Guild As String
    Public Faction As Faction
    Public AdvancedClass As AdvancedClass
    Public Level As Integer
    Public Gender As Gender
    Public Race As Race
    Public Alignment As Alignment
    Public SocialLevel As SocialLevel
    Public ValorRank As Integer
    Public CraftingCrewSkill As CrewSkill?
    Public CrewSkill2 As CrewSkill?
    Public CrewSkill3 As CrewSkill?
    Public SkillString As String

    <JsonProperty(NullValueHandling:=NullValueHandling.Include)> _
    Public GearSet As Dictionary(Of Enumerations.CharacterSlot, Item)

    <JsonProperty(NullValueHandling:=NullValueHandling.Include)> _
    Public Datacrons As List(Of Integer)

    <JsonProperty(NullValueHandling:=NullValueHandling.Include)> _
    Public Buffs As List(Of Buff)

    Public Stance As Stance?


    Public Function Clone() As Object Implements System.ICloneable.Clone
        Dim rc As New Character


        CopyTo(rc)

        Return rc
    End Function


    Protected Overridable Sub CopyTo(ByVal aOther As Character)
        aOther.ProfileId = ProfileId
        aOther.ProfileName = ProfileName
        aOther.LastUpdated = LastUpdated
        aOther.Region = Region
        aOther.Server = Server
        aOther.Name = Name
        aOther.Guild = Guild
        aOther.Faction = Faction
        aOther.AdvancedClass = AdvancedClass
        aOther.Level = Level
        aOther.Gender = Gender
        aOther.Race = Race
        aOther.Alignment = Alignment
        aOther.SocialLevel = SocialLevel
        aOther.ValorRank = ValorRank
        aOther.CraftingCrewSkill = CraftingCrewSkill
        aOther.CrewSkill2 = CrewSkill2
        aOther.CrewSkill3 = CrewSkill3
        aOther.SkillString = SkillString

        If GearSet IsNot Nothing Then
            ' Create a deep copy of the Gear Set
            aOther.GearSet = New Dictionary(Of CharacterSlot, Item)(GearSet.Count)

            For Each kvp As KeyValuePair(Of CharacterSlot, Item) In GearSet
                aOther.GearSet.Add(kvp.Key, kvp.Value.Clone)
            Next kvp
        Else
            aOther.GearSet = Nothing
        End If

        If Datacrons IsNot Nothing Then
            aOther.Datacrons = New List(Of Integer)(Datacrons)
        Else
            aOther.Datacrons = Nothing
        End If

        If Buffs IsNot Nothing Then
            aOther.Buffs = New List(Of Buff)(Buffs)
        Else
            aOther.Buffs = Nothing
        End If

    End Sub
End Class
