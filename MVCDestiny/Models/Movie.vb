Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity

Namespace Models
    Public Class Movie
        Public Property ID As Integer
        Public Property Title As String
        <Display(Name:="Release Date")>
        <DataType(DataType.Date)>
        <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
        Public Property ReleaseDate As DateTime
        Public Property Genre As String
        Public Property Price As Decimal
    End Class
End Namespace

Public Class MovieDbContext
    Inherits DbContext

    Public Property Movies As DbSet(Of Movie)
End Class

Public Class Movie

End Class
