using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaco6
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Branch Name")]
        [StringLength(50)]
        public string? BranchName { get; set; }
        [Column("Address 1")]
        [StringLength(100)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(100)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(100)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(100)]
        public string? Address4 { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
    }
}
