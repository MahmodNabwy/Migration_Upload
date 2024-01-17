﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("TRADE_FOR_PORTS")]
public partial class TradeForPort
{
    [Key]
    [Column("PORTS_ID", TypeName = "numeric(38, 0)")]
    public decimal PortsId { get; set; }

    [Column("PORTS_NAMEAR")]
    [StringLength(300)]
    public string PortsNamear { get; set; }

    [Column("PORTS_NAMEEN")]
    [StringLength(300)]
    public string PortsNameen { get; set; }

    [Column("PORTS_CODE")]
    [StringLength(4)]
    public string PortsCode { get; set; }
}