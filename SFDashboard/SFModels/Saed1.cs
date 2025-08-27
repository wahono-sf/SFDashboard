using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saed1")]
    public partial class Saed1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(150)]
        public string? BccEmailAddr { get; set; }
        [StringLength(150)]
        public string? CcEmailAddr { get; set; }
        [StringLength(100)]
        public string? EdiDescription { get; set; }
        [StringLength(50)]
        public string? EdiName { get; set; }
        [StringLength(10)]
        public string? EdiVersion { get; set; }
        [StringLength(2000)]
        public string? EmailBody { get; set; }
        [StringLength(1000)]
        public string? EmailSignature { get; set; }
        [StringLength(150)]
        public string? EmailSubject { get; set; }
        [StringLength(50)]
        public string? FileFormat { get; set; }
        [StringLength(200)]
        public string? Filter1 { get; set; }
        [StringLength(200)]
        public string? Filter2 { get; set; }
        [StringLength(200)]
        public string? Filter3 { get; set; }
        [StringLength(100)]
        public string? InFolder { get; set; }
        [StringLength(100)]
        public string? LogFolder { get; set; }
        [StringLength(100)]
        public string? OutFolder { get; set; }
        [StringLength(150)]
        public string? RecipientEmailAddr { get; set; }
        [StringLength(1)]
        public string? SchedulerFlag { get; set; }
    }
}
