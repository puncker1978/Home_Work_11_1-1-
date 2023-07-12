namespace Home_Work_11_1.Model;

public abstract class Employee : Person, IClientDataMonitor
{
    #region Конструкторы
    /// <summary>
    /// Конструктор для инициализации сотрудника
    /// </summary>
    /// <param name="firstName">Имя</param>
    /// <param name="secondName">Фамилия</param>
    /// <param name="thirdName">Отчество</param>
    public Employee(string firstName,
                    string secondName,
                    string thirdName) : base(firstName, secondName, thirdName)
    {
    }
    #endregion

    #region Методы
    public override string ToString()
    {
        return $"Фамилия: {this.SecondName}\n" +
            $"Имя: {this.FirstName}\n" +
            $"Отчество: {this.ThirdName}\n";
    }

    public virtual string ViewClientData(Client client)
    {
        throw new NotImplementedException();
    }

    public virtual void EditClientData(Client oldClientData, Client newClientData)
    {
        throw new NotImplementedException();
    }

    #endregion
}
