using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcbp9
    {
        [Column("Business Party Code")]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Destination Code")]
        [StringLength(3)]
        public string? DestinationCode { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("Origin Agent Code")]
        [StringLength(10)]
        public string? OriginAgentCode { get; set; }
        [Column("Profit Share Percent", TypeName = "decimal(13, 2)")]
        public decimal? ProfitSharePercent { get; set; }
    }
}
