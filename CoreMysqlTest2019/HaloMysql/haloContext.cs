using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AdminPortal.HaloMysql
{

    public partial class haloContext : DbContext
    {

        public haloContext()
        {
        }

        public haloContext(DbContextOptions<haloContext> options)
            : base(options)
        {
        }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = "server=gcapp-mysql.mysql.database.azure.com;port=3306;user=gcsysops@gcapp-mysql;password=9zgGEQs7b&Gm;database=halo";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(connection);
            }
        }

        public virtual DbSet<Applicationdistributions> Applicationdistributions { get; set; }
        public virtual DbSet<Authtokens> Authtokens { get; set; }
        public virtual DbSet<Callcentreaudittrail> Callcentreaudittrail { get; set; }
        public virtual DbSet<Callcentrechatmessages> Callcentrechatmessages { get; set; }
        public virtual DbSet<Callcentrefaqs> Callcentrefaqs { get; set; }
        public virtual DbSet<Callcentrefirestations> Callcentrefirestations { get; set; }
        public virtual DbSet<Callcentremodules> Callcentremodules { get; set; }
        public virtual DbSet<Callcentrerolemodules> Callcentrerolemodules { get; set; }
        public virtual DbSet<Callcentreuserroles> Callcentreuserroles { get; set; }
        public virtual DbSet<Callcentreusers> Callcentreusers { get; set; }
        public virtual DbSet<Cartrack> Cartrack { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<CitiesList> CitiesList { get; set; }
        public virtual DbSet<ClientTokens> ClientTokens { get; set; }
        public virtual DbSet<Cmsmodules> Cmsmodules { get; set; }
        public virtual DbSet<Cmsrolemodules> Cmsrolemodules { get; set; }
        public virtual DbSet<Cmsuserroles> Cmsuserroles { get; set; }
        public virtual DbSet<Cmsusers> Cmsusers { get; set; }
        public virtual DbSet<Communicationlog> Communicationlog { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryList> CountryList { get; set; }
        public virtual DbSet<EdmundsTest> EdmundsTest { get; set; }
        public virtual DbSet<HaloMobileContentClients> HaloMobileContentClients { get; set; }
        public virtual DbSet<Haloaudittrail> Haloaudittrail { get; set; }
        public virtual DbSet<Halobatchimported> Halobatchimported { get; set; }
        public virtual DbSet<Halobranches> Halobranches { get; set; }
        public virtual DbSet<Halochatmessages> Halochatmessages { get; set; }
        public virtual DbSet<Halochatrequests> Halochatrequests { get; set; }
        public virtual DbSet<Haloclaims> Haloclaims { get; set; }
        public virtual DbSet<Haloclaimtypes> Haloclaimtypes { get; set; }
        public virtual DbSet<Haloclientapiregister> Haloclientapiregister { get; set; }
        public virtual DbSet<Haloclientbanners> Haloclientbanners { get; set; }
        public virtual DbSet<Haloclientmembers> Haloclientmembers { get; set; }
        public virtual DbSet<Haloclientpartners> Haloclientpartners { get; set; }
        public virtual DbSet<Haloclientprogramproducts> Haloclientprogramproducts { get; set; }
        public virtual DbSet<Haloclientprograms> Haloclientprograms { get; set; }
        public virtual DbSet<Haloclients> Haloclients { get; set; }
        public virtual DbSet<Haloclientslogin> Haloclientslogin { get; set; }
        public virtual DbSet<HalodictionaryEnZa> HalodictionaryEnZa { get; set; }
        public virtual DbSet<Halodriverslicences> Halodriverslicences { get; set; }
        public virtual DbSet<Haloftpaudittrail> Haloftpaudittrail { get; set; }
        public virtual DbSet<Haloinappapplications> Haloinappapplications { get; set; }
        public virtual DbSet<Haloinappmessages> Haloinappmessages { get; set; }
        public virtual DbSet<Haloinappregistration> Haloinappregistration { get; set; }
        public virtual DbSet<HalomemberAdditionalClientData> HalomemberAdditionalClientData { get; set; }
        public virtual DbSet<Halomemberclaims> Halomemberclaims { get; set; }
        public virtual DbSet<Halomemberclaimseyewitness> Halomemberclaimseyewitness { get; set; }
        public virtual DbSet<Halomemberclaimsthirdparty> Halomemberclaimsthirdparty { get; set; }
        public virtual DbSet<Halomemberdependants> Halomemberdependants { get; set; }
        public virtual DbSet<Halomemberftpfiles> Halomemberftpfiles { get; set; }
        public virtual DbSet<Halomemberloaderror> Halomemberloaderror { get; set; }
        public virtual DbSet<Halomembermessages> Halomembermessages { get; set; }
        public virtual DbSet<Halomemberphonenumbers> Halomemberphonenumbers { get; set; }
        public virtual DbSet<Halomemberprograms> Halomemberprograms { get; set; }
        public virtual DbSet<Halomembers> Halomembers { get; set; }
        public virtual DbSet<Halomembersstage> Halomembersstage { get; set; }
        public virtual DbSet<Halomobileclientcontent> Halomobileclientcontent { get; set; }
        public virtual DbSet<Halomobilecontent> Halomobilecontent { get; set; }
        public virtual DbSet<Halonetstar> Halonetstar { get; set; }
        public virtual DbSet<Halopanics> Halopanics { get; set; }
        public virtual DbSet<Halopartners> Halopartners { get; set; }
        public virtual DbSet<Haloproducts> Haloproducts { get; set; }
        public virtual DbSet<Haloreminders> Haloreminders { get; set; }
        public virtual DbSet<Halosentsmss> Halosentsmss { get; set; }
        public virtual DbSet<Halositeconfig> Halositeconfig { get; set; }
        public virtual DbSet<Halovehiclelicences> Halovehiclelicences { get; set; }
        public virtual DbSet<Halovehiclemonitorintegration> Halovehiclemonitorintegration { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Policychangerequests> Policychangerequests { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<ProvincesList> ProvincesList { get; set; }
        public virtual DbSet<ReferenceSubset> ReferenceSubset { get; set; }
        public virtual DbSet<ReferralResponse> ReferralResponse { get; set; }
        public virtual DbSet<Referrals> Referrals { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionList> RegionList { get; set; }
        public virtual DbSet<ServiceCatagoriesList> ServiceCatagoriesList { get; set; }
        public virtual DbSet<ServiceCategories> ServiceCategories { get; set; }
        public virtual DbSet<ServiceList> ServiceList { get; set; }
        public virtual DbSet<ServiceProvidersAudit> ServiceProvidersAudit { get; set; }
        public virtual DbSet<ServiceSubCatagories> ServiceSubCatagories { get; set; }
        public virtual DbSet<ServiceSubCategoriesList> ServiceSubCategoriesList { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Suburbs> Suburbs { get; set; }
        public virtual DbSet<SuburbsList> SuburbsList { get; set; }
        public virtual DbSet<Token> Token { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Ussdtest> Ussdtest { get; set; }

        // Unable to generate entity type for table 'halo.archer_delivery_report'. Please see the warning messages.
        // Unable to generate entity type for table 'halo.halofrontlinephone'. Please see the warning messages.
        // Unable to generate entity type for table 'halo.policytestids'. Please see the warning messages.
        // Unable to generate entity type for table 'halo.product_icons'. Please see the warning messages.
        // Unable to generate entity type for table 'halo.refresh_token'. Please see the warning messages.
        // Unable to generate entity type for table 'halo.user_client'. Please see the warning messages.

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Applicationdistributions>(entity =>
            {
                entity.HasKey(e => e.DistroId);

                entity.ToTable("applicationdistributions", "halo");

                entity.Property(e => e.DistroId)
                    .HasColumnName("DistroID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DistroJson).IsUnicode(false);

                entity.Property(e => e.DistroNamespace)
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.DistroTitle)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Authtokens>(entity =>
            {
                entity.HasKey(e => e.AtId);

                entity.ToTable("authtokens", "halo");

                entity.Property(e => e.AtId)
                    .HasColumnName("at_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtClientId)
                    .HasColumnName("at_client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtJwt)
                    .HasColumnName("at_jwt")
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.AtPassword)
                    .HasColumnName("at_password")
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.AtUserName)
                    .HasColumnName("at_user_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Callcentreaudittrail>(entity =>
            {
                entity.ToTable("callcentreaudittrail", "halo");

                entity.Property(e => e.CallCentreAuditTrailId)
                    .HasColumnName("CallCentreAuditTrailID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreAuditTrailDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CallCentreAuditTrailTransaction)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreAuditTrailUserId)
                    .HasColumnName("CallCentreAuditTrailUserID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Callcentrechatmessages>(entity =>
            {
                entity.HasKey(e => e.CallCentreChatMessageId);

                entity.ToTable("callcentrechatmessages", "halo");

                entity.Property(e => e.CallCentreChatMessageId)
                    .HasColumnName("CallCentreChatMessageID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreChatMessage).HasColumnType("mediumtext");

                entity.Property(e => e.CallCentreChatMessageRead)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CallCentreChatMessageSentAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CallCentreChatMessageSentFrom).HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreChatMessageSentTo).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Callcentrefaqs>(entity =>
            {
                entity.HasKey(e => e.CallCentreFaqid);

                entity.ToTable("callcentrefaqs", "halo");

                entity.Property(e => e.CallCentreFaqid)
                    .HasColumnName("CallCentreFAQID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreFaqanswer)
                    .HasColumnName("CallCentreFAQAnswer")
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreFaqquestion)
                    .HasColumnName("CallCentreFAQQuestion")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Callcentrefirestations>(entity =>
            {
                entity.HasKey(e => e.CallCentreFireStationId);

                entity.ToTable("callcentrefirestations", "halo");

                entity.Property(e => e.CallCentreFireStationId)
                    .HasColumnName("CallCentreFireStationID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreFireStationAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreFireStationLat)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreFireStationLng)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreFireStationName)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreFireStationPhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Callcentremodules>(entity =>
            {
                entity.HasKey(e => e.CallCentreModuleId);

                entity.ToTable("callcentremodules", "halo");

                entity.Property(e => e.CallCentreModuleId)
                    .HasColumnName("CallCentreModuleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CallCentreModuleHtml)
                    .HasColumnName("CallCentreModuleHTML")
                    .HasColumnType("longtext");

                entity.Property(e => e.CallCentreModuleName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreModuleOrder).HasColumnType("int(11)");

                entity.Property(e => e.CallCentreModuleScript).HasColumnType("longtext");

                entity.Property(e => e.CallCentreModuleSubNames)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Callcentrerolemodules>(entity =>
            {
                entity.HasKey(e => e.CallCentreRoleModuleId);

                entity.ToTable("callcentrerolemodules", "halo");

                entity.Property(e => e.CallCentreRoleModuleId)
                    .HasColumnName("CallCentreRoleModuleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CallCentreModuleId)
                    .HasColumnName("CallCentreModuleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CallCentreRoleId)
                    .HasColumnName("CallCentreRoleID")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Callcentreuserroles>(entity =>
            {
                entity.HasKey(e => e.CallCentreUserRoleId);

                entity.ToTable("callcentreuserroles", "halo");

                entity.Property(e => e.CallCentreUserRoleId)
                    .HasColumnName("CallCentreUserRoleID")
                    .HasColumnType("smallint(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CallCentreUserRoleName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Callcentreusers>(entity =>
            {
                entity.HasKey(e => e.CallCentreUserId);

                entity.ToTable("callcentreusers", "halo");

                entity.HasIndex(e => e.CallCentreUserName)
                    .HasName("CallCentreUserName_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CallCentreUserId)
                    .HasColumnName("CallCentreUserID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreUserFirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreUserHash)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreUserIsHashed)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CallCentreUserName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreUserPassword)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CallCentreUserRole).HasColumnType("smallint(6)");

                entity.Property(e => e.CallCentreUserStatus)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CallCentreUserSurname)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cartrack>(entity =>
            {
                entity.ToTable("cartrack", "halo");

                entity.Property(e => e.CarTrackId)
                    .HasColumnName("CarTrackID")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.CarTrackCellphoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarTrackClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarTrackClientNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarTrackEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarTrackEngineNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarTrackHaloMemberId).HasColumnType("bigint(10)");

                entity.Property(e => e.CarTrackIdNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarTrackModel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarTrackPolicyNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarTrackRegistrationNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarTrackVehicleMake)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CarTrackVinNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("cities", "halo");

                entity.HasIndex(e => e.CityId)
                    .HasName("city_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CityDescription)
                    .HasColumnName("city_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("region_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CitiesList>(entity =>
            {
                entity.ToTable("cities_list", "halo");

                entity.HasIndex(e => e.CitiesListId)
                    .HasName("cities_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CitiesListId)
                    .HasColumnName("cities_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CitiesListDescription)
                    .HasColumnName("cities_list_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CitiesListName)
                    .HasColumnName("cities_list_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientTokens>(entity =>
            {
                entity.ToTable("client_tokens", "halo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("client_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.TokensAvailable)
                    .HasColumnName("tokens_available")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TokensBrought)
                    .HasColumnName("tokens_brought")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasDefaultValueSql("00000000000");

                entity.Property(e => e.TokensUsed)
                    .HasColumnName("tokens_used")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasDefaultValueSql("00000000000");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cmsmodules>(entity =>
            {
                entity.HasKey(e => e.CmsmoduleId);

                entity.ToTable("cmsmodules", "halo");

                entity.Property(e => e.CmsmoduleId)
                    .HasColumnName("CMSModuleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CmsmoduleHtml)
                    .HasColumnName("CMSModuleHTML")
                    .HasColumnType("longtext");

                entity.Property(e => e.CmsmoduleName)
                    .HasColumnName("CMSModuleName")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmsmoduleOrder)
                    .HasColumnName("CMSModuleOrder")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CmsmoduleScript)
                    .HasColumnName("CMSModuleScript")
                    .HasColumnType("longtext");

                entity.Property(e => e.CmsmoduleSubNames)
                    .HasColumnName("CMSModuleSubNames")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cmsrolemodules>(entity =>
            {
                entity.HasKey(e => e.CmsroleModuleId);

                entity.ToTable("cmsrolemodules", "halo");

                entity.Property(e => e.CmsroleModuleId)
                    .HasColumnName("CMSRoleModuleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CmsmoduleId)
                    .HasColumnName("CMSModuleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CmsroleId)
                    .HasColumnName("CMSRoleID")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Cmsuserroles>(entity =>
            {
                entity.HasKey(e => e.CmsuserRoleId);

                entity.ToTable("cmsuserroles", "halo");

                entity.Property(e => e.CmsuserRoleId)
                    .HasColumnName("CMSUserRoleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CmsuserRoleName)
                    .HasColumnName("CMSUserRoleName")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cmsusers>(entity =>
            {
                entity.HasKey(e => e.CmsuserId);

                entity.ToTable("cmsusers", "halo");

                entity.HasIndex(e => e.CmsuserName)
                    .HasName("CMSUserName_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.CmsuserRole)
                    .HasName("fk_CMSUsers_1_idx");

                entity.Property(e => e.CmsuserId)
                    .HasColumnName("CMSUserID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CmsuserName)
                    .HasColumnName("CMSUserName")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmsuserPassword)
                    .HasColumnName("CMSUserPassword")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CmsuserRole)
                    .HasColumnName("CMSUserRole")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CmsuserStatus)
                    .HasColumnName("CMSUserStatus")
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CmsuserSurname)
                    .HasColumnName("CMSUserSurname")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Communicationlog>(entity =>
            {
                entity.ToTable("communicationlog", "halo");

                entity.HasIndex(e => e.Id)
                    .HasName("CommunicationLog_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasMaxLength(8192)
                    .IsUnicode(false);

                entity.Property(e => e.SentAt)
                    .HasColumnName("sent_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("contacts", "halo");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContactStatus).HasColumnType("int(2)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country", "halo");

                entity.HasIndex(e => e.CountryId)
                    .HasName("country_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryDescription)
                    .HasColumnName("country_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceSubCatagorieId)
                    .HasColumnName("service_sub_catagorie_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CountryList>(entity =>
            {
                entity.ToTable("country_list", "halo");

                entity.HasIndex(e => e.CountryListId)
                    .HasName("country_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CountryListId)
                    .HasColumnName("country_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryListDescription)
                    .HasColumnName("country_list_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CountryListName)
                    .HasColumnName("country_list_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EdmundsTest>(entity =>
            {
                entity.ToTable("edmunds_test", "halo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EdmundsAddress1)
                    .HasColumnName("edmunds_address1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdmundsAddress2)
                    .HasColumnName("edmunds_address2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdmundsCity)
                    .HasColumnName("edmunds_city")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdmundsName)
                    .HasColumnName("edmunds_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdmundsPayDate).HasColumnName("edmunds_pay_date");

                entity.Property(e => e.EdmundsProvince)
                    .HasColumnName("edmunds_province")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdmundsSalary)
                    .HasColumnName("edmunds_salary")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdmundsSurname)
                    .HasColumnName("edmunds_surname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdmundsYearsWorked)
                    .HasColumnName("edmunds_years_worked")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HaloMobileContentClients>(entity =>
            {
                entity.ToTable("halo_mobile_content_clients", "halo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloMobileClientId)
                    .HasColumnName("halo_mobile_client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloMobileContentId)
                    .HasColumnName("halo_mobile_content_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Haloaudittrail>(entity =>
            {
                entity.ToTable("haloaudittrail", "halo");

                entity.Property(e => e.HaloAuditTrailId)
                    .HasColumnName("HaloAuditTrailID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloAuditDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloAuditTrailStatus)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloAuditTrailTransaction)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloAuditTrailUserId)
                    .HasColumnName("HaloAuditTrailUserID")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halobatchimported>(entity =>
            {
                entity.ToTable("halobatchimported", "halo");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Failed)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halobranches>(entity =>
            {
                entity.HasKey(e => e.HaloBranchId);

                entity.ToTable("halobranches", "halo");

                entity.HasIndex(e => e.HaloClientId)
                    .HasName("fk_HaloBranches_1_idx");

                entity.Property(e => e.HaloBranchId)
                    .HasColumnName("HaloBranchID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloBranchEmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloBranchName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloBranchPhoneNumbers).IsUnicode(false);

                entity.Property(e => e.HaloBranchPhysicalAddress).IsUnicode(false);

                entity.Property(e => e.HaloBranchPostalAddress).IsUnicode(false);

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.HaloClient)
                    .WithMany(p => p.Halobranches)
                    .HasForeignKey(d => d.HaloClientId)
                    .HasConstraintName("fk_HaloBranches_1");
            });

            modelBuilder.Entity<Halochatmessages>(entity =>
            {
                entity.HasKey(e => e.HaloChatMessageId);

                entity.ToTable("halochatmessages", "halo");

                entity.HasIndex(e => e.HaloChatRequestId)
                    .HasName("fk_HaloChatMessages_1_idx");

                entity.Property(e => e.HaloChatMessageId)
                    .HasColumnName("HaloChatMessageID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatMessage).HasColumnType("mediumtext");

                entity.Property(e => e.HaloChatMessageSentAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloChatMessageSentFrom).HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatMessageSentTo).HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatMessageType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HaloChatRequestId)
                    .HasColumnName("HaloChatRequestID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halochatrequests>(entity =>
            {
                entity.HasKey(e => e.HaloChatRequestId);

                entity.ToTable("halochatrequests", "halo");

                entity.Property(e => e.HaloChatRequestId)
                    .HasColumnName("HaloChatRequestID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatRequestActive)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HaloChatRequestHandledAt)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloChatRequestHandledBy).HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatRequestHasUnread)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HaloChatRequestLastTransaction).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloChatRequestLatitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloChatRequestLongitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloChatRequestMemberId)
                    .HasColumnName("HaloChatRequestMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatRequestMemberPhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloChatRequestTimeStamp).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Haloclaims>(entity =>
            {
                entity.HasKey(e => e.ClaimId);

                entity.ToTable("haloclaims", "halo");

                entity.Property(e => e.ClaimId)
                    .HasColumnName("ClaimID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClaimClientId)
                    .HasColumnName("ClaimClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimJson).HasColumnType("mediumtext");

                entity.Property(e => e.ClaimReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimStatus).HasColumnType("int(11)");

                entity.Property(e => e.ClaimType).HasColumnType("int(11)");

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Haloclaimtypes>(entity =>
            {
                entity.ToTable("haloclaimtypes", "halo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CimsType)
                    .HasColumnName("cimsType")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasColumnName("claimType")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("groupName")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Haloclientapiregister>(entity =>
            {
                entity.HasKey(e => e.Apiclientid);

                entity.ToTable("haloclientapiregister", "halo");

                entity.Property(e => e.Apiclientid)
                    .HasColumnName("apiclientid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Clientemail)
                    .IsRequired()
                    .HasColumnName("clientemail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasColumnName("clientname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Createdat).HasColumnName("createdat");

                entity.Property(e => e.Passwordhash)
                    .IsRequired()
                    .HasColumnName("passwordhash")
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Haloclientbanners>(entity =>
            {
                entity.HasKey(e => e.HaloClientBannerId);

                entity.ToTable("haloclientbanners", "halo");

                entity.HasIndex(e => e.HaloClientId)
                    .HasName("fk_HaloClientBanners_1_idx");

                entity.Property(e => e.HaloClientBannerId)
                    .HasColumnName("HaloClientBannerID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientBannerPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.HaloClient)
                    .WithMany(p => p.Haloclientbanners)
                    .HasForeignKey(d => d.HaloClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloClientBanners_1");
            });

            modelBuilder.Entity<Haloclientmembers>(entity =>
            {
                entity.HasKey(e => e.HaloClientMemberId);

                entity.ToTable("haloclientmembers", "halo");

                entity.HasIndex(e => e.HaloClientId)
                    .HasName("fk_HaloClientMembers_1_idx");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloClientMembers_2_idx");

                entity.Property(e => e.HaloClientMemberId)
                    .HasColumnName("HaloClientMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Haloclientpartners>(entity =>
            {
                entity.HasKey(e => e.HaloClientPartnerId);

                entity.ToTable("haloclientpartners", "halo");

                entity.HasIndex(e => e.HaloClientId)
                    .HasName("fk_HaloClientPartners_1_idx");

                entity.Property(e => e.HaloClientPartnerId)
                    .HasColumnName("HaloClientPartnerID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloPartnerId)
                    .HasColumnName("HaloPartnerID")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.HaloClient)
                    .WithMany(p => p.Haloclientpartners)
                    .HasForeignKey(d => d.HaloClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloClientPartners_1");
            });

            modelBuilder.Entity<Haloclientprogramproducts>(entity =>
            {
                entity.HasKey(e => e.HaloClientProgramProductId);

                entity.ToTable("haloclientprogramproducts", "halo");

                entity.HasIndex(e => e.HaloClientProgramId)
                    .HasName("fk_HaloClientProgramProducts_1_idx");

                entity.Property(e => e.HaloClientProgramProductId)
                    .HasColumnName("HaloClientProgramProductID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientProgramId)
                    .HasColumnName("HaloClientProgramID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientProgramProductDescription).IsUnicode(false);

                entity.Property(e => e.HaloClientProgramProductIcon)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientProgramProductIndex).HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientProgramProductName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientProgramProductOrder).HasColumnType("int(11)");

                entity.Property(e => e.HaloClientProgramProductPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientProgramProductPrice).HasColumnType("decimal(8,2)");

                entity.Property(e => e.HaloClientProgramProductTerms).IsUnicode(false);
            });

            modelBuilder.Entity<Haloclientprograms>(entity =>
            {
                entity.HasKey(e => e.HaloClientProgramId);

                entity.ToTable("haloclientprograms", "halo");

                entity.HasIndex(e => e.HaloClientProgramClientId)
                    .HasName("fk_HaloClientPrograms_1_idx");

                entity.Property(e => e.HaloClientProgramId)
                    .HasColumnName("HaloClientProgramID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientProgramClientId)
                    .HasColumnName("HaloClientProgramClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientProgramCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.HaloClientProgramClient)
                    .WithMany(p => p.Haloclientprograms)
                    .HasForeignKey(d => d.HaloClientProgramClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloClientPrograms_1");
            });

            modelBuilder.Entity<Haloclients>(entity =>
            {
                entity.HasKey(e => e.HaloClientId);

                entity.ToTable("haloclients", "halo");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientAbout).HasColumnType("mediumtext");

                entity.Property(e => e.HaloClientClaimEmailAddress)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientContactDetailsInfo)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasDefaultValueSql("This innovative app service is provided by Global Choices as a result of your insurance policy with ?CLIENTNAME?.");

                entity.Property(e => e.HaloClientEmailAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientEmergencyPhoneNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientFspnumber)
                    .HasColumnName("HaloClientFSPNumber")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientLogoPath)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("/images/clients/default/logo.png");

                entity.Property(e => e.HaloClientName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientPdflogoPath)
                    .HasColumnName("HaloClientPDFLogoPath")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("/images/clients/default/logo.png");

                entity.Property(e => e.HaloClientPhoneNumbers).IsUnicode(false);

                entity.Property(e => e.HaloClientPhysicalAddress).IsUnicode(false);

                entity.Property(e => e.HaloClientPostalAddress).IsUnicode(false);

                entity.Property(e => e.HaloClientRegistrationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloClientResetMessage).IsUnicode(false);

                entity.Property(e => e.HaloClientServices).HasColumnType("mediumtext");

                entity.Property(e => e.HaloClientSmscredits)
                    .HasColumnName("HaloClientSMSCredits")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HaloClientWebsite)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientWelcomeMessage).IsUnicode(false);
            });

            modelBuilder.Entity<Haloclientslogin>(entity =>
            {
                entity.HasKey(e => e.HaloClientLoginId);

                entity.ToTable("haloclientslogin", "halo");

                entity.Property(e => e.HaloClientLoginId)
                    .HasColumnName("HaloClientLoginID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientPassword)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientStatus).HasColumnType("smallint(1)");

                entity.Property(e => e.HaloClientUserName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloClientUserSurname)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HalodictionaryEnZa>(entity =>
            {
                entity.ToTable("halodictionary_en_za", "halo");

                entity.HasIndex(e => e.Key)
                    .HasName("key_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<Halodriverslicences>(entity =>
            {
                entity.HasKey(e => e.HaloDriversLicenceId);

                entity.ToTable("halodriverslicences", "halo");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloDriversLicences_1_idx");

                entity.Property(e => e.HaloDriversLicenceId)
                    .HasColumnName("HaloDriversLicenceID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CertificateNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Class1FirstIssueDate)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Class1VehicleCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Class1VehicleRestrictions).IsUnicode(false);

                entity.Property(e => e.Class2FirstIssueDate)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Class2VehicleCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Class2VehicleRestrictions).IsUnicode(false);

                entity.Property(e => e.Class3FirstIssueDate)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Class3VehicleCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Class3VehicleRestrictions).IsUnicode(false);

                entity.Property(e => e.CountryOfIssue)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DriverRestrictions1).IsUnicode(false);

                entity.Property(e => e.DriverRestrictions2).IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Initials)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IssueNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LicencePhoto).HasColumnType("mediumtext");

                entity.Property(e => e.Pdpcategory)
                    .HasColumnName("PDPCategory")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PdpvalidTo)
                    .HasColumnName("PDPValidTo")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ValidFrom)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTo)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Haloftpaudittrail>(entity =>
            {
                entity.ToTable("haloftpaudittrail", "halo");

                entity.Property(e => e.HaloFtpauditTrailId)
                    .HasColumnName("HaloFTPAuditTrailID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloFtpauditTrailClientId)
                    .HasColumnName("HaloFTPAuditTrailClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloFtpauditTrailFileDateTime)
                    .HasColumnName("HaloFTPAuditTrailFileDateTime")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloFtpauditTrailFileFrom)
                    .HasColumnName("HaloFTPAuditTrailFileFrom")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloFtpauditTrailFileName)
                    .HasColumnName("HaloFTPAuditTrailFileName")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloFtpauditTrailProcDateTime)
                    .HasColumnName("HaloFTPAuditTrailProcDateTime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloFtpauditTrailStatus)
                    .HasColumnName("HaloFTPAuditTrailStatus")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Haloinappapplications>(entity =>
            {
                entity.ToTable("haloinappapplications", "halo");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("ProjectID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RestApiKey)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Haloinappmessages>(entity =>
            {
                entity.ToTable("haloinappmessages", "halo");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_At")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.MessageType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Read)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReadAt).HasColumnName("Read_At");

                entity.Property(e => e.Sent)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SentAt).HasColumnName("Sent_At");

                entity.Property(e => e.Subject).IsUnicode(false);
            });

            modelBuilder.Entity<Haloinappregistration>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("haloinappregistration", "halo");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HalomemberAdditionalClientData>(entity =>
            {
                entity.ToTable("halomember_additional_client_data", "halo");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClientId).HasColumnType("int(11)");

                entity.Property(e => e.ClientIdentifier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.Programme)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PropCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VehicleCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Halomemberclaims>(entity =>
            {
                entity.HasKey(e => e.HaloMemberClaimId);

                entity.ToTable("halomemberclaims", "halo");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloMemberClaims_1_idx");

                entity.Property(e => e.HaloMemberClaimId)
                    .HasColumnName("HaloMemberClaimID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberClaimIncidentAddress).IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimIncidentContactNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimIncidentDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimIncidentDescription).IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimIncidentIdnumber)
                    .HasColumnName("HaloMemberClaimIncidentIDNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimIncidentName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimIncidentSurname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimIncidentTime)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimPicBack)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimPicFront)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimPicLabel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimPicLeft)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimPicLicence)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimPicOdo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimPicRight)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimPicWindscreen)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimSubmitted).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloMemberClaimTowingCompanyContact)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimTowingCompanyDriver)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimTowingCompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimVehicleColour)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimVehicleControlNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimVehicleDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimVehicleEngineNumber)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimVehicleExpiryDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimVehicleLicenceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimVehicleMake)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimVehicleRegisterNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimVehicleSeriesName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimVehicleVinNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.HaloMember)
                    .WithMany(p => p.Halomemberclaims)
                    .HasForeignKey(d => d.HaloMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloMemberClaims_1");
            });

            modelBuilder.Entity<Halomemberclaimseyewitness>(entity =>
            {
                entity.ToTable("halomemberclaimseyewitness", "halo");

                entity.HasIndex(e => e.HaloMemberClaimsId)
                    .HasName("fk_HaloMemberClaimsEyewitness_1_idx");

                entity.Property(e => e.HaloMemberClaimsEyewitnessId)
                    .HasColumnName("HaloMemberClaimsEyewitnessID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberClaimsEyewitnessAddress).IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsEyewitnessContact)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsEyewitnessName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsId)
                    .HasColumnName("HaloMemberClaimsID")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.HaloMemberClaims)
                    .WithMany(p => p.Halomemberclaimseyewitness)
                    .HasForeignKey(d => d.HaloMemberClaimsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloMemberClaimsEyewitness_1");
            });

            modelBuilder.Entity<Halomemberclaimsthirdparty>(entity =>
            {
                entity.ToTable("halomemberclaimsthirdparty", "halo");

                entity.HasIndex(e => e.HaloMemberClaimId)
                    .HasName("fk_HaloMemberClaimsThirdParty_1_idx");

                entity.Property(e => e.HaloMemberClaimsThirdPartyId)
                    .HasColumnName("HaloMemberClaimsThirdPartyID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberClaimId)
                    .HasColumnName("HaloMemberClaimID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberClaimsThirdPartyAddress).IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyColour)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyContact)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyControlNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyEngineNumber)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyExpiryDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyLicenceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyMake)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicBack)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicFront)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicLabel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicLeft)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicLicence)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicOdo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicRight)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicWindscreen)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyRegisterNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartySeriesName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberClaimsThirdPartyVinNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.HaloMemberClaim)
                    .WithMany(p => p.Halomemberclaimsthirdparty)
                    .HasForeignKey(d => d.HaloMemberClaimId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloMemberClaimsThirdParty_1");
            });

            modelBuilder.Entity<Halomemberdependants>(entity =>
            {
                entity.HasKey(e => e.HaloDependantId);

                entity.ToTable("halomemberdependants", "halo");

                entity.HasIndex(e => e.HaloDependantCellPhoneNumber)
                    .HasName("HaloDependantCellPhoneNumber_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloMemberDependants_1_idx");

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloDependantActive)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HaloDependantAllergies).IsUnicode(false);

                entity.Property(e => e.HaloDependantBloodDonorNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantBloodType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantBusinessName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantCellPhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantDateAdded).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloDependantDateOfBirth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantEmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantEmergencyContactName1)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantEmergencyContactName2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantEmergencyContactNumber1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantEmergencyContactNumber2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantFullName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantGender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantHash)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantHomeAddress).IsUnicode(false);

                entity.Property(e => e.HaloDependantHomeLatitude)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantHomeLongitude)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantHomePhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantIdnumber)
                    .HasColumnName("HaloDependantIDNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantIdtype)
                    .HasColumnName("HaloDependantIDType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantImage).HasColumnType("mediumtext");

                entity.Property(e => e.HaloDependantIsHashed)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HaloDependantLanguage)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantMedicalAidName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantMedicalAidNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantMedicalAidScheme)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantOccupation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantRelationship)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantSurname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantTmpIndex)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantWorkAddress).IsUnicode(false);

                entity.Property(e => e.HaloDependantWorkPhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberDependantOtp)
                    .HasColumnName("HaloMemberDependantOTP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberDependantPassword)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberDependantToken)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halomemberftpfiles>(entity =>
            {
                entity.ToTable("halomemberftpfiles", "halo");

                entity.HasIndex(e => e.HaloMemberFtpFilesId)
                    .HasName("HaloMemberFtpFilesID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.HaloMemberFtpFilesId)
                    .HasColumnName("HaloMemberFtpFilesID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberFtpFileProcessed)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("\"No\"");

                entity.Property(e => e.HaloMemberFtpFilesEmailSent)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberFtpFilesFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberFtpFilesTimeStamp)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberFtpFolderName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halomemberloaderror>(entity =>
            {
                entity.ToTable("halomemberloaderror", "halo");

                entity.Property(e => e.HaloMemberLoadErrorId)
                    .HasColumnName("HaloMemberLoadErrorID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloMemberLoadErrorDateSent)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorEmailSent)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorFtpFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorIdNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorIdType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorMobileNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorPolicyNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorSurname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadErrorTimeStamp)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halomembermessages>(entity =>
            {
                entity.HasKey(e => e.HaloMemberMessageId);

                entity.ToTable("halomembermessages", "halo");

                entity.Property(e => e.HaloMemberMessageId)
                    .HasColumnName("HaloMemberMessageID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberMessage).HasColumnType("mediumtext");

                entity.Property(e => e.HaloMemberMessageDeleted)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HaloMemberMessageRead)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HaloMemberMessageSentAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloMemberMessageSentFromId)
                    .HasColumnName("HaloMemberMessageSentFromID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberMessageSentFromName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberMessageSentTo).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halomemberphonenumbers>(entity =>
            {
                entity.HasKey(e => e.HaloMemberPhoneNumberId);

                entity.ToTable("halomemberphonenumbers", "halo");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloMemberPhoneNumbers_1_idx");

                entity.Property(e => e.HaloMemberPhoneNumberId)
                    .HasColumnName("HaloMemberPhoneNumberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberPhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halomemberprograms>(entity =>
            {
                entity.HasKey(e => e.HaloMemberProgramId);

                entity.ToTable("halomemberprograms", "halo");

                entity.HasIndex(e => e.HaloClientId)
                    .HasName("fk_HaloMemberPrograms_1_idx");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloMemberPrograms_2_idx");

                entity.HasIndex(e => e.HaloProgramId)
                    .HasName("fk_HaloMemberPrograms_3_idx");

                entity.Property(e => e.HaloMemberProgramId)
                    .HasColumnName("HaloMemberProgramID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloProgramId)
                    .HasColumnName("HaloProgramID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halomembers>(entity =>
            {
                entity.HasKey(e => e.HaloMemberId);

                entity.ToTable("halomembers", "halo");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberActive)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HaloMemberAllergies).IsUnicode(false);

                entity.Property(e => e.HaloMemberBloodDonorNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberBloodType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberBusinessName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberDataKey)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberDateOfBirth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberEmailAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberEmergencyContactName1)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberEmergencyContactName2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberEmergencyContactNumber1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberEmergencyContactNumber2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberFullName)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberGender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberHash)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberHomeAddress).IsUnicode(false);

                entity.Property(e => e.HaloMemberHomeLatitude)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberHomeLongitude)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberHomePhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberIdnumber)
                    .HasColumnName("HaloMemberIDNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberIdtype)
                    .HasColumnName("HaloMemberIDType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberImage).HasColumnType("mediumtext");

                entity.Property(e => e.HaloMemberIsHashed)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HaloMemberLanguage)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberLoadDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloMemberMedicalAidName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberMedicalAidNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberMedicalAidScheme)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberOccupation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberOtp)
                    .HasColumnName("HaloMemberOTP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberPassword)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberSurname)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberToken)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberVat)
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberWelcomeEmailSent)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HaloMemberWorkAddress).IsUnicode(false);

                entity.Property(e => e.HaloMemberWorkPhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halomembersstage>(entity =>
            {
                entity.HasKey(e => e.HaloMemberId);

                entity.ToTable("halomembersstage", "halo");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberActive)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HaloMemberAllergies).IsUnicode(false);

                entity.Property(e => e.HaloMemberBloodDonorNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberBloodType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberBusinessName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberDateOfBirth)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberEmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberEmergencyContactName1)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberEmergencyContactName2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberEmergencyContactNumber1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberEmergencyContactNumber2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberGender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberHomeAddress).IsUnicode(false);

                entity.Property(e => e.HaloMemberHomeLatitude)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberHomeLongitude)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberHomePhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberIdnumber)
                    .HasColumnName("HaloMemberIDNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberIdtype)
                    .HasColumnName("HaloMemberIDType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberImage).HasColumnType("mediumtext");

                entity.Property(e => e.HaloMemberLanguage)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberMedicalAidName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberMedicalAidNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberMedicalAidScheme)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberOccupation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberOtp)
                    .HasColumnName("HaloMemberOTP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberPassword)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberSurname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberToken)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberWorkAddress).IsUnicode(false);

                entity.Property(e => e.HaloMemberWorkPhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halomobileclientcontent>(entity =>
            {
                entity.ToTable("halomobileclientcontent", "halo");

                entity.Property(e => e.HaloMobileClientContentId)
                    .HasColumnName("HaloMobileClientContentID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMobileClientContentClientId)
                    .HasColumnName("HaloMobileClientContentClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMobileClientContentPageContent).HasColumnType("mediumtext");

                entity.Property(e => e.HaloMobileClientContentPageName)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halomobilecontent>(entity =>
            {
                entity.ToTable("halomobilecontent", "halo");

                entity.Property(e => e.HaloMobileContentId)
                    .HasColumnName("HaloMobileContentID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloMobileContentPageContent).HasColumnType("mediumtext");

                entity.Property(e => e.HaloMobileContentPageName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMobileContentType)
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halonetstar>(entity =>
            {
                entity.ToTable("halonetstar", "halo");

                entity.Property(e => e.HaloNetStarId)
                    .HasColumnName("HaloNetStarID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloNetStarCellNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaloNetStarIdnumber)
                    .HasColumnName("HaloNetStarIDNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloNetStarIncidentDateTimeUtc)
                    .HasColumnName("HaloNetStarIncidentDateTimeUTC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.HaloNetStarIncidentLatitude)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloNetStarIncidentLongitude)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloNetStarIncidentSpeed)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HaloNetStarName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloNetStarPolicyNumber)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloNetStarSurname)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaloNetStarTimeStamp).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloNetStarVehichleRegistration)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halopanics>(entity =>
            {
                entity.HasKey(e => e.HaloPanicId);

                entity.ToTable("halopanics", "halo");

                entity.Property(e => e.HaloPanicId)
                    .HasColumnName("HaloPanicID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloCaseId)
                    .HasColumnName("HaloCaseID")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberPhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloPanicActive)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HaloPanicHandledBy).HasColumnType("bigint(20)");

                entity.Property(e => e.HaloPanicLatitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloPanicLongitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloPanicProductId)
                    .HasColumnName("HaloPanicProductID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloPanicTimeStamp).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloPanicVmiId)
                    .HasColumnName("HaloPanicVmiID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halopartners>(entity =>
            {
                entity.HasKey(e => e.HaloPartnerId);

                entity.ToTable("halopartners", "halo");

                entity.Property(e => e.HaloPartnerId)
                    .HasColumnName("HaloPartnerID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloPartnerAbout).HasColumnType("mediumtext");

                entity.Property(e => e.HaloPartnerEmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaloPartnerLogoPath)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("/images/partners/default/logo.png");

                entity.Property(e => e.HaloPartnerName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaloPartnerPhoneNumbers).IsUnicode(false);

                entity.Property(e => e.HaloPartnerPhysicalAddress).IsUnicode(false);

                entity.Property(e => e.HaloPartnerPostalAddress).IsUnicode(false);

                entity.Property(e => e.HaloPartnerWebsite)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Haloproducts>(entity =>
            {
                entity.HasKey(e => e.HaloProductId);

                entity.ToTable("haloproducts", "halo");

                entity.Property(e => e.HaloProductId)
                    .HasColumnName("HaloProductID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloProductDescription).IsUnicode(false);

                entity.Property(e => e.HaloProductIcon)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloProductName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloProductPhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaloProductPrice).HasColumnType("decimal(8,2)");

                entity.Property(e => e.HaloProductTerms).IsUnicode(false);
            });

            modelBuilder.Entity<Haloreminders>(entity =>
            {
                entity.ToTable("haloreminders", "halo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.InAppMessageId)
                    .HasColumnName("in_app_message_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReminderType)
                    .HasColumnName("reminder_type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Halosentsmss>(entity =>
            {
                entity.HasKey(e => e.HaloSentSmsid);

                entity.ToTable("halosentsmss", "halo");

                entity.Property(e => e.HaloSentSmsid)
                    .HasColumnName("HaloSentSMSID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloSentSmsfromId)
                    .HasColumnName("HaloSentSMSFromID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloSentSmsgatewayResponse)
                    .HasColumnName("HaloSentSMSGatewayResponse")
                    .IsUnicode(false);

                entity.Property(e => e.HaloSentSmsmessage)
                    .HasColumnName("HaloSentSMSMessage")
                    .IsUnicode(false);

                entity.Property(e => e.HaloSentSmstimeStamp)
                    .HasColumnName("HaloSentSMSTimeStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloSentSmstoId)
                    .HasColumnName("HaloSentSMSToID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halositeconfig>(entity =>
            {
                entity.ToTable("halositeconfig", "halo");

                entity.Property(e => e.HaloSiteConfigId)
                    .HasColumnName("HaloSiteConfigID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloSiteConfigKey)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.HaloSiteConfigValue).HasColumnType("mediumtext");
            });

            modelBuilder.Entity<Halovehiclelicences>(entity =>
            {
                entity.HasKey(e => e.HaloVehicleLicenceId);

                entity.ToTable("halovehiclelicences", "halo");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloVehicleLicences_1_idx");

                entity.Property(e => e.HaloVehicleLicenceId)
                    .HasColumnName("HaloVehicleLicenceID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ControlNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EngineNumber)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.LicenceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SeriesName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleColour)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleMake)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VinNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Halovehiclemonitorintegration>(entity =>
            {
                entity.HasKey(e => e.Vmiid);

                entity.ToTable("halovehiclemonitorintegration", "halo");

                entity.Property(e => e.Vmiid)
                    .HasColumnName("VMIID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.UnidentifiedContent).HasColumnType("json");

                entity.Property(e => e.VmicellNumber)
                    .HasColumnName("VMICellNumber")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Vmiidnumber)
                    .HasColumnName("VMIIDNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VmiincidentDateTimeUtc).HasColumnName("VMIIncidentDateTimeUTC");

                entity.Property(e => e.VmiincidentLatitude)
                    .HasColumnName("VMIIncidentLatitude")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.VmiincidentLongitude)
                    .HasColumnName("VMIIncidentLongitude")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.VmiincidentSpeed)
                    .HasColumnName("VMIIncidentSpeed")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VmimemberId)
                    .HasColumnName("VMIMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Vminame)
                    .HasColumnName("VMIName")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.VmipolicyNumber)
                    .HasColumnName("VMIPolicyNumber")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Vmiradius)
                    .HasColumnName("VMIRadius")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vmisource)
                    .HasColumnName("VMISource")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("cartrack");

                entity.Property(e => e.Vmistatus)
                    .HasColumnName("VMIStatus")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Vmisurname)
                    .HasColumnName("VMISurname")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.VmitimeStamp)
                    .HasColumnName("VMITimeStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.VmivehichleRegistration)
                    .HasColumnName("VMIVehichleRegistration")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.ToTable("notifications", "halo");

                entity.HasIndex(e => e.Id)
                    .HasName("notifications_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("longtext");

                entity.Property(e => e.Players)
                    .IsRequired()
                    .HasColumnName("players")
                    .HasColumnType("json");

                entity.Property(e => e.Program)
                    .HasColumnName("program")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sent)
                    .HasColumnName("sent")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Policychangerequests>(entity =>
            {
                entity.ToTable("policychangerequests", "halo");

                entity.HasIndex(e => e.Id)
                    .HasName("PolicyChangeRequests_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeDetails)
                    .HasColumnName("change_details")
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyId)
                    .HasColumnName("policy_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.RiskItemId)
                    .HasColumnName("risk_item_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Providers>(entity =>
            {
                entity.HasKey(e => e.ProviderId);

                entity.ToTable("providers", "halo");

                entity.HasIndex(e => e.ProviderId)
                    .HasName("providers_provider_id_uindex")
                    .IsUnique();

                entity.Property(e => e.ProviderId)
                    .HasColumnName("provider_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccNumber)
                    .HasColumnName("bank_acc_number")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranchCode)
                    .HasColumnName("bank_branch_code")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasColumnName("bank_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BranchPhysicalAddress)
                    .HasColumnName("branch_physical_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessRegistrationNumber)
                    .HasColumnName("business_registration_number")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IncomTaxNumber)
                    .HasColumnName("incom_tax_number")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerContactNumber)
                    .HasColumnName("owner_contact_number")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .HasColumnName("owner_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddress)
                    .HasColumnName("postal_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryContactNumber)
                    .HasColumnName("primary_contact_number")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredBusinessName)
                    .HasColumnName("registered_business_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredPhysicalAddress)
                    .HasColumnName("registered_physical_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryContactNumber)
                    .HasColumnName("secondary_contact_number")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasColumnName("suburb")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TradingBusinessName)
                    .HasColumnName("trading_business_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VatNumber)
                    .HasColumnName("vat_number")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provinces>(entity =>
            {
                entity.HasKey(e => e.ProvinceId);

                entity.ToTable("provinces", "halo");

                entity.HasIndex(e => e.ProvinceId)
                    .HasName("province_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("province_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvinceDescription)
                    .HasColumnName("province_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceName)
                    .HasColumnName("province_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Provincescol)
                    .HasColumnName("provincescol")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProvincesList>(entity =>
            {
                entity.ToTable("provinces_list", "halo");

                entity.HasIndex(e => e.ProvincesListId)
                    .HasName("provinces_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ProvincesListId)
                    .HasColumnName("provinces_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvincesListDescription)
                    .HasColumnName("provinces_list_description")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ProvincesListName)
                    .HasColumnName("provinces_list_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReferenceSubset>(entity =>
            {
                entity.ToTable("reference_subset", "halo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubsetLast)
                    .HasColumnName("subset_last")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SubsetName)
                    .HasColumnName("subset_name")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.SubsetPrefix)
                    .HasColumnName("subset_prefix")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReferralResponse>(entity =>
            {
                entity.ToTable("referral_response", "halo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HttpResponse)
                    .HasColumnName("http_response")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Referrals>(entity =>
            {
                entity.ToTable("referrals", "halo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasColumnName("relationship")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("region", "halo");

                entity.HasIndex(e => e.RegionId)
                    .HasName("region_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.RegionId)
                    .HasColumnName("region_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("province_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegionDescription)
                    .HasColumnName("region_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegionName)
                    .HasColumnName("region_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegionList>(entity =>
            {
                entity.ToTable("region_list", "halo");

                entity.HasIndex(e => e.RegionListId)
                    .HasName("region_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.RegionListId)
                    .HasColumnName("region_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegionListDescription)
                    .HasColumnName("region_list_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegionListName)
                    .HasColumnName("region_list_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceCatagoriesList>(entity =>
            {
                entity.ToTable("service_catagories_list", "halo");

                entity.HasIndex(e => e.ServiceCatagoriesListId)
                    .HasName("service_catagories_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceCatagoriesListId)
                    .HasColumnName("service_catagories_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceCatagoriesListDescription)
                    .HasColumnName("service_catagories_list_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCatagoriesListName)
                    .HasColumnName("service_catagories_list_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceCategories>(entity =>
            {
                entity.HasKey(e => e.ServiceCatagorieId);

                entity.ToTable("service_categories", "halo");

                entity.HasIndex(e => e.ServiceCatagorieId)
                    .HasName("service_catagorie_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceCatagorieId)
                    .HasColumnName("service_catagorie_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceCategorieDescription)
                    .HasColumnName("service_categorie_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCategorieName)
                    .HasColumnName("service_categorie_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ServiceList>(entity =>
            {
                entity.ToTable("service_list", "halo");

                entity.HasIndex(e => e.ServiceListId)
                    .HasName("service_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceListId)
                    .HasColumnName("service_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceListDescription)
                    .HasColumnName("service_list_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceListName)
                    .HasColumnName("service_list_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceProvidersAudit>(entity =>
            {
                entity.ToTable("service_providers_audit", "halo");

                entity.HasIndex(e => e.ServiceProvidersAuditId)
                    .HasName("service_providers_audit_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceProvidersAuditId)
                    .HasColumnName("service_providers_audit_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceProvidersAuditChangeDate)
                    .HasColumnName("service_providers_audit_change_date")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceProvidersAuditChangedTableName)
                    .HasColumnName("service_providers_audit_changed_table_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceProvidersAuditData)
                    .HasColumnName("service_providers_audit_data")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceProvidersAuditType)
                    .HasColumnName("service_providers_audit_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceProvidersAuditUserName)
                    .HasColumnName("service_providers_audit_user_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceSubCatagories>(entity =>
            {
                entity.HasKey(e => e.ServiceSubCatagorieId);

                entity.ToTable("service_sub_catagories", "halo");

                entity.HasIndex(e => e.ServiceSubCatagorieId)
                    .HasName("service_sub_catagorie_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceSubCatagorieId)
                    .HasColumnName("service_sub_catagorie_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceCatagorieId)
                    .HasColumnName("service_catagorie_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceSubCatagorieDescription)
                    .HasColumnName("service_sub_catagorie_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceSubCatagorieName)
                    .HasColumnName("service_sub_catagorie_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceSubCategoriesList>(entity =>
            {
                entity.ToTable("service_sub_categories_list", "halo");

                entity.HasIndex(e => e.ServiceSubCategoriesListId)
                    .HasName("service_sub_categories_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceSubCategoriesListId)
                    .HasColumnName("service_sub_categories_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceSubCategoriesListDescription)
                    .HasColumnName("service_sub_categories_list_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceSubCategoriesListName)
                    .HasColumnName("service_sub_categories_list_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("services", "halo");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("service_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProviderId)
                    .HasColumnName("provider_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceDescription)
                    .HasColumnName("service_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasColumnName("service_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Suburbs>(entity =>
            {
                entity.HasKey(e => e.SuburbId);

                entity.ToTable("suburbs", "halo");

                entity.HasIndex(e => e.SuburbId)
                    .HasName("suburb_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.SuburbId)
                    .HasColumnName("suburb_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address1)
                    .HasColumnName("address_1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address_2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BeeLevel)
                    .HasColumnName("bee_level")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BranchEmailAddress)
                    .HasColumnName("branch_email_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BranchLatitude)
                    .HasColumnName("branch_latitude")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BranchLongitude)
                    .HasColumnName("branch_longitude")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BranchTelephoneNumber)
                    .HasColumnName("branch_telephone_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactCellNo)
                    .HasColumnName("contact_cell_no")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmailAddress)
                    .HasColumnName("contact_email_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCheck)
                    .HasColumnName("credit_check")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateBeeLevel)
                    .HasColumnName("date_bee_level")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreditCheck)
                    .HasColumnName("date_credit_check")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SuburbName)
                    .HasColumnName("suburb_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuburbsList>(entity =>
            {
                entity.ToTable("suburbs_list", "halo");

                entity.HasIndex(e => e.SuburbsListId)
                    .HasName("suburbs_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.SuburbsListId)
                    .HasColumnName("suburbs_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SuburbsListDescription)
                    .HasColumnName("suburbs_list_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SuburbsListName)
                    .HasColumnName("suburbs_list_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.HasKey(e => e.AutoInc);

                entity.ToTable("token", "halo");

                entity.HasIndex(e => e.Id)
                    .HasName("token_id_uindex")
                    .IsUnique();

                entity.Property(e => e.AutoInc)
                    .HasColumnName("auto_inc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Issuer)
                    .HasColumnName("issuer")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.AutoInc);

                entity.ToTable("users", "halo");

                entity.HasIndex(e => e.Email)
                    .HasName("users_email_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("users_id_uindex")
                    .IsUnique();

                entity.Property(e => e.AutoInc)
                    .HasColumnName("auto_inc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnName("last_modified");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .IsUnicode(false);

                entity.Property(e => e.Secret)
                    .HasColumnName("secret")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ussdtest>(entity =>
            {
                entity.ToTable("ussdtest", "halo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contents)
                    .HasColumnName("contents")
                    .HasMaxLength(1023)
                    .IsUnicode(false);
            });
        }
    }
}
