namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateQuiz : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Quizs", newName: "Quizzes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Quizzes", newName: "Quizs");
        }
    }
}
