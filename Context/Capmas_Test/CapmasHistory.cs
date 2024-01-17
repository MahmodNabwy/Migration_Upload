﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("capmas_histories")]
[Index("Year", "Title", Name = "IX_capmas_histories_year_title", IsUnique = true)]
public partial class CapmasHistory
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("title")]
    public string Title { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("image_url")]
    public string ImageUrl { get; set; }

    [Required]
    [Column("year")]
    [StringLength(4)]
    public string Year { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool IsDeleted { get; set; }

    [Required]
    [Column("is_system")]
    public bool? IsSystem { get; set; }

    [InverseProperty("CapmasHistory")]
    public virtual ICollection<CapmasHistoryTranslation> CapmasHistoryTranslations { get; set; } = new List<CapmasHistoryTranslation>();
}