﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("website_type_translations")]
[Index("WebsiteTypeId", "Locale", Name = "IX_website_type_translations_website_type_id_locale", IsUnique = true)]
public partial class WebsiteTypeTranslation
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("title")]
    public string Title { get; set; }

    [Required]
    [Column("locale")]
    [StringLength(6)]
    public string Locale { get; set; }

    [Column("website_type_id")]
    public long WebsiteTypeId { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("WebsiteTypeId")]
    [InverseProperty("WebsiteTypeTranslations")]
    public virtual WebsiteType WebsiteType { get; set; }
}