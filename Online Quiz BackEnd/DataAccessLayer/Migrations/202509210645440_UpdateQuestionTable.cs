namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateQuestionTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "CorrectOption", c => c.String(nullable: false));
            AlterColumn("dbo.Questions", "Option3", c => c.String());
            AlterColumn("dbo.Questions", "Option4", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questions", "Option4", c => c.Int());
            AlterColumn("dbo.Questions", "Option3", c => c.Int());
            DropColumn("dbo.Questions", "CorrectOption");
        }
    }
}
