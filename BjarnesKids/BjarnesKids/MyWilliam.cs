using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjarnesKids
{
    internal class MyWilliam
    {
        public void Run()
        {
            int williamInt = 2;
            float williamFloat = 2.0f;
            string williamString = "one";
            bool williamBool = true;
            if (williamBool)
            {
                for (int i = 0; i < williamFloat; i++)
                {
                    Console.WriteLine(IsAboveOne(williamInt)); // cw calls method to return a string value, string says if variable int is above, equal or below one
                    CWString(williamString); //calls method to write out string value of williannString
                }
            }
        }
        public string IsAboveOne(int inputInt)
        {

            if (inputInt > 1)
            {
                string aboveOne = "above one";
                return aboveOne;
            }
            else if (inputInt == 1)
            {
                string equalOne = "equal to one";
                return equalOne;
            }
            else
            {
                string belowOne = "below one";
                return belowOne;
            }
        }

        public void CWString(string inputString)
        {
            Console.WriteLine(inputString);
        }
    }
}
