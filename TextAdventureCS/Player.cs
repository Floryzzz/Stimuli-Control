using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Player : Actor
    {
        private Dictionary<string, Objects> inventory;
        public Player(string name)
            : base(name)
        {
            inventory = new Dictionary<string, Objects>();
        }

        public void DropItem(string itemName)
        {
            if (HasObject(itemName))
            {
                inventory.Remove(itemName);
                Console.WriteLine("{0} is removed from your inventory",itemName);
                ShowInventoryMenu();
                Console.WriteLine("Press a key to continue..");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your inventory does not contain an item");
                Console.WriteLine("with the name {0}. Please try again.", itemName);
                Console.WriteLine("Press a key to continue..");
                Console.ReadKey();
            }
        }

        public void PickupItem(Objects obj)
        {
            // Add an if-statement here when you want to have a maximum number of items
            inventory.Add(obj.GetName(), obj);
            obj.SetIsAcquirable(false);
        }
        public bool lookItem(Map map, int InvIndex)
        {
            Dictionary<string, Objects> list = map.GetLocation().GetItems();
            Objects[] obj = list.Values.ToArray();
            int selectPosition = 0;
            ConsoleKeyInfo keyinfo;
            obj[InvIndex].Description();
            do
            {
                
                Console.SetCursorPosition(0, 10);
                if (selectPosition == 0)
                    Console.WriteLine("<Take this item>\n Go Back ");
                else
                    Console.WriteLine(" Take this item \n<Go Back>");
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.UpArrow && selectPosition != 0)
                    selectPosition--;
                else if (keyinfo.Key == ConsoleKey.DownArrow && selectPosition != 1)
                    selectPosition++;

            } while (keyinfo.Key != ConsoleKey.Enter);
            if (selectPosition == 0)
                return true;
            else
                return false;
        }

        public bool ShowInventoryMenu()
        {
            if (inventory.Count > 0)
            {
                int selectPosition = 0;
                Objects[] obj = inventory.Values.ToArray();
                ConsoleKeyInfo keyinfo;
                do
                {
                    Console.Clear();
                    for (int i = 0; i < inventory.Count; i++)
                    {
                        if (i == selectPosition)
                            Console.WriteLine("<{0}>", obj[i].GetName());
                        else
                            Console.WriteLine(" {0} ", obj[i].GetName());
                    }
                    Console.WriteLine("\n\n");
                    obj[selectPosition].Description();
                    keyinfo = Console.ReadKey();
                    if (keyinfo.Key == ConsoleKey.DownArrow && selectPosition != inventory.Count - 1)
                        selectPosition++;
                    else if (keyinfo.Key == ConsoleKey.UpArrow && selectPosition != 0)
                        selectPosition--;

                } while (keyinfo.Key != ConsoleKey.E && keyinfo.Key != ConsoleKey.Escape);


                return true;
            }
            else
            {
                return (false);
            }
                
                
            
        }

        public bool HasObject(string name)
        {
            if (inventory.ContainsKey(name))
                return true;
            else
                return false;
        }

        
        
    }
}
