using AutoHub.Domain.Entities.Features;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class FeatureSeedData
    {
        internal static readonly Feature[] Data =
        {
            // Безопасност (FeatureCategoryId = 1)
            new() { Id = 1, FeatureCategoryId = 1, Name = "GPS система за проследяване", IsActive = true },
            new() { Id = 2, FeatureCategoryId = 1, Name = "Адаптивни предни светлини", IsActive = true },
            new() { Id = 3, FeatureCategoryId = 1, Name = "Антиблокираща система", IsActive = true },
            new() { Id = 4, FeatureCategoryId = 1, Name = "Въздушни възглавници - Задни", IsActive = true },
            new() { Id = 5, FeatureCategoryId = 1, Name = "Въздушни възглавници - Предни", IsActive = true },
            new() { Id = 6, FeatureCategoryId = 1, Name = "Въздушни възглавници - Странични", IsActive = true },
            new() { Id = 7, FeatureCategoryId = 1, Name = "Ел. разпределяне на спирачното усилие", IsActive = true },
            new() { Id = 8, FeatureCategoryId = 1, Name = "Електронна програма за стабилизиране", IsActive = true },
            new() { Id = 9, FeatureCategoryId = 1, Name = "Контрол на налягането на гумите", IsActive = true },
            new() { Id = 10, FeatureCategoryId = 1, Name = "Парктроник", IsActive = true },
            new() { Id = 11, FeatureCategoryId = 1, Name = "Система ISOFIX", IsActive = true },
            new() { Id = 12, FeatureCategoryId = 1, Name = "Система за динамична устойчивост", IsActive = true },
            new() { Id = 13, FeatureCategoryId = 1, Name = "Система за защита от пробуксуване", IsActive = true },
            new() { Id = 14, FeatureCategoryId = 1, Name = "Система за контрол на дистанцията", IsActive = true },
            new() { Id = 15, FeatureCategoryId = 1, Name = "Система за контрол на спускането", IsActive = true },

            // Комфорт (FeatureCategoryId = 2)
            new() { Id = 16, FeatureCategoryId = 2, Name = "360 камера / Задна камера", IsActive = true },
            new() { Id = 17, FeatureCategoryId = 2, Name = "Apple CarPlay / Android Auto", IsActive = true },
            new() { Id = 18, FeatureCategoryId = 2, Name = "Auto Start Stop function", IsActive = true },
            new() { Id = 19, FeatureCategoryId = 2, Name = "Bluetooth / handsfree система", IsActive = true },
            new() { Id = 20, FeatureCategoryId = 2, Name = "DVD, TV", IsActive = true },
            new() { Id = 21, FeatureCategoryId = 2, Name = "Head up display", IsActive = true },
            new() { Id = 22, FeatureCategoryId = 2, Name = "Steptronic / Tiptronic", IsActive = true },
            new() { Id = 23, FeatureCategoryId = 2, Name = "USB, audio/video, IN/AUX изводи", IsActive = true },
            new() { Id = 24, FeatureCategoryId = 2, Name = "Автоматично затваряне на багажника", IsActive = true },
            new() { Id = 25, FeatureCategoryId = 2, Name = "Адаптивно въздушно окачване", IsActive = true },
            new() { Id = 26, FeatureCategoryId = 2, Name = "Безключово палене", IsActive = true },
            new() { Id = 27, FeatureCategoryId = 2, Name = "Блокаж на диференциала", IsActive = true },
            new() { Id = 28, FeatureCategoryId = 2, Name = "Бордкомпютър", IsActive = true },
            new() { Id = 29, FeatureCategoryId = 2, Name = "Бързи / бавни скорости", IsActive = true },
            new() { Id = 30, FeatureCategoryId = 2, Name = "Вентилация на седалките", IsActive = true },
            new() { Id = 31, FeatureCategoryId = 2, Name = "Датчик за светлина", IsActive = true },
            new() { Id = 32, FeatureCategoryId = 2, Name = "Ел. огледала", IsActive = true },
            new() { Id = 33, FeatureCategoryId = 2, Name = "Ел. стъкла", IsActive = true },
            new() { Id = 34, FeatureCategoryId = 2, Name = "Ел. регулиране на седалките", IsActive = true },
            new() { Id = 35, FeatureCategoryId = 2, Name = "Ел. усилвател на волана", IsActive = true },
            new() { Id = 36, FeatureCategoryId = 2, Name = "Климатик", IsActive = true },
            new() { Id = 37, FeatureCategoryId = 2, Name = "Климатроник", IsActive = true },
            new() { Id = 38, FeatureCategoryId = 2, Name = "Мултифункционален волан", IsActive = true },
            new() { Id = 39, FeatureCategoryId = 2, Name = "Навигация", IsActive = true },
            new() { Id = 40, FeatureCategoryId = 2, Name = "Отопление на волана", IsActive = true },
            new() { Id = 41, FeatureCategoryId = 2, Name = "Печка", IsActive = true },
            new() { Id = 42, FeatureCategoryId = 2, Name = "Подгряване на предното стъкло", IsActive = true },
            new() { Id = 43, FeatureCategoryId = 2, Name = "Подгряване на седалките", IsActive = true },
            new() { Id = 44, FeatureCategoryId = 2, Name = "Регулиране на волана", IsActive = true },
            new() { Id = 45, FeatureCategoryId = 2, Name = "Сензор за дъжд", IsActive = true },
            new() { Id = 46, FeatureCategoryId = 2, Name = "Серво усилвател на волана", IsActive = true },
            new() { Id = 47, FeatureCategoryId = 2, Name = "Система за измиване на фаровете", IsActive = true },
            new() { Id = 48, FeatureCategoryId = 2, Name = "Система за контрол на скоростта (автопилот)", IsActive = true },
            new() { Id = 49, FeatureCategoryId = 2, Name = "Термопомпа", IsActive = true },
            new() { Id = 50, FeatureCategoryId = 2, Name = "Хладилна жабка", IsActive = true },

            // Други (FeatureCategoryId = 3)
            new() { Id = 51, FeatureCategoryId = 3, Name = "4x4", IsActive = true },
            new() { Id = 52, FeatureCategoryId = 3, Name = "7 места", IsActive = true },
            new() { Id = 53, FeatureCategoryId = 3, Name = "Buy back", IsActive = true },
            new() { Id = 54, FeatureCategoryId = 3, Name = "Бартер", IsActive = true },
            new() { Id = 55, FeatureCategoryId = 3, Name = "Газова уредба", IsActive = true },
            new() { Id = 56, FeatureCategoryId = 3, Name = "Дълга база", IsActive = true },
            new() { Id = 57, FeatureCategoryId = 3, Name = "Капариран / Продаден", IsActive = true },
            new() { Id = 58, FeatureCategoryId = 3, Name = "Катастрофирал", IsActive = true },
            new() { Id = 59, FeatureCategoryId = 3, Name = "Къса база", IsActive = true },
            new() { Id = 60, FeatureCategoryId = 3, Name = "Лизинг", IsActive = true },
            new() { Id = 61, FeatureCategoryId = 3, Name = "Метанова уредба", IsActive = true },
            new() { Id = 62, FeatureCategoryId = 3, Name = "На части", IsActive = true },
            new() { Id = 63, FeatureCategoryId = 3, Name = "Напълно обслужен", IsActive = true },
            new() { Id = 64, FeatureCategoryId = 3, Name = "Нов внос", IsActive = true },
            new() { Id = 65, FeatureCategoryId = 3, Name = "С регистрация", IsActive = true },
            new() { Id = 66, FeatureCategoryId = 3, Name = "Сервизна книжка", IsActive = true },
            new() { Id = 67, FeatureCategoryId = 3, Name = "Тунинг", IsActive = true },

            // Защита (FeatureCategoryId = 4)
            new() { Id = 68, FeatureCategoryId = 4, Name = "OFFROAD пакет", IsActive = true },
            new() { Id = 69, FeatureCategoryId = 4, Name = "Аларма", IsActive = true },
            new() { Id = 70, FeatureCategoryId = 4, Name = "Брониран", IsActive = true },
            new() { Id = 71, FeatureCategoryId = 4, Name = "Каско", IsActive = true },
            new() { Id = 72, FeatureCategoryId = 4, Name = "Лебедка", IsActive = true },
            new() { Id = 73, FeatureCategoryId = 4, Name = "Централно заключване", IsActive = true },

            // Интериор (FeatureCategoryId = 5)
            new() { Id = 74, FeatureCategoryId = 5, Name = "Велурен салон", IsActive = true },
            new() { Id = 75, FeatureCategoryId = 5, Name = "Десен волан", IsActive = true },
            new() { Id = 76, FeatureCategoryId = 5, Name = "Кожен салон", IsActive = true },
            new() { Id = 77, FeatureCategoryId = 5, Name = "Светъл салон", IsActive = true },

            // Специализирани (FeatureCategoryId = 6)
            new() { Id = 78, FeatureCategoryId = 6, Name = "TAXI", IsActive = true },
            new() { Id = 79, FeatureCategoryId = 6, Name = "За хора с увреждания", IsActive = true },
            new() { Id = 80, FeatureCategoryId = 6, Name = "Катафалка", IsActive = true },
            new() { Id = 81, FeatureCategoryId = 6, Name = "Линейка", IsActive = true },
            new() { Id = 82, FeatureCategoryId = 6, Name = "Учебен", IsActive = true },
            new() { Id = 83, FeatureCategoryId = 6, Name = "Хладилен", IsActive = true },
            new() { Id = 84, FeatureCategoryId = 6, Name = "Хомологация N1", IsActive = true },

            // Екстериор (FeatureCategoryId = 7)
            new() { Id = 85, FeatureCategoryId = 7, Name = "2(3) Врати", IsActive = true },
            new() { Id = 86, FeatureCategoryId = 7, Name = "4(5) Врати", IsActive = true },
            new() { Id = 87, FeatureCategoryId = 7, Name = "LED фарове", IsActive = true },
            new() { Id = 88, FeatureCategoryId = 7, Name = "Ксенонови фарове", IsActive = true },
            new() { Id = 89, FeatureCategoryId = 7, Name = "Лети джанти", IsActive = true },
            new() { Id = 90, FeatureCategoryId = 7, Name = "Металик", IsActive = true },
            new() { Id = 91, FeatureCategoryId = 7, Name = "Панорамен люк", IsActive = true },
            new() { Id = 92, FeatureCategoryId = 7, Name = "Рейлинг на покрива", IsActive = true },
            new() { Id = 93, FeatureCategoryId = 7, Name = "Спойлери", IsActive = true },
            new() { Id = 94, FeatureCategoryId = 7, Name = "Теглич", IsActive = true },
            new() { Id = 95, FeatureCategoryId = 7, Name = "Халогенни фарове", IsActive = true },
            new() { Id = 96, FeatureCategoryId = 7, Name = "Шибедах", IsActive = true },
        };
    }
}