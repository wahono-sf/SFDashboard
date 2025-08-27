using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class Sysconstraint
    {
        [Column("constid")]
        public int? Constid { get; set; }
        [Column("id")]
        public int? Id { get; set; }
        [Column("colid")]
        public short? Colid { get; set; }
        [Column("spare1")]
        public byte? Spare1 { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("actions")]
        public int? Actions { get; set; }
        [Column("error")]
        public int? Error { get; set; }
    }
}
