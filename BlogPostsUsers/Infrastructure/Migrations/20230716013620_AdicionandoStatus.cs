using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPostsUsers.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatusPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    success = table.Column<bool>(type: "bit", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    offset = table.Column<int>(type: "int", nullable: false),
                    limit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    success = table.Column<bool>(type: "bit", nullable: false),
                    time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    total_users = table.Column<int>(type: "int", nullable: false),
                    offset = table.Column<int>(type: "int", nullable: false),
                    limit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusUsers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatusPosts");

            migrationBuilder.DropTable(
                name: "StatusUsers");
        }
    }
}
