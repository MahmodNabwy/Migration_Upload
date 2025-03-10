﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("country_translations")]
[Index("CountryId", Name = "IX_country_translations_country_id")]
public partial class CountryTranslation
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("locale")]
    [StringLength(6)]
    public string Locale { get; set; }

    [Required]
    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("country_id")]
    public long CountryId { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("CountryTranslations")]
    public virtual Country Country { get; set; }
}