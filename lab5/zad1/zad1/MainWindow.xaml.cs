using System;
using System.IO;
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

namespace zad1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> ListaStudentow { get; set; }
        public MainWindow()
        {
            ListaStudentow = new List<Student>()
            {
                new Student(){ imie="Jan", nazwisko="Kowalski", nrIndeksu=1234, wydzial="KIS"},
                new Student(){ imie="Anna", nazwisko="Nowak", nrIndeksu=4321, wydzial="KIS"},
                new Student(){ imie="Michał", nazwisko="Jacek", nrIndeksu=5678, wydzial="KIS"},
            };

            InitializeComponent();

            dgStudents.Columns.Add(new DataGridTextColumn() { Header = "Imię", Binding = new Binding("imie") });
            dgStudents.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("nazwisko") });
            dgStudents.Columns.Add(new DataGridTextColumn() { Header = "Nr indeksu", Binding = new Binding("nrIndeksu") });
            dgStudents.Columns.Add(new DataGridTextColumn() { Header = "Wydzial", Binding = new Binding("wydzial") });

            dgStudents.AutoGenerateColumns = false;
            dgStudents.ItemsSource = ListaStudentow;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();

            if(dialog.ShowDialog() == true)
            {
                ListaStudentow.Add(dialog.student);
                dgStudents.Items.Refresh();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (dgStudents.SelectedItem is Student)
                ListaStudentow.Remove((Student)dgStudents.SelectedItem);
            dgStudents.Items.Refresh();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(dgStudents);
            sw.Close();
        }

    }
}
