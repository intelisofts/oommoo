using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oommoo.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        // /// <inheritdoc />
        // protected override void Up(MigrationBuilder migrationBuilder)
        // {
        //     migrationBuilder.AlterDatabase()
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "activity",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             user_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             request = table.Column<string>(type: "longtext", nullable: false),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "contact",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             entity_type = table.Column<string>(type: "enum('USER','PRODUCTION_COMPANY','VENUE','SHOW','EVENT')", nullable: false),
        //             entity_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             primary = table.Column<bool>(type: "tinyint(1)", nullable: true),
        //             phone = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             phone2 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             address = table.Column<string>(type: "text", nullable: true),
        //             address2 = table.Column<string>(type: "text", nullable: true),
        //             state = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             city = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             country = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             postal_code = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "event",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             name = table.Column<string>(type: "text", nullable: false),
        //             description = table.Column<string>(type: "text", nullable: true),
        //             type = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             start_date = table.Column<DateTime>(type: "datetime", nullable: true),
        //             end_date = table.Column<DateTime>(type: "datetime", nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             display_image_url = table.Column<string>(type: "text", nullable: true),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "file",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             entity_type = table.Column<string>(type: "enum('USER','PRODUCTION_COMPANY','VENUE','SHOW','EVENT','REVIEW','WATCHLIST','WATCHLIST_ITEM')", nullable: false),
        //             entity_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             filename = table.Column<string>(type: "text", nullable: false),
        //             filetype = table.Column<string>(type: "text", nullable: false),
        //             url = table.Column<string>(type: "text", nullable: false),
        //             path = table.Column<string>(type: "text", nullable: false),
        //             size = table.Column<double>(type: "double", nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             type = table.Column<string>(type: "text", nullable: true),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: true)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "like",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             entity_type = table.Column<string>(type: "enum('USER','PRODUCTION_COMPANY','PRODUCTION_COMPANY_USER','VENUE','SHOW','EVENT','REVIEW','WATCHLIST')", nullable: false),
        //             entity_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             value = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "production_company",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             name = table.Column<string>(type: "text", nullable: false),
        //             description = table.Column<string>(type: "text", nullable: true),
        //             founded = table.Column<DateTime>(type: "datetime", nullable: true),
        //             type = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             display_image_url = table.Column<string>(type: "text", nullable: true),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "production_company_user",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             user_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             production_company_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             role = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "rating",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             user_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             show_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             venue_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             event_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             review_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             type = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
        //             value = table.Column<int>(type: "int", nullable: false),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             held = table.Column<bool>(type: "tinyint(1)", nullable: true),
        //             show_user_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             venue_show_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "review",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             user_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             show_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             venue_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             event_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             type = table.Column<string>(type: "enum('AUDIENCE','CRITIC')", nullable: true),
        //             review = table.Column<string>(type: "longtext", nullable: false),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             display_image_url = table.Column<string>(type: "text", nullable: true),
        //             held = table.Column<bool>(type: "tinyint(1)", nullable: true),
        //             show_user_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             venue_show_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "show",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
        //             description = table.Column<string>(type: "text", nullable: true),
        //             production_company_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             age_recommendation = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             duration = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             start_date = table.Column<DateTime>(type: "datetime", nullable: true),
        //             end_date = table.Column<DateTime>(type: "datetime", nullable: true),
        //             type = table.Column<string>(type: "enum('THEATRE','DANCE','PERFORMANCE_ART','MUSIC')", nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             display_image_url = table.Column<string>(type: "text", nullable: true),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false),
        //             average_rating = table.Column<float>(type: "float", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "show_user",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             show_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             user_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             attendance_type = table.Column<string>(type: "enum('VENUE','PRODUCTION','CAST','CREW','CRITIC','AUDIENCE')", nullable: false),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             venue_show_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "tag",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             entity_type = table.Column<string>(type: "enum('USER','PRODUCTION_COMPANY','PRODUCTION_COMPANY_USER','VENUE','SHOW','EVENT','REVIEW','WATCHLIST')", nullable: false),
        //             entity_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             tag = table.Column<string>(type: "text", nullable: false),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "user",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             username = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
        //             first_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
        //             last_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
        //             middle_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             full_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             type = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             subtype = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             dob = table.Column<DateTime>(type: "datetime", nullable: false),
        //             gender = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
        //             age = table.Column<int>(type: "int", nullable: false),
        //             password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
        //             system_id = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             notes = table.Column<string>(type: "text", nullable: true),
        //             role = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             logged_in = table.Column<bool>(type: "tinyint(1)", nullable: true),
        //             verified = table.Column<bool>(type: "tinyint(1)", nullable: true),
        //             verification_code = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             verification_type = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             reset_code = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             email = table.Column<string>(type: "varchar(255)", nullable: false),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             display_image_url = table.Column<string>(type: "text", nullable: true),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "user_permission",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             name = table.Column<string>(type: "enum('ADD_SHOW','EDIT_SHOW','ADD_USER','EDIT_USER','ADD_VENUE','EDIT_VENUE','ADD_REVIEW','EDIT_REVIEW','ADD_RATING','EDIT_RATING','ADD_EVENT','EDIT_EVENT','ADD_PRODUCTION_COMPANY','EDIT_PRODUCTION_COMPANY')", nullable: false),
        //             user_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             entity_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "venue",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             name = table.Column<string>(type: "text", nullable: false),
        //             description = table.Column<string>(type: "text", nullable: true),
        //             type = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             accessibility = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             display_image_url = table.Column<string>(type: "text", nullable: true),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "venue_event",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             venue_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             event_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             show_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             active = table.Column<bool>(type: "tinyint(1)", nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             type = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             name = table.Column<string>(type: "text", nullable: true),
        //             description = table.Column<string>(type: "text", nullable: true)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "venue_show",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             show_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             venue_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             type = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             date = table.Column<DateTime>(type: "datetime", nullable: false),
        //             active = table.Column<bool>(type: "tinyint(1)", nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             start_time = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
        //             end_time = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             name = table.Column<string>(type: "text", nullable: true),
        //             description = table.Column<string>(type: "text", nullable: true),
        //             event_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             venue_event_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "venue_user",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             user_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             venue_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             role = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             type = table.Column<string>(type: "text", nullable: true)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "watchlist",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             user_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             name = table.Column<string>(type: "text", nullable: false),
        //             description = table.Column<string>(type: "text", nullable: true),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             display_image_url = table.Column<string>(type: "text", nullable: true),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateTable(
        //         name: "watchlist_item",
        //         columns: table => new
        //         {
        //             id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             watchlist_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             show_id = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             position = table.Column<int>(type: "int", nullable: false),
        //             create_time = table.Column<DateTime>(type: "datetime", nullable: false),
        //             update_time = table.Column<DateTime>(type: "datetime", nullable: true),
        //             created_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
        //             updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
        //             is_deleted = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
        //             @private = table.Column<bool>(name: "private", type: "tinyint(1)", nullable: false)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PRIMARY", x => x.id);
        //         })
        //         .Annotation("MySQL:Charset", "utf8mb4");
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE",
        //         table: "activity",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE1",
        //         table: "contact",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE2",
        //         table: "event",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE3",
        //         table: "file",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE4",
        //         table: "like",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE5",
        //         table: "production_company",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE6",
        //         table: "production_company_user",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE7",
        //         table: "rating",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE8",
        //         table: "review",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE9",
        //         table: "show",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE10",
        //         table: "show_user",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE11",
        //         table: "tag",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "email",
        //         table: "user",
        //         column: "email",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE12",
        //         table: "user",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE13",
        //         table: "user_permission",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE14",
        //         table: "venue",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE15",
        //         table: "venue_event",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE16",
        //         table: "venue_show",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE17",
        //         table: "venue_user",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE18",
        //         table: "watchlist",
        //         column: "id",
        //         unique: true);
        //
        //     migrationBuilder.CreateIndex(
        //         name: "id_UNIQUE19",
        //         table: "watchlist_item",
        //         column: "id",
        //         unique: true);
        // }
        //
        // /// <inheritdoc />
        // protected override void Down(MigrationBuilder migrationBuilder)
        // {
        //     migrationBuilder.DropTable(
        //         name: "activity");
        //
        //     migrationBuilder.DropTable(
        //         name: "contact");
        //
        //     migrationBuilder.DropTable(
        //         name: "event");
        //
        //     migrationBuilder.DropTable(
        //         name: "file");
        //
        //     migrationBuilder.DropTable(
        //         name: "like");
        //
        //     migrationBuilder.DropTable(
        //         name: "production_company");
        //
        //     migrationBuilder.DropTable(
        //         name: "production_company_user");
        //
        //     migrationBuilder.DropTable(
        //         name: "rating");
        //
        //     migrationBuilder.DropTable(
        //         name: "review");
        //
        //     migrationBuilder.DropTable(
        //         name: "show");
        //
        //     migrationBuilder.DropTable(
        //         name: "show_user");
        //
        //     migrationBuilder.DropTable(
        //         name: "tag");
        //
        //     migrationBuilder.DropTable(
        //         name: "user");
        //
        //     migrationBuilder.DropTable(
        //         name: "user_permission");
        //
        //     migrationBuilder.DropTable(
        //         name: "venue");
        //
        //     migrationBuilder.DropTable(
        //         name: "venue_event");
        //
        //     migrationBuilder.DropTable(
        //         name: "venue_show");
        //
        //     migrationBuilder.DropTable(
        //         name: "venue_user");
        //
        //     migrationBuilder.DropTable(
        //         name: "watchlist");
        //
        //     migrationBuilder.DropTable(
        //         name: "watchlist_item");
        // }


        protected override void Up(MigrationBuilder migrationBuilder){}

        protected override void Down(MigrationBuilder migrationBuilder){}
    }
}
