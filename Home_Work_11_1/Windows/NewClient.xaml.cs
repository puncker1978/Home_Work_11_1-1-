using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
namespace Home_Work_11_1
{
    /// <summary>
    /// Логика взаимодействия для NewClient.xaml
    /// </summary>
    public partial class NewClient : Window
    {
        Client client;
        public NewClient(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void NewClient_Click(object sender, RoutedEventArgs e)
        {           
                second_name.Text = client.SecondName;
                first_name.Text = client.FirstName;
                third_name.Text = client.ThirdName;
                phone_number.Text = client.PhoneNumber;
                passport_series.Text = client.PassportSeries;
                passport_number.Text = client.PassportNumber;
        }
    }
}
