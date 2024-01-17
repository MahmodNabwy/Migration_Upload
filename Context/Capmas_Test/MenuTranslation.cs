﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("menu_translations")]
[Index("MenuId", "Locale", Name = "IX_menu_translations_menu_id_locale", IsUnique = true)]
public partial class MenuTranslation
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; }

    [Required]
    [Column("locale")]
    [StringLength(6)]
    public string Locale { get; set; }

    [Required]
    [Column("items")]
    public string Items { get; set; }

    [Column("menu_id")]
    public long MenuId { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("MenuTranslations")]
    public virtual Menu Menu { get; set; }
}