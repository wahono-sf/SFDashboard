using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SaDatabaseIndex
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("first")]
        [MaxLength(6)]
        public byte[] First { get; set; } = null!;
        [Column("indid")]
        public short Indid { get; set; }
        [Column("root")]
        [MaxLength(6)]
        public byte[] Root { get; set; } = null!;
        [Column("minlen")]
        public short Minlen { get; set; }
        [Column("keycnt")]
        public short Keycnt { get; set; }
        [Column("groupid")]
        public short Groupid { get; set; }
        [Column("dpages")]
        public int Dpages { get; set; }
        [Column("reserved")]
        public int Reserved { get; set; }
        [Column("used")]
        public int Used { get; set; }
        [Column("rowcnt")]
        public long Rowcnt { get; set; }
        [Column("rowmodctr")]
        public int Rowmodctr { get; set; }
        [Column("reserved3")]
        public byte Reserved3 { get; set; }
        [Column("reserved4")]
        public byte Reserved4 { get; set; }
        [Column("xmaxlen")]
        public short Xmaxlen { get; set; }
        [Column("maxirow")]
        public short Maxirow { get; set; }
        public byte OrigFillFactor { get; set; }
        public byte StatVersion { get; set; }
        [Column("reserved2")]
        public int Reserved2 { get; set; }
        [Column("FirstIAM")]
        [MaxLength(6)]
        public byte[] FirstIam { get; set; } = null!;
        [Column("impid")]
        public short Impid { get; set; }
        [Column("lockflags")]
        public short Lockflags { get; set; }
        [Column("pgmodctr")]
        public int Pgmodctr { get; set; }
        [Column("keys")]
        [MaxLength(1088)]
        public byte[]? Keys { get; set; }
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; } = null!;
        [Column("statblob", TypeName = "image")]
        public byte[]? Statblob { get; set; }
        [Column("maxlen")]
        public int Maxlen { get; set; }
        [Column("rows")]
        public int? Rows { get; set; }
    }
}
