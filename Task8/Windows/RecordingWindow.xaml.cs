using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
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
using Task8.Classes;
using static Task8.Classes.ClassHelper;

namespace Task8.Windows
{
    /// <summary>
    /// Логика взаимодействия для RecordingWindow.xaml
    /// </summary>
    public partial class RecordingWindow : Window
    {
        public RecordingWindow()
        {
            InitializeComponent();
            LVOrder.ItemsSource = recordings;
        }

    }
}
