using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImpm1ActualStatus
    {
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        public int? BalQty { get; set; }
    }
}
