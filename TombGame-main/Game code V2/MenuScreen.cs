using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_code_V2
{
    class MenuScreen
    {
        public static void Setup() //Menuscreen - plot of game described and player enters name
        {
            string playername;
            bool isnumber;
            int tempnumber;

            Console.WriteLine("Hello young explorer! In this game you decide to adventure to Egypt, where you explore through an abandoned tomb. Choose carefully! The choices you make will decide your fate...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("So explorer, what is your name?");
            playername = Console.ReadLine();
            do
            {
                isnumber = Int32.TryParse(playername, out tempnumber);
                if (isnumber == true)
                {
                    Console.WriteLine("Playername cannot contain numbers. Please enter another name"); //Validation
                    playername = Console.ReadLine();

                }
                else if (isnumber == false)
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(playername + " I wish you luck on your adventure!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You " + playername + " a thrillseeking explorer are looking for your next adventure. After some searching through different websites you decide on Egypt. Not wasting any time you pack a bag and head straight to the airport");
                    System.Threading.Thread.Sleep(1000);

                }

            } while (isnumber == true);
        }
    }
}
