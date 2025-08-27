using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlfb1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string AccCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string CurrCode { get; set; } = null!;
        [Column("Current Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? CurrentBalanceAmt { get; set; }
        [Column("Last Yr End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrEndBalanceAmt { get; set; }
        [Column("Last Yr Mth 01 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01BalanceAmt { get; set; }
        [Column("Last Yr Mth 02 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02BalanceAmt { get; set; }
        [Column("Last Yr Mth 03 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03BalanceAmt { get; set; }
        [Column("Last Yr Mth 04 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04BalanceAmt { get; set; }
        [Column("Last Yr Mth 05 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05BalanceAmt { get; set; }
        [Column("Last Yr Mth 06 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06BalanceAmt { get; set; }
        [Column("Last Yr Mth 07 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07BalanceAmt { get; set; }
        [Column("Last Yr Mth 08 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08BalanceAmt { get; set; }
        [Column("Last Yr Mth 09 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09BalanceAmt { get; set; }
        [Column("Last Yr Mth 10 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10BalanceAmt { get; set; }
        [Column("Last Yr Mth 11 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11BalanceAmt { get; set; }
        [Column("Last Yr Mth 12 Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12BalanceAmt { get; set; }
        [Column("Last Yr Open Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrOpenBalanceAmt { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("This Mth 01 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth01EndBalanceAmt { get; set; }
        [Column("This Mth 02 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth02EndBalanceAmt { get; set; }
        [Column("This Mth 03 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth03EndBalanceAmt { get; set; }
        [Column("This Mth 04 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth04EndBalanceAmt { get; set; }
        [Column("This Mth 05 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth05EndBalanceAmt { get; set; }
        [Column("This Mth 06 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth06EndBalanceAmt { get; set; }
        [Column("This Mth 07 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth07EndBalanceAmt { get; set; }
        [Column("This Mth 08 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth08EndBalanceAmt { get; set; }
        [Column("This Mth 09 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth09EndBalanceAmt { get; set; }
        [Column("This Mth 10 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth10EndBalanceAmt { get; set; }
        [Column("This Mth 11 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth11EndBalanceAmt { get; set; }
        [Column("This Mth 12 End Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisMth12EndBalanceAmt { get; set; }
        [Column("This Yr Open Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrOpenBalanceAmt { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
