namespace GradingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GradingProgram : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Result", "Output", c => c.String(storeType: "ntext"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Result", "Output");
        }
    }
}
