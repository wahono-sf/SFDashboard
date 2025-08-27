using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlcm2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [StringLength(50)]
        public string? Branch { get; set; }
        [Column("Company Name")]
        [StringLength(80)]
        public string? CompanyName { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("Licence Key")]
        [StringLength(500)]
        public string? LicenceKey { get; set; }
        [StringLength(80)]
        public string? Module { get; set; }
        [Column("No Of User")]
        public int? NoOfUser { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(200)]
        public string? Version { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
    }
}
