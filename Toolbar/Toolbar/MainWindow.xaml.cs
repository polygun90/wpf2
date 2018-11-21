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

namespace Toolbar
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<String> list = new List<string>();
            InitializeComponent();
            list.Add("서울");
            list.Add("대전");
            list.Add("춘천");
            list.Add("제주");
            toolbar.ItemsSource = list;
        }
        public void ButtonClick(object sender, EventArgs args)
        {
            MessageBox.Show(((Button)sender).Content.ToString());
        }
    }
}
