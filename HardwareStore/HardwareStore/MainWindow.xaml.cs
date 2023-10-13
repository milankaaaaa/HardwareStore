using HardwareStore.MyPages;
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

namespace HardwareStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var path = @"C:\Users\222112\\Downloads\Task\\Сессия 1\services_s_import\"; 
            //foreach (var item in App.db.Service.ToArray())
            //{
            //    var fullPath = path + item.MainImage.Trim();
            //    var imageByte = File.ReadAllBytes(fullPath);
            //    item.MainImagePage = imageByte;
            //}
            //App.db.SaveChanges();

            MainFrame.Navigate(new ServiseListPage1());
        }
    }
} 