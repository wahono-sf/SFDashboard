using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwIvpa3
    {
        [Column("Unique Key")]
        public int UniqueKey { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Outlay Vat Acc Code")]
        [StringLength(15)]
        public string? OutlayVatAccCode { get; set; }
        [Column("Outlay Vat Item Code")]
        [StringLength(30)]
        public string? OutlayVatItemCode { get; set; }
    }
}
