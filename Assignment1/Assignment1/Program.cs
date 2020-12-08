using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            employee p1 = new employee();
           
            p1.Name ="sss";
            p1.Deptno = 9;
            p1.Basic = 15;
            Console.WriteLine(p1.EmpNo);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Basic);
           


               employee p2 = new employee();
                Console.WriteLine(p2.EmpNo);
                



            employee p3 = new employee();
            Console.WriteLine(p3.EmpNo);



            employee e1 = new employee("satish", 12212, 10);
            employee e2 = new employee("satish", 12212);
            employee e3 = new employee("satish");
            Console.WriteLine(e1.getnetsalary());
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
                if (value=="")
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

        private static int dd =1;
          

        private  int empno;
           public   int EmpNo
        {
             
              get
            {
                return  empno;


            }

        }
          
       


        private decimal basic;
        public decimal Basic
        {
            set { 
            if(value>10 && value< 100)
            {
                    basic = value;
            }
                else
                {

                    Console.WriteLine("not allowed values in decimal part");
                }

           }
            get
            {

                return basic;
            }
        }

        private short deptno;
             public  short Deptno
        {
            set
            {
                if(value>0)
                {
                    deptno = value;
                }
            }
            get
            {
                return Deptno;
            }

        }

            public employee()
        {
            this.empno = dd++;
            


        }

        public employee(String name,decimal basic,short  deptno)
        {
            this.deptno = deptno;
            this.name = name;
            this.basic = basic;
            this.empno = dd++;
        }
        public employee(String name, decimal basic)
        {
            this.name = name;
            this.basic = basic;
            this.empno = dd++;
        }
        public employee(String name)
        {
            this.name = name;
            this.empno = dd++;
        }

        public  int getnetsalary()
        {
            int netsalary = (int)basic + 1000;
            return netsalary;
        }
    }
}


