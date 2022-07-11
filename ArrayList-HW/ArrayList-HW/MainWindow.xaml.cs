using System;
using System.Collections;
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

namespace ArrayList_HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void DataBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(DataBox.Text);
            MessageBox.Show("Add : "+DataBox.Text+"\n"+" Completed");
            DataBox.Text = "";

        }


        private void RemoveButton_Click_1(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(DataBox.Text);
            MessageBox.Show("Remove : " + DataBox.Text + "\n"+ " Completed");
            DataBox.Text = "";

        }


        private void ShowALlButton_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (string data in arrayList)
            {
                MessageBox.Show(data);
            }
        }

        private void DataBox_GotFocus(object sender, RoutedEventArgs e)
        {
            DataBox.Text = "";
        }

        private void DataBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (DataBox.Text == "")
            {
                DataBox.Text = "Fill in something";
            }
        }
    }
}
