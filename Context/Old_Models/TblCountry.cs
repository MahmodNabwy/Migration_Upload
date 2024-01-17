﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblCountries")]
public partial class TblCountry
{
    [Key]
    [Column("Country_ID")]
    public int CountryId { get; set; }

    [Column("Country_NameAr")]
    [StringLength(50)]
    public string CountryNameAr { get; set; }

    [Column("Country_NameEn")]
    [StringLength(50)]
    public string CountryNameEn { get; set; }

    [Column("Phone_Code")]
    [StringLength(10)]
    public string PhoneCode { get; set; }

    [InverseProperty("Country")]
    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}