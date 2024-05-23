using System.Collections.Generic;
using System.ComponentModel;

namespace Skeleton_Program
{
    internal class Program
    {
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

                        task1();
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
        public static void task1()
        {

<<<<<<< HEAD
=======
            string temp;




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
                Console.WriteLine("You see a man from a distance, you walk up to him and tap him on the shoulder");
                Console.WriteLine("He doesn't turn around");
                Console.WriteLine("He's bleeding...");
                Thread.Sleep(400);
                Console.WriteLine("What could be wrong with him");
                Console.WriteLine(".");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("...");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("....");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(".......");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(".........");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("RUN!!!!");
                Console.ReadLine();
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


>>>>>>> 89537b88433a16bef42fb675cd3e6bf79d6c63d9
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

<<<<<<< HEAD
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
=======
        static void Cafeteria()
        {
            Console.WriteLine();
        }

>>>>>>> 89537b88433a16bef42fb675cd3e6bf79d6c63d9
    }


}


