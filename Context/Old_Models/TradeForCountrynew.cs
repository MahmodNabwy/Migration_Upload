﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("TRADE_FOR_COUNTRYNew")]
public partial class TradeForCountrynew
{
    [Key]
    [Column("COUNTRY_ID")]
    public int CountryId { get; set; }

    [Column("COUNTRY_NAMEAR")]
    [StringLength(150)]
    public string CountryNamear { get; set; }

    [Column("COUNTRY_NAMEEN")]
    [StringLength(150)]
    public string CountryNameen { get; set; }

    [Column("COUNTRY_CODE")]
    [StringLength(4)]
    public string CountryCode { get; set; }

    [Column("COUNTRY_SERIAL")]
    public int? CountrySerial { get; set; }

    [Column("COUNTRY_SERIAL_GRP")]
    public int? CountrySerialGrp { get; set; }

    [Column("COUNTRY_ARAB_GRP")]
    [StringLength(2)]
    public string CountryArabGrp { get; set; }
}