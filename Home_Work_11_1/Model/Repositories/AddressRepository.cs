namespace Home_Work_11_1.Model.Repositories;

public static class AddressRepository
{
    private static Random random = new Random();

    private static readonly string[] towns = new string[]
            {
                "Абакан",
                "Абдулино",
                "Азов",
                "Аксай",
                "Алупка",
                "Алушта",
                "Альметьевск",
                "Амурск",
                "Анадырь",
                "Анапа",
                "Ангарск",
                "Апатиты",
                "Арамиль",
                "Арзамас",
                "Армавир",
                "Артёмовск",
                "Архангельск",
                "Асбест",
                "Астрахань",
                "Ачинск"
            };//Размещение городов в базе данных towns
    private static int townsNumber = towns.Length;

    private static readonly string[] streets = new string[]
            {
                "Бабаевская улица",
                "Бабьегородский 1-й, переулок",
                "Бабьегородский 2-й, переулок",
                "Багратионовский проезд",
                "Багрицкого улица",
                "Баженова улица",
                "Бажова улица",
                "Базовая улица",
                "Базовская улица",
                "Байдукова улица",
                "Байкальская улица",
                "Бакинская улица",
                "26-ти Бакинских Комиссаров улица",
                "Бакунинская улица",
                "Балакиревский переулок",
                "Балаклавский проспект"
            };//Размещение улиц в базе данных streets
    private static int streetsNumber = streets.Length;

    public static Address Address()
    {
            return new(towns[random.Next(1, townsNumber)],
                streets[random.Next(1, streetsNumber)],
                random.Next(1, 100),
                random.Next(1, 100));
    }
}
