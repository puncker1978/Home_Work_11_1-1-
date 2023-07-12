using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11_1.Model
{
    public class Repository
    {
        /// <summary>
        /// База данных имён
        /// </summary>
        private static readonly string[] firstNames;

        /// <summary>
        /// База данных фамилий
        /// </summary>
        private static readonly string[] secondNames;

        /// <summary>
        /// База данных отчеств
        /// </summary>
        private static readonly string[] thirdNames;

        /// <summary>
        /// Телефонный номер
        /// </summary>
        private readonly string phoneNumber;

        /// <summary>
        /// Серия паспорта
        /// </summary>
        private readonly string passportSeries;

        /// <summary>
        /// Номер паспорта
        /// </summary>
        private readonly string passportNumber;

        /// <summary>
        /// Генератор псевдослучайных чисел
        /// </summary>
        private static readonly Random randomize;

        /// <summary>
        /// Статический конструктор, в котором "хранятся"
        /// данные о именах и фамилиях баз данных firstNames, secondNames и thirdNames
        /// </summary>
        static Repository()
        {
            randomize = new Random(); // Размещение в памяти генератора случайных чисел

            // Размещение имен в базе данных firstNames
            firstNames = new string[]
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
            };

            // Размещение фамилий в базе данных secondNames
            secondNames = new string[]
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
            };

            // Размещение отчеств в базе данных thirdNames
            thirdNames = new string[] 
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
            };
        }

        /// <summary>
        /// База данных работников, в которой хранятся 
        /// Имя, фамилия, возраст и зарплаты каждого сотрудника
        /// </summary>
        public ObservableCollection<Client> Clients { get; set; }

        public Repository(int Count)
        {
            this.Clients = new ObservableCollection<Client>(); // Выделение памяти для хранения базы данных Clients
            int fName = Repository.firstNames.Length;
            int sName = Repository.secondNames.Length;
            int thName = Repository.thirdNames.Length;

            for (int i = 0; i < Count; i++)    // Заполнение базы данных Clients. Выполняется Count раз
            {
                // Генерируем случайный номер телефона
                int code = randomize.Next(100, 999);
                int num = randomize.Next(100, 999);
                int num1 = randomize.Next(10, 99);
                int num2 = randomize.Next(10, 99);
                phoneNumber = $"+7({code}){num}-{num1}-{num2}";

                // Генерируем случайную серию паспорта
                passportSeries = $"{randomize.Next(1000, 9999)}";

                // Генерируем случайный номер паспорта
                passportNumber = $"{randomize.Next(100000, 999999)}";

                //Генерируем начальную сумму на счёте
                int sum = randomize.Next(10, 10_000_000);

                // Добавляем нового работника в базу данных Clients
                this.Clients.Add(
                    new Client(
                        //Id клиента
                        Guid.NewGuid(),

                        // выбираем случайное имя из базы данных имён и передаём в конструктор
                        firstNames[Repository.randomize.Next(fName)],

                        // выбираем случайное имя из базы данных фамилий и передаём в конструктор
                        secondNames[Repository.randomize.Next(sName)],

                        // Генерируем случайное отчество и передаём в конструктор
                        thirdNames[Repository.randomize.Next(thName)],

                        //Передаем телефонный номер в конструктор
                        phoneNumber,

                        //Передаём серию паспорта в конструктор
                        passportSeries,

                        //Передаём номер паспорта в конструктор
                        passportNumber,

                        //Передаём начальную сумму на счёте
                        sum
                ));
            }
        }
    }
}
