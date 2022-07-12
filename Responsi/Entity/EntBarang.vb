Public Class EntBarang
    Private _IDBarang As String
    Private _IDMerk As String
    Private _namaBarang As String
    Private _deskripsiBarang As String

    Public Property IDBarang As String
        Get
            Return _IDBarang
        End Get
        Set(value As String)
            _IDBarang = value
        End Set
    End Property

    Public Property IDMerk As String
        Get
            Return _IDMerk
        End Get
        Set(value As String)
            _IDMerk = value
        End Set
    End Property

    Public Property NamaBarang As String
        Get
            Return _namaBarang
        End Get
        Set(value As String)
            _namaBarang = value
        End Set
    End Property

    Public Property DeskripsiBarang As String
        Get
            Return _deskripsiBarang
        End Get
        Set(value As String)
            _deskripsiBarang = value
        End Set
    End Property
End Class
