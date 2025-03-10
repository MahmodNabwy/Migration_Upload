﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("infographics")]
[Index("PublicationDetailId", Name = "IX_infographics_publication_detail_id")]
public partial class Infographic
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("publication_detail_id")]
    public long PublicationDetailId { get; set; }

    [Required]
    [Column("infographic_url")]
    public string InfographicUrl { get; set; }

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

    [ForeignKey("PublicationDetailId")]
    [InverseProperty("Infographics")]
    public virtual PublicationDetail PublicationDetail { get; set; }
}