using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbAppEcommerce.Migrations
{
    public partial class InicialCriandoBancoETabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.IdEndereco);
                });

            migrationBuilder.CreateTable(
                name: "tb_Produto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Produto", x => x.IdProduto);
                });

            migrationBuilder.CreateTable(
                name: "tb_Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoIdEndereco = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cliente", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_tb_Cliente_tb_Endereco_EnderecoIdEndereco",
                        column: x => x.EnderecoIdEndereco,
                        principalTable: "tb_Endereco",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_ItemPedido",
                columns: table => new
                {
                    IdItemPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecoUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    ProdutoIdProduto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ItemPedido", x => x.IdItemPedido);
                    table.ForeignKey(
                        name: "FK_tb_ItemPedido_tb_Produto_ProdutoIdProduto",
                        column: x => x.ProdutoIdProduto,
                        principalTable: "tb_Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pedido",
                columns: table => new
                {
                    IdPEdido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteIdCliente = table.Column<int>(type: "int", nullable: true),
                    ItemPedidoIdItemPedido = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pedido", x => x.IdPEdido);
                    table.ForeignKey(
                        name: "FK_tb_Pedido_tb_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "tb_Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_Pedido_tb_ItemPedido_ItemPedidoIdItemPedido",
                        column: x => x.ItemPedidoIdItemPedido,
                        principalTable: "tb_ItemPedido",
                        principalColumn: "IdItemPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Cliente_EnderecoIdEndereco",
                table: "tb_Cliente",
                column: "EnderecoIdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_tb_ItemPedido_ProdutoIdProduto",
                table: "tb_ItemPedido",
                column: "ProdutoIdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pedido_ClienteIdCliente",
                table: "tb_Pedido",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pedido_ItemPedidoIdItemPedido",
                table: "tb_Pedido",
                column: "ItemPedidoIdItemPedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Pedido");

            migrationBuilder.DropTable(
                name: "tb_Cliente");

            migrationBuilder.DropTable(
                name: "tb_ItemPedido");

            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Produto");
        }
    }
}
