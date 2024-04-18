namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRows : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lops", "KhoaId", c => c.Int(nullable: false));
            AddColumn("dbo.SinhViens", "LopId", c => c.Int(nullable: false));
            CreateIndex("dbo.Lops", "KhoaId");
            CreateIndex("dbo.SinhViens", "LopId");
            AddForeignKey("dbo.Lops", "KhoaId", "dbo.Khoas", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SinhViens", "LopId", "dbo.Lops", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "LopId", "dbo.Lops");
            DropForeignKey("dbo.Lops", "KhoaId", "dbo.Khoas");
            DropIndex("dbo.SinhViens", new[] { "LopId" });
            DropIndex("dbo.Lops", new[] { "KhoaId" });
            DropColumn("dbo.SinhViens", "LopId");
            DropColumn("dbo.Lops", "KhoaId");
        }
    }
}
