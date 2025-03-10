﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("migrations")]
public partial class Migration
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("file_name")]
    public string FileName { get; set; }

    [Column("no_sheets")]
    public int NoSheets { get; set; }

    [Column("file_url")]
    public string FileUrl { get; set; }

    [Column("migration_status")]
    public string MigrationStatus { get; set; }

    [Column("error_sheet")]
    public string ErrorSheet { get; set; }

    [Column("error_row")]
    public int ErrorRow { get; set; }

    [Column("error_column")]
    public int ErrorColumn { get; set; }

    [Column("error")]
    public string Error { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}