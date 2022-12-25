using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("n1");
            int Start = int.Parse(Console.ReadLine());
            Console.WriteLine("n2");

            int End = int.Parse(Console.ReadLine());

            int Sum = 0;
            for (int i = Start; i <= End; i++) {
                for (int x = 1; x <= i; x++){
                    if(i%x==0)
                    Sum++;
                }
                if(Sum==2){
                    Console.WriteLine(i);
                    Sum=0;
                }else{
                    Sum=0;
                    continue;
            }
               

               
                }
            
            
            
            }
            

       
            


        }
    }

