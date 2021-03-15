using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddedFistsnameAndSurname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("95e0db96-d2e6-442d-9aa3-8fe562f90591"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("a6e42631-cd43-4a72-bf8c-6814a688b44f"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("b5900a21-7fb6-4d13-81a3-54a5b8b9f301"));

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: new Guid("52650028-ce5a-4a6f-afda-ecb24653b1e9"));

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: new Guid("e60ecff6-5b33-4b45-967c-9aa60817601c"));

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("ba786960-44e6-469b-932f-5865dc1cc633"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Tennis" });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("4acfb92f-7c21-47de-8a4e-32f476e9bcfc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Squash" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedDate", "Firstname", "LastModifiedBy", "LastModifiedDate", "ParticipantEmail", "SportId", "Surname" },
                values: new object[] { new Guid("2821fb8c-c892-47f0-ae73-a9c2b72f01d0"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, "johndoe@email.com", new Guid("ba786960-44e6-469b-932f-5865dc1cc633"), "" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedDate", "Firstname", "LastModifiedBy", "LastModifiedDate", "ParticipantEmail", "SportId", "Surname" },
                values: new object[] { new Guid("551f2886-16cd-4b50-9d8b-8b47f2758984"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, "someoneelse@email.com", new Guid("ba786960-44e6-469b-932f-5865dc1cc633"), "" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedDate", "Firstname", "LastModifiedBy", "LastModifiedDate", "ParticipantEmail", "SportId", "Surname" },
                values: new object[] { new Guid("8ed7de7e-e9bc-4c9f-bbcb-a75a0dde59af"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, null, "johndoe@email.com", new Guid("4acfb92f-7c21-47de-8a4e-32f476e9bcfc"), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("2821fb8c-c892-47f0-ae73-a9c2b72f01d0"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("551f2886-16cd-4b50-9d8b-8b47f2758984"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("8ed7de7e-e9bc-4c9f-bbcb-a75a0dde59af"));

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: new Guid("4acfb92f-7c21-47de-8a4e-32f476e9bcfc"));

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: new Guid("ba786960-44e6-469b-932f-5865dc1cc633"));

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Participants");

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
        }
    }
}
