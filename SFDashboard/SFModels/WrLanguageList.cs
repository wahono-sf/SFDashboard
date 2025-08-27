using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrLanguageList")]
    public partial class WrLanguageList
    {
        [Key]
        [Column("LanguageID")]
        [StringLength(50)]
        public string LanguageId { get; set; } = null!;
        [StringLength(50)]
        public string LanguageName { get; set; } = null!;
        [StringLength(100)]
        public string? LanguageCaption { get; set; }
        [StringLength(50)]
        public string LanguageCultureInfo { get; set; } = null!;
    }
}
