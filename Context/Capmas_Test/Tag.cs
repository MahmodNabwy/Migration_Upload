﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("tags")]
public partial class Tag
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("tag_name")]
    public string TagName { get; set; }

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

    [InverseProperty("Tag")]
    public virtual ICollection<NewsTag> NewsTags { get; set; } = new List<NewsTag>();

    [InverseProperty("Tag")]
    public virtual ICollection<PublicationTag> PublicationTags { get; set; } = new List<PublicationTag>();

    [InverseProperty("Tag")]
    public virtual ICollection<TagTranslation> TagTranslations { get; set; } = new List<TagTranslation>();
}