Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports MVCDestiny.Models

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of Models.MovieDbContext)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        'Protected Overrides Sub Seed(context As Models.MovieDbContext)
        Protected Overrides Sub Seed(context As MovieDbContext)
            context.Movies.AddOrUpdate(Function(i) i.Title,
        New Movie() With {
            .Title = "When Harry Met Sally",
            .ReleaseDate = DateTime.Parse("1989-1-11"),
            .Genre = "Romantic Comedy",
            .Price = 7.99D,
            .Rating = "PG"
        }, New Movie() With {
            .Title = "Ghostbusters ",
            .ReleaseDate = DateTime.Parse("1984-3-13"),
            .Genre = "Comedy",
            .Price = 8.99D,
            .Rating = "PG"
        }, New Movie() With {
            .Title = "Ghostbusters 2",
            .ReleaseDate = DateTime.Parse("1986-2-23"),
            .Genre = "Comedy",
            .Price = 9.99D,
            .Rating = "PG"
        }, New Movie() With {
            .Title = "Rio Bravo",
            .ReleaseDate = DateTime.Parse("1959-4-15"),
            .Genre = "Western",
            .Price = 3.99D,
            .Rating = "PG"
        })
        End Sub
        'End Sub

    End Class

End Namespace
