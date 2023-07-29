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
    /// Банковский счёт клиента с уникальным идентификационным номером id
    /// с начальной суммой sum
    /// </summary>
    /// <param name="sum">Сумма на счёте клиента</param>
    /// <param name="id">Уникальный идентификационный номер счёта клиента</param>
    public Account(Guid id, int sum)
    {
        Id = id;
        Sum = sum;
        IdClient = Guid.NewGuid();
    }
    #endregion
}