using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {



            /*  Dictionary< int, employee> e1 = new Dictionary<int, employee>();
              String s = Convert.ToString(Console.ReadLine());
              while (s=="yes")
              {
                  Console.WriteLine("enter 1 to continue");
                  string sk = Convert.ToString(Console.ReadLine());
                  if (sk=="no")
                  {
                      break;
                  }


                  Console.WriteLine("enter the name of employee");
                  string name = Convert.ToString(Console.ReadLine());

                  Console.WriteLine("enter the basic of employee");
                  decimal basic = Convert.ToDecimal(Console.ReadLine());


                  Console.WriteLine("enter the department number of employee");
                  short deptno = Convert.ToSByte(Console.ReadLine());

                  Console.WriteLine("++++++++++++++++++++++++++++++++++");
                  Console.WriteLine("enter key vallue");
                  int key = Convert.ToInt32(Console.ReadLine());
                  e1.Add( key, new employee { Name = name, Basic = basic, Deptno = deptno });

              }
              decimal sl = 0;
              int ddd = 0;
              foreach (int key in e1.Keys)
              {
                  if (e1[key].Basic >= sl)
                  {
                      sl = e1[key].Basic;
                      ddd = key;
                  }

              }
              //Console.WriteLine("max salary={0}",sl);
              //Console.WriteLine("employee name is={0}",e1[ddd].Name);
              ////foreach (KeyValuePair<int,employee> x in e1)
              ////{
              ////    Console.WriteLine(e1.Keys);
              ////    Console.WriteLine(e1[1].Basic);
              ////}  
              ///
              Console.WriteLine("enter employee number to find the detail of employee");
              int empn = Convert.ToInt32(Console.ReadLine());
              foreach (int key in e1.Keys)
              {
                  if (e1[key].EmpNo ==empn)
                  {
                      //sl = e1[key].Basic;
                      //ddd = key;
                      string nn =e1[key].Name;
                        decimal t= e1[key].Basic;
                         int emmm= e1[key].Deptno;
                          int iie= e1[key].EmpNo;
                      Console.WriteLine(nn);
                      Console.WriteLine(t);
                      Console.WriteLine(emmm);
                      Console.WriteLine(iie);
                  }

              }
              Console.WriteLine("enter employee key to find employee ");
              int jkk= Convert.ToInt32(Console.ReadLine());

              //foreach (int key in e1.Keys)
              //{
              //    if (key==jkk)
              //    {
              //         e1.
              //    }

              //}
              int j = 0;
              Console.WriteLine("enter how many number employee information you want");
              int k = Convert.ToInt32(Console.ReadLine());
              foreach(KeyValuePair<int,employee>eer in e1)
              {
                  if(j<k)
                  {
                      Console.WriteLine(  eer.Value.Name);
                      Console.WriteLine(eer.Value.Basic);
                      Console.WriteLine(eer.Value.Deptno);
                      Console.WriteLine(eer.Value.EmpNo);
                      Console.WriteLine("+++++++++++++");
                  }
                  j++;
              }
            */
              employee[] e = new employee[3];
              e[0] = new employee("eee",1200,1);

              e[1] = new employee("lll", 3200, 4);

              e[2] = new employee("eee", 8999, 5);

              List<employee> e33;
              e33 = e.ToList();

              foreach (employee tr in e33)
              {
                  Console.WriteLine(tr.Basic);
                  Console.WriteLine(tr.Deptno);
                  Console.WriteLine(tr.Name);
                  Console.WriteLine(tr.EmpNo);
              }

            Console.WriteLine("----------------------");
            employee[] hh = new employee[e33.Count];
                hh = e33.ToArray();
                    for(int i=0;i<hh.Length;i++)
                   {
                Console.WriteLine(hh[i].Basic);
                Console.WriteLine(hh[i].Deptno);
                Console.WriteLine(hh[i].EmpNo);
                Console.WriteLine(hh[i].Name);

            }







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
                {  name = value;
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
