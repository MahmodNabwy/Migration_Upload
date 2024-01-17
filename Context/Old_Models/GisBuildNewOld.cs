﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Keyless]
[Table("GIS_Build_New_old")]
public partial class GisBuildNewOld
{
    [Column("OBJECTID")]
    public int Objectid { get; set; }

    [Column(TypeName = "image")]
    public byte[] Shape { get; set; }

    [Column("GOV_NAME")]
    [StringLength(254)]
    public string GovName { get; set; }

    [Column("GOV_CODE")]
    [StringLength(2)]
    public string GovCode { get; set; }

    [Column("SEC_NAME")]
    [StringLength(254)]
    public string SecName { get; set; }

    [Column("SEC_CODE")]
    [StringLength(2)]
    public string SecCode { get; set; }

    [Column("SSEC_NAME")]
    [StringLength(254)]
    public string SsecName { get; set; }

    [Column("SSEC_CODE")]
    [StringLength(2)]
    public string SsecCode { get; set; }

    [Column("UNITCODE")]
    [StringLength(6)]
    public string Unitcode { get; set; }

    [Column("LAY")]
    public int? Lay { get; set; }

    [Column("ADDR1_2016")]
    public int? Addr12016 { get; set; }

    [Column("ADDR2_2016")]
    [StringLength(5)]
    public string Addr22016 { get; set; }

    [Column("ADDR3_2016")]
    [StringLength(150)]
    public string Addr32016 { get; set; }

    [Column("Name_2016")]
    [StringLength(200)]
    public string Name2016 { get; set; }

    [Column("UNIQE_CODE")]
    [StringLength(15)]
    public string UniqeCode { get; set; }

    [Column("SHAPE_Leng")]
    public double? ShapeLeng { get; set; }

    [Column("lay_name")]
    [StringLength(250)]
    public string LayName { get; set; }

    [Column("lay_name_e")]
    [StringLength(250)]
    public string LayNameE { get; set; }
}