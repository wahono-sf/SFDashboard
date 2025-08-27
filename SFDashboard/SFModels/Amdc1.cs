using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amdc1")]
    public partial class Amdc1
    {
        [Key]
        public short TrxNo { get; set; }
        [StringLength(3)]
        public string AwbChargeCode { get; set; } = null!;
        [StringLength(5)]
        public string DistrictCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate01 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate02 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate03 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate04 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate05 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate06 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate07 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate08 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate09 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate10 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate11 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate12 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate13 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate14 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate15 { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate16 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak01 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak02 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak03 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak04 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak05 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak06 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak07 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak08 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak09 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak10 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak11 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak12 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak13 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak14 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak15 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak16 { get; set; }
        [StringLength(1)]
        public string? WeightType { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [ForeignKey("AwbChargeCode")]
        [InverseProperty("Amdc1s")]
        public virtual Rchc1 AwbChargeCodeNavigation { get; set; } = null!;
        [ForeignKey("DistrictCode")]
        [InverseProperty("Amdc1s")]
        public virtual Rcdc1 DistrictCodeNavigation { get; set; } = null!;
        [ForeignKey("SalesItemCode")]
        [InverseProperty("Amdc1s")]
        public virtual Acit1? SalesItemCodeNavigation { get; set; }
    }
}
