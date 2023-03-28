using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMN
{
    internal class Player
    {
        public string item { get; set; }
        public string name { get; set; }

        public Player()
        {
            Random random= new Random();
            int rnd = random.Next(1, 3);
            if (rnd == 1)
                item = "бумага";
            if (rnd == 2)
                item = "ножницы";
            if (rnd == 3)
                item = "камень";
            name= "Боб";
        }
        public Player(string item, string name)
        {
            this.item = item;
            this.name = name;
        }

        public void randomItem()
        {
            Random random = new Random();
            int rnd = random.Next(1, 3);
            if (rnd == 1)
                item = "бумага";
            if (rnd == 2)
                item = "ножницы";
            if (rnd == 3)
                item = "камень";
        }
    }
}
