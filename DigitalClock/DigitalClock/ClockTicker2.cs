using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace DigitalClock
{
    public class ClockTicker2 : INotifyPropertyChanged
    {
        // INotyfyPropertyChanged 인터페이스가 요구하는 이벤트
        public event PropertyChangedEventHandler PropertyChanged;

        // public 프로퍼티, CLR Property
        public string DateTimeValue
        {
            get { return DateTime.Now.ToString("yyy-mm-dd hh:mm:ss"); }
        }

        // 생성자에서 Timer를 설정
        public ClockTicker2()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimerOnTick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new
               PropertyChangedEventArgs("DateTimeValue"));
            }
        }
    }
}
