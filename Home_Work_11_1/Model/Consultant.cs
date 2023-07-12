namespace Home_Work_11_1.Model;

public class Consultant : Employee
{
    #region Конструкторы
    public Consultant(string firstName,
        string secondName,
        string thirdName) : base(firstName,
            secondName, thirdName)
    {
    }
    #endregion

    #region Методы

    public override void EditClientData(Client oldClientData, Client newClientData)
    {
        //Консультант может изменить только номер телефона
        oldClientData.PhoneNumber = newClientData.PhoneNumber;
    }

    public override string ViewClientData(Client client)
    {
        string str = "";
        str += $"Данные о клиенте:\n" +
            $"Фамилия: {client.SecondName}\n" +
            $"Имя: {client.FirstName}\n" +
            $"Отчество: {client.ThirdName}\n" +
            $"Номер телефона: {client.PhoneNumber}\n" +
            $"Серия паспорта: ****\n" +
            $"Номер паспорта: ******";
        return str;
    }
    #endregion
}
