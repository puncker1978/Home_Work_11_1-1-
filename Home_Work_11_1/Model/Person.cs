namespace Home_Work_11_1.Model;

public abstract class Person
{
    #region Свойства
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string SecondName { get; set; }

    /// <summary>
    /// Отчество
    /// </summary>
    public string ThirdName { get; set; }
    #endregion

    #region Конструкторы
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="firstName">Имя</param>
    /// <param name="secondName">Фамилия</param>
    /// <param name="thirdName">Отчество</param>
    public Person(string firstName, string secondName, string thirdName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        this.ThirdName = thirdName;
    }
    #endregion
}
