namespace QuizApp2.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedQuestionAndAnswer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer1 = c.String(),
                        Answer2 = c.String(),
                        Answer3 = c.String(),
                        Answer4 = c.String(),
                        CorrectAnswer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prompt = c.String(),
                        AnswerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Answers", t => t.AnswerId, cascadeDelete: true)
                .Index(t => t.AnswerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "AnswerId", "dbo.Answers");
            DropIndex("dbo.Questions", new[] { "AnswerId" });
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
