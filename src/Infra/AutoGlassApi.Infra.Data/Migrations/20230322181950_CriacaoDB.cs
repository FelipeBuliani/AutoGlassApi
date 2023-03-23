using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoGlassApi.Infra.Data.Migrations
{
    public partial class CriacaoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Situacao = table.Column<int>(type: "INTEGER", maxLength: 10, nullable: true),
                    DataFabricacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataValidade = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CodigoFornecedor = table.Column<int>(type: "INTEGER", nullable: true),
                    DescricaoFornecedor = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CnpjFornecedor = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Codigo);
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 1, "12.983.451/0001-01", 1, new DateTime(2023, 1, 29, 15, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2028, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "Vidro", "Fornecedor 1", 0 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 2, "12.983.451/0001-01", 1, new DateTime(2022, 11, 18, 9, 55, 18, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), "Retrovisor", "Fornecedor 1", 0 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 3, "12.983.451/0001-01", 1, new DateTime(2019, 10, 22, 8, 45, 23, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 22, 8, 45, 23, 0, DateTimeKind.Unspecified), "Pelicula", "Fornecedor 1", 1 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 4, "45.781.394/0001-02", 2, new DateTime(2022, 12, 13, 12, 42, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), "Lanterna", "Fornecedor 2", 0 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 5, "45.781.394/0001-02", 2, new DateTime(2023, 2, 22, 9, 15, 32, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 22, 9, 15, 32, 0, DateTimeKind.Unspecified), "Lampada", "Fornecedor 2", 0 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 6, "45.781.394/0001-02", 2, new DateTime(2021, 8, 7, 14, 24, 35, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 20, 14, 20, 0, 0, DateTimeKind.Unspecified), "Farol", "Fornecedor 2", 0 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 7, "45.781.394/0001-02", 2, new DateTime(2023, 1, 15, 9, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Higienizacao", "Fornecedor 2", 1 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 8, "55.425.738/0001-47", 3, new DateTime(2022, 7, 8, 18, 15, 17, 0, DateTimeKind.Unspecified), new DateTime(2032, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), "Para-choque", "Fornecedor 3", 0 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 9, "55.425.738/0001-47", 3, new DateTime(2023, 3, 2, 11, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Lataria", "Fornecedor 3", 1 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 10, "55.425.738/0001-47", 3, new DateTime(2022, 12, 31, 15, 32, 15, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 15, 32, 15, 0, DateTimeKind.Unspecified), "Suspensao", "Fornecedor 3", 0 });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Codigo", "CnpjFornecedor", "CodigoFornecedor", "DataFabricacao", "DataValidade", "Descricao", "DescricaoFornecedor", "Situacao" },
                values: new object[] { 11, "55.425.738/0001-47", 3, new DateTime(2021, 5, 30, 11, 40, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 11, 40, 45, 0, DateTimeKind.Unspecified), "Palheta", "Fornecedor 3", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_DataFabricacao",
                table: "Produto",
                column: "DataFabricacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
