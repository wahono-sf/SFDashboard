using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaoh1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Field Name")]
        [StringLength(100)]
        public string? FieldName { get; set; }
        [Column("Help Description")]
        [StringLength(2000)]
        public string? HelpDescription { get; set; }
        [Column("Table Name")]
        [StringLength(20)]
        public string? TableName { get; set; }
    }
}
