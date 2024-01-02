using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace Sockets
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() { InitializeComponent(); }
        public static string index1 = "115547", index2 = "121170", index3 = "125009";
        public static string[] indexes = { index1, index2, index3 };
        public static List<string> places = new List<string>();
        private void button_Click(object sender, RoutedEventArgs e) { Check_in.Check_in_(box, list_box, places,
            indexes); }
    }
}