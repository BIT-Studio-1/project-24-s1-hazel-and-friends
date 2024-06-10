using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;

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
            static void task2()
            {
                Console.WriteLine("Task 2");
                Console.WriteLine("Press any key to return");
                Console.ReadLine();
            }
            static void task3()
            {
                Console.WriteLine("Task 3");
                Console.WriteLine("Press any key to return");
                Console.ReadLine();
            }
            static void task4()
            {
                Console.WriteLine("Task 4");
                Console.WriteLine("Press any key to return");
                Console.ReadLine();


            }

            static void task5()
            {
                String temp;
                Console.WriteLine("Do you wish to enter room 5?");
                temp = Console.ReadLine().ToLower();
                if (temp.Equals("y"))
                {
                    Console.Clear();
                    room5();
                }
                else if (temp.Equals("n"))
                {
                    Console.WriteLine("You stayed");
                    Main();
                }

            }


            static void room5()
            {
                List<string> items = new List<string>();        //Just trying something
                int temp;
                Console.Write("Room 5");
                Console.WriteLine("Clear, box with resources, bandages or etc...");
                Console.WriteLine("1- Select box\n2-bandages\n3- etc");
                temp = Convert.ToInt32(Console.ReadLine());

                switch (temp)
                {
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

--------------------------------------------------------------------------------------------------------------------------------------------------
- ~~	* ~	* ~	~`	*	~	`	`*	`	*`			~		*	`  ~      `		 -
- _______________________________________________________________________________	*   ~		  *	 *		*	 	 -
-||___________________________________________________________||____         ____|  `		`*	 `		`*	    *		 -
-||				*			      ||____	     ____|    _________			*	    ~ `	 	 *	 -
-||		*	*	~	*	*	*     ||____         ____|   | _______ |    *  _____________________________		 -
-||          ~              	*		*	      ||____	     ____|   | [Guard] |      |	   |    |      []   |       |	    * 	 -
-||	*		*				      ||____ Showers ____|   | [Tower] |      |	   |    |[]	    | Armory|	* 	 -
-|| 		*	      Courtyard		*	      ||____	     ____|   | [__3__] |      |	   |    |           |       | 		 -
-||	~					~	*     ||____	     ____|   |_________|      |Bath|Bath|[]	    |_____  |     *	 - 
-||		~		~	*		      ||____	     ____| 		  *   |Room|Room|  Offices	    |	 	 -
-||	*              *          *      ~     	*	      ||____	     ____|	* *           |	   |    |         []        | 	    *	 -
-|\   ________________________________________________________||                 | 	~	*     |	   |    |		    |	 	 -
-|   |_________________________________________________________|_______    ______|____________________|	|__|__| |		  []| *		 -
-| 														| []     []         |	  *	 -
-| 																  []|		 -
-|______________________________     _________________________________________________________________    ______|___________________|	*	 -
-                           |           | 		*		*	*		*     |	  _____	  	            |	   *	 -
-   `     	~	    |           | 	*	 _________	   * `   `	~	      |	 |_____|~~~~~~~~~~~~~~~~~~| |    	 -
-         *                 | CellBlock | *	~	| _______ |    * ~       ~	 *	      |	 |	Visitor	    	    |	  *   *	 - 
-     ~    	*	    |     2	|  *		| [Guard] |			    *	 ~    |	 |	Room	  	    |	 	 -
-                     ~     |	        | ~	 *	| [Tower] |              *                    |  |  []   []         []  []  |    *       -
-~ `			    |           |		| [__1__] |	*	   *    `       *     |	 |_______________  _________|____________-______	  
-       *  		    |           |     *		|_________|		`		      |	 			    |[]                 \
-        	    `	    |           | 					*	  *	      |	 	  Reception		       EXIT     
-       ~   `               |___     ___| *	~  * ~     * `~		*	`		      |		  		    
-         			|   | 	   *			*   ~		~		~     |____________________________|____________ ______/		 
-        *		*	|   | 	~	* 	~    *		*			~					         -
-            `    ~             |   |          _________________________________ 	`		  *		  *	~     *   *      -
-    ~    			|   |	      | 	  |	   |            |              *       		 				 -
-         	 ~         	|   |	      | 	    Library             |   *     ~            ~ 		*	     ~           -
-        *	        ________|   |_________|       ____|________|______      |                     *			~			 -
-        	       | []  []	      []  []  |       |	     ~            |     |      *               	  ~			 *		 -
-      ~  	       | []  []	      []  []  |       |	  *        *      |     |            *        		  *		~		 -
-        	  ~    | []  []	      []  []  |       |	      *    ~      |     |    *			*   ~			   *	 	 -
- 	    *          | []  []	      []  []  |       |	 *  `       *     |     |              *         	     ~	 _________	         -
-   *     	       | []  []	      []  []  |       |           `       |     |_________________________	~	| _______ | *	         -
-         ~	       |      Cafeteria	              |  `     *     `    |                   |      	  |	*	| [Guard] |		 -
-     *    	 *     |         	              |    `         *    |                         V     |		| [Tower] |		 -
-   ___________        | []  []	      []  []  |       |      *            |      _____________| CellBlock |*		| [__2__] |		 -
-   |  _____  |        | []  []	      []  []  |       |   *	`    `    |     |             |     1	  |		|_________|	 *	 -
-   | [Guard] |	   ~   | []  []	      []  []  |       | `	~     *   |     |             |     	  |*				         -
-   | [Tower] |	*      | []  []	      []  []  |       |    `	  *       |     |             |   	  |			*		 -
-   | [__4__] |        | []  []	      []  []  |       |  *	          |     | 	~     |*	~ |	*	~			 -
-   |_________|        |______________________|       |    `     *   *    |     | 	      |___________|				*	 - 
-        	                 	      |       |___________________|     |   *		~			    			 -
-        	*    ~       *		      |	      |	                  |     | 	*		~	~		*		 -
-     *      ~     		  ~	      |	              Rec  	        | 			*		  *			 - 
-                	*		      |	    	     Room               | 							*	 -
-      *     ~                      ~         |_______|___________________|_____| 	~	~						 -
- 		*					*							*				 -
- 				*				*	~		*				*			 - 
--------------------------------------------------------------------------------------------------------------------------------------------------";
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
                //Console.WriteLine("You see a man from a distance, you walk up to him and lightly tap him on the shoulder");
                //Console.WriteLine("He doesn't turn around");
                //Console.WriteLine("He's bleeding...");
                //Console.WriteLine("The man slowly turns around and groans \n HELP ME... PLEASE");
                Console.WriteLine("You decide to go right, all you see is a series of lined  metal doors - no doubt leading to cells or storage rooms.");
                Console.WriteLine("Your footsteps echo ominously as you make your way forward. ");
                Console.WriteLine("Suddenly, a faint sound catches your attention.");
                Console.WriteLine("All you hear is a muffled groan, coming from just around the corner.");
                Console.WriteLine("You pause, your heart pounding, and slowly look ahead");
                Console.WriteLine("There, in a pool of blood, lies a figure, unmoving.");
                Console.WriteLine("As your heart races even faster, you approach cautiously.");
                Console.Beep((int)60, 100);
                Console.WriteLine("You try and focus your eyes in the darkness and you slowly start to see the form of a battered man.");
                Console.WriteLine("As you get closer, you notice he's a fellow cellmate and his uniform is all tattered and covered in blood.");
                Console.WriteLine("He turns his head weakly, his eyes widening as he sees you.");
                Console.WriteLine("Please...he rasps, his voice barely above a whisper. Help me.");
                Console.WriteLine("Would you like to help him (H) or are you going to ignore him(I)");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "H")
                {
                    Console.WriteLine("You tear a piece of your shirt and pass it to him \n He presses the piece of cloth onto his neck where it looked like he was badly scratched and attacked");
                    Console.WriteLine("He manages to say, coughing up a mouthful of blood.");
                    Console.WriteLine("They took... my keys.");
                    Console.WriteLine("You glance down and notice him holding a set of keys.");
                    Console.WriteLine("Hold on, you say, reaching for the keys. I may be able to use these to help us escape.");
                    Console.WriteLine("The man nods weakly, a faint smile crossing his lips. Take them... use them well and make sure that....");
                    inventory[1] = "Key";
                    Console.WriteLine("INVENTORY UPDATED");
                    for (int i = 0; i < inventory.Length; i++)
                    {
                        Console.WriteLine(inventory[i]);
                    }

                    Console.WriteLine("Just before your fellow cellmate was about to finish what he was saying, he falls onto the ground and starts getting zombie possessed");
                    Console.WriteLine("RUN!!!!");
                }


                if (choice == "I")
                {
                    Console.WriteLine("You look down at the wounded prisoner, his pleading eyes desperate for help.\n  But the risks of assisting him seem too great, and the chance of your own escape feels more important.");
                    Thread.Sleep(600);
                    Console.WriteLine("With a heavy heart, you turn your back and continue down the hallway. \n The prisoner's faint cries echo behind you.");
                    Thread.Sleep(600);
                    Console.WriteLine("The keys he mentioned could be a valuable resource, but at what cost?\n You push the guilt aside, knowing that your own survival  is a priority ");
                    Console.WriteLine("You continue to make your way through the prison");
                }



                Console.WriteLine("You reach the bottom of the stairs, all the cell doors are open as well. You see a sign with the words 'corridor'. Would you like to enter the 'corridor'? Yes (y) or No (n)");
                char answer = char.Parse(Console.ReadLine());
                if (answer == 'y')
                {
                    Corridor();
                }
                else
                {
                    Console.WriteLine("You stayed in cell blocks");
                    Console.WriteLine("You stayed in cell blocks, you feel a sharp pain on your neck");
                    Console.WriteLine("You fall to the ground, your vision starts blur and you embrace death.");
                    Console.ReadKey();
                    task1();
                }
                static void Corridor()
                {

                    Console.WriteLine("You enter a long corridor \nyou begin to walk down it. \n you see 2 bodies lying on the floor.");
                    Console.WriteLine("Do you want to check the bodies, Yes 'y' or No 'n'");
                    char answer = char.Parse(Console.ReadLine());
                    if (answer == 'y' || answer == 'Y')
                    {
                        Console.WriteLine("You check the bodies each of them have bite marks on different areas of their bodies");
                        Console.WriteLine("They both start to move and swiftly attack you. \nYou died");
                        task1();

                    }
                    else if (answer == 'n' || answer == 'N')
                    {
                        Console.WriteLine("You move past them ignoring them and continue walking down the corridor");
                        Console.WriteLine("You reach the end and see 2 signs with arrows pointing in different directions");
                        Console.WriteLine("Left going to 'Library' and right going to 'Rec room'");
                        Console.WriteLine("Which way do you want to go? \n");
                        char direction = char.Parse(Console.ReadLine());
                        if (direction == 'L' || direction == 'l')
                        {
                            Library();
                        }
                        else if (direction == 'R' || (direction == 'r'))
                        {
                            Recroom();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please choose 'L' for Library or 'R' for Rec Room ");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose 'Y' for Yes or 'N' for No");
                    }

                    static void Library()
                    {
                        string temp;
                        bool explore = true;

                        Console.WriteLine("You walk down corridor and open the library doors");
                        Thread.Sleep(1000);
                        Console.WriteLine("You see that the room is a mess. Books scattered every where on the ground it's a total mess");
                        Thread.Sleep(1000);
                        Console.WriteLine("You enter the room, closing the door behind you, would you like to explore? \nYes (y) or No (n)?");
                        Thread.Sleep(1000);
                        char answer = char.Parse(Console.ReadLine());
                        if (answer == 'y' || answer == 'Y')
                        {
                            {
                                Console.WriteLine("You search around the room, seeing piles and piles of books on the ground.");
                                Thread.Sleep(1000);
                                Console.WriteLine("Would you like to investigate? Yes 'y' or No 'n'?");
                                char investigate = char.Parse(Console.ReadLine());
                                if (investigate == 'y' || investigate == 'Y')
                                {
                                    Console.WriteLine("You step on a piece of paper");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Pick up Yes (y) or No (n)?");
                                    char pickUp = char.Parse(Console.ReadLine());
                                    if (pickUp == 'y' || pickUp == 'Y')
                                    {
                                        Console.WriteLine("You pick up the piece of paper and examine it.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("On further examination you see that it is the map of the prison");
                                        inventory[2] = "Map";
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You examine the map carefully slowly growing board of it,\nyou scrunch up the map and put it into your pocket and move on");
                                        Thread.Sleep(1000);


                                    }
                                    else if (pickUp == 'n' || pickUp == 'N')
                                    {
                                        Console.WriteLine("You leave the piece of paper on the ground.");
                                        Thread.Sleep(1000);

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You decide not to look at the paper");
                                    Thread.Sleep(1000);
                                }
                                Console.WriteLine("You venture deeper into the library walking into a maze of bookshelfs ");
                                Thread.Sleep(1000);
                                Console.WriteLine("You find yourself lost, each direction look unfimilliar \nYou look left, right, straight and up");
                                Thread.Sleep(1000);
                                Console.WriteLine("What is your next move?");

                                while (explore)
                                {
                                    temp = Console.ReadLine().ToLower();
                                    switch (temp)
                                    {
                                        case "left":
                                            Console.WriteLine("You find yourself back at where you started");
                                            Console.WriteLine("Everything seems to be the same, you walk back into the maze to try again");
                                            break;
                                        case "right":
                                            Console.WriteLine("You exit the maze to see a door with the words 'Cafeteria' on it");
                                            Console.WriteLine("You feel your stomach growling, it's been a while since you have eaten");
                                            Console.WriteLine("YOu let your stomach control your actions \nYou walk towards the door and enter the cafeteria.");
                                            Cafeteria();
                                            break;
                                        case "up":
                                            Console.WriteLine("You are too indecisive to make a choice");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("You look up and decide to get a better view");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("You start to climb up the bookshelf \nYou feel it wobble and shake");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("You lose your footing and fall to your death");
                                            Thread.Sleep(1000);
                                            Main();
                                            break;
                                        default:
                                            Console.WriteLine("Invalid input. Please enter 'left', 'right', or 'up'.");
                                            break;

                                    }
                                }


                            }
                        }
                        else
                        {
                            Console.WriteLine("You decide not to search the room.");
                        }
                    }

                    static void Recroom()
                    {
                        Random rand = new Random();
                        for (int i = 0; i < 10; i++)
                        {
                            int frequency = rand.Next(100, 2000);
                            int duration = rand.Next(50, 400);
                            Console.Beep(frequency, duration);
                            System.Threading.Thread.Sleep(100);
                        }
                        Console.WriteLine("You reached the recreation room, a safe spot for now");
                        Console.WriteLine("   _______\r\n  | Rec   |\r\n  | Room  |\r\n  |       | \r\n  | o     | \r\n  |_______|\r\n");
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        Console.WriteLine("Your heart is racing as you look for a hiding spot. You find a strong table at the corner of the room");
                        Thread.Sleep(3000);
                        Console.WriteLine("");
                        Console.WriteLine("HURRY TYPE    'HIDE'    IN ALL CAPS TO HIDE UNDER THE TABLE");
                        string temp = "";



                        while (temp != "HIDE")


                            Console.WriteLine("  \r\n ********  *********  ********* ********* ******** ******** *********  *  *********\r\n *         *       *  *         *             *    *        *       *  *  *       *\r\n *         *********  ********  *********     *    ******** ********   *  *********\r\n *         *       *  *         *             *    *        *   *      *  *       *\r\n ********  *       *  *         *********     *    ******** *      *   *  *       *     ");
                        Console.WriteLine("  ( (\r\n   ) )\r\n   ____\r\n  |    |\r\n  |    |]|\r\n  |____| \r\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("You push open the heavy doors and step into the cafeteria,");
                        Thread.Sleep(400);
                        Console.WriteLine("The dim lighting casting long shadows across the empty tables and benches.");
                        Thread.Sleep(400);
                        Console.WriteLine("As you scan the room, your eyes quickly adjust, and you begin to take note of your surroundings. ");
                        Thread.Sleep(400);
                        Console.WriteLine("The cafeteria is surprisingly well stocked, with several stainless steel counters lining the walls, each containing various supplies and equipment.");
                        Thread.Sleep(400);
                        Console.WriteLine("As you take a closer look, you notice that some of these counters have locks on them");
                        Thread.Sleep(400);
                        Console.WriteLine("Your gaze shifts to a stack of metal trays, their sharp edges glinting in the faint light.");
                        Thread.Sleep(400);
                        Console.WriteLine("Nearby, you spot a collection of dull-looking utensils forks, knives, and spoons  that could potentially be used again as makeshift weapons.");
                        Thread.Sleep(400);
                        Console.WriteLine("Further down, you notice a rack of plastic cups, each filled with a murky liquid that you assume is water.");
                        Thread.Sleep(400);
                        Console.WriteLine("The cups could be useful for carrying liquid or even as improvised tools but eww.");
                        Thread.Sleep(400);
                        Console.WriteLine("As you continue to explore the cafeteria, your attention is drawn to a set of shelves lining the back wall.");
                        Thread.Sleep(400);
                        Console.WriteLine("Upon closer inspection, you see that are some bags of dried food and a few sealed bottles of water.");
                        Thread.Sleep(400);
                        Console.WriteLine("These supplies could be valuable in your quest for survival in the WALKING JAIL.");
                        Thread.Sleep(400);
                        Console.WriteLine("Which of these items would you like to gather, (food or water)?");
                        string choice = Console.ReadLine();
                        if (choice == "food")
                        {
                            inventory[4] = "food";
                            Console.WriteLine("You grab the bags of dried food and stuff them in your pockets");
                            Console.WriteLine("Wold you like to grab any other item y/n?");
                            char user = char.Parse(Console.ReadLine());
                            if (user == 'y')

                            {
                                temp = Console.ReadLine();

                                if (temp != "HIDE")
                                {
                                    Console.WriteLine("TRY AGAIN HURRY!!!!!");
                                    Console.WriteLine("HURRY TYPE    'HIDE'    IN ALL CAPS TO HIDE UNDER THE TABLE");
                                }
                            }

                            Console.WriteLine("You're hiding behind A table in the prison's game room.");
                            Thread.Sleep(2000);
                            Console.WriteLine("");
                            Console.WriteLine("There are no lights and its hard to see but you can hear scary noises outside, like moans and shuffling. It's a zombie.");
                            Thread.Sleep(5000);
                            Console.WriteLine("");
                            Console.WriteLine("Its skin was decaying, and its clothes were in tatters. But what truly made it horrifying were its gruesome injuries.");
                            Console.WriteLine("         .-\"\"\"-.\r\n        /       \\\r\n       |  O   O  |\r\n       |    ∆    |\r\n        \\ ----- /\r\n     ____|_____|____\r\n   /  ______(O)______\\\r\n   \\_/  [_____]'   [___] \r\n");
                            Thread.Sleep(5000);
                            Console.WriteLine("");
                            Console.WriteLine("You look around for a better hiding spot and see a dark corner. You try to sneak over there, but then you see the zombie stumble into the room.");
                            Thread.Sleep(5000);
                            Console.WriteLine("");
                            Console.WriteLine("Its eyes are creepy and it's looking for someone to eat.");
                            Thread.Sleep(3000);
                            Console.WriteLine("");
                            Console.WriteLine("You freeze as the zombie's gaze lands on you.");
                            Thread.Sleep(3000);
                            Console.WriteLine("");
                            Console.WriteLine("You scan the room quickly, searching for a safer place to hide.");
                            Thread.Sleep(4000);
                            Console.WriteLine("");
                            Console.WriteLine("You see a sturdy-looking cabinet against the far wall, it seems like a better option than your current spot behind the tables.");
                            Thread.Sleep(5000);
                            Console.WriteLine("");
                            Console.WriteLine("You notice another possibility, you see a large overturned couch near the center of the room. It's bulky and could provide better cover.");
                            Thread.Sleep(6000);
                            Console.WriteLine("");
                            Console.WriteLine("But the couch is closer to where the zombie is slowly making its way towards you.");
                            Thread.Sleep(3000);
                            Console.WriteLine("");

                            for (int i = 0; i < 3; i++)
                            {
                                Console.Beep(1000, 200);
                                System.Threading.Thread.Sleep(200);
                                Console.Beep(1500, 200);
                                System.Threading.Thread.Sleep(200);
                            }

                            Console.WriteLine("CHOOSE A PLACE TO HIDE: CLOSET(press 1)   COUCH(press 2)");
                            temp = Console.ReadLine();
                            int hide = Convert.ToInt32(temp);



                            switch (hide)
                            {
                                case 1:
                                    Console.WriteLine("You see the closet door slightly open and think it's a good hiding spot. Without much thinking, you go inside and close the door.");
                                    Console.WriteLine("");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("Inside, it's dark and cramped. You start feeling scared. There's no way out.");
                                    Console.WriteLine("");
                                    Thread.Sleep(4000);
                                    Console.WriteLine("Outside, the zombie gets closer. It finds you in the closet and opens the door. You try to hide, but there's nowhere to go.");
                                    Console.WriteLine("");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("The zombie grabs you, and you can't escape. Your mistake cost your life");
                                    break;



                                case 2:
                                    Console.WriteLine("You see the couch and think it might be a good hiding spot. It's closer and seems big enough to protect you.");
                                    Console.WriteLine("");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("You quickly hide behind the couch, holding your breath. The zombie's groans get quieter, and you start feeling safer.");
                                    Console.WriteLine("");
                                    Thread.Sleep(4000);
                                    Console.WriteLine("You wait for a long time, but eventually, the zombie's sounds go away completely.");
                                    Console.WriteLine("");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("You peek out from behind the couch and see that it's safe.");
                                    break;

                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                case 8:
                                case 9:
                                    Console.WriteLine("You choose to stay under the table");
                                    Console.WriteLine("");
                                    Thread.Sleep(3000);
                                    Console.WriteLine("You heard the zombie approaching, as it's groans grow louder.");
                                    Thread.Sleep(3000);
                                    Console.WriteLine("");
                                    Console.WriteLine("IT");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("");
                                    Console.WriteLine("SEES");
                                    Console.WriteLine("");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("YOU");
                                    Console.WriteLine("");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("The zombie lunges forward, sinking its teeth into your leg. \n You scream in agony as the zombie's terrifying cry fills the room.");
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice");
                                    break;
                            }

                            Console.WriteLine("You're hiding behind the couch in the dim rec room jail. It's dark, and you can't see much.");
                            Console.WriteLine("");
                            Thread.Sleep(4000);
                            Console.WriteLine("Your hand touches two things: a flashlight and a pool stick. You need to decide which one to pick.");
                            Console.WriteLine("");
                            Thread.Sleep(4000);
                            Console.WriteLine("The flashlight can help you see better, but the pool stick could protect you if zombies come near. \n What will you choose?");
                            Console.WriteLine("PRESS Q for  FLASHLIGHT OR PRESS W POOL StICK ");
                            temp = Console.ReadLine();
                            char item = Convert.ToChar(temp);

                            if (item == 'q' || item == 'Q')
                            {
                                Console.WriteLine("");
                                inventory[2] = "Flashlight";
                            }
                            else
                            {
                                Console.WriteLine("");
                            }
                        }

                    }
                
                    static void Cafeteria()
                    {
                        Console.WriteLine("  \r\n ********  *********  ********* ********* ******** ******** *********  *  *********\r\n *         *       *  *         *             *    *        *       *  *  *       *\r\n *         *********  ********  *********     *    ******** ********   *  *********\r\n *         *       *  *         *             *    *        *   *      *  *       *\r\n ********  *       *  *         *********     *    ******** *      *   *  *       *     ");
                        Console.WriteLine("  ( (\r\n   ) )\r\n   ____\r\n  |    |\r\n  |    |]|\r\n  |____| \r\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("You push open the heavy doors and step into the cafeteria,");
                        Thread.Sleep(400);
                        Console.WriteLine("The dim lighting casting long shadows across the empty tables and benches.");
                        Thread.Sleep(400);
                        Console.WriteLine("As you scan the room, your eyes quickly adjust, and you begin to take note of your surroundings. ");
                        Thread.Sleep(400);
                        Console.WriteLine("The cafeteria is surprisingly well stocked, with several stainless steel counters lining the walls, each containing various supplies and equipment.");
                        Thread.Sleep(400);
                        Console.WriteLine("As you take a closer look, you notice that some of these counters have locks on them");
                        Thread.Sleep(400);
                        Console.WriteLine("Your gaze shifts to a stack of metal trays, their sharp edges glinting in the faint light.");
                        Thread.Sleep(400);
                        Console.WriteLine("Nearby, you spot a collection of dull-looking utensils forks, knives, and spoons  that could potentially be used again as makeshift weapons.");
                        Thread.Sleep(400);
                        Console.WriteLine("Further down, you notice a rack of plastic cups, each filled with a murky liquid that you assume is water.");
                        Thread.Sleep(400);
                        Console.WriteLine("The cups could be useful for carrying liquid or even as improvised tools but eww.");
                        Thread.Sleep(400);
                        Console.WriteLine("As you continue to explore the cafeteria, your attention is drawn to a set of shelves lining the back wall.");
                        Thread.Sleep(400);
                        Console.WriteLine("Upon closer inspection, you see that are some bags of dried food and a few sealed bottles of water.");
                        Thread.Sleep(400);
                        Console.WriteLine("These supplies could be valuable in your quest for survival in the WALKING JAIL.");
                        Thread.Sleep(400);
                        Console.WriteLine("Which of these items would you like to gather, (food or water)?");
                        string choice = Console.ReadLine();
                        if (choice == "food")
                        {
                            inventory[4] = "food";
                            Console.WriteLine("You grab the bags of dried food and stuff them in your pockets");
                            Console.WriteLine("Wold you like to grab any other item y/n?");
                            char user = char.Parse(Console.ReadLine());
                            if (user == 'y')
                            {
                                Console.WriteLine("Now that you know where you can find some supplies, you grab yourself a bottle of water and chug it. ");

                            }
                            else if (user == 'n')
                            {
                                Console.WriteLine("You're satisfied with what you have and continue exploring the cafeteria");
                            }
                        }
                        else if (choice == "water")
                        {
                            inventory[4] = "water";
                            Console.WriteLine("You grab yourself a bottle of water and chug it");
                            Console.WriteLine("Wold you like to grab any other item?");
                            char user = char.Parse(Console.ReadLine());
                            if (user == 'y')
                            {
                                Console.WriteLine("Now that you know where you can find some supplies, you grab yourself a few packets of some dried food and stuff them in your pockets. ");

                            }
                            else if (user == 'n')
                            {
                                Console.WriteLine("You're satisfied with what you have and continue exploring the cafeteria");
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice, please choose what you would like to grab:\nfood or water");
                            }
                        }
                    }






                    static void courtyard()
                    {
                        Random Rand = new Random();
                        Console.WriteLine("You walk into the courtyard. There are zombies everywhere.");
                        Console.WriteLine("You realize that they are in a dull state and don't realize you're there yet. You might be able to sneak around them");
                        Console.WriteLine("You notice the dead prison guard at the other end of the courtyard, his body has a gun and a key card.");
                        Console.WriteLine("If you don't have a weapon on you, this could end badly.");
                        /*CREATE VARIABLE CALLED WEAPONCHECK(); AND IF IT IS TICKED THEN CREATE DIFFERENT OPTIONS FOR PLAYER */
                        Console.WriteLine("Do you sneak forward (Y) or do you leave the Courtyard (N)");
                        string usersinputs = Console.ReadLine();
                        if (usersinputs == "Y" || usersinputs == "y")
                        {
                            Console.WriteLine("You start sneaking towards the dead guard.");
                            Console.WriteLine("You step as quietly as possible around the mumbling, walking dead bodies.");
                            int randzombie = Rand.Next(1, 6);
                            if (randzombie == 3)
                            {
                                Console.WriteLine("You suddenly are thrown to the ground as a zombie jumps on top of you.");
                                Console.WriteLine("The last thing you hear is the crunching sound of your head being bitten");
                                Console.WriteLine("YOU DIED");
                                Console.Beep((int)294.2, 800);
                                Console.Beep((int)277.2, 800);
                                Console.Beep((int)262.2, 800);
                                Console.Beep((int)247.2, 1100);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("You make it to the dead guard's body. You take the key card and the gun.");
                                /*INSERT INVENTORY GET GUN AND KEYCARD CODE HERE */
                                string guardgun = "yes";
                                string keycard = "yes";
                                Console.WriteLine("Do you try sneaking back through the crowd of zombies (Y) or shoot your way out? (N)");
                                string seconduserinput = Console.ReadLine();
                                int randzombie2 = Rand.Next(1, 6);
                                if (seconduserinput == "Y" || seconduserinput == "y")
                                {
                                    Console.WriteLine("You try crawling your way past the zombies.");
                                    if (randzombie >= 3)
                                    {
                                        Console.WriteLine("You bump into a zombie's leg. It yells and tries to bite you.");
                                        Console.WriteLine("Push the zombie away (Y) or shoot it (N) ?");
                                        string thirduserinput = Console.ReadLine();
                                        if (thirduserinput == "Y" || thirduserinput == "y")
                                        {
                                            Console.WriteLine("You try to push the zombie away...");
                                            if (randzombie2 == 5)
                                            {
                                                Console.WriteLine("As you stretch out your arm, another zombie bites off your entire hand.");
                                                Console.WriteLine("The last thing you see is the zombies eating your flesh.");
                                                Console.WriteLine("YOU DIED");
                                                Console.Beep((int)294.2, 800);
                                                Console.Beep((int)277.2, 800);
                                                Console.Beep((int)262.2, 800);
                                                Console.Beep((int)247.2, 1100);
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("You pushed the zombie back and ran to the exit.");
                                                Console.WriteLine("You escaped the courtyard.");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You aim the gun and fire it at the zombie");
                                            Console.WriteLine("The rest of the zombies turn around and start moving towards you.");
                                            Console.WriteLine("Run straight for the exit (Y) or shoot the zombies as you go (N)?");
                                            string fourthuserinput = Console.ReadLine();
                                            if (fourthuserinput == "Y" || fourthuserinput == "y")
                                            {
                                                Console.WriteLine("You run straight for the exit and escape the Courtyard.");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("You try to shoot the zombies as you move towards the exit");
                                                if (randzombie2 == 5)
                                                {
                                                    Console.WriteLine("You try to shoot the zombie in front of you by putting the barrel against the zombie's temple.");
                                                    Console.WriteLine("Your gun jams.");
                                                    Console.WriteLine("You are paralyzed in fear as the zombie proceeds to bite your fingers off the gun.");
                                                    Console.WriteLine("The last thing you see is the zombies eating your flesh.");
                                                    Console.WriteLine("YOU DIED");
                                                    Console.Beep((int)294.2, 800);
                                                    Console.Beep((int)277.2, 800);
                                                    Console.Beep((int)262.2, 800);
                                                    Console.Beep((int)247.2, 1100);
                                                    Console.ReadLine();
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You escaped the courtyard.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You aim the gun at the nearest zombie and fire");
                                    Console.WriteLine("The rest of the zombies turn around and start moving towards you");
                                    Console.WriteLine("You try to shoot the zombies as you move towards the exit");
                                    if (randzombie2 == 5)
                                    {
                                        Console.WriteLine("You try to shoot the zombie in front of you by putting the barrel against the zombie's temple.");
                                        Console.WriteLine("Your gun jams.");
                                        Console.WriteLine("You are paralyzed in fear as the zombie proceeds to bite your fingers off the gun.");
                                        Console.WriteLine("The last thing you see is the zombies eating your flesh.");
                                        Console.WriteLine("YOU DIED");
                                        Console.Beep((int)294.2, 800);
                                        Console.Beep((int)277.2, 800);
                                        Console.Beep((int)262.2, 800);
                                        Console.Beep((int)247.2, 1100);
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("You escaped the Courtyard.");
                                        Console.ReadLine();
                                    }
                                    Console.WriteLine("You escape the courtyard, and left behind a pile of corpses.");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("You leave the courtyard and instead go to the showers further down the corridor");
                            /* showers(); */
                            Console.ReadLine();
                        }
                        Console.ReadLine();
                    }



                    Console.ReadLine();


                }


            }
        }
    }
}





