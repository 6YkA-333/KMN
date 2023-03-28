using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMN
{
    internal class Processing
    {
        private Player BotResult;
        private Player PlResult;
        private int result = 0;


        public Processing()
        {
            BotResult = new Player();
            PlResult = new Player("---", "Player");
        }
        public Processing(string Plres, string Plname)
        {
            BotResult= new Player();
            PlResult= new Player(Plres, Plname);
        }

        public void BotRnd()
        {
            BotResult.randomItem();
        }
        public void Set_Pl_Itm(string itm)
        {
            PlResult.item = itm;
        }
        public void Set_Pl_Name(string nm)
        {
            PlResult.name = nm;
        }
        public string Get_Pl_Itm()
        {
            return PlResult.item;
        }
        public string Get_Bot_Itm()
        {
            return BotResult.item;
        }
        public string Get_Pl_Name()
        {
            return PlResult.name;
        }
        public string Get_Bot_Name()
        {
            return BotResult.name;
        }


        public int gaming()
        {
            result= 0;

            if (PlResult.item == "ножницы" && BotResult.item == "бумага")
                result= 1;
            if (PlResult.item == "камень" && BotResult.item == "ножницы")
                result = 1;
            if (PlResult.item == "бумага" && BotResult.item == "камень")
                result = 1;

            if (PlResult.item == "ножницы" && BotResult.item == "камень")
                result = 0;
            if (PlResult.item == "камень" && BotResult.item == "бумага")
                result = 0;
            if (PlResult.item == "бумага" && BotResult.item == "ножницы")
                result = 0;

            if (PlResult.item == "бумага" && BotResult.item == "бумага")
                result = 2;
            if (PlResult.item == "ножницы" && BotResult.item == "ножницы")
                result = 2;
            if (PlResult.item == "камень" && BotResult.item == "камень")
                result = 2;

            return result;
        }


    }
}
