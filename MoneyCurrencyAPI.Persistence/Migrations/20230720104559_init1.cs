using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoneyCurrencyAPI.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForexBuying = table.Column<double>(type: "float", nullable: false),
                    ForexSelling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BanknoteBuying = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BanknoteSelling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrossRateUSD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrossRateOther = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrossOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BultenNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
