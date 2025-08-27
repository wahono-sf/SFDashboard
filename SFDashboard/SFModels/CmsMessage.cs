using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("cms_message")]
    public partial class CmsMessage
    {
        [Key]
        public int SequenceId { get; set; }
        [StringLength(20)]
        public string? MsgType { get; set; }
        [StringLength(200)]
        public string? JobType { get; set; }
        [StringLength(20)]
        public string? JobOrder { get; set; }
        [StringLength(20)]
        public string? TriggerType { get; set; }
        [StringLength(20)]
        public string? MsgStatus { get; set; }
        [StringLength(1000)]
        public string? MsgNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeQueue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeOut { get; set; }
        [StringLength(200)]
        public string? SendFrom { get; set; }
        [StringLength(500)]
        public string? SendTo { get; set; }
        [StringLength(200)]
        public string? SendCc { get; set; }
        [StringLength(200)]
        public string? SendBcc { get; set; }
        [StringLength(200)]
        public string? SendSubject { get; set; }
        [StringLength(1000)]
        public string? SendContent { get; set; }
        [StringLength(1000)]
        public string? SendFiles { get; set; }
        [StringLength(200)]
        public string? RecFrom { get; set; }
        [StringLength(200)]
        public string? RecTo { get; set; }
        [StringLength(200)]
        public string? RecCc { get; set; }
        [StringLength(200)]
        public string? RecSubject { get; set; }
        [StringLength(1000)]
        public string? RecContent { get; set; }
        [StringLength(1000)]
        public string? RecFiles { get; set; }
    }
}
