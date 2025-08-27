using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("safd1")]
    public partial class Safd1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? BoldFlag { get; set; }
        [StringLength(1)]
        public string? CheckDuplicateFlag { get; set; }
        [StringLength(50)]
        public string? ColorCode { get; set; }
        [StringLength(50)]
        public string? FieldName { get; set; }
        [StringLength(50)]
        public string? FontColorCode { get; set; }
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [StringLength(255)]
        public string? MandatoryCondition { get; set; }
        [StringLength(1)]
        public string? MandatoryFlag { get; set; }
        [StringLength(50)]
        public string? NodeName { get; set; }
        [StringLength(1000)]
        public string? PromptMessage { get; set; }
        [StringLength(1000)]
        public string? PromptValue { get; set; }
        [StringLength(50)]
        public string? TableName { get; set; }
    }
}
