using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glbc1")]
    public partial class Glbc1
    {
        [Key]
        [StringLength(10)]
        public string BankCode { get; set; } = null!;
        [StringLength(50)]
        public string? BankName { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(50)]
        public string? BankAccNo { get; set; }
        [StringLength(10)]
        public string? ClearBankCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(1)]
        public string? LockCurrCodeFlag { get; set; }
        [StringLength(20)]
        public string? NextChequeNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? PaymentLimit { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(20)]
        public string? SwiftCode { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
