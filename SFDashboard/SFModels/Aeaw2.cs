using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aeaw2")]
    public partial class Aeaw2
    {
        [Key]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [Column(TypeName = "decimal(6, 0)")]
        public decimal? BoxNo { get; set; }
        [StringLength(200)]
        public string? CaseMarking { get; set; }
        [Column("CCC")]
        [StringLength(50)]
        public string? Ccc { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChgWtLb { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Dimension { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWtLb { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? LooseQty { get; set; }
        [StringLength(50)]
        public string? LooseUomCode { get; set; }
        [Column(TypeName = "decimal(22, 0)")]
        public decimal? Pcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReqDate { get; set; }
        [StringLength(50)]
        public string? RequestNo { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? TruckerAmt { get; set; }
        [Column(TypeName = "decimal(11, 4)")]
        public decimal? VolWt { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? VolWtLb { get; set; }
        [StringLength(50)]
        public string? VoteCharge { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Width { get; set; }
    }
}
