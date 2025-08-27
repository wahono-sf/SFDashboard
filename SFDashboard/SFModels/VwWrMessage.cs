using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrMessage
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachments Name")]
        [StringLength(2000)]
        public string? AttachmentsName { get; set; }
        [Column("External Flag")]
        [StringLength(1)]
        public string? ExternalFlag { get; set; }
        [Column("Key Name")]
        [StringLength(20)]
        public string? KeyName { get; set; }
        [Column("Key Value")]
        [StringLength(50)]
        public string? KeyValue { get; set; }
        [StringLength(4000)]
        public string? Message { get; set; }
        [Column("Ready Read")]
        [StringLength(1)]
        [Unicode(false)]
        public string? ReadyRead { get; set; }
        [Column("Receive Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiveDate { get; set; }
        [StringLength(400)]
        public string? Recipient { get; set; }
        [Column("Recipient Status Code")]
        [StringLength(3)]
        [Unicode(false)]
        public string? RecipientStatusCode { get; set; }
        [StringLength(20)]
        public string Sender { get; set; } = null!;
        [Column("Sender Status Code")]
        [StringLength(3)]
        public string SenderStatusCode { get; set; } = null!;
        [StringLength(200)]
        public string Subject { get; set; } = null!;
        [Column("Table Name")]
        [StringLength(20)]
        public string? TableName { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
    }
}
