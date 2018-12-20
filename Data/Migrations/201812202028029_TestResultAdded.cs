namespace Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class TestResultAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestResults",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    Name = c.String(nullable: false),
                    CorrectAnswersCount = c.Long(nullable: false),
                    IncorrectAnswersCount = c.Long(nullable: false),
                    MissedAnswersCount = c.Long(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.TestResults");
        }
    }
}
