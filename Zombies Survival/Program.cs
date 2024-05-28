using System.Collections.Generic;
using System.ComponentModel;

namespace Skeleton_Program
{
    internal class Program
    {
        static string[] inventory = new string[10];

        static void Main()
        {
            
            int tasks;
            do
                
            {
                Console.Clear();
                Console.WriteLine("The Walking Jail: \n1 Play game \n2 Instructions \n3 Options \n4 Credits \n0 Exit game");
                tasks = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (tasks)
                {
                    case 1:

                        introduction();
                        break;

                    case 2:

                        task2();
                        break;

                    case 3:

                        task3();
                        break;
                    case 4:

                        task4();
                        break;

                    case 5:
                        task5();
                        break;

                    case 0:
                        Console.WriteLine("Exit");
                        break;

                }

            } while (tasks != 0);

        }
        public static void introduction()
        {
            Console.WriteLine("INTRODUCTION");
            Console.WriteLine("------------");
            Console.WriteLine("You wake up to the sound of knocking at your door, it's your landlord.");
            Console.WriteLine("She says you are behind on the rent again, you explain how you got fired and it's not your fault but she doesn't care.");
            Console.WriteLine("She demands you pay your rent by tonight or else you'll be kicked out onto the street.");
            Console.WriteLine("To calm down and come up with ideas, you decide to go for a walk.");
            Console.WriteLine("");
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();
            Console.WriteLine("------------");
            Console.WriteLine("After walking through town thinking about all the bad choices you've made, you notice a vacant mansion across the street.");
            Console.WriteLine("All the curtains are open, no one looks like they're inside and there are no cars in the driveway.");
            Console.WriteLine("You peek into the curtains and notice various expensive-looking objects you could sell.");
            Console.WriteLine("You also remember you need the money for your rent. By tonight.");
            Console.WriteLine("");
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();
            Console.WriteLine("------------");
            Console.WriteLine("You picklock the door with the picklocks you keep in your pocket, and start exploring and pocketing items in the house.");
            Console.Beep((int)592.2, 1000);
            Console.Beep((int)370.2, 1000);
            Console.Beep((int)592.2, 1000);
            Console.Beep((int)370.2, 1000);
            Console.WriteLine("After filling your pockets, you suddenly hear a police siren getting closer and closer.");
            Console.WriteLine("You try to make a run for it onto the streets, but the cops are already there, waiting for you.");
            Console.WriteLine("");
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();
            Console.WriteLine("------------");
            Console.WriteLine("After 3 years, you're very tired of being in prison.");
            Console.Beep((int)294.2, 800);
            Console.Beep((int)277.2, 800);
            Console.Beep((int)262.2, 800);
            Console.Beep((int)247.2, 1100);
            Console.WriteLine("you and you're cellmate are in your cell when suddenly you hear screaming.");
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("The riot alarm has been sounded and all the cell doors suddenly fly open.");
            Console.Beep((int)772.2, 100);
            Console.Beep((int)772.2, 100);
            Console.Beep((int)772.2, 100);
            Console.Beep((int)772.2, 100);
            Console.Beep((int)772.2, 100);
            Console.Beep((int)772.2, 100);
            Console.Beep((int)772.2, 100);
            Console.Beep((int)772.2, 100);
            Console.Beep((int)772.2, 100);
            Console.Beep((int)772.2, 100);
            Console.WriteLine("The halls are filled with prisoners shouting and running.");
            Console.WriteLine("You try to step out of your cell, but your cellmate knocks you out cold before you can step through the doorway.");
            Console.WriteLine("");
            Console.WriteLine("------------");
            Console.WriteLine("You wake up, feeling nauseous and uncomfortable, probably from sleeping on the cold prison floor for two days straight.");
            Console.WriteLine("The prison is much quieter than usual, and the cell doors are all still open.");
            Console.WriteLine("");
            Console.ReadLine();
            task1();
        }
        public static void task1()
        {

            string temp;

            string map = @"
_________________________________________________________________________
| 							                |                    
| 							                |                    
| 							    ______      |                    
| 							          |     |                    
| 							          |     |                    
| 						                  |     |                    
| 						                  |     |       	     
| 						                  |     |_____________________
| 					                          |                   |      |
| 						                  |                     START| 
| 					                          |      _____________|______|
| 							          |     |                  
| 							          |     |                  
| 							          |     |                
| 							          |     | 
| 							          |     |
| 							    ______|     |
| 							                |
| 							                |
| 							                |
|_______________________________________________________________________|";
            Console.WriteLine(map);


            Console.WriteLine("Which way do you want to go right (r) or left (l)?");

            char user = char.Parse(Console.ReadLine());

            if (user == 'l')

            {
                Console.WriteLine("You leave your cell and turned to the left and you saw a fellow inmate standing with his back facing you");
                Console.WriteLine("You go up to him and asked him what happened and where everyone is, you get close to him and as you are about to tap his shoulder");
                Console.WriteLine("He turns around, his face is covered in blood. You stumble backwards, you see him lunge at you, you swiftly dodge around him");
                Console.WriteLine("You see the stair, you run towards them and go down ");
                Console.ReadLine();
            }
            if (user == 'r')
            {
                Console.WriteLine("You see a man from a distance, you walk up to him and lightly tap him on the shoulder");
                Console.WriteLine("He doesn't turn around");
                Console.WriteLine("He's bleeding...");
                Console.WriteLine("The man slowly turns around and groans \n HELP ME... PLEASE");
                Console.WriteLine("Would you like to help him (H) or are you going to ignore him(I)");
                string choice = Console.ReadLine().ToUpper();
            if (choice == "H")
            {
                Console.WriteLine("You tear a piece of your shirt and pass it to him \n He presses the piece of cloth onto his neck where it looked like e was badly scratched and attacked");
                Console.WriteLine("The man clearly looks like he's dying:(");
                Console.WriteLine("He thanks you and gives you a key to another part of the prison");
                inventory[1] = "Key";
                Console.WriteLine("INVENTORY UPDATED");
                for (int i = 0; i < inventory.Length; i++)
                {
                        Console.WriteLine(inventory[i]);
                }
                Console.WriteLine($"The man says, I was able to grab these keys from one of the gaurds... This key should be able to unlock..");
                Console.WriteLine("Just before the man was about to finish what he was saying, he falls onto the ground and starts getting zombie possessed");
                Console.WriteLine("RUN!!!!");
            }
            
            }
            Console.WriteLine("You reach the bottom of the stairs, all the cell doors are open as well. You see a sign with the words 'cafeteria'. Would you like to enter the 'cafeteria'? Yes (y) or No (n)");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'y')
            {
                Cafeteria();
            }
            else
            {
                Console.WriteLine("You stayed in cell blocks");
            }
            Console.ReadLine();



        }
        public static void task2()
        {
            Console.WriteLine("Task 2");
            Console.WriteLine("Press any key to return");
            Console.ReadLine();
        }
        public static void task3()
        {
            Console.WriteLine("Task 3");
            Console.WriteLine("Press any key to return");
            Console.ReadLine();
        }
        public static void task4()
        {
            Console.WriteLine("Task 4");
            Console.WriteLine("Press any key to return");
            Console.ReadLine();


        }

        public static void task5(){
            String temp;
            Console.WriteLine("Do you wish to enter room 5?");
            temp = Console.ReadLine().ToLower();
            if (temp.Equals("y")) {
                Console.Clear();
                room5();
            }else if (temp.Equals("n"))
            {
                Console.WriteLine("You stayed");
                Main();
            }
            
            }


    public static void room5()
        {
            List<string> items = new List<string>();        //Just trying something
            int temp;
            Console.Write("Room 5");
            Console.WriteLine("Clear, box with resources, bandages or etc...");
            Console.WriteLine("1- Select box\n2-bandages\n3- etc");
            temp = Convert.ToInt32(Console.ReadLine());

            switch (temp) { 
                case 1:
                    Console.WriteLine("You select the box");
                    break;
                    case 2:
                    Console.WriteLine("You select bandages");
                    items.Add("2 bandages");
                    items.Add("3 mags of 9mm bullets");
                    Console.WriteLine($"You now have ....");

                    break;
                    case 3:
                    Console.WriteLine("idk bro");
                    break;

                default:
                    Console.WriteLine("Choose a number");
                    break;
                    
            }
            Console.ReadLine();
        }

        static void Cafeteria()
        {
            Console.WriteLine();
        }

    }


}


