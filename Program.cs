using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentQ2
{
    class   Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Manager();
            //e1.Basic = 101;
            //Console.WriteLine("basic value of employee"+e1.Basic);
            //Console.ReadLine();
            //Console.WriteLine(e1.CalcNetSalary());
            //Console.ReadLine();
            Employee e2 = new CEO();
            Console.WriteLine(  e2.CalcNetSalary());
            Console.ReadLine();
        }
    }


 public  abstract class  Employee
    {
        private String name;
          public String Name
        {
            set
            {
                if (value == "")
                    Console.WriteLine("invalid name");
                else
                    name = value;

            }
            get
            {
                return name;
            }

        }

        private int empno;
          public int EmpNo
        {
            get
            {
                return empno;
            }

        }

        private short deptno;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptno = value;
                else
                    Console.WriteLine("invalid entry in deptno");

            }
            get
            {
                return deptno;
            }

        }

        public abstract decimal Basic
        {
            get;
            set;
        }

        public abstract decimal CalcNetSalary();
         public  Employee()
        {
            Console.WriteLine("constructor for abstract employee class");

        }
        public Employee(String name, int empno,short deptno )
        {
            Console.WriteLine("constructor for abstract employee class");
            this.name = name;
            this.empno = empno;
            this.deptno = deptno;
              
        }

    }
 public class Manager : Employee
    {    

        private String designation;
        public String Designation
        {
            set
            {
                if (value == "")
                    Console.WriteLine("invalid name");
                else
                    designation = value;

            }
            get
            {
                return designation;
            }

        }
         
        private decimal basic;
        public override decimal Basic
        {
            set
            {
                if (value > 100)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("invalid entry of manager basic");
                }
            }
            get
            {

                return basic;
            }
        }


        public Manager()
        {
            Console.WriteLine("  no paramer constructor for abstract overridden employee class with manager");
            this.designation = "satish";
            this.basic = 101;
             
        }

        public Manager(String designation, int basic)
        {
            Console.WriteLine("this is manager class  with  parameter cnstructor");
            this.basic = basic;
            this.designation = designation;

        }
        public override decimal CalcNetSalary()
        {
            return basic + 1000;
        }
 
    }
 public class GeneralManager:Manager
    {
        private String perk;
          public string Perk
        {
            set
            {
                perk = value;
            }
            get
            {
                return perk;

            }

        }
          public GeneralManager()
        {
            Console.WriteLine("this is CEO class  no parameter cnstructor");
            this.perk = "jjdsj";
             
        }
        public GeneralManager(String perk)
        {
            Console.WriteLine("this is general manager class  parameter cnstructor");
            this.perk = perk;

        }

    }

 public class CEO : Employee
    {
        private decimal basic;
        public override decimal Basic
        {

            set
            {   if (value > 1000)
                {
                    basic = value;
                }
            else
                {
                    Console.WriteLine("invalid entry of basic in CEO class");

                }
            }
            get
            {
                return basic;

            }
        }
        public override  sealed decimal CalcNetSalary()
        {
            Console.WriteLine("this is calcNetsalary  ceo  class function");
            int salary = (int)(basic + 250);
            return salary;
        }
           public CEO()
        {
            Console.WriteLine("this is CEO class no parameter cnstructor");
            this.basic = 1200;
             

        }

        public CEO(int basic)
        {
            Console.WriteLine("this is CEO class  parameter cnstructor");
            this.basic = basic;


        }
    }

}
