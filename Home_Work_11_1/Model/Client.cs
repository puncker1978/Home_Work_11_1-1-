using Home_Work_11_1.Model.Repositories;

namespace Home_Work_11_1.Model;

public class Client : Person
{
    /// <summary>
    /// Уникальный идентификационный номер клиента
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Номер телефона клиента
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Адрес клиента
    /// </summary>
    public Address Address { get; set; }

    /// <summary>
    /// Паспорт клиента
    /// </summary>
    public Passport Passport { get; set; }

    /// <summary>
    /// Банковский счёт клиента
    /// </summary>
    public Account Account { get; set; }

    /// <summary>
    /// Конструктор, описывающий клиента
    /// </summary>
    /// <param name="firstName">Имя</param>
    /// <param name="secondName">Фамилия</param>
    /// <param name="thirdName">Отчество</param>
    /// <param name="phoneNumber">Телефон</param>
    /// <param name="passport">Паспортные данные</param>
    /// <param name="address">Адрес</param>
    /// <param name="account">Банковский счёт</param>
    public Client(string firstName,
                  string secondName,
                  string thirdName,
                  string phoneNumber,
                  Passport passport,
                  Address address,
                  Account account) : base(firstName, secondName, thirdName)
    {
        
        Id = Guid.NewGuid();
        PhoneNumber = phoneNumber;
        Passport = passport;
        Address = address;
        Account = account;
    }
}
