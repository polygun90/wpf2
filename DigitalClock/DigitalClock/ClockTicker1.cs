using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace DigitalClock
{
    public class ClockTicker1 : DependencyObject
    {
        // 의존 프로퍼티 선언
        public static DependencyProperty DateTimeProperty =
        DependencyProperty.Register("DateTimeValue", typeof(string),
        typeof(ClockTicker1));

        // CLR property로 의존 프로퍼티를 노출
        public string DateTimeValue
        {
            set { SetValue(DateTimeProperty, value); }
            get { return (string)GetValue(DateTimeProperty); }
        }

        // 생성자.
        public ClockTicker1()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimerOnTick;
            timer.Interval = TimeSpan.FromSeconds(1); //1초에 한번씩
            timer.Start();
        }

        // DateTime property 값을 설정하기 위한 Timer 이벤트 핸들러
        void TimerOnTick(object sender, EventArgs args)
        {
            DateTimeValue = DateTime.Now.ToString("yyy-mm-dd hh:mm:ss");
        }
    }
}
