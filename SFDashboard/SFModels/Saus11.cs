using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saus11")]
    [Index("ActivityDescription", Name = "INDEX_saus11_ActivityDescription")]
    [Index("ActivityType", Name = "INDEX_saus11_ActivityType")]
    [Index("CreateDateTime", Name = "INDEX_saus11_CreateDateTime")]
    [Index("TableName", "PrimaryKeyValue", Name = "INDEX_saus11_TableAndValue")]
    [Index("TableName", Name = "INDEX_saus11_TableName")]
    [Index("UserId", Name = "INDEX_saus11_UserID")]
    [Index("WorkStation", Name = "INDEX_saus11_WorkStation")]
    public partial class Saus11
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(250)]
        public string? ActivityDescription { get; set; }
        [StringLength(20)]
        public string? ActivityType { get; set; }
        [StringLength(50)]
        public string? PrimaryKeyName { get; set; }
        [StringLength(50)]
        public string? PrimaryKeyValue { get; set; }
        [StringLength(20)]
        public string? TableName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(20)]
        public string? UserId { get; set; }
        [StringLength(50)]
        public string? WorkStation { get; set; }
    }
}
