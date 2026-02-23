using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FluentApiCofig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassengers_Flights_FlightId",
                table: "FlightPassengers");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassengers_Passengers_PassengerId",
                table: "FlightPassengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassengers",
                table: "FlightPassengers");

            migrationBuilder.RenameTable(
                name: "FlightPassengers",
                newName: "Reservation");

            migrationBuilder.RenameColumn(
                name: "PassengerId",
                table: "Reservation",
                newName: "PassengersPassportNumber");

            migrationBuilder.RenameColumn(
                name: "FlightId",
                table: "Reservation",
                newName: "FlightsFlightId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassengers_PassengerId",
                table: "Reservation",
                newName: "IX_Reservation_PassengersPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                columns: new[] { "FlightsFlightId", "PassengersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Flights_FlightsFlightId",
                table: "Reservation",
                column: "FlightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Passengers_PassengersPassportNumber",
                table: "Reservation",
                column: "PassengersPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Flights_FlightsFlightId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Passengers_PassengersPassportNumber",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "FlightPassengers");

            migrationBuilder.RenameColumn(
                name: "PassengersPassportNumber",
                table: "FlightPassengers",
                newName: "PassengerId");

            migrationBuilder.RenameColumn(
                name: "FlightsFlightId",
                table: "FlightPassengers",
                newName: "FlightId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_PassengersPassportNumber",
                table: "FlightPassengers",
                newName: "IX_FlightPassengers_PassengerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassengers",
                table: "FlightPassengers",
                columns: new[] { "FlightId", "PassengerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassengers_Flights_FlightId",
                table: "FlightPassengers",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassengers_Passengers_PassengerId",
                table: "FlightPassengers",
                column: "PassengerId",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
