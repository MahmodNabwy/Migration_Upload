﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

[Table("news_email_list_categories")]
[Index("EmailListCategoryId", Name = "IX_news_email_list_categories_email_list_category_id")]
[Index("NewsId", "EmailListCategoryId", Name = "IX_news_email_list_categories_news_id_email_list_category_id", IsUnique = true)]
public partial class NewsEmailListCategory
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("email_list_category_id")]
    public long EmailListCategoryId { get; set; }

    [Column("news_id")]
    public long NewsId { get; set; }

    [Column("created_by")]
    public string CreatedBy { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_by")]
    public string UpdatedBy { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("EmailListCategoryId")]
    [InverseProperty("NewsEmailListCategories")]
    public virtual EmailListCategory EmailListCategory { get; set; }

    [ForeignKey("NewsId")]
    [InverseProperty("NewsEmailListCategories")]
    public virtual News News { get; set; }
}