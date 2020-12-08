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
            Console.WriteLine("hii");
            //Console.WriteLine("basic value of employee"+e1.Basic);
            ////Console.ReadLine();
            ////Console.WriteLine(e1.CalcNetSalary());
            ////Console.ReadLine();
            //Employee e2 = new CEO();
            //Console.WriteLine(  e2.CalcNetSalary());
          IDbFunctions obj = new GeneralManager();
             obj.Insert();
            Console.WriteLine("hii");
           Console.ReadLine();
             
            
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();

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
            private set
            {
                empno = value;
            }
            get
            {
                return empno;
            }

        }
        public static int empn = 1;
        

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

        protected   decimal basic;
          public abstract decimal Basic
        {
            get;set;
        }

        public abstract decimal CalcNetSalary();
         public  Employee()
        {
            Console.WriteLine("constructor for abstract employee class");

        }
        public Employee(String Name="satish", short Deptno=10,int Basic=1000 )
        {
            Console.WriteLine("constructor for abstract employee class");
            this.Basic = Basic;
            this.DeptNo = DeptNo;
            this.Name = Name;
            this.EmpNo = ++empn;


        }

    }
 public class Manager : Employee,IDbFunctions
    {    

        protected String designation;
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

        public override decimal Basic {
            set {
                if (value > 5)
                    basic = value;
                else
                    Console.WriteLine("manager basic is always greatter than 5");

            }
            get {
                return basic;
            }
        }
        public Manager()
        {
            this.DeptNo = 1;
            this.Basic = 10;
            this.Designation = "manager";
            this.Name = "kkk";

        }
         

        public Manager(String designation ,int basic,String name,short deptno ) { 
            Console.WriteLine("this is manager class  with  parameter cnstructor");
            this.Basic = basic;
            this.Designation = designation;
            this.Name = name;
            this.DeptNo = deptno;
        }



        public override decimal CalcNetSalary()
        {
            return basic + 1000;
        }

        public virtual void Insert()
        {
            Console.WriteLine("this is insert function of manager"); 
        }

        public virtual void Update()
        {
            Console.WriteLine("this is update function of manager");
        }

        public  virtual void Delete()
        {
            Console.WriteLine("this is Delete function of manager");
        }
    }
 public class GeneralManager:Manager,IDbFunctions
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
            Console.WriteLine("this is general manager class  no parameter cnstructor");
            this.Perk = "jjdsj";
            this.Basic = 15000;
            this.DeptNo = 1;
            this.Designation = "CEO";
            this.Name = "CEO";
             
        }
        public GeneralManager(String perk,int basic,int Deptno,string designation,string name)
        {
            Console.WriteLine("this is general manager class  parameter cnstructor");
            this.Perk = perk;
            this.Basic =basic;
            this.DeptNo = DeptNo;
            this.Designation = designation; ;
            this.Name = name; 
        }
        //void IDbFunctions.Insert()
        //{
        //    Console.WriteLine("this input function of General  Manager class+++++++++++++");
        //}
        //void IDbFunctions.Delete()
        //{
        //    Console.WriteLine("this delete function of General  manager class");
        //}
        //void IDbFunctions.Update()
        //{
        //    Console.WriteLine("this update function of General  Manager class");
        //}
        public override void Insert()
        {
            Console.WriteLine("this is insert function of general manager");
        }

        public override void Update()
        {
            Console.WriteLine("this is update function ofg manager");
        }

        public override void Delete()
        {
            Console.WriteLine("this is Delete function of g manager");
        }
    }

 public class CEO : Employee,IDbFunctions
    {
        public override decimal Basic { 
            set {
                if (value > 20)
                    basic = value;
                 else
                    Console.WriteLine("ceo salary always greatter than 20");
            }
            get
            {
                return basic;
            }
        
        }

        public override  sealed decimal CalcNetSalary()
        {
            Console.WriteLine("this is calcNetsalary  ceo  class function");
            int salary = (int)(Basic + 250);
            return salary;
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public CEO()
        {
            Console.WriteLine("this is CEO class no parameter cnstructor");
            this.Basic = 1200;
            this.Basic = 21;
            this.DeptNo =45;
            this.Name ="satish";

        }

        public CEO(int basic,short deptno,string name)
        {
            Console.WriteLine("this is CEO class  parameter cnstructor");
            this.Basic = basic;
            this.DeptNo =deptno;
            this.Name =name;
             


        }
    }

}
