namespace Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Text = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Questions",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    Image = c.Binary(),
                    Description = c.String(),
                    Decision = c.String(),
                    RightAnswerId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Answers", t => t.RightAnswerId, cascadeDelete: true)
                .Index(t => t.RightAnswerId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Questions", "RightAnswerId", "dbo.Answers");
            DropIndex("dbo.Questions", new[] { "RightAnswerId" });
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
