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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task4
{
    //Разработать окно добавления нового пациента в частной клинике. При добавлении учитывать валидацию всех полей.


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbGender.ItemsSource = new List<string>() { "М", "Ж" }; //Создание списка полов
            cmbGender.SelectedIndex = 0;
            cmbHospital.ItemsSource = new List<string>() { "Клиника им. Менгельса", "Скотобойня" }; //Список БОЛЬниц
            cmbHospital.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Проверки на пустоты
                if (String.IsNullOrEmpty(tbName.Text))
                {
                    MessageBox.Show("Поле имя Пустое");
                    return; //Возвращает обратно
                }
                if (String.IsNullOrEmpty(tbSurename.Text))
                {
                    MessageBox.Show("Поле фамилия Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(tbPhone.Text))
                {
                    MessageBox.Show("Поле телефон Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(dpDate.Text))
                {
                    MessageBox.Show("Поле дата рождения Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(tbSocial.Text))
                {
                    MessageBox.Show("Поле полис пустое");
                    return;
                }

                //Проверки на длинну
                if (tbSocial.Text.Length != 6)//У полиса много цифр, но мне лень каждый раз их вводить
                {
                    MessageBox.Show("Полис неверный");
                    return;
                }
                if (tbPhone.Text.Length != 11)
                {
                    MessageBox.Show("Телефон неверный");
                    return;
                }

                //Проверки на спец.символы
                if (!tbName.Text.All(Char.IsLetter)) //Запрос LINQ, является ли текст буквами (Внимание на восклицательный знак)
                {
                    MessageBox.Show("Поле имя содержит недопустимые символы");
                    return;
                }
                if (!tbSurename.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Поле фамилия содержит недопустимые символы");
                    return;
                }
                if (!tbPhone.Text.All(Char.IsDigit)) //Запрос LINQ, является ли текст цифрами (Внимание на восклицательный знак)
                {
                    MessageBox.Show("Поле телефон содержит недопустимые символы");
                    return;
                }
                if (!tbSocial.Text.All(Char.IsDigit)) //Запрос LINQ, является ли текст цифрами (Внимание на восклицательный знак)
                {
                    MessageBox.Show("Поле полис содержит недопустимые символы");
                    return;
                }


                //Проверка даты (Делать только если он докапается)
                DateTime dateTime = Convert.ToDateTime(dpDate.Text); //Создаём дату из текста datepicker'a
                if (dateTime > DateTime.Now || DateTime.Now.Year - dateTime.Year < 18) //Проверка на то, чтоб дата была до сегодня и человеку было 18
                {
                    MessageBox.Show("Некорректная дата");
                    return;
                }
                MessageBox.Show("Клиент добавлен"); //Имитация добавления
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
