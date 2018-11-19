using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HelloWorld_2
{
    class MyMain
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += WinMouseDown;
            //mainWindow.MouseDown += new MouseButtonEventHandler(WinMouseDown);
            //mainWindow.Show();

            for (int i = 0; i < 2; i++)
            {
                Window win = new Window();
                win.Title = "Extra Window No." + (i + 1);
                win.ShowInTaskbar = false;
                //win.Owner = mainWindow; mainWindow.Show(); 이후에 설정
                win.Show();
            }

            // WPF Samplw(Main) 윈도우를 맨 마지막에 띄움
            Application app = new Application();
            app.Run(mainWindow);
        }

        private static void WinMouseDown(object sender, MouseButtonEventArgs e)
        {
            Window win = new Window();
            win.Title = "Modal DialogBox";
            win.Width = 400;
            win.Height = 200;
            Button b = new Button();
            b.Content = "Click Me!";
            b.Click += Button_Click;
            win.Content = b;
            win.ShowDialog(); //Modal 형태
        }

        private static void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }

        //private void WinMouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    Window win = new Window();
        //    win.Title = "Modal DialogBox";
        //    win.Width = 400;
        //    win.Height = 200;
        //    Button b = new Button();
        //    b.Content = "Click Me!";
        //    b.Click += Button_Click;
        //    win.Content = b;
        //    win.ShowDialog(); //Modal 형태
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Button Click!", sender.ToString());
        //}
    }
}
