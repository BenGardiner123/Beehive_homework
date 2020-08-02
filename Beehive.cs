using System;
using System.Collections.Generic;
using System.Reflection;

namespace c__offlineHomework_S2

{
    public class  Beehive 
    {
        public List<Bee> beeList;
        public int maxbees;
        public string name; 

        ///-.!---.!---.!---.!---.!-- Constructor .!---.!---.!---.!--///
        public Beehive()
        {
            
        }

        public Beehive(int maxbees, string name)
        {
            this.maxbees = maxbees;
            this.name = name;
            this.beeList = new List<Bee>();
        }

        ///.!---.!---.!---.!--- MEthods .!---.!---.!---///

        
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

            Console.WriteLine($"{this.name} collected {Amount} of honey");
        }


        public void numBeesHive()
        {
            
            int counter = 0;
            for (int i = 0; i < this.beeList.Count; i++)
            {
               counter++; 
            }

            Console.WriteLine($"{this.name} has {counter} bees in it!");
        }   

    }


}
