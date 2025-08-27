using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTnpa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Alert Days")]
        public int? AlertDays { get; set; }
        [Column("Declarant Code")]
        [StringLength(17)]
        public string? DeclarantCode { get; set; }
        [Column("Declarant Cr No")]
        [StringLength(25)]
        public string? DeclarantCrNo { get; set; }
        [Column("Declarant Name")]
        [StringLength(100)]
        public string? DeclarantName { get; set; }
        [Column("Declarant Tel")]
        [StringLength(25)]
        public string? DeclarantTel { get; set; }
        [Column("Document Send Folder")]
        [StringLength(255)]
        public string? DocumentSendFolder { get; set; }
        [Column("Expire Month")]
        public int? ExpireMonth { get; set; }
        [Column("GST Recoverable Amt", TypeName = "decimal(13, 2)")]
        public decimal? GstRecoverableAmt { get; set; }
        [Column("Message Receive Folder")]
        [StringLength(50)]
        public string? MessageReceiveFolder { get; set; }
        [Column("Message Send Folder")]
        [StringLength(50)]
        public string? MessageSendFolder { get; set; }
        [Column("Party Code")]
        [StringLength(20)]
        public string? PartyCode { get; set; }
        [Column("Party Name 1")]
        [StringLength(35)]
        public string? PartyName1 { get; set; }
        [Column("Party Name 2")]
        [StringLength(35)]
        public string? PartyName2 { get; set; }
        [Column("Party Name 3")]
        [StringLength(35)]
        public string? PartyName3 { get; set; }
        [Column("Party Name 4")]
        [StringLength(35)]
        public string? PartyName4 { get; set; }
        [Column("Party Tel")]
        [StringLength(25)]
        public string? PartyTel { get; set; }
        [Column("Party UEN")]
        [StringLength(20)]
        public string? PartyUen { get; set; }
        [StringLength(20)]
        public string? Password { get; set; }
        [Column("Password Update Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PasswordUpdateDate { get; set; }
        [Column("Recipient ID")]
        [StringLength(12)]
        public string? RecipientId { get; set; }
        [Column("Sender ID")]
        [StringLength(12)]
        public string? SenderId { get; set; }
        [Column("User ID")]
        [StringLength(20)]
        public string? UserId { get; set; }
        [Column("Xsd Path")]
        [StringLength(50)]
        public string? XsdPath { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
