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
    #endregion

    #region Конструкторы
    /// <summary>
    /// Банковский счёт с начальной суммой
    /// </summary>
    /// <param name="sum">начальная сумма на счёте</param>
    public Account(int sum)
    {
        Id = new Guid();
        Sum = sum;
    }
    #endregion
}