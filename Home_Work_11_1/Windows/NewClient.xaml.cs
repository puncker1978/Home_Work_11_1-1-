using Home_Work_11_1.Model.Repositories;
using System.Drawing;
using System.Windows.Media;

namespace Home_Work_11_1;

/// <summary>
/// Логика взаимодействия для NewClient.xaml
/// </summary>
public partial class NewClient : Window
{
    private Client client;
    Passport passport;
    Address address;
    Account account;
    ClientsRepository repository = MainWindow.repository;
    Guid idAccount;
    

    public NewClient()
    {
        InitializeComponent();
        idAccount = Guid.NewGuid();
        id_account.Text = idAccount.ToString();
        birthday.Text = DateTime.Now.ToString();
        birthday.Foreground = Brushes.DarkRed;
        birthday.FontWeight = FontWeights.Bold;
    }

    private void SaveNewClient_Click(object sender, RoutedEventArgs e)
    {
        passport = new(passport_series.Text, passport_number.Text, (DateTime)birthday.SelectedDate);
        address = new(town.Text, street.Text, house.Text, int.Parse(apartment.Text));

        Guid idClient = Guid.NewGuid();
        account = new(idClient, int.Parse(cashless.Text));

        client = new(first_name.Text, second_name.Text, third_name.Text, phone_number.Text,
            passport, address, account);

        repository.Clients.Add(client);

        this.Close();
    }
}
