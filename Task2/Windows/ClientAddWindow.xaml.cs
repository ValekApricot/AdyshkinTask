using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Task2.Classes;
using static Task2.Classes.ClassHelper;

namespace Task2.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientAddWindow.xaml
    /// </summary>
    public partial class ClientAddWindow : Window
    {
        public ClientAddWindow()
        {
            InitializeComponent();
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbFirstName.Text))
            {
                MessageBox.Show("Имя не может быть пустым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbLastName.Text))
            {
                MessageBox.Show("Фамилия не может быть пустой");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbNumber.Text))
            {
                MessageBox.Show("Номер телефона не может быть пустым");
                return;
            }
            bool result = long.TryParse(TbNumber.Text, out var number);//Проверка на инт
            if (result != true || Convert.ToInt64(TbNumber.Text) < 0)
            {
                MessageBox.Show(Convert.ToInt64(TbNumber.Text) + "");
                MessageBox.Show("Номер телефона должна быть заполнена числами");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbEmail.Text))
            {
                MessageBox.Show("Почта не может быть пустой");
                return;
            }
            else
            {
                Client client = new Client();
                client.FirstName = TbFirstName.Text;
                client.LastName = TbLastName.Text;
                client.MiddleName = TbMiddleName.Text;
                client.Number = TbNumber.Text;
                client.Email = TbEmail.Text;
                client.Gender = CbGender.Text;
                TbFirstName.Text = null;
                TbLastName.Text = null;
                TbMiddleName.Text = null;
                TbNumber.Text = null;
                TbEmail.Text = null;
                CbGender.SelectedIndex = 0;
                clients.Add(client);
                MessageBox.Show("Клиент добавлен");
            }
        }
    }
}
