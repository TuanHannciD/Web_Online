using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOnline.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_CaiDatHeThong",
                columns: table => new
                {
                    SettingKey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SettingValue = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_CaiDatHeThong", x => x.SettingKey);
                });

            migrationBuilder.CreateTable(
                name: "tb_DanhMuc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Positon = table.Column<int>(type: "int", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeyWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DanhMuc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_DanhMucSaPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeyWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DanhMucSaPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_DatHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalArmout = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DatHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_HinhAnhSanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_HinhAnhSanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_LienHe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsReal = table.Column<bool>(type: "bit", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_LienHe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_QuangCao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_QuangCao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_BaiViet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeyWords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryssId = table.Column<int>(type: "int", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_BaiViet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tb_BaiViet_tb_DanhMuc_CategoryssId",
                        column: x => x.CategoryssId,
                        principalTable: "tb_DanhMuc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_TinTuc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeyWords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategorysId = table.Column<int>(type: "int", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_TinTuc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tb_TinTuc_tb_DanhMuc_CategorysId",
                        column: x => x.CategorysId,
                        principalTable: "tb_DanhMuc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_SanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceSale = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsHome = table.Column<bool>(type: "bit", nullable: false),
                    IsSale = table.Column<bool>(type: "bit", nullable: false),
                    IsFeature = table.Column<bool>(type: "bit", nullable: false),
                    IsHot = table.Column<bool>(type: "bit", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeyWords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategorysId = table.Column<int>(type: "int", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_SanPham_tb_DanhMucSaPham_ProductCategorysId",
                        column: x => x.ProductCategorysId,
                        principalTable: "tb_DanhMucSaPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_ChiTietDatHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrdersID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OdersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ChiTietDatHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_ChiTietDatHang_tb_DatHang_OdersId",
                        column: x => x.OdersId,
                        principalTable: "tb_DatHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_ChiTietDatHang_tb_SanPham_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "tb_SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_BaiViet_CategoryssId",
                table: "tb_BaiViet",
                column: "CategoryssId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_ChiTietDatHang_OdersId",
                table: "tb_ChiTietDatHang",
                column: "OdersId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_ChiTietDatHang_ProductsId",
                table: "tb_ChiTietDatHang",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_SanPham_ProductCategorysId",
                table: "tb_SanPham",
                column: "ProductCategorysId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_TinTuc_CategorysId",
                table: "tb_TinTuc",
                column: "CategorysId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_BaiViet");

            migrationBuilder.DropTable(
                name: "tb_CaiDatHeThong");

            migrationBuilder.DropTable(
                name: "tb_ChiTietDatHang");

            migrationBuilder.DropTable(
                name: "tb_HinhAnhSanPham");

            migrationBuilder.DropTable(
                name: "tb_LienHe");

            migrationBuilder.DropTable(
                name: "tb_QuangCao");

            migrationBuilder.DropTable(
                name: "tb_TinTuc");

            migrationBuilder.DropTable(
                name: "tb_DatHang");

            migrationBuilder.DropTable(
                name: "tb_SanPham");

            migrationBuilder.DropTable(
                name: "tb_DanhMuc");

            migrationBuilder.DropTable(
                name: "tb_DanhMucSaPham");
        }
    }
}
