Imports System.Net
Imports Newtonsoft.Json


''' <summary>
''' A static object used to make requests to the Ask Mr Robot Character API.
''' </summary>
Public Class CharacterRequest

    Private Sub New()
        ' Prevent instanciation
    End Sub


    ''' <summary>
    ''' Returns a requested <see cref="Character"/> by Profile ID.
    ''' </summary>
    ''' <param name="aProfileID"></param>
    ''' <returns>The <see cref="Character"/> with the <paramref name="aProfileID"/>.</returns>
    ''' <remarks></remarks>
    Public Shared Function RequestCharacter(ByVal aProfileID As String) As Character
        Dim rc As Character = Nothing


        Try
            Dim address As New Uri("http://swtor.askmrrobot.com/api/character/v1/" & aProfileID)
            Dim req As HttpWebRequest = System.Net.HttpWebRequest.Create(address)
            Dim resp As HttpWebResponse = req.GetResponse

            Dim reader As New JsonTextReader(New System.IO.StreamReader(resp.GetResponseStream))

            rc = (New JsonSerializer).Deserialize(Of Character)(reader)

        Catch tex As Threading.ThreadAbortException
            ' Re-throw ThreadAbortExceptions
            Throw

        Catch ex As System.Net.WebException
            ' Just throw web exceptions, they're self explanatory.
            Throw

        Catch ex As Exception
            ' Throw other exceptions as a Character Exception
            Throw New CharacterException(ex)

        End Try

        Return rc
    End Function

End Class
