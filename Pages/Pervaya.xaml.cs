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
using VAZ1403.Classess;
using VAZ1403.Pages;

namespace VAZ1403
{
    /// <summary>
    /// Логика взаимодействия для Pervaya.xaml
    /// </summary>
    public partial class Pervaya : Page
    {
        public Pervaya()
        {
            InitializeComponent();
        }

        private void bDataGorit(object sender, RoutedEventArgs e)
        {
            Pomosch.frame.Navigate(new DataSgorela());
        }
    }
}
