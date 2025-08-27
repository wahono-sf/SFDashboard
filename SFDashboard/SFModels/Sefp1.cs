using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sefp1")]
    public partial class Sefp1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BafFee { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BankCharge { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BlFee { get; set; }
        [StringLength(30)]
        public string? BlNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Commission { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OceanFreight { get; set; }
        [StringLength(20)]
        public string? PaymentNo { get; set; }
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
    }
}
