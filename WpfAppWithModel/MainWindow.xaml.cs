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
using WpfAppWithModel.ViewModel;
using WpfAppWithModel.Model;

namespace WpfAppWithModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM_Crop vM;

        public MainWindow()
        {
            vM = new VM_Crop(new Crop(Name = "Plant"));
            InitializeComponent();
            this.DataContext = vM;
        }

        private void btn_Grow_Click(object sender, RoutedEventArgs e)
        {
            vM.Height++;
        }

        private void btn_Harvest_Click(object sender, RoutedEventArgs e)
        {
            vM.Height--;
        }
    }
}
