using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSafr2
    {
        [Column("Freight Company Code")]
        [StringLength(10)]
        public string FreightCompanyCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [StringLength(255)]
        public string Action { get; set; } = null!;
        [Column("Action Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ActionDateTime { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string ContactName { get; set; } = null!;
        [StringLength(50)]
        public string Place { get; set; } = null!;
        [StringLength(50)]
        public string Position { get; set; } = null!;
        [StringLength(20)]
        public string Reference { get; set; } = null!;
        [StringLength(255)]
        public string Response { get; set; } = null!;
        [Column("Response Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ResponseDateTime { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
