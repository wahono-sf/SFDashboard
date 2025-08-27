using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("saus2")]
    public partial class Saus2
    {
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? AccessFlag { get; set; }
        [StringLength(1)]
        public string? AddFlag { get; set; }
        [StringLength(1)]
        public string? DeleteFlag { get; set; }
        [StringLength(1)]
        public string? EditFlag { get; set; }
        [StringLength(50)]
        public string? FormName { get; set; }
        [StringLength(30)]
        public string? FormId { get; set; }
        [StringLength(30)]
        public string? ModuleName { get; set; }
        [StringLength(1)]
        public string? RemarkFlag { get; set; }
        [StringLength(1)]
        public string? UndeleteFlag { get; set; }
        [StringLength(20)]
        public string? UserId { get; set; }
        [StringLength(1)]
        public string? ViewFlag { get; set; }
    }
}
