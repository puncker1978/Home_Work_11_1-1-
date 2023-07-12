namespace Home_Work_11_1.Model;

public class Manager : Employee
{
    #region Конструкторы
    public Manager(string firstName,
        string secondName,
        string thirdName) : base(firstName, secondName, thirdName)
    {
    }

    #endregion

    #region Методы
    public override void EditClientData(Client oldClientData, Client newClientData)
    {
        oldClientData = newClientData;
    }

    public override string ViewClientData(Client client)
    {
        string str = "";
        str += $"Данные о клиенте:\n" +
            $"Фамилия: {client.SecondName}\n" +
            $"Имя: {client.FirstName}\n" +
            $"Отчество: {client.ThirdName}\n" +
            $"Номер телефона: {client.PhoneNumber}\n" +
            $"Серия паспорта: {client.PassportSeries}\n" +
            $"Номер паспорта: {client.PassportNumber}";
        return str;
    }
    #endregion
}
