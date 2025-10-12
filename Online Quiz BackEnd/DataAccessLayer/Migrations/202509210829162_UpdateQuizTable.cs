namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateQuizTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Quizzes", "Counts");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quizzes", "Counts", c => c.Int(nullable: false));
        }
    }
}
