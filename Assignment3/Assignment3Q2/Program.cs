using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
            Console.WriteLine("enter the number of batches in cdac kharghar");
            int k = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[k][];
            //arr[0] = new int[2];
            //arr[0] = new int[3];
            //arr[0] = new int[2];
            //arr[0] = new int[3];
            
            
            
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write("enter the number of student in batch ={0}::", j);
                int jj = Convert.ToInt32(Console.ReadLine());
                arr[j] = new int[jj];
            }






            for (int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.Write("enter  per batch  evry student marks   ");
                    int ii = Convert.ToInt32(Console.ReadLine());
                    arr[i][j] = ii; 
                }
                Console.WriteLine("new batch is started now");

            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("batch  number={0} ",i);
                 for (int j = 0; j < arr[i].Length; j++)
                {  
                    Console.WriteLine("     student marks ={0} ",arr[i][j]);
                  }
                Console.ReadLine();
            }

            

        }
    }
}
