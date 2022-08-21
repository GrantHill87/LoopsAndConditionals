﻿using System;

namespace LoopsPlusConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spectrumof1000();
            ThreesCompany();
            Equivalence();
            AtOdds();
            DeadOrAlive();
            VoteForPedro();
            AreYouInRange();
            Multipliers();
        }

        public static void Spectrumof1000()
        {
            Console.WriteLine("Challenge Accepted! Loops Plus Conditionals Program.");
            Console.WriteLine("");
            Console.WriteLine("Ho-Hoh! We got some countin' to do.... Well, maybe the computer does.");
            Console.WriteLine("");
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void ThreesCompany()
        {
            Console.WriteLine("");
            Console.WriteLine("It has been said -- good things come in threes.... I don't know how much you like 3 though.");
            Console.WriteLine("");
            for (int n = 3; n <= 999; n += 3)
            {
                Console.WriteLine(n);
            }
        }
        public static void Equivalence()
        {
            Console.WriteLine("What is Equivalence");
            Console.WriteLine("");
            Console.WriteLine("Hey there. We need a numeric value -- What is the value of A?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Alright. Now we need one more numeric value -- What is the value of B?");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Does A equal B?");
            Console.WriteLine("");
            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}");
            }
            else
            {
                Console.WriteLine($"{a} is not equal to {b}.");
            }
        }
        public static void AtOdds()
        {
            Console.WriteLine("");
            Console.WriteLine("Are you at Odds?");
            Console.WriteLine("");
            Console.WriteLine("We'll see. Choose your destiny (*Cough* err number).");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (j % 2 == 0)
            {
                Console.WriteLine("You're not at odds, but you are even steven.");
            }
            else
            {
                Console.WriteLine("You're at odds, you odd duck.");
            }
        }
        public static void DeadOrAlive()
        {
            Console.WriteLine("");
            Console.WriteLine("You seem to be alive and well.... Ehh maybe you're more on the undead side.");
            Console.WriteLine("");
            Console.WriteLine("I don't trust you; we'd better check and see, this 'deadometer' will take a numeric selection from you -- don't come any closer!");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (h > 0)
            {
                Console.WriteLine("Phew!!! Ok, sorry about that; I think -- I trust you now. You can never be too sure 'bout those 'undead' folk, y'know?");
            }
            else if (h < 0 && h > -1000)
            {
                Console.WriteLine("Gah!!! Run away! Run away! The negativity is killing me!");
            }
            else if (h <= -1000 && h > -1000000)
            {
                Console.WriteLine("Whoaaa!!!! I'm out of here!!!");
            }
            else if (h <= -1000000)
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Environment.Exit(0);
            }
        }
        public static void VoteForPedro()
        {
            Console.WriteLine("");
            Console.WriteLine("Howdy! Welcome to the Comedian's Colosseum. You're just in time -- to vote, that is! Wait a minute....");
            Console.WriteLine("");
            Console.WriteLine("*Squinting in your direction* You.... you look suspect. Are you eligible to vote? How old were you again?");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (g >= 16)
            {
                Console.WriteLine("Ah you don't say?? Very good, you meet the minimum age requirement to cast your vote here!");
            }
            else if (g < 16 && g > 12)
            {
                Console.WriteLine("Aww, too bad.... voting criteria here at the colosseum says you've got to be a bit older to be counted. Sorry.");
                Environment.Exit(0);
            }
            else if (g <= 12 && g > 4)
            {
                Console.WriteLine("Shucks.... Where are your parents?? Go home.");
                Environment.Exit(0);
            }
            else if (g <= 4)
            {
                Console.WriteLine("Uhh.... We really need to find your parents.... How in the heck did you waddle all the way over here??");
                Environment.Exit(0);
            }
            Console.WriteLine("");
            Console.WriteLine("Y'know, we're terribly stubborn here at the Comedian's Colosseum -- I don't believe you, what was your year of birth?");
            int f = int.Parse(Console.ReadLine());
            if (f <= 2006)
            {
                Console.WriteLine("Eh, ok, you really are of the minimal age requirement, not sorry that I doubted you.");
            }
            else if (f > 2006 && f < 2010)
            {
                Console.WriteLine("No good!! Honestly, between you and me.... I'd let you vote here, at the colosseum, if it were up to me. But, these guys.... they're sending you home.");
                Environment.Exit(0);
            }
            else if (f >= 2010 && f < 2018)
            {
                Console.WriteLine("Yeah, what was that you showed for identification? A fake ID?? Better luck next time, kid.");
                Environment.Exit(0);
            }
            else if (f >= 2018)
            {
                Console.WriteLine("What in the -- how the heck -- how is this possible??? I'm speechless.... *A toddler made it through security, unattended* I wonder who they'd vote for?");
                Environment.Exit(0);
            }
            Console.WriteLine("");
            Console.WriteLine("Ok, if you say so. Your height seems rather dubious; would you mind telling me, roughly, how many centimeters you are?");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (e >= 137)
            {
                Console.WriteLine("Ah-ha! Spectacular; go right on up to the center stage of the inner colosseum -- yes, straight down that large hallway, stage is on your right.");
            }
            else if (e >= 259)
            {
                Console.WriteLine("Oh my, you're a bit tall -- see if you can crouch down to the microphone at the podium, yeah? Apologies for the inconvenience.");
            }
            else if (e < 137)
            {
                Console.WriteLine("*Sigh* So sorry, we're out of stepping stools at the moment. You can still vote, it'll just have to be at a later time. We can get you squared away for tomorrow! Come on back.");
                Environment.Exit(0);
            }
            Console.WriteLine("");
            Console.WriteLine("Oh, it appears you are tall enough to stand at this here podium, and announce to the massive crowds inside the Colosseum, of your choice. Would be a shame if you couldn't to reach the microphone.");
            Console.WriteLine("");
            Console.WriteLine("Alright, so we have a few candidates to discern between, as far as who is perhaps the most hilarious of them all. It is the 'Comedian' Colosseum, after all.");
            Console.WriteLine("");
            Console.WriteLine("And your available selections for today's voting on the silliest comedians of 'all time' are as follows -- we had a top 7 contenders this year!");
            Console.WriteLine("");
            Console.WriteLine("Being hosted here tonight, at the Comedian Colosseum, are the following funny folk; Robin Williams, Ben Stiller, Jackie Chan, Pedro, Colin Mochrie, Ryan Stiles, and Will Ferrell.");
            Console.WriteLine("");
            Console.WriteLine("One at a time, each of the voters may approach the podium, center stage, and make their pick. Please be sure to speak loudly into the microphone, so that your vote can be heard!");
            string d = Console.ReadLine();
            Console.WriteLine("");
            switch (d)
            {
                case "Robin Williams":
                    Console.WriteLine("Can't go wrong there! Hard to match that wit -- Certainly one of the greatest of all time.");
                    break;
            
            
                case "Ben Stiller":
                    Console.WriteLine("Yeah! What a variety of comedy, with films such as Zoolander, Dodgeball, Starsky and Hutch, and even Tropic Thunder.... Awesome!");
                    break;

                case "Jackie Chan":
                    Console.WriteLine("Definitely! Mixing martial arts with comedic notion; who'd have guessed??");
                    break;

                case "Pedro":
                    Console.WriteLine("When in doubt, vote for Pedro.");
                    break;

                case "Colin Mochrie":
                    Console.WriteLine("Yes! The funnyman who frequented the very popular, 'Whose Line is it Anyway?'. Couldn't argue with that. ");
                    break;

                case "Ryan Stiles":
                    Console.WriteLine("It's so hard to keep a straight face when watching this guy perform, lot of talent here.");
                    break;

                case "Will Ferrell":
                    Console.WriteLine("Too many works of his to name here, but undoubtedly a top contender.");
                    break;

                default:
                    Console.WriteLine("Hey! We appreciate your pick, however, it was not included within today's set of candidates.");
                    break;
            }
        }
        public static void AreYouInRange()
        {
            Console.WriteLine("");
            Console.WriteLine("Are you within Range?? Let's find out. No hints either.");
            Console.WriteLine("");
            Console.WriteLine("Ok, one hint -- please provide a number.");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Err was it less than 10? Or greater than -10??");
            Console.WriteLine("");
            if (c <= 10 && c >= -10)
            {
                Console.WriteLine("Wow! Well, it appears as though you are in range. Congrats.");
            }
            else
            {
                Console.WriteLine("Gosh Darn it, you're not within range!");
            }
        }
        public static void Multipliers()
        {
            Console.WriteLine("Integers 1 - 12; Table Based.");
            Console.WriteLine("");
            Console.WriteLine("Display of Multiplication");
            Console.WriteLine("");
            int table1 = 1;
            int table2 = 2;
            int table3 = 3;
            int table4 = 4;
            int table5 = 5;
            int table6 = 6;
            int table7 = 7;
            int table8 = 8;
            int table9 = 9;
            int table10 = 10;
            int table11 = 11;
            int table12 = 12;
            int length = 12;
            int k = 1;

            Console.WriteLine("Multiplication Table: " + table1);
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table1);
            }
            Console.WriteLine($"Multiplication Table: {table2}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table2);
            }
            Console.WriteLine($"Multiplication Table: {table3}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table3);
            }
            Console.WriteLine("Multiplication Table: " + table4);
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table4);
            }
            Console.WriteLine($"Multiplication Table: {table5}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table5);
            }
            Console.WriteLine($"Multiplication Table: {table6}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table6);
            }
            Console.WriteLine($"Multiplication Table: {table7}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table7);
            }
            Console.WriteLine($"Multiplication Table: {table8}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table8);
            }
            Console.WriteLine($"Multiplication Table: {table9}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table9);
            }
            Console.WriteLine($"Multiplication Table: {table10}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table10);
            }
            Console.WriteLine($"Multiplication Table: {table11}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table11);
            }
            Console.WriteLine($"Multiplication Table: {table12}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table12);
            }
            Console.WriteLine("");
            Console.WriteLine("Was there a multiplication table you wanted to see performed? up until a value of 12?");
            Console.WriteLine("");
            Console.WriteLine("Please input a value of 1 or greater for 'yes', and 0 or less for 'no'.");
            int userResponse = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            if (userResponse >= 1)
            {
                Console.WriteLine("Great. We'll go ahead and continue your request.");
            }
            else if (userResponse < 1)
            {
                Console.WriteLine("Fair Enough. Have a good one!");
                Environment.Exit(0);
            }
            Console.WriteLine("");
            Console.WriteLine("Ok. Go ahead make your bid.");
            int table0 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication Table: {table0}");
            for (k = 1; k <= length; k++)
            {
                Console.WriteLine(k * table0);
            }
        }
    }
}
