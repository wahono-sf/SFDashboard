using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saco4")]
    public partial class Saco4
    {
        /// <summary>
        /// Show on find now database name
        /// </summary>
        [Key]
        [StringLength(50)]
        public string DatabaseName { get; set; } = null!;
        [StringLength(50)]
        public string? ColorCode { get; set; }
        /// <summary>
        /// web service connection : &quot;Web Service, Database&quot; or &quot;Web Service, Database, Login User, Password&quot;
        /// Database=web.config database name
        /// </summary>
        [StringLength(100)]
        public string? ConnectionString { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(1)]
        public string? TransferCostingFlag { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
    }
}
