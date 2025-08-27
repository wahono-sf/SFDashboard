using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrApplist
    {
        [Column("Comment Text")]
        [StringLength(255)]
        public string? CommentText { get; set; }
        [Column("Cross Database")]
        [StringLength(100)]
        public string? CrossDatabase { get; set; }
        [Column("Default Hide")]
        [StringLength(400)]
        public string? DefaultHide { get; set; }
        [Column("Filter Salesman Flag")]
        [StringLength(1)]
        public string? FilterSalesmanFlag { get; set; }
        [Column("Form Default File")]
        [StringLength(400)]
        public string? FormDefaultFile { get; set; }
        [Column("Frm Name")]
        [StringLength(30)]
        public string? FrmName { get; set; }
        [Column("Hide Tab")]
        [StringLength(255)]
        public string? MenuUrl { get; set; }
        [StringLength(255)]
        public string? MenuUrlEntry { get; set; }
        [StringLength(255)]
        public string? HideTab { get; set; }
        [Column("Lock Field")]
        [StringLength(400)]
        public string? LockField { get; set; }
        [Column("Main Table Name")]
        [StringLength(30)]
        public string? MainTableName { get; set; }
        [Column("Module Name")]
        [StringLength(30)]
        public string? ModuleName { get; set; }
        [Column("Node Name")]
        [StringLength(30)]
        public string NodeName { get; set; } = null!;
        [Column("Node Parent")]
        [StringLength(30)]
        public string? NodeParent { get; set; }
        [Column("Node Type")]
        [StringLength(1)]
        [Unicode(false)]
        public string? NodeType { get; set; }
        [StringLength(255)]
        public string? Parameter { get; set; }
        [Column("Sort No")]
        public int? SortNo { get; set; }
        [Column("Status List")]
        [StringLength(200)]
        public string? StatusList { get; set; }
        [Column("Use Flag")]
        [StringLength(1)]
        public string? UseFlag { get; set; }
        [Column("View Condition")]
        [StringLength(255)]
        public string? ViewCondition { get; set; }
        [Column("View Name")]
        [StringLength(30)]
        public string? ViewName { get; set; }
        [Column("View Key")]
        [StringLength(255)]
        public string? ViewKey { get; set; }
    }
}
