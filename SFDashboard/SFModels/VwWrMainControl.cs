using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrMainControl
    {
        [Column("Caculator Auto Hide")]
        [StringLength(1)]
        public string? CaculatorAutoHide { get; set; }
        [Column("Caculator Closed")]
        [StringLength(1)]
        public string? CaculatorClosed { get; set; }
        [Column("Caculator Dock State")]
        public int? CaculatorDockState { get; set; }
        [Column("Caculator Dock Style")]
        public int? CaculatorDockStyle { get; set; }
        [Column("Caculator Floating Location")]
        [StringLength(50)]
        public string? CaculatorFloatingLocation { get; set; }
        [Column("Caculator Size")]
        [StringLength(50)]
        public string? CaculatorSize { get; set; }
        [Column("Calendars Auto Hide")]
        [StringLength(1)]
        public string? CalendarsAutoHide { get; set; }
        [Column("Calendars Closed")]
        [StringLength(1)]
        public string? CalendarsClosed { get; set; }
        [Column("Calendars Dock State")]
        public int? CalendarsDockState { get; set; }
        [Column("Calendars Dock Style")]
        public int? CalendarsDockStyle { get; set; }
        [Column("Calendars Floating Location")]
        [StringLength(50)]
        public string? CalendarsFloatingLocation { get; set; }
        [Column("Calendars Size")]
        [StringLength(50)]
        public string? CalendarsSize { get; set; }
        [Column("Document Search Flag")]
        [StringLength(1)]
        public string? DocumentSearchFlag { get; set; }
        [Column("Document Search Location")]
        [StringLength(20)]
        public string? DocumentSearchLocation { get; set; }
        [Column("Document Search Row Index")]
        public int? DocumentSearchRowIndex { get; set; }
        [Column("Grid Auto Hide")]
        [StringLength(1)]
        public string? GridAutoHide { get; set; }
        [Column("Grid Size")]
        [StringLength(50)]
        public string? GridSize { get; set; }
        [Column("Menu Bar Flag")]
        [StringLength(1)]
        public string? MenuBarFlag { get; set; }
        [Column("Menu Bar Location")]
        [StringLength(20)]
        public string? MenuBarLocation { get; set; }
        [Column("Menu Bar Row Index")]
        public int? MenuBarRowIndex { get; set; }
        [Column("Note Calendars Auto Hide")]
        [StringLength(1)]
        public string? NoteCalendarsAutoHide { get; set; }
        [Column("Note Calendars Closed")]
        [StringLength(1)]
        public string? NoteCalendarsClosed { get; set; }
        [Column("Note Calendars Dock State")]
        public int? NoteCalendarsDockState { get; set; }
        [Column("Note Calendars Dock Style")]
        public int? NoteCalendarsDockStyle { get; set; }
        [Column("Note Calendars Floating Location")]
        [StringLength(50)]
        public string? NoteCalendarsFloatingLocation { get; set; }
        [Column("Note Calendars Size")]
        [StringLength(50)]
        public string? NoteCalendarsSize { get; set; }
        [Column("Remark Calendars Auto Hide")]
        [StringLength(1)]
        public string? RemarkCalendarsAutoHide { get; set; }
        [Column("Remark Calendars Closed")]
        [StringLength(1)]
        public string? RemarkCalendarsClosed { get; set; }
        [Column("Remark Calendars Dock State")]
        public int? RemarkCalendarsDockState { get; set; }
        [Column("Remark Calendars Dock Style")]
        public int? RemarkCalendarsDockStyle { get; set; }
        [Column("Remark Calendars Floating Location")]
        [StringLength(50)]
        public string? RemarkCalendarsFloatingLocation { get; set; }
        [Column("Remark Calendars Size")]
        [StringLength(50)]
        public string? RemarkCalendarsSize { get; set; }
        [Column("Select Module")]
        [StringLength(100)]
        public string? SelectModule { get; set; }
        [Column("Select Node Name")]
        [StringLength(200)]
        public string? SelectNodeName { get; set; }
        [Column("Short Cut Flag")]
        [StringLength(1)]
        public string? ShortCutFlag { get; set; }
        [Column("Short Cut Location")]
        [StringLength(20)]
        public string? ShortCutLocation { get; set; }
        [Column("Short Cut Row Index")]
        public int? ShortCutRowIndex { get; set; }
        [Column("Tools Flag")]
        [StringLength(1)]
        public string? ToolsFlag { get; set; }
        [Column("Tools Location")]
        [StringLength(20)]
        public string? ToolsLocation { get; set; }
        [Column("Tools Row Index")]
        public int? ToolsRowIndex { get; set; }
        [Column("Tree Auto Hide")]
        [StringLength(1)]
        public string? TreeAutoHide { get; set; }
        [Column("Tree Size")]
        [StringLength(50)]
        public string? TreeSize { get; set; }
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
    }
}
