using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_writer_blog_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Comments",
                newName: "BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                newName: "IX_Comments_BlogID");

            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_WriterID",
                table: "Blogs",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writers_WriterID",
                table: "Blogs",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writers_WriterID",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_WriterID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "Comments",
                newName: "BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_BlogID",
                table: "Comments",
                newName: "IX_Comments_BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
