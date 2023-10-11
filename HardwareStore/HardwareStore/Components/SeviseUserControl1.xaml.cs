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

namespace HardwareStore.Components
{
    /// <summary>
    /// Логика взаимодействия для SeviseUserControl1.xaml
    /// </summary>
    public partial class SeviseUserControl1 
    {
        public SeviseUserControl1(Image image, string title, decimal cost, string costTime, string discount, Visibility costVisibility)
        {
            InitializeComponent();
            //ServaseIng = Image;
            TittleTb.Text = title;
            CostTimeTb.Text = cost.ToString(":0");
            DiscountTb.Text = discount;
            CostTb.Text = cost.ToString();
            CostTb.Visibility = costVisibility;

        }
    }
}
