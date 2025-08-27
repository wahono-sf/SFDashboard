using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class IvAllInvoiceVat
    {
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
    }
}
