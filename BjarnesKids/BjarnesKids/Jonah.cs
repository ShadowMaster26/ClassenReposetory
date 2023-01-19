using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjarnesKids
{
    internal class Jonah
    {
        string myName = "Jonah";
        int myFavoriteNumber = 9;
        float coolNumber = 22.5F;
        bool isEpic = false;

        public void Run()
        {
            for (int i = 0; i < coolNumber; i++)
            {
                WriteString(GetPerson(myFavoriteNumber));

            }

        }

        string GetPerson(int favoriteNumber)
        {
            if (favoriteNumber == 9)
            {
                return myName;
            }
            return "RAHHH!! No person found with that favorite number!";
        }

        void WriteString(string stringToWrite)
        {
            Console.WriteLine(stringToWrite);
        }

        
    }
}
