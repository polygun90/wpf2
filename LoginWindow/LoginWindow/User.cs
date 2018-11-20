using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoginWindow
{
    public class User : INotifyPropertyChanged
    {
        private string _fisrtname;
        public string FirstName
        {
            get
            {
                return _fisrtname;
            }
            set
            {
                _fisrtname = value;
                RaisePropertyChange();
            }
        }

        private string _lastname;
        public event PropertyChangedEventHandler PropertyChanged;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                RaisePropertyChange();
            }
        }

        private void RaisePropertyChange([CallerMemberName] string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }

}
