using Microsoft.EntityFrameworkCore.Migrations;

namespace RelationShip2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "BookPage",
                table: "Pages",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Pages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_BookId",
                table: "Votes",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_BookId",
                table: "Pages",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Books_BookId",
                table: "Pages",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Books_BookId",
                table: "Votes",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Books_BookId",
                table: "Pages");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Books_BookId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_BookId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Pages_BookId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BookPage",
                table: "Pages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
