using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrNote
    {
        [Column("Display When Logo Non")]
        [StringLength(1)]
        public string? DisplayWhenLogoNon { get; set; }
        [Column("Flag Code")]
        [StringLength(20)]
        public string? FlagCode { get; set; }
        [Column("Note Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NoteDate { get; set; }
        [Column("Note Item No")]
        public int NoteItemNo { get; set; }
        [Column("Note Text")]
        [StringLength(4000)]
        public string? NoteText { get; set; }
        [Column("Note Time", TypeName = "datetime")]
        public DateTime? NoteTime { get; set; }
        [Column("Note Title")]
        [StringLength(50)]
        public string? NoteTitle { get; set; }
        [Column("Reminder Flag")]
        [StringLength(1)]
        public string? ReminderFlag { get; set; }
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
    }
}
