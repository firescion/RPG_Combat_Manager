Public Class Character
    Private _strName As String
    Private _intInitiativeMod As Integer
    Private _randGen As New Random
    Private _intInitiativeTotal As Integer
    
    Public Property Name As String
        Get
            Return _strName
        End Get
        Set(value As String)
            _strName = value
        End Set

    End Property

    Public Property InitiativeMod As Integer
        Get
            Return _intInitiativeMod
        End Get
        Set(value As Integer)
            _intInitiativeMod = value
        End Set
    End Property

    Public Property InitiativeTotal As Integer
        Get
            Return _intInitiativeTotal
        End Get
        Set(value As Integer)
            _intInitiativeTotal = value
        End Set
    End Property

    Public Function GetInitiative() As Integer
        Return _intInitiativeMod + _randGen.Next(1, 21)
    End Function

    Public Property kInitiativeTotal As Integer
End Class
