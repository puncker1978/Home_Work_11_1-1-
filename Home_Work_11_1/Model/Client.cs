namespace Home_Work_11_1.Model;

public class Client : Person
{
    #region Свойства

    /// <summary>
    /// Уникальный идентификационный номер клиента
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Серия паспорта
    /// </summary>
    public string PassportSeries { get; set; }

    /// <summary>
    /// Номер паспорта
    /// </summary>
    public string PassportNumber { get; set; }

    /// <summary>
    /// Банковский счёт
    /// </summary>
    Account Account { get; set; }
    #endregion

    #region Конструктор
    /// <summary>
    /// Клиент
    /// </summary>
    /// <param name="id">Уникальный идентификационный номер клиента</param>
    /// <param name="firstName">Имя клиента</param>
    /// <param name="secondName">Фамилия клиента</param>
    /// <param name="thirdName">Отчество клиента</param>
    /// <param name="phoneNumber">Номер телефона клиента</param>
    /// <param name="passportSeries">Серия паспорта клиента</param>
    /// <param name="passportNumber">Номер паспорта клиента</param>
    /// <param name="sum">Деньги клиента</param>
    public Client(Guid id,
        string firstName,
        string secondName,
        string thirdName,
        string phoneNumber,
        string passportSeries,
        string passportNumber,
        int sum) : base(firstName, secondName, thirdName)
    {
        Id = id;
        Account = new Account(sum, id);
        PhoneNumber = phoneNumber;
        PassportSeries = passportSeries;
        PassportNumber = passportNumber;
    }
    #endregion

    #region Методы
    public override string ToString()
    {
        return $"================================\n" +
           $"|Фамилия: {this.SecondName}\n" +
           $"|Имя: {this.FirstName}\n" +
           $"|Отчество: {this.ThirdName}\n" +
           $"|Номер телефона: {this.PhoneNumber}\n" +
           $"|Серия паспорта: {this.PassportSeries}\n" +
           $"|Номер паспорта: {this.PassportNumber}\n" +
           $"================================\n";
    }

    public string ViewedBy(Employee employee)
    {
        string str = $"Фамилия: {this.SecondName}\n" +
                $"Имя: {this.FirstName}\n" +
                $"Отчество: {this.ThirdName}\n" +
                $"Номер телефона: {this.PhoneNumber}\n";
        if (employee is Consultant)
        {
            str += $"Серия паспорта: ******\n" +
                $"Номер паспорта: ****";
        }
        else
        {

        }
        return str;
    }
    #endregion
}
