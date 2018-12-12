namespace MvcDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOnStudentsTableDefinition : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "StudentName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "StudentName", c => c.String());
        }
    }
}
