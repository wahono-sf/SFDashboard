using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaed1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Bcc Email Addr")]
        [StringLength(150)]
        public string? BccEmailAddr { get; set; }
        [Column("Cc Email Addr")]
        [StringLength(150)]
        public string? CcEmailAddr { get; set; }
        [Column("Edi Description")]
        [StringLength(100)]
        public string? EdiDescription { get; set; }
        [Column("Edi Name")]
        [StringLength(50)]
        public string? EdiName { get; set; }
        [Column("Edi Version")]
        [StringLength(10)]
        public string? EdiVersion { get; set; }
        [Column("Email Body")]
        [StringLength(2000)]
        public string? EmailBody { get; set; }
        [Column("Email Signature")]
        [StringLength(1000)]
        public string? EmailSignature { get; set; }
        [Column("Email Subject")]
        [StringLength(150)]
        public string? EmailSubject { get; set; }
        [Column("File Format")]
        [StringLength(50)]
        public string? FileFormat { get; set; }
        [Column("Filter 1")]
        [StringLength(200)]
        public string? Filter1 { get; set; }
        [Column("Filter 2")]
        [StringLength(200)]
        public string? Filter2 { get; set; }
        [Column("Filter 3")]
        [StringLength(200)]
        public string? Filter3 { get; set; }
        [Column("In Folder")]
        [StringLength(100)]
        public string? InFolder { get; set; }
        [Column("Log Folder")]
        [StringLength(100)]
        public string? LogFolder { get; set; }
        [Column("Out Folder")]
        [StringLength(100)]
        public string? OutFolder { get; set; }
        [Column("Recipient Email Addr")]
        [StringLength(150)]
        public string? RecipientEmailAddr { get; set; }
        [Column("Scheduler Flag")]
        [StringLength(1)]
        public string? SchedulerFlag { get; set; }
    }
}
