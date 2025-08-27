using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("Sebl4")]
    public partial class Sebl4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short CargoLineItemNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [Column(TypeName = "decimal(6, 0)")]
        public decimal? BoxNo { get; set; }
        [StringLength(200)]
        public string? CaseMarking { get; set; }
        [Column("CCC")]
        [StringLength(50)]
        public string? Ccc { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ChgWtLbs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(12, 3)")]
        public decimal? GrossWtLbs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(12, 3)")]
        public decimal? IndTrkAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? LooseQty { get; set; }
        [StringLength(50)]
        public string? LooseUomCode { get; set; }
        public int? Pcs { get; set; }
        [StringLength(50)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReqDate { get; set; }
        [StringLength(50)]
        public string? RequestNo { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(12, 3)")]
        public decimal? VolWtLbs { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(50)]
        public string? Vote { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Width { get; set; }
    }
}
