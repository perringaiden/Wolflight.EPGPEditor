Public Class PlayerStanding

    Private cgName As String
    Private cgRank As String
    Private cgLevel As Integer
    Private cgLastRaid As Date

    Private Const CG_UNKNOWN As String = "<< UNKNOWN >>"

    Public Sub New(ByVal aName As String, ByVal aRank As String, ByVal aLevel As Integer, ByVal aLastRaid As Date)
        cgName = If(String.IsNullOrEmpty(aName), aName, CG_UNKNOWN)
        cgRank = If(String.IsNullOrEmpty(aRank), aRank, CG_UNKNOWN)
        cgLevel = Math.Max(aLevel, 0)
        cgLastRaid = aLastRaid
    End Sub

    Public Property EP As Decimal

    Public Property GP As Decimal

    Public ReadOnly Property PR As Decimal
        Get
            If GP > 0 Then
                Return EP / GP
            Else
                Return Decimal.MaxValue
            End If
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return cgName
        End Get
    End Property

    Public ReadOnly Property Rank As String
        Get
            Return cgRank
        End Get
    End Property

    Public ReadOnly Property Level As Integer
        Get
            Return cglevel
        End Get
    End Property

    Public ReadOnly Property LastRaid As Date
        Get
            Return cgLastRaid
        End Get
    End Property



End Class
