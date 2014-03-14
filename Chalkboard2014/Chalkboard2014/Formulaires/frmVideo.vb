Public Class frmVideo
    Public Sub New(ByVal url As String)
        InitializeComponent()
        player.URL = url
    End Sub

    Public Function Temps() As Double
        Return player.Ctlcontrols.currentPosition
    End Function
End Class