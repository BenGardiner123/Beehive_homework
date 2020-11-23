using c__offlineHomework_S2;

namespace Beehive_homework
{
    public class QueenBee : Bee
    {
        public QueenBee(string name, float size) : base(name, size)
        {
            this.beeSize = 0.1f;
        }

        public Bee MakeBee(string name){
            Bee newBee = new Bee();
            newBee.beeSize = 0.1f;
            newBee.Name = name;
            return newBee;

        }


    }


    
}