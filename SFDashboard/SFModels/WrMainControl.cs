using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrMainControl")]
    public partial class WrMainControl
    {
        [Key]
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [StringLength(1)]
        public string? CaculatorAutoHide { get; set; }
        [StringLength(1)]
        public string? CaculatorClosed { get; set; }
        public int? CaculatorDockState { get; set; }
        public int? CaculatorDockStyle { get; set; }
        [StringLength(50)]
        public string? CaculatorFloatingLocation { get; set; }
        [StringLength(50)]
        public string? CaculatorSize { get; set; }
        [StringLength(1)]
        public string? CalendarsAutoHide { get; set; }
        [StringLength(1)]
        public string? CalendarsClosed { get; set; }
        public int? CalendarsDockState { get; set; }
        public int? CalendarsDockStyle { get; set; }
        [StringLength(50)]
        public string? CalendarsFloatingLocation { get; set; }
        [StringLength(50)]
        public string? CalendarsSize { get; set; }
        [StringLength(1)]
        public string? GridAutoHide { get; set; }
        [StringLength(50)]
        public string? GridSize { get; set; }
        [StringLength(1)]
        public string? DocumentSearchFlag { get; set; }
        [StringLength(20)]
        public string? DocumentSearchLocation { get; set; }
        public int? DocumentSearchRowIndex { get; set; }
        [StringLength(1)]
        public string? MenuBarFlag { get; set; }
        [StringLength(20)]
        public string? MenuBarLocation { get; set; }
        public int? MenuBarRowIndex { get; set; }
        [StringLength(1)]
        public string? NoteCalendarsAutoHide { get; set; }
        [StringLength(1)]
        public string? NoteCalendarsClosed { get; set; }
        [StringLength(50)]
        public string? NoteCalendarsFloatingLocation { get; set; }
        public int? NoteCalendarsDockState { get; set; }
        public int? NoteCalendarsDockStyle { get; set; }
        [StringLength(50)]
        public string? NoteCalendarsSize { get; set; }
        [StringLength(50)]
        public string? RemarkCalendarsSize { get; set; }
        public int? RemarkCalendarsDockState { get; set; }
        public int? RemarkCalendarsDockStyle { get; set; }
        [StringLength(1)]
        public string? RemarkCalendarsAutoHide { get; set; }
        [StringLength(50)]
        public string? RemarkCalendarsFloatingLocation { get; set; }
        [StringLength(1)]
        public string? RemarkCalendarsClosed { get; set; }
        [StringLength(100)]
        public string? SelectModule { get; set; }
        [StringLength(200)]
        public string? SelectNodeName { get; set; }
        [StringLength(1)]
        public string? ShortCutFlag { get; set; }
        [StringLength(20)]
        public string? ShortCutLocation { get; set; }
        public int? ShortCutRowIndex { get; set; }
        [StringLength(1)]
        public string? ToolsFlag { get; set; }
        [StringLength(20)]
        public string? ToolsLocation { get; set; }
        public int? ToolsRowIndex { get; set; }
        [StringLength(1)]
        public string? TreeAutoHide { get; set; }
        [StringLength(50)]
        public string? TreeSize { get; set; }
    }
}
