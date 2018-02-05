Imports System.Data.Entity

Namespace Models
        Public Class Movie
            Public Property ID As Integer
            Public Property Title As String
            Public Property ReleaseDate As DateTime
            Public Property Genre As String
        Public Property Price As Decimal
        Public Property Rating As String
    End Class

        Public Class MovieDbContext
            Inherits DbContext

            Public Property Movies As DbSet(Of Movie)
        End Class

    End Namespace

