﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Keyless]
[Table("GIS_Indicators_desc")]
public partial class GisIndicatorsDesc
{
    [Column("OBJECTID")]
    public int Objectid { get; set; }

    [Column("ind_name")]
    [StringLength(255)]
    public string IndName { get; set; }

    [Column("ind_desc")]
    [StringLength(255)]
    public string IndDesc { get; set; }

    [Column("subsector_code")]
    public int? SubsectorCode { get; set; }

    [Column("Indicator_EN")]
    [StringLength(200)]
    [Unicode(false)]
    public string IndicatorEn { get; set; }
}