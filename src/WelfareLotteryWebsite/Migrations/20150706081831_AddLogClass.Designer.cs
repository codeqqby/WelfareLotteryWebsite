using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using WelfareLotteryWebsite.Models;

namespace WelfareLotteryWebsite.Migrations
{
    [ContextType(typeof(ApplicationDbContext))]
    partial class AddLogClass
    {
        public override string Id
        {
            get { return "20150706081831_AddLogClass"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta4-12943"; }
        }
        
        public override IModel Target
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Identity");
                
                builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                    {
                        b.Property<string>("ConcurrencyStamp")
                            .ConcurrencyToken()
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("Name")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<string>("NormalizedName")
                            .Annotation("OriginalValueIndex", 3);
                        b.Key("Id");
                        b.Annotation("Relational:TableName", "AspNetRoles");
                    });
                
                builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]", b =>
                    {
                        b.Property<string>("ClaimType")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("ClaimValue")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 2)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("RoleId")
                            .Annotation("OriginalValueIndex", 3);
                        b.Key("Id");
                        b.Annotation("Relational:TableName", "AspNetRoleClaims");
                    });
                
                builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]", b =>
                    {
                        b.Property<string>("ClaimType")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("ClaimValue")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 2)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("UserId")
                            .Annotation("OriginalValueIndex", 3);
                        b.Key("Id");
                        b.Annotation("Relational:TableName", "AspNetUserClaims");
                    });
                
                builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]", b =>
                    {
                        b.Property<string>("LoginProvider")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("ProviderDisplayName")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("ProviderKey")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<string>("UserId")
                            .Annotation("OriginalValueIndex", 3);
                        b.Key("LoginProvider", "ProviderKey");
                        b.Annotation("Relational:TableName", "AspNetUserLogins");
                    });
                
                builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]", b =>
                    {
                        b.Property<string>("RoleId")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("UserId")
                            .Annotation("OriginalValueIndex", 1);
                        b.Key("UserId", "RoleId");
                        b.Annotation("Relational:TableName", "AspNetUserRoles");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.Administrator", b =>
                    {
                        b.Property<string>("AdminName")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.Logs", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("Memo")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<DateTime>("OptTime")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<int>("OptType")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<string>("UGuid")
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<string>("Username")
                            .Annotation("OriginalValueIndex", 5);
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.LotteryStation", b =>
                    {
                        b.Property<int?>("AdminId")
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("ShadowIndex", 0);
                        b.Property<string>("AgencyNum")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<bool>("CommunicationType")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<string>("DepositCardNo")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<DateTime?>("EstablishedTime")
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<string>("GuaranteeBase64IdentityPic")
                            .Annotation("OriginalValueIndex", 5);
                        b.Property<string>("GuaranteeName")
                            .Annotation("OriginalValueIndex", 6);
                        b.Property<string>("HostBase64IdentityPic")
                            .Annotation("OriginalValueIndex", 7);
                        b.Property<string>("HostBase64Pic")
                            .Annotation("OriginalValueIndex", 8);
                        b.Property<string>("HostIdentityAddress")
                            .Annotation("OriginalValueIndex", 9);
                        b.Property<string>("HostIdentityNo")
                            .Annotation("OriginalValueIndex", 10);
                        b.Property<string>("HostName")
                            .Annotation("OriginalValueIndex", 11);
                        b.Property<string>("HostPhoneNum")
                            .Annotation("OriginalValueIndex", 12);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 13)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<bool>("MachineType")
                            .Annotation("OriginalValueIndex", 14);
                        b.Property<string>("ManageTypeName")
                            .Annotation("OriginalValueIndex", 15);
                        b.Property<string>("ManageTypeProgencyListSerialized")
                            .Annotation("OriginalValueIndex", 16);
                        b.Property<bool>("PropertyRight")
                            .Annotation("OriginalValueIndex", 17);
                        b.Property<int?>("RegionId")
                            .Annotation("OriginalValueIndex", 18)
                            .Annotation("ShadowIndex", 1);
                        b.Property<string>("RelatedPhoneNetNum")
                            .Annotation("OriginalValueIndex", 19);
                        b.Property<string>("RentDiscount")
                            .Annotation("OriginalValueIndex", 20);
                        b.Property<int?>("SportLotteryInfoId")
                            .Annotation("OriginalValueIndex", 21)
                            .Annotation("ShadowIndex", 2);
                        b.Property<string>("StationCode")
                            .Annotation("OriginalValueIndex", 22);
                        b.Property<string>("StationPhoneNo")
                            .Annotation("OriginalValueIndex", 23);
                        b.Property<string>("StationPicListSerialized")
                            .Annotation("OriginalValueIndex", 24);
                        b.Property<string>("StationSpecificAddress")
                            .Annotation("OriginalValueIndex", 25);
                        b.Property<string>("StationTarget")
                            .Annotation("OriginalValueIndex", 26);
                        b.Property<string>("UsableArea")
                            .Annotation("OriginalValueIndex", 27);
                        b.Property<string>("Violation")
                            .Annotation("OriginalValueIndex", 28);
                        b.Property<string>("WelfareGameTypeListSerialized")
                            .Annotation("OriginalValueIndex", 29);
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.RewardCardInfo", b =>
                    {
                        b.Property<string>("CardIdentityNo")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("CardName")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("CardNum")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 3)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<int?>("LotteryStationId")
                            .Annotation("OriginalValueIndex", 4)
                            .Annotation("ShadowIndex", 0);
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.Salesclerk", b =>
                    {
                        b.Property<string>("HeadPortraitBase64Pic")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("IdentityAddress")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<string>("IdentityNo")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<int?>("LotteryStationId")
                            .Annotation("OriginalValueIndex", 4)
                            .Annotation("ShadowIndex", 0);
                        b.Property<string>("Name")
                            .Annotation("OriginalValueIndex", 5);
                        b.Property<string>("Phone")
                            .Annotation("OriginalValueIndex", 6);
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.SportLottery", b =>
                    {
                        b.Property<int?>("GameTypeId")
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("ShadowIndex", 0);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<DateTime?>("IncomingDate")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<bool>("IsInstall")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<string>("LotteryCode")
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<string>("PhoneNumber")
                            .Annotation("OriginalValueIndex", 5);
                        b.Property<string>("Relation")
                            .Annotation("OriginalValueIndex", 6);
                        b.Property<string>("SportLotteryHostName")
                            .Annotation("OriginalValueIndex", 7);
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.SportLotteryGameType", b =>
                    {
                        b.Property<string>("GameType")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.StationManageType", b =>
                    {
                        b.Property<string>("DetailsListSerialized")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("TypeName")
                            .Annotation("OriginalValueIndex", 2);
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.StationModifiedInfo", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<int?>("LotteryStationId")
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("ShadowIndex", 0);
                        b.Property<string>("Memo")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<DateTime>("ModifiedTime")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<int?>("ModifiedTypeId")
                            .Annotation("OriginalValueIndex", 4)
                            .Annotation("ShadowIndex", 1);
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.StationModifiedType", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("TypeName")
                            .Annotation("OriginalValueIndex", 1);
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.StationRegion", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("RegionName")
                            .Annotation("OriginalValueIndex", 1);
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.WelfareLotteryGameType", b =>
                    {
                        b.Property<string>("GameType")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("Rebate")
                            .Annotation("OriginalValueIndex", 2);
                        b.Key("Id");
                    });
                
                builder.Entity("WelfareLotteryWebsite.Models.ApplicationUser", b =>
                    {
                        b.Property<int>("AccessFailedCount")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("ConcurrencyStamp")
                            .ConcurrencyToken()
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("Email")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<bool>("EmailConfirmed")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<string>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<bool>("LockoutEnabled")
                            .Annotation("OriginalValueIndex", 5);
                        b.Property<DateTimeOffset?>("LockoutEnd")
                            .Annotation("OriginalValueIndex", 6);
                        b.Property<string>("NormalizedEmail")
                            .Annotation("OriginalValueIndex", 7);
                        b.Property<string>("NormalizedUserName")
                            .Annotation("OriginalValueIndex", 8);
                        b.Property<string>("PasswordHash")
                            .Annotation("OriginalValueIndex", 9);
                        b.Property<string>("PhoneNumber")
                            .Annotation("OriginalValueIndex", 10);
                        b.Property<bool>("PhoneNumberConfirmed")
                            .Annotation("OriginalValueIndex", 11);
                        b.Property<string>("SecurityStamp")
                            .Annotation("OriginalValueIndex", 12);
                        b.Property<bool>("TwoFactorEnabled")
                            .Annotation("OriginalValueIndex", 13);
                        b.Property<string>("UserName")
                            .Annotation("OriginalValueIndex", 14);
                        b.Key("Id");
                        b.Annotation("Relational:TableName", "AspNetUsers");
                    });
                
                builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]", b =>
                    {
                        b.ForeignKey("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", "RoleId");
                    });
                
                builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]", b =>
                    {
                        b.ForeignKey("WelfareLotteryWebsite.Models.ApplicationUser", "UserId");
                    });
                
                builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]", b =>
                    {
                        b.ForeignKey("WelfareLotteryWebsite.Models.ApplicationUser", "UserId");
                    });
                
                builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]", b =>
                    {
                        b.ForeignKey("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", "RoleId");
                        b.ForeignKey("WelfareLotteryWebsite.Models.ApplicationUser", "UserId");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.LotteryStation", b =>
                    {
                        b.ForeignKey("WelfareLotteryWebsite.DBModels.Administrator", "AdminId");
                        b.ForeignKey("WelfareLotteryWebsite.DBModels.StationRegion", "RegionId");
                        b.ForeignKey("WelfareLotteryWebsite.DBModels.SportLottery", "SportLotteryInfoId");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.RewardCardInfo", b =>
                    {
                        b.ForeignKey("WelfareLotteryWebsite.DBModels.LotteryStation", "LotteryStationId");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.Salesclerk", b =>
                    {
                        b.ForeignKey("WelfareLotteryWebsite.DBModels.LotteryStation", "LotteryStationId");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.SportLottery", b =>
                    {
                        b.ForeignKey("WelfareLotteryWebsite.DBModels.SportLotteryGameType", "GameTypeId");
                    });
                
                builder.Entity("WelfareLotteryWebsite.DBModels.StationModifiedInfo", b =>
                    {
                        b.ForeignKey("WelfareLotteryWebsite.DBModels.LotteryStation", "LotteryStationId");
                        b.ForeignKey("WelfareLotteryWebsite.DBModels.StationModifiedType", "ModifiedTypeId");
                    });
                
                return builder.Model;
            }
        }
    }
}
