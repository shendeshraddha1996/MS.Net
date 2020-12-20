using DatabaseExample2.MyDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true");
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //cn.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            cn.Open();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = cn;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = "select * from EmployeeInfo";

            da.SelectCommand = cmdSelect;
            da.Fill(ds, "Emps");

            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = "Select* from Department";
            da.Fill(ds, "Deps");

            DepartmentTableAdapter daDeps = new DepartmentTableAdapter();
            daDeps.Fill(mds.Department);
            EmployeeInfoTableAdapter daEmps = new EmployeeInfoTableAdapter();
            daEmps.Fill(mds.EmployeeInfo);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var recs = ds.Tables["Emps"].AsEnumerable();

            //recs have collection of data row

            //emp is single row in datarow collection

            //var emps = from emp in recs
            //           where emp.Field<Decimal>("Basic") > 1000
            //           select emp;

            var emps = from emp in recs
                       where emp.Field<int>("DeptNo") > 30
                       select emp;

            DataTable dt = emps.CopyToDataTable();

            
            dataGridView1.ItemsSource = dt.DefaultView;


        }

        MyDataSet mds = new MyDataSet();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            var recs = mds.EmployeeInfo.AsEnumerable();
            var emps = from emp in recs
                       where emp.EmpSalary > 4000
                       select emp;
            DataTable dt = emps.CopyToDataTable();

            dataGridView1.ItemsSource= dt.DefaultView;
        }
    }
}
