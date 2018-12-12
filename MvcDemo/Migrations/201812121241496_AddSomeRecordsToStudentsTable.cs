namespace MvcDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeRecordsToStudentsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Students (StudentName, Age) VALUES ('John', 23)");
            Sql("INSERT INTO Students (StudentName, Age) VALUES ('Sam', 19)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Students WHERE StudentName = 'John' And Age = 23");
            Sql("DELETE FROM Students WHERE StudentName = 'Sam' And Age = 19");
        }
    }
}
