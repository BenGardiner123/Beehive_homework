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
          Beehive h1 = new Beehive(8, "Hive 1");
          Beehive h2 = new Beehive(10, "Hive 2");
          
          //instatiate using the maxbees overload
          Beehive h3 = new Beehive(8, "Hive 3");
        

          //mthods to add bees 
          h1.addBeetoList(b1);
          h1.addBeetoList(b2);
          h1.addBeetoList(b3);
          h1.addBeetoList(b4);
          h2.addBeetoList(b5);
          h2.addBeetoList(b6);
          h2.addBeetoList(b7);


          //run the collect honey method
          h1.collectHoney(5);
          h2.collectHoney(8);
          
          //count the bees in the hive
          h1.numBeesHive();
          h2.numBeesHive();
          Console.ReadKey();


        }
    }


}
