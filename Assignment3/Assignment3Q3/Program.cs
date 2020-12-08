using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            abc[] arr = new abc[5];

              for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("enter the name of student");
                string name = Convert.ToString(Console.ReadLine()) ;

                Console.WriteLine("enter the rollno of student");
                int rollno = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("enter the total marks of student");
                decimal marks = Convert.ToDecimal(Console.ReadLine());
                arr[i] = new abc(name,rollno,marks); 
                    

            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("++++++++++++++++++++");
                Console.WriteLine(" name of student={0}:",arr[i].name);
                Console.WriteLine(" rollno of student={0}:", arr[i].rollno);
                Console.WriteLine(" total marks of student={0}:", arr[i].marks);
                Console.WriteLine("++++++++++++++++++++");
            }
            Console.ReadLine();
        }
    }

    public struct abc
    {
        public string name;
        public int rollno;
        public decimal marks;
        public abc(string name, int rollno,decimal marks)
        {
            this.marks = marks;
            this.name = name;
            this.rollno = rollno;

        }
    }
}
