using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("Ivcr_ReversePost")]
    public partial class IvcrReversePost
    {
        public int TrxNo { get; set; }
    }
}
