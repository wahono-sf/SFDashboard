using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRccm1
    {
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Cas No")]
        [StringLength(12)]
        public string? CasNo { get; set; }
        [Column("Chemical Composition")]
        [StringLength(255)]
        public string? ChemicalComposition { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string CommodityCode { get; set; } = null!;
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Commodity Type")]
        [StringLength(50)]
        public string? CommodityType { get; set; }
        [StringLength(50)]
        public string? Density { get; set; }
        [Column("Dg Packing Group")]
        [StringLength(1)]
        public string? DgPackingGroup { get; set; }
        [Column("Dutiable Flag")]
        [StringLength(1)]
        public string? DutiableFlag { get; set; }
        [Column("Flash Point")]
        [StringLength(20)]
        public string? FlashPoint { get; set; }
        [Column("FOSFA Flag")]
        [StringLength(1)]
        public string? FosfaFlag { get; set; }
        [Column("IMCO")]
        [StringLength(20)]
        public string? Imco { get; set; }
        [Column("KOSHER Flag")]
        [StringLength(1)]
        public string? KosherFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("UN No")]
        [StringLength(20)]
        public string? UnNo { get; set; }
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
