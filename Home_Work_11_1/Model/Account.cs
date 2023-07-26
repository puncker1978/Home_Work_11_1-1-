namespace Home_Work_11_1.Model;

internal class Account
{
    #region Cвойства
    /// <summary>
    /// Уникальный идентификационный номер счёта
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Сумма на счёте
    /// </summary>
    public int Sum { get; set; }

    public Guid IdClient { get; set; }
    #endregion

    #region Конструкторы
    /// <summary>
    /// Банковский счёт с начальной суммой
    /// </summary>
    /// <param name="sum">Сумма на счёте</param>
    /// <param name="idClient">Уникальный идентификационный номер клиента</param>
    public Account(int sum, Guid idClient)
    {
        Id = new Guid();
        Sum = sum;
        IdClient = idClient;
    }
    #endregion
}