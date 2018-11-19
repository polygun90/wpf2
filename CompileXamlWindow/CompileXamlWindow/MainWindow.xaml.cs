using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CompileXamlWindow
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //필드초기화 후 이벤트 핸들러를 가지고 오기 위한 메소드 호출
            InitializeComponent();
            //브러시 이름으로 ListBox를 채움
            foreach (PropertyInfo prop in typeof(Brushes).GetProperties())
                lstbox.Items.Add(prop.Name);
        }

        private void ButtonOnClick(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            MessageBox.Show(b.Content.ToString());
        }

        private void ListBoxOnSelection(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            string items = listBox.SelectedItem as string;
            PropertyInfo pInfo = typeof(Brushes).GetProperty(items);
            elips.Fill = (Brush)pInfo.GetValue(null, null);
        }
    }
}
