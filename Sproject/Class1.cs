using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sproject
{
    internal class Car
    {
        public double price;
        public string color;
        public string merk;
        public string type;
        public int doors;
        public string picture;


        public Car(double price, string color, string merk, string type, int doors, string picture)
        {
            this.price = price;
            this.color = color;
            this.merk = merk;
            this.type = type;
            this.doors = doors;
            this.picture = picture;
        }
        public string geefNaam()
        {
            return $"{this.merk} {this.type}";
        }
        public bool heeftAfbeelding()
        {
            return picture != String.Empty;
        }
        public void updateVraagprijs(double new_price)
        {
            this.price = new_price;
        }
        public double toonVraagprijs()
        {
            return this.price;
        }
        override public string ToString()
        {
            return this.geefNaam();
        }
    }



}
