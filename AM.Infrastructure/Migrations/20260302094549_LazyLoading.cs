using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LazyLoading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationTicket_Passengers_FkPassenger",
                table: "ReservationTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationTicket_Ticket_FkTicket",
                table: "ReservationTicket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationTicket",
                table: "ReservationTicket");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameTable(
                name: "ReservationTicket",
                newName: "ReservationTickets");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationTicket_FkTicket",
                table: "ReservationTickets",
                newName: "IX_ReservationTickets_FkTicket");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationTickets",
                table: "ReservationTickets",
                columns: new[] { "FkPassenger", "FkTicket", "DateReservation" });

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationTickets_Passengers_FkPassenger",
                table: "ReservationTickets",
                column: "FkPassenger",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationTickets_Tickets_FkTicket",
                table: "ReservationTickets",
                column: "FkTicket",
                principalTable: "Tickets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationTickets_Passengers_FkPassenger",
                table: "ReservationTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationTickets_Tickets_FkTicket",
                table: "ReservationTickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationTickets",
                table: "ReservationTickets");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameTable(
                name: "ReservationTickets",
                newName: "ReservationTicket");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationTickets_FkTicket",
                table: "ReservationTicket",
                newName: "IX_ReservationTicket_FkTicket");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationTicket",
                table: "ReservationTicket",
                columns: new[] { "FkPassenger", "FkTicket", "DateReservation" });

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationTicket_Passengers_FkPassenger",
                table: "ReservationTicket",
                column: "FkPassenger",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationTicket_Ticket_FkTicket",
                table: "ReservationTicket",
                column: "FkTicket",
                principalTable: "Ticket",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
