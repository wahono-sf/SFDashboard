using Microsoft.EntityFrameworkCore;
using SFDashboard.SFModels;
using System.ComponentModel.DataAnnotations;

namespace SFDashboard.Models
{
    public class DashboardDbContext : DbContext
    {
        public DashboardDbContext(DbContextOptions<DashboardDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccessID>()
                  .HasKey(m => new { m.UserId });
            modelBuilder.Entity<Tab>()
               .HasKey(m => new { m.TabCode });
            modelBuilder.Entity<TabDetail>()
               .HasKey(m => new { m.TabCode,m.DashBoardName, m.code2, m.Code, m.CustomerCode,m.UserId });
            modelBuilder.Entity<DashBoardDetails>()
                .HasKey(m => new { m.DashBoardName,m.code2,m.Code,m.CustomerCode });
        }

        // public DbSet<DashboardModel> DashboardModels { get; set; }
        public DbSet<DashBoardDetails> DashBoardDetails { get; set; }
        public DbSet<Tab> Tab { get; set; }
        public DbSet<UserAccessID> UserAccessID { get; set; }

        public DbSet<TabDetail> TabDetails { get; set; }
        //public DbSet<SPViewModel> SPViewModels { get; set; }
        //public class SPViewModel
        //{
        //    public int value { get; set; }
        //}
    }

    //public class SecondDbContext : DbContext
    //{
    //    public SecondDbContext(DbContextOptions<DashboardDbContext> options) : base(options)
    //    {

      //  }

        //public DbSet<DashboardModel> DashboardModels { get; set; }
        //public DbSet<SPViewModel> SPViewModels { get; set; }
        //public class SPViewModel
        //{
        //    public int value { get; set; }
        //}
    //}
}
