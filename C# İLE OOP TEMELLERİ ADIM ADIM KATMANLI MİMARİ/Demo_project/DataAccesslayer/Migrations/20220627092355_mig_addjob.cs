using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesslayer.Migrations
{
    public partial class mig_addjob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobID",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_JobID",
                table: "Customers",
                column: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Jobs_JobID",
                table: "Customers",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Jobs_JobID",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Customers_JobID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "JobID",
                table: "Customers");
        }
    }
}
