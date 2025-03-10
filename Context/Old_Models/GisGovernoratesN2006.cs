﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("GIS_GOVERNORATES_N2006")]
public partial class GisGovernoratesN2006
{
    [Key]
    [Column("Gov_ID")]
    public int GovId { get; set; }

    [Column("OBJECTID")]
    public int Objectid { get; set; }

    [Column(TypeName = "image")]
    public byte[] Shape { get; set; }

    [Column("GOV_NAME_E")]
    [StringLength(50)]
    public string GovNameE { get; set; }

    [Column("GOV_CODE")]
    [StringLength(50)]
    public string GovCode { get; set; }

    [Column("GOV_NAME_A")]
    [StringLength(50)]
    public string GovNameA { get; set; }

    [Column("SHAPE_Leng")]
    public double? ShapeLeng { get; set; }

    [Column("Shape_Length")]
    public double? ShapeLength { get; set; }

    [Column("Shape_Area")]
    public double? ShapeArea { get; set; }

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

    [Column("per_capeta")]
    public float? PerCapeta { get; set; }

    [Column("sanitation_conn")]
    public float? SanitationConn { get; set; }

    [InverseProperty("Gov")]
    public virtual ICollection<GisQismMarkazN2006> GisQismMarkazN2006s { get; set; } = new List<GisQismMarkazN2006>();

    [InverseProperty("Gov")]
    public virtual ICollection<TblApplicationOld> TblApplicationOlds { get; set; } = new List<TblApplicationOld>();
}