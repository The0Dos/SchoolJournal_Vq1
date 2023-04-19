using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolJournalDesktop.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicYears",
                columns: table => new
                {
                    IdAcademicYear = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicYears", x => x.IdAcademicYear);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    IdSchool = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.IdSchool);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudent);
                });

            migrationBuilder.CreateTable(
                name: "StudingClasses",
                columns: table => new
                {
                    IdStudingClass = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParallelIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudingClasses", x => x.IdStudingClass);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    IdSubject = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.IdSubject);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCards",
                columns: table => new
                {
                    IdTeacherCard = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCards", x => x.IdTeacherCard);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCategories",
                columns: table => new
                {
                    IdTeacherCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCategories", x => x.IdTeacherCategory);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Users_Roles_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleEducationProcesses",
                columns: table => new
                {
                    IdScheduleEducationProcess = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSchool = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleEducationProcesses", x => x.IdScheduleEducationProcess);
                    table.ForeignKey(
                        name: "FK_ScheduleEducationProcesses_Schools_IdSchool",
                        column: x => x.IdSchool,
                        principalTable: "Schools",
                        principalColumn: "IdSchool",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherPositions",
                columns: table => new
                {
                    IdTeacherPosition = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeginWorking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OccupiedRate = table.Column<double>(type: "float", nullable: false),
                    IdTeacherCard = table.Column<int>(type: "int", nullable: false),
                    IdTeacherCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherPositions", x => x.IdTeacherPosition);
                    table.ForeignKey(
                        name: "FK_TeacherPositions_TeacherCards_IdTeacherCard",
                        column: x => x.IdTeacherCard,
                        principalTable: "TeacherCards",
                        principalColumn: "IdTeacherCard",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherPositions_TeacherCategories_IdTeacherCategory",
                        column: x => x.IdTeacherCategory,
                        principalTable: "TeacherCategories",
                        principalColumn: "IdTeacherCategory",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegisterJournals",
                columns: table => new
                {
                    IdRegisterJournal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdScheduleEducationProcess = table.Column<int>(type: "int", nullable: false),
                    IdSubject = table.Column<int>(type: "int", nullable: false),
                    IdTeacherCard = table.Column<int>(type: "int", nullable: false),
                    IdAcademicYear = table.Column<int>(type: "int", nullable: false),
                    IdStudingClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterJournals", x => x.IdRegisterJournal);
                    table.ForeignKey(
                        name: "FK_RegisterJournals_AcademicYears_IdAcademicYear",
                        column: x => x.IdAcademicYear,
                        principalTable: "AcademicYears",
                        principalColumn: "IdAcademicYear",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterJournals_ScheduleEducationProcesses_IdScheduleEducationProcess",
                        column: x => x.IdScheduleEducationProcess,
                        principalTable: "ScheduleEducationProcesses",
                        principalColumn: "IdScheduleEducationProcess",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterJournals_StudingClasses_IdStudingClass",
                        column: x => x.IdStudingClass,
                        principalTable: "StudingClasses",
                        principalColumn: "IdStudingClass",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterJournals_Subjects_IdSubject",
                        column: x => x.IdSubject,
                        principalTable: "Subjects",
                        principalColumn: "IdSubject",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterJournals_TeacherCards_IdTeacherCard",
                        column: x => x.IdTeacherCard,
                        principalTable: "TeacherCards",
                        principalColumn: "IdTeacherCard",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DateJournalRecord",
                columns: table => new
                {
                    IdDateJournalRecord = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRecord = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdRegisterJournal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateJournalRecord", x => x.IdDateJournalRecord);
                    table.ForeignKey(
                        name: "FK_DateJournalRecord_RegisterJournals_IdRegisterJournal",
                        column: x => x.IdRegisterJournal,
                        principalTable: "RegisterJournals",
                        principalColumn: "IdRegisterJournal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    IdGrade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeNum = table.Column<int>(type: "int", nullable: false),
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    IdDateJournalRecord = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.IdGrade);
                    table.ForeignKey(
                        name: "FK_Grades_DateJournalRecord_IdDateJournalRecord",
                        column: x => x.IdDateJournalRecord,
                        principalTable: "DateJournalRecord",
                        principalColumn: "IdDateJournalRecord",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Students_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DateJournalRecord_IdRegisterJournal",
                table: "DateJournalRecord",
                column: "IdRegisterJournal");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_IdDateJournalRecord",
                table: "Grades",
                column: "IdDateJournalRecord");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_IdStudent",
                table: "Grades",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterJournals_IdAcademicYear",
                table: "RegisterJournals",
                column: "IdAcademicYear");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterJournals_IdScheduleEducationProcess",
                table: "RegisterJournals",
                column: "IdScheduleEducationProcess");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterJournals_IdStudingClass",
                table: "RegisterJournals",
                column: "IdStudingClass");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterJournals_IdSubject",
                table: "RegisterJournals",
                column: "IdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterJournals_IdTeacherCard",
                table: "RegisterJournals",
                column: "IdTeacherCard");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleEducationProcesses_IdSchool",
                table: "ScheduleEducationProcesses",
                column: "IdSchool");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherPositions_IdTeacherCard",
                table: "TeacherPositions",
                column: "IdTeacherCard");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherPositions_IdTeacherCategory",
                table: "TeacherPositions",
                column: "IdTeacherCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdRole",
                table: "Users",
                column: "IdRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "TeacherPositions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DateJournalRecord");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TeacherCategories");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "RegisterJournals");

            migrationBuilder.DropTable(
                name: "AcademicYears");

            migrationBuilder.DropTable(
                name: "ScheduleEducationProcesses");

            migrationBuilder.DropTable(
                name: "StudingClasses");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "TeacherCards");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
