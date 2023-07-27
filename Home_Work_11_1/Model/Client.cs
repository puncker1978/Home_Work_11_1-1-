namespace Home_Work_11_1.Model;

internal class Client : Person
{
    /// <summary>
    /// Уникальный идентификационный номер клиента
    /// </summary>
    internal Guid Id { get; set; }

    /// <summary>
    /// Номер телефона клиента
    /// </summary>
    internal string PhoneNumber { get; set; }

    /// <summary>
    /// Адрес клиента
    /// </summary>
    internal Address Address { get; set; }

    /// <summary>
    /// Серия паспорта клиента
    /// </summary>
    internal string PassportSeries { get; set; }

    /// <summary>
    /// Номер паспорта клиента
    /// </summary>
    internal string PassportNumber { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    internal DateTime BirthDay { get; set; }

    /// <summary>
    /// Банковский счёт клиента
    /// </summary>
    internal Account Account { get; set; }

    /// <summary>
    /// Конструктор, описывающий клиента
    /// </summary>
    /// <param name="firstName">Имя</param>
    /// <param name="secondName">Фамилия</param>
    /// <param name="thirdName">Отчество</param>
    /// <param name="birthDay">Дата рождения</param>
    /// <param name="id">Уникальный идентификационный номер</param>
    /// <param name="phoneNumber">Телефон</param>
    /// <param name="address">Адрес</param>
    /// <param name="passportSeries">Серия паспорта</param>
    /// <param name="passportNumber">Номер паспорта</param>
    /// <param name="account">Банковский счёт</param>
    internal Client(string firstName,
                  string secondName,
                  string thirdName,
                  DateTime birthDay,
                  Guid id,
                  string phoneNumber,
                  Address address,
                  string passportSeries,
                  string passportNumber,
                  Account account) : base(firstName, secondName, thirdName)
    {
        BirthDay = birthDay;
        Id = id;
        PhoneNumber = phoneNumber;
        Address = address;
        PassportSeries = passportSeries;
        PassportNumber = passportNumber;
        Account = account;
    }
}
