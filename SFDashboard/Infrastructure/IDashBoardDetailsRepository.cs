using SFDashboard.Models;
using SFDashboard.SFModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SFDashboard.Infrastructure
{
    public interface IDashBoardDetailsRepository
    {
        List<DashBoardDetails> GetDashBoardDetailsByCode(string DashboardName,string Code);
        List<DashBoardDetails> GetDashBoardDetailsByDashboardName(string DashboardName);
        List<DashBoardDetails> GetallDashboardDetails();

        List<VwUserMenu> GetUserMenuById(string UserId);

    }
}
