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
using System.Text.RegularExpressions;

namespace zad1
{
    public partial class StudentWindow : Window
    {
        public Student student;
        public StudentWindow(Student student = null)
        {
            InitializeComponent();

            if(student != null)
            {
                tbImie.Text = student.imie;
                tbNazwisko.Text = student.nazwisko;
                tbNrAlbumu.Text = student.nrIndeksu.ToString();
                tbWydzial.Text = student.wydzial;
            }
            this.student = student ?? new Student();
        }

        public StudentWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (student != null)
            {
                student.imie = tbImie.Text;
                student.nazwisko = tbNazwisko.Text;
                student.nrIndeksu = int.Parse(tbNrAlbumu.Text);
                student.wydzial = tbWydzial.Text;
                this.DialogResult = true;
            } else
            {
                this.student = student ?? new Student();
                student.imie = tbImie.Text;
                student.nazwisko = tbNazwisko.Text;
                student.nrIndeksu = int.Parse(tbNrAlbumu.Text);
                student.wydzial = tbWydzial.Text;
                this.DialogResult = true;
            }
        }
    }
}
