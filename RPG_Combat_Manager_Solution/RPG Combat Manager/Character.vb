Public Class Character
    Private _strName As String
    Private _intInitiativeMod As Integer

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


    Public Function GetInitiative()
        Randomize()
        Dim _roll As Integer = Int(Int((20 * Rnd()) + 1))
        InitiativeTotal = _intInitiativeMod + _roll

    End Function

End Class
