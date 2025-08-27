using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrDisplayFormTitle")]
    public partial class WrDisplayFormTitle
    {
        [Key]
        [StringLength(30)]
        public string NodeName { get; set; } = null!;
        [Key]
        [StringLength(100)]
        public string DisplayCol { get; set; } = null!;
        [StringLength(255)]
        public string? DisplayText { get; set; }
        [Column("LanguageID1DisPlayText")]
        [StringLength(255)]
        public string? LanguageId1disPlayText { get; set; }
        [Column("LanguageID2DisplayText")]
        [StringLength(255)]
        public string? LanguageId2displayText { get; set; }
        [Column("LanguageID3DisplayText")]
        [StringLength(255)]
        public string? LanguageId3displayText { get; set; }
    }
}
