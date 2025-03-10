﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

public partial class StaticValue
{
    [Key]
    [Column("St_ID")]
    public int StId { get; set; }

    [Column("St_NameAr")]
    [StringLength(50)]
    public string StNameAr { get; set; }

    [Column("St_NameEn")]
    [StringLength(50)]
    public string StNameEn { get; set; }

    [Column("St_BriefAr")]
    [StringLength(50)]
    public string StBriefAr { get; set; }

    [Column("St_BriefEn")]
    [StringLength(50)]
    public string StBriefEn { get; set; }

    [Column("St_IconLink")]
    [StringLength(150)]
    public string StIconLink { get; set; }

    [Column("St_LinkAr")]
    [StringLength(150)]
    public string StLinkAr { get; set; }

    [Column("St_LinkEn")]
    [StringLength(150)]
    public string StLinkEn { get; set; }

    [Column("St_Value")]
    [StringLength(20)]
    public string StValue { get; set; }

    [Column("St_Base")]
    [StringLength(12)]
    public string StBase { get; set; }

    [Column("St_Month")]
    [StringLength(20)]
    public string StMonth { get; set; }

    [Column("St_MonthEn")]
    [StringLength(20)]
    public string StMonthEn { get; set; }

    [Column("St_IsShow")]
    public bool? StIsShow { get; set; }

    [Column("St_IsShowEn")]
    public bool? StIsShowEn { get; set; }
}