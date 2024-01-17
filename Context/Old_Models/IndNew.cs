﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Keyless]
[Table("ind_new")]
public partial class IndNew
{
    [Column("IndData_ID")]
    public int IndDataId { get; set; }

    [Column("IndData_Value")]
    [StringLength(100)]
    public string IndDataValue { get; set; }

    [Column("IndData_Note")]
    [StringLength(250)]
    public string IndDataNote { get; set; }

    [Column("Ind_ID")]
    public int? IndId { get; set; }

    [Column("Year_ID")]
    public int? YearId { get; set; }

    [Column("Month_ID")]
    public int? MonthId { get; set; }

    [Column("Qurt_ID")]
    public int? QurtId { get; set; }

    [Column("Gov_ID")]
    public int? GovId { get; set; }

    [Column("Gen_ID")]
    public int? GenId { get; set; }

    [Column("Urban_ID")]
    public int? UrbanId { get; set; }

    [Column("GeoArea_ID")]
    public int? GeoAreaId { get; set; }

    [Column("GenSector_ID")]
    public int? GenSectorId { get; set; }

    [Column("CountrySector_ID")]
    public int? CountrySectorId { get; set; }

    [Column("LegalEntity_ID")]
    public int? LegalEntityId { get; set; }

    [Column("Activity_ID")]
    public int? ActivityId { get; set; }

    [Column("OtherData_ID")]
    public int? OtherDataId { get; set; }

    [Column("IndData_Visible")]
    public bool? IndDataVisible { get; set; }

    [Column("IndData_ChartType")]
    [StringLength(1)]
    public string IndDataChartType { get; set; }

    [Column("Internal_Show")]
    public bool? InternalShow { get; set; }

    [Column("IndData_Note_En")]
    [StringLength(250)]
    public string IndDataNoteEn { get; set; }
}