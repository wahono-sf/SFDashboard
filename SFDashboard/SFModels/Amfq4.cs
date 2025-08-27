using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amfq4")]
    public partial class Amfq4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short QuoteLineItemNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [StringLength(3)]
        public string? AirportDestCode { get; set; }
    }
}
