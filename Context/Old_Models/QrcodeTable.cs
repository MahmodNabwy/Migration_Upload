﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("qrcode_table")]
public partial class QrcodeTable
{
    [Key]
    [Column("qr_id")]
    public int QrId { get; set; }

    [Column("qrcode_url")]
    [StringLength(150)]
    public string QrcodeUrl { get; set; }

    [Column("qrcode_image")]
    [StringLength(150)]
    public string QrcodeImage { get; set; }

    [Column("hc_id")]
    public int? HcId { get; set; }
}