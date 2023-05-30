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
using Task5.Classes;
using static Task5.Classes.ClassHelper;

namespace Task5.Windows
{
    /// <summary>
    /// Логика взаимодействия для PetAddWindow.xaml
    /// </summary>
    public partial class PetAddWindow : Window
    {
        public PetAddWindow()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbName.Text))
            {
                MessageBox.Show("Кличка не может быть пустой");
                return;
            }
            else
            {
                Pet pet = new Pet();
                pet.Name = TbName.Text;
                pet.Kind = CbKind.Text;
                pet.Gender = CbGender.Text;

                TbName.Text = null;
                CbKind.SelectedIndex = 0;
                CbGender.SelectedIndex = 0;

                pets.Add(pet);
                MessageBox.Show("Питомец добавлен");
            }
        }
    }
}
