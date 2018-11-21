using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBinding
{
    public class Emps : ObservableCollection<Emp>
    {
        internal Emps()
        {
            Add(new Emp() { Ename = "SMITH", Job = "Salesman" });
            Add(new Emp() { Ename = "KING", Job = "Manager" });
            Add(new Emp() { Ename = "FORD", Job = "CLERK" });
            Add(new Emp() { Ename = "JOHN", Job = "CLERK" });
        }    }

    public class Emp
    {
        public string Ename { get; set; }
        public string Job { get; set; }
    }
}
