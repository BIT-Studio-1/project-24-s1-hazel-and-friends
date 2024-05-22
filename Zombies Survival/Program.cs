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

                    case 0:
                        Console.WriteLine("Exit");
                        break;

                }

            } while (tasks != 0);

        }
        public static void task1()
        {
            Console.WriteLine("You reach the bottom of the stairs, all the cell doors are open as well. You see a sign with the words 'cafeteria'. Would you like to enter the 'cafeteria' or explore the cells more? ");
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


    }


}


