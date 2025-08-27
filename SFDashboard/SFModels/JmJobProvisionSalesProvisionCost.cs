using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobProvisionSalesProvisionCost
    {
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Qty { get; set; }
        [Column("Unit Rate", TypeName = "decimal(15, 5)")]
        public decimal? UnitRate { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "decimal(36, 9)")]
        public decimal? Amt { get; set; }
        [Column("Local Amt", TypeName = "decimal(15, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Vat Code")]
        [StringLength(3)]
        public string? VatCode { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
    }
}
