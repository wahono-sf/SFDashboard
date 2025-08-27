using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using SFDashboard.Infrastructure;
using SFDashboard.SFModels;
namespace SFDashboard.Models
{
    public class DashboardDetailsRepository : IDashBoardDetailsRepository
    {
        private DashboardDbContext _dashboarddetaildbcontext;
        private SFDbContext _sfcontext;
        public DashboardDetailsRepository(DashboardDbContext context, SFDbContext sfcontext)
        {
            _dashboarddetaildbcontext = context;
            _sfcontext = sfcontext;
        }
        public List<DashBoardDetails> GetallDashboardDetails()
        {
            return _dashboarddetaildbcontext.DashBoardDetails.ToList();
        }

        public List<DashBoardDetails> GetDashBoardDetailsByCode(string DashboardName, string Code)
        {
            if (DashboardName != null && DashboardName != string.Empty)
            {
                if (Code == null || Code == string.Empty)
                {
                    return _dashboarddetaildbcontext.DashBoardDetails.Where(e => e.DashBoardName.StartsWith(DashboardName)).ToList();

                }
                else
                {
                    return _dashboarddetaildbcontext.DashBoardDetails.Where(e => e.DashBoardName.StartsWith(DashboardName) && e.Code.StartsWith(Code)).ToList();

                }
            }
            else
            {
                return _dashboarddetaildbcontext.DashBoardDetails.Where(e => e.ArchiveFlag=="1").ToList();
            }
        }

        public List<DashBoardDetails> GetDashBoardDetailsByDashboardName(string DashboardName)
        {
            return _dashboarddetaildbcontext.DashBoardDetails.Where(e => e.DashBoardName == DashboardName).ToList();
        }

        public List<VwUserMenu> GetUserMenuById(string UserId)
        {
            return _sfcontext.VwUserMenus.Where(e => e.UserId == UserId).ToList();
        }

    }
}
