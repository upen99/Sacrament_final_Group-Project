using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sacrament_final.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sacrament",
                columns: table => new
                {
                    SacramentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    SpeakerTopic = table.Column<string>(nullable: false),
                    ConductingLeader = table.Column<string>(nullable: false),
                    OpenignSong = table.Column<string>(nullable: false),
                    OpeningPrayer = table.Column<string>(nullable: false),
                    Speaker = table.Column<string>(nullable: false),
                    SpeakerTwo = table.Column<string>(nullable: true),
                    SpeakerThree = table.Column<string>(nullable: true),
                    IntermediateHymn = table.Column<string>(nullable: false),
                    ClosingPrayer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sacrament", x => x.SacramentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sacrament");
        }
    }
}
