using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main1(string[] args)
        {

            Func<decimal, decimal, decimal, decimal> simpleInterst = (a,b,c) =>
              {
                  decimal d = a * b * c / 100;
                  return d;
              };
            Console.WriteLine( simpleInterst(10000,5,3));

            Func<int, int,bool > IsGreatter = (a, b) =>
             {
                 bool rr;
                 if (a > b)
                   {
                      rr = true;
                     return rr;
                 }
                 else
                 {  
                     rr = false;
                     return rr;
                 }
                
             };
            Console.WriteLine(IsGreatter(12,11));


            Func<int, bool> IsEven = (a) =>
             { bool t;
                 if(a%2==0)
                 {
                     return t = true; 
                 }
                 else
                 {
                     return t = false;
                 }

             };

            Console.WriteLine(IsEven(16));


            Console.ReadLine();
        }

        static void Main()
        {
            employee e = new employee("satish",999,12);

            //basic salary of empolyee
            Func<employee,decimal> getBasic = (r) =>
            { 
                return r.Basic;
            };
            Console.WriteLine(getBasic(e));


            //if basic salary is greatter than 1000 then return true

            Func<employee, bool> GreaterBasic = (y) =>
                {
                    bool prp;
                    if (y.Basic > 999)
                    {
                        prp = true;
                        return prp;
                    }
                    else
                    {
                        prp = false;
                        return prp;
                    }
                };

            Console.WriteLine( GreaterBasic(e));
            Console.ReadLine();
        }

    }

    public class employee
    {
        private String name;
        public String Name
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("invallid entry in String name");
                }
                else
                {
                    name = value;
                }
            }

            get
            {
                return name;
            }

        }

        private static int dd = 1;
        private int empno;
        public int EmpNo
        {
            private set
            {
                empno = value;
            }
            get
            {
                return empno;
            }

        }
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 10 && value < 10000)
                {
                    basic = value;
                }
                else
                {

                    Console.WriteLine("not allowed values in basic part");
                }
            }

            get
            {

                return basic;
            }
        }

        private short deptno;
        public short Deptno
        {
            set
            {
                if (value > 0)
                {
                    deptno = value;
                }
            }
            get
            {
                return deptno;
            }
        }

        public employee()
        {
            this.EmpNo = dd++;
        }

        public employee(String name, decimal basic, short deptno)
        {
            this.Deptno = deptno;
            this.Name = name;
            this.Basic = basic;
            this.EmpNo = dd++;
        }
        public employee(String name, decimal basic)
        {
            this.Name = name;
            this.Basic = basic;
            this.EmpNo = dd++;
        }
        public employee(String name)
        {
            this.Name = name;
            this.EmpNo = dd++;
        }

        public int getnetsalary()
        {
            int netsalary = (int)basic + 1000;
            return netsalary;
        }
    }
}
