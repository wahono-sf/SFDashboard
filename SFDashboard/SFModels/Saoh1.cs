using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saoh1")]
    [Index("TableName", Name = "IX_saoh1")]
    [Index("FieldName", Name = "IX_saoh1_1")]
    [Index("TableName", "FieldName", Name = "IX_saoh1_2")]
    public partial class Saoh1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(100)]
        public string? FieldName { get; set; }
        [StringLength(2000)]
        public string? HelpDescription { get; set; }
        [StringLength(20)]
        public string? TableName { get; set; }
    }
}
