using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public class DPTest : DependencyObject
    {
        //의존 속성을 정의
        public static readonly DependencyProperty TestProperty =
               DependencyProperty.Register(
                "Test",
                typeof(string),
                typeof(DPTest),
                new PropertyMetadata("Dependency Property Initial Value",
               OnTestPropertyChanged)); //Test 속성의 값이 바뀌면 OnTestPropertyChanged 호출
                                        //TestProperty라는 의존속성을 래핑하고 있는 일반 속성,
                                        //이값이 바뀜을 통지 받아서 OnTestPropertyChanged 메소드가 호출된다.
        public string Test
        {
            get
            {
                Debug.WriteLine("Test GetValue");
                return (string)GetValue(TestProperty);
            }
            set
            {
                Debug.WriteLine("Test SetValue");
                SetValue(TestProperty, value);
            }
        }


        private static void OnTestPropertyChanged(DependencyObject d,
               DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("Property Changed : {0}", e.NewValue);
        }

    }
}
