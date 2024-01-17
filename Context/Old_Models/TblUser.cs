﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Context.Old_Models;

[Table("tblUsers")]
[Index("UsrUserName", Name = "IX_tblUsers", IsUnique = true)]
[Index("UsrMail", Name = "IX_tblUsers_Usr_Mail")]
[Index("UsrStartDate", Name = "IX_tblUsers_Usr_StartDate")]
public partial class TblUser
{
    [Key]
    [Column("Usr_ID")]
    public int UsrId { get; set; }

    [Column("Usr_FirstName")]
    [StringLength(20)]
    public string UsrFirstName { get; set; }

    [Column("Usr_LastName")]
    [StringLength(20)]
    public string UsrLastName { get; set; }

    [Column("Usr_UserName")]
    [StringLength(20)]
    public string UsrUserName { get; set; }

    [Column("Usr_Password")]
    [StringLength(250)]
    public string UsrPassword { get; set; }

    [Column("Usr_Mail")]
    [StringLength(50)]
    public string UsrMail { get; set; }

    [Column("Usr_Mobile")]
    [StringLength(14)]
    public string UsrMobile { get; set; }

    [Column("Usr_CreationDate", TypeName = "date")]
    public DateTime? UsrCreationDate { get; set; }

    [Column("Usr_StartDate", TypeName = "date")]
    public DateTime? UsrStartDate { get; set; }

    [Column("Usr_EndDate", TypeName = "date")]
    public DateTime? UsrEndDate { get; set; }

    [Column("Usr_LastDate", TypeName = "datetime")]
    public DateTime? UsrLastDate { get; set; }

    [Column("UsrGrp_ID")]
    public int UsrGrpId { get; set; }

    [Column("Usr_ActivationKey")]
    [StringLength(100)]
    public string UsrActivationKey { get; set; }

    [Column("Country_ID")]
    public int? CountryId { get; set; }

    [Column("Emp_Create")]
    public int? EmpCreate { get; set; }

    [Column("Emp_Last_Update")]
    public int? EmpLastUpdate { get; set; }

    [Column("Emp_Update_Date", TypeName = "datetime")]
    public DateTime? EmpUpdateDate { get; set; }

    [Column("Usr_RegisterdGroup")]
    public int UsrRegisterdGroup { get; set; }

    [Column("Usr_Address")]
    [StringLength(250)]
    public string UsrAddress { get; set; }

    [Column("Usr_Photo")]
    [StringLength(150)]
    public string UsrPhoto { get; set; }

    [Column("Usr_DisscutionTopic")]
    public bool? UsrDisscutionTopic { get; set; }

    [Column("Usr_Title")]
    [StringLength(100)]
    public string UsrTitle { get; set; }

    [Column("Com_ID")]
    public int? ComId { get; set; }

    [Column("Usr_Activated")]
    public bool? UsrActivated { get; set; }

    [Column("Usr_Phone1")]
    [StringLength(50)]
    public string UsrPhone1 { get; set; }

    [Column("Usr_Phone2")]
    [StringLength(50)]
    public string UsrPhone2 { get; set; }

    [Column("Usr_Phone3")]
    [StringLength(50)]
    public string UsrPhone3 { get; set; }

    [Column("Usr_MonthlyBullitians")]
    public bool? UsrMonthlyBullitians { get; set; }

    [Column("UT_ID")]
    public int UtId { get; set; }

    [ForeignKey("ComId")]
    [InverseProperty("TblUsers")]
    public virtual TblCompany Com { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("TblUsers")]
    public virtual TblCountry Country { get; set; }

    [ForeignKey("EmpCreate")]
    [InverseProperty("TblUserEmpCreateNavigations")]
    public virtual TblEmployee EmpCreateNavigation { get; set; }

    [ForeignKey("EmpLastUpdate")]
    [InverseProperty("TblUserEmpLastUpdateNavigations")]
    public virtual TblEmployee EmpLastUpdateNavigation { get; set; }

    [InverseProperty("Usr")]
    public virtual ICollection<TblDisscutionTopic> TblDisscutionTopics { get; set; } = new List<TblDisscutionTopic>();

    [InverseProperty("Usr")]
    public virtual ICollection<TblQuestion> TblQuestions { get; set; } = new List<TblQuestion>();

    [InverseProperty("Usr")]
    public virtual ICollection<TblRequestRegisteration> TblRequestRegisterations { get; set; } = new List<TblRequestRegisteration>();

    [InverseProperty("Usr")]
    public virtual ICollection<TblUseMessage> TblUseMessages { get; set; } = new List<TblUseMessage>();

    [InverseProperty("Usr")]
    public virtual ICollection<TblUserFav> TblUserFavs { get; set; } = new List<TblUserFav>();

    [InverseProperty("Usr")]
    public virtual ICollection<TblUsersAnswer> TblUsersAnswers { get; set; } = new List<TblUsersAnswer>();

    [InverseProperty("User")]
    public virtual ICollection<TblVisitHistory> TblVisitHistories { get; set; } = new List<TblVisitHistory>();

    [ForeignKey("UsrGrpId")]
    [InverseProperty("TblUserUsrGrps")]
    public virtual TblUserGroup UsrGrp { get; set; }

    [ForeignKey("UsrRegisterdGroup")]
    [InverseProperty("TblUserUsrRegisterdGroupNavigations")]
    public virtual TblUserGroup UsrRegisterdGroupNavigation { get; set; }

    [ForeignKey("UtId")]
    [InverseProperty("TblUsers")]
    public virtual TblUserType Ut { get; set; }
}