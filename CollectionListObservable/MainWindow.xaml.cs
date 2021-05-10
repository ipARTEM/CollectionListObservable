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

namespace CollectionListObservable
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty PhoneProperty;

        public Phone MyPhone { get; set; }

        public Phone Phone
        {
            get { return (Phone)GetValue(PhoneProperty); }
            set { SetValue(PhoneProperty, value); }
        }
        static MainWindow()
        {
            PhoneProperty = DependencyProperty.Register(
                "Phone",
                typeof(Phone),
                typeof(MainWindow));
        }


        public MainWindow()
        {
            InitializeComponent();

            MyPhone = new Phone
            {
                Name = "Lumia 630",
                Company = new Company { Title = "Microsoft" },
                Price = 1000
            };
            this.DataContext = MyPhone;
        }
    }
    
}
