﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("GIS_QISM_MARKAZ_N2006")]
public partial class GisQismMarkazN2006
{
    [Key]
    [Column("Sec_ID")]
    public int SecId { get; set; }

    [Column("Gov_ID")]
    public int? GovId { get; set; }

    [Column("OBJECTID")]
    public int Objectid { get; set; }

    [Column(TypeName = "image")]
    public byte[] Shape { get; set; }

    [Column("SEC_NAME_A")]
    [StringLength(100)]
    public string SecNameA { get; set; }

    [Column("SEC_NAME_E")]
    [StringLength(50)]
    public string SecNameE { get; set; }

    [Column("SEC_CODE")]
    [StringLength(50)]
    public string SecCode { get; set; }

    [Column("poverty_pe")]
    public float? PovertyPe { get; set; }

    [Column("illitracy")]
    public float? Illitracy { get; set; }

    [Column("unemployme")]
    public float? Unemployme { get; set; }

    [Column("water_conn")]
    public float? WaterConn { get; set; }

    [Column("electric_c")]
    public float? ElectricC { get; set; }

    [Column("Shape_Length")]
    public double? ShapeLength { get; set; }

    [Column("Shape_Area")]
    public double? ShapeArea { get; set; }

    [Column("per_capeta")]
    public float? PerCapeta { get; set; }

    [Column("sanitation_conn")]
    public float? SanitationConn { get; set; }

    [InverseProperty("Sec")]
    public virtual ICollection<GisShyakhaVillageN2006> GisShyakhaVillageN2006s { get; set; } = new List<GisShyakhaVillageN2006>();

    [ForeignKey("GovId")]
    [InverseProperty("GisQismMarkazN2006s")]
    public virtual GisGovernoratesN2006 Gov { get; set; }

    [InverseProperty("Centre")]
    public virtual ICollection<TblApplicationOld> TblApplicationOlds { get; set; } = new List<TblApplicationOld>();
}