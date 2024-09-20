using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickableGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class newItemPowers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Power",
                table: "UserItems",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "Power",
                table: "Items",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Items",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://www.tacticool22.com/wp-content/uploads/2015/12/colt-m16-22-left.jpg", 0.3m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://www.proarmis.si/product_images/l/ak47_7.62x39_wbp_jack_wood_premium_2.jpg", 0.35m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://hk-usa.com/wp-content/uploads/1-HK416-10.4-LEFT1.jpg", 0.4m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://fnamerica.com/wp-content/uploads/2016/12/SCAR-17S-FDE_026.jpg", 0.45m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/5/5a/Barrett-M82A1-Independence-Day-2017-IZE-048-white.jpg", 0.6m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://www.prc68.com/I/Images/RPG7-12b.jpg", 5m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://gunsweek.com/sites/default/files/styles/content_sm/public/archive/contents/rifles/articles/colt-defense-m4-classic-series/Colt_M4_Classic_Series_23.JPG?itok=_UD1C2Un", 0.35m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://slovarms.si/media/catalog/product/cache/1/small_image/1200x630/9df78eab33525d08d6e5fb8d27136e95/f/n/fn_2000.jpg", 0.4m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/d/d7/IWI-Tavor-TAR-21w1.jpg", 0.45m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://gunsweek.com/sites/default/files/archive/contents/rifles/news/cz-bren-2-br-762x51mm-battle-rifle/CZ-BREN2-BR-Icon.jpg", 0.4m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1d/PEO_Browning_M2E2_QCB_%28c1%29.jpg/1200px-PEO_Browning_M2E2_QCB_%28c1%29.jpg", 8m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://cdn11.bigcommerce.com/s-kp97pt369w/images/stencil/1280x1280/products/2169/4939/SVimg-DE50SRMB__97561.1515511754.jpg?c=2", 0.2m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://slovarms.si/media/catalog/product/cache/1/thumbnail/9df78eab33525d08d6e5fb8d27136e95/g/l/glock-17-gen-5_1.jpg", 0.1m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://www.colt.com/wp-content/uploads/2022/12/1911-classic-.45.jpg", 0.15m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Abrams-transparent.png/1200px-Abrams-transparent.png", 60m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://www.modellbahnunion.com/modellbahn-union-en/prodpic/HO-Tank-Leopard-2A7-FRG-Artitec-6870671_b_0.JPG", 65m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://www.technic-toys.com/wp-content/uploads/2022/04/23118-600x344.jpg", 55m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://www.super-hobby.si/zdjecia/0/8/5/277_rd.jpg", 58m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://www.torro-shop.de/media/image/product/12211/lg/1-16-rc-idf-merkava-mk-iv-bbir.jpg", 55m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://static.wikia.nocookie.net/armoredwarfare_gamepedia/images/b/b5/400px_Type_99.png/revision/latest?cb=20220602113420", 54m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://static.wikia.nocookie.net/armoredwarfare_gamepedia/images/c/c7/400px_Leclerc.png/revision/latest?cb=20220209061434", 57m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://static.wikia.nocookie.net/armoredwarfare_gamepedia/images/f/f3/K2_Black_Panther_K2PL_skin_icon.png/revision/latest?cb=20221102171501", 60m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://static.wikia.nocookie.net/armoredwarfare_gamepedia/images/5/56/400px_T-14_Armata.png/revision/latest?cb=20220209073631", 65m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://p.turbosquid.com/ts-thumb/Rs/VRdg1E/JK/amx_56_leclerc_french_main_battle_tank_rigged_002/jpg/1674133615/600x600/fit_q87/c581b01b01a3c245e43fed4751b2f63220349ebf/amx_56_leclerc_french_main_battle_tank_rigged_002.jpg", 58m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://360view.hum3d.com/standard/Tanks/PT-91_Twardy_360_720_50-35.jpg", 50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/b/bf/Testflyging_av_f%C3%B8rste_norske_F-35_-1_%28cropped%29.jpg", 400m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://static1.simpleflyingimages.com/wordpress/wp-content/uploads/2024/02/shutterstock_2176703295-1.jpg", 380m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1e/F-22_Raptor_edit1_%28cropped%29.jpg/1200px-F-22_Raptor_edit1_%28cropped%29.jpg", 450m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://cdn.shopify.com/s/files/1/0360/4209/t/49/assets/eurofighter_typhoon_aut-1693194083159.jpg?v=1693194084", 350m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://i0.wp.com/militaryleak.com/wp-content/uploads/2024/01/indonesian-air-force-completes-acquisition-of-42-dassault-rafale-fighter-jets.jpg", 320m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/7/73/J-20_at_CCAS2022_%2820220827103424%29.jpg", 370m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Saab_JAS_39_Gripen_at_Kaivopuisto_Air_Show%2C_June_2017_%28altered%29_copy.jpg/1200px-Saab_JAS_39_Gripen_at_Kaivopuisto_Air_Show%2C_June_2017_%28altered%29_copy.jpg", 300m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/d/de/US_Navy_071203-N-8923M-074_An_F-A-18F_Super_Hornet%2C_from_the_Red_Rippers_of_Strike_Fighter_Squadron_%28VFA%29_11%2C_makes_a_sharp_turn_above_the_flight_deck_aboard_the_Nimitz-class_nuclear-powered_aircraft_carrier_USS_Harry_S._Truman.jpg", 330m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://img.goodfon.com/original/2560x1662/d/53/mig-35-samoliot-oruzhie.jpg", 310m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://d.newsweek.com/en/full/2386052/falcon-fighter-india.jpg?w=1600&h=1200&q=88&f=8d07b013bcff347223f2e065e5edc4ef", 310m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/a/a6/F-15C_Eagle_from_the_44th_Fighter_Squadron_flies_during_a_routine_training_exercise_April_15%2C_2019.jpg", 340m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/e/ec/Russian_Air_Force%2C_RF-81719%2C_Sukhoi_Su-35S_%2849581740157%29.jpg", 330m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/c/cf/A-10_Thunderbolt_II_In-flight-2.jpg", 280m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a1/B-2_Spirits_on_Deployment_to_Indo-Asia-Pacific.jpg/640px-B-2_Spirits_on_Deployment_to_Indo-Asia-Pacific.jpg", 500m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://cloudfront-us-east-1.images.arcpublishing.com/archetype/DJED4KFT4VDDRI35Y5BC2SKXSM.jpg", 400m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://www.naval-technology.com/wp-content/uploads/sites/15/2022/05/DDG-121-scaled.jpg", 2000m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/4/43/160421-N-YE579-005_%2826543438313%29.jpg", 2500m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/8/81/USS_Nimitz_in_Victoria_Canada_036.jpg", 20000m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/5/52/USS_Gerald_R._Ford_%28CVN-78%29_underway_in_the_Atlantic_Ocean_on_9_October_2022_%28221009-N-TL968-1248%29.JPG", 25000m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://www.seaforces.org/marint/Royal-Navy/Aircraft-Carrier/R08-HMS-Queen-Elizabeth_DAT/R08-HMS-Queen-Elizabeth-084.jpg", 15000m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/b/bf/HMS_Daring-1.jpg", 1800m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Admiral_Gorshkov_frigate_02.jpg/800px-Admiral_Gorshkov_frigate_02.jpg", 1500m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/0/0a/USS-Freedom-130222-N-DR144-174-crop.jpg", 1200m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Defense.gov_News_Photo_960703-N-00000-001.jpg/1200px-Defense.gov_News_Photo_960703-N-00000-001.jpg", 4000m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ImageUrl", "Power" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/b/bb/US_Navy_040730-N-1234E-002_PCU_Virginia_%28SSN_774%29_returns_to_the_General_Dynamics_Electric_Boat_shipyard.jpg", 3500m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "Power",
                table: "UserItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "Power",
                table: "Items",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Power",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Power",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "Power",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "Power",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "Power",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "Power",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                column: "Power",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "Power",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                column: "Power",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                column: "Power",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                column: "Power",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                column: "Power",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                column: "Power",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                column: "Power",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                column: "Power",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                column: "Power",
                value: 92);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                column: "Power",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                column: "Power",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                column: "Power",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                column: "Power",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                column: "Power",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                column: "Power",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                column: "Power",
                value: 92);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                column: "Power",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                column: "Power",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                column: "Power",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                column: "Power",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                column: "Power",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                column: "Power",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                column: "Power",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                column: "Power",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                column: "Power",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                column: "Power",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                column: "Power",
                value: 82);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                column: "Power",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                column: "Power",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                column: "Power",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                column: "Power",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                column: "Power",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                column: "Power",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                column: "Power",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                column: "Power",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                column: "Power",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                column: "Power",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                column: "Power",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                column: "Power",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                column: "Power",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                column: "Power",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                column: "Power",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                column: "Power",
                value: 90);
        }
    }
}
