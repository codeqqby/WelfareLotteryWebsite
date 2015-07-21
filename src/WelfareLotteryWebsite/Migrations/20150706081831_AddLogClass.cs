using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace WelfareLotteryWebsite.Migrations
{
    public partial class AddLogClass : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    Memo = table.Column(type: "nvarchar(max)", nullable: true),
                    OptTime = table.Column(type: "datetime2", nullable: false),
                    OptType = table.Column(type: "int", nullable: false),
                    UGuid = table.Column(type: "nvarchar(max)", nullable: true),
                    Username = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Logs");
        }
    }
}
