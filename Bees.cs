using System;
using System.Collections.Generic;


namespace c__offlineHomework_S2
{
    
    public class Bee
    {
       public string Name; 
       public float beeSize;

        public Bee()
        {
            
        }

        public Bee(string name, float size)
        {
            this.Name = name;
            this.beeSize = size;
        }

        public float getBeeSzie(){
            return this.beeSize;
        }



    }

    


}
