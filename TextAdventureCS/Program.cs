using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Originally made by Sietse Dijks
// Releasedate: 18-01-2014
// Current version: 1.5
// Last changes by: Michiel Pot and Alex van Pelt
// Change Date: 09-01-2015

namespace TextAdventureCS
{
    
    class Program
    {
        static int progression = 0;
        const string MOVE_NORTH = "Go North";
        const string MOVE_WEST = "Go West";
        const string MOVE_SOUTH = "Go South";
        const string MOVE_EAST = "Go East";
        
        
        static List<string> validDirections = new List<string> 
        {
            MOVE_NORTH, 
            MOVE_WEST, 
            MOVE_SOUTH, 
            MOVE_EAST        
        };

        
        const string ACTION_SEARCH = "Search";
        const string ACTION_FIGHT = "Fight";
        const string ACTION_RUN = "Run";
        const string ACTION_QUIT = "Exit";
        
        static SText stext = new SText();

        static Information info = new Information();

        static Player player = new Player("James Vicary");
        static Map map = new Map(4,4,2,0);

        static void Main(string[] args)
        {
            Welcome(ref player);
            InitMap(ref map);
            Start(ref map, ref player);
            Quit();
        }

        static void Welcome(ref Player player)
        {
            string[] menuArray = new string[4] {"Start the game", "Options", "Credits","Quit"};
            ConsoleKeyInfo keyinfo;
            int selectPosition = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                for (int i = 0; i < menuArray.Length; i++)
                {
                    if (selectPosition == i)
                        Console.WriteLine("\t\t\t<{0}>", menuArray[i]);
                    else
                        Console.WriteLine("\t\t\t {0} ", menuArray[i]);
                }
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.UpArrow && selectPosition != 0)
                    selectPosition--;
                else if (keyinfo.Key == ConsoleKey.DownArrow && selectPosition != menuArray.Length)
                    selectPosition++;


            } while (keyinfo.Key != ConsoleKey.Enter);
        }

        static void InitMap(ref Map map)
        {
            // Add locations with their coordinates to this list.
            Home home = new Home("Home");
            map.AddLocation(home, 0, 2);
            Church church = new Church("Old Chapel");
            map.AddLocation(church, 1, 2);
            Swamp swamp = new Swamp("Bog");
            map.AddLocation(swamp, 0, 1);
            University uni = new University("University");
            map.AddLocation(uni, 0, 3);
        }

        static void Start(ref Map map, ref Player player)
        {
            List<string> menuItems = new List<string>();
            int choice;

            do
            {
                Console.Clear();
                choice = ShowMenu(map, ref menuItems,player);
                Dictionary<string, Objects> list = map.GetLocation().GetItems();
                Objects[] obj = list.Values.ToArray();

                if ( choice != menuItems.Count() )
                {
                    if (validDirections.Contains(menuItems[choice]))
                    {
                        map.Move(menuItems[choice]);
                    }
                    switch (menuItems[choice])
                        {
                            case ACTION_SEARCH:
                                if (player.lookItem(map, 0))
                                {
                                    player.PickupItem(obj[0]);
                                    info.infoText = (obj[0].GetName() + " Has had to your inventory");
                                }                             
                                break;

                            case ACTION_FIGHT:
                                // Add code for fighting here
                                break;

                            case ACTION_RUN:
                                // Add code for running here
                                break;
                        }
                }
                
            } 
            while ( choice < menuItems.Count() - 1);
        }

        // This Method builds the menu
        static int ShowMenu(Map map, ref List<string> menu,Player player)
        {
            int selectPosition = 0;
            ConsoleKeyInfo keyinfo;

            menu.Clear();
            ShowDirections(map, ref menu);
            
            if (map.GetLocation().CheckForItems())
            {
                bool acquirableitems = false;
                Dictionary<string, Objects> list = map.GetLocation().GetItems();
                Objects[] obj = list.Values.ToArray();
                for (int i = 0; i < obj.Count(); i++)
                {
                    if (obj[i].GetAcquirable())
                        acquirableitems = true;
                }
                if(acquirableitems)
                    menu.Add( ACTION_SEARCH );
            }
            if (map.GetLocation().HasEnemy())
            {
                menu.Add( ACTION_FIGHT );
                menu.Add( ACTION_RUN );
            }
            menu.Add( ACTION_QUIT );

            
            do
            {
                Console.Clear();
                map.GetLocation().Description();
                if (info.infoText != "")
                {
                    info.AddInfoMessage();
                    info.infoText = "";
                }
                else
                    Console.WriteLine();
                for (int i = 0; i < menu.Count(); i++)
                {
                    if (i == selectPosition)
                        Console.WriteLine("<{0}>", menu[i]);
                    else
                        Console.WriteLine(" {0} ", menu[i]);
                }


                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.DownArrow && selectPosition != menu.Count)
                    selectPosition++;
                else if (keyinfo.Key == ConsoleKey.UpArrow && selectPosition != 0)
                    selectPosition--;
                else if (keyinfo.Key == ConsoleKey.E)
                {
                    if (!player.ShowInventoryMenu())
                        info.infoText = ("Sorry there are none items in your inventory");

                }
                //Console.Beep();
            } while (keyinfo.Key != ConsoleKey.Enter);
            return selectPosition;

            //return choice;
        }

        static void ShowDirections(Map map, ref List<string> items)
        {
            map.AllowedDirections();

            if (map.GetNorth() == 1)
                items.Add( MOVE_NORTH );
            if (map.GetEast() == 1)
                items.Add( MOVE_EAST );
            if (map.GetSouth() == 1)
                items.Add( MOVE_SOUTH );
            if (map.GetWest() == 1)
                items.Add( MOVE_WEST );
        }

        static void Quit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for playing and have a nice day!");
            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();
        }       
    }
}