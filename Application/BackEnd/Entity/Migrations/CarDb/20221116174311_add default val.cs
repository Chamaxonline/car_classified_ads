using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations.CarDb
{
    public partial class adddefaultval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManualOrderNumber",
                table: "VehicleCompany",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManualOrderNumber",
                table: "VehicleCompany");
        }
    }
}
