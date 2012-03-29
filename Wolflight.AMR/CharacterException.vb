
''' <summary>
''' An exception that is thrown when an error occurs decoding the information for a character.
''' </summary>
Public Class CharacterException
    Inherits ApplicationException

    Public Sub New(ByVal aInnerException As Exception)
        MyBase.New("An exception occurred retrieiving the requested character.  See the InnerException for more details.", aInnerException)
    End Sub

End Class