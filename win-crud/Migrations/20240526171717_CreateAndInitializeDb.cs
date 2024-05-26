using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace win_crud.Migrations
{
    public partial class CreateAndInitializeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Age = table.Column<short>(type: "smallint", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CelPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "CPF", "CelPhone", "CreatedAt", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, (short)30, "123.456.789-01", "11984763130", new DateTime(2024, 5, 26, 14, 17, 17, 570, DateTimeKind.Local).AddTicks(9183), "joao.silva@example.com", "João", "Silva", "1156794477" },
                    { 2, (short)25, "987.654.321-02", "11987537480", new DateTime(2024, 5, 26, 14, 17, 17, 570, DateTimeKind.Local).AddTicks(9185), "maria.santos@example.com", "Maria", "Santos", "1156794477" },
                    { 3, (short)40, "111.222.333-03", "11984933130", new DateTime(2024, 5, 26, 14, 17, 17, 570, DateTimeKind.Local).AddTicks(9205), "pedro.oliveira@example.com", "Pedro", "Oliveira", "1156794477" },
                    { 4, (short)35, "444.555.666-04", "11987558130", new DateTime(2024, 5, 26, 14, 17, 17, 570, DateTimeKind.Local).AddTicks(9206), "ana.pereira@example.com", "Ana", "Pereira", "1156794477" },
                    { 5, (short)28, "777.888.999-05", "11946833130", new DateTime(2024, 5, 26, 14, 17, 17, 570, DateTimeKind.Local).AddTicks(9207), "carlos.souza@example.com", "Carlos", "Souza", "1156794477" }
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "CreatedAt", "Number", "PersonId", "State", "Street", "UF", "ZipCode" },
                values: new object[,]
                {
                    { 1, "São Paulo", "Brasil", new DateTime(2024, 5, 26, 14, 17, 17, 570, DateTimeKind.Local).AddTicks(9285), "123", 1, "São Paulo", "Rua A", "SP", "01010-010" },
                    { 2, "Rio de Janeiro", "Brasil", new DateTime(2024, 5, 26, 14, 17, 17, 570, DateTimeKind.Local).AddTicks(9287), "456", 2, "Rio de Janeiro", "Rua B", "RJ", "02020-020" },
                    { 3, "Belo Horizonte", "Brasil", new DateTime(2024, 5, 26, 14, 17, 17, 570, DateTimeKind.Local).AddTicks(9288), "789", 3, " Minas Gerais", "Rua C", "MG", "03030-030" },
                    { 4, "Curitiba", "Brasil", new DateTime(2024, 5, 26, 14, 17, 17, 570, DateTimeKind.Local).AddTicks(9290), "1011", 4, "Paraná", "Rua D", "PR", "04040-040" },
                    { 5, "Porto Alegre", "Brasil", new DateTime(2024, 5, 26, 14, 17, 17, 570, DateTimeKind.Local).AddTicks(9291), "1213", 5, "Rio Grande do Sul", "Rua E", "RS", "05050-050" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                table: "Address",
                column: "PersonId",
                unique: true,
                filter: "[PersonId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
