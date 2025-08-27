using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlvn2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Party Code")]
        [StringLength(10)]
        public string? PartyCode { get; set; }
        [Column("Party Type")]
        [StringLength(1)]
        public string? PartyType { get; set; }
        [StringLength(50)]
        public string? Relationship { get; set; }
    }
}
