using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaus2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Access Flag")]
        [StringLength(1)]
        public string? AccessFlag { get; set; }
        [Column("Add Flag")]
        [StringLength(1)]
        public string? AddFlag { get; set; }
        [Column("Delete Flag")]
        [StringLength(1)]
        public string? DeleteFlag { get; set; }
        [Column("Edit Flag")]
        [StringLength(1)]
        public string? EditFlag { get; set; }
        [Column("Form Name")]
        [StringLength(50)]
        public string? FormName { get; set; }
        [Column("Form ID")]
        [StringLength(30)]
        public string? FormId { get; set; }
        [Column("Module Name")]
        [StringLength(30)]
        public string? ModuleName { get; set; }
        [Column("Remark Flag")]
        [StringLength(1)]
        public string? RemarkFlag { get; set; }
        [Column("Undelete Flag")]
        [StringLength(1)]
        public string? UndeleteFlag { get; set; }
        [Column("User ID")]
        [StringLength(20)]
        public string? UserId { get; set; }
        [Column("View Flag")]
        [StringLength(1)]
        public string? ViewFlag { get; set; }
    }
}
