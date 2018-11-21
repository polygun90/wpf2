using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingSortExam
{
    public class Emps : ObservableCollection<Emp>
    {
        public Emps()
        {
            Add(new Emp() { Empno = 1, Ename = "김길동", Job = "Salesman" });
            Add(new Emp() { Empno = 2, Ename = "박길동", Job = "Clerk" });
            Add(new Emp() { Empno = 3, Ename = "정길동", Job = "Clerk" });
            Add(new Emp() { Empno = 4, Ename = "남길동", Job = "Clerk" });
            Add(new Emp() { Empno = 5, Ename = "황길동", Job = "Salesman" });
            Add(new Emp() { Empno = 6, Ename = "홍길동", Job = "Manager" });
        }
    }
}
