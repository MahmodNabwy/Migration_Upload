﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblIndicatorGeoArea")]
public partial class TblIndicatorGeoArea
{
    [Key]
    [Column("GeoArea_ID")]
    public int GeoAreaId { get; set; }

    [Column("GeoArea_NameAr")]
    [StringLength(30)]
    public string GeoAreaNameAr { get; set; }

    [Column("GeoArea_NameEn")]
    [StringLength(30)]
    public string GeoAreaNameEn { get; set; }
}