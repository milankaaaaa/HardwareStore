using HardwareStore.Components;
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

namespace HardwareStore.MyPages
{
    /// <summary>
    /// Логика взаимодействия для ServiseListPage1.xaml
    /// </summary>
    public partial class ServiseListPage1 : Page
    {
        public ServiseListPage1()
        {
            InitializeComponent();
            var services = App.db.Sevice.ToList();
            foreach (var service in services)
            {
                ServiseWrapPanel.Children.Add(new SeviseUserControl1(new Image(), service.Title, service.Cost, service.CostTime.ToString(), service.Discount.ToString(), service.CostVisibility));
            }
        }
      
    }
}
