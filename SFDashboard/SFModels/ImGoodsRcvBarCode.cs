using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class ImGoodsRcvBarCode
    {
        public int TrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        [StringLength(20)]
        public string GoodsReceiptNoteNo { get; set; } = null!;
        [StringLength(3)]
        [Unicode(false)]
        public string? LineNo { get; set; }
        public int? BarCodePrintQty { get; set; }
        [StringLength(255)]
        public string? ProductCode { get; set; }
    }
}
