namespace Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AnswerIsCorrectAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "RightAnswerId", "dbo.Answers");
            DropIndex("dbo.Questions", new[] { "RightAnswerId" });
            AddColumn("dbo.Answers", "QuestionId", c => c.Int(nullable: false));
            AddColumn("dbo.Answers", "IsCorrect", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Answers", "QuestionId");
            AddForeignKey("dbo.Answers", "QuestionId", "dbo.Questions", "Id", cascadeDelete: true);
            DropColumn("dbo.Questions", "RightAnswerId");
        }

        public override void Down()
        {
            AddColumn("dbo.Questions", "RightAnswerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropColumn("dbo.Answers", "IsCorrect");
            DropColumn("dbo.Answers", "QuestionId");
            CreateIndex("dbo.Questions", "RightAnswerId");
            AddForeignKey("dbo.Questions", "RightAnswerId", "dbo.Answers", "Id", cascadeDelete: true);
        }
    }
}
