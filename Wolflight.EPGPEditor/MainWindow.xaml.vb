Class MainWindow



    Private Sub Go_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Go.Click
        Dim yellowFive As Wolflight.AMR.Character = Wolflight.AMR.CharacterRequest.RequestCharacter("0f95a940-4cf1-4af3-a922-666e312ff49c")
        Dim elorael As Wolflight.AMR.Character = Wolflight.AMR.CharacterRequest.RequestCharacter("a282b43d-7e62-47a1-bd87-ed0db8b7cabd")


        Stop

        Dim eloClone As Wolflight.AMR.Character = elorael.Clone()

        Stop
    End Sub
End Class
