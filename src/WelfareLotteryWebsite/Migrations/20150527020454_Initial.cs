using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace WelfareLotteryWebsite.Migrations
{
    public partial class Initial : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    AdminName = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.Id);
                });
            migration.CreateTable(
                name: "SportLotteryGameType",
                columns: table => new
                {
                    GameType = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportLotteryGameType", x => x.Id);
                });
            migration.CreateTable(
                name: "StationManageType",
                columns: table => new
                {
                    DetailsListSerialized = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    TypeName = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationManageType", x => x.Id);
                });
            migration.CreateTable(
                name: "StationModifiedType",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    TypeName = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationModifiedType", x => x.Id);
                });
            migration.CreateTable(
                name: "StationRegion",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    RegionName = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationRegion", x => x.Id);
                });
            migration.CreateTable(
                name: "WelfareLotteryGameType",
                columns: table => new
                {
                    GameType = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    Rebate = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelfareLotteryGameType", x => x.Id);
                });
            migration.CreateTable(
                name: "SportLottery",
                columns: table => new
                {
                    GameTypeId = table.Column(type: "int", nullable: true),
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    IncomingDate = table.Column(type: "datetime2", nullable: true),
                    IsInstall = table.Column(type: "bit", nullable: false),
                    LotteryCode = table.Column(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column(type: "nvarchar(max)", nullable: true),
                    Relation = table.Column(type: "nvarchar(max)", nullable: true),
                    SportLotteryHostName = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportLottery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportLottery_SportLotteryGameType_GameTypeId",
                        columns: x => x.GameTypeId,
                        referencedTable: "SportLotteryGameType",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "LotteryStation",
                columns: table => new
                {
                    AdminId = table.Column(type: "int", nullable: true),
                    AgencyNum = table.Column(type: "nvarchar(max)", nullable: true),
                    CommunicationType = table.Column(type: "bit", nullable: false),
                    DepositCardNo = table.Column(type: "nvarchar(max)", nullable: true),
                    EstablishedTime = table.Column(type: "datetime2", nullable: true),
                    GuaranteeBase64IdentityPic = table.Column(type: "nvarchar(max)", nullable: true),
                    GuaranteeName = table.Column(type: "nvarchar(max)", nullable: true),
                    HostBase64IdentityPic = table.Column(type: "nvarchar(max)", nullable: true),
                    HostBase64Pic = table.Column(type: "nvarchar(max)", nullable: true),
                    HostIdentityAddress = table.Column(type: "nvarchar(max)", nullable: true),
                    HostIdentityNo = table.Column(type: "nvarchar(max)", nullable: true),
                    HostName = table.Column(type: "nvarchar(max)", nullable: true),
                    HostPhoneNum = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    MachineType = table.Column(type: "bit", nullable: false),
                    ManageTypeName = table.Column(type: "nvarchar(max)", nullable: true),
                    ManageTypeProgencyListSerialized = table.Column(type: "nvarchar(max)", nullable: true),
                    PropertyRight = table.Column(type: "bit", nullable: false),
                    RegionId = table.Column(type: "int", nullable: true),
                    RelatedPhoneNetNum = table.Column(type: "nvarchar(max)", nullable: true),
                    RentDiscount = table.Column(type: "nvarchar(max)", nullable: true),
                    SportLotteryInfoId = table.Column(type: "int", nullable: true),
                    StationCode = table.Column(type: "nvarchar(max)", nullable: true),
                    StationPhoneNo = table.Column(type: "nvarchar(max)", nullable: true),
                    StationPicListSerialized = table.Column(type: "nvarchar(max)", nullable: true),
                    StationSpecificAddress = table.Column(type: "nvarchar(max)", nullable: true),
                    StationTarget = table.Column(type: "nvarchar(max)", nullable: true),
                    UsableArea = table.Column(type: "nvarchar(max)", nullable: true),
                    Violation = table.Column(type: "nvarchar(max)", nullable: true),
                    WelfareGameTypeListSerialized = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryStation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryStation_Administrator_AdminId",
                        columns: x => x.AdminId,
                        referencedTable: "Administrator",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LotteryStation_StationRegion_RegionId",
                        columns: x => x.RegionId,
                        referencedTable: "StationRegion",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LotteryStation_SportLottery_SportLotteryInfoId",
                        columns: x => x.SportLotteryInfoId,
                        referencedTable: "SportLottery",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "RewardCardInfo",
                columns: table => new
                {
                    CardIdentityNo = table.Column(type: "nvarchar(max)", nullable: true),
                    CardName = table.Column(type: "nvarchar(max)", nullable: true),
                    CardNum = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    LotteryStationId = table.Column(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RewardCardInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RewardCardInfo_LotteryStation_LotteryStationId",
                        columns: x => x.LotteryStationId,
                        referencedTable: "LotteryStation",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "Salesclerk",
                columns: table => new
                {
                    HeadPortraitBase64Pic = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    IdentityAddress = table.Column(type: "nvarchar(max)", nullable: true),
                    IdentityNo = table.Column(type: "nvarchar(max)", nullable: true),
                    LotteryStationId = table.Column(type: "int", nullable: true),
                    Name = table.Column(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salesclerk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salesclerk_LotteryStation_LotteryStationId",
                        columns: x => x.LotteryStationId,
                        referencedTable: "LotteryStation",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "StationModifiedInfo",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    LotteryStationId = table.Column(type: "int", nullable: true),
                    Memo = table.Column(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column(type: "datetime2", nullable: false),
                    ModifiedTypeId = table.Column(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationModifiedInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StationModifiedInfo_LotteryStation_LotteryStationId",
                        columns: x => x.LotteryStationId,
                        referencedTable: "LotteryStation",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StationModifiedInfo_StationModifiedType_ModifiedTypeId",
                        columns: x => x.ModifiedTypeId,
                        referencedTable: "StationModifiedType",
                        referencedColumn: "Id");
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Administrator");
            migration.DropTable("LotteryStation");
            migration.DropTable("RewardCardInfo");
            migration.DropTable("Salesclerk");
            migration.DropTable("SportLottery");
            migration.DropTable("SportLotteryGameType");
            migration.DropTable("StationManageType");
            migration.DropTable("StationModifiedInfo");
            migration.DropTable("StationModifiedType");
            migration.DropTable("StationRegion");
            migration.DropTable("WelfareLotteryGameType");
        }
    }
}
