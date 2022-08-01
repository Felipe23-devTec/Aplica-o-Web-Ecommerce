using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbAppEcommerce.Migrations
{
    public partial class mudandoIntegridaderelacionalPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Pedido_tb_ItemPedido_ItemPedidoIdItemPedido",
                table: "tb_Pedido");

            migrationBuilder.DropIndex(
                name: "IX_tb_Pedido_ItemPedidoIdItemPedido",
                table: "tb_Pedido");

            migrationBuilder.DropColumn(
                name: "ItemPedidoIdItemPedido",
                table: "tb_Pedido");

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPEdido",
                table: "tb_ItemPedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_ItemPedido_PedidoIdPEdido",
                table: "tb_ItemPedido",
                column: "PedidoIdPEdido");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_ItemPedido_tb_Pedido_PedidoIdPEdido",
                table: "tb_ItemPedido",
                column: "PedidoIdPEdido",
                principalTable: "tb_Pedido",
                principalColumn: "IdPEdido",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_ItemPedido_tb_Pedido_PedidoIdPEdido",
                table: "tb_ItemPedido");

            migrationBuilder.DropIndex(
                name: "IX_tb_ItemPedido_PedidoIdPEdido",
                table: "tb_ItemPedido");

            migrationBuilder.DropColumn(
                name: "PedidoIdPEdido",
                table: "tb_ItemPedido");

            migrationBuilder.AddColumn<int>(
                name: "ItemPedidoIdItemPedido",
                table: "tb_Pedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pedido_ItemPedidoIdItemPedido",
                table: "tb_Pedido",
                column: "ItemPedidoIdItemPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Pedido_tb_ItemPedido_ItemPedidoIdItemPedido",
                table: "tb_Pedido",
                column: "ItemPedidoIdItemPedido",
                principalTable: "tb_ItemPedido",
                principalColumn: "IdItemPedido",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
