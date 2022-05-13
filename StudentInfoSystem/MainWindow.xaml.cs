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
using UserLogin;

namespace StudentInfoSystem
{
  
    public partial class MainWindow : Window
    {
        Student studenta = StudentData.TestStudents[0];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fillFieldWithData(Student students)
        {
            foreach (var item in mainGrid.Children)
            {
                if (item is TextBox)
                {
                    var textBox = (TextBox)item;
                    switch (textBox.Name)
                    {
                        case "txtFName":
                            {

                                textBox.Text = students.firstName;
                                break;
                            }
                        case "txtMName":
                            {
                                textBox.Text = students.middleName;
                                break;
                            }
                        case "txtLName":
                            {
                                textBox.Text = students.lastName;
                                break;
                            }
                        case "txtFac":
                            {
                                textBox.Text = students.facNum;
                                break;
                            }
                        case "txtSpec":
                            {
                                textBox.Text = students.speciality;
                                break;
                            }
                        case "txtOks":
                            {
                                textBox.Text = students.degree;
                                break;
                            }
                        case "txtStat":
                            {
                                textBox.Text = students.status;
                                break;
                            }
                        case "txtFNum":
                            {
                                textBox.Text = students.facNum;
                                break;
                            }
                        case "txtCourse":
                            {
                                textBox.Text = students.course.ToString();
                                break;
                            }
                        case "txtStream":
                            {
                                textBox.Text = students.stream.ToString();
                                break;
                            }
                        case "txtGroup":
                            {
                                textBox.Text = students.group.ToString();
                                break;
                            }
                    }
                }
            }
        }
        private void clearAllTxtBoxes()
        {
            foreach (var item in mainGrid.Children)
            {
                if (item is TextBox)
                {
                    var textBox = (TextBox)item;
                    textBox.Text = "";
                }
            }
        }

        private void enableOrDisableGridCtrls(bool isEnabled)
        {
            foreach (var item in mainGrid.Children)
            {
                UIElement element = item as UIElement;
                element.IsEnabled = isEnabled;
                if (element is Button)
                {
                    btnEnable.IsEnabled = true;
                }
            }
        }

        private void btnNames_Click(object sender, RoutedEventArgs e)
        {
            fillFieldWithData(studenta);
        }

        private void btnStudInfo_Click(object sender, RoutedEventArgs e)
        {
            fillFieldWithData(studenta);

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            clearAllTxtBoxes();
        }

        private void btnEnable_Click(object sender, RoutedEventArgs e)
        {
            enableOrDisableGridCtrls(true);
        }

        private void btnDisable_Click(object sender, RoutedEventArgs e)
        {
            enableOrDisableGridCtrls(false);
        }
    }
}
