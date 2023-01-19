using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjarnesKids
{
    internal class MyZebastian
    {
        public void Run()
        {

            Console.WriteLine(ConvertInt(value1));
           

            for (int i = 0; i < value1; i++)
            {
                ConsoleString(dunk);
                ConvertInt(value1);

            }

        }

        public  int value1 = 20;
        public float kill = 10f;
        public string dunk = "Hello World!";
        public bool pressed = true;



        string ConvertInt(int value2)
        {
            string text = "Hello World!";


            if (value2 > 1)
            {
                Console.WriteLine(text);
            }


            

            return text;
            
        }


        void  ConsoleString(string skibop)
        {

            skibop = "Hola Mundo!";

            Console.WriteLine(skibop);
        }



    }
}
