namespace Home_Work_11_1.Model;

interface IClientDataMonitor
{
    string ViewClientData(Client client);

    void EditClientData(Client oldClientData, Client newClientData);
}
