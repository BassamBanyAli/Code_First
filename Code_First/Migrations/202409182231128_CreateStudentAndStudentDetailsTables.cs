namespace Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudentAndStudentDetailsTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        Address = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentDetails", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentDetails", new[] { "StudentId" });
            DropTable("dbo.Students");
            DropTable("dbo.StudentDetails");
        }
    }
}
