namespace Home_Work_11_1;

/// <summary>
/// Логика взаимодействия для NewClient.xaml
/// </summary>
public partial class NewClient : Window
{
    Employee employee;
    Client client;
    public NewClient(Employee employee, Client client)
    {
        InitializeComponent();
        this.employee = employee;
        this.client = client;
    }

    private void NewClient_Click(object sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new(employee);
        this.Close();
        mainWindow.Show();
    }
}
