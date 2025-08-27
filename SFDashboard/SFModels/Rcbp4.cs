using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcbp4")]
    public partial class Rcbp4
    {
        [Key]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(10)]
        public string? CompetitorCode { get; set; }
        [StringLength(80)]
        public string? CompetitorName { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
