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

namespace WpfApp2
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add("Shraddha1");
            lstNames.Items.Add("Shraddha2");
            lstNames.Items.Add("Shraddha3");
        }

        private void btnAddData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lstNames.Items.Count.ToString());
            // MessageBox.Show(lstNames.SelectedItem.ToString());
            foreach (var item in lstNames.SelectedItems)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void btnRemData_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.RemoveAt(lstNames.SelectedIndex);
        }
    }
}
