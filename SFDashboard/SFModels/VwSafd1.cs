using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSafd1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Bold Flag")]
        [StringLength(1)]
        public string? BoldFlag { get; set; }
        [Column("Check Duplicate Flag")]
        [StringLength(1)]
        public string? CheckDuplicateFlag { get; set; }
        [Column("Color Code")]
        [StringLength(50)]
        public string? ColorCode { get; set; }
        [Column("Field Name")]
        [StringLength(50)]
        public string? FieldName { get; set; }
        [Column("Font Color Code")]
        [StringLength(50)]
        public string? FontColorCode { get; set; }
        [Column("Lock Flag")]
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [Column("Mandatory Condition")]
        [StringLength(255)]
        public string? MandatoryCondition { get; set; }
        [Column("Mandatory Flag")]
        [StringLength(1)]
        public string? MandatoryFlag { get; set; }
        [Column("Node Name")]
        [StringLength(50)]
        public string? NodeName { get; set; }
        [Column("Prompt Message")]
        [StringLength(1000)]
        public string? PromptMessage { get; set; }
        [Column("Prompt Value")]
        [StringLength(1000)]
        public string? PromptValue { get; set; }
        [Column("Table Name")]
        [StringLength(50)]
        public string? TableName { get; set; }
    }
}
