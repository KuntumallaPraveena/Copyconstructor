using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copyconstructor
{
    class Employ
    {
        int eno;
        string ename;
        double esal;
        internal Employ(int eno,string ename,double esal)
        {
            this.eno = eno;
            this.ename = ename;
            this.esal = esal;
        }
        internal Employ(Employ obj)  //Copy Constructor
        {
            //This is a copy constructor, it creates a new Employ object by copying values from an existing Employ object.
            eno = obj.eno;
            ename=obj.ename;
            esal=obj.esal;
        }
        internal void Display()
        {
            Console.WriteLine("Employee ID:" + eno);
            Console.WriteLine("Employee name:" + ename);
            Console.WriteLine("Employee salary" + esal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ e1 = new Employ(101,"Devi",30000);
            Employ e2 = new Employ(102, "Karan", 40000);
            e1.Display();
            e2.Display();
            Employ e3 = new Employ(e1);
            e3.Display();
        }
    }
}
