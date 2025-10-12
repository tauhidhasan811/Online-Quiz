namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentQuizzes", "EndTime", c => c.DateTime());
            AlterColumn("dbo.StudentQuizzes", "Mark", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentQuizzes", "Mark", c => c.Single(nullable: false));
            AlterColumn("dbo.StudentQuizzes", "EndTime", c => c.DateTime(nullable: false));
        }
    }
}
