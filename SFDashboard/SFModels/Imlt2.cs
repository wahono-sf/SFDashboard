using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imlt2")]
    public partial class Imlt2
    {
        [Key]
        [StringLength(20)]
        public string LotNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        public int? LooseQty { get; set; }
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [StringLength(24)]
        public string? ProductCode { get; set; }
        [StringLength(20)]
        public string? ReceiveNoteOrIssueNoteNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveOrIssueDate { get; set; }
        public int? ReceiveOrIssueTrxNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }

        [ForeignKey("LotNo")]
        [InverseProperty("Imlt2s")]
        public virtual Imlt1 LotNoNavigation { get; set; } = null!;
    }
}
