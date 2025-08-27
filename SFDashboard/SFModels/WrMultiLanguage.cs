using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrMultiLanguage")]
    [Index("FrmName", "CtlName", Name = "IX_wrMultiLanguage")]
    [Index("ActualEnucaption", Name = "IX_wrMultiLanguage_ActualENUCaption")]
    [Index("FrmName", Name = "IX_wrMultiLanguage_frmName")]
    public partial class WrMultiLanguage
    {
        [Key]
        [Column("frmName")]
        [StringLength(100)]
        public string FrmName { get; set; } = null!;
        [Key]
        [Column("ctlName")]
        [StringLength(100)]
        public string CtlName { get; set; } = null!;
        [Key]
        [Column("ctlColumnNo")]
        public int CtlColumnNo { get; set; }
        [Column("ActualENUCaption")]
        [StringLength(255)]
        public string? ActualEnucaption { get; set; }
        [Column("ctlColumnName")]
        [StringLength(255)]
        public string? CtlColumnName { get; set; }
        [StringLength(255)]
        public string? DefaultData { get; set; }
        [Column("ENUCaption")]
        [StringLength(255)]
        public string? Enucaption { get; set; }
        [StringLength(255)]
        public string? LanguageType { get; set; }
        [Column("LanguageID1Caption")]
        [StringLength(500)]
        public string? LanguageId1caption { get; set; }
        [Column("LanguageID1FontName")]
        [StringLength(255)]
        public string? LanguageId1fontName { get; set; }
        [Column("LanguageID1FontSize")]
        [StringLength(255)]
        public string? LanguageId1fontSize { get; set; }
        [Column("LanguageID1FontStyle")]
        [StringLength(255)]
        public string? LanguageId1fontStyle { get; set; }
        [Column("LanguageID2Caption")]
        [StringLength(500)]
        public string? LanguageId2caption { get; set; }
        [Column("LanguageID2FontName")]
        [StringLength(255)]
        public string? LanguageId2fontName { get; set; }
        [Column("LanguageID2FontSize")]
        [StringLength(255)]
        public string? LanguageId2fontSize { get; set; }
        [Column("LanguageID2FontStyle")]
        [StringLength(255)]
        public string? LanguageId2fontStyle { get; set; }
        [Column("LanguageID3Caption")]
        [StringLength(500)]
        public string? LanguageId3caption { get; set; }
        [Column("LanguageID3FontName")]
        [StringLength(255)]
        public string? LanguageId3fontName { get; set; }
        [Column("LanguageID3FontSize")]
        [StringLength(255)]
        public string? LanguageId3fontSize { get; set; }
        [Column("LanguageID3FontStyle")]
        [StringLength(255)]
        public string? LanguageId3fontStyle { get; set; }
    }
}
