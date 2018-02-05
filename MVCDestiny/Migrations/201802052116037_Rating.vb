Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Rating
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Movies", "Rating", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Movies", "Rating")
        End Sub
    End Class
End Namespace
