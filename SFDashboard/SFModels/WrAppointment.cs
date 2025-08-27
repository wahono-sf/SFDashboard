using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrAppointments")]
    public partial class WrAppointment
    {
        [Key]
        [Column("AppointmentID")]
        public int AppointmentId { get; set; }
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Column("AppointmentCategoryID")]
        public int? AppointmentCategoryId { get; set; }
        [StringLength(50)]
        public string? AppointmentLayout { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(50)]
        public string? RecurrencePattern { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [StringLength(255)]
        public string? Subject { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("WrAppointments")]
        public virtual Saus1 User { get; set; } = null!;
    }
}
