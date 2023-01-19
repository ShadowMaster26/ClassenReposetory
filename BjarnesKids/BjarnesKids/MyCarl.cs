using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjarnesKids
{
    internal class MyCarl
    {
        public void Run() 
        {
            string[] show = new string[2];
            show[0] = " ";
            show[1] = "Hello world";


            int witch = 0;


            string key = Console.ReadKey().Key.ToString();
            if (key.ToUpper() == "W") 
            {

                witch = 1;
            
            
            
            }
            else 
            {

                witch = 0;
            
            }

            Console.WriteLine(show[witch]);





        }










    }
}
