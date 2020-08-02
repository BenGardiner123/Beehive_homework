using System;
using System.Collections.Generic;

namespace c__offlineHomework_S2
{
    class Program
    {
        static void Main(string[] args)
        {

          //instatiate the bees
          Bee b1 = new Bee ("John" , 3.2F);
          Bee b2 = new Bee ("Paul" , 2.7F);
          Bee b3 = new Bee ("Ringo" , 1.1F);
          Bee b4 = new Bee ("George" , 2.0F);
          Bee b5 = new Bee ("Kurt" , 2.3F);
          Bee b6 = new Bee ("Dave" , 7.4F);
          Bee b7 = new Bee ("Krist" , 1.5F);

          //instatiate the hives using the default ctor
          Beehive h1 = new Beehive();
          Beehive h2 = new Beehive();
          
          //instatiate using the maxbees overload
          Beehive h3 = new Beehive(8);
          
          //use this method to instatiate the beelist
          h1.createBeeList();

          //mthods to add bees and collect the honey
          h1.addBeetoList(b1);
          h1.addBeetoList(b2);
          h1.addBeetoList(b3);
          h1.addBeetoList(b4);

          h1.collectHoney(5);
          
          h1.numBeesHive();
          


        }
    }


}
