using System;
using System.Threading;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            phantomOfTheWoods();
            first();
        }

        public static void phantomOfTheWoods()
        {
            Console.WriteLine($"His breath came in short gasps as the cold air blew against his face burning his cheeks and nose. The spruce and pines looked daunting covered in heavy snow.");
            Console.WriteLine("He came to a stop at the top of the peak, lowered his eyes and then took a running leap. His heart caught in his throat as his hang glider swooshed through the crisp, light into the dark woods below.");
            Thread.Sleep(10000);
            Console.ReadLine();
            Console.WriteLine("Welcome to Phantom Of The Woods");
            Console.WriteLine("Location: Mt. Layell, California");
            Console.WriteLine("Elevation: 13,120'");
            Console.ReadLine();
            string yourName;
            Console.WriteLine("Please enter your name to access the Phantom file");
            yourName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Access Granted");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Welcome {yourName}. Information on the Phanotom is limited. There are only two known facts, 1. It has never been seen but merely felt. No images or drone footage has been captured of it. 2. The only sign that the Phantom is present is the carving of P H N T M on tress around the park. No one has gone missing until now. Your job is to find Jake and uncover the mystery behind this Phantom. Good Luck!");
            Console.WriteLine("Press 'Enter' to being.");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            string choice;

            Console.WriteLine("Jake was last seen by ole man Russ at Russ's Last Stop located outside of Yosemite. He stopped there 3 days ago to get a couple RX bars and a Red Bull.");
            Console.WriteLine("No one knows why he went to Yosemite, not even his best friend, Bedford, whom he roomed with. All Beford knew is he was taking his new toy out for a fly from Mt. Layell");
            Console.WriteLine("Where do you want to start?");
            Console.WriteLine("1. Russ's Last Stop ");
            Console.WriteLine("2. Mt. Layell");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("Hey Mr. Russ? I have a few questions for you.");
                        Console.WriteLine("An older man about 57 stepped out from the back room. He wore a faded blue shirt with a dip can in one pocket.");
                        Console.WriteLine("What can I do for ya?");
                        Console.WriteLine("I'm looking for this man, Jake Morsono. He was last seen 3 days ago here.");
                        Console.WriteLine("Yeah, I remember him. Reminds me of my own boy. Can't tell ya where he went tho. Did say somethin 'bout findin the thing that always haunts him. Got no idea what that was 'bout.");
                        Console.ReadLine();
                        third();
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine("Reaching the top of Mt. Layell, you could see for miles. The sun shone bright off the snow and the trees glistened like ice icicles.");
                        Console.WriteLine("Why would he come up here?");
                        Console.WriteLine("Then it clicked! ");
                        Console.WriteLine("It's the freedom!");
                        Console.WriteLine("The freedom of the air, the space.");
                        Console.WriteLine("Yes, but why this spot?");
                        Console.WriteLine("As you're thinking your eyes rest on a nearby tree and make out the letters P H N T M");
                        Console.WriteLine("make out the letters carved on the tree.");
                        Console.ReadLine();
                        sixth();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again.");
                        first();
                        break;
                    }
            }
        }

        public static void third()
        {

            Random rnd = new Random();
            string[] secOptions = { "You look up in time to see a figure dissapear around the cornor outside the store", "The old man knows more than he is letting on." };
            int randomNumber = rnd.Next(0, 2);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Do you follow your instinct?");
            Console.WriteLine("Yes or No?");
            Console.WriteLine("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes")
            {
                fourth();
            }

            else if (secChoice == "no")
            {
                Console.WriteLine("You don't trust your gut enough.");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                gameOver();
            }
            else
            {
                Console.WriteLine("I don't understand that command...");
                Console.WriteLine("Press 'Enter' to try again.");
                third();
            }

        }

        public static void second()
        {

            Console.WriteLine("You're the Phantom?");
            Console.WriteLine("No, I'm Jake.");
            Console.WriteLine("Where is the Phantom.");
            Console.WriteLine("Inside me.");
            Console.WriteLine("I don't understand.");
            Console.WriteLine("The person I feared the most is me. The person that haunts me, is me. The thing that holds me back, me. I only come out when I am by myself, that is why I come up here. I am my own Phantom!");
            missionSuccessful();
            
        }

        public static void fourth()
        {
            string choice;

                Console.WriteLine("You take off for the figure and chase him for 2 miles, weaving in and out of the trees.");
                Console.WriteLine("A branch catches the side of the figure's mask and rips it off but the figure doesn't stop and disappears before you can see where it went.");
                Console.WriteLine("You stoop to pick up the mask.");
                Console.WriteLine("There is a tiny strand of hair attached to the corner.");
                Console.WriteLine("1. You take the strand of hair to a lab");
                Console.WriteLine("2. You continue to search for Jake and the Phantom");
                Console.WriteLine("Choice: ");
                choice = Console.ReadLine().ToLower();


                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("You drive to the lab at the local police station.");
                            Console.WriteLine("They say they'll look into it right away and get back with you in 24 hours.");
                            Console.WriteLine("You decide to look up Jake's best friend, Bedford while you wait.");
                            seventh();
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine("You stand there holding the mask looking around for where the figure might have gone.");
                            Console.WriteLine("You notice carvings on the nearby trees.");
                            Console.WriteLine("1, 2, 3. Probably half a dozen trees.");
                            Console.WriteLine("This must be where he disappeared");
                            Console.WriteLine("But to where?");
                            fifth();
                            break;
                        }
                }
        }

        public static void fifth()
        {
            string choice;

                Console.WriteLine("There is no hole in the ground, no tree it could have escaped to, it didn't fly away...");
                Console.WriteLine("Did he just disappear in thin air?");
                Console.WriteLine("You go to every tree studying the writing. You notice that the N is not carved in but carved out around.");
                Console.WriteLine("What do you do?");
                Console.WriteLine("1. You press the letter in?");
                Console.WriteLine("2. You run to the other trees to check the letters to see if they are all the same.");
                Console.WriteLine("Choice: ");
                choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You press the letter and a door opens in the opposite tree.");
                        Console.WriteLine("You run down through the door and catch the unmasked man by the arm.");
                        Console.WriteLine("You wheel him around and it's Jake.");
                        second();
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine("You've wasted so much time");
                        gameOver();
                        break;
                    }
            }
        }

        public static void sixth()
        {
            Console.WriteLine("He walked to the tree and studied the letters.");
            Console.WriteLine("They were just normal tree carving letters, but the tree it was carved on a tree that was different than the others.  It was a maple in the midst of a pine forrest.");
            Console.WriteLine("He ran his fingers over the letters and they lit up.");
            Console.WriteLine("The snow began to shake from the tree and the trunk opened.");
            Console.WriteLine("You decend the stairs and stand face to face with Jake.");
            second();

        }

        public static void seventh()
        {
            Console.WriteLine("Bedford isn't home and the lab frames you as the Phantom.");
            gameOver();
            
        }

        public static void gameOver()
        {
                Console.Clear();
                Console.WriteLine("Your mission was terminated.");
                Thread.Sleep(5000);
                Console.WriteLine("You failed, you failed, you failed");
                Thread.Sleep(5000);
                Console.WriteLine("You failed, you failed!");
                Thread.Sleep(3000);
                Console.WriteLine("You failed...");
                Console.ReadLine();
                Console.WriteLine("YOU FAILED!");
                Console.ReadLine();
                Console.WriteLine("Press 'Enter' to try again. ");
                Console.ReadLine();
                Console.Clear();
                phantomOfTheWoods();
        }

        public static void missionSuccessful()
        {
                Console.Clear();
                Console.WriteLine("Congratulations!");
                Thread.Sleep(3000);
                Console.WriteLine("You successfully completed your mission.");
                Thread.Sleep(3000);
                Console.WriteLine("Press 'Enter' to try again. ");
                Console.ReadLine();
                Console.Clear();
                phantomOfTheWoods();
        
        }
    }
}