namespace Home_Work_11_1.Model.Repositories;

public class Account
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

    /// <summary>
    /// Уникальный идентификационный номер клиента
    /// </summary>
    public Guid IdClient { get; set; }
    #endregion

    #region Конструкторы
    /// <summary>
    /// Банковский счёт клиента с уникальным идентификационным номером idClient
    /// с начальной суммой sum
    /// </summary>
    /// <param name="sum">Сумма на счёте</param>
    /// <param name="idClient">Уникальный идентификационный номер клиента</param>
    public Account(Guid idClient, int sum)
    {
        Id = Guid.NewGuid();
        Sum = sum;
        IdClient = idClient;
    }
    #endregion
}