using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("acit2")]
    [Index("JobType", Name = "INDEX_Acit2_JobType")]
    [Index("ModuleCode", Name = "INDEX_Acit2_ModuleCode")]
    public partial class Acit2
    {
        [Key]
        [StringLength(30)]
        public string ItemCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(15)]
        public string? AdvanceAccCode { get; set; }
        [StringLength(2)]
        public string? BillType { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(15)]
        public string? CostAccCode { get; set; }
        [StringLength(6)]
        public string? CustomerChargeCode { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(10)]
        public string? MainCustomerCode { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(15)]
        public string? ProvisionAccCode { get; set; }
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
    }
}
