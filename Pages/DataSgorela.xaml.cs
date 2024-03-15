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

namespace VAZ1403.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataSgorela.xaml
    /// </summary>
    public partial class DataSgorela : Page
    {
        public DataSgorela()
        {
            InitializeComponent();
            if (!Pomosch.listStudent.Any())
            {
                Student student1 = new Student()
                {
                    Id = 1,
                    FirstName = "Ilia",
                    LastName = "Benzikov",
                    Age = 18,
                    Mobila = "88005553535",
                    Stepuxa = 5928.01
                };
                Pomosch.listStudent.Add(student1);
                Student student2 = new Student()
                {
                    Id = 1,
                    FirstName = "Ilia",
                    LastName = "Benzikov",
                    Age = 17,
                    Mobila = "88005553535",
                    Stepuxa = 5928.01
                };
                Pomosch.listStudent.Add(student2);
                Student student3 = new Student()
                {
                    Id = 1,
                    FirstName = "Ilia",
                    LastName = "Benzikov",
                    Age = 16,
                    Mobila = "88005553535",
                    Stepuxa = 5928.01
                };
                Pomosch.listStudent.Add(student3);
                Student student4 = new Student()
                {
                    Id = 1,
                    FirstName = "Ilia",
                    LastName = "Benzikov",
                    Age = 15,
                    Mobila = "88005553535",
                    Stepuxa = 5928.01
                };
                Pomosch.listStudent.Add(student4);
                Student student5 = new Student()
                {
                    Id = 1,
                    FirstName = "Ilia",
                    LastName = "anekdot",
                    Age = 14,
                    Mobila = "88005553535",
                    Stepuxa = 5928.01
                };
                Pomosch.listStudent.Add(student5);
            }
            

            PStudents.ItemsSource = Pomosch.listStudent;
        }

        private void txtSearchLN_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = txtSearchLN.Text;
            if (search.Length > 0 ) 
            {
                PStudents.ItemsSource = Pomosch.listStudent.Where(x => x.LastName.ToLower().Contains(search.ToLower()));
            }
            else
            {
                PStudents.ItemsSource = Pomosch.listStudent;
            }
        }

        private void cmbFiltrAge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFiltrAge.SelectedIndex == 1) 
            {
                PStudents.ItemsSource = Pomosch.listStudent.Where(x=>x.Age >= 18);
            }
            else
            {
                PStudents.ItemsSource = Pomosch.listStudent;
            }
        }
    }
}
