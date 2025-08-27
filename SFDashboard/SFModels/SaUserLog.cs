using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SaUserLog
    {
        [Column("Activity Description")]
        [StringLength(1000)]
        public string? ActivityDescription { get; set; }
        [Column("Activity Type")]
        [StringLength(20)]
        public string? ActivityType { get; set; }
        [Column("Primary Key Name")]
        [StringLength(50)]
        public string? PrimaryKeyName { get; set; }
        [Column("Primary Key Value")]
        [StringLength(50)]
        public string? PrimaryKeyValue { get; set; }
        [Column("Table Name")]
        [StringLength(50)]
        public string? TableName { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("User Id")]
        [StringLength(50)]
        public string? UserId { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
    }
}
