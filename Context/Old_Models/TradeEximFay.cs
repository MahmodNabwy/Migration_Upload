﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Keyless]
[Table("TRADE_EXIM_FAY")]
public partial class TradeEximFay
{
    [Column("U_ID")]
    [StringLength(24)]
    [Unicode(false)]
    public string UId { get; set; }

    [Column("TYPE_TR")]
    [StringLength(1)]
    [Unicode(false)]
    public string TypeTr { get; set; }

    [Column("ITEM")]
    [StringLength(10)]
    [Unicode(false)]
    public string Item { get; set; }

    [Column("COUNTRY")]
    [StringLength(4)]
    [Unicode(false)]
    public string Country { get; set; }

    [Column("N_EXP_IP")]
    [StringLength(9)]
    [Unicode(false)]
    public string NExpIp { get; set; }
}