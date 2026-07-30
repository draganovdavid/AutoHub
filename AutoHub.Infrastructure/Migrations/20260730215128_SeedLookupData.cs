using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedLookupData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Brands");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Features",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "BodyTypes",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Ван" },
                    { 2, true, "Джип" },
                    { 3, true, "Кабрио" },
                    { 4, true, "Комби" },
                    { 5, true, "Купе" },
                    { 6, true, "Миниван" },
                    { 7, true, "Седан" },
                    { 8, true, "Стреч лимузина" },
                    { 9, true, "Хечбек" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Mercedes-Benz" },
                    { 2, true, "BMW" },
                    { 3, true, "Audi" },
                    { 4, true, "Volkswagen" },
                    { 5, true, "Toyota" },
                    { 6, true, "Ford" },
                    { 7, true, "Opel" },
                    { 8, true, "Renault" },
                    { 9, true, "Peugeot" },
                    { 10, true, "Škoda" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Бяло" },
                    { 2, true, "Черно" },
                    { 3, true, "Сиво" },
                    { 4, true, "Сребристо" },
                    { 5, true, "Синьо" },
                    { 6, true, "Червено" },
                    { 7, true, "Зелено" },
                    { 8, true, "Кафяво" },
                    { 9, true, "Жълто" },
                    { 10, true, "Оранжево" }
                });

            migrationBuilder.InsertData(
                table: "EngineTypes",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Бензинов" },
                    { 2, true, "Дизелов" },
                    { 3, true, "Електрически" },
                    { 4, true, "Хибриден" },
                    { 5, true, "Plug-in хибрид" },
                    { 6, true, "Газ" },
                    { 7, true, "Водород" }
                });

            migrationBuilder.InsertData(
                table: "EuroStandards",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Euro 1" },
                    { 2, true, "Euro 2" },
                    { 3, true, "Euro 3" },
                    { 4, true, "Euro 4" },
                    { 5, true, "Euro 5" },
                    { 6, true, "Euro 6" }
                });

            migrationBuilder.InsertData(
                table: "FeatureCategories",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Безопасност" },
                    { 2, true, "Комфорт" },
                    { 3, true, "Други" },
                    { 4, true, "Защита" },
                    { 5, true, "Интериор" },
                    { 6, true, "Специализирани" },
                    { 7, true, "Екстериор" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "София" },
                    { 2, true, "Пловдив" },
                    { 3, true, "Варна" },
                    { 4, true, "Бургас" },
                    { 5, true, "Русе" },
                    { 6, true, "Стара Загора" },
                    { 7, true, "Плевен" },
                    { 8, true, "Сливен" },
                    { 9, true, "Добрич" },
                    { 10, true, "Шумен" },
                    { 11, true, "Перник" },
                    { 12, true, "Хасково" },
                    { 13, true, "Пазарджик" },
                    { 14, true, "Благоевград" },
                    { 15, true, "Велико Търново" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Ръчна" },
                    { 2, true, "Автоматична" },
                    { 3, true, "Полуавтоматична" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "IsActive", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, true, "Автомобили и Джипове", "avtomobiliidjipove" },
                    { 2, true, "Бусове", "busove" },
                    { 3, true, "Камиони", "kamioni" },
                    { 4, true, "Мотоциклети", "mototsikleti" },
                    { 5, true, "Селскостопански", "selskostopanski" },
                    { 6, true, "Индустриални", "industrialni" },
                    { 7, true, "Кари", "kari" },
                    { 8, true, "Каравани", "karavani" },
                    { 9, true, "Яхти и Лодки", "yahtiilodki" },
                    { 10, true, "Ремаркета", "remarketa" },
                    { 11, true, "Велосипеди", "velosipedi" },
                    { 12, true, "Части", "chasti" },
                    { 13, true, "Аксесоари", "aksesoari" },
                    { 14, true, "Гуми и джанти", "gumiidjanti" },
                    { 15, true, "Купува", "kupuva" },
                    { 16, true, "Услуги", "uslugi" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "FeatureCategoryId", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 1, true, "GPS система за проследяване" },
                    { 2, 1, true, "Адаптивни предни светлини" },
                    { 3, 1, true, "Антиблокираща система" },
                    { 4, 1, true, "Въздушни възглавници - Задни" },
                    { 5, 1, true, "Въздушни възглавници - Предни" },
                    { 6, 1, true, "Въздушни възглавници - Странични" },
                    { 7, 1, true, "Ел. разпределяне на спирачното усилие" },
                    { 8, 1, true, "Електронна програма за стабилизиране" },
                    { 9, 1, true, "Контрол на налягането на гумите" },
                    { 10, 1, true, "Парктроник" },
                    { 11, 1, true, "Система ISOFIX" },
                    { 12, 1, true, "Система за динамична устойчивост" },
                    { 13, 1, true, "Система за защита от пробуксуване" },
                    { 14, 1, true, "Система за контрол на дистанцията" },
                    { 15, 1, true, "Система за контрол на спускането" },
                    { 16, 2, true, "360 камера / Задна камера" },
                    { 17, 2, true, "Apple CarPlay / Android Auto" },
                    { 18, 2, true, "Auto Start Stop function" },
                    { 19, 2, true, "Bluetooth / handsfree система" },
                    { 20, 2, true, "DVD, TV" },
                    { 21, 2, true, "Head up display" },
                    { 22, 2, true, "Steptronic / Tiptronic" },
                    { 23, 2, true, "USB, audio/video, IN/AUX изводи" },
                    { 24, 2, true, "Автоматично затваряне на багажника" },
                    { 25, 2, true, "Адаптивно въздушно окачване" },
                    { 26, 2, true, "Безключово палене" },
                    { 27, 2, true, "Блокаж на диференциала" },
                    { 28, 2, true, "Бордкомпютър" },
                    { 29, 2, true, "Бързи / бавни скорости" },
                    { 30, 2, true, "Вентилация на седалките" },
                    { 31, 2, true, "Датчик за светлина" },
                    { 32, 2, true, "Ел. огледала" },
                    { 33, 2, true, "Ел. стъкла" },
                    { 34, 2, true, "Ел. регулиране на седалките" },
                    { 35, 2, true, "Ел. усилвател на волана" },
                    { 36, 2, true, "Климатик" },
                    { 37, 2, true, "Климатроник" },
                    { 38, 2, true, "Мултифункционален волан" },
                    { 39, 2, true, "Навигация" },
                    { 40, 2, true, "Отопление на волана" },
                    { 41, 2, true, "Печка" },
                    { 42, 2, true, "Подгряване на предното стъкло" },
                    { 43, 2, true, "Подгряване на седалките" },
                    { 44, 2, true, "Регулиране на волана" },
                    { 45, 2, true, "Сензор за дъжд" },
                    { 46, 2, true, "Серво усилвател на волана" },
                    { 47, 2, true, "Система за измиване на фаровете" },
                    { 48, 2, true, "Система за контрол на скоростта (автопилот)" },
                    { 49, 2, true, "Термопомпа" },
                    { 50, 2, true, "Хладилна жабка" },
                    { 51, 3, true, "4x4" },
                    { 52, 3, true, "7 места" },
                    { 53, 3, true, "Buy back" },
                    { 54, 3, true, "Бартер" },
                    { 55, 3, true, "Газова уредба" },
                    { 56, 3, true, "Дълга база" },
                    { 57, 3, true, "Капариран / Продаден" },
                    { 58, 3, true, "Катастрофирал" },
                    { 59, 3, true, "Къса база" },
                    { 60, 3, true, "Лизинг" },
                    { 61, 3, true, "Метанова уредба" },
                    { 62, 3, true, "На части" },
                    { 63, 3, true, "Напълно обслужен" },
                    { 64, 3, true, "Нов внос" },
                    { 65, 3, true, "С регистрация" },
                    { 66, 3, true, "Сервизна книжка" },
                    { 67, 3, true, "Тунинг" },
                    { 68, 4, true, "OFFROAD пакет" },
                    { 69, 4, true, "Аларма" },
                    { 70, 4, true, "Брониран" },
                    { 71, 4, true, "Каско" },
                    { 72, 4, true, "Лебедка" },
                    { 73, 4, true, "Централно заключване" },
                    { 74, 5, true, "Велурен салон" },
                    { 75, 5, true, "Десен волан" },
                    { 76, 5, true, "Кожен салон" },
                    { 77, 5, true, "Светъл салон" },
                    { 78, 6, true, "TAXI" },
                    { 79, 6, true, "За хора с увреждания" },
                    { 80, 6, true, "Катафалка" },
                    { 81, 6, true, "Линейка" },
                    { 82, 6, true, "Учебен" },
                    { 83, 6, true, "Хладилен" },
                    { 84, 6, true, "Хомологация N1" },
                    { 85, 7, true, "2(3) Врати" },
                    { 86, 7, true, "4(5) Врати" },
                    { 87, 7, true, "LED фарове" },
                    { 88, 7, true, "Ксенонови фарове" },
                    { 89, 7, true, "Лети джанти" },
                    { 90, 7, true, "Металик" },
                    { 91, 7, true, "Панорамен люк" },
                    { 92, 7, true, "Рейлинг на покрива" },
                    { 93, 7, true, "Спойлери" },
                    { 94, 7, true, "Теглич" },
                    { 95, 7, true, "Халогенни фарове" },
                    { 96, 7, true, "Шибедах" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypeFeatures",
                columns: new[] { "FeatureId", "VehicleTypeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 },
                    { 21, 1 },
                    { 22, 1 },
                    { 23, 1 },
                    { 24, 1 },
                    { 25, 1 },
                    { 26, 1 },
                    { 27, 1 },
                    { 28, 1 },
                    { 29, 1 },
                    { 30, 1 },
                    { 31, 1 },
                    { 32, 1 },
                    { 33, 1 },
                    { 34, 1 },
                    { 35, 1 },
                    { 36, 1 },
                    { 37, 1 },
                    { 38, 1 },
                    { 39, 1 },
                    { 40, 1 },
                    { 41, 1 },
                    { 42, 1 },
                    { 43, 1 },
                    { 44, 1 },
                    { 45, 1 },
                    { 46, 1 },
                    { 47, 1 },
                    { 48, 1 },
                    { 49, 1 },
                    { 50, 1 },
                    { 51, 1 },
                    { 52, 1 },
                    { 53, 1 },
                    { 54, 1 },
                    { 55, 1 },
                    { 56, 1 },
                    { 57, 1 },
                    { 58, 1 },
                    { 59, 1 },
                    { 60, 1 },
                    { 61, 1 },
                    { 62, 1 },
                    { 63, 1 },
                    { 64, 1 },
                    { 65, 1 },
                    { 66, 1 },
                    { 67, 1 },
                    { 68, 1 },
                    { 69, 1 },
                    { 70, 1 },
                    { 71, 1 },
                    { 72, 1 },
                    { 73, 1 },
                    { 74, 1 },
                    { 75, 1 },
                    { 76, 1 },
                    { 77, 1 },
                    { 78, 1 },
                    { 79, 1 },
                    { 80, 1 },
                    { 81, 1 },
                    { 82, 1 },
                    { 83, 1 },
                    { 84, 1 },
                    { 85, 1 },
                    { 86, 1 },
                    { 87, 1 },
                    { 88, 1 },
                    { 89, 1 },
                    { 90, 1 },
                    { 91, 1 },
                    { 92, 1 },
                    { 93, 1 },
                    { 94, 1 },
                    { 95, 1 },
                    { 96, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BodyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BodyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BodyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BodyTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BodyTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BodyTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BodyTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BodyTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BodyTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EngineTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EngineTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EngineTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EngineTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EngineTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EngineTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EngineTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EuroStandards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 78, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 82, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 88, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 91, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 92, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 94, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 95, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypeFeatures",
                keyColumns: new[] { "FeatureId", "VehicleTypeId" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeatureCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeatureCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeatureCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FeatureCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FeatureCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FeatureCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FeatureCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Features",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Brands",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }
    }
}
