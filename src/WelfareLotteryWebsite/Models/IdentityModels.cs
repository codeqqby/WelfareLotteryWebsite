using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Framework.OptionsModel;
using WelfareLotteryWebsite.DBModels;
using Microsoft.Framework.ConfigurationModel;

namespace WelfareLotteryWebsite.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private static bool _created;
        /// <summary>
        /// 网点信息
        /// </summary>
        public DbSet<LotteryStation> LotteryStations { get; set; }
        /// <summary>
        /// 管理员
        /// </summary>
        public DbSet<Administrator> Administrators { get; set; }
        /// <summary>
        /// 网点所在区域
        /// </summary>
        public DbSet<StationRegion> StationRegions { get; set; }
        /// <summary>
        /// 店面类型
        /// </summary>
        public DbSet<StationManageType> StationManageTypes { get; set; }
        /// <summary>
        /// 即开奖励卡信息
        /// </summary>
        public DbSet<RewardCardInfo> RewardCardInfos { get; set; }
        /// <summary>
        /// 网点变更信息
        /// </summary>
        public DbSet<StationModifiedInfo> StationModifiedInfos { get; set; }
        /// <summary>
        /// 体彩店信息
        /// </summary>
        public DbSet<SportLottery> SportLotteries { get; set; }
        /// <summary>
        /// 体彩游戏类型
        /// </summary>
        public DbSet<SportLotteryGameType> SportLotteryGameTypes { get; set; }
        /// <summary>
        /// 福彩游戏类型
        /// </summary>
        public DbSet<WelfareLotteryGameType> WelfareLotteryGameTypes { get; set; }
        /// <summary>
        /// 销售员信息
        /// </summary>
        public DbSet<Salesclerk> Salesclerks { get; set; }


        public ApplicationDbContext()
        {
            // Create the database and schema if it doesn't exist
            if (!_created)
            {
                _configuration.AddJsonFile("config.json");
                Database.AsRelational().ApplyMigrations();
                _created = true;
                
            }
        }

        private readonly Configuration _configuration = new Configuration();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["Data:DefaultConnection:ConnectionString"]);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
