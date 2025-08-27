using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SaDatabaseObjectName
    {
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; } = null!;
        [Column("id")]
        public int Id { get; set; }
        [Column("xtype")]
        [StringLength(2)]
        [Unicode(false)]
        public string Xtype { get; set; } = null!;
        [Column("uid")]
        public short Uid { get; set; }
        [Column("info")]
        public short Info { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("base_schema_ver")]
        public int BaseSchemaVer { get; set; }
        [Column("replinfo")]
        public int Replinfo { get; set; }
        [Column("parent_obj")]
        public int ParentObj { get; set; }
        [Column("crdate", TypeName = "datetime")]
        public DateTime Crdate { get; set; }
        [Column("ftcatid")]
        public short Ftcatid { get; set; }
        [Column("schema_ver")]
        public int SchemaVer { get; set; }
        [Column("stats_schema_ver")]
        public int StatsSchemaVer { get; set; }
        [Column("type")]
        [StringLength(2)]
        [Unicode(false)]
        public string? Type { get; set; }
        [Column("userstat")]
        public short? Userstat { get; set; }
        [Column("sysstat")]
        public short? Sysstat { get; set; }
        [Column("indexdel")]
        public short? Indexdel { get; set; }
        [Column("refdate", TypeName = "datetime")]
        public DateTime? Refdate { get; set; }
        [Column("version")]
        public int? Version { get; set; }
        [Column("deltrig")]
        public int? Deltrig { get; set; }
        [Column("instrig")]
        public int? Instrig { get; set; }
        [Column("updtrig")]
        public int? Updtrig { get; set; }
        [Column("seltrig")]
        public int? Seltrig { get; set; }
        [Column("category")]
        public int? Category { get; set; }
        [Column("cache")]
        public short? Cache { get; set; }
        [Column("Object Name")]
        [StringLength(30)]
        public string? ObjectName { get; set; }
    }
}
