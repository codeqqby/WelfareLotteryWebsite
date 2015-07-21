using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Framework.ConfigurationModel;
using WelfareLotteryWebsite.DBModels;

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
        /// <summary>
        /// 操作日志
        /// </summary>
        public DbSet<Logs> Logses { get; set; }

        public ApplicationDbContext()
        {
            // Create the database and schema if it doesn't exist
            if (!_created)
            {
                _configuration.AddJsonFile("config.json");
                Database.AsRelational().ApplyMigrations();
                _created = true;
                AddUserAndRoles();
            }
        }

        private readonly Configuration _configuration = new Configuration();
        private string connectionString= null;
        public string outConnectionString = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                connectionString =( connectionString?? _configuration["Data:DefaultConnection:ConnectionString"])??outConnectionString;
                if (connectionString != null)
                    optionsBuilder.UseSqlServer(connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        /// <summary>
        /// 创建默角色和一个管理员帐号
        /// </summary>
        /// <returns></returns>
        void AddUserAndRoles()
        {
            bool success = false;
            var idManager = new IdentityManager();

            if (!idManager.RoleExistsAsync("Admin").Result)
            {
                success = idManager.CreateRoleAsync("Admin").Result;
            }
            if (!idManager.RoleExistsAsync("Operator").Result)
            {
                success = idManager.CreateRoleAsync("Operator").Result;
            }
            if (!idManager.RoleExistsAsync("Member").Result)
            {
                success = idManager.CreateRoleAsync("Member").Result;
            }

            if (!idManager.UserExistsAsync("admin").Result)
            {
                var newUser = new ApplicationUser()
                {
                    UserName = "admin",
                    Email = "admin@admin.com"
                };
                success = idManager.CreateUserAsync(newUser, "admin").Result;
                success = idManager.AddUserToRoleAsync(newUser, "Admin").Result;
            }
        }
    }

    public class IdentityManager
    {
        // 判断角色是否已在存在
        public async Task<bool> RoleExistsAsync(string name)
        {
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()), null, null,
                null, null, null);
            return await rm.RoleExistsAsync(name);
        }

        // 新增角色
        public async Task<bool> CreateRoleAsync(string name)
        {
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()), null, null,
                null, null, null);
            IdentityResult idResult = await rm.CreateAsync(new IdentityRole(name));
            return idResult.Succeeded;
        }

        //是否有此用户
        public async Task<bool> UserExistsAsync(string name)
        {
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()),null,new PasswordHasher<ApplicationUser>(),null,null,null, null, null, null, null);
            return await um.FindByNameAsync(name) != null;
        }
        
        // 新增角色
        public async Task<bool> CreateUserAsync(ApplicationUser user, string pass)
        {
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()), null, new PasswordHasher<ApplicationUser>(), null, null, null, null, null, null, null);
            var idResult = await um.CreateAsync(user, pass);
            return idResult.Succeeded;
        } 

        // 将使用者加入角
        public async Task<bool> AddUserToRoleAsync(ApplicationUser user, string roleName)
        {
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()), null, new PasswordHasher<ApplicationUser>(), null, null, null, null, null, null, null);
            var idResult = await um.AddToRoleAsync(user, roleName);
            return idResult.Succeeded;
        }
    }
}
