namespace Notification_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StandingInstruction_NotificationService_tbl_AuditLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActivityName = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        SIFrequency = c.String(),
                        SIType = c.String(),
                        MachineName = c.String(),
                        ClientId = c.String(),
                        Status = c.String(),
                        Instruction_name = c.String(),
                        customer_id = c.String(),
                        retrialCount = c.Int(nullable: false),
                        requestId = c.Int(nullable: false),
                        SIfrequencyId = c.Int(nullable: false),
                        SITypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StandingInstruction_NotificationService_tbl_ErrorLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        Level = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        Exception = c.String(),
                        SIType = c.String(),
                        SIFrequency = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StandingInstruction_NotificationService_tbl_ErrorLog");
            DropTable("dbo.StandingInstruction_NotificationService_tbl_AuditLog");
        }
    }
}
