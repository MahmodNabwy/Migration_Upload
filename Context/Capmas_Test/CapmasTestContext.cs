﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Context.Capmas_Test;

public partial class CapmasTestContext : DbContext
{
    public CapmasTestContext()
    {
    }

    public CapmasTestContext(DbContextOptions<CapmasTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AgencyType> AgencyTypes { get; set; }

    public virtual DbSet<AgencyTypeTranslation> AgencyTypeTranslations { get; set; }

    public virtual DbSet<AppSetting> AppSettings { get; set; }

    public virtual DbSet<Calendar> Calendars { get; set; }

    public virtual DbSet<CalendarType> CalendarTypes { get; set; }

    public virtual DbSet<CalendarTypeTranslation> CalendarTypeTranslations { get; set; }

    public virtual DbSet<CapmasHead> CapmasHeads { get; set; }

    public virtual DbSet<CapmasHeadTranslation> CapmasHeadTranslations { get; set; }

    public virtual DbSet<CapmasHistory> CapmasHistories { get; set; }

    public virtual DbSet<CapmasHistoryTranslation> CapmasHistoryTranslations { get; set; }

    public virtual DbSet<CapmasSector> CapmasSectors { get; set; }

    public virtual DbSet<CapmasSectorTranslation> CapmasSectorTranslations { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryTranslation> CategoryTranslations { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CountryTranslation> CountryTranslations { get; set; }

    public virtual DbSet<DataRequest> DataRequests { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DepartmentTranslation> DepartmentTranslations { get; set; }

    public virtual DbSet<DepartmentUser> DepartmentUsers { get; set; }

    public virtual DbSet<EgyptPopulation> EgyptPopulations { get; set; }

    public virtual DbSet<EgyptStatisticsJournal> EgyptStatisticsJournals { get; set; }

    public virtual DbSet<EgyptStatisticsJournalTranslation> EgyptStatisticsJournalTranslations { get; set; }

    public virtual DbSet<Element> Elements { get; set; }

    public virtual DbSet<ElementTranslation> ElementTranslations { get; set; }

    public virtual DbSet<EmailList> EmailLists { get; set; }

    public virtual DbSet<EmailListCategory> EmailListCategories { get; set; }

    public virtual DbSet<EmailListCategoryTranslation> EmailListCategoryTranslations { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventTranslation> EventTranslations { get; set; }

    public virtual DbSet<EventType> EventTypes { get; set; }

    public virtual DbSet<EventTypeTranslation> EventTypeTranslations { get; set; }

    public virtual DbSet<EvidenceAndClassification> EvidenceAndClassifications { get; set; }

    public virtual DbSet<EvidenceAndClassificationTranslation> EvidenceAndClassificationTranslations { get; set; }

    public virtual DbSet<FilesLibrary> FilesLibraries { get; set; }

    public virtual DbSet<FilmType> FilmTypes { get; set; }

    public virtual DbSet<FilmTypeTranslation> FilmTypeTranslations { get; set; }

    public virtual DbSet<Filter> Filters { get; set; }

    public virtual DbSet<FilterTranslation> FilterTranslations { get; set; }

    public virtual DbSet<Forum> Forums { get; set; }

    public virtual DbSet<ForumMetadata> ForumMetadatas { get; set; }

    public virtual DbSet<ForumMetadataTranslation> ForumMetadataTranslations { get; set; }

    public virtual DbSet<ForumTranslation> ForumTranslations { get; set; }

    public virtual DbSet<Governorate> Governorates { get; set; }

    public virtual DbSet<GovernoratePopulation> GovernoratePopulations { get; set; }

    public virtual DbSet<GovernorateTranslation> GovernorateTranslations { get; set; }

    public virtual DbSet<HappeningNow> HappeningNows { get; set; }

    public virtual DbSet<HappeningNowTranslation> HappeningNowTranslations { get; set; }

    public virtual DbSet<ImportantPortal> ImportantPortals { get; set; }

    public virtual DbSet<ImportantPortalTranslation> ImportantPortalTranslations { get; set; }

    public virtual DbSet<Indicator> Indicators { get; set; }

    public virtual DbSet<IndicatorTranslation> IndicatorTranslations { get; set; }

    public virtual DbSet<Infographic> Infographics { get; set; }

    public virtual DbSet<InternationalDay> InternationalDays { get; set; }

    public virtual DbSet<InternationalDayTranslation> InternationalDayTranslations { get; set; }

    public virtual DbSet<JournalCategory> JournalCategories { get; set; }

    public virtual DbSet<JournalCategoryTranslation> JournalCategoryTranslations { get; set; }

    public virtual DbSet<Journalism> Journalisms { get; set; }

    public virtual DbSet<JournalismTranslation> JournalismTranslations { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LanguageTranslation> LanguageTranslations { get; set; }

    public virtual DbSet<LawRegulation> LawRegulations { get; set; }

    public virtual DbSet<LawRegulationTranslation> LawRegulationTranslations { get; set; }

    public virtual DbSet<MainValue> MainValues { get; set; }

    public virtual DbSet<MainValueTranslation> MainValueTranslations { get; set; }

    public virtual DbSet<MeasureUnit> MeasureUnits { get; set; }

    public virtual DbSet<MeasureUnitTranslation> MeasureUnitTranslations { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuTranslation> MenuTranslations { get; set; }

    public virtual DbSet<MicrofilmDatum> MicrofilmData { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NewsBar> NewsBars { get; set; }

    public virtual DbSet<NewsBarTranslation> NewsBarTranslations { get; set; }

    public virtual DbSet<NewsCategory> NewsCategories { get; set; }

    public virtual DbSet<NewsEmailListCategory> NewsEmailListCategories { get; set; }

    public virtual DbSet<NewsTag> NewsTags { get; set; }

    public virtual DbSet<NewsTranslation> NewsTranslations { get; set; }

    public virtual DbSet<Page> Pages { get; set; }

    public virtual DbSet<PageTranslation> PageTranslations { get; set; }

    public virtual DbSet<Periodic> Periodics { get; set; }

    public virtual DbSet<PeriodicTranslation> PeriodicTranslations { get; set; }

    public virtual DbSet<PermissionModule> PermissionModules { get; set; }

    public virtual DbSet<Photo> Photos { get; set; }

    public virtual DbSet<PhotoAlbum> PhotoAlbums { get; set; }

    public virtual DbSet<PhotoAlbumTranslation> PhotoAlbumTranslations { get; set; }

    public virtual DbSet<PhotoCategory> PhotoCategories { get; set; }

    public virtual DbSet<PhotoCategoryTranslation> PhotoCategoryTranslations { get; set; }

    public virtual DbSet<Publication> Publications { get; set; }

    public virtual DbSet<PublicationDetail> PublicationDetails { get; set; }

    public virtual DbSet<PublicationIndicator> PublicationIndicators { get; set; }

    public virtual DbSet<PublicationSubscription> PublicationSubscriptions { get; set; }

    public virtual DbSet<PublicationTag> PublicationTags { get; set; }

    public virtual DbSet<PublicationTranslation> PublicationTranslations { get; set; }

    public virtual DbSet<PublicationType> PublicationTypes { get; set; }

    public virtual DbSet<PublicationTypeTranslation> PublicationTypeTranslations { get; set; }

    public virtual DbSet<RegionalOffice> RegionalOffices { get; set; }

    public virtual DbSet<RegionalOfficeTranslation> RegionalOfficeTranslations { get; set; }

    public virtual DbSet<RelatedWebsite> RelatedWebsites { get; set; }

    public virtual DbSet<RelatedWebsiteTranslation> RelatedWebsiteTranslations { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<RoleTranslation> RoleTranslations { get; set; }

    public virtual DbSet<Sector> Sectors { get; set; }

    public virtual DbSet<SectorTranslation> SectorTranslations { get; set; }

    public virtual DbSet<SecurityQuestion> SecurityQuestions { get; set; }

    public virtual DbSet<ServiceAndToolTranslation> ServiceAndToolTranslations { get; set; }

    public virtual DbSet<ServiceType> ServiceTypes { get; set; }

    public virtual DbSet<ServiceTypeTranslation> ServiceTypeTranslations { get; set; }

    public virtual DbSet<ServicesAndTool> ServicesAndTools { get; set; }

    public virtual DbSet<SiteSelection> SiteSelections { get; set; }

    public virtual DbSet<SiteSelectionTranslation> SiteSelectionTranslations { get; set; }

    public virtual DbSet<Slider> Sliders { get; set; }

    public virtual DbSet<SliderTranslation> SliderTranslations { get; set; }

    public virtual DbSet<StudyPeriod> StudyPeriods { get; set; }

    public virtual DbSet<StudyPeriodsTranslation> StudyPeriodsTranslations { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<SubjectTranslation> SubjectTranslations { get; set; }

    public virtual DbSet<SubscriptionType> SubscriptionTypes { get; set; }

    public virtual DbSet<SubscriptionTypeTranslation> SubscriptionTypeTranslations { get; set; }

    public virtual DbSet<Survey> Surveys { get; set; }

    public virtual DbSet<SurveyCensuse> SurveyCensuses { get; set; }

    public virtual DbSet<SurveyCensuseTranslation> SurveyCensuseTranslations { get; set; }

    public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }

    public virtual DbSet<SurveyQuestionOption> SurveyQuestionOptions { get; set; }

    public virtual DbSet<SurveyQuestionOptionTranslation> SurveyQuestionOptionTranslations { get; set; }

    public virtual DbSet<SurveyQuestionOptionVote> SurveyQuestionOptionVotes { get; set; }

    public virtual DbSet<SurveyQuestionTranslation> SurveyQuestionTranslations { get; set; }

    public virtual DbSet<SurveyTranslation> SurveyTranslations { get; set; }

    public virtual DbSet<SurveyVote> SurveyVotes { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TagTranslation> TagTranslations { get; set; }

    public virtual DbSet<TrainingProgram> TrainingPrograms { get; set; }

    public virtual DbSet<TrainingProgramApplication> TrainingProgramApplications { get; set; }

    public virtual DbSet<TrainingProgramTranslation> TrainingProgramTranslations { get; set; }

    public virtual DbSet<UserSecurityQuestion> UserSecurityQuestions { get; set; }

    public virtual DbSet<VideoLibrary> VideoLibraries { get; set; }

    public virtual DbSet<VideoLibraryCategory> VideoLibraryCategories { get; set; }

    public virtual DbSet<VideoLibraryCategoryTranslation> VideoLibraryCategoryTranslations { get; set; }

    public virtual DbSet<VideoLibraryTranslation> VideoLibraryTranslations { get; set; }

    public virtual DbSet<WebsiteType> WebsiteTypes { get; set; }

    public virtual DbSet<WebsiteTypeTranslation> WebsiteTypeTranslations { get; set; }

    public virtual DbSet<YearType> YearTypes { get; set; }

    public virtual DbSet<YearTypeTranslation> YearTypeTranslations { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-B2PS99A;Initial Catalog=Capmas-Test;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AgencyType>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<AgencyTypeTranslation>(entity =>
        {
            entity.HasOne(d => d.AgencyType).WithMany(p => p.AgencyTypeTranslations).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AppSetting>(entity =>
        {
            entity.HasIndex(e => e.Key, "key_unique")
                .IsUnique()
                .HasFilter("([key] IS NOT NULL)");

            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<Calendar>(entity =>
        {
            entity.Property(e => e.Date).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            entity.HasOne(d => d.CalendarType).WithMany(p => p.Calendars).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<CalendarType>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Type).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<CalendarTypeTranslation>(entity =>
        {
            entity.Property(e => e.Type).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<CapmasHead>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<CapmasHistory>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryName).HasDefaultValueSql("(N'')");
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<CategoryTranslation>(entity =>
        {
            entity.Property(e => e.CategoryName).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.Property(e => e.Code).HasDefaultValueSql("(N'')");
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<CountryTranslation>(entity =>
        {
            entity.HasOne(d => d.Country).WithMany(p => p.CountryTranslations).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DepartmentUser>(entity =>
        {
            entity.HasIndex(e => new { e.UserId, e.DepartmentId }, "IX_department_users_user_id_department_id")
                .IsUnique()
                .HasFilter("([user_id] IS NOT NULL)");

            entity.Property(e => e.IsManager).HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentUsers).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<EgyptStatisticsJournal>(entity =>
        {
            entity.Property(e => e.IsPdf).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<EmailList>(entity =>
        {
            entity.HasOne(d => d.EmailListCategory).WithMany(p => p.EmailLists).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<EventTranslation>(entity =>
        {
            entity.Property(e => e.EventId).HasDefaultValueSql("(CONVERT([bigint],(0)))");
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<EventType>(entity =>
        {
            entity.Property(e => e.Name).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<EventTypeTranslation>(entity =>
        {
            entity.Property(e => e.Name).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<FilmType>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<FilmTypeTranslation>(entity =>
        {
            entity.HasOne(d => d.FilmType).WithMany(p => p.FilmTypeTranslations).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ForumMetadata>(entity =>
        {
            entity.HasOne(d => d.Forum).WithMany(p => p.ForumMetadata).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Governorate>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<GovernoratePopulation>(entity =>
        {
            entity.HasOne(d => d.Governorate).WithMany(p => p.GovernoratePopulations).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Indicator>(entity =>
        {
            entity.Property(e => e.YearTypeId).HasDefaultValueSql("(CONVERT([bigint],(0)))");

            entity.HasOne(d => d.YearType).WithMany(p => p.Indicators).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<IndicatorTranslation>(entity =>
        {
            entity.HasOne(d => d.Indicator).WithMany(p => p.IndicatorTranslations).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Infographic>(entity =>
        {
            entity.HasOne(d => d.PublicationDetail).WithMany(p => p.Infographics).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InternationalDay>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<InternationalDayTranslation>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.InternationalDay).WithMany(p => p.InternationalDayTranslations).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<JournalCategory>(entity =>
        {
            entity.Property(e => e.JournalName).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<JournalCategoryTranslation>(entity =>
        {
            entity.Property(e => e.JournalName).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Journalism>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.JournalCategory).WithMany(p => p.Journalisms).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<LawRegulation>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<LawRegulationTranslation>(entity =>
        {
            entity.HasOne(d => d.LawRegulation).WithMany(p => p.LawRegulationTranslations).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<MainValue>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<MainValueTranslation>(entity =>
        {
            entity.HasOne(d => d.MainValue).WithMany(p => p.MainValueTranslations).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<MeasureUnitTranslation>(entity =>
        {
            entity.HasOne(d => d.MeasureUnit).WithMany(p => p.MeasureUnitTranslations).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<MicrofilmDatum>(entity =>
        {
            entity.HasOne(d => d.AgencyType).WithMany(p => p.MicrofilmData).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FilmType).WithMany(p => p.MicrofilmData).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.Property(e => e.IsPdf).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsSend).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<NewsBar>(entity =>
        {
            entity.Property(e => e.IsInternal).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Link).HasDefaultValueSql("(N'')");
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<NewsBarTranslation>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<NewsCategory>(entity =>
        {
            entity.HasOne(d => d.Category).WithMany(p => p.NewsCategories).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.News).WithMany(p => p.NewsCategories).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<NewsEmailListCategory>(entity =>
        {
            entity.HasOne(d => d.EmailListCategory).WithMany(p => p.NewsEmailListCategories).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.News).WithMany(p => p.NewsEmailListCategories).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<NewsTag>(entity =>
        {
            entity.HasOne(d => d.News).WithMany(p => p.NewsTags).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Tag).WithMany(p => p.NewsTags).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Periodic>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<PermissionModule>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Photo>(entity =>
        {
            entity.HasOne(d => d.PhotoAlbum).WithMany(p => p.Photos).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PhotoAlbum>(entity =>
        {
            entity.HasOne(d => d.PhotoCategory).WithMany(p => p.PhotoAlbums).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Publication>(entity =>
        {
            entity.Property(e => e.SubsubjectId).HasDefaultValueSql("(CONVERT([bigint],(0)))");
            entity.Property(e => e.YearTypeId).HasDefaultValueSql("(CONVERT([bigint],(0)))");

            entity.HasOne(d => d.Periodic).WithMany(p => p.Publications).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PublicAdministration).WithMany(p => p.Publications).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PublicationType).WithMany(p => p.Publications).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Subsubject).WithMany(p => p.Publications).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.YearType).WithMany(p => p.Publications).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PublicationDetail>(entity =>
        {
            entity.Property(e => e.IsHome).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ReleaseDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            entity.HasOne(d => d.Publication).WithMany(p => p.PublicationDetails).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PublicationIndicator>(entity =>
        {
            entity.Property(e => e.FilterId).HasDefaultValueSql("(CONVERT([bigint],(0)))");

            entity.HasOne(d => d.Filter).WithMany(p => p.PublicationIndicators).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Indicator).WithMany(p => p.PublicationIndicators).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PublicationDetail).WithMany(p => p.PublicationIndicators).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PublicationSubscription>(entity =>
        {
            entity.HasOne(d => d.Publication).WithMany(p => p.PublicationSubscriptions).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PublicationTag>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Publication).WithMany(p => p.PublicationTags).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Tag).WithMany(p => p.PublicationTags).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PublicationType>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<RegionalOffice>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<RegionalOfficeTranslation>(entity =>
        {
            entity.Property(e => e.Name).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<RelatedWebsite>(entity =>
        {
            entity.Property(e => e.Link).HasDefaultValueSql("(N'')");
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<RelatedWebsiteTranslation>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.Property(e => e.RoleId).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.Module).WithMany(p => p.RolePermissions).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<RoleTranslation>(entity =>
        {
            entity.HasIndex(e => new { e.RoleId, e.Locale }, "IX_role_translations_role_id_locale")
                .IsUnique()
                .HasFilter("([role_id] IS NOT NULL)");

            entity.Property(e => e.Locale).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<ServiceAndToolTranslation>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<ServiceType>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<ServiceTypeTranslation>(entity =>
        {
            entity.HasOne(d => d.ServiceType).WithMany(p => p.ServiceTypeTranslations).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ServicesAndTool>(entity =>
        {
            entity.Property(e => e.IsHomepage).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsInternal).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsNew).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<SubscriptionType>(entity =>
        {
            entity.Property(e => e.IsPublished).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsSystem).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<Survey>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<SurveyQuestion>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<SurveyQuestionOption>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<SurveyQuestionOptionTranslation>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<SurveyQuestionOptionVote>(entity =>
        {
            entity.HasOne(d => d.SurveyQuestion).WithMany(p => p.SurveyQuestionOptionVotes).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.SurveyVote).WithMany(p => p.SurveyQuestionOptionVotes).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SurveyQuestionTranslation>(entity =>
        {
            entity.Property(e => e.Locale).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<SurveyTranslation>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.Property(e => e.TagName).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<TagTranslation>(entity =>
        {
            entity.Property(e => e.TagName).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<TrainingProgram>(entity =>
        {
            entity.Property(e => e.Name).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<TrainingProgramApplication>(entity =>
        {
            entity.Property(e => e.Name).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.TrainingProgram).WithMany(p => p.TrainingProgramApplications).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TrainingProgramTranslation>(entity =>
        {
            entity.Property(e => e.Name).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<VideoLibrary>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.VideoLibraryCategory).WithMany(p => p.VideoLibraries).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<WebsiteType>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<WebsiteTypeTranslation>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValueSql("(N'')");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}