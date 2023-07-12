namespace Home_Work_11_1
{
    
    public partial class AuthorizationWindow : Window
    {

        Employee? employee;
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            string position = cbPosition.Text;
            if (position != "")
            {
                if (position == "Консультант")
                {
                    employee = new Consultant("Алексей", "Быков", "Владимирович");
                    MainWindow mainWindow = new(employee);
                    //mainWindow.second_name.IsReadOnly = true;
                    //mainWindow.first_name.IsReadOnly = true;
                    //mainWindow.third_name.IsReadOnly = true;
                    //mainWindow.phone_number.IsReadOnly = false;
                    //mainWindow.passport_series.IsReadOnly = true;
                    //mainWindow.passport_number.IsReadOnly = true;
                    //mainWindow.btn_NewClient.IsEnabled = false;
                    //mainWindow.btn_Change.IsEnabled = false;
                    MessageBox.Show($"Вы вошли под учётной записью: {position}\n" +
                        $"Добрый день, {employee.SecondName} {employee.FirstName} {employee.ThirdName}!");
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    employee = new Manager("Виктор", "Ильин", "Сергеевич");
                    MainWindow mainWindow = new(employee);
                    //mainWindow.second_name.IsReadOnly = false;
                    //mainWindow.first_name.IsReadOnly = false;
                    //mainWindow.third_name.IsReadOnly = false;
                    //mainWindow.phone_number.IsReadOnly = false;
                    //mainWindow.passport_series.IsReadOnly = false;
                    //mainWindow.passport_number.IsReadOnly = false;
                    //mainWindow.btn_NewClient.IsEnabled = true;
                    //mainWindow.btn_Change.IsEnabled = false;
                    MessageBox.Show($"Вы вошли под учётной записью: {position}\n" +
                        $"Добрый день, {employee.SecondName} {employee.FirstName} {employee.ThirdName}!");
                    mainWindow.Show();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Вы должны выбрать должность");
            }
        }
    }
}