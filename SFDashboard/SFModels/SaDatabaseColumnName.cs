using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SaDatabaseColumnName
    {
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; } = null!;
        [Column("id")]
        public int Id { get; set; }
        [Column("xtype")]
        public byte Xtype { get; set; }
        [Column("typestat")]
        public byte Typestat { get; set; }
        [Column("xusertype")]
        public short Xusertype { get; set; }
        [Column("length")]
        public short Length { get; set; }
        [Column("xprec")]
        public byte Xprec { get; set; }
        [Column("xscale")]
        public byte Xscale { get; set; }
        [Column("colid")]
        public short Colid { get; set; }
        [Column("xoffset")]
        public short Xoffset { get; set; }
        [Column("bitpos")]
        public byte Bitpos { get; set; }
        [Column("reserved")]
        public byte Reserved { get; set; }
        [Column("colstat")]
        public short Colstat { get; set; }
        [Column("cdefault")]
        public int Cdefault { get; set; }
        [Column("domain")]
        public int Domain { get; set; }
        [Column("number")]
        public short Number { get; set; }
        [Column("colorder")]
        public short Colorder { get; set; }
        [Column("autoval")]
        [MaxLength(8000)]
        public byte[]? Autoval { get; set; }
        [Column("offset")]
        public short Offset { get; set; }
        [Column("collationid")]
        public int? Collationid { get; set; }
        [Column("language")]
        public int Language { get; set; }
        [Column("status")]
        public byte? Status { get; set; }
        [Column("type")]
        public byte? Type { get; set; }
        [Column("usertype")]
        public short? Usertype { get; set; }
        [Column("printfmt")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Printfmt { get; set; }
        [Column("prec")]
        public short? Prec { get; set; }
        [Column("scale")]
        public int? Scale { get; set; }
        [Column("iscomputed")]
        public int? Iscomputed { get; set; }
        [Column("isoutparam")]
        public int? Isoutparam { get; set; }
        [Column("isnullable")]
        public int? Isnullable { get; set; }
        [Column("collation")]
        [StringLength(128)]
        public string? Collation { get; set; }
        [Column("tdscollation")]
        [MaxLength(5)]
        public byte[]? Tdscollation { get; set; }
        [Column("Object Name")]
        [StringLength(128)]
        public string? ObjectName { get; set; }
        [Column("Column Name")]
        [StringLength(30)]
        public string? ColumnName { get; set; }
        [Column("Auto Value")]
        [StringLength(30)]
        public string? AutoValue { get; set; }
    }
}
