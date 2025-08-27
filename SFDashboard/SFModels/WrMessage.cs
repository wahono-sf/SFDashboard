using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrMessage")]
    public partial class WrMessage
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(2000)]
        public string? AttachmentsName { get; set; }
        [StringLength(1)]
        public string? ExternalFlag { get; set; }
        [StringLength(20)]
        public string? KeyName { get; set; }
        [StringLength(50)]
        public string? KeyValue { get; set; }
        [StringLength(4000)]
        public string? Message { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? ReadyRead { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveDate { get; set; }
        [StringLength(400)]
        public string? Recipient { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string? RecipientStatusCode { get; set; }
        [StringLength(20)]
        public string Sender { get; set; } = null!;
        [StringLength(200)]
        public string Subject { get; set; } = null!;
        [StringLength(3)]
        public string SenderStatusCode { get; set; } = null!;
        [StringLength(20)]
        public string? TableName { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
    }
}
