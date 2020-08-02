using System;
using System.Collections.Generic;
using System.Reflection;

namespace c__offlineHomework_S2

{
    public class  Beehive 
    {
        public List<Bee> beeList;
        public int maxbees;

        ///-.!---.!---.!---.!---.!-- Constructor .!---.!---.!---.!--///
        public Beehive()
        {
            
        }

        public Beehive(int maxbees)
        {
            this.maxbees = maxbees;
        }

        ///.!---.!---.!---.!--- MEthods .!---.!---.!---///

        public void createBeeList() 
        {
            this.beeList = new List<Bee>();
        }

        public void addBeetoList(Bee newBee)
        {
            this.beeList.Add(newBee);
        }

         public void collectHoney(int days)
        {  
            float Amount = 0.0F;

            //get each bees size and add a running totoal to amount
            foreach (var bee in beeList)
            {
                Amount = Amount + days * bee.beeSize * 0.2F;
            }
        

            
            Console.WriteLine($"Your hive collected {Amount} of honey");
        }

        public void numBeesHive()
        {
            int counter = 0;
            for (int i = 0; i < this.beeList.Count; i++)
            {
               counter++; 
            }

            Console.WriteLine($"This beehive has {counter} bees in it!");
        }   

    }


}
