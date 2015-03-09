using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    abstract class Location
    {
        public bool firstime;
        public bool specificAction;
        protected Actor actor;
        protected string name;
        protected int width;
        protected int length;
        protected bool hasPeople;
        protected Dictionary<string, Objects> items;

        public Location(string name)
        {
            this.name = name;
            hasPeople = false;
            items = new Dictionary<string, Objects>();
        }

        abstract public void Description();

        public virtual string GetName()
        {
            return name;
        }

        public virtual bool HasPeople()
        {
            return hasPeople;
        }

        public virtual bool CheckForItems()
        {
            if (items.Count() == 0)
                return false;
            else
                return true;
        }

        public Dictionary<string, Objects> GetItems()
        {
            return items;
        }
        public Actor GetActor()
        {
            return actor;
        }
    }
}
