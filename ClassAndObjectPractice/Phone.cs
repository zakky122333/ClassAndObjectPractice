using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectPractice
{
    internal class Phone
    {
        public string colour;
        public string brand;
        public int storage;

        // this is a constructor
        public Phone(string aColour, string aBrand, int aStorage) //this is where the arguments go
        {
            this.colour = aColour;
            this.brand = aBrand;
            this.storage = aStorage;
        }

        // this is an object method
        public bool HasEnoughStorage()
        {
            if (this.storage >= 32)
            {
                return true;
            }
            return false;
        }
    }
}
