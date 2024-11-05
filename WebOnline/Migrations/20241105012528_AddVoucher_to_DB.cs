using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOnline.Migrations
{
    /// <inheritdoc />
    public partial class AddVoucher_to_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_tb_TaiKhoan_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_tb_VaiTro_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_DonHang_tb_TaiKhoan_UserId",
                table: "tb_DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_RoleClaims_tb_VaiTro_RoleId",
                table: "tb_RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_UserClaims_tb_TaiKhoan_UserId",
                table: "tb_UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_UserLogins_tb_TaiKhoan_UserId",
                table: "tb_UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_UserTokens_tb_TaiKhoan_UserId",
                table: "tb_UserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_tb.GioHang_tb_TaiKhoan_UserID",
                table: "tb.GioHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_VaiTro",
                table: "tb_VaiTro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_UserTokens",
                table: "tb_UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_UserLogins",
                table: "tb_UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_UserClaims",
                table: "tb_UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_TaiKhoan",
                table: "tb_TaiKhoan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_RoleClaims",
                table: "tb_RoleClaims");

            migrationBuilder.RenameTable(
                name: "tb_VaiTro",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "tb_UserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "tb_UserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "tb_UserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "tb_TaiKhoan",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "tb_RoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_tb_UserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_UserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_RoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tb_Voucher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Voucher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orderVoucher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    VoucherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderVoucher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orderVoucher_tb_DonHang_OrderId",
                        column: x => x.OrderId,
                        principalTable: "tb_DonHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderVoucher_tb_Voucher_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "tb_Voucher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productVoucher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    VoucherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productVoucher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productVoucher_tb_SanPham_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tb_SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productVoucher_tb_Voucher_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "tb_Voucher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userVoucher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VoucherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userVoucher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userVoucher_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userVoucher_tb_Voucher_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "tb_Voucher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orderVoucher_OrderId",
                table: "orderVoucher",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_orderVoucher_VoucherId",
                table: "orderVoucher",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_productVoucher_ProductId",
                table: "productVoucher",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_productVoucher_VoucherId",
                table: "productVoucher",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_userVoucher_UserId1",
                table: "userVoucher",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_userVoucher_VoucherId",
                table: "userVoucher",
                column: "VoucherId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_DonHang_AspNetUsers_UserId",
                table: "tb_DonHang",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb.GioHang_AspNetUsers_UserID",
                table: "tb.GioHang",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_DonHang_AspNetUsers_UserId",
                table: "tb_DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_tb.GioHang_AspNetUsers_UserID",
                table: "tb.GioHang");

            migrationBuilder.DropTable(
                name: "orderVoucher");

            migrationBuilder.DropTable(
                name: "productVoucher");

            migrationBuilder.DropTable(
                name: "userVoucher");

            migrationBuilder.DropTable(
                name: "tb_Voucher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "tb_UserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "tb_TaiKhoan");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "tb_UserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "tb_UserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "tb_VaiTro");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "tb_RoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "tb_UserLogins",
                newName: "IX_tb_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "tb_UserClaims",
                newName: "IX_tb_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "tb_RoleClaims",
                newName: "IX_tb_RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_UserTokens",
                table: "tb_UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_TaiKhoan",
                table: "tb_TaiKhoan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_UserLogins",
                table: "tb_UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_UserClaims",
                table: "tb_UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_VaiTro",
                table: "tb_VaiTro",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_RoleClaims",
                table: "tb_RoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_tb_TaiKhoan_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "tb_TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_tb_VaiTro_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "tb_VaiTro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_DonHang_tb_TaiKhoan_UserId",
                table: "tb_DonHang",
                column: "UserId",
                principalTable: "tb_TaiKhoan",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_RoleClaims_tb_VaiTro_RoleId",
                table: "tb_RoleClaims",
                column: "RoleId",
                principalTable: "tb_VaiTro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_UserClaims_tb_TaiKhoan_UserId",
                table: "tb_UserClaims",
                column: "UserId",
                principalTable: "tb_TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_UserLogins_tb_TaiKhoan_UserId",
                table: "tb_UserLogins",
                column: "UserId",
                principalTable: "tb_TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_UserTokens_tb_TaiKhoan_UserId",
                table: "tb_UserTokens",
                column: "UserId",
                principalTable: "tb_TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb.GioHang_tb_TaiKhoan_UserID",
                table: "tb.GioHang",
                column: "UserID",
                principalTable: "tb_TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
