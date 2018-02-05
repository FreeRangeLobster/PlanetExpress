Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Initial
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Movies",
                Function(c) New With
                    {
                        .ID = c.Int(nullable := False, identity := True),
                        .Title = c.String(),
                        .ReleaseDate = c.DateTime(nullable := False),
                        .Genre = c.String(),
                        .Price = c.Decimal(nullable := False, precision := 18, scale := 2)
                    }) _
                .PrimaryKey(Function(t) t.ID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Movies")
        End Sub
    End Class
End Namespace
