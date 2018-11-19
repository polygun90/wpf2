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
using System.Windows.Shapes;

namespace CustomXamlButton
{
    /// <summary>
    /// UseCustomClass.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UseCustomClass : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new UseCustomClass());
        }
        public UseCustomClass()
        {
            InitializeComponent();

            //버튼 2개를 추가로 생성
            for (int i = 0; i < 2; i++)
            {
                CenteredButton b = new CenteredButton();
                b.Content = "Button " + (i + 1);
                mystack.Children.Add(b);
            }
        }
    }
}
