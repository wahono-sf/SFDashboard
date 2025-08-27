using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrAppList")]
    public partial class WrAppList
    {
        [Key]
        [StringLength(30)]
        public string NodeName { get; set; } = null!;
        [StringLength(30)]
        public string? NodeParent { get; set; }
        [StringLength(255)]
        public string? CommentText { get; set; }
        [StringLength(100)]
        public string? CrossDatabase { get; set; }
        [StringLength(400)]
        public string? DefaultHide { get; set; }
        [StringLength(1)]
        public string? FilterSalesmanFlag { get; set; }
        [StringLength(400)]
        public string? FormDefaultFile { get; set; }
        [StringLength(30)]
        public string? FrmName { get; set; }
        [StringLength(255)]
        public string? MenuUrl { get; set; }
        [StringLength(255)]
        public string? MenuUrlEntry { get; set; }
        [StringLength(255)]
        public string? HideTab { get; set; }
        [StringLength(400)]
        public string? LockField { get; set; }
        [StringLength(30)]
        public string? MainTableName { get; set; }
        [StringLength(30)]
        public string? ModuleName { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? NodeType { get; set; }
        [StringLength(255)]
        public string? Parameter { get; set; }
        public int? SortNo { get; set; }
        [StringLength(200)]
        public string? StatusList { get; set; }
        [StringLength(1)]
        public string? UseFlag { get; set; }
        [StringLength(255)]
        public string? ViewCondition { get; set; }
        [StringLength(255)]
        public string? ViewKey { get; set; }
        [StringLength(30)]
        public string? ViewName { get; set; }
    }
}
