using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrMultiLanguage
    {
        [Column("ctl Column Name")]
        [StringLength(255)]
        public string? CtlColumnName { get; set; }
        [Column("ctl Column No")]
        public int CtlColumnNo { get; set; }
        [Column("ctl Name")]
        [StringLength(100)]
        public string CtlName { get; set; } = null!;
        [Column("Actual Enu Caption")]
        [StringLength(255)]
        public string? ActualEnuCaption { get; set; }
        [Column("Default Data")]
        [StringLength(255)]
        public string? DefaultData { get; set; }
        [Column("ENU Caption")]
        [StringLength(255)]
        public string? EnuCaption { get; set; }
        [Column("frm Name")]
        [StringLength(100)]
        public string FrmName { get; set; } = null!;
        [Column("Language ID 1 Caption")]
        [StringLength(500)]
        public string? LanguageId1Caption { get; set; }
        [Column("Language ID 1 Font Name")]
        [StringLength(255)]
        public string? LanguageId1FontName { get; set; }
        [Column("Language ID 1 Font Size")]
        [StringLength(255)]
        public string? LanguageId1FontSize { get; set; }
        [Column("Language ID 1 Font Style")]
        [StringLength(255)]
        public string? LanguageId1FontStyle { get; set; }
        [Column("Language ID 2 Caption")]
        [StringLength(500)]
        public string? LanguageId2Caption { get; set; }
        [Column("Language ID 2 Font Name")]
        [StringLength(255)]
        public string? LanguageId2FontName { get; set; }
        [Column("Language ID 2 Font Size")]
        [StringLength(255)]
        public string? LanguageId2FontSize { get; set; }
        [Column("Language ID 2 Font Style")]
        [StringLength(255)]
        public string? LanguageId2FontStyle { get; set; }
        [Column("Language ID 3 Caption")]
        [StringLength(500)]
        public string? LanguageId3Caption { get; set; }
        [Column("Language ID 3 Font Name")]
        [StringLength(255)]
        public string? LanguageId3FontName { get; set; }
        [Column("Language ID 3 Font Size")]
        [StringLength(255)]
        public string? LanguageId3FontSize { get; set; }
        [Column("Language ID 3 Font Style")]
        [StringLength(255)]
        public string? LanguageId3FontStyle { get; set; }
        [Column("Language Type")]
        [StringLength(255)]
        public string? LanguageType { get; set; }
    }
}
