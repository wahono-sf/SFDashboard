using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrLanguageList
    {
        [Column("Language ID")]
        [StringLength(50)]
        public string LanguageId { get; set; } = null!;
        [Column("Language Caption")]
        [StringLength(100)]
        public string? LanguageCaption { get; set; }
        [Column("Language Culture Info")]
        [StringLength(50)]
        public string LanguageCultureInfo { get; set; } = null!;
        [Column("Language Name")]
        [StringLength(50)]
        public string LanguageName { get; set; } = null!;
    }
}
