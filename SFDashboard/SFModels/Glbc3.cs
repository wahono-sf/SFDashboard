using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glbc3")]
    public partial class Glbc3
    {
        [Key]
        [StringLength(10)]
        public string BankCode { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(15)]
        public string? ChequeRefNo { get; set; }
        [StringLength(20)]
        public string? FirstChequeNo { get; set; }
        [StringLength(20)]
        public string? LastChequeNo { get; set; }
        [StringLength(20)]
        public string? NextChequeNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceivedDate { get; set; }
    }
}
