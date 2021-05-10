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
using System.Collections.ObjectModel;

namespace CollectionListObservable3
{
    public partial class MainWindow : Window
    {

        ObservableCollection<string> phones;
        public MainWindow()
        {
            InitializeComponent();

            phones = new ObservableCollection<string> { "iPhone 6S Plus", "Nexus 6P", "Galaxy S7 Edge" };


             phonesList.ItemsSource = phones;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string phone = phoneTextBox.Text;
            // добавление нового объекта
            phones.Add(phone);
            phonesList.ItemsSource = phones;
        }
    }
}
