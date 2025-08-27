using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlbc3
    {
        [Column("Bank Code")]
        [StringLength(10)]
        public string BankCode { get; set; } = null!;
        [Column("Cheque Ref No")]
        [StringLength(15)]
        public string? ChequeRefNo { get; set; }
        [Column("First Cheque No")]
        [StringLength(20)]
        public string? FirstChequeNo { get; set; }
        [Column("Last Cheque No")]
        [StringLength(20)]
        public string? LastChequeNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Next Cheque No")]
        [StringLength(20)]
        public string? NextChequeNo { get; set; }
        [Column("Received Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceivedDate { get; set; }
    }
}
