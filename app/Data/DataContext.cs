using Microsoft.EntityFrameworkCore;
using ClickableGameBackend.Models;

namespace ClickableGameBackend.Data {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<UserBalance> UserBalances { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<UserItem> UserItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Item>().HasData(
            new Item { Id = 1, Name = "M16 Rifle", Power = 0.3m, Price = 1200m, ImageUrl = "https://www.tacticool22.com/wp-content/uploads/2015/12/colt-m16-22-left.jpg" },
            new Item { Id = 2, Name = "AK-47", Power = 0.35m, Price = 700m, ImageUrl = "https://www.proarmis.si/product_images/l/ak47_7.62x39_wbp_jack_wood_premium_2.jpg" },
            new Item { Id = 3, Name = "HK416", Power = 0.4m, Price = 2500m, ImageUrl = "https://hk-usa.com/wp-content/uploads/1-HK416-10.4-LEFT1.jpg" },
            new Item { Id = 4, Name = "FN SCAR", Power = 0.45m, Price = 3000m, ImageUrl = "https://fnamerica.com/wp-content/uploads/2016/12/SCAR-17S-FDE_026.jpg" },
            new Item { Id = 5, Name = "Barrett M82", Power = 0.6m, Price = 10000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5a/Barrett-M82A1-Independence-Day-2017-IZE-048-white.jpg" },
            new Item { Id = 6, Name = "RPG-7", Power = 5m, Price = 1200m, ImageUrl = "https://www.prc68.com/I/Images/RPG7-12b.jpg" },
            new Item { Id = 7, Name = "M4 Carbine", Power = 0.35m, Price = 1500m, ImageUrl = "https://gunsweek.com/sites/default/files/styles/content_sm/public/archive/contents/rifles/articles/colt-defense-m4-classic-series/Colt_M4_Classic_Series_23.JPG?itok=_UD1C2Un" },
            new Item { Id = 8, Name = "FN F2000", Power = 0.4m, Price = 2300m, ImageUrl = "https://slovarms.si/media/catalog/product/cache/1/small_image/1200x630/9df78eab33525d08d6e5fb8d27136e95/f/n/fn_2000.jpg" },
            new Item { Id = 9, Name = "IWI Tavor", Power = 0.45m, Price = 2800m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d7/IWI-Tavor-TAR-21w1.jpg" },
            new Item { Id = 10, Name = "CZ BREN 2", Power = 0.4m, Price = 2200m, ImageUrl = "https://gunsweek.com/sites/default/files/archive/contents/rifles/news/cz-bren-2-br-762x51mm-battle-rifle/CZ-BREN2-BR-Icon.jpg" },
            new Item { Id = 11, Name = "M2 Browning", Power = 8m, Price = 12000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1d/PEO_Browning_M2E2_QCB_%28c1%29.jpg/1200px-PEO_Browning_M2E2_QCB_%28c1%29.jpg" },
            new Item { Id = 12, Name = "Desert Eagle", Power = 0.2m, Price = 1800m, ImageUrl = "https://cdn11.bigcommerce.com/s-kp97pt369w/images/stencil/1280x1280/products/2169/4939/SVimg-DE50SRMB__97561.1515511754.jpg?c=2" },
            new Item { Id = 13, Name = "Glock 17", Power = 0.1m, Price = 600m, ImageUrl = "https://slovarms.si/media/catalog/product/cache/1/thumbnail/9df78eab33525d08d6e5fb8d27136e95/g/l/glock-17-gen-5_1.jpg" },
            new Item { Id = 14, Name = "Colt M1911", Power = 0.15m, Price = 800m, ImageUrl = "https://www.colt.com/wp-content/uploads/2022/12/1911-classic-.45.jpg" },
            new Item { Id = 15, Name = "M1 Abrams", Power = 60m, Price = 7000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Abrams-transparent.png/1200px-Abrams-transparent.png" },
            new Item { Id = 16, Name = "Leopard 2A7", Power = 65m, Price = 8000000m, ImageUrl = "https://www.modellbahnunion.com/modellbahn-union-en/prodpic/HO-Tank-Leopard-2A7-FRG-Artitec-6870671_b_0.JPG" },
            new Item { Id = 17, Name = "T-90", Power = 55m, Price = 4000000m, ImageUrl = "https://www.technic-toys.com/wp-content/uploads/2022/04/23118-600x344.jpg" },
            new Item { Id = 18, Name = "Challenger 2", Power = 58m, Price = 6000000m, ImageUrl = "https://www.super-hobby.si/zdjecia/0/8/5/277_rd.jpg" },
            new Item { Id = 19, Name = "Merkava Mk IV", Power = 55m, Price = 6500000m, ImageUrl = "https://www.torro-shop.de/media/image/product/12211/lg/1-16-rc-idf-merkava-mk-iv-bbir.jpg" },
            new Item { Id = 20, Name = "Type 99", Power = 54m, Price = 5000000m, ImageUrl = "https://static.wikia.nocookie.net/armoredwarfare_gamepedia/images/b/b5/400px_Type_99.png/revision/latest?cb=20220602113420" },
            new Item { Id = 21, Name = "Leclerc", Power = 57m, Price = 9000000m, ImageUrl = "https://static.wikia.nocookie.net/armoredwarfare_gamepedia/images/c/c7/400px_Leclerc.png/revision/latest?cb=20220209061434" },
            new Item { Id = 22, Name = "K2 Black Panther", Power = 60m, Price = 8500000m, ImageUrl = "https://static.wikia.nocookie.net/armoredwarfare_gamepedia/images/f/f3/K2_Black_Panther_K2PL_skin_icon.png/revision/latest?cb=20221102171501" },
            new Item { Id = 23, Name = "T-14 Armata", Power = 65m, Price = 7500000m, ImageUrl = "https://static.wikia.nocookie.net/armoredwarfare_gamepedia/images/5/56/400px_T-14_Armata.png/revision/latest?cb=20220209073631" },
            new Item { Id = 24, Name = "AMX-56 Leclerc", Power = 58m, Price = 8500000m, ImageUrl = "https://p.turbosquid.com/ts-thumb/Rs/VRdg1E/JK/amx_56_leclerc_french_main_battle_tank_rigged_002/jpg/1674133615/600x600/fit_q87/c581b01b01a3c245e43fed4751b2f63220349ebf/amx_56_leclerc_french_main_battle_tank_rigged_002.jpg" },
            new Item { Id = 25, Name = "PT-91 Twardy", Power = 50m, Price = 4500000m, ImageUrl = "https://360view.hum3d.com/standard/Tanks/PT-91_Twardy_360_720_50-35.jpg" },
            new Item { Id = 26, Name = "F-35 Lightning II", Power = 400m, Price = 100000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/bf/Testflyging_av_f%C3%B8rste_norske_F-35_-1_%28cropped%29.jpg" },
            new Item { Id = 27, Name = "Sukhoi Su-57", Power = 380m, Price = 90000000m, ImageUrl = "https://static1.simpleflyingimages.com/wordpress/wp-content/uploads/2024/02/shutterstock_2176703295-1.jpg" },
            new Item { Id = 28, Name = "F-22 Raptor", Power = 450m, Price = 120000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1e/F-22_Raptor_edit1_%28cropped%29.jpg/1200px-F-22_Raptor_edit1_%28cropped%29.jpg" },
            new Item { Id = 29, Name = "Eurofighter Typhoon", Power = 350m, Price = 80000000m, ImageUrl = "https://cdn.shopify.com/s/files/1/0360/4209/t/49/assets/eurofighter_typhoon_aut-1693194083159.jpg?v=1693194084" },
            new Item { Id = 30, Name = "Dassault Rafale", Power = 320m, Price = 75000000m, ImageUrl = "https://i0.wp.com/militaryleak.com/wp-content/uploads/2024/01/indonesian-air-force-completes-acquisition-of-42-dassault-rafale-fighter-jets.jpg" },
            new Item { Id = 31, Name = "J-20 Mighty Dragon", Power = 370m, Price = 90000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/73/J-20_at_CCAS2022_%2820220827103424%29.jpg" },
            new Item { Id = 32, Name = "Saab Gripen", Power = 300m, Price = 60000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Saab_JAS_39_Gripen_at_Kaivopuisto_Air_Show%2C_June_2017_%28altered%29_copy.jpg/1200px-Saab_JAS_39_Gripen_at_Kaivopuisto_Air_Show%2C_June_2017_%28altered%29_copy.jpg" },
            new Item { Id = 33, Name = "F/A-18 Super Hornet", Power = 330m, Price = 75000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/de/US_Navy_071203-N-8923M-074_An_F-A-18F_Super_Hornet%2C_from_the_Red_Rippers_of_Strike_Fighter_Squadron_%28VFA%29_11%2C_makes_a_sharp_turn_above_the_flight_deck_aboard_the_Nimitz-class_nuclear-powered_aircraft_carrier_USS_Harry_S._Truman.jpg" },
            new Item { Id = 34, Name = "MiG-35", Power = 310m, Price = 45000000m, ImageUrl = "https://img.goodfon.com/original/2560x1662/d/53/mig-35-samoliot-oruzhie.jpg" },
            new Item { Id = 35, Name = "F-16 Fighting Falcon", Power = 310m, Price = 40000000m, ImageUrl = "https://d.newsweek.com/en/full/2386052/falcon-fighter-india.jpg?w=1600&h=1200&q=88&f=8d07b013bcff347223f2e065e5edc4ef" },
            new Item { Id = 36, Name = "F-15 Eagle", Power = 340m, Price = 60000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a6/F-15C_Eagle_from_the_44th_Fighter_Squadron_flies_during_a_routine_training_exercise_April_15%2C_2019.jpg" },
            new Item { Id = 37, Name = "Su-35 Flanker-E", Power = 330m, Price = 50000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Russian_Air_Force%2C_RF-81719%2C_Sukhoi_Su-35S_%2849581740157%29.jpg" },
            new Item { Id = 38, Name = "A-10 Thunderbolt II", Power = 280m, Price = 18000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cf/A-10_Thunderbolt_II_In-flight-2.jpg" },
            new Item { Id = 39, Name = "B-2 Spirit Bomber", Power = 500m, Price = 1500000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a1/B-2_Spirits_on_Deployment_to_Indo-Asia-Pacific.jpg/640px-B-2_Spirits_on_Deployment_to_Indo-Asia-Pacific.jpg" },
            new Item { Id = 40, Name = "B-52 Stratofortress", Power = 400m, Price = 100000000m, ImageUrl = "https://cloudfront-us-east-1.images.arcpublishing.com/archetype/DJED4KFT4VDDRI35Y5BC2SKXSM.jpg" },
            new Item { Id = 41, Name = "Arleigh Burke Destroyer", Power = 2000m, Price = 1500000000m, ImageUrl = "https://www.naval-technology.com/wp-content/uploads/sites/15/2022/05/DDG-121-scaled.jpg" },
            new Item { Id = 42, Name = "Zumwalt-Class Destroyer", Power = 2500m, Price = 4000000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/160421-N-YE579-005_%2826543438313%29.jpg" },
            new Item { Id = 43, Name = "Nimitz-Class Aircraft Carrier", Power = 20000m, Price = 9000000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/81/USS_Nimitz_in_Victoria_Canada_036.jpg" },
            new Item { Id = 44, Name = "Ford-Class Aircraft Carrier", Power = 25000m, Price = 13000000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/52/USS_Gerald_R._Ford_%28CVN-78%29_underway_in_the_Atlantic_Ocean_on_9_October_2022_%28221009-N-TL968-1248%29.JPG" },
            new Item { Id = 45, Name = "Queen Elizabeth-Class Carrier", Power = 15000m, Price = 6500000000m, ImageUrl = "https://www.seaforces.org/marint/Royal-Navy/Aircraft-Carrier/R08-HMS-Queen-Elizabeth_DAT/R08-HMS-Queen-Elizabeth-084.jpg" },
            new Item { Id = 46, Name = "Type 45 Destroyer", Power = 1800m, Price = 1200000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/bf/HMS_Daring-1.jpg" },
            new Item { Id = 47, Name = "Admiral Gorshkov-Class Frigate", Power = 1500m, Price = 500000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Admiral_Gorshkov_frigate_02.jpg/800px-Admiral_Gorshkov_frigate_02.jpg" },
            new Item { Id = 48, Name = "LCS Freedom-Class", Power = 1200m, Price = 400000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0a/USS-Freedom-130222-N-DR144-174-crop.jpg" },
            new Item { Id = 49, Name = "Seawolf-Class Submarine", Power = 4000m, Price = 3000000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Defense.gov_News_Photo_960703-N-00000-001.jpg/1200px-Defense.gov_News_Photo_960703-N-00000-001.jpg" },
            new Item { Id = 50, Name = "Virginia-Class Submarine", Power = 3500m, Price = 2700000000m, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/bb/US_Navy_040730-N-1234E-002_PCU_Virginia_%28SSN_774%29_returns_to_the_General_Dynamics_Electric_Boat_shipyard.jpg" }
        );



            // Define 1:1 relationship between User and UserBalance
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserBalance)
                .WithOne(b => b.User)
                .HasForeignKey<UserBalance>(b => b.UserId);

            // Define 1:N relationship between User and Transaction
            modelBuilder.Entity<Transaction>()
                .HasOne<User>()
                .WithMany(u => u.Transactions)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Define 1:N relationship between Item and Transaction
            modelBuilder.Entity<Transaction>()
                .HasOne<Item>()
                .WithMany()
                .HasForeignKey(t => t.ItemId)
                .OnDelete(DeleteBehavior.Restrict);

            // Define the many-to-many relationship via UserItem
            modelBuilder.Entity<UserItem>()
                .HasKey(ui => new { ui.UserId, ui.ItemId });  // Composite key

            modelBuilder.Entity<UserItem>()
                .HasOne<User>()
                .WithMany(u => u.UserItems)
                .HasForeignKey(ui => ui.UserId);

            modelBuilder.Entity<UserItem>()
                .HasOne<Item>()
                .WithMany()
                .HasForeignKey(ui => ui.ItemId);
        }
    }
}