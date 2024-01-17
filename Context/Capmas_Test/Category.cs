﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("categories")]
[Index("CategoryName", Name = "IX_categories_category_name", IsUnique = true)]
public partial class Category
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("category_name")]
    public string CategoryName { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [Column("status")]
    public int? Status { get; set; }

    [Column("is_published")]
    public bool IsPublished { get; set; }

    [Column("is_deleted")]
    public bool IsDeleted { get; set; }

    [Column("publish_date")]
    public DateTime? PublishDate { get; set; }

    [Required]
    [Column("is_system")]
    public bool? IsSystem { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<CategoryTranslation> CategoryTranslations { get; set; } = new List<CategoryTranslation>();

    [InverseProperty("Category")]
    public virtual ICollection<NewsCategory> NewsCategories { get; set; } = new List<NewsCategory>();
}