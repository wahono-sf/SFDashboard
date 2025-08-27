using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlbl1DebitCredit
    {
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Financial Year")]
        [StringLength(4)]
        public string? FinancialYear { get; set; }
        [Column("Mth 01 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth01DebitBalance { get; set; }
        [Column("Mth 01 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth01CreditBalance { get; set; }
        [Column("Mth 02 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth02DebitBalance { get; set; }
        [Column("Mth 02 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth02CreditBalance { get; set; }
        [Column("Mth 03 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth03DebitBalance { get; set; }
        [Column("Mth 03 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth03CreditBalance { get; set; }
        [Column("Mth 04 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth04DebitBalance { get; set; }
        [Column("Mth 04 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth04CreditBalance { get; set; }
        [Column("Mth 05 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth05DebitBalance { get; set; }
        [Column("Mth 05 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth05CreditBalance { get; set; }
        [Column("Mth 06 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth06DebitBalance { get; set; }
        [Column("Mth 06 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth06CreditBalance { get; set; }
        [Column("Mth 07 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth07DebitBalance { get; set; }
        [Column("Mth 07 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth07CreditBalance { get; set; }
        [Column("Mth 08 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth08DebitBalance { get; set; }
        [Column("Mth 08 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth08CreditBalance { get; set; }
        [Column("Mth 09 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth09DebitBalance { get; set; }
        [Column("Mth 09 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth09CreditBalance { get; set; }
        [Column("Mth 10 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth10DebitBalance { get; set; }
        [Column("Mth 10 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth10CreditBalance { get; set; }
        [Column("Mth 11 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth11DebitBalance { get; set; }
        [Column("Mth 11 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth11CreditBalance { get; set; }
        [Column("Mth 12 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth12DebitBalance { get; set; }
        [Column("Mth 12 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth12CreditBalance { get; set; }
        [Column("Mth 13 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth13DebitBalance { get; set; }
        [Column("Mth 13 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth13CreditBalance { get; set; }
        [Column("Mth 14 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth14DebitBalance { get; set; }
        [Column("Mth 14 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth14CreditBalance { get; set; }
        [Column("Mth 15 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth15DebitBalance { get; set; }
        [Column("Mth 15 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth15CreditBalance { get; set; }
        [Column("Mth 16 Debit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth16DebitBalance { get; set; }
        [Column("Mth 16 Credit Balance", TypeName = "decimal(38, 2)")]
        public decimal? Mth16CreditBalance { get; set; }
    }
}
