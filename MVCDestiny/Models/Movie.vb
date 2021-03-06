﻿Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity

Namespace Models
    Public Class Movie
        Public Property ID As Integer

        <StringLength(60, MinimumLength:=3)>
        Public Property Title As String

        <Display(Name:="Release Date")>
        <DataType(DataType.Date)>
        <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
        Public Property ReleaseDate As DateTime

        <RegularExpression("^[A-Z]+[a-zA-Z''-'\s]*$")>
        <Required>
        <StringLength(30)>
        Public Property Genre As String


        <Range(1, 100)>
        <DataType(DataType.Currency)>
        Public Property Price As Decimal

        <RegularExpression("^[A-Z]+[a-zA-Z''-'\s]*$")>
        <StringLength(5)>
        Public Property Rating As String

    End Class
End Namespace

Public Class MovieDbContext
    Inherits DbContext

    Public Property Movies As DbSet(Of Movie)
End Class

Public Class Movie

End Class
