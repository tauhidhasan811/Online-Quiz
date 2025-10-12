namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatestdQuz : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.StudentQuizs", newName: "StudentQuizzes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.StudentQuizzes", newName: "StudentQuizs");
        }
    }
}
