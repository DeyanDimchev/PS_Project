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

namespace StudentInfoSystem
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
        private Student _student;
        public Student Student { 
            get 
            { 
                return _student;
            }
            set
            {
                if (_student == null)
                {
                    clearBoxes();
                    disableBoxes();
                }
                else
                {
                    enableBoxes();
                    displayStudent(_student);
                    
                }
            }
        }
        private void setButton_Click(object sender, RoutedEventArgs e)
        {
            _student = new Student("Deyan", "Dimitrov", "Dimchev",
                          "FKST", "ITI", "Bachelor's", "active", "501219028", 4, 9, 36);
            displayStudent(_student);//question?!

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void clearBoxes()
        {
            nameBox.Text = String.Empty;
            secondNameBox.Text = String.Empty;
            lastNameBox.Text = String.Empty;
            facultyBox.Text = String.Empty;
            fieldBox.Text = String.Empty;
            qualificationBox.Text = String.Empty;
            statusBox.Text = String.Empty;
            facultyNumBox.Text = String.Empty;
            yearBox.Text = String.Empty;
            streamBox.Text = String.Empty;
            groupBox.Text = String.Empty;
        }

        private void displayStudent(Student student)
        {
            MessageBox.Show(student.name);
            nameBox.Text = student.name;
            secondNameBox.Text = student.secondName;
            lastNameBox.Text = student.lastName;
            facultyBox.Text = student.faculty;
            fieldBox.Text = student.field;
            qualificationBox.Text = student.qualification;
            statusBox.Text = student.status;
            facultyNumBox.Text = student.facultyNum;
            yearBox.Text = student.year.ToString();
            streamBox.Text = student.stream.ToString();
            groupBox.Text = student.group.ToString();
        }

        private void disableBoxes()
        {
            nameBox.IsEnabled = false;
            secondNameBox.IsEnabled = false;
            lastNameBox.IsEnabled = false;
            facultyBox.IsEnabled = false;
            fieldBox.IsEnabled = false;
            qualificationBox.IsEnabled = false;
            statusBox.IsEnabled = false;
            facultyNumBox.IsEnabled = false;
            yearBox.IsEnabled = false;
            streamBox.IsEnabled = false;
            groupBox.IsEnabled = false;
        }

        private void enableBoxes()
        {
            nameBox.IsEnabled = true;
            secondNameBox.IsEnabled = true;
            lastNameBox.IsEnabled = true;
            facultyBox.IsEnabled = true;
            fieldBox.IsEnabled = true;
            qualificationBox.IsEnabled = true;
            statusBox.IsEnabled = true;
            facultyNumBox.IsEnabled = true;
            yearBox.IsEnabled = true;
            streamBox.IsEnabled = true;
            groupBox.IsEnabled = true;
        }


    }
}
