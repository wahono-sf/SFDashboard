using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcbp9")]
    public partial class Rcbp9
    {
        [Key]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(3)]
        public string? DestinationCode { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(10)]
        public string? OriginAgentCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ProfitSharePercent { get; set; }
    }
}
