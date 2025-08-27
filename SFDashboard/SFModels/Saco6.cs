using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("Saco6")]
    public partial class Saco6
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(50)]
        public string? BranchName { get; set; }
        [StringLength(100)]
        public string? Address1 { get; set; }
        [StringLength(100)]
        public string? Address2 { get; set; }
        [StringLength(100)]
        public string? Address3 { get; set; }
        [StringLength(100)]
        public string? Address4 { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
    }
}
