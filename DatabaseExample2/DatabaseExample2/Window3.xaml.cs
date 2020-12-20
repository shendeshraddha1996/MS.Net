using DatabaseExample2.MyDataSetTableAdapters;
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

namespace DatabaseExample2
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        MyDataSet ds;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ds = new MyDataSet();
            DepartmentTableAdapter daDeps = new DepartmentTableAdapter();
            daDeps.Fill(ds.Department);

            EmployeeInfoTableAdapter daEmp = new EmployeeInfoTableAdapter();
            daEmp.Fill(ds.EmployeeInfo);
            dgEmps.ItemsSource = ds.EmployeeInfo.DefaultView;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmployeeInfoTableAdapter daEmp = new EmployeeInfoTableAdapter();
            daEmp.Update(ds.EmployeeInfo);
        }
    }
}
