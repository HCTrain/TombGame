using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_code_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup(); //Intro + player enters name
            //Main code - game begins

            Choice1(); //Choice 1 - Do you go in to cafe or not?

            Console.WriteLine("This peaking your interest, you decide that you will be the one to explore the pyramids and come back to tell the tale. After all, this could put you in the history books you think to yourself.");
            System.Threading.Thread.Sleep(3000); //increase delay to make more readable
            Console.WriteLine("You arrive at a base camp, where you can purchase all the supplies you need for your trip. You buy a torch, some matches, a lighter and a few packets of some food rations.");
            System.Threading.Thread.Sleep(3000);

            //Exploration begins
            Console.WriteLine("You pack your bag and head to the entrance of the pyramid. You're feeling condifent about your navigation abilities, as this isn't your first exploration but the thought of all those missing people creates a little doubt in the back of your head");
            System.Threading.Thread.Sleep(3000);

            Choice2(); //Choice 2 - Carry on or exit game?

            Console.WriteLine("You carry on deeper and deeper into the pyramid. The natural light from outisde now completely vanished. Solely reyling on your torch you work your way through the different pathways in the pyramid. On your way you see skeletons of past explorers. You jump as spiders run across your feet");
            Choice3(); //choice 3 - Open chest or not?

            Console.WriteLine("With a sense that you may be on to a big discovery here, you press on deeper into the pyramid. You stop to look at the heiroglphys on the wall. You stare at them and think how beautiful they are");
            System.Threading.Thread.Sleep(1000);
            Choice4(); //choice 4 - Continue looking or get up?

            //Choice 5 - End of game - Good ending or bad ending
            Choice5();
        }
        static void Setup()
        {
            string playername;
            bool isnumber;
            int tempnumber;

            Console.WriteLine("Hello young explorer! In this game you decide to adventure to Egypt, where you explore an abdandoned pyramid. The choices you make will decide your fate.");
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
        static void Choice1()
        {
            string choice;
            bool isnumber;
            int tempnumber;
            Console.WriteLine("After a long flight, you finally arrive in Egypt.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("As you are walking down the street, you see a local cafe. Do you go in to get something to eat? Please type yes or no to make your decision");
            choice = Console.ReadLine();
            do
            {
                isnumber = Int32.TryParse(choice, out tempnumber);
                if (isnumber == true)
                {
                    Console.WriteLine("Invalid answer. Please type yes or no");
                }
                else if (isnumber == false)
                {


                    if (choice == "yes")
                    {
                        Console.WriteLine("You go in and grab a sandwhich from the cafe, while you're eating you get talking to one of the locals about your visit. While you're chatting he mentions that ther are some unexplored pyramids, he says that these are extremely dangerous as those who have tried have never come back alive ");
                        System.Threading.Thread.Sleep(1000);
                    }
                    else if (choice == "no")
                    {
                        Console.WriteLine("You carry on down the street where you come across a missing persons poster. You pick it up. A passerby explains about the missing tourists and the unexplored pyramids");
                        System.Threading.Thread.Sleep(1000);
                    }
                }

            } while (isnumber == true);


        }
        static void Choice2()
        {
            string choice;
            bool isnumber;
            int tempnumber;
            Console.WriteLine("With your lit torch in hand you make your way into the pyramid. As you walk down the entrance to the cave the outside light starts to disapear behind you. The missing persons posters stuck in your head, you think wether its a good idea to turn back? Please type yes or no to make your desicion");
            choice = Console.ReadLine();
            do
            {
                isnumber = Int32.TryParse(choice, out tempnumber);
                if (isnumber == true)
                {
                    Console.WriteLine("Invalid answer.Please type yes or no");
                }
                else if (isnumber == false)
                {


                    if (choice == "yes")
                    {
                        Console.WriteLine("Thinking that maybe it isn't worth it, you turn back. Deciding to take the rest of your adventure as a holiday");
                        System.Threading.Thread.Sleep(1000);
                        System.Environment.Exit(1); //Exit Program - Game over

                    }
                    else if (choice == "no")
                    {
                        Console.WriteLine("You talk yourself out of it. You think to yourself that you could be onto something here. The thought of doing something that no one has done before gives you the confidence to carry on");
                        System.Threading.Thread.Sleep(1000);
                    }
                }

            } while (isnumber == true);

        }
        static void Choice3()
        {
            string choice;
            bool isnumber;
            int tempnumber;
            Console.WriteLine(" After what feels like forever you come to a chest. Do you open it? Please type yes or no to make your decision");
            choice = Console.ReadLine();
            do
            {
                isnumber = Int32.TryParse(choice, out tempnumber);
                if (isnumber == true)
                {
                    Console.WriteLine("Invalid answer.Please type yes or no");
                }
                else if (isnumber == false)
                {
                    if (choice == "yes")
                    {
                        Console.WriteLine("You open the chest. You gasp in shock as you see whats inside. A chest full of anciet egyptian coins. You fill your bag with as many as you can fit. You feel extremely confident, thinking that you're now going to end up in the history books");
                        System.Threading.Thread.Sleep(1000);
                    }
                    else if (choice == "no")
                    {
                        Console.WriteLine("After hearing about too many egytpian curses and seeing the remains of the explorers who've come before you. You decide that maybe its not worth it and carry on");
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            } while (isnumber == true);

        }
        static void Choice4()
        {
            string choice;
            bool isnumber;
            int tempnumber;
            Console.WriteLine("Oh no! You've tripped and fallen. Your torch has gone out, you scramble around on the floor to try and find it but no luck. Do you continue looking or get up and dust yourself off. Please type continue looking or get up to make your decision");
            choice = Console.ReadLine();
            do
            {
                isnumber = Int32.TryParse(choice, out tempnumber);
                if (isnumber == true)
                {
                    Console.WriteLine("Invalid answer.Please type continue looking or get up");
                }
                else if (isnumber == false)
                {
                    if (choice == "continue looking")
                    {
                        Console.WriteLine("You continue to scramble around on the floor, getting on your hands and knees to find your backpack and torch. You start to give up hope but your scrambling pays off. You find your backpack and torch, with your torch relit you carry on with your journey");
                        System.Threading.Thread.Sleep(1000);
                    }
                    else if (choice == "get up")
                    {
                        Console.WriteLine("You decide to cut your losses and just get up. As you're doing this you hear a massive bang, almost as if plates were smashing on the floor. You search the floor to see if you can find out what it was, finding your torch you relight it, only to discover you'd broken a canopic jar");
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            } while (isnumber == true);
        }
        static void Choice5()
        {
            string choice;
            bool isnumber;
            int tempnumber;

            
            Console.WriteLine("You've come to find what seems like a massive room, you hover by the entrance and put your torch in first. You are shocked with your discovery, in utter disbelief about what you've discovered. Infront of you is a room filled with ancient relics, coins and lots more treasure. You've never seen anything like it. But in the middle of the room is a sarcophagus. You begin to get curious about what could be inside. Do you open the sarcophagus? Please type yes or no to make your decision");
            choice = Console.ReadLine(); 
            {
                isnumber = Int32.TryParse(choice, out tempnumber);
                if (isnumber == true)
                {
                    Console.WriteLine("Invalid answer. Please type yes or no");
                }
                else if (isnumber == false)
                {

                    if (choice == "yes")
                    {
                        Console.WriteLine("You walk over to the sarcophagus, opening the lid only to reveal a mummifed Tutankhamun. You freeze with fear as he starts to awake and sit up. He doesn't look very friendly, not happy that you've disturbed his place of rest he curses you. You run out of the room as fast you can, following all the routes you'd taken to get in there.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Just when you can start to see the natural light from the outside, you drop to the floor. You try your hardest to get back up but everything fades to black. A few days pass and since you haven't returned, the locals start to grow concerned about your whereabouts and they add your picture to the many missing persons posters around the town");
                        Console.ReadLine();
                    }
                    else if (choice == "no")
                    {
                        Console.WriteLine("You think about it for a second but decide to leave it. You carry on looking around the room but suddenly the lid to the sarcohpagus falls to the ground. You turn around to see the mummifed remains of Tutankamun staring you in the face. He looks quite friendly though. He thanks you for not disturbing his place of rest. He gifts you with treasure and some old relics. You return out of the tomb safely, telling your story to the locals. You become a local hero");
                        Console.ReadLine();
                    }
                }
            } while (isnumber == true);

        }
    }
}
