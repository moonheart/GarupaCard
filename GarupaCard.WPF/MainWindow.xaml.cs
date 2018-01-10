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
using GarupaCard.Shared.Models;

namespace GarupaCard.WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetImageList();
        }

        private void GetImageList()
        {
            var list = UserInfo.Instance.AllCards.ToList();
            ListBox1.ItemsSource = list;
        }

        private void Image_OnImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            
        }
    }
}
