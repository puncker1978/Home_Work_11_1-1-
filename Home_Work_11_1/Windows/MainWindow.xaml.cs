namespace Home_Work_11_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Repository repository;
        private Employee employee;
        public MainWindow(Employee employee)
        {
            InitializeComponent();
            repository = new Repository(20);
            list_clients.ItemsSource = repository.Clients;
            list_clients.SelectedIndex = 0;
            this.employee = employee;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

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

        }
    }
}
