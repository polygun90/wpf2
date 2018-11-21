using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace INotifyTest
{
    public class Person : INotifyPropertyChanged
    {
        private string name;

        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;

        public Person() { }

        public Person(string value) { this.name = value; }

        public string PersonName
        {
            get { return name; }
            set
            {
                name = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

}
