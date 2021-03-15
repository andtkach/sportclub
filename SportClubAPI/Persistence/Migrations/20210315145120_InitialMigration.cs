using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParticipantEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("e60ecff6-5b33-4b45-967c-9aa60817601c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Tennis" });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("52650028-ce5a-4a6f-afda-ecb24653b1e9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Squash" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "ParticipantEmail", "SportId" },
                values: new object[] { new Guid("b5900a21-7fb6-4d13-81a3-54a5b8b9f301"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "johndoe@email.com", new Guid("e60ecff6-5b33-4b45-967c-9aa60817601c") });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "ParticipantEmail", "SportId" },
                values: new object[] { new Guid("95e0db96-d2e6-442d-9aa3-8fe562f90591"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "someoneelse@email.com", new Guid("e60ecff6-5b33-4b45-967c-9aa60817601c") });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "ParticipantEmail", "SportId" },
                values: new object[] { new Guid("a6e42631-cd43-4a72-bf8c-6814a688b44f"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "johndoe@email.com", new Guid("52650028-ce5a-4a6f-afda-ecb24653b1e9") });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_SportId",
                table: "Participants",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
