﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("TRADE_FOR_HSNNew")]
public partial class TradeForHsnnew
{
    [Key]
    [Column("HSN_ID")]
    public int HsnId { get; set; }

    [Required]
    [Column("HSN_NAMEAR")]
    [StringLength(300)]
    public string HsnNamear { get; set; }

    [Column("HSN_NAMEEN")]
    [StringLength(700)]
    public string HsnNameen { get; set; }

    [Column("SUB_CHAPTERS_ID")]
    public int? SubChaptersId { get; set; }

    [Column("MANUFACTURE_IMPORT_ID")]
    public int? ManufactureImportId { get; set; }

    [Column("UNITS_ID")]
    public int? UnitsId { get; set; }

    [Column("HSN_CODE")]
    [StringLength(10)]
    public string HsnCode { get; set; }

    [Column("MANUFACTURE_EXPORT_ID")]
    public int? ManufactureExportId { get; set; }
}