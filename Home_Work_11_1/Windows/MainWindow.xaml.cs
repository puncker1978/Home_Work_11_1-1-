namespace Home_Work_11_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Repository repository;
        private Employee employee;
        private Client client;
        public MainWindow(Employee employee)
        {
            InitializeComponent();
            repository = new Repository(20);
            list_clients.ItemsSource = repository.Clients;
            this.employee = employee;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (list_clients.SelectedItem != null && list_clients.SelectedItem is Client)
            {
                Client client = list_clients.SelectedItem as Client;
                NewClient newClient = new(employee, client);
                newClient.Show();
                this.Close();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (list_clients.SelectedItem != null)
            {
                if (list_clients.SelectedItem is Client client)
                {
                    repository.Clients.Remove(client);
                }
            }
        }

        /// <summary>
        /// Метод поиска клиента по фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (search.Text!="" && search.Text != null)
            {
                list_clients.ItemsSource = repository.Clients.Where(Item => Item.SecondName == search.Text).ToList();
            }
            else
            {
                MessageBox.Show("Строка для поиска пуста");
            }
        }

        private void list_clients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        private void sortByAscending_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sortByDescending_Click(object sender, RoutedEventArgs e)
        {

        }

        private void newClient_Click(object sender, RoutedEventArgs e)
        {
            NewClient newClient = new(employee, client);
            newClient.Show();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            list_clients.ItemsSource=repository.Clients;
        }
    }
}
