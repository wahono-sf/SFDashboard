using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("Tmp_Edi_Message")]
    public partial class TmpEdiMessage
    {
        public long? Seqno { get; set; }
        [Column("SQLStr")]
        [StringLength(8000)]
        [Unicode(false)]
        public string? Sqlstr { get; set; }
    }
}
