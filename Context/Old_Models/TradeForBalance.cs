﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Keyless]
[Table("TRADE_FOR_BALANCE")]
public partial class TradeForBalance
{
    [Column("DAT", TypeName = "numeric(38, 0)")]
    public decimal? Dat { get; set; }

    [Column("TRADE_FOR_COUNTRY_ID", TypeName = "numeric(38, 0)")]
    public decimal? TradeForCountryId { get; set; }

    [Column("EXPV")]
    [StringLength(40)]
    public string Expv { get; set; }

    [Column("EXPQ")]
    [StringLength(40)]
    public string Expq { get; set; }

    [Column("IMPV")]
    [StringLength(40)]
    public string Impv { get; set; }

    [Column("IMPQ")]
    [StringLength(40)]
    public string Impq { get; set; }

    [Column("TRADE_FOR_BLANCE_ID", TypeName = "numeric(38, 0)")]
    public decimal? TradeForBlanceId { get; set; }

    [ForeignKey("Dat")]
    public virtual TradeForFdoller DatNavigation { get; set; }

    [ForeignKey("TradeForCountryId")]
    public virtual TradeForCountry TradeForCountry { get; set; }
}