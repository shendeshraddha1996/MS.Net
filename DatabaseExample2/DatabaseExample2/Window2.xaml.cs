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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        DataSet ds;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EmployeeInfo";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds,"Emps");

            cmd.CommandText = "select * from Department";
            da.Fill(ds, "Deps");
            //dgEmp.ItemsSource = ds.Tables[0];

            //primary key Validation
            DataColumn[] arrCols = new DataColumn[1];
            arrCols[0] = ds.Tables["Emps"].Columns["EmpNo"];
            ds.Tables["Emps"].PrimaryKey = arrCols;

            //foreign key Validation
            ds.Relations.Add(ds.Tables["Deps"].Columns["DeptNo"], ds.Tables["Emps"].Columns["DeptNo"]);

            dgEmp.ItemsSource = ds.Tables["Emps"].DefaultView;
            cn.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";
            cn.Open();

            //Update Command
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = cn;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = "update EmployeeInfo set EmpName=@EmpName,EmpSalary=@EmpSalary,Deptno=@DeptNo  where EmpNo=@EmpNo";

            //SqlParameter p = new SqlParameter();
            //p.ParameterName = "@EmpName";
            //p.SourceColumn = "EmpName";
            //p.SourceVersion = DataRowVersion.Current;
            //cmdUpdate.Parameters.Add(p);

            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpName", SourceColumn = "EmpName", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpSalary", SourceColumn = "EmpSalary", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

            //insert Command
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = "Insert into EmployeeInfo(EmpNo,EmpName,EmpSalary,DeptNo) values ( @EmpNo,@EmpName,@EmpSalary,@DeptNo)";
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpName", SourceColumn = "EmpName", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpSalary", SourceColumn = "EmpSalary", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });

            //Delete Command
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = cn;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = "Delete from EmployeeInfo where EmpNo= @EmpNo";
            cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original});
            cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpName", SourceColumn = "EmpName", SourceVersion = DataRowVersion.Original });
            cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpSalary", SourceColumn = "EmpSalary", SourceVersion = DataRowVersion.Original});
            cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Original });




            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = cmdUpdate;
            da.InsertCommand = cmdInsert;
            da.DeleteCommand = cmdDelete;

           // da.ContinueUpdateOnError = true;

            da.Update(ds, "Emps");
           
            cn.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";
            cn.Open();

            //Update Command
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = cn;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = "update EmployeeInfo set EmpName=@EmpName,EmpSalary=@EmpSalary,Deptno=@DeptNo  where EmpNo=@EmpNo";

            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpName", SourceColumn = "EmpName", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpSalary", SourceColumn = "EmpSalary", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

            //insert Command
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = "Insert into EmployeeInfo(EmpNo,EmpName,EmpSalary,DeptNo) values ( @EmpNo,@EmpName,@EmpSalary,@DeptNo)";
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpName", SourceColumn = "EmpName", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpSalary", SourceColumn = "EmpSalary", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });

            //Delete Command
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = cn;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = "Delete from EmployeeInfo where EmpNo= @EmpNo";
            cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });
            cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpName", SourceColumn = "EmpName", SourceVersion = DataRowVersion.Original });
            cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpSalary", SourceColumn = "EmpSalary", SourceVersion = DataRowVersion.Original });
            cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Original });

            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = cmdUpdate;
            da.InsertCommand = cmdInsert;
            da.DeleteCommand = cmdDelete;

            DataSet ds2 = ds.GetChanges();
            // DataSet ds2 = ds.GetChanges(DataRowState.Modified);

            da.Update(ds, "Emps");

           // ds.AcceptChanges();ds.RejectChanges();{undo the changes}
            cn.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //DataView dv = new DataView(ds.Tables["Emps"]);
            //dv.RowFilter = "DeptNo= "+ txtDeptNo.txt;
            //dv.Sort = "";
            //dgEmp.ItemsSource =dv;

            ds.Tables["Emps"].DefaultView.RowFilter= "DeptNo= " + txtDeptNo.Text;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(ds.GetXml());
            //MessageBox.Show(ds.GetXmlSchema());

            //save dataset to a file
            ds.WriteXmlSchema("a.xsd");
            ds.WriteXml("a.xml",XmlWriteMode.DiffGram);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ds = new DataSet();
            ds.ReadXmlSchema("a.xsd");
            ds.ReadXml("a.xml",XmlReadMode.DiffGram);
            dgEmp.ItemsSource = ds.Tables["Emps"].DefaultView;
        }
    }
}
//dataset=Disconnected xml set of records