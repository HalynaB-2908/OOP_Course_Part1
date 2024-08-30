using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT2
{
    public class Stud
    {
        public string Name;
        int e1, e2, e3;
        public int Ex1 
        {
            set { e1 = value; }
            get { return e1; }  
        }
        public int Ex2
        {
            set { e2 = value; }
            get { return e2; }
        }
        public int Ex3
        {
            set { e3 = value; }
            get { return e3; }
        }
        public double AverGrade
        { 
            get { return (Convert.ToDouble(e1 + e2 + e3)) / 3; } 
        }
    }
}
