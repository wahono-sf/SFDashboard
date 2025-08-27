using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SaDatabaseComment
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("number")]
        public short Number { get; set; }
        [Column("colid")]
        public short Colid { get; set; }
        [Column("status")]
        public short Status { get; set; }
        [Column("ctext")]
        [MaxLength(8000)]
        public byte[] Ctext { get; set; } = null!;
        [Column("texttype")]
        public short? Texttype { get; set; }
        [Column("language")]
        public short? Language { get; set; }
        [Column("encrypted")]
        public bool? Encrypted { get; set; }
        [Column("compressed")]
        public bool? Compressed { get; set; }
        [Column("text")]
        [StringLength(4000)]
        public string? Text { get; set; }
    }
}
