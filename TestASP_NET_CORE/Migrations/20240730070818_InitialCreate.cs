using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestASP_NET_CORE.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    _taskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _isDone = table.Column<bool>(type: "bit", nullable: false),
                    _userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x._taskId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
