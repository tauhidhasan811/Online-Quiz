namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOptionAndUpdateQuestionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        IsCorrect = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
            AddColumn("dbo.Questions", "QuestionType", c => c.String(nullable: false));
            DropColumn("dbo.Questions", "Option1");
            DropColumn("dbo.Questions", "Option2");
            DropColumn("dbo.Questions", "Option3");
            DropColumn("dbo.Questions", "Option4");
            DropColumn("dbo.Questions", "CorrectOption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "CorrectOption", c => c.String(nullable: false));
            AddColumn("dbo.Questions", "Option4", c => c.String());
            AddColumn("dbo.Questions", "Option3", c => c.String());
            AddColumn("dbo.Questions", "Option2", c => c.String(nullable: false));
            AddColumn("dbo.Questions", "Option1", c => c.String(nullable: false));
            DropForeignKey("dbo.Options", "QuestionId", "dbo.Questions");
            DropIndex("dbo.Options", new[] { "QuestionId" });
            DropColumn("dbo.Questions", "QuestionType");
            DropTable("dbo.Options");
        }
    }
}
