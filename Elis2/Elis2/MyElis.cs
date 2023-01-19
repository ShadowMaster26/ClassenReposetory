using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elis2
{
    internal class MyElis
    {
        public void Run()
        {
            int elisInt = 2;
            float elisFloat = 1.0f;
            string elisString = "Hello";
            bool elisBool = true;

            if (elisBool)
            {
                for (int i = 0; i < elisInt; i++)
                {
                    Console.WriteLine(ElisMethod(elisInt));     //skriver ut värdet elisInt från metoden elisMethod
                    CWString(elisString);    //kallar på CWString metoden och ger ut värdet på variabeln elisString
                }
            }
        }

        public void CWString(string elisString) //metod som skriver ut elisString
        {
            Console.WriteLine(elisString);
        }

        public string ElisMethod(int elisInt)   //metod som skickar tillbaks string värdet "Yo"
        {
            if (elisInt < 3)
            {
                string lessThan = "What's up";
                return lessThan;
            }
            else
            {
                string moreThan = "Nothing much";
                return moreThan;
            }

        }
    }
}
