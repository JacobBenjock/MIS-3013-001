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

namespace WpfStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {

            string firstName, lastName, color, id;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            color = txtFavoriteColor.Text;
            id = txtID.Text;

            Student newStudent = new Student();
            newStudent.FirstName = firstName;
            newStudent.LastName = lastName;
            newStudent.FavoriteColor = color;
            newStudent.StudentID = Convert.ToInt32(id);

            lstEnter.Items.Add(newStudent.ToString());

            txtFirstName.Clear();
            txtLastName.Clear();
            txtID.Clear();
            txtFavoriteColor.Clear();

        }
    }
}