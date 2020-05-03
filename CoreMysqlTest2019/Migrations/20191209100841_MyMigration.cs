using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPortal.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "halo");

            migrationBuilder.CreateTable(
                name: "applicationdistributions",
                schema: "halo",
                columns: table => new
                {
                    DistroID = table.Column<int>(type: "int(11)", nullable: false),
                    DistroNamespace = table.Column<string>(unicode: false, maxLength: 63, nullable: true),
                    DistroTitle = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    DistroJson = table.Column<string>(unicode: false, nullable: true),
                    ClientID = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_applicationdistributions", x => x.DistroID);
                });

            migrationBuilder.CreateTable(
                name: "authtokens",
                schema: "halo",
                columns: table => new
                {
                    at_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    at_user_name = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    at_password = table.Column<string>(unicode: false, maxLength: 1023, nullable: true),
                    at_jwt = table.Column<string>(unicode: false, maxLength: 1023, nullable: true),
                    at_client_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authtokens", x => x.at_id);
                });

            migrationBuilder.CreateTable(
                name: "callcentreaudittrail",
                schema: "halo",
                columns: table => new
                {
                    CallCentreAuditTrailID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CallCentreAuditTrailUserID = table.Column<long>(type: "bigint(20)", nullable: true),
                    CallCentreAuditTrailTransaction = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    CallCentreAuditTrailDate = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_callcentreaudittrail", x => x.CallCentreAuditTrailID);
                });

            migrationBuilder.CreateTable(
                name: "callcentrechatmessages",
                schema: "halo",
                columns: table => new
                {
                    CallCentreChatMessageID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CallCentreChatMessage = table.Column<string>(type: "mediumtext", nullable: true),
                    CallCentreChatMessageSentFrom = table.Column<long>(type: "bigint(20)", nullable: true),
                    CallCentreChatMessageSentTo = table.Column<long>(type: "bigint(20)", nullable: true),
                    CallCentreChatMessageRead = table.Column<byte>(type: "tinyint(1)", nullable: true, defaultValueSql: "0"),
                    CallCentreChatMessageSentAt = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_callcentrechatmessages", x => x.CallCentreChatMessageID);
                });

            migrationBuilder.CreateTable(
                name: "callcentrefaqs",
                schema: "halo",
                columns: table => new
                {
                    CallCentreFAQID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CallCentreFAQQuestion = table.Column<string>(unicode: false, nullable: true),
                    CallCentreFAQAnswer = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_callcentrefaqs", x => x.CallCentreFAQID);
                });

            migrationBuilder.CreateTable(
                name: "callcentrefirestations",
                schema: "halo",
                columns: table => new
                {
                    CallCentreFireStationID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CallCentreFireStationName = table.Column<string>(unicode: false, maxLength: 55, nullable: true),
                    CallCentreFireStationAddress = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CallCentreFireStationLat = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CallCentreFireStationLng = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CallCentreFireStationPhoneNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_callcentrefirestations", x => x.CallCentreFireStationID);
                });

            migrationBuilder.CreateTable(
                name: "callcentremodules",
                schema: "halo",
                columns: table => new
                {
                    CallCentreModuleID = table.Column<short>(type: "smallint(6)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CallCentreModuleName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CallCentreModuleSubNames = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    CallCentreModuleHTML = table.Column<string>(type: "longtext", nullable: true),
                    CallCentreModuleScript = table.Column<string>(type: "longtext", nullable: true),
                    CallCentreModuleOrder = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_callcentremodules", x => x.CallCentreModuleID);
                });

            migrationBuilder.CreateTable(
                name: "callcentrerolemodules",
                schema: "halo",
                columns: table => new
                {
                    CallCentreRoleModuleID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CallCentreRoleID = table.Column<short>(type: "smallint(6)", nullable: true),
                    CallCentreModuleID = table.Column<short>(type: "smallint(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_callcentrerolemodules", x => x.CallCentreRoleModuleID);
                });

            migrationBuilder.CreateTable(
                name: "callcentreuserroles",
                schema: "halo",
                columns: table => new
                {
                    CallCentreUserRoleID = table.Column<short>(type: "smallint(6)", nullable: false),
                    CallCentreUserRoleName = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_callcentreuserroles", x => x.CallCentreUserRoleID);
                });

            migrationBuilder.CreateTable(
                name: "callcentreusers",
                schema: "halo",
                columns: table => new
                {
                    CallCentreUserID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CallCentreUserName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CallCentreUserFirstName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CallCentreUserSurname = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CallCentreUserPassword = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CallCentreUserStatus = table.Column<short>(type: "smallint(1)", nullable: false, defaultValueSql: "1"),
                    CallCentreUserRole = table.Column<short>(type: "smallint(6)", nullable: true),
                    CallCentreUserHash = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CallCentreUserIsHashed = table.Column<short>(type: "smallint(1)", nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_callcentreusers", x => x.CallCentreUserID);
                });

            migrationBuilder.CreateTable(
                name: "cartrack",
                schema: "halo",
                columns: table => new
                {
                    CarTrackID = table.Column<long>(type: "bigint(10)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CarTrackClientNo = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackClientName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackPolicyNumber = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackIdNumber = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackCellphoneNumber = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackEmail = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackEngineNumber = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackModel = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackRegistrationNumber = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackVehicleMake = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackVinNumber = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CarTrackHaloMemberId = table.Column<long>(type: "bigint(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartrack", x => x.CarTrackID);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                schema: "halo",
                columns: table => new
                {
                    city_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    region_id = table.Column<int>(type: "int(11)", nullable: true),
                    city_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    city_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.city_id);
                });

            migrationBuilder.CreateTable(
                name: "cities_list",
                schema: "halo",
                columns: table => new
                {
                    cities_list_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    cities_list_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    cities_list_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities_list", x => x.cities_list_id);
                });

            migrationBuilder.CreateTable(
                name: "client_tokens",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    client_id = table.Column<string>(unicode: false, maxLength: 36, nullable: false),
                    tokens_available = table.Column<int>(type: "int(11)", nullable: false),
                    tokens_used = table.Column<int>(type: "int(11) unsigned zerofill", nullable: true, defaultValueSql: "00000000000"),
                    tokens_brought = table.Column<int>(type: "int(11) unsigned zerofill", nullable: true, defaultValueSql: "00000000000"),
                    type = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_tokens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cmsmodules",
                schema: "halo",
                columns: table => new
                {
                    CMSModuleID = table.Column<short>(type: "smallint(6)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CMSModuleName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CMSModuleSubNames = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    CMSModuleHTML = table.Column<string>(type: "longtext", nullable: true),
                    CMSModuleScript = table.Column<string>(type: "longtext", nullable: true),
                    CMSModuleOrder = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmsmodules", x => x.CMSModuleID);
                });

            migrationBuilder.CreateTable(
                name: "cmsrolemodules",
                schema: "halo",
                columns: table => new
                {
                    CMSRoleModuleID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CMSRoleID = table.Column<short>(type: "smallint(6)", nullable: true),
                    CMSModuleID = table.Column<short>(type: "smallint(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmsrolemodules", x => x.CMSRoleModuleID);
                });

            migrationBuilder.CreateTable(
                name: "cmsuserroles",
                schema: "halo",
                columns: table => new
                {
                    CMSUserRoleID = table.Column<short>(type: "smallint(6)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CMSUserRoleName = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmsuserroles", x => x.CMSUserRoleID);
                });

            migrationBuilder.CreateTable(
                name: "cmsusers",
                schema: "halo",
                columns: table => new
                {
                    CMSUserID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CMSUserName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CMSUserSurname = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CMSUserPassword = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    CMSUserStatus = table.Column<short>(type: "smallint(1)", nullable: false, defaultValueSql: "1"),
                    CMSUserRole = table.Column<short>(type: "smallint(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmsusers", x => x.CMSUserID);
                });

            migrationBuilder.CreateTable(
                name: "communicationlog",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    sent_at = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    body = table.Column<string>(unicode: false, maxLength: 8192, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_communicationlog", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                schema: "halo",
                columns: table => new
                {
                    ContactID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ContactName = table.Column<string>(unicode: false, maxLength: 1023, nullable: true),
                    ContactLastName = table.Column<string>(unicode: false, maxLength: 1023, nullable: true),
                    ContactNumber = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: false),
                    ContactStatus = table.Column<int>(type: "int(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "country",
                schema: "halo",
                columns: table => new
                {
                    country_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    service_sub_catagorie_id = table.Column<int>(type: "int(11)", nullable: true),
                    country_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    country_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.country_id);
                });

            migrationBuilder.CreateTable(
                name: "country_list",
                schema: "halo",
                columns: table => new
                {
                    country_list_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    country_list_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    country_list_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country_list", x => x.country_list_id);
                });

            migrationBuilder.CreateTable(
                name: "edmunds_test",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    edmunds_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    edmunds_surname = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    edmunds_address1 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    edmunds_address2 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    edmunds_city = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    edmunds_province = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    edmunds_salary = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    edmunds_pay_date = table.Column<DateTimeOffset>(nullable: true),
                    edmunds_years_worked = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edmunds_test", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "halo_mobile_content_clients",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    halo_mobile_content_id = table.Column<int>(type: "int(11)", nullable: true),
                    halo_mobile_client_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halo_mobile_content_clients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "haloaudittrail",
                schema: "halo",
                columns: table => new
                {
                    HaloAuditTrailID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloAuditTrailUserID = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloAuditTrailTransaction = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloAuditTrailStatus = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloAuditDate = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloaudittrail", x => x.HaloAuditTrailID);
                });

            migrationBuilder.CreateTable(
                name: "halobatchimported",
                schema: "halo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Date = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Amount = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Failed = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halobatchimported", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "halochatmessages",
                schema: "halo",
                columns: table => new
                {
                    HaloChatMessageID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloChatRequestID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloChatMessage = table.Column<string>(type: "mediumtext", nullable: true),
                    HaloChatMessageSentFrom = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloChatMessageSentTo = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloChatMessageSentAt = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    HaloChatMessageType = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halochatmessages", x => x.HaloChatMessageID);
                });

            migrationBuilder.CreateTable(
                name: "halochatrequests",
                schema: "halo",
                columns: table => new
                {
                    HaloChatRequestID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloChatRequestMemberID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloChatRequestMemberPhoneNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloChatRequestActive = table.Column<byte>(type: "tinyint(1)", nullable: true, defaultValueSql: "1"),
                    HaloChatRequestTimeStamp = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    HaloChatRequestLastTransaction = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    HaloChatRequestHandledBy = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloChatRequestHandledAt = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloChatRequestLatitude = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloChatRequestLongitude = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloChatRequestHasUnread = table.Column<byte>(type: "tinyint(1)", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halochatrequests", x => x.HaloChatRequestID);
                });

            migrationBuilder.CreateTable(
                name: "haloclaims",
                schema: "halo",
                columns: table => new
                {
                    ClaimID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: false),
                    HaloDependantID = table.Column<long>(type: "bigint(20)", nullable: false),
                    ClaimType = table.Column<int>(type: "int(11)", nullable: true),
                    ClaimStatus = table.Column<int>(type: "int(11)", nullable: true),
                    ClaimJson = table.Column<string>(type: "mediumtext", nullable: true),
                    ClaimCreatedAt = table.Column<DateTime>(nullable: true),
                    ClaimSubmittedAt = table.Column<DateTime>(nullable: true),
                    ClaimModifiedAt = table.Column<DateTime>(nullable: true),
                    ClaimClientID = table.Column<long>(type: "bigint(20)", nullable: false),
                    ClaimReference = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloclaims", x => x.ClaimID);
                });

            migrationBuilder.CreateTable(
                name: "haloclaimtypes",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    claimType = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    groupName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    cimsType = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloclaimtypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "haloclientapiregister",
                schema: "halo",
                columns: table => new
                {
                    apiclientid = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    clientname = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    clientemail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    passwordhash = table.Column<string>(unicode: false, nullable: false),
                    token = table.Column<string>(unicode: false, nullable: false),
                    createdat = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloclientapiregister", x => x.apiclientid);
                });

            migrationBuilder.CreateTable(
                name: "haloclientmembers",
                schema: "halo",
                columns: table => new
                {
                    HaloClientMemberID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloClientID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloclientmembers", x => x.HaloClientMemberID);
                });

            migrationBuilder.CreateTable(
                name: "haloclientprogramproducts",
                schema: "halo",
                columns: table => new
                {
                    HaloClientProgramProductID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloClientProgramID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloClientProgramProductIndex = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloClientProgramProductName = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloClientProgramProductIcon = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloClientProgramProductDescription = table.Column<string>(unicode: false, nullable: true),
                    HaloClientProgramProductTerms = table.Column<string>(unicode: false, nullable: true),
                    HaloClientProgramProductPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    HaloClientProgramProductPhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloClientProgramProductOrder = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloclientprogramproducts", x => x.HaloClientProgramProductID);
                });

            migrationBuilder.CreateTable(
                name: "haloclients",
                schema: "halo",
                columns: table => new
                {
                    HaloClientID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloClientName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloClientCode = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloClientRegistrationDate = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    HaloClientLogoPath = table.Column<string>(unicode: false, maxLength: 80, nullable: true, defaultValueSql: "/images/clients/default/logo.png"),
                    HaloClientPDFLogoPath = table.Column<string>(unicode: false, maxLength: 80, nullable: true, defaultValueSql: "/images/clients/default/logo.png"),
                    HaloClientFSPNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloClientPhoneNumbers = table.Column<string>(unicode: false, nullable: true),
                    HaloClientEmailAddress = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloClientClaimEmailAddress = table.Column<string>(unicode: false, maxLength: 512, nullable: true),
                    HaloClientWebsite = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloClientPhysicalAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloClientPostalAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloClientServices = table.Column<string>(type: "mediumtext", nullable: true),
                    HaloClientAbout = table.Column<string>(type: "mediumtext", nullable: true),
                    HaloClientWelcomeMessage = table.Column<string>(unicode: false, nullable: true),
                    HaloClientResetMessage = table.Column<string>(unicode: false, nullable: true),
                    HaloClientSMSCredits = table.Column<long>(type: "bigint(20)", nullable: true, defaultValueSql: "0"),
                    HaloClientEmergencyPhoneNumber = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    HaloClientContactDetailsInfo = table.Column<string>(unicode: false, maxLength: 512, nullable: true, defaultValueSql: "This innovative app service is provided by Global Choices as a result of your insurance policy with ?CLIENTNAME?.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloclients", x => x.HaloClientID);
                });

            migrationBuilder.CreateTable(
                name: "haloclientslogin",
                schema: "halo",
                columns: table => new
                {
                    HaloClientLoginID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloClientID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloClientUserName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloClientUserSurname = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloClientPassword = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloClientStatus = table.Column<short>(type: "smallint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloclientslogin", x => x.HaloClientLoginID);
                });

            migrationBuilder.CreateTable(
                name: "halodictionary_en_za",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    key = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    value = table.Column<string>(type: "mediumtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halodictionary_en_za", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "halodriverslicences",
                schema: "halo",
                columns: table => new
                {
                    HaloDriversLicenceID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloDependantID = table.Column<long>(type: "bigint(20)", nullable: true),
                    IDNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Surname = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Initials = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Gender = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    DriverRestrictions1 = table.Column<string>(unicode: false, nullable: true),
                    DriverRestrictions2 = table.Column<string>(unicode: false, nullable: true),
                    DateOfBirth = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    CertificateNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    CountryOfIssue = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    IssueNumber = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ValidFrom = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    ValidTo = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    PDPCategory = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    PDPValidTo = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    Class1VehicleCode = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Class1VehicleRestrictions = table.Column<string>(unicode: false, nullable: true),
                    Class1FirstIssueDate = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    Class2VehicleCode = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Class2VehicleRestrictions = table.Column<string>(unicode: false, nullable: true),
                    Class2FirstIssueDate = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    Class3VehicleCode = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Class3VehicleRestrictions = table.Column<string>(unicode: false, nullable: true),
                    Class3FirstIssueDate = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    LicencePhoto = table.Column<string>(type: "mediumtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halodriverslicences", x => x.HaloDriversLicenceID);
                });

            migrationBuilder.CreateTable(
                name: "haloftpaudittrail",
                schema: "halo",
                columns: table => new
                {
                    HaloFTPAuditTrailID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloFTPAuditTrailFileName = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloFTPAuditTrailFileFrom = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloFTPAuditTrailFileDateTime = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloFTPAuditTrailProcDateTime = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    HaloFTPAuditTrailClientID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloFTPAuditTrailStatus = table.Column<string>(unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloftpaudittrail", x => x.HaloFTPAuditTrailID);
                });

            migrationBuilder.CreateTable(
                name: "haloinappapplications",
                schema: "halo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ClientID = table.Column<long>(type: "bigint(20)", nullable: true),
                    ProjectID = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    RestApiKey = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloinappapplications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "haloinappmessages",
                schema: "halo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Created_At = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    MessageType = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Subject = table.Column<string>(unicode: false, nullable: true),
                    Message = table.Column<string>(unicode: false, nullable: true),
                    MemberID = table.Column<int>(type: "int(11)", nullable: true),
                    Read = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "0"),
                    Sent = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "0"),
                    Sent_At = table.Column<DateTimeOffset>(nullable: true),
                    Read_At = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloinappmessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "haloinappregistration",
                schema: "halo",
                columns: table => new
                {
                    MemberID = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    PlayerID = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloinappregistration", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "halomember_additional_client_data",
                schema: "halo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    MemberId = table.Column<int>(type: "int(11)", nullable: false),
                    ClientId = table.Column<int>(type: "int(11)", nullable: false),
                    Programme = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ClientIdentifier = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    VehicleCount = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "0"),
                    PropCount = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "0"),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomember_additional_client_data", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "halomemberdependants",
                schema: "halo",
                columns: table => new
                {
                    HaloDependantID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloDependantRelationship = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloDependantName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloDependantSurname = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloDependantIDNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberDependantPassword = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberDependantOTP = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    HaloMemberDependantToken = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloDependantEmailAddress = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloDependantLanguage = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloDependantGender = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    HaloDependantIDType = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    HaloDependantDateOfBirth = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HaloDependantCellPhoneNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloDependantHomePhoneNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloDependantWorkPhoneNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloDependantMedicalAidName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloDependantMedicalAidNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloDependantMedicalAidScheme = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloDependantHomeAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloDependantWorkAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloDependantEmergencyContactName1 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloDependantEmergencyContactNumber1 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloDependantEmergencyContactName2 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloDependantEmergencyContactNumber2 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloDependantOccupation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloDependantBusinessName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloDependantBloodType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HaloDependantBloodDonorNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloDependantAllergies = table.Column<string>(unicode: false, nullable: true),
                    HaloDependantHomeLatitude = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloDependantHomeLongitude = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloDependantImage = table.Column<string>(type: "mediumtext", nullable: true),
                    HaloDependantTmpIndex = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    HaloDependantActive = table.Column<short>(type: "smallint(1)", nullable: true, defaultValueSql: "1"),
                    HaloDependantHash = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloDependantIsHashed = table.Column<short>(type: "smallint(1)", nullable: true, defaultValueSql: "1"),
                    HaloDependantFullName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloDependantDateAdded = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomemberdependants", x => x.HaloDependantID);
                });

            migrationBuilder.CreateTable(
                name: "halomemberftpfiles",
                schema: "halo",
                columns: table => new
                {
                    HaloMemberFtpFilesID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberFtpFilesFileName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberFtpFileProcessed = table.Column<string>(unicode: false, maxLength: 255, nullable: true, defaultValueSql: "\"No\""),
                    HaloMemberFtpFilesTimeStamp = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberFtpFolderName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberFtpFilesEmailSent = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomemberftpfiles", x => x.HaloMemberFtpFilesID);
                });

            migrationBuilder.CreateTable(
                name: "halomemberloaderror",
                schema: "halo",
                columns: table => new
                {
                    HaloMemberLoadErrorID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberLoadErrorDescription = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorFtpFileName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorTimeStamp = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorPolicyNumber = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorMobileNumber = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorSurname = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorIdType = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorIdNumber = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorEmail = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorEmailSent = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLoadErrorDateSent = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomemberloaderror", x => x.HaloMemberLoadErrorID);
                });

            migrationBuilder.CreateTable(
                name: "halomembermessages",
                schema: "halo",
                columns: table => new
                {
                    HaloMemberMessageID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberMessage = table.Column<string>(type: "mediumtext", nullable: true),
                    HaloMemberMessageSentFromID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloMemberMessageSentFromName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberMessageSentTo = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloMemberMessageRead = table.Column<byte>(type: "tinyint(1)", nullable: true, defaultValueSql: "0"),
                    HaloMemberMessageSentAt = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    HaloMemberMessageDeleted = table.Column<byte>(type: "tinyint(1)", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomembermessages", x => x.HaloMemberMessageID);
                });

            migrationBuilder.CreateTable(
                name: "halomemberphonenumbers",
                schema: "halo",
                columns: table => new
                {
                    HaloMemberPhoneNumberID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloMemberPhoneNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomemberphonenumbers", x => x.HaloMemberPhoneNumberID);
                });

            migrationBuilder.CreateTable(
                name: "halomemberprograms",
                schema: "halo",
                columns: table => new
                {
                    HaloMemberProgramID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloClientID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloProgramID = table.Column<long>(type: "bigint(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomemberprograms", x => x.HaloMemberProgramID);
                });

            migrationBuilder.CreateTable(
                name: "halomembers",
                schema: "halo",
                columns: table => new
                {
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberSurname = table.Column<string>(unicode: false, maxLength: 400, nullable: true),
                    HaloMemberIDNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberPassword = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberOTP = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    HaloMemberToken = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberEmailAddress = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberLanguage = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberGender = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    HaloMemberIDType = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    HaloMemberDateOfBirth = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HaloMemberHomePhoneNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloMemberWorkPhoneNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloMemberMedicalAidName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberMedicalAidNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberMedicalAidScheme = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberHomeAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloMemberWorkAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloMemberEmergencyContactName1 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberEmergencyContactNumber1 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberEmergencyContactName2 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberEmergencyContactNumber2 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberOccupation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberBusinessName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberBloodType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HaloMemberBloodDonorNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberAllergies = table.Column<string>(unicode: false, nullable: true),
                    HaloMemberHomeLatitude = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberHomeLongitude = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberImage = table.Column<string>(type: "mediumtext", nullable: true),
                    HaloMemberActive = table.Column<short>(type: "smallint(1)", nullable: true, defaultValueSql: "1"),
                    HaloMemberDataKey = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberLoadDate = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    HaloMemberWelcomeEmailSent = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "0"),
                    HaloMemberHash = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloMemberIsHashed = table.Column<short>(type: "smallint(1)", nullable: true, defaultValueSql: "1"),
                    HaloMemberVat = table.Column<string>(unicode: false, maxLength: 31, nullable: true),
                    HaloMemberActivateDate = table.Column<DateTimeOffset>(nullable: true),
                    HaloMemberModifiedDate = table.Column<DateTimeOffset>(nullable: true),
                    HaloMemberFullName = table.Column<string>(unicode: false, maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomembers", x => x.HaloMemberID);
                });

            migrationBuilder.CreateTable(
                name: "halomembersstage",
                schema: "halo",
                columns: table => new
                {
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberSurname = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberIDNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberPassword = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberOTP = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    HaloMemberToken = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberEmailAddress = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberLanguage = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberGender = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    HaloMemberIDType = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    HaloMemberDateOfBirth = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    HaloMemberHomePhoneNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloMemberWorkPhoneNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloMemberMedicalAidName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberMedicalAidNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberMedicalAidScheme = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberHomeAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloMemberWorkAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloMemberEmergencyContactName1 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberEmergencyContactNumber1 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloMemberEmergencyContactName2 = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberEmergencyContactNumber2 = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloMemberOccupation = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberBusinessName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberBloodType = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    HaloMemberBloodDonorNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberAllergies = table.Column<string>(unicode: false, nullable: true),
                    HaloMemberHomeLatitude = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberHomeLongitude = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberImage = table.Column<string>(type: "mediumtext", nullable: true),
                    HaloMemberActive = table.Column<short>(type: "smallint(1)", nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomembersstage", x => x.HaloMemberID);
                });

            migrationBuilder.CreateTable(
                name: "halomobileclientcontent",
                schema: "halo",
                columns: table => new
                {
                    HaloMobileClientContentID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMobileClientContentClientID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloMobileClientContentPageName = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMobileClientContentPageContent = table.Column<string>(type: "mediumtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomobileclientcontent", x => x.HaloMobileClientContentID);
                });

            migrationBuilder.CreateTable(
                name: "halomobilecontent",
                schema: "halo",
                columns: table => new
                {
                    HaloMobileContentID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMobileContentPageName = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMobileContentPageContent = table.Column<string>(type: "mediumtext", nullable: true),
                    HaloMobileContentType = table.Column<string>(unicode: false, maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomobilecontent", x => x.HaloMobileContentID);
                });

            migrationBuilder.CreateTable(
                name: "halonetstar",
                schema: "halo",
                columns: table => new
                {
                    HaloNetStarID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloNetStarName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloNetStarSurname = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloNetStarCellNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloNetStarIDNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloNetStarPolicyNumber = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloNetStarIncidentDateTimeUTC = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    HaloNetStarIncidentSpeed = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    HaloNetStarIncidentLongitude = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloNetStarIncidentLatitude = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloNetStarVehichleRegistration = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloNetStarTimeStamp = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halonetstar", x => x.HaloNetStarID);
                });

            migrationBuilder.CreateTable(
                name: "halopanics",
                schema: "halo",
                columns: table => new
                {
                    HaloPanicID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloMemberPhoneNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloPanicLatitude = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloPanicLongitude = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloPanicActive = table.Column<byte>(type: "tinyint(1)", nullable: true, defaultValueSql: "1"),
                    HaloPanicTimeStamp = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    HaloPanicHandledBy = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloPanicHandledAt = table.Column<DateTimeOffset>(nullable: true),
                    HaloPanicProductID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloPanicVmiID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloCaseID = table.Column<string>(unicode: false, maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halopanics", x => x.HaloPanicID);
                });

            migrationBuilder.CreateTable(
                name: "halopartners",
                schema: "halo",
                columns: table => new
                {
                    HaloPartnerID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloPartnerName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloPartnerLogoPath = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "/images/partners/default/logo.png"),
                    HaloPartnerPhoneNumbers = table.Column<string>(unicode: false, nullable: true),
                    HaloPartnerEmailAddress = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloPartnerPhysicalAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloPartnerPostalAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloPartnerWebsite = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    HaloPartnerAbout = table.Column<string>(type: "mediumtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halopartners", x => x.HaloPartnerID);
                });

            migrationBuilder.CreateTable(
                name: "haloproducts",
                schema: "halo",
                columns: table => new
                {
                    HaloProductID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloProductName = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloProductIcon = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloProductDescription = table.Column<string>(unicode: false, nullable: true),
                    HaloProductTerms = table.Column<string>(unicode: false, nullable: true),
                    HaloProductPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    HaloProductPhoneNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloproducts", x => x.HaloProductID);
                });

            migrationBuilder.CreateTable(
                name: "haloreminders",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    reminder_type = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "0"),
                    reference_number = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    in_app_message_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    created_at = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloreminders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "halosentsmss",
                schema: "halo",
                columns: table => new
                {
                    HaloSentSMSID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloSentSMSFromID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloSentSMSToID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloSentSMSMessage = table.Column<string>(unicode: false, nullable: true),
                    HaloSentSMSTimeStamp = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    HaloSentSMSGatewayResponse = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halosentsmss", x => x.HaloSentSMSID);
                });

            migrationBuilder.CreateTable(
                name: "halositeconfig",
                schema: "halo",
                columns: table => new
                {
                    HaloSiteConfigID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloSiteConfigKey = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloSiteConfigValue = table.Column<string>(type: "mediumtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halositeconfig", x => x.HaloSiteConfigID);
                });

            migrationBuilder.CreateTable(
                name: "halovehiclelicences",
                schema: "halo",
                columns: table => new
                {
                    HaloVehicleLicenceID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloDependantID = table.Column<long>(type: "bigint(20)", nullable: true),
                    ControlNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    LicenceNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    RegisterNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    VehicleDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    VehicleMake = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    SeriesName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    VehicleColour = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    VinNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    EngineNumber = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    ExpiryDate = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    VehicleYear = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halovehiclelicences", x => x.HaloVehicleLicenceID);
                });

            migrationBuilder.CreateTable(
                name: "halovehiclemonitorintegration",
                schema: "halo",
                columns: table => new
                {
                    VMIID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    VMIName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    VMISurname = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    VMICellNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    VMIIDNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    VMIPolicyNumber = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    VMIIncidentDateTimeUTC = table.Column<DateTime>(nullable: true),
                    VMIIncidentSpeed = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    VMIIncidentLongitude = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    VMIIncidentLatitude = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    VMIRadius = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    VMIVehichleRegistration = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    VMITimeStamp = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UnidentifiedContent = table.Column<string>(type: "json", nullable: true),
                    VMIStatus = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "0"),
                    VMIMemberID = table.Column<long>(type: "bigint(20)", nullable: true),
                    VMISource = table.Column<string>(unicode: false, maxLength: 32, nullable: true, defaultValueSql: "cartrack")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halovehiclemonitorintegration", x => x.VMIID);
                });

            migrationBuilder.CreateTable(
                name: "notifications",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    client_id = table.Column<int>(type: "int(11)", nullable: false),
                    subject = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    content = table.Column<string>(type: "longtext", nullable: false),
                    time = table.Column<DateTime>(nullable: false),
                    type = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "1"),
                    players = table.Column<string>(type: "json", nullable: false),
                    program = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    sent = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "policychangerequests",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    user_id = table.Column<long>(type: "bigint(20)", nullable: false),
                    change_details = table.Column<string>(unicode: false, maxLength: 1023, nullable: true),
                    policy_id = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    risk_item_id = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    request_timestamp = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_policychangerequests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "providers",
                schema: "halo",
                columns: table => new
                {
                    provider_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    registered_business_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    trading_business_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    business_registration_number = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    bank_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    bank_acc_number = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    bank_branch_code = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    registered_physical_address = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    branch_physical_address = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    suburb = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    area = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    region = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    postal_address = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    postal_code = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    incom_tax_number = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    vat_number = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    email_address = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    website = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    primary_contact_number = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    secondary_contact_number = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    owner_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    owner_contact_number = table.Column<string>(unicode: false, maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_providers", x => x.provider_id);
                });

            migrationBuilder.CreateTable(
                name: "provinces",
                schema: "halo",
                columns: table => new
                {
                    province_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    country_id = table.Column<int>(type: "int(11)", nullable: true),
                    province_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    province_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    provincescol = table.Column<string>(unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provinces", x => x.province_id);
                });

            migrationBuilder.CreateTable(
                name: "provinces_list",
                schema: "halo",
                columns: table => new
                {
                    provinces_list_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    provinces_list_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    provinces_list_description = table.Column<string>(unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provinces_list", x => x.provinces_list_id);
                });

            migrationBuilder.CreateTable(
                name: "reference_subset",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    subset_name = table.Column<string>(unicode: false, maxLength: 36, nullable: true),
                    subset_prefix = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    subset_last = table.Column<string>(unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reference_subset", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "referral_response",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    http_response = table.Column<string>(unicode: false, nullable: true),
                    create_at = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referral_response", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "referrals",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(unicode: false, maxLength: 1024, nullable: true),
                    contact = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    relationship = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    client_id = table.Column<int>(type: "int(11)", nullable: true),
                    member_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    timestamp = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referrals", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "region",
                schema: "halo",
                columns: table => new
                {
                    region_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    province_id = table.Column<int>(type: "int(11)", nullable: true),
                    region_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    region_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_region", x => x.region_id);
                });

            migrationBuilder.CreateTable(
                name: "region_list",
                schema: "halo",
                columns: table => new
                {
                    region_list_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    region_list_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    region_list_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_region_list", x => x.region_list_id);
                });

            migrationBuilder.CreateTable(
                name: "service_catagories_list",
                schema: "halo",
                columns: table => new
                {
                    service_catagories_list_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    service_catagories_list_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    service_catagories_list_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service_catagories_list", x => x.service_catagories_list_id);
                });

            migrationBuilder.CreateTable(
                name: "service_categories",
                schema: "halo",
                columns: table => new
                {
                    service_catagorie_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    service_id = table.Column<int>(type: "int(11)", nullable: true),
                    service_categorie_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    service_categorie_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service_categories", x => x.service_catagorie_id);
                });

            migrationBuilder.CreateTable(
                name: "service_list",
                schema: "halo",
                columns: table => new
                {
                    service_list_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    service_list_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    service_list_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service_list", x => x.service_list_id);
                });

            migrationBuilder.CreateTable(
                name: "service_providers_audit",
                schema: "halo",
                columns: table => new
                {
                    service_providers_audit_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    service_providers_audit_user_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    service_providers_audit_type = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    service_providers_audit_change_date = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    service_providers_audit_changed_table_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    service_providers_audit_data = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service_providers_audit", x => x.service_providers_audit_id);
                });

            migrationBuilder.CreateTable(
                name: "service_sub_catagories",
                schema: "halo",
                columns: table => new
                {
                    service_sub_catagorie_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    service_catagorie_id = table.Column<int>(type: "int(11)", nullable: true),
                    service_sub_catagorie_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    service_sub_catagorie_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service_sub_catagories", x => x.service_sub_catagorie_id);
                });

            migrationBuilder.CreateTable(
                name: "service_sub_categories_list",
                schema: "halo",
                columns: table => new
                {
                    service_sub_categories_list_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    service_sub_categories_list_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    service_sub_categories_list_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service_sub_categories_list", x => x.service_sub_categories_list_id);
                });

            migrationBuilder.CreateTable(
                name: "services",
                schema: "halo",
                columns: table => new
                {
                    service_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    provider_id = table.Column<int>(type: "int(11)", nullable: true),
                    service_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    service_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.service_id);
                });

            migrationBuilder.CreateTable(
                name: "suburbs",
                schema: "halo",
                columns: table => new
                {
                    suburb_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    city_id = table.Column<int>(type: "int(11)", nullable: true),
                    suburb_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    address_1 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    address_2 = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    postal_code = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    contact_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    contact_cell_no = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    contact_email_address = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    branch_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    branch_telephone_number = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    branch_email_address = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    branch_latitude = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    branch_longitude = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    bee_level = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    date_bee_level = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    credit_check = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    date_credit_check = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suburbs", x => x.suburb_id);
                });

            migrationBuilder.CreateTable(
                name: "suburbs_list",
                schema: "halo",
                columns: table => new
                {
                    suburbs_list_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    suburbs_list_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    suburbs_list_description = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suburbs_list", x => x.suburbs_list_id);
                });

            migrationBuilder.CreateTable(
                name: "token",
                schema: "halo",
                columns: table => new
                {
                    auto_inc = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id = table.Column<string>(unicode: false, maxLength: 36, nullable: true),
                    issuer = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    user_id = table.Column<string>(unicode: false, maxLength: 36, nullable: true),
                    created_at = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_token", x => x.auto_inc);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "halo",
                columns: table => new
                {
                    auto_inc = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    username = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    password = table.Column<string>(unicode: false, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 1023, nullable: true),
                    secret = table.Column<string>(unicode: false, maxLength: 36, nullable: true),
                    created_at = table.Column<DateTime>(nullable: true),
                    last_modified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.auto_inc);
                });

            migrationBuilder.CreateTable(
                name: "ussdtest",
                schema: "halo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    contents = table.Column<string>(unicode: false, maxLength: 1023, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ussdtest", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "halobranches",
                schema: "halo",
                columns: table => new
                {
                    HaloBranchID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloClientID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloBranchName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloBranchPhoneNumbers = table.Column<string>(unicode: false, nullable: true),
                    HaloBranchEmailAddress = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloBranchPhysicalAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloBranchPostalAddress = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halobranches", x => x.HaloBranchID);
                    table.ForeignKey(
                        name: "fk_HaloBranches_1",
                        column: x => x.HaloClientID,
                        principalSchema: "halo",
                        principalTable: "haloclients",
                        principalColumn: "HaloClientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "haloclientbanners",
                schema: "halo",
                columns: table => new
                {
                    HaloClientBannerID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloClientID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloClientBannerPath = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloclientbanners", x => x.HaloClientBannerID);
                    table.ForeignKey(
                        name: "fk_HaloClientBanners_1",
                        column: x => x.HaloClientID,
                        principalSchema: "halo",
                        principalTable: "haloclients",
                        principalColumn: "HaloClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "haloclientpartners",
                schema: "halo",
                columns: table => new
                {
                    HaloClientPartnerID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloClientID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloPartnerID = table.Column<long>(type: "bigint(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloclientpartners", x => x.HaloClientPartnerID);
                    table.ForeignKey(
                        name: "fk_HaloClientPartners_1",
                        column: x => x.HaloClientID,
                        principalSchema: "halo",
                        principalTable: "haloclients",
                        principalColumn: "HaloClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "haloclientprograms",
                schema: "halo",
                columns: table => new
                {
                    HaloClientProgramID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloClientProgramClientID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloClientProgramCode = table.Column<string>(unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haloclientprograms", x => x.HaloClientProgramID);
                    table.ForeignKey(
                        name: "fk_HaloClientPrograms_1",
                        column: x => x.HaloClientProgramClientID,
                        principalSchema: "halo",
                        principalTable: "haloclients",
                        principalColumn: "HaloClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "halomemberclaims",
                schema: "halo",
                columns: table => new
                {
                    HaloMemberClaimID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloDependantID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloMemberClaimIncidentDate = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberClaimIncidentTime = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberClaimIncidentAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloMemberClaimIncidentDescription = table.Column<string>(unicode: false, nullable: true),
                    HaloMemberClaimIncidentIDNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberClaimIncidentName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberClaimIncidentSurname = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberClaimIncidentContactNumber = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloMemberClaimVehicleControlNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberClaimVehicleLicenceNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberClaimVehicleRegisterNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberClaimVehicleDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimVehicleMake = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimVehicleSeriesName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimVehicleColour = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimVehicleVinNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberClaimVehicleEngineNumber = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberClaimVehicleExpiryDate = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    HaloMemberClaimTowingCompanyName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimTowingCompanyDriver = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimTowingCompanyContact = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimPicFront = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimPicLeft = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimPicBack = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimPicRight = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimPicWindscreen = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimPicLabel = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimPicOdo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimPicLicence = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimSubmitted = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomemberclaims", x => x.HaloMemberClaimID);
                    table.ForeignKey(
                        name: "fk_HaloMemberClaims_1",
                        column: x => x.HaloMemberID,
                        principalSchema: "halo",
                        principalTable: "halomembers",
                        principalColumn: "HaloMemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "halomemberclaimseyewitness",
                schema: "halo",
                columns: table => new
                {
                    HaloMemberClaimsEyewitnessID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberClaimsID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloMemberClaimsEyewitnessName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberClaimsEyewitnessContact = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloMemberClaimsEyewitnessAddress = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomemberclaimseyewitness", x => x.HaloMemberClaimsEyewitnessID);
                    table.ForeignKey(
                        name: "fk_HaloMemberClaimsEyewitness_1",
                        column: x => x.HaloMemberClaimsID,
                        principalSchema: "halo",
                        principalTable: "halomemberclaims",
                        principalColumn: "HaloMemberClaimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "halomemberclaimsthirdparty",
                schema: "halo",
                columns: table => new
                {
                    HaloMemberClaimsThirdPartyID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    HaloMemberClaimID = table.Column<long>(type: "bigint(20)", nullable: true),
                    HaloMemberClaimsThirdPartyName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    HaloMemberClaimsThirdPartyContact = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HaloMemberClaimsThirdPartyAddress = table.Column<string>(unicode: false, nullable: true),
                    HaloMemberClaimsThirdPartyControlNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberClaimsThirdPartyLicenceNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberClaimsThirdPartyRegisterNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HaloMemberClaimsThirdPartyDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyMake = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartySeriesName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyColour = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyVinNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    HaloMemberClaimsThirdPartyEngineNumber = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    HaloMemberClaimsThirdPartyExpiryDate = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyPicFront = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyPicLeft = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyPicBack = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyPicRight = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyPicWindscreen = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyPicLabel = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyPicOdo = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HaloMemberClaimsThirdPartyPicLicence = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halomemberclaimsthirdparty", x => x.HaloMemberClaimsThirdPartyID);
                    table.ForeignKey(
                        name: "fk_HaloMemberClaimsThirdParty_1",
                        column: x => x.HaloMemberClaimID,
                        principalSchema: "halo",
                        principalTable: "halomemberclaims",
                        principalColumn: "HaloMemberClaimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "CallCentreUserName_UNIQUE",
                schema: "halo",
                table: "callcentreusers",
                column: "CallCentreUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "city_id_UNIQUE",
                schema: "halo",
                table: "cities",
                column: "city_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "cities_list_id_UNIQUE",
                schema: "halo",
                table: "cities_list",
                column: "cities_list_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CMSUserName_UNIQUE",
                schema: "halo",
                table: "cmsusers",
                column: "CMSUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_CMSUsers_1_idx",
                schema: "halo",
                table: "cmsusers",
                column: "CMSUserRole");

            migrationBuilder.CreateIndex(
                name: "CommunicationLog_id_uindex",
                schema: "halo",
                table: "communicationlog",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "country_id_UNIQUE",
                schema: "halo",
                table: "country",
                column: "country_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "country_list_id_UNIQUE",
                schema: "halo",
                table: "country_list",
                column: "country_list_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_HaloBranches_1_idx",
                schema: "halo",
                table: "halobranches",
                column: "HaloClientID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloChatMessages_1_idx",
                schema: "halo",
                table: "halochatmessages",
                column: "HaloChatRequestID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloClientBanners_1_idx",
                schema: "halo",
                table: "haloclientbanners",
                column: "HaloClientID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloClientMembers_1_idx",
                schema: "halo",
                table: "haloclientmembers",
                column: "HaloClientID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloClientMembers_2_idx",
                schema: "halo",
                table: "haloclientmembers",
                column: "HaloMemberID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloClientPartners_1_idx",
                schema: "halo",
                table: "haloclientpartners",
                column: "HaloClientID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloClientProgramProducts_1_idx",
                schema: "halo",
                table: "haloclientprogramproducts",
                column: "HaloClientProgramID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloClientPrograms_1_idx",
                schema: "halo",
                table: "haloclientprograms",
                column: "HaloClientProgramClientID");

            migrationBuilder.CreateIndex(
                name: "key_UNIQUE",
                schema: "halo",
                table: "halodictionary_en_za",
                column: "key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_HaloDriversLicences_1_idx",
                schema: "halo",
                table: "halodriverslicences",
                column: "HaloMemberID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloMemberClaims_1_idx",
                schema: "halo",
                table: "halomemberclaims",
                column: "HaloMemberID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloMemberClaimsEyewitness_1_idx",
                schema: "halo",
                table: "halomemberclaimseyewitness",
                column: "HaloMemberClaimsID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloMemberClaimsThirdParty_1_idx",
                schema: "halo",
                table: "halomemberclaimsthirdparty",
                column: "HaloMemberClaimID");

            migrationBuilder.CreateIndex(
                name: "HaloDependantCellPhoneNumber_UNIQUE",
                schema: "halo",
                table: "halomemberdependants",
                column: "HaloDependantCellPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_HaloMemberDependants_1_idx",
                schema: "halo",
                table: "halomemberdependants",
                column: "HaloMemberID");

            migrationBuilder.CreateIndex(
                name: "HaloMemberFtpFilesID_UNIQUE",
                schema: "halo",
                table: "halomemberftpfiles",
                column: "HaloMemberFtpFilesID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_HaloMemberPhoneNumbers_1_idx",
                schema: "halo",
                table: "halomemberphonenumbers",
                column: "HaloMemberID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloMemberPrograms_1_idx",
                schema: "halo",
                table: "halomemberprograms",
                column: "HaloClientID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloMemberPrograms_2_idx",
                schema: "halo",
                table: "halomemberprograms",
                column: "HaloMemberID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloMemberPrograms_3_idx",
                schema: "halo",
                table: "halomemberprograms",
                column: "HaloProgramID");

            migrationBuilder.CreateIndex(
                name: "fk_HaloVehicleLicences_1_idx",
                schema: "halo",
                table: "halovehiclelicences",
                column: "HaloMemberID");

            migrationBuilder.CreateIndex(
                name: "notifications_id_uindex",
                schema: "halo",
                table: "notifications",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PolicyChangeRequests_id_uindex",
                schema: "halo",
                table: "policychangerequests",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "providers_provider_id_uindex",
                schema: "halo",
                table: "providers",
                column: "provider_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "province_id_UNIQUE",
                schema: "halo",
                table: "provinces",
                column: "province_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "provinces_list_id_UNIQUE",
                schema: "halo",
                table: "provinces_list",
                column: "provinces_list_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "region_id_UNIQUE",
                schema: "halo",
                table: "region",
                column: "region_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "region_list_id_UNIQUE",
                schema: "halo",
                table: "region_list",
                column: "region_list_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "service_catagories_list_id_UNIQUE",
                schema: "halo",
                table: "service_catagories_list",
                column: "service_catagories_list_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "service_catagorie_id_UNIQUE",
                schema: "halo",
                table: "service_categories",
                column: "service_catagorie_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "service_list_id_UNIQUE",
                schema: "halo",
                table: "service_list",
                column: "service_list_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "service_providers_audit_id_UNIQUE",
                schema: "halo",
                table: "service_providers_audit",
                column: "service_providers_audit_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "service_sub_catagorie_id_UNIQUE",
                schema: "halo",
                table: "service_sub_catagories",
                column: "service_sub_catagorie_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "service_sub_categories_list_id_UNIQUE",
                schema: "halo",
                table: "service_sub_categories_list",
                column: "service_sub_categories_list_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "service_id_UNIQUE",
                schema: "halo",
                table: "services",
                column: "service_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "suburb_id_UNIQUE",
                schema: "halo",
                table: "suburbs",
                column: "suburb_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "suburbs_list_id_UNIQUE",
                schema: "halo",
                table: "suburbs_list",
                column: "suburbs_list_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "token_id_uindex",
                schema: "halo",
                table: "token",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "users_email_uindex",
                schema: "halo",
                table: "users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "users_id_uindex",
                schema: "halo",
                table: "users",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "applicationdistributions",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "authtokens",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "callcentreaudittrail",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "callcentrechatmessages",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "callcentrefaqs",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "callcentrefirestations",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "callcentremodules",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "callcentrerolemodules",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "callcentreuserroles",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "callcentreusers",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "cartrack",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "cities",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "cities_list",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "client_tokens",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "cmsmodules",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "cmsrolemodules",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "cmsuserroles",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "cmsusers",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "communicationlog",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "contacts",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "country",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "country_list",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "edmunds_test",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halo_mobile_content_clients",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloaudittrail",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halobatchimported",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halobranches",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halochatmessages",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halochatrequests",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloclaims",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloclaimtypes",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloclientapiregister",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloclientbanners",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloclientmembers",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloclientpartners",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloclientprogramproducts",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloclientprograms",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloclientslogin",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halodictionary_en_za",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halodriverslicences",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloftpaudittrail",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloinappapplications",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloinappmessages",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloinappregistration",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomember_additional_client_data",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomemberclaimseyewitness",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomemberclaimsthirdparty",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomemberdependants",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomemberftpfiles",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomemberloaderror",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomembermessages",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomemberphonenumbers",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomemberprograms",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomembersstage",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomobileclientcontent",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomobilecontent",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halonetstar",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halopanics",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halopartners",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloproducts",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloreminders",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halosentsmss",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halositeconfig",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halovehiclelicences",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halovehiclemonitorintegration",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "notifications",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "policychangerequests",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "providers",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "provinces",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "provinces_list",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "reference_subset",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "referral_response",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "referrals",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "region",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "region_list",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "service_catagories_list",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "service_categories",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "service_list",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "service_providers_audit",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "service_sub_catagories",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "service_sub_categories_list",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "services",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "suburbs",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "suburbs_list",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "token",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "users",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "ussdtest",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "haloclients",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomemberclaims",
                schema: "halo");

            migrationBuilder.DropTable(
                name: "halomembers",
                schema: "halo");
        }
    }
}
