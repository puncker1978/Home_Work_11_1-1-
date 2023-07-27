using System.Net;

namespace Home_Work_11_1.Model.Repositories;

public class ClientsRepository
{
    private static Random random = new Random();
    public ObservableCollection<Client> Clients = new ObservableCollection<Client>();

    private Account account;
    private Address address;
    private Passport passport;


    /// <summary>
    /// База данных имён
    /// </summary>
    private static readonly string[] firstNames = new string[]
        {
                "Агата",
                "Агнес",
                "Аделаида",
                "Аделина",
                "Алдона",
                "Алима",
                "Аманда",
                "Влада",
                "Виолетта",
                "Галина",
                "Гузель",
                "Гюльчатай",
                "Дарья",
                "Евдокия",
                "Екатерина",
                "Зинаида",
                "Ирина"
        };// Размещение имен в базе данных firstName;
    private int fNames = firstNames.Length;

    /// <summary>
    /// База данных фамилий
    /// </summary>
    private static readonly string[] secondNames = new string[]
        {
                "Иванова",
                "Петрова",
                "Васильева",
                "Кузнецова",
                "Ковалёва",
                "Попова",
                "Пономарёва",
                "Дьячкова",
                "Коновалова",
                "Соколова",
                "Лебедева",
                "Соловьёва",
                "Козлова",
                "Волкова",
                "Зайцева",
                "Ершова",
                "Карпова",
                "Щукина",
                "Виноградова",
                "Цветкова",
                "Калинина"
        };// Размещение фамилий в базе данных secondNames
    private int sNames = secondNames.Length;

    /// <summary>
    /// База данных отчеств
    /// </summary>
    private static readonly string[] thirdNames = new string[]
        {
                "Николаевна",
                "Алексеевна",
                "Юрьевна",
                "Ярославовна",
                "Семеновна",
                "Евгеньевна",
                "Олеговна",
                "Петровна",
                "Степановна",
                "Вячеславовна",
                "Сергеевна",
                "Дмитриевна",
                "Егоровна",
                "Ивановна",
                "Сидоровна",
                "Игоревна",
                "Матвеевна"
        };// Размещение отчеств в базе данных thirdNames
    private int thNames = thirdNames.Length;

    public ClientsRepository(int count)
    {
        for (int i = 0; i < count; i++)
        {
            // Генерируем случайный номер телефона
            int code = random.Next(100, 999);
            int num = random.Next(100, 999);
            int num1 = random.Next(10, 99);
            int num2 = random.Next(10, 99);
            string phoneNumber = $"+7({code}){num}-{num1}-{num2}";

            //Банковский счёт клиента
            account = AccountRepository.Account();

            //Адрес клиента
            address = AddressRepository.Address();

            //Паспорт клиента
            passport = PassportRepository.Passport();
            

            // Добавляем нового работника в базу данных Clients
            Clients.Add
                (
                new Client(

                    // выбираем случайное имя из базы данных имён и передаём в конструктор
                    firstNames[random.Next(fNames)],

                    // выбираем случайное имя из базы данных фамилий и передаём в конструктор
                    secondNames[random.Next(sNames)],

                    // Генерируем случайное отчество и передаём в конструктор
                    thirdNames[random.Next(thNames)],

                    //Передаем телефонный номер в конструктор
                    phoneNumber,

                    //Паспортные данные клиента
                    passport,

                    //Адрес клиента
                    address,

                    //Банковский счёт
                    account)
                );
        }
    }
}
