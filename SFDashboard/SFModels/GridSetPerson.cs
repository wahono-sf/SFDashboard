using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("GridSet_Person")]
    public partial class GridSetPerson
    {
        [Column("lUserId")]
        [StringLength(20)]
        public string LUserId { get; set; } = null!;
        [Column("sTableName")]
        [StringLength(50)]
        public string STableName { get; set; } = null!;
        [Column("sFieldName")]
        [StringLength(50)]
        public string SFieldName { get; set; } = null!;
        [Column("lFieldOrder")]
        public int LFieldOrder { get; set; }
        [Column("lFieldWidth", TypeName = "decimal(6, 2)")]
        public decimal LFieldWidth { get; set; }
        [Column("bFieldVisible")]
        public bool BFieldVisible { get; set; }
    }
}
