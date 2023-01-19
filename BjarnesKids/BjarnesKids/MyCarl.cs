using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjarnesKids
{
    internal class MyCarl
    {
        int holeNumbre = 10;
        string text = "Anser";
        bool onOff = true;
        float desemalNumber = 3;


        public void Run()
        {

            for (int i = 0; i < desemalNumber; i++)
            {
                Console.WriteLine(Answerer(holeNumbre));
                Writer(text);
                holeNumbre++;
            }

            



            if (true)
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


        string Answerer(int giftNumber)
        {
            string giveAnser = "smaler then 13";
            if (giftNumber < 13)
            {
                return giveAnser;
            }

            return "not smaler then 13";

        }


        void Writer(string toWrite)
        {

            Console.WriteLine(toWrite);




        }




    }
}
