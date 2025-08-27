using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrNote")]
    public partial class WrNote
    {
        [Key]
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Key]
        public int NoteItemNo { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime NoteDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NoteTime { get; set; }
        [StringLength(50)]
        public string? NoteTitle { get; set; }
        [StringLength(4000)]
        public string? NoteText { get; set; }
        [StringLength(1)]
        public string? DisplayWhenLogoNon { get; set; }
        [StringLength(20)]
        public string? FlagCode { get; set; }
        [StringLength(1)]
        public string? ReminderFlag { get; set; }
        [StringLength(20)]
        public string? ReminderTime { get; set; }
    }
}
