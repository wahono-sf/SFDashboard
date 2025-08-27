using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAcit2
    {
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string ItemCode { get; set; } = null!;
        [Column("Advance Acc Code")]
        [StringLength(15)]
        public string? AdvanceAccCode { get; set; }
        [Column("Bill Type")]
        [StringLength(2)]
        public string? BillType { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Cost Acc Code")]
        [StringLength(15)]
        public string? CostAccCode { get; set; }
        [Column("Customer Charge Code")]
        [StringLength(6)]
        public string? CustomerChargeCode { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Main Customer Code")]
        [StringLength(10)]
        public string? MainCustomerCode { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("Provision Acc Code")]
        [StringLength(15)]
        public string? ProvisionAccCode { get; set; }
        [Column("Sales Acc Code")]
        [StringLength(15)]
        public string? SalesAccCode { get; set; }
    }
}
