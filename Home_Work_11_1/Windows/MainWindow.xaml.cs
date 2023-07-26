namespace Home_Work_11_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Repository repository;
        public MainWindow(Employee employee)
        {
            InitializeComponent();
            repository = new Repository(20);
            list_clients.ItemsSource = repository.Clients;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void list_clients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
