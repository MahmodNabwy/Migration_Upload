﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("TRADE_FOR_CHAPTERS")]
public partial class TradeForChapter
{
    [Key]
    [Column("CHAPTERS_ID", TypeName = "numeric(38, 0)")]
    public decimal ChaptersId { get; set; }

    [Column("CHAPTERS_NAMEEN")]
    [StringLength(400)]
    public string ChaptersNameen { get; set; }

    [Column("CHAPTERS_NAMEAR")]
    [StringLength(376)]
    public string ChaptersNamear { get; set; }

    [Column("CHAPTERS_CODE")]
    [StringLength(4)]
    public string ChaptersCode { get; set; }
}