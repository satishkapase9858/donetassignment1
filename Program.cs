using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            employee[] e = new employee[3] ;
            for (int i = 0; i <e.Length   ; i++) {

                Console.WriteLine("enter the name of employee");
                string name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("enter the basic of employee");
                decimal basic = Convert.ToDecimal (Console.ReadLine());


                Console.WriteLine("enter the department number of employee");
                short deptno = Convert.ToSByte(Console.ReadLine());
                 
                e[i] = new employee(name,basic,deptno);
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
               
            }
           
            
            for (int i=0;i<e.Length;i++)
            {
                for (int j=i+1;j<e.Length;j++) {
                      if (e[i].Basic>e[j].Basic)
                    {
                        employee m = e[i];
                        e[i] = e[j];
                        e[j] = m;
                        
                        
                    }
                        }
            }
            Console.WriteLine("employee name of highest salary{0}:::=", e[e.Length-1].Name);

            Console.WriteLine("=====================================================");

            Console.WriteLine("enter the emloyee number to find all detail of that number");
            int k = Convert.ToInt32(Console.ReadLine());
              for(int i=0;i<e.Length;i++)
            {
                if(e[i].EmpNo==k)
                {
                    Console.Write("employee name={0}:",e[i].Name);
                    Console.Write("employee deptno={0}:", e[i].Deptno);
                    Console.Write("employee basic={0}:", e[i].Basic);
                    Console.Write("employee empno={0}:", e[i].EmpNo);
                    Console.ReadLine();
                }

            }
            Console.ReadLine();
        }
    }
    class employee
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
            this.Name= name;
            this.Basic = basic;
            this.EmpNo = dd++;
        }
        public employee(String name)
        {
            this.Name= name;
            this.EmpNo = dd++;
        }

        public int getnetsalary()
        {
            int netsalary = (int)basic + 1000;
            return netsalary;
        }
    }
}
