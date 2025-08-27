using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tnpa1")]
    public partial class Tnpa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        public int? AlertDays { get; set; }
        [StringLength(17)]
        public string? DeclarantCode { get; set; }
        [StringLength(25)]
        public string? DeclarantCrNo { get; set; }
        [StringLength(100)]
        public string? DeclarantName { get; set; }
        [StringLength(25)]
        public string? DeclarantTel { get; set; }
        [StringLength(255)]
        public string? DocumentSendFolder { get; set; }
        public int? ExpireMonth { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? GstRecoverableAmt { get; set; }
        [StringLength(50)]
        public string? MsgRecvFolder { get; set; }
        [StringLength(50)]
        public string? MsgSendFolder { get; set; }
        [StringLength(20)]
        public string? PartyCode { get; set; }
        [StringLength(35)]
        public string? PartyName1 { get; set; }
        [StringLength(35)]
        public string? PartyName2 { get; set; }
        [StringLength(35)]
        public string? PartyName3 { get; set; }
        [StringLength(35)]
        public string? PartyName4 { get; set; }
        [StringLength(25)]
        public string? PartyTel { get; set; }
        [Column("PartyUEN")]
        [StringLength(20)]
        public string? PartyUen { get; set; }
        [StringLength(20)]
        public string? Password { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PwdUpdateDate { get; set; }
        [Column("RecipientID")]
        [StringLength(12)]
        public string? RecipientId { get; set; }
        [Column("SenderID")]
        [StringLength(12)]
        public string? SenderId { get; set; }
        [StringLength(20)]
        public string? UserId { get; set; }
        [StringLength(50)]
        public string? XsdPath { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
