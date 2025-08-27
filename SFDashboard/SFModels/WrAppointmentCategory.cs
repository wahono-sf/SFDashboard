using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrAppointmentCategories")]
    public partial class WrAppointmentCategory
    {
        [Key]
        [Column("AppointmentCategoryID")]
        public int AppointmentCategoryId { get; set; }
        [StringLength(50)]
        public string? CategoryName { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
    }
}
